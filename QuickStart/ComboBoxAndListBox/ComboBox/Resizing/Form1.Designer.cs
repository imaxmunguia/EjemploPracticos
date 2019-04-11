namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Resizing
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.radGroupSizingMode = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioUpDown = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioBottomUpDown = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioRightBottom = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSizingMode)).BeginInit();
            this.radGroupSizingMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioBottomUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(282, 318);
            this.radPanelDemoHolder.MaximumSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.MinimumSize = new System.Drawing.Size(362, 100);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.RootElement.MaxSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.RootElement.MinSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupSizingMode);
            this.settingsPanel.Location = new System.Drawing.Point(726, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 734);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSizingMode, 0);
            // 
            // radGroupSizingMode
            // 
            this.radGroupSizingMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSizingMode.Controls.Add(this.radRadioUpDown);
            this.radGroupSizingMode.Controls.Add(this.radRadioBottomUpDown);
            this.radGroupSizingMode.Controls.Add(this.radRadioRightBottom);
            this.radGroupSizingMode.Controls.Add(this.radRadioNone);
            this.radGroupSizingMode.FooterImageIndex = -1;
            this.radGroupSizingMode.FooterImageKey = "";
            this.radGroupSizingMode.FooterText = "";
            this.radGroupSizingMode.ForeColor = System.Drawing.Color.Black;
            this.radGroupSizingMode.HeaderImageIndex = -1;
            this.radGroupSizingMode.HeaderImageKey = "";
            this.radGroupSizingMode.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupSizingMode.HeaderText = " Sizing Mode ";
            this.radGroupSizingMode.Location = new System.Drawing.Point(10, 6);
            this.radGroupSizingMode.Name = "radGroupSizingMode";
            this.radGroupSizingMode.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupSizingMode.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupSizingMode.Size = new System.Drawing.Size(180, 156);
            this.radGroupSizingMode.TabIndex = 0;
            this.radGroupSizingMode.Text = " Sizing Mode ";
            // 
            // radRadioUpDown
            // 
            this.radRadioUpDown.ForeColor = System.Drawing.Color.Black;
            this.radRadioUpDown.Location = new System.Drawing.Point(13, 112);
            this.radRadioUpDown.Name = "radRadioUpDown";
            this.radRadioUpDown.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioUpDown.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioUpDown.Size = new System.Drawing.Size(64, 16);
            this.radRadioUpDown.TabIndex = 3;
            this.radRadioUpDown.Text = "UpDown";
            this.radRadioUpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioUpDown.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSizingMode_ToggleStateChanged);
            // 
            // radRadioBottomUpDown
            // 
            this.radRadioBottomUpDown.ForeColor = System.Drawing.Color.Black;
            this.radRadioBottomUpDown.Location = new System.Drawing.Point(13, 78);
            this.radRadioBottomUpDown.Name = "radRadioBottomUpDown";
            this.radRadioBottomUpDown.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioBottomUpDown.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioBottomUpDown.Size = new System.Drawing.Size(111, 29);
            this.radRadioBottomUpDown.TabIndex = 2;
            this.radRadioBottomUpDown.Text = "RightBottom and\r\nUpDown";
            this.radRadioBottomUpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioBottomUpDown.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSizingMode_ToggleStateChanged);
            // 
            // radRadioRightBottom
            // 
            this.radRadioRightBottom.ForeColor = System.Drawing.Color.Black;
            this.radRadioRightBottom.Location = new System.Drawing.Point(13, 57);
            this.radRadioRightBottom.Name = "radRadioRightBottom";
            this.radRadioRightBottom.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioRightBottom.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioRightBottom.Size = new System.Drawing.Size(83, 16);
            this.radRadioRightBottom.TabIndex = 1;
            this.radRadioRightBottom.Text = "RightBottom";
            this.radRadioRightBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioRightBottom.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSizingMode_ToggleStateChanged);
            // 
            // radRadioNone
            // 
            this.radRadioNone.ForeColor = System.Drawing.Color.Black;
            this.radRadioNone.Location = new System.Drawing.Point(13, 36);
            this.radRadioNone.Name = "radRadioNone";
            this.radRadioNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioNone.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioNone.Size = new System.Drawing.Size(47, 16);
            this.radRadioNone.TabIndex = 0;
            this.radRadioNone.Text = "None";
            this.radRadioNone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSizingMode_ToggleStateChanged);
            // 
            // radComboDemo
            // 
            this.radComboDemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radComboDemo.BackColor = System.Drawing.Color.Transparent;
            this.radComboDemo.DataSource = this.employeesBindingSource;
            this.radComboDemo.DisplayMember = "LastName";
            this.radComboDemo.DropDownHeight = 80;
            this.radComboDemo.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboDemo.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.Location = new System.Drawing.Point(28, 42);
            this.radComboDemo.Name = "radComboDemo";
            // 
            // 
            // 
            this.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.RootElement.ToolTipText = null;
            this.radComboDemo.Size = new System.Drawing.Size(306, 20);
            this.radComboDemo.TabIndex = 0;
            this.radComboDemo.TabStop = false;
            this.radComboDemo.Text = "";
            this.radComboDemo.ThemeName = "ControlDefault";
            this.radComboDemo.ValueMember = "EmployeeID";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(927, 736);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSizingMode)).EndInit();
            this.radGroupSizingMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioBottomUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRightBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupSizingMode;
        private Telerik.WinControls.UI.RadRadioButton radRadioUpDown;
        private Telerik.WinControls.UI.RadRadioButton radRadioBottomUpDown;
        private Telerik.WinControls.UI.RadRadioButton radRadioRightBottom;
        private Telerik.WinControls.UI.RadRadioButton radRadioNone;
        private Telerik.WinControls.UI.RadDropDownList radComboDemo;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
	}
}
