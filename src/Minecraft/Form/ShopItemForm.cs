using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft
{
	public partial class ShopItemForm : Form
	{

		private PlayerBean player = (PlayerBean)Data.Get("player");
		private WorldBean world = (WorldBean)Data.Get("world");
		private BankAccountBean account = (BankAccountBean)Data.Get("account");
		private BankAccountBean system = (BankAccountBean)Data.Get("system_account");

		private ShopItemDAO shopItemDAO = new ShopItemDAO();
		private PlayerDAO playerDAO = new PlayerDAO();
		private ShopRecordDAO shopRecordDAO = new ShopRecordDAO();
		private BankAccountDAO bankAccountDAO = new BankAccountDAO();
		private BankAccountRecordDAO bankAccountRecordDAO = new BankAccountRecordDAO();

		public ShopItemForm()
		{
			InitializeComponent();
			textBoxPlayerMoney.Text = account.Balance.ToString();
			comboBoxAmount.Items.Add("个");
			comboBoxAmount.Items.Add("组");
			comboBoxAmount.SelectedIndex = 1;
		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			listBoxShopItems.Items.Clear();
			List<ShopItemBean> shopItems = shopItemDAO.Search(textBoxSearch.Text);
			foreach (ShopItemBean shopItem in shopItems)
			{
				listBoxShopItems.Items.Add(shopItem);
			}
		}

		private void ListBoxShopItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxShopItems.SelectedIndex < 0)
			{
				return;
			}
			ShopItemBean shopItem = (ShopItemBean)listBoxShopItems.SelectedItem;
			textBoxShopItemInfo.Text = string.Format("序号：{0} # {1}\r\n名称：{2}\r\n英文名称：{3}\r\n单价：{4}\r\n每组数量：{5}\r\n每组价格：{6}\r\n",
				shopItem.FirstId, shopItem.SecondId, shopItem.Name, shopItem.EnglishName, shopItem.Price, shopItem.GroupAmount, shopItem.GroupPrice);
		}

		private void ButtonBuy_Click(object sender, EventArgs e)
		{
			Trade(-1);
		}

		private void ButtonSell_Click(object sender, EventArgs e)
		{
			Trade(1);
		}

		private void Trade(int mode)
		{
			ShopItemBean shopItem = (ShopItemBean)listBoxShopItems.SelectedItem;
			if (shopItem == null)
			{
				MessageBox.Show("未选择任何条目");
				return;
			}
			int amount;
			try
			{
				amount = int.Parse(textBoxAmount.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("数量输入不正确");
				return;
			}
			if (comboBoxAmount.SelectedItem.Equals("组"))
			{
				amount = amount * shopItem.GroupAmount;
			}
			int price = shopItem.Price * amount;
			if (mode < 0 && price > account.Balance)
			{
				MessageBox.Show("账户余额不足");
				return;
			}
			DialogResult result = MessageBox.Show(string.Format("确认要{0}吗？", mode < 0 ? "买入" : "卖出"), "确认交易", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				account.Balance += (price * mode);
				system.Balance -= (price * mode);
				ShopRecordBean shopRecord = new ShopRecordBean
				{
					PlayerId = player.Id,
					WorldId = world.Id,
					ItemFirstId = shopItem.FirstId,
					ItemSecondId = shopItem.SecondId,
					ItemName = shopItem.Name,
					Amount = amount,
					Type = mode,
					Time = DateTime.Now
				};

				BankAccountRecordBean bankRecord = new BankAccountRecordBean
				{
					Src = mode > 0 ? 0 : account.Id,
					Dest = mode > 0 ? account.Id : 0,
					Amount = amount,
					Time = DateTime.Now,
					Note = "系统商店"
				};

				DBUtils.BeginTransaction();
				if (bankAccountDAO.Update(account) > 0 && bankAccountDAO.Update(system) > 0 && shopRecordDAO.Insert(shopRecord) > 0 && bankAccountRecordDAO.Insert(bankRecord) > 0)
				{
					textBoxPlayerMoney.Text = account.Balance.ToString();
					DBUtils.Commit();
					DBUtils.CloseConnection(null);
				}
				else
				{
					DBUtils.Rollback();
				}

			}
		}

	}
}
