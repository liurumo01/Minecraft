using System;

namespace Minecraft
{
	class BankAccountRecordBean
	{

		public long Id { get; set; }
		public long Src { get; set; }
		public long Dest { get; set; }
		public double Amount { get; set; }
		public DateTime Time { get; set; }
		public string Note { get; set; }

	}
}
