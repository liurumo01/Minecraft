using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Minecraft
{
	class ShopRecordDAO : BaseDAO<ShopRecordBean>
	{

		public List<ShopRecordBean> GetAll(DateTime start, DateTime end, PlayerBean player, WorldBean world)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "select r.id as record_id, r.amount as record_amount, r.type as record_type, r.time as record_time, i.first_id as item_first_id, i.second_id as item_second_id, i.name as item_name, i.english_name as item_english_name, i.price as item_price, i.group_amount as item_group_amount from tb_shop_record r left join tb_shop_item i on r.item_first_id = i.first_id and r.item_second_id = i.second_id where r.player_id = @playerId and r.world_id = @worldId and r.time > @startTime and r.time < @endTime order by r.time desc";
			cmd.Parameters.AddWithValue("@playerId", player.Id);
			cmd.Parameters.AddWithValue("@worldId", player.Id);
			cmd.Parameters.AddWithValue("@startTime", start);
			cmd.Parameters.AddWithValue("@endTime", end);
			MySqlDataReader reader = cmd.ExecuteReader();
			List<ShopRecordBean> records = new List<ShopRecordBean>();
			while (reader.Read())
			{
				ShopRecordBean record = new ShopRecordBean
				{
					Id = reader.GetInt64("record_id"),
					PlayerId = player.Id,
					WorldId = world.Id,
					ItemFirstId = reader.GetInt32("item_first_id"),
					ItemSecondId = reader.GetInt32("item_second_id"),
					ItemName = reader.GetString("item_name"),
					Amount = reader.GetInt32("record_amount"),
					Type = reader.GetInt32("record_type"),
					Time = reader.GetDateTime("record_time")
				};
				records.Add(record);
			}
			reader.Close();
			DBUtils.CloseConnection(conn);
			return records;
		}
	}
}
