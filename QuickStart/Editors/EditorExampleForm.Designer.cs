using Telerik.QuickStart.WinControls;
namespace Telerik.Examples.WinControls.Editors.ComboBox
{
    partial class EditorExampleBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radPanelDemoHolder = new Telerik.WinControls.UI.RadPanel();
            this.roudRectShape = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(716, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 598);
            this.settingsPanel.ThemeName = MainForm.DefaultTheme;
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(277, 250);
            this.radPanelDemoHolder.Name = "radPanelDemoHolder";
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(200, 100);
            this.radPanelDemoHolder.TabIndex = 1;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanelDemoHolder.GetChildAt(0))).Shape = this.roudRectShape;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).NumberOfColors = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).GradientPercentage = 0.3F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).GradientPercentage2 = 0.01F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            // 
            // roudRectShape
            // 
            this.roudRectShape.Radius = 10;
            // 
            // EditorExampleBaseForm
            // 
            this.Controls.Add(this.radPanelDemoHolder);
            this.Name = "EditorExampleBaseForm";
            this.Size = new System.Drawing.Size(917, 600);
            this.Controls.SetChildIndex(this.radPanelDemoHolder, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Telerik.WinControls.RoundRectShape roudRectShape;
        protected Telerik.WinControls.UI.RadPanel radPanelDemoHolder;
    }
}