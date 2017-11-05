using System.Text;

namespace Minecraft
{
	class StringUtils
	{

		public static string CamelCaseToUnderline(string str)
		{
			StringBuilder b = new StringBuilder(str);
			for (int i = 1; i < b.Length; i++)
			{
				if (char.IsUpper(b[i]))
				{
					b.Replace(b[i].ToString(), "_" + b[i], i, 1);
					i++;
				}
			}
			return b.ToString().ToLower();
		}

	}
}
