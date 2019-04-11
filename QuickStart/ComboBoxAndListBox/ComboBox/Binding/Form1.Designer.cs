using Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding.General;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NorthwindDataSetAccess = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter2 = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.radGroupBindingOpts = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioDB = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioArray = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioDataTable = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioUnbound = new Telerik.WinControls.UI.RadRadioButton();
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSetAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBindingOpts)).BeginInit();
            this.radGroupBindingOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUnbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(431, 318);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBindingOpts);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBindingOpts, 0);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.NorthwindDataSetAccess;
            // 
            // NorthwindDataSetAccess
            // 
            this.NorthwindDataSetAccess.DataSetName = "NwindDataSet";
            this.NorthwindDataSetAccess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding.General.Customer);
            this.CustomerBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.CustomerBindingSource_AddingNew);
            // 
            // employeesTableAdapter2
            // 
            this.employeesTableAdapter2.ClearBeforeFill = true;
            // 
            // radGroupBindingOpts
            // 
            this.radGroupBindingOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBindingOpts.Controls.Add(this.radRadioDB);
            this.radGroupBindingOpts.Controls.Add(this.radRadioArray);
            this.radGroupBindingOpts.Controls.Add(this.radRadioDataTable);
            this.radGroupBindingOpts.Controls.Add(this.radRadioUnbound);
            this.radGroupBindingOpts.FooterImageIndex = -1;
            this.radGroupBindingOpts.FooterImageKey = "";
            this.radGroupBindingOpts.FooterText = "";
            this.radGroupBindingOpts.ForeColor = System.Drawing.Color.Black;
            this.radGroupBindingOpts.HeaderImageIndex = -1;
            this.radGroupBindingOpts.HeaderImageKey = "";
            this.radGroupBindingOpts.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBindingOpts.HeaderText = " Binding options ";
            this.radGroupBindingOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupBindingOpts.Name = "radGroupBindingOpts";
            this.radGroupBindingOpts.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBindingOpts.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBindingOpts.Size = new System.Drawing.Size(180, 131);
            this.radGroupBindingOpts.TabIndex = 0;
            this.radGroupBindingOpts.Text = " Binding options ";
            // 
            // radRadioDB
            // 
            this.radRadioDB.ForeColor = System.Drawing.Color.Black;
            this.radRadioDB.Location = new System.Drawing.Point(33, 96);
            this.radRadioDB.Name = "radRadioDB";
            // 
            // 
            // 
            this.radRadioDB.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioDB.Size = new System.Drawing.Size(69, 16);
            this.radRadioDB.TabIndex = 0;
            this.radRadioDB.Text = "Database";
            this.radRadioDB.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            // 
            // radRadioArray
            // 
            this.radRadioArray.ForeColor = System.Drawing.Color.Black;
            this.radRadioArray.Location = new System.Drawing.Point(33, 74);
            this.radRadioArray.Name = "radRadioArray";
            // 
            // 
            // 
            this.radRadioArray.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioArray.Size = new System.Drawing.Size(47, 16);
            this.radRadioArray.TabIndex = 0;
            this.radRadioArray.Text = "Array";
            this.radRadioArray.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            // 
            // radRadioDataTable
            // 
            this.radRadioDataTable.ForeColor = System.Drawing.Color.Black;
            this.radRadioDataTable.Location = new System.Drawing.Point(33, 52);
            this.radRadioDataTable.Name = "radRadioDataTable";
            // 
            // 
            // 
            this.radRadioDataTable.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioDataTable.Size = new System.Drawing.Size(76, 16);
            this.radRadioDataTable.TabIndex = 0;
            this.radRadioDataTable.Text = "Data Table";
            this.radRadioDataTable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            // 
            // radRadioUnbound
            // 
            this.radRadioUnbound.ForeColor = System.Drawing.Color.Black;
            this.radRadioUnbound.Location = new System.Drawing.Point(33, 30);
            this.radRadioUnbound.Name = "radRadioUnbound";
            // 
            // 
            // 
            this.radRadioUnbound.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioUnbound.Size = new System.Drawing.Size(97, 16);
            this.radRadioUnbound.TabIndex = 0;
            this.radRadioUnbound.Text = "Unbound mode";
            this.radRadioUnbound.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            // 
            // radComboDemo
            // 
            this.radComboDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown;
            this.radComboDemo.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.Location = new System.Drawing.Point(28, 40);
            this.radComboDemo.Name = "radComboDemo";
            // 
            // 
            // 
            this.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.Size = new System.Drawing.Size(306, 20);
            this.radComboDemo.TabIndex = 2;
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSetAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBindingOpts)).EndInit();
            this.radGroupBindingOpts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUnbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet NorthwindDataSetAccess;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter2;
		private BindingSource CustomerBindingSource;
        private BindingSource employeesBindingSource;
        private Telerik.WinControls.UI.RadGroupBox radGroupBindingOpts;
        private Telerik.WinControls.UI.RadRadioButton radRadioDB;
        private Telerik.WinControls.UI.RadRadioButton radRadioArray;
        private Telerik.WinControls.UI.RadRadioButton radRadioDataTable;
        private Telerik.WinControls.UI.RadRadioButton radRadioUnbound;
        private Telerik.WinControls.UI.RadDropDownList radComboDemo;
    }
}