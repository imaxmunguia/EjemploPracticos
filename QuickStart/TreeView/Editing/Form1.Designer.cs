namespace Telerik.Examples.WinControls.TreeView.Editing
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radCheckBoxAllowEdit = new Telerik.WinControls.UI.RadCheckBox();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.Examples.TreeExampleHeaderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxAllowEdit);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(727, 970);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxAllowEdit, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(246, 470);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // radPanel1
            // 
            this.radPanel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.Location = new System.Drawing.Point(300, 155);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(280, 115);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.Text = "Hello world!";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Text = "Hello world!";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Width = 5F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Black;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 3;
            // 
            // radCheckBoxAllowEdit
            // 
            this.radCheckBoxAllowEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxAllowEdit.Location = new System.Drawing.Point(10, 37);
            this.radCheckBoxAllowEdit.Name = "radCheckBoxAllowEdit";
            this.radCheckBoxAllowEdit.Size = new System.Drawing.Size(70, 18);
            this.radCheckBoxAllowEdit.TabIndex = 1;
            this.radCheckBoxAllowEdit.Text = "Allow Edit";
            this.radCheckBoxAllowEdit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxAllowEdit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAllowEdit_ToggleStateChanged);
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radTreeView1);
            this.radPanel4.Controls.Add(this.radPanel1);
            this.radPanel4.Location = new System.Drawing.Point(17, 56);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(639, 470);
            this.radPanel4.TabIndex = 3;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel3
            // 
            this.radPanel3.Location = new System.Drawing.Point(17, 20);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(639, 36);
            this.radPanel3.TabIndex = 2;
            this.radPanel3.Text = "Property manager";
            // 
            // Form1
            // 
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel4);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1183, 749);
            this.Controls.SetChildIndex(this.radPanel4, 0);
            this.Controls.SetChildIndex(this.radPanel3, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAllowEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAllowEdit;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.Examples.TreeExampleHeaderPanel radPanel3;
    }
}
