namespace Telerik.Examples.WinControls.TreeView.Populating.SelfReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureLT2008DataSet = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.employeeTableAdapter = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.adventureLT2008DataSet;
            // 
            // adventureLT2008DataSet
            // 
            this.adventureLT2008DataSet.DataSetName = "AdventureLT2008DataSet";
            this.adventureLT2008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User Business Male.png");
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTreeView1.ImageIndex = 0;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(13, 8);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(325, 483);
            this.radTreeView1.TabIndex = 1;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // Form1
            // 
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1183, 749);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.AdventureLT2008DataSet adventureLT2008DataSet;
        private DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
	}
}
