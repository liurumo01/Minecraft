using System;

namespace Minecraft
{
	class ShopRecordBean
	{

		public long Id { get; set; }
		public long PlayerId { get; set; }
		public long WorldId { get; set; }
		public int ItemFirstId { get; set; }
		public int ItemSecondId { get; set; }
		[DatabaseInsertIgnoreAttribute]
		public string ItemName { get; set; }
		public int Amount { get; set; }
		public int Type { get; set; }
		public DateTime Time { get; set; }

		public override string ToString()
		{
			return string.Format("{0} | [{1}#{2}]{3} | {4} | {5} | {6}", Id, ItemFirstId, ItemSecondId, ItemName, Amount, Type < 0 ? "购买" : "出售", Time);
		}

	}
}
