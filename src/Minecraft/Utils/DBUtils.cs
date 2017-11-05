using MySql.Data.MySqlClient;

namespace Minecraft
{
	class DBUtils
	{

		private static string connectionString = "Server=127.0.0.1;UserId=snowwolf;Password=snowwolf;Database=minecraft";
		//private static string connectionString = "Server=123.57.218.103;UserId=snowwolf;Password=snowwolf;Database=minecraft";

		public static bool InTransaction { get { return transaction != null; } }
		private static MySqlConnection conn = null;
		private static MySqlTransaction transaction = null;

		public static MySqlConnection GetConnection()
		{
			MySqlConnection c = InTransaction ? conn : new MySqlConnection(connectionString);
			if (c.State != System.Data.ConnectionState.Open)
			{
				c.Open();
			}
			return c;
		}

		public static void BeginTransaction()
		{
			conn = GetConnection();
			transaction = conn.BeginTransaction();
		}

		public static void Commit()
		{
			transaction.Commit();
			transaction = null;
		}

		public static void Rollback()
		{
			transaction.Rollback();
			transaction = null;
		}

		public static void CloseConnection(MySqlConnection conn)
		{
			if (transaction == null)
			{
				if (conn == null && DBUtils.conn != null)
				{
					conn = DBUtils.conn;
				}
				conn.Close();
			}
		}

	}
}
