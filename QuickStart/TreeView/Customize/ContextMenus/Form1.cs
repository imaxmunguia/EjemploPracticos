using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
{
    /// <summary>
    /// Form code
    /// </summary>
	public partial class Form1 : TreeExamplesControl
	{
        Bitmap bottomRightBitmap = Resources.TV_email;
        private string clickedNode;
        
        public Form1()
		{
			InitializeComponent();
			this.radLblSelectedNode.Text = "";
            this.radLblSelectedItem.Text = "";
			this.Load += new EventHandler(Form1_Load);

			this.SelectedControl = this.radTreeViewDemo;            
            this.radTreeViewDemo.AllowEdit = true;

            this.radContextMenu1.DropDownOpening += new System.ComponentModel.CancelEventHandler(radContextMenu1_DropDownOpening);
		}


        public override RadTreeView TreeControl
        {
            get { return this.radTreeViewDemo; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Mail"; }
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			this.radMenuItem1.Click += new EventHandler(radMenuItem1_Click);
			this.radMenuItem2.Click +=new EventHandler(radMenuItem2_Click);
			this.radMenuItem4.Click +=new EventHandler(radMenuItem4_Click);
			this.radMenuItem5.Click +=new EventHandler(radMenuItem5_Click);

			this.radTreeViewDemo.NodeMouseDown += new Telerik.WinControls.UI.RadTreeView.TreeViewMouseEventHandler(node_MouseDown);
		}

		private void node_MouseDown(object sender, RadTreeViewEventArgs e)
		{
			if (Control.MouseButtons == MouseButtons.Right)
			{
				clickedNode = e.Node.Text;
			}
		}

        private void SetLabel(object sender)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item != null)
            {
                radLblSelectedNode.Text = this.clickedNode;
                radLblSelectedItem.Text = item.Text;
            }
        }

        void radContextMenu1_DropDownOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RadTreeNode node = this.radTreeViewDemo.SelectedNode;
            if (node != null)
            {
                this.radMenuItem1.Enabled = node.Enabled;
                this.radMenuItem4.Enabled = node.Enabled;
                this.radMenuItem5.Enabled = node.Enabled;
                if (node.Enabled)
                {
                    this.radMenuItem2.Text = "Disable";
                }
                else
                {
                    this.radMenuItem2.Text = "Enable";
                }
            }
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            SetLabel(sender);
            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.BeginEdit();
            }
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            SetLabel(sender);
            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.SelectedNode.Enabled = !this.radTreeViewDemo.SelectedNode.Enabled;
            }
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            SetLabel(sender);

            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.SelectedNode.Remove();
            }
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            SetLabel(sender);
            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.SelectedNode.Expand();
                RadTreeNode newNode = this.radTreeViewDemo.SelectedNode.Nodes.Add("New Folder");
                if (newNode != null)
                {
                    this.radTreeViewDemo.SelectedNode = newNode;
                    this.radTreeViewDemo.BeginEdit();
                }
            }
        }
    }
}
