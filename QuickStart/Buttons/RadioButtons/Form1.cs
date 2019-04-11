using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Buttons.RadioButtons
{
	/// <summary>
	/// Represents the RadRadioButtons example form
	/// </summary>
	public partial class Form1 : EditorExampleBaseForm
	{
		CustomShape customShape1;
		public Form1()
		{
			InitializeComponent();

            this.EnabledQSFButtons = ~QSFButtons.ChangeTheme;
			this.customShape1 = new CustomShape();
			customShape1.CreateClosedShape(CreateInitialShape(5, 100, 60));
            SetTheme();
            SetShapes();
			this.SelectedControl = this.radRadioCustShape;
		}

        private void SetTheme()
        {
            this.radGroupBox1.ThemeName = "ControlDefault";
            this.radRadioRegular.ThemeName = "ControlDefault";
            this.radTextBoxEvents.ThemeName = "ControlDefault";
            this.radRadioCustShape.ThemeName = "ControlDefault";
            this.radRadioDonut.ThemeName = "ControlDefault";
            this.radRadioSquare.ThemeName = "ControlDefault";
            this.radRadioOffice.ThemeName = "ControlDefault";
            this.radRadioRound.ThemeName = "ControlDefault";
        }

		private static List<PointF> CreateInitialShape(int vertices, double radius1, double radius2)
		{
			List<PointF> pts = new List<PointF>();

			if (radius1 == 0) return null;

			if (radius2 == 0) return null;

			for (int i = 0; i < vertices; i++)
			{
				double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
				double angle2 = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices);
				pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
				pts.Add(new PointF((float)(Math.Cos(angle2) * radius2), (float)(Math.Sin(angle2) * radius2)));
			}

			return pts;
		}

        private void SetShapes()
        {
            this.radRadioCustShape.RootElement.Children[0].Children[1].Children[1].Shape = customShape1;
            this.radRadioDonut.RootElement.Children[0].Children[1].Children[1].Shape = new DonutShape();
            RoundRectShape square = new RoundRectShape();
            square.Radius = 0;
            this.radRadioSquare.RootElement.Children[0].Children[1].Children[1].Shape = square;
            this.radRadioRound.RootElement.Children[0].Children[1].Children[1].Shape = new RoundRectShape();
            this.radRadioOffice.RootElement.Children[0].Children[1].Children[1].Shape = new OfficeShape();
        }

        private void radRadioCustShape_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            string s = " on";
            if ((sender as RadRadioButton).ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
                s = " off";

            this.radTextBoxEvents.Text += string.Format("{0} toggled" + s + Environment.NewLine, (sender as RadRadioButton).Text);
            this.radTextBoxEvents.SelectionStart = this.radTextBoxEvents.Text.Length;
            this.radTextBoxEvents.ScrollToCaret();
        }
	}
}