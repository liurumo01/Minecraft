namespace Minecraft
{
	class ShopItemBean
	{

		public int FirstId { get; set; }
		public int SecondId { get; set; }
		public string Name { get; set; }
		public string EnglishName { get; set; }
		public int Price { get; set; }
		public int GroupAmount { get; set; }
		public int GroupPrice { get { return Price * GroupAmount; } }

		public override string ToString()
		{
			return string.Format("[{0}#{1}]{2}", FirstId, SecondId, Name);
		}

	}
}
