using System;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Editors.FirstLook
{
    /// <summary>
    /// example form         
    /// </summary>
	public partial class Form1 : EditorExampleBaseForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();
            this.SetTheme();
		}

        void radPanelDemoHolder_SizeChanged(object sender, EventArgs e)
        {

        }

        private void SetTheme()
        {
            this.radTxtDemo1.ThemeName = THEME;
            this.radTxtDemo2.ThemeName = THEME;
            this.radTxtNullText.ThemeName = THEME;
            this.radCheckCancel.ThemeName = THEME;
            this.radGroupMulti.ThemeName = THEME;
            this.radGroupNull.ThemeName = THEME;
            this.radLblNewValue.ThemeName = THEME;
            this.radLblNulltext.ThemeName = THEME;
            this.radLblOldValue.ThemeName = THEME;
            this.radLabel1.ThemeName = THEME;
            this.radLabel2.ThemeName = THEME;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			radTxtDemo1.NullText = this.radTxtNullText.Text;
		}

		private void radTextBox2_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
		{
			e.Cancel = this.radCheckCancel.Checked;            
			this.radLblOldValue.Text = "Old Value: " + e.OldValue;
			this.radLblNewValue.Text = "New Value: " + e.NewValue;
		}

        private void radTxtNullText_TextChanged(object sender, EventArgs e)
        {
            radTxtDemo1.NullText = this.radTxtNullText.Text;
            radTxtDemo2.NullText = this.radTxtNullText.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radTxtDemo2.AcceptsReturn = true;
        }
	}
}