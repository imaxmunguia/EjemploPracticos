namespace Telerik.Examples.WinControls.GridView.ColumnChooser
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

                this.radGridView1.HideColumnChooser();
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radBtnLaunchColChooser = new Telerik.WinControls.UI.RadButton();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnLaunchColChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radBtnLaunchColChooser);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radBtnLaunchColChooser, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            gridViewTextBoxColumn1.FieldName = "ContactName";
            gridViewTextBoxColumn1.HeaderText = "Contact Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ContactName";
            gridViewTextBoxColumn1.Width = 128;
            gridViewTextBoxColumn2.FieldName = "CompanyName";
            gridViewTextBoxColumn2.HeaderText = "Company Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "CompanyName";
            gridViewTextBoxColumn2.Width = 207;
            gridViewTextBoxColumn3.FieldName = "City";
            gridViewTextBoxColumn3.HeaderText = "City";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "City";
            gridViewTextBoxColumn3.Width = 207;
            gridViewTextBoxColumn4.FieldName = "Country";
            gridViewTextBoxColumn4.HeaderText = "Country";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Country";
            gridViewTextBoxColumn4.Width = 207;
            gridViewTextBoxColumn5.FieldName = "Phone";
            gridViewTextBoxColumn5.HeaderText = "Phone";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Phone";
            gridViewTextBoxColumn5.Width = 207;
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5);
            this.radGridView1.MasterTemplate.DataSource = this.customersBindingSource;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(1224, 737);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Telerik";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindRadGridView;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radBtnLaunchColChooser
            // 
            this.radBtnLaunchColChooser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radBtnLaunchColChooser.BackColor = System.Drawing.Color.Transparent;
            this.radBtnLaunchColChooser.Location = new System.Drawing.Point(10, 6);
            this.radBtnLaunchColChooser.Name = "radBtnLaunchColChooser";
            this.radBtnLaunchColChooser.Size = new System.Drawing.Size(180, 47);
            this.radBtnLaunchColChooser.TabIndex = 5;
            this.radBtnLaunchColChooser.Text = "Launch Column Chooser";
            this.radBtnLaunchColChooser.ThemeName = "Telerik";
            this.radBtnLaunchColChooser.Click += new System.EventHandler(this.btnOpenCondFormatting_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnLaunchColChooser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private Telerik.WinControls.UI.RadButton radBtnLaunchColChooser;
        private Telerik.WinControls.UI.RadGridView radGridView1;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}
