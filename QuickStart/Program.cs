using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls.UI;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Text;

namespace Telerik.QuickStart.WinControls
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main(string[] args)
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
	}
}