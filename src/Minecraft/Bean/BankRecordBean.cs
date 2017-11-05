using System;

namespace Minecraft
{
	class BankRecordBean
	{
		public long Id { get; set; }
		public BankAccountBean Account { get; set; }
		public int Amount { get; set; }
		public int Type { get; set; }
		public DateTime Time { get; set; }
		public string Note { get; set; }

	}
}
