﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Telerik.WinControls;
using System.IO;

namespace Telerik.Examples.WinControls.Integration.BugTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string executablePath = Application.StartupPath + @"\..\..\BugTracker\Bin\BugTracker.exe";
            if (File.Exists(executablePath))
            {
                ProcessStartInfo proc = new ProcessStartInfo(executablePath);
                proc.WorkingDirectory = Path.GetDirectoryName(executablePath);
                Process.Start(proc);
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Close();
        }
    }
}
