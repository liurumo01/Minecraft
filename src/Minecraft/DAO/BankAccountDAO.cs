using MySql.Data.MySqlClient;
using System.Reflection;

namespace Minecraft
{
	class BankAccountDAO : BaseDAO<BankAccountBean>
	{
		public BankAccountBean GetByPlayerIdAndWorldId(long playerId, long worldId)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetSelectAllSQL() + " where player_id = @playerId and world_id = @worldId";
			cmd.Parameters.AddWithValue("@playerId", playerId);
			cmd.Parameters.AddWithValue("@worldId", worldId);
			MySqlDataReader reader = cmd.ExecuteReader();
			if (!reader.Read())
			{
				return null;
			}
			BankAccountBean account = new BankAccountBean();
			//List<String> values = new List<>();
			foreach (object[] arr in fields)
			{
				object value = reader[StringUtils.CamelCaseToUnderline((string)arr[1])];
				((PropertyInfo)arr[0]).SetValue(account, value);
				//values.add(value.toString());
			}
			DBUtils.CloseConnection(conn);
			return account;
		}
	}
}
