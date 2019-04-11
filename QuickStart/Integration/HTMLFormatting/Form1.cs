using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Integration.HTMLFormatting
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            this.radListBox1.ThemeName = "ControlDefault";
            this.radRadioButton1.ThemeName = "ControlDefault";
            this.radCheckBox1.ThemeName = "ControlDefault";
            this.radTextBox1.ThemeName = "ControlDefault";
            this.radButton1.ThemeName = "ControlDefault";
            this.radToggleButton1.ThemeName = "ControlDefault";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radTextBox1.Text = this.radLabel1.Text;
            this.radButton2.Click += new EventHandler(radButton2_Click);
            this.radTextBox1.Text = "<html><p><span style=\"font-size: large\">RadLabel</span></p><p><span style=\"font-size: medium\"><strong>Arial, Bold</strong></span></p><p><span style=\"font-size: small\"><em><span style=\"font-family: times new roman\">Times, Italic, <u>Underline</u></span></em></span></p><p><em><span style=\"font-family: times new roman; color: #0080ff; font-size: 18pt\">Sample Text</span></em></p></html>";
        }

        void radButton2_Click(object sender, EventArgs e)
        {
            using (RadMarkupDialog dialog = new RadMarkupDialog())
            {
                dialog.Value = this.radTextBox1.Text;

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.radTextBox1.Text = dialog.Value;
                }
            }      
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.radLabel1.Text = this.radTextBox1.Text;
        }        
    }
}