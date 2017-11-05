using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft
{
	public partial class BankRecordForm : Form
	{

		private BankAccountRecordDAO bankAccountRecordDAO = new BankAccountRecordDAO();

		private BankAccountBean account = (BankAccountBean)Data.Get("account");

		public BankRecordForm()
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
			List<BankAccountRecordBean> records = bankAccountRecordDAO.GetAll(start, end, account);
			listBoxBankHistory.Items.Clear();
			foreach (BankAccountRecordBean record in records)
			{
				listBoxBankHistory.Items.Add(record);
			}
		}
	}
}
