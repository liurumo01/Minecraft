using System.Collections;

namespace Minecraft
{
	class Data
	{

		private static Hashtable data = new Hashtable();

		public static void Set(string key, object value)
		{
			data[key] = value;
		}

		public static object Get(string key)
		{
			return data[key];
		}

		public static object Remove(string key)
		{
			object value = data[key];
			data[key] = null;
			return value;
		}

	}
}
