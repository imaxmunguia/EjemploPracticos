﻿namespace Telerik.Examples.WinControls.GridView.Printing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radRadioButtonTable = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonHtml = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonColumnGroups = new Telerik.WinControls.UI.RadRadioButton();
            this.radButtonPrint = new Telerik.WinControls.UI.RadButton();
            this.radButtonPrintPreview = new Telerik.WinControls.UI.RadButton();
            this.radButtonPrintSettings = new Telerik.WinControls.UI.RadButton();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHtml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radButtonPrint);
            this.settingsPanel.Controls.Add(this.radButtonPrintPreview);
            this.settingsPanel.Controls.Add(this.radButtonPrintSettings);
            this.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsPanel.Location = new System.Drawing.Point(381, 90);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(261, 354);
            this.settingsPanel.TabIndex = 0;
            this.settingsPanel.Visible = false;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "EmployeeID";
            gridViewDecimalColumn1.HeaderText = "EmployeeID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "EmployeeID";
            gridViewTextBoxColumn1.FieldName = "TitleOfCourtesy";
            gridViewTextBoxColumn1.HeaderText = "TitleOfCourtesy";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "TitleOfCourtesy";
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "FirstName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "LastName";
            gridViewTextBoxColumn3.HeaderText = "LastName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "Title";
            gridViewTextBoxColumn4.HeaderText = "Title";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Title";
            gridViewTextBoxColumn4.Width = 80;
            gridViewDateTimeColumn1.FieldName = "BirthDate";
            gridViewDateTimeColumn1.HeaderText = "BirthDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "BirthDate";
            gridViewDateTimeColumn2.FieldName = "HireDate";
            gridViewDateTimeColumn2.HeaderText = "HireDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "HireDate";
            gridViewTextBoxColumn5.FieldName = "Country";
            gridViewTextBoxColumn5.HeaderText = "Country";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Country";
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.FieldName = "Photo";
            gridViewImageColumn1.HeaderText = "Photo";
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.IsVisible = false;
            gridViewImageColumn1.Name = "Photo";
            gridViewTextBoxColumn6.FieldName = "Address";
            gridViewTextBoxColumn6.HeaderText = "Address";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Address";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "City";
            gridViewTextBoxColumn7.HeaderText = "City";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "City";
            gridViewTextBoxColumn8.FieldName = "Region";
            gridViewTextBoxColumn8.HeaderText = "Region";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Region";
            gridViewTextBoxColumn9.FieldName = "PostalCode";
            gridViewTextBoxColumn9.HeaderText = "PostalCode";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "PostalCode";
            gridViewTextBoxColumn10.FieldName = "HomePhone";
            gridViewTextBoxColumn10.HeaderText = "Phone";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "HomePhone";
            gridViewTextBoxColumn10.Width = 80;
            gridViewTextBoxColumn11.FieldName = "Extension";
            gridViewTextBoxColumn11.HeaderText = "Extension";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Extension";
            gridViewTextBoxColumn12.FieldName = "Notes";
            gridViewTextBoxColumn12.HeaderText = "Notes";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "Notes";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ReportsTo";
            gridViewDecimalColumn2.HeaderText = "ReportsTo";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ReportsTo";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn5,
            gridViewImageColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewDecimalColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.employeesBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1317, 732);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radRadioButtonTable
            // 
            this.radRadioButtonTable.Location = new System.Drawing.Point(5, 21);
            this.radRadioButtonTable.Name = "radRadioButtonTable";
            this.radRadioButtonTable.TabIndex = 1;
            this.radRadioButtonTable.Text = "Table";
            this.radRadioButtonTable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            // 
            // radRadioButtonHtml
            // 
            this.radRadioButtonHtml.Location = new System.Drawing.Point(5, 45);
            this.radRadioButtonHtml.Name = "radRadioButtonHtml";
            this.radRadioButtonHtml.TabIndex = 1;
            this.radRadioButtonHtml.TabStop = true;
            this.radRadioButtonHtml.Text = "HTML";
            this.radRadioButtonHtml.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            // 
            // radRadioButtonColumnGroups
            // 
            this.radRadioButtonColumnGroups.Location = new System.Drawing.Point(5, 69);
            this.radRadioButtonColumnGroups.Name = "radRadioButtonColumnGroups";
            this.radRadioButtonColumnGroups.TabIndex = 1;
            this.radRadioButtonColumnGroups.Text = "Column groups";
            this.radRadioButtonColumnGroups.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButtonColumnGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            // 
            // radButtonPrint
            // 
            this.radButtonPrint.Location = new System.Drawing.Point(24, 173);
            this.radButtonPrint.Name = "radButtonPrint";
            this.radButtonPrint.TabIndex = 2;
            this.radButtonPrint.Text = "Print";
            this.radButtonPrint.Click += new System.EventHandler(this.radButtonPrint_Click);
            // 
            // radButtonPrintPreview
            // 
            this.radButtonPrintPreview.Location = new System.Drawing.Point(25, 203);
            this.radButtonPrintPreview.Name = "radButtonPrintPreview";
            this.radButtonPrintPreview.TabIndex = 2;
            this.radButtonPrintPreview.Text = "Print preview";
            this.radButtonPrintPreview.Click += new System.EventHandler(this.radButtonPrintPreview_Click);
            // 
            // radButtonPrintSettings
            // 
            this.radButtonPrintSettings.Location = new System.Drawing.Point(25, 233);
            this.radButtonPrintSettings.Name = "radButtonPrintSettings";
            this.radButtonPrintSettings.TabIndex = 2;
            this.radButtonPrintSettings.Text = "Print settings";
            this.radButtonPrintSettings.Click += new System.EventHandler(this.radButtonPrintSettings_Click);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.AssociatedObject = this.radGridView1;
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radPrintWatermark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F);
            radPrintWatermark1.ImageOpacity = ((byte)(127));
            radPrintWatermark1.Pages = null;
            radPrintWatermark1.Text = null;
            radPrintWatermark1.TextAngle = 0F;
            radPrintWatermark1.TextOpacity = ((byte)(127));
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radRadioButtonTable);
            this.radGroupBox1.Controls.Add(this.radRadioButtonColumnGroups);
            this.radGroupBox1.Controls.Add(this.radRadioButtonHtml);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Print style";
            this.radGroupBox1.Location = new System.Drawing.Point(24, 50);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(130, 100);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Print style";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1317, 732);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHtml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonTable;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonHtml;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonColumnGroups;
        private Telerik.WinControls.UI.RadButton radButtonPrint;
        private Telerik.WinControls.UI.RadButton radButtonPrintPreview;
        private Telerik.WinControls.UI.RadButton radButtonPrintSettings;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private DataSources.NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}