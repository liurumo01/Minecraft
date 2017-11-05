using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Minecraft
{
	class ShopItemDAO : BaseDAO<ShopItemBean>
	{
		public List<ShopItemBean> Search(string search)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "select * from tb_shop_item where name like @search or english_name like @search";
			if (search.Length == 0)
			{
				search = "%";
			}
			else
			{
				search = "%" + search + "%";
			}
			cmd.Parameters.AddWithValue("@search", search);
			MySqlDataReader reader = cmd.ExecuteReader();
			List<ShopItemBean> items = new List<ShopItemBean>();
			while (reader.Read())
			{
				ShopItemBean shopItem = new ShopItemBean
				{
					FirstId = reader.GetInt32("first_id"),
					SecondId = reader.GetInt32("second_id"),
					Name = reader.GetString("name"),
					EnglishName = reader.GetString("english_name"),
					Price = reader.GetInt32("price"),
					GroupAmount = reader.GetInt32("group_amount")
				};
				items.Add(shopItem);
			}
			reader.Close();
			DBUtils.CloseConnection(conn);
			return items;
		}
	}
}
