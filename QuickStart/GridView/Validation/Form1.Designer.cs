﻿namespace Telerik.Examples.WinControls.GridView.Validation
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.order_DetailsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor2 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radComboBox3 = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBox2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBox1 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(844, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 585);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "OrderID";
            gridViewDecimalColumn1.HeaderText = "OrderID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "OrderID";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ProductID";
            gridViewDecimalColumn2.HeaderText = "ProductID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductID";
            gridViewDecimalColumn3.DataType = typeof(decimal);
            gridViewDecimalColumn3.FieldName = "UnitPrice";
            gridViewDecimalColumn3.HeaderText = "UnitPrice";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "UnitPrice";
            gridViewDecimalColumn4.DataType = typeof(short);
            gridViewDecimalColumn4.FieldName = "Quantity";
            gridViewDecimalColumn4.HeaderText = "Quantity";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Quantity";
            gridViewDecimalColumn5.DataType = typeof(float);
            gridViewDecimalColumn5.FieldName = "Discount";
            gridViewDecimalColumn5.HeaderText = "Discount";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "Discount";
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn4);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn5);
            this.radGridView1.MasterTemplate.DataSource = this.orderDetailsBindingSource;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(1045, 587);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.ThemeName = "ControlDefault";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            this.radGridView1.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.radGridView1_RowFormatting);
            this.radGridView1.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.radGridView1_CellValidating);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSpinEditor2);
            this.radGroupBox1.Controls.Add(this.radSpinEditor1);
            this.radGroupBox1.Controls.Add(this.radComboBox3);
            this.radGroupBox1.Controls.Add(this.radComboBox2);
            this.radGroupBox1.Controls.Add(this.radComboBox1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Column restrictions:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 46);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.Size = new System.Drawing.Size(180, 190);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Column restrictions:";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(17, 110);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Size = new System.Drawing.Size(23, 14);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "and";
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.BackColor = System.Drawing.Color.White;
            this.radSpinEditor2.ForeColor = System.Drawing.Color.Black;
            this.radSpinEditor2.Location = new System.Drawing.Point(17, 156);
            this.radSpinEditor2.Name = "radSpinEditor2";
            // 
            // 
            // 
            this.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSpinEditor2.ShowBorder = true;
            this.radSpinEditor2.Size = new System.Drawing.Size(78, 20);
            this.radSpinEditor2.TabIndex = 4;
            this.radSpinEditor2.Text = "radSpinEditor2";
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.BackColor = System.Drawing.Color.White;
            this.radSpinEditor1.ForeColor = System.Drawing.Color.Black;
            this.radSpinEditor1.Location = new System.Drawing.Point(17, 84);
            this.radSpinEditor1.Name = "radSpinEditor1";
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSpinEditor1.ShowBorder = true;
            this.radSpinEditor1.Size = new System.Drawing.Size(78, 20);
            this.radSpinEditor1.TabIndex = 3;
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            // 
            // radComboBox3
            // 
            this.radComboBox3.ForeColor = System.Drawing.Color.Black;
            this.radComboBox3.Location = new System.Drawing.Point(17, 130);
            this.radComboBox3.Name = "radComboBox3";
            // 
            // 
            // 
            this.radComboBox3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboBox3.Size = new System.Drawing.Size(147, 20);
            this.radComboBox3.TabIndex = 2;
            this.radComboBox3.Text = "radComboBox3";
            this.radComboBox3.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox3_SelectedIndexChanged);
            // 
            // radComboBox2
            // 
            this.radComboBox2.ForeColor = System.Drawing.Color.Black;
            this.radComboBox2.Location = new System.Drawing.Point(17, 58);
            this.radComboBox2.Name = "radComboBox2";
            // 
            // 
            // 
            this.radComboBox2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboBox2.Size = new System.Drawing.Size(147, 20);
            this.radComboBox2.TabIndex = 1;
            this.radComboBox2.Text = "radComboBox2";
            this.radComboBox2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox2_SelectedIndexChanged);
            // 
            // radComboBox1
            // 
            this.radComboBox1.ForeColor = System.Drawing.Color.Black;
            this.radComboBox1.Location = new System.Drawing.Point(17, 32);
            this.radComboBox1.Name = "radComboBox1";
            // 
            // 
            // 
            this.radComboBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboBox1.Size = new System.Drawing.Size(147, 20);
            this.radComboBox1.TabIndex = 0;
            this.radComboBox1.Text = "radComboBox1";
            this.radComboBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1045, 587);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList radComboBox1;
        private Telerik.WinControls.UI.RadDropDownList radComboBox3;
        private Telerik.WinControls.UI.RadDropDownList radComboBox2;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
