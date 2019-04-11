using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;

namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
{
	public partial class Form1 : ExamplesForm
	{
        private Telerik.WinControls.CustomShape shape;

		public Form1()
		{
			InitializeComponent();
			
			radComboBox1.Items.Add(new RadListDataItem("RoundRectShape", typeof(RoundRectShape)));
            radComboBox1.Items.Add(new RadListDataItem("EllipseShape", typeof(EllipseShape)));
            radComboBox1.Items.Add(new RadListDataItem("DonutShape", typeof(DonutShape)));
            radComboBox1.Items.Add(new RadListDataItem("TabOffice12Shape", typeof(TabOffice12Shape)));
            radComboBox1.Items.Add(new RadListDataItem("TabVsShape", typeof(TabVsShape)));

            this.EnabledQSFButtons = QSFButtons.ControlSpy;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			radComboBox1.SelectedIndex = 0;
		}

		private void radButton2_Click(object sender, EventArgs e)
		{
			ElementShape shape = null;

			if (radioButton1.Checked)
			{
                RadListDataItem item = radComboBox1.SelectedItem;
				shape = (ElementShape)Activator.CreateInstance((Type)item.Value);
			}
			else
			{
				shape = this.shape;
			}

			MyShapedForm form = new MyShapedForm(shape);
			form.BorderWidth = 2;
			form.ShowDialog();
		}
		
		private void radButton3_Click(object sender, System.EventArgs e)
		{
			radioButton2.Checked = true;

            Telerik.WinControls.CustomShapeEditorForm form = new Telerik.WinControls.CustomShapeEditorForm();

            if (shape == null)
            {
                shape = new Telerik.WinControls.CustomShape(new Rectangle(0, 0, 320, 180));
            }

            shape = form.EditShape(shape);

            if (form.Result == DialogResult.OK)
            {
                radButton1.ButtonElement.Shape = shape;
            }
		}

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			radioButton1.Checked = true;
            RadListDataItem item = radComboBox1.SelectedItem;
			radButton1.ButtonElement.Shape = (ElementShape)Activator.CreateInstance((Type)item.Value);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			RadListDataItem item = radComboBox1.SelectedItem;
			radButton1.ButtonElement.Shape = (ElementShape)Activator.CreateInstance((Type)item.Value);
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (shape != null)
			{
				radButton1.ButtonElement.Shape = shape;
			}
		}
    }
}