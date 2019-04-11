using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Themes;

namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
{
	public partial class Form1 : Telerik.WinControls.UI.RadRibbonForm
	{
        private int mdiChildCount = 0;

        public Form1()
        {
            InitializeComponent();

            this.AllowAero = false;

            this.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem =
                this.radRibbonBar1.RibbonBarElement.TabStripElement.Items[0];
            this.IsMdiContainer = true;
            this.MinimumSize = new Size(210, 140);
        }

        void radRibbonBarChunk2_Click(object sender, System.EventArgs e)
        {
            this.AddNewChildForm();
        }

        private void PrepareMDIContainerForThemeChange()
        {
            if (this.ActiveMdiChild == null)
                return;
            if (this.ActiveMdiChild.WindowState == FormWindowState.Maximized)
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Normal;
            }
        }

		private void AddNewChildForm()
		{
            Form form = this.MdiChildren.Length % 2 == 0 ? new Form() : new Telerik.WinControls.UI.RadForm();
            form.MdiParent = this;
            form.Text = "MDI Child Form " + (++this.mdiChildCount);
            form.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            AddNewChildForm();
            AddNewChildForm();
            AddNewChildForm();
            AddNewChildForm();    
		}

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            this.AddNewChildForm();
        }

        private void radButtonElement29_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "Office2010Black");
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplyThemeToControlTree(this, "Office2010Silver");
        }
	}
}