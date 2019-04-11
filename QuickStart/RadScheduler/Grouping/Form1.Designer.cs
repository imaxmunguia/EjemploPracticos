namespace Telerik.Examples.WinControls.RadScheduler.Grouping
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
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1042, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 269);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // radSchedulerDemo
            // 
            this.radSchedulerDemo.BackColor = System.Drawing.Color.White;
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerDemo.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radSchedulerDemo.HeaderFormat = "MMMM dd";
            this.radSchedulerDemo.Location = new System.Drawing.Point(0, 78);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            // 
            // 
            // 
            this.radSchedulerDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerDemo.Size = new System.Drawing.Size(1243, 193);
            this.radSchedulerDemo.TabIndex = 0;
            this.radSchedulerDemo.Text = "radScheduler1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.MinimumSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1243, 78);
            this.radSchedulerNavigator1.TabIndex = 0;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.ThemeName = "ControlDefault";
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.radSchedulerDemo);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1243, 271);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
    }
}
