using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
{
	public partial class MyShapedForm : Telerik.WinControls.UI.ShapedForm
	{
		public MyShapedForm(): this(null)
		{
		}

		public MyShapedForm(ElementShape shape)
		{
			InitializeComponent();
			if (shape != null)
				this.Shape = shape;
		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override int GetHitTest(Point point)
		{
			int result = base.GetHitTest(point);
			if (result == 1)
				result = 2;
			return result;
		}
	}
}