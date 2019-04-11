using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : Telerik.WinControls.UI.RadForm  
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            RadPageViewOutlookElement outlookStyle = this.radPanelBar1.ViewElement as RadPageViewOutlookElement;
            outlookStyle.HideItems(3);

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radRibbonBar1.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Hidden;

            LayoutProperties designerForm = new LayoutProperties();
            designerForm.Owner = this;
            designerForm.Show();

            SetDefaultPanelBorderColors();
        }

        private void SetDefaultPanelBorderColors()
        {
            this.splitPanel1.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel2.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel3.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel4.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            this.splitPanel5.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255);
            ((BorderPrimitive)this.radPanel1.PanelElement.Children[1]).ForeColor = Color.FromArgb(191, 225, 255);
            ((BorderPrimitive)this.radPanel2.PanelElement.Children[1]).ForeColor = Color.FromArgb(191, 225, 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.northwindDataSet.Cars);

        }

        #region Split Properties

        public Telerik.WinControls.UI.RadSplitContainer RadSplitContainer1
        {
            get
            {
                return this.radSplitContainer1;
            }
        }

        public Telerik.WinControls.UI.RadSplitContainer RadSplitContainer2
        {
            get
            {
                return this.radSplitContainer2;
            }
        }

        public SplitPanel SplitPanel1
        {
            get
            {
                return this.splitPanel1;
            }
        }

        public SplitPanel SplitPanel2
        {
            get
            {
                return this.splitPanel2;
            }
        }

        public SplitPanel SplitPanel3
        {
            get
            {
                return this.splitPanel3;
            }
        }

        public SplitPanel SplitPanel4
        {
            get
            {
                return this.splitPanel4;
            }
        }

        public SplitPanel SplitPanel5
        {
            get
            {
                return this.splitPanel5;
            }
        }

        #endregion

        private void btnOpenDesigner_Click(object sender, EventArgs e)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is LayoutProperties)
                    return;                    
            }

            LayoutProperties designerForm = new LayoutProperties();
            designerForm.Owner = this;
            designerForm.Show();
        }
    }
}