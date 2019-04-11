namespace Telerik.Examples.WinControls.GridView.ColumnTypes
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radGroupBoxColumns = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxCustom = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxBrowse = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCalculator = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxColor = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxHyperlink = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxMaskBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxLookUp = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxImage = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxText = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxDecimal = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumns)).BeginInit();
            this.radGroupBoxColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHyperlink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMaskBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxColumns);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            this.settingsPanel.Size = new System.Drawing.Size(303, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxColumns, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.White;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1277, 749);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Telerik";
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "NwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.nwindDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nwindDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBoxColumns
            // 
            this.radGroupBoxColumns.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxCustom);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxCheckBox);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxBrowse);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxCalculator);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxColor);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxHyperlink);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxMaskBox);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxLookUp);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxImage);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxText);
            this.radGroupBoxColumns.Controls.Add(this.radCheckBoxDecimal);
            this.radGroupBoxColumns.FooterImageIndex = -1;
            this.radGroupBoxColumns.FooterImageKey = "";
            this.radGroupBoxColumns.ForeColor = System.Drawing.Color.Black;
            this.radGroupBoxColumns.HeaderImageIndex = -1;
            this.radGroupBoxColumns.HeaderImageKey = "";
            this.radGroupBoxColumns.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBoxColumns.HeaderText = "Columns";
            this.radGroupBoxColumns.Location = new System.Drawing.Point(15, 6);
            this.radGroupBoxColumns.Name = "radGroupBoxColumns";
            this.radGroupBoxColumns.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBoxColumns.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBoxColumns.Size = new System.Drawing.Size(115, 298);
            this.radGroupBoxColumns.TabIndex = 1;
            this.radGroupBoxColumns.Text = "Columns";
            // 
            // radCheckBoxCustom
            // 
            this.radCheckBoxCustom.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxCustom.Location = new System.Drawing.Point(19, 267);
            this.radCheckBoxCustom.Name = "radCheckBoxCustom";
            // 
            // 
            // 
            this.radCheckBoxCustom.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxCustom.Size = new System.Drawing.Size(59, 18);
            this.radCheckBoxCustom.TabIndex = 34;
            this.radCheckBoxCustom.Text = "Custom";
            this.radCheckBoxCustom.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxCustom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxCustom.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxCustom_ToggleStateChanged);
            // 
            // radCheckBoxCheckBox
            // 
            this.radCheckBoxCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxCheckBox.Location = new System.Drawing.Point(19, 243);
            this.radCheckBoxCheckBox.Name = "radCheckBoxCheckBox";
            // 
            // 
            // 
            this.radCheckBoxCheckBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxCheckBox.Size = new System.Drawing.Size(69, 18);
            this.radCheckBoxCheckBox.TabIndex = 33;
            this.radCheckBoxCheckBox.Text = "CheckBox";
            this.radCheckBoxCheckBox.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxCheckBox_ToggleStateChanged);
            // 
            // radCheckBoxBrowse
            // 
            this.radCheckBoxBrowse.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxBrowse.Location = new System.Drawing.Point(19, 219);
            this.radCheckBoxBrowse.Name = "radCheckBoxBrowse";
            // 
            // 
            // 
            this.radCheckBoxBrowse.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxBrowse.Size = new System.Drawing.Size(56, 18);
            this.radCheckBoxBrowse.TabIndex = 32;
            this.radCheckBoxBrowse.Text = "Browse";
            this.radCheckBoxBrowse.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxBrowse.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxBrowse.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxBrowse_ToggleStateChanged);
            // 
            // radCheckBoxCalculator
            // 
            this.radCheckBoxCalculator.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxCalculator.Location = new System.Drawing.Point(19, 195);
            this.radCheckBoxCalculator.Name = "radCheckBoxCalculator";
            // 
            // 
            // 
            this.radCheckBoxCalculator.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxCalculator.Size = new System.Drawing.Size(70, 18);
            this.radCheckBoxCalculator.TabIndex = 31;
            this.radCheckBoxCalculator.Text = "Calculator";
            this.radCheckBoxCalculator.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxCalculator.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxCalculator.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxCalculator_ToggleStateChanged);
            // 
            // radCheckBoxColor
            // 
            this.radCheckBoxColor.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxColor.Location = new System.Drawing.Point(19, 171);
            this.radCheckBoxColor.Name = "radCheckBoxColor";
            // 
            // 
            // 
            this.radCheckBoxColor.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxColor.Size = new System.Drawing.Size(47, 18);
            this.radCheckBoxColor.TabIndex = 28;
            this.radCheckBoxColor.Text = "Color";
            this.radCheckBoxColor.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxColor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxColor.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColor_ToggleStateChanged);
            // 
            // radCheckBoxHyperlink
            // 
            this.radCheckBoxHyperlink.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxHyperlink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxHyperlink.Location = new System.Drawing.Point(19, 147);
            this.radCheckBoxHyperlink.Name = "radCheckBoxHyperlink";
            // 
            // 
            // 
            this.radCheckBoxHyperlink.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxHyperlink.Size = new System.Drawing.Size(68, 18);
            this.radCheckBoxHyperlink.TabIndex = 28;
            this.radCheckBoxHyperlink.Text = "Hyperlink";
            this.radCheckBoxHyperlink.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxHyperlink.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxHyperlink.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxHyperlink_ToggleStateChanged);
            // 
            // radCheckBoxMaskBox
            // 
            this.radCheckBoxMaskBox.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxMaskBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxMaskBox.Location = new System.Drawing.Point(19, 123);
            this.radCheckBoxMaskBox.Name = "radCheckBoxMaskBox";
            // 
            // 
            // 
            this.radCheckBoxMaskBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxMaskBox.Size = new System.Drawing.Size(65, 18);
            this.radCheckBoxMaskBox.TabIndex = 28;
            this.radCheckBoxMaskBox.Text = "MaskBox";
            this.radCheckBoxMaskBox.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxMaskBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxMaskBox_ToggleStateChanged);
            // 
            // radCheckBoxLookUp
            // 
            this.radCheckBoxLookUp.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxLookUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxLookUp.Location = new System.Drawing.Point(19, 99);
            this.radCheckBoxLookUp.Name = "radCheckBoxLookUp";
            // 
            // 
            // 
            this.radCheckBoxLookUp.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxLookUp.Size = new System.Drawing.Size(59, 18);
            this.radCheckBoxLookUp.TabIndex = 30;
            this.radCheckBoxLookUp.Text = "LookUp";
            this.radCheckBoxLookUp.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxLookUp.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxLookUp_ToggleStateChanged);
            // 
            // radCheckBoxImage
            // 
            this.radCheckBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxImage.Location = new System.Drawing.Point(19, 75);
            this.radCheckBoxImage.Name = "radCheckBoxImage";
            // 
            // 
            // 
            this.radCheckBoxImage.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxImage.Size = new System.Drawing.Size(51, 18);
            this.radCheckBoxImage.TabIndex = 29;
            this.radCheckBoxImage.Text = "Image";
            this.radCheckBoxImage.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxImage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxImage.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxImage_ToggleStateChanged);
            // 
            // radCheckBoxText
            // 
            this.radCheckBoxText.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxText.Location = new System.Drawing.Point(19, 51);
            this.radCheckBoxText.Name = "radCheckBoxText";
            // 
            // 
            // 
            this.radCheckBoxText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxText.Size = new System.Drawing.Size(41, 18);
            this.radCheckBoxText.TabIndex = 28;
            this.radCheckBoxText.Text = "Text";
            this.radCheckBoxText.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxText.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxText_ToggleStateChanged);
            // 
            // radCheckBoxDecimal
            // 
            this.radCheckBoxDecimal.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBoxDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxDecimal.Location = new System.Drawing.Point(19, 27);
            this.radCheckBoxDecimal.Name = "radCheckBoxDecimal";
            // 
            // 
            // 
            this.radCheckBoxDecimal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radCheckBoxDecimal.Size = new System.Drawing.Size(60, 18);
            this.radCheckBoxDecimal.TabIndex = 27;
            this.radCheckBoxDecimal.Text = "Decimal";
            this.radCheckBoxDecimal.ThemeName = "GridFeaturesBrowser";
            this.radCheckBoxDecimal.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxDecimal_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1277, 749);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumns)).EndInit();
            this.radGroupBoxColumns.ResumeLayout(false);
            this.radGroupBoxColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHyperlink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMaskBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDecimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private System.Windows.Forms.BindingSource employeesBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxColumns;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxDecimal;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCustom;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCheckBox;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxBrowse;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCalculator;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColor;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxHyperlink;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxMaskBox;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxLookUp;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxImage;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxText;


    }
}