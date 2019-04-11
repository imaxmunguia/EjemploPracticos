using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples
{
    public class TreeExamplesControl : ExamplesForm
    {
        Bitmap topRightBitmap = Resources.TV_gradient;
        TreeExampleHeaderPanel headerPanel;

        public TreeExamplesControl()
        {
            headerPanel = new TreeExampleHeaderPanel();
            this.Controls.Add(headerPanel);
            this.AutoScroll = false;
        }

        public virtual RadTreeView TreeControl { get { return null; } }

        public virtual Bitmap BottomRightImage { get { return null; } }

        public virtual string HeaderText { get { return ""; } }

        public virtual Bitmap TopRightImage
        {
            get { return this.topRightBitmap; }
        }

        protected virtual int CalculateTreeWidth(int clientWidth)
        {
            return clientWidth - (197 + 264);
        }

        protected virtual int CalculateOffset(int clientWidth)
        {
            return 194;
        }

        protected virtual void UpdateTreeDimensions()
        {
            if (this.TreeControl != null)
            {
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                int offset = CalculateOffset(width);
                this.TreeControl.Size = new Size(CalculateTreeWidth(width), height - 94 - 30);
                this.TreeControl.Location = new Point(offset, 62 + 30);
                this.headerPanel.Size = new Size(this.TreeControl.Size.Width, 30);
                this.headerPanel.Location = new Point(offset, 62);
            }
        }

        protected virtual void PaintImages(Graphics g)
        {
            if (TopRightImage != null)
            {
                g.DrawImage(TopRightImage, new Point(this.Size.Width - TopRightImage.Width, 0));
            }
            if (BottomRightImage != null)
            {
                g.DrawImage(BottomRightImage, new Point(this.Size.Width - BottomRightImage.Width, this.Size.Height - BottomRightImage.Height));
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (TreeControl != null)
            {
                this.TreeControl.ItemHeight = 27;
                this.TreeControl.ShowLines = false;
                this.TreeControl.FullRowSelect = true;
                this.TreeControl.ExpandAnimation = ExpandAnimation.None;
                this.headerPanel.Text = HeaderText;
                this.TreeControl.AllowEdit = true;
                this.TreeControl.AllowAdd = false;
                this.TreeControl.AllowRemove = false;
                this.TreeControl.AllowDefaultContextMenu = true;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateTreeDimensions();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintImages(e.Graphics);
        }
    }
}
