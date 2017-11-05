using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Minecraft
{
	class FormUtils
	{
		public static void AddAll<T>(ComboBox combo, List<T> list)
		{
			foreach (T obj in list)
			{
				PropertyInfo prop = typeof(T).GetProperty("Id");
				if ((long)prop.GetValue(obj) == 0)
				{
					continue;
				}
				combo.Items.Add(obj);
			}
			if (combo.Items.Count > 0)
			{
				combo.SelectedIndex = 0;
			}
		}
	}
}
