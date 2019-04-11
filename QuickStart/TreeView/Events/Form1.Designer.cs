namespace Telerik.Examples.WinControls.TreeView.Events
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
            this.radListBox1 = new Telerik.WinControls.UI.RadListControl();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.clearEventsBtn = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearEventsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();           
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radListBox1
            // 
            this.radListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radListBox1.ForeColor = System.Drawing.Color.Black;
            this.radListBox1.Location = new System.Drawing.Point(10, 25);
            this.radListBox1.Name = "radListBox1";
            // 
            // 
            // 
            this.radListBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radListBox1.Size = new System.Drawing.Size(163, 291);
            this.radListBox1.TabIndex = 1;
            // 
            // radTreeView1
            // 
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.Name = "radTreeView1";            
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.Location = new System.Drawing.Point(20, 17);
            this.radTreeView1.Size = new System.Drawing.Size(246, 441);
            this.radTreeView1.ItemHeight = 27;
            // 
            // clearEventsBtn
            // 
            this.clearEventsBtn.Location = new System.Drawing.Point(23, 322);
            this.clearEventsBtn.Name = "clearEventsBtn";
            this.clearEventsBtn.Size = new System.Drawing.Size(120, 23);
            this.clearEventsBtn.TabIndex = 2;
            this.clearEventsBtn.Text = "Clear";
            this.clearEventsBtn.Click += new System.EventHandler(this.clearEventsBtn_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.clearEventsBtn);
            this.radGroupBox1.Controls.Add(this.radListBox1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = " Events ";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 357);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = " Events ";
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            this.Controls.Add(this.radTreeView1);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearEventsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListBox1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadButton clearEventsBtn;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;

    }
}
