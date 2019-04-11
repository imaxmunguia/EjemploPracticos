using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.RichTextBox.Editor
{
    public partial class Form1 : Form
    {
        private static readonly string ExternalPath = Path.GetDirectoryName(Application.ExecutablePath) +
                                                      "\\..\\..\\TelerikEditor\\bin\\TelerikEditor.exe";

        public Form1()
        {
            InitializeComponent();
            Process.Start(new ProcessStartInfo(ExternalPath));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Close();
        }
    }
}
