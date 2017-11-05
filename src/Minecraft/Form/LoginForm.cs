using System.Windows.Forms;

namespace Minecraft
{
	public partial class LoginForm : Form
	{

		private PlayerDAO playerDAO = new PlayerDAO();
		private WorldDAO worldDAO = new WorldDAO();
		private BankAccountDAO bankAccountDAO = new BankAccountDAO();

		public LoginForm()
		{
			InitializeComponent();
			FormUtils.AddAll(comboBoxSelectPlayer, playerDAO.GetAll());
			FormUtils.AddAll(comboBoxSelectWorld, worldDAO.GetAll());
		}

		private void ButtonEnterWorld_Click(object sender, System.EventArgs e)
		{
			PlayerBean player = (PlayerBean)comboBoxSelectPlayer.SelectedItem;
			WorldBean world = (WorldBean)comboBoxSelectWorld.SelectedItem;
			BankAccountBean account = bankAccountDAO.GetByPlayerIdAndWorldId(player.Id, world.Id);
			if (player == null)
			{
				MessageBox.Show("请选择玩家");
				return;
			}
			if (world == null)
			{
				MessageBox.Show("请选择世界");
				return;
			}
			if (account == null)
			{
				account = new BankAccountBean()
				{
					PlayerId = player.Id,
					WorldId = world.Id
				};
				bankAccountDAO.Insert(account);
			}
			Data.Set("player", player);
			Data.Set("world", world);
			Data.Set("account", account);
			Data.Set("system_account", bankAccountDAO.GetById(0));
			Data.Set("form", new MainForm());
			Dispose();
		}

		private void ButtonCreateWorld_Click(object sender, System.EventArgs e)
		{
			if (comboBoxSelectWorld.Text.Length == 0)
			{
				MessageBox.Show("世界名称不能为空");
				return;
			}
			WorldBean world = new WorldBean
			{
				Name = comboBoxSelectWorld.Text
			};
			int result = worldDAO.Insert(world);
			if (result > 0)
			{
				MessageBox.Show("创建成功");
				comboBoxSelectWorld.Items.Add(world);
				comboBoxSelectWorld.SelectedItem = world;
			}
			else
			{
				MessageBox.Show("创建失败");
			}
		}

		private void ButtonCreatePlayer_Click(object sender, System.EventArgs e)
		{
			if (comboBoxSelectPlayer.Text.Length == 0)
			{
				MessageBox.Show("玩家名称不能为空");
				return;
			}
			PlayerBean player = new PlayerBean
			{
				Name = comboBoxSelectPlayer.Text
			};
			int result = playerDAO.Insert(player);
			if (result > 0)
			{
				MessageBox.Show("创建成功");
				comboBoxSelectPlayer.Items.Add(player);
				comboBoxSelectPlayer.SelectedItem = player;
			}
			else
			{
				MessageBox.Show("创建失败");
			}
		}
	}
}
