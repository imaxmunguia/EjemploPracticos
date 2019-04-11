using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.FirstLook
{
    /// <summary>
    /// Example beautifying
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            LoadData();
            this.radTreeView1.ExpandAll();

            RadMenuItem item = new RadMenuItem("None");
            item.Click += new EventHandler(item_Click);
            this.radDropDownButton1.Items.Add(item);

            item = new RadMenuItem("Ascending");
            item.Click += new EventHandler(item_Click);
            this.radDropDownButton1.Items.Add(item);

            item = new RadMenuItem("Descending");
            item.Click += new EventHandler(item_Click);
            this.radDropDownButton1.Items.Add(item);

            ImagePrimitive searchIcon = new ImagePrimitive();
            searchIcon.Image = Resources.TV_search;
            searchIcon.Alignment = ContentAlignment.MiddleRight;
            this.radTextBox1.TextBoxElement.Children.Add(searchIcon);
            this.radTextBox1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft;
            this.radTextBox1.TextBoxElement.TextBoxItem.StretchHorizontally = false;
            this.radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MinimumSize = new Size(210, 0);
            this.radTextBox1.TextBoxElement.TextBoxItem.PropertyChanged += new PropertyChangedEventHandler(TextBoxItem_PropertyChanged);
            this.radTreeView1.TreeViewElement.AllowAlternatingRowColor = true;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.AllowAdd = true;
            this.radTreeView1.AllowRemove = true;
            this.radTreeView1.ItemHeight = 27;
            this.radTreeView1.AllowDefaultContextMenu = true;
            this.AutoScroll = false;
            this.radPanel1.Text = "Subscriptions";
        }

        private void LoadData()
        {
            RadTreeNode root = this.radTreeView1.Nodes.Add("Programming");
            root.Nodes.Add("Microsoft Research News and Highlights", 1);

            root.Nodes.Add("Joel on Software", 1);
            root.Nodes.Add("Miguel de Icaza", 1);
            root.Nodes.Add("channel 9", 1);

            root = this.radTreeView1.Nodes.Add("News (1)");
            root.Nodes.Add("cnn.com (1)", 1);
            root.Nodes.Add("msnbc.com", 1);
            root.Nodes.Add("reuters.com", 1);
            root.Nodes.Add("bbc.co.uk", 1);

            root = this.radTreeView1.Nodes.Add("Personal (19)");
            root.Nodes.Add("sports (2)", 1);
            RadTreeNode folder = root.Nodes.Add("fun (17)");
            folder.Nodes.Add("Lolcats (2)", 1);
            folder.Nodes.Add("FFFOUND (15)", 1);

            this.radTreeView1.Nodes.Add("Telerik blogs", 1);
            this.radTreeView1.Nodes.Add("Techcrunch", 1);
            this.radTreeView1.Nodes.Add("Engadget", 1);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.radPanel2 != null)
            {
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                this.radPanel2.Size = new System.Drawing.Size(633, 427);
                this.radPanel2.Location = new Point((width - radPanel2.Size.Width) / 2, this.radPanel2.Location.Y);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            RadMenuItem item = (RadMenuItem)sender;
            this.radDropDownButton1.Text = item.Text;
            if (item.Text == "None")
            {
                radTreeView1.SortOrder = SortOrder.None;
            }
            else if (item.Text == "Ascending")
            {
                radTreeView1.SortOrder = SortOrder.Ascending;
            }
            else
            {
                radTreeView1.SortOrder = SortOrder.Descending;
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.radTreeView1.Filter = this.radTextBox1.Text;
        }

        private void radTreeView1_NodeFormatting(object sender, TreeNodeFormattingEventArgs args)
        {
            if (args.Node.Text.Contains("("))
            {
                args.NodeElement.ContentElement.Text = "<html><b>" + args.Node.Text;
            }
        }

        private void TextBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = new Size(radTextBox1.Size.Width - 28, 0);
            }
        }
    }
}
