namespace Telerik.Examples.WinControls.GridView.Expressions
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupPreDef = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupNumericText = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioAverage = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radRadioNumExpr2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioNumExpr1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupCheckBox = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radRadioCheckExpr2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCheckExpr1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radButtonExprEditor = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupPreDef)).BeginInit();
            this.radGroupPreDef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNumericText)).BeginInit();
            this.radGroupNumericText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCheckBox)).BeginInit();
            this.radGroupCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupPreDef);
            this.settingsPanel.Controls.Add(this.radButtonExprEditor);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(751, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 806);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupPreDef, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(186, 286);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowColumnChooser = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.MultiSelect = true;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.MultiSelect = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(580, 176);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Telerik";
            // 
            // radGroupPreDef
            // 
            this.radGroupPreDef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupPreDef.Controls.Add(this.radGroupNumericText);
            this.radGroupPreDef.Controls.Add(this.radGroupCheckBox);
            this.radGroupPreDef.FooterImageIndex = -1;
            this.radGroupPreDef.FooterImageKey = "";
            this.radGroupPreDef.ForeColor = System.Drawing.Color.Black;
            this.radGroupPreDef.HeaderImageIndex = -1;
            this.radGroupPreDef.HeaderImageKey = "";
            this.radGroupPreDef.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupPreDef.HeaderText = "Predefined Expressions";
            this.radGroupPreDef.Location = new System.Drawing.Point(10, 6);
            this.radGroupPreDef.Name = "radGroupPreDef";
            this.radGroupPreDef.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupPreDef.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupPreDef.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupPreDef.Size = new System.Drawing.Size(180, 264);
            this.radGroupPreDef.TabIndex = 0;
            this.radGroupPreDef.Text = "Predefined Expressions";
            // 
            // radGroupNumericText
            // 
            this.radGroupNumericText.Controls.Add(this.radRadioAverage);
            this.radGroupNumericText.Controls.Add(this.radLabel3);
            this.radGroupNumericText.Controls.Add(this.radRadioNumExpr2);
            this.radGroupNumericText.Controls.Add(this.radRadioNumExpr1);
            this.radGroupNumericText.FooterImageIndex = -1;
            this.radGroupNumericText.FooterImageKey = "";
            this.radGroupNumericText.ForeColor = System.Drawing.Color.Black;
            this.radGroupNumericText.HeaderImageIndex = -1;
            this.radGroupNumericText.HeaderImageKey = "";
            this.radGroupNumericText.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupNumericText.HeaderText = "NumericText Column";
            this.radGroupNumericText.Location = new System.Drawing.Point(9, 24);
            this.radGroupNumericText.Name = "radGroupNumericText";
            this.radGroupNumericText.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupNumericText.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupNumericText.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupNumericText.Size = new System.Drawing.Size(144, 116);
            this.radGroupNumericText.TabIndex = 1;
            this.radGroupNumericText.Text = "NumericText Column";
            // 
            // radRadioAverage
            // 
            this.radRadioAverage.ForeColor = System.Drawing.Color.Black;
            this.radRadioAverage.Location = new System.Drawing.Point(6, 91);
            this.radRadioAverage.Name = "radRadioAverage";
            // 
            // 
            // 
            this.radRadioAverage.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioAverage.Size = new System.Drawing.Size(88, 16);
            this.radRadioAverage.TabIndex = 2;
            this.radRadioAverage.Text = "Avg(Decimal)";
            this.radRadioAverage.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(6, 27);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Size = new System.Drawing.Size(102, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Choose expression:";
            // 
            // radRadioNumExpr2
            // 
            this.radRadioNumExpr2.ForeColor = System.Drawing.Color.Black;
            this.radRadioNumExpr2.Location = new System.Drawing.Point(6, 69);
            this.radRadioNumExpr2.Name = "radRadioNumExpr2";
            // 
            // 
            // 
            this.radRadioNumExpr2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioNumExpr2.Size = new System.Drawing.Size(86, 16);
            this.radRadioNumExpr2.TabIndex = 5;
            this.radRadioNumExpr2.Text = "Decimal + 15";
            this.radRadioNumExpr2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            // 
            // radRadioNumExpr1
            // 
            this.radRadioNumExpr1.ForeColor = System.Drawing.Color.Black;
            this.radRadioNumExpr1.Location = new System.Drawing.Point(6, 47);
            this.radRadioNumExpr1.Name = "radRadioNumExpr1";
            // 
            // 
            // 
            this.radRadioNumExpr1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioNumExpr1.Size = new System.Drawing.Size(102, 16);
            this.radRadioNumExpr1.TabIndex = 3;
            this.radRadioNumExpr1.Text = "(Decimal - 3) * 2";
            this.radRadioNumExpr1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            // 
            // radGroupCheckBox
            // 
            this.radGroupCheckBox.Controls.Add(this.radLabel5);
            this.radGroupCheckBox.Controls.Add(this.radRadioCheckExpr2);
            this.radGroupCheckBox.Controls.Add(this.radRadioCheckExpr1);
            this.radGroupCheckBox.FooterImageIndex = -1;
            this.radGroupCheckBox.FooterImageKey = "";
            this.radGroupCheckBox.ForeColor = System.Drawing.Color.Black;
            this.radGroupCheckBox.HeaderImageIndex = -1;
            this.radGroupCheckBox.HeaderImageKey = "";
            this.radGroupCheckBox.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupCheckBox.HeaderText = "CheckBox Column";
            this.radGroupCheckBox.Location = new System.Drawing.Point(9, 145);
            this.radGroupCheckBox.Name = "radGroupCheckBox";
            this.radGroupCheckBox.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupCheckBox.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupCheckBox.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupCheckBox.Size = new System.Drawing.Size(144, 109);
            this.radGroupCheckBox.TabIndex = 1;
            this.radGroupCheckBox.Text = "CheckBox Column";
            // 
            // radLabel5
            // 
            this.radLabel5.ForeColor = System.Drawing.Color.Black;
            this.radLabel5.Location = new System.Drawing.Point(6, 26);
            this.radLabel5.Name = "radLabel5";
            // 
            // 
            // 
            this.radLabel5.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel5.Size = new System.Drawing.Size(102, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Choose expression:";
            // 
            // radRadioCheckExpr2
            // 
            this.radRadioCheckExpr2.ForeColor = System.Drawing.Color.Black;
            this.radRadioCheckExpr2.Location = new System.Drawing.Point(7, 68);
            this.radRadioCheckExpr2.Name = "radRadioCheckExpr2";
            // 
            // 
            // 
            this.radRadioCheckExpr2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioCheckExpr2.Size = new System.Drawing.Size(140, 16);
            this.radRadioCheckExpr2.TabIndex = 5;
            // 
            // radRadioCheckExpr1
            // 
            this.radRadioCheckExpr1.ForeColor = System.Drawing.Color.Black;
            this.radRadioCheckExpr1.Location = new System.Drawing.Point(7, 46);
            this.radRadioCheckExpr1.Name = "radRadioCheckExpr1";
            // 
            // 
            // 
            this.radRadioCheckExpr1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioCheckExpr1.Size = new System.Drawing.Size(138, 16);
            this.radRadioCheckExpr1.TabIndex = 3;
            this.radRadioCheckExpr1.Text = "Decimal < 600";
            this.radRadioCheckExpr1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCheckExpr1_ToggleStateChanged);
            //
            // radButtonExprEditor
            //
            this.radButtonExprEditor.Size = new System.Drawing.Size(120, 28);
            this.radButtonExprEditor.Location = new System.Drawing.Point(0, 300);
            this.radButtonExprEditor.Text = "Show Expression Editor";
            this.radButtonExprEditor.Click += new System.EventHandler(radButtonExprEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(952, 808);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupPreDef)).EndInit();
            this.radGroupPreDef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNumericText)).EndInit();
            this.radGroupNumericText.ResumeLayout(false);
            this.radGroupNumericText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNumExpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupCheckBox)).EndInit();
            this.radGroupCheckBox.ResumeLayout(false);
            this.radGroupCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCheckExpr1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupPreDef;
        private Telerik.WinControls.UI.RadRadioButton radRadioNumExpr1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadRadioButton radRadioNumExpr2;
        private Telerik.WinControls.UI.RadGroupBox radGroupNumericText;
        private Telerik.WinControls.UI.RadGroupBox radGroupCheckBox;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadRadioButton radRadioCheckExpr2;
        private Telerik.WinControls.UI.RadRadioButton radRadioCheckExpr1;
        private Telerik.WinControls.UI.RadRadioButton radRadioAverage;
        private Telerik.WinControls.UI.RadButton radButtonExprEditor;
    }
}