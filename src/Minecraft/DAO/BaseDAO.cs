using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Minecraft
{
	class BaseDAO<T>
	{

		protected Type TargetType
		{
			get
			{
				return typeof(T);
			}
		}

		protected string TableName
		{
			get
			{
				return "tb_" + StringUtils.CamelCaseToUnderline(typeof(T).Name.Replace("Bean", ""));
			}
		}

		protected const int VARCHAR_DEFAULT_LENGTH = 1024;

		protected List<object[]> fields;

		public BaseDAO()
		{
			fields = new List<object[]>();
			PropertyInfo[] p = TargetType.GetProperties();
			foreach (PropertyInfo property in p)
			{
				String fieldName = property.Name;
				String columnName = StringUtils.CamelCaseToUnderline(fieldName);
				Type csType = property.PropertyType;
				if (!IsBasicType(csType))
				{
					continue;
				}
				String dbType = null;
				if (csType == typeof(int) || csType == typeof(long))
				{
					dbType = "int";
				}
				else if (csType == typeof(float) || csType == typeof(double))
				{
					dbType = "double";
				}
				else if (csType == typeof(string))
				{
					dbType = "varchar(" + VARCHAR_DEFAULT_LENGTH + ")";
				}
				else if (csType == typeof(DateTime))
				{
					dbType = "timestamp";
				}
				if (dbType == null)
				{
					continue;
				}
				object[] arr = { property, fieldName, columnName, csType, dbType };
				fields.Add(arr);
			}
		}

		public int Insert(T obj)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetInsertSQL();
			//List<string> values = new List<string>();
			int index = -1;
			for (int i = 0; i < fields.Count; i++)
			{
				PropertyInfo prop = (PropertyInfo)(fields[i][0]);
				if (prop.GetCustomAttribute(typeof(DatabaseInsertIgnoreAttributeAttribute)) != null)
				{
					continue;
				}
				object value = prop.GetValue(obj);
				//values.Add(value.ToString());
				cmd.Parameters.AddWithValue("@" + fields[i][1], value);
				if ((fields[i][1]).Equals("Id"))
				{
					index = i;
				}
			}
			int result = cmd.ExecuteNonQuery();
			((PropertyInfo)fields[index][0]).SetValue(obj, cmd.LastInsertedId);
			DBUtils.CloseConnection(conn);
			return result;
		}

		public int Delete(long id)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetDeleteSQL();
			cmd.Parameters.AddWithValue("@id", id);
			int result = cmd.ExecuteNonQuery();
			DBUtils.CloseConnection(conn);
			return result;
		}

		public int Update(T obj)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetUpdateSQL();
			//List<string> values = new List<string>();
			for (int i = 0; i < fields.Count; i++)
			{
				object value = ((PropertyInfo)fields[i][0]).GetValue(obj);
				//values.Add(value.ToString);
				cmd.Parameters.AddWithValue("@" + fields[i][1], value);
			}
			int result = cmd.ExecuteNonQuery();
			DBUtils.CloseConnection(conn);
			return result;
		}

		public T GetById(long id)
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetSelectSQL();
			cmd.Parameters.AddWithValue("@id", id);
			MySqlDataReader reader = cmd.ExecuteReader();
			if (!reader.Read())
			{
				return default(T);
			}
			T obj = (T)TargetType.GetConstructor(new Type[0]).Invoke(new object[0]);
			//List<String> values = new List<>();
			foreach (object[] arr in fields)
			{
				object value = reader[(string)arr[2]];
				((PropertyInfo)arr[0]).SetValue(obj, value);
				//values.add(value.toString());
			}
			DBUtils.CloseConnection(conn);
			return obj;
		}

		public List<T> GetAll()
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetSelectAllSQL();
			MySqlDataReader reader = cmd.ExecuteReader();
			List<T> result = new List<T>();
			while (reader.Read())
			{
				T obj = (T)TargetType.GetConstructor(new Type[0]).Invoke(new object[0]);
				//List<String> values = new List<>();
				foreach (object[] arr in fields)
				{
					object value = reader[(string)arr[1]];
					((PropertyInfo)arr[0]).SetValue(obj, value);
					//values.add(value.toString());
				}
				result.Add(obj);
			}
			DBUtils.CloseConnection(conn);
			return result;
		}

		public long Count()
		{
			MySqlConnection conn = DBUtils.GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = GetCountSQL();
			MySqlDataReader reader = cmd.ExecuteReader();
			if (!reader.Read())
			{
				return -1;
			}
			long result = (long)reader[0];
			DBUtils.CloseConnection(conn);
			return result;
		}

		protected string GetInsertSQL()
		{
			StringBuilder b = new StringBuilder();
			b.Append("insert into ").Append(TableName).Append(" (");
			foreach (object[] arr in fields)
			{
				if (((PropertyInfo)arr[0]).GetCustomAttribute(typeof(DatabaseInsertIgnoreAttributeAttribute)) != null)
				{
					continue;
				}
				b.Append(arr[2]).Append(", ");
			}
			b.Remove(b.Length - 2, 2);
			b.Append(") values (");
			for (int i = 0; i < fields.Count; i++)
			{
				if (((PropertyInfo)fields[i][0]).GetCustomAttribute(typeof(DatabaseInsertIgnoreAttributeAttribute)) != null)
				{
					continue;
				}
				b.Append("@" + fields[i][1]).Append(", ");
			}
			b.Remove(b.Length - 2, 2);
			b.Append(")");
			return b.ToString();
		}

		protected string GetDeleteSQL()
		{
			return "delete from " + TableName + " where id = @id";
		}

		protected string GetUpdateSQL()
		{
			StringBuilder b = new StringBuilder();
			b.Append("update ").Append(TableName).Append(" set ");
			foreach (object[] arr in fields)
			{
				if (arr[2].Equals("Id"))
				{
					continue;
				}
				b.Append(arr[2]).Append(" = @").Append(arr[1]).Append(", ");
			}
			b.Remove(b.Length - 2, 2);
			b.Append(" where id = @Id");
			return b.ToString();
		}

		protected string GetSelectSQL()
		{
			return GetSelectAllSQL() + " where id = @Id";
		}

		protected string GetSelectAllSQL()
		{
			StringBuilder b = new StringBuilder();
			b.Append("select ");
			foreach (object[] arr in fields)
			{
				b.Append(arr[2]).Append(", ");
			}
			b.Remove(b.Length - 2, 2);
			b.Append(" from ").Append(TableName);
			return b.ToString();
		}

		protected string GetCountSQL()
		{
			return "select count(*) from " + TableName;
		}

		protected bool IsBasicType(Type type)
		{
			List<Type> list = new List<Type>() { typeof(int), typeof(long), typeof(float), typeof(double), typeof(string), typeof(DateTime) };
			return list.Contains(type);
		}

	}
}
