using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft
{
	public partial class ShopHistoryForm : Form
	{
		private PlayerBean player = (PlayerBean)Data.Get("player");
		private WorldBean world = (WorldBean)Data.Get("world");
		private ShopRecordDAO shopHistoryDAO = new ShopRecordDAO();

		public ShopHistoryForm()
		{
			InitializeComponent();
			dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
			dateTimePickerStartTime.Value = DateTime.Today;
			dateTimePickerEndTime.Format = DateTimePickerFormat.Custom;
			dateTimePickerEndTime.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			DateTime start = dateTimePickerStartTime.Value;
			DateTime end = dateTimePickerEndTime.Value;
			List<ShopRecordBean> records = shopHistoryDAO.GetAll(start, end, player, world);
			listBoxShopHistory.Items.Clear();
			foreach (ShopRecordBean record in records)
			{
				listBoxShopHistory.Items.Add(record);
			}
		}
	}
}
