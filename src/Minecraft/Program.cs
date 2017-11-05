using System;
using System.Windows.Forms;

namespace Minecraft
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Data.Set("form", new LoginForm());
			while (Data.Get("form") != null)
			{
				Form form = (Form)Data.Remove("form");
				Application.Run(form);
			}
		}
	}
}
