using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Buttons.SplitButton
{
	/// <summary>
	/// Main class for the split button example
	/// </summary>
    public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();
            SetTheme();
			this.SelectedControl = radSplitButton3;
		}

        private void SetTheme()
        {
            this.radButton1.ThemeName = "ControlDefault";
            this.radSplitButton3.ThemeName = "ControlDefault";
        }

		private RadElement rotatedElement;

        private void Form1_Load(object sender, EventArgs e)
        {			
			rotatedElement = radButton1.RootElement.Children[0];
            this.radButton1.AutoSize = true;
			SetDefaultItem(radMenuItem1);
        }

		private void radMenuItem1_Click(object sender, EventArgs e)
		{
			rotatedElement.AngleTransform += 10f;
			SetDefaultItem(radMenuItem1);
		}

		private void radMenuItem2_Click(object sender, EventArgs e)
		{
			rotatedElement.AngleTransform -= 10f;
			SetDefaultItem(radMenuItem2);
		}

		private void radButton1_Click(object sender, EventArgs e)
		{			
			rotatedElement.AngleTransform = 0f;
		}

		private void SetDefaultItem(RadMenuItem item)
		{
			radSplitButton3.DefaultItem = item;
			radSplitButton3.ImageIndex = item.ImageIndex;
			radSplitButton3.Text = item.Text;
		}
	}
}