using System.ComponentModel;
using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
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
            this.components = new Container();
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem8 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem9 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem10 = new Telerik.WinControls.UI.RadListDataItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(240, 272);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(642, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            // 
            // radComboDemo
            // 
            this.radComboDemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radComboDemo.BackColor = System.Drawing.Color.Transparent;
            this.radComboDemo.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboDemo.ForeColor = System.Drawing.Color.Black;            
            this.radComboDemo.Items.AddRange(new RadListDataItem[] {
            this.radComboBoxItem1,
            this.radComboBoxItem2,
            this.radComboBoxItem3,
            this.radComboBoxItem4,
            this.radComboBoxItem5,
            this.radComboBoxItem6,
            this.radComboBoxItem7,
            this.radComboBoxItem8,
            this.radComboBoxItem9,
            this.radComboBoxItem10});
            this.radComboDemo.Location = new System.Drawing.Point(19, 40);            
            this.radComboDemo.Name = "radComboDemo";
            this.radComboDemo.NullText = "Select Car...";
            // 
            // 
            // 
            this.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.RootElement.ToolTipText = null;
            this.radComboDemo.Size = new System.Drawing.Size(324, 20);
            this.radComboDemo.TabIndex = 0;
            this.radComboDemo.TabStop = false;
            // 
            // radComboBoxItem1
            // 
            //this.radComboBoxItem1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem1.Image = this.GetImageFromResource("SSC Ultimate Aero.png");
            this.radComboBoxItem1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            //this.radComboBoxItem1.Name = "radComboBoxItem1";
            this.radComboBoxItem1.Text = "SSC Ultimate Aero";
           // this.radComboBoxItem1.DescriptionText = "<html><size=9><font=Arial><b>Maximum Speed: </b>257 <i>mph</i><br><size=9><font=Arial><b>Horse Power:</b>1,187 <i>bhp</i>";
            //this.radComboBoxItem1.DescriptionText = "<html><p><span style=\"font-size: large\">RadLabel</span></p><p><span style=\"font-size: medium\"><strong>Arial, Bold</strong></span></p><p><span style=\"font-size: 18px\"><em><span style=\"font-family: times new roman\">Times, Italic, <u>Underline</u></span></em></span></p><p><em><span style=\"font-family: times new roman; color: #0080ff; font-size: 18px\">Sample Text</span></em></p></html>";
            this.radComboBoxItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radComboBoxItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            
            // 
            // radComboBoxItem2
            // 
            this.radComboBoxItem2.Image = this.GetImageFromResource("Bugatti Veyron.png");
            this.radComboBoxItem2.Text = "Bugatti Veyron";
            this.radComboBoxItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radComboBoxItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            
            // 
            // radComboBoxItem3
            // 
            //this.radComboBoxItem3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem3.Image = this.GetImageFromResource("Koenigsegg CCX.png");
            //this.radComboBoxItem3.Name = "radComboBoxItem3";
            this.radComboBoxItem3.Text = "Koenigsegg CCX";
            this.radComboBoxItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            //this.radComboBoxItem3.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>250 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>806 <i>bhp</i>";
            this.radComboBoxItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            //this.radComboBoxItem3.ToolTipText = null;
            // 
            // radComboBoxItem4
            // 
            //this.radComboBoxItem4.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem4.Image = this.GetImageFromResource("Saleen S7 Twin-Turbo.png");
            //this.radComboBoxItem4.Name = "radComboBoxItem4";
            this.radComboBoxItem4.Text = "Saleen S7 Twin-Turbo";
            this.radComboBoxItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            //this.radComboBoxItem4.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>248 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>750 <i>bhp</i>";
            this.radComboBoxItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            //this.radComboBoxItem4.ToolTipText = null;
            // 
            // radComboBoxItem5
            // 
            //this.radComboBoxItem5.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem5.Image = this.GetImageFromResource("McLaren F1.png");
            //this.radComboBoxItem5.Name = "radComboBoxItem5";
            this.radComboBoxItem5.Text = "McLaren F1";
            //this.radComboBoxItem5.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>240 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>627 <i>bhp</i>";
            this.radComboBoxItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radComboBoxItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft; 
            //this.radComboBoxItem5.ToolTipText = null;
            // 
            // radComboBoxItem6
            // 
            //this.radComboBoxItem6.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem6.Image = this.GetImageFromResource("Ferrari Enzo.png");
            //this.radComboBoxItem6.Name = "radComboBoxItem6";
            this.radComboBoxItem6.Text = "Ferrari Enzo";
            //this.radComboBoxItem6.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>217 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>660 <i>bhp</i>";
            this.radComboBoxItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radComboBoxItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            //this.radComboBoxItem6.ToolTipText = null;
            // 
            // radComboBoxItem7
            // 
            //this.radComboBoxItem7.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem7.Image = this.GetImageFromResource("Jaguar XJ220.png");
            //this.radComboBoxItem7.Name = "radComboBoxItem7";
            this.radComboBoxItem7.Text = "Jaguar XJ220";
            //this.radComboBoxItem7.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>217 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>542 <i>bhp</i>";
            this.radComboBoxItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radComboBoxItem7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            //this.radComboBoxItem7.ToolTipText = null;
            // 
            // radComboBoxItem8
            //
            //this.radComboBoxItem8.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>219 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>550 <i>bhp</i>";
            //this.radComboBoxItem8.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem8.Image = this.GetImageFromResource("Lamborghini Murcielago LP640.png");
            //this.radComboBoxItem8.Name = "radComboBoxItem10";
            this.radComboBoxItem8.Text = "Lamborghini Murcielago";
            this.radComboBoxItem8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radComboBoxItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            //this.radComboBoxItem8.ToolTipText = null;
            // 
            // radComboBoxItem9
            // 
            //this.radComboBoxItem9.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>215 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>650 <i>bhp</i>";
            //this.radComboBoxItem9.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem9.Image = this.GetImageFromResource("Pagani Zonda F.png");
            //this.radComboBoxItem9.Name = "radComboBoxItem9";
            this.radComboBoxItem9.Text = "Pagani Zonda F";
            this.radComboBoxItem9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radComboBoxItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            //this.radComboBoxItem9.ToolTipText = null;
            // 
            // radComboBoxItem10
            // 
            //this.radComboBoxItem10.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>215 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>650 <i>bhp</i>";
            //this.radComboBoxItem10.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.radComboBoxItem10.Image = this.GetImageFromResource("Porsche Carrera GT.png");
            //this.radComboBoxItem10.Name = "radComboBoxItem10";
            this.radComboBoxItem10.Text = "Porsche Carrera GT";
            this.radComboBoxItem10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radComboBoxItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            //this.radComboBoxItem10.ToolTipText = null;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(843, 643);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList radComboDemo;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem5;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem6;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem7;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem8;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem9;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem10;
    }
}

