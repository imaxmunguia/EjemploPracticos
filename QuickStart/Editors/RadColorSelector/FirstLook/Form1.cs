using System;
using System.Drawing;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.Editors.RadColorSelector.FirstLook
{
	/// <summary>
	/// Color selector example form
	/// </summary>
	public partial class Form1 : ExamplesForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();

			radColorSelector1.SelectedColor = Color.Red;
            radColorSelector1.OkButtonClicked += new ColorChangedEventHandler(radColorSelector1_OkButtonClicked);
            radColorSelector1.CancelButtonClicked += new ColorChangedEventHandler(radColorSelector1_CancelButtonClicked);

			radCheckBox1.ToggleState = radColorSelector1.ShowBasicColors ? ToggleState.On : ToggleState.Off;
            radCheckBox2.ToggleState = radColorSelector1.ShowSystemColors ? ToggleState.On : ToggleState.Off;
            radCheckBox3.ToggleState = radColorSelector1.ShowWebColors ? ToggleState.On : ToggleState.Off;
            radCheckBox4.ToggleState = radColorSelector1.ShowProfessionalColors ? ToggleState.On : ToggleState.Off;

            radCheckBox5.ToggleState = radColorSelector1.ShowHEXColorValue ? ToggleState.On : ToggleState.Off;
            radCheckBox6.ToggleState = radColorSelector1.ShowCustomColors ? ToggleState.On : ToggleState.Off;
            radCheckBox7.ToggleState = radColorSelector1.AllowColorSaving ? ToggleState.On : ToggleState.Off;
            radCheckBox8.ToggleState = radColorSelector1.AllowEditHEXValue ? ToggleState.On : ToggleState.Off;
            radCheckBox9.ToggleState = radColorSelector1.AllowColorPickFromScreen ? ToggleState.On : ToggleState.Off;

			radTextBox1.Text = radColorSelector1.SelectedColorLabelHeading;
			radTextBox2.Text = radColorSelector1.OldColorLabelHeading;
			radTextBox3.Text = radColorSelector1.AddNewColorButtonText;

			this.EnabledQSFButtons = QSFButtons.None;

            ThemeResolutionService.ApplyThemeToControlTree(this.radColorSelector1, THEME);
		}

        private void SetTheme()
        {
            for (int i = 0; i < this.settingsPanel.Controls.Count; i++ )
            {
                RadControl currentControl = this.settingsPanel.Controls[i] as RadControl;

                if (currentControl != null)
                {
                    currentControl.ThemeName = THEME;

                    this.SetTheme(currentControl);
                }
            }
        }

        private void SetTheme(RadControl control)
        {
            control.ThemeName = THEME;

            for (int i = 0; i < control.Controls.Count; i++)
            {
                RadControl currentControl = control.Controls[i] as RadControl;

                if (currentControl != null)
                {
                    currentControl.ThemeName = THEME;

                    this.SetTheme(currentControl);
                }
            }
        }


        protected override void OnLoad(EventArgs e)
        {

            this.SetTheme();
            base.OnLoad(e);
        }

		void radColorSelector1_CancelButtonClicked(object sender, ColorChangedEventArgs args)
		{
			
		}

		void radColorSelector1_OkButtonClicked(object sender, ColorChangedEventArgs args)
		{
			
		}

		private void radColorSelector1_ColorChanged(object sender, ColorChangedEventArgs args)
		{

		}

		private void radTextBox1_TextChanged(object sender, EventArgs e)
		{
			radColorSelector1.SelectedColorLabelHeading = radTextBox1.Text;
			radColorSelector1.Refresh();
		}

		private void radTextBox2_TextChanged(object sender, EventArgs e)
		{
			radColorSelector1.OldColorLabelHeading = radTextBox2.Text;
			radColorSelector1.Refresh();
		}

		private void radTextBox3_TextChanged(object sender, EventArgs e)
		{
			radColorSelector1.AddNewColorButtonText = radTextBox3.Text;
			radColorSelector1.Refresh();
		}

		private void radCheckBox1_Click(object sender, StateChangedEventArgs e)
		{
			if (!radColorSelector1.ShowWebColors && !radColorSelector1.ShowSystemColors
				&& !radColorSelector1.ShowProfessionalColors)
			{
                radCheckBox1.ToggleState = ToggleState.On;
				return;
			}
			radColorSelector1.ShowBasicColors = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox2_Click(object sender, StateChangedEventArgs e)
		{
			if (!radColorSelector1.ShowWebColors && !radColorSelector1.ShowBasicColors
				&& !radColorSelector1.ShowProfessionalColors)
			{
                radCheckBox2.ToggleState = ToggleState.On;
				return;
			}

			radColorSelector1.ShowSystemColors = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox3_Click(object sender, StateChangedEventArgs e)
		{
			if (!radColorSelector1.ShowSystemColors && !radColorSelector1.ShowBasicColors
				&& !radColorSelector1.ShowProfessionalColors)
			{
                radCheckBox3.ToggleState = ToggleState.On;
				return;
			}

			radColorSelector1.ShowWebColors = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox4_Click(object sender, StateChangedEventArgs e)
		{
			if (!radColorSelector1.ShowWebColors && !radColorSelector1.ShowBasicColors
				&& !radColorSelector1.ShowSystemColors)
			{
                radCheckBox4.ToggleState = ToggleState.On;
				return;
			}

			radColorSelector1.ShowProfessionalColors = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox6_Click(object sender, StateChangedEventArgs e)
		{
			radColorSelector1.ShowCustomColors = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			//when the custom colors are not shown, the user cannot add to them
			if (!radColorSelector1.ShowCustomColors)
			{
				radCheckBox7.Enabled = false;
                radCheckBox7.ToggleState = ToggleState.Off;
				radColorSelector1.AllowColorSaving = false;
			}
			else
			{
				radCheckBox7.Enabled = true;
                radCheckBox7.ToggleState = ToggleState.On;
				radColorSelector1.AllowColorSaving = true;
			}
			radColorSelector1.Refresh();
		}

		private void radCheckBox7_Click(object sender, StateChangedEventArgs e)
		{
			radColorSelector1.AllowColorSaving = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox5_Click(object sender, StateChangedEventArgs e)
		{
			radColorSelector1.ShowHEXColorValue = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox8_Click(object sender, StateChangedEventArgs e)
		{
			radColorSelector1.AllowEditHEXValue = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void radCheckBox9_Click(object sender, StateChangedEventArgs e)
		{
			radColorSelector1.AllowColorPickFromScreen = e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
			radColorSelector1.Refresh();
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}
	}
}