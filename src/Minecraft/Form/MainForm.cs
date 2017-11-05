using System;
using System.Windows.Forms;

namespace Minecraft
{
	public partial class MainForm : Form
	{

		private PlayerBean player;
		private WorldBean world;
		private BankAccountBean account;

		public MainForm()
		{
			InitializeComponent();
			player = (PlayerBean)Data.Get("player");
			world = (WorldBean)Data.Get("world");
			account = (BankAccountBean)Data.Get("account");
		}

		private void 余额ToolStripMenuItem_Click(object sender, EventArgs e)
		{

			MessageBox.Show("账户余额：" + account.Balance.ToString());
		}

		private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShopItemForm shopItemForm = new ShopItemForm();
			shopItemForm.MdiParent = this;
			shopItemForm.Show();
		}

		private void 历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShopHistoryForm shopHistoryForm = new ShopHistoryForm();
			shopHistoryForm.MdiParent = this;
			shopHistoryForm.Show();
		}
	}
}
