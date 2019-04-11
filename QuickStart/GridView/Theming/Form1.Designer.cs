using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.GridView.Theming
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.aggregatesSampleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.aggregatesSampleTableTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aggregatesSampleTableBindingSource
            // 
            this.aggregatesSampleTableBindingSource.DataMember = "EmployeeOrders";
            this.aggregatesSampleTableBindingSource.DataSource = this.nwindRadGridView;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aggregatesSampleTableTableAdapter
            // 
            this.aggregatesSampleTableTableAdapter.ClearBeforeFill = true;
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ForeColor = System.Drawing.Color.White;
            this.radGridView1.Location = new System.Drawing.Point(20, 43);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            gridViewTextBoxColumn8.FieldName = "FirstName";
            gridViewTextBoxColumn8.FormatString = "{0}";
            gridViewTextBoxColumn8.HeaderText = "FirstName";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "FirstName";
            gridViewTextBoxColumn9.FieldName = "LastName";
            gridViewTextBoxColumn9.FormatString = "{0}";
            gridViewTextBoxColumn9.HeaderText = "LastName";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn9.Name = "LastName";
            gridViewTextBoxColumn10.FieldName = "Title";
            gridViewTextBoxColumn10.FormatString = "{0}";
            gridViewTextBoxColumn10.HeaderText = "Title";
            gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn10.Name = "Title";
            gridViewTextBoxColumn11.FieldName = "City";
            gridViewTextBoxColumn11.FormatString = "{0}";
            gridViewTextBoxColumn11.HeaderText = "City";
            gridViewTextBoxColumn11.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn11.Name = "City";
            gridViewTextBoxColumn12.FieldName = "Country";
            gridViewTextBoxColumn12.FormatString = "{0}";
            gridViewTextBoxColumn12.HeaderText = "Country";
            gridViewTextBoxColumn12.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn12.Name = "Country";
            gridViewTextBoxColumn13.FieldName = "ShipName";
            gridViewTextBoxColumn13.FormatString = "{0}";
            gridViewTextBoxColumn13.HeaderText = "ShipName";
            gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn13.Name = "ShipName";
            gridViewDecimalColumn2.DataType = typeof(decimal);
            gridViewDecimalColumn2.FieldName = "UnitPrice";
            gridViewDecimalColumn2.FormatString = "{0}";
            gridViewDecimalColumn2.HeaderText = "UnitPrice";
            gridViewDecimalColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewDecimalColumn2.Name = "UnitPrice";
            gridViewTextBoxColumn14.DataType = typeof(short);
            gridViewTextBoxColumn14.FieldName = "Quantity";
            gridViewTextBoxColumn14.FormatString = "{0}";
            gridViewTextBoxColumn14.HeaderText = "Quantity";
            gridViewTextBoxColumn14.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn14.Name = "Quantity";
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn11);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn12);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn13);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn14);
            this.radGridView1.MasterTemplate.DataSource = this.aggregatesSampleTableBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;

            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.White;
            this.radGridView1.Size = new System.Drawing.Size(994, 676);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.radCheckBox1.ForeColor = System.Drawing.Color.White;
            this.radCheckBox1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.Location = new System.Drawing.Point(38, 14);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.White;
            this.radCheckBox1.Size = new System.Drawing.Size(121, 17);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Enable HotTracking";
            this.radCheckBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBox1.GetChildAt(0))).Text = "Enable HotTracking";
            ((Telerik.WinControls.Primitives.CheckPrimitive)(this.radCheckBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.radCheckBox1);
            this.Controls.Add(this.radGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1039, 722);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private BindingSource aggregatesSampleTableBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter aggregatesSampleTableTableAdapter;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
	}
}
