namespace Telerik.Examples.WinControls.TreeView.Serialization
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode10 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode11 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode12 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode13 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode14 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode15 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode16 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.btnAddRoot = new Telerik.WinControls.UI.RadButton();
            this.btnAddChild = new Telerik.WinControls.UI.RadButton();
            this.btnLoadFile = new Telerik.WinControls.UI.RadButton();
            this.btnSaveFile = new Telerik.WinControls.UI.RadButton();
            this.btnRemove = new Telerik.WinControls.UI.RadButton();
            this.radGroupNodeOpts = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupXml = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNodeOpts)).BeginInit();
            this.radGroupNodeOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupXml)).BeginInit();
            this.radGroupXml.SuspendLayout();
            this.SuspendLayout();
          
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupXml);
            this.settingsPanel.Controls.Add(this.radGroupNodeOpts);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupNodeOpts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupXml, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AllowDragDrop = true;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode2.Expanded = true;
            radTreeNode3.Text = "Node15";
            radTreeNode4.Text = "Node16";
            radTreeNode2.Nodes.Add(radTreeNode3);
            radTreeNode2.Nodes.Add(radTreeNode4);
            radTreeNode2.Text = "Node7";
            radTreeNode5.Expanded = true;
            radTreeNode6.Text = "Node14";
            radTreeNode5.Nodes.Add(radTreeNode6);
            radTreeNode5.Text = "Node8";
            radTreeNode7.Text = "Node9";
            radTreeNode1.Nodes.Add(radTreeNode2);
            radTreeNode1.Nodes.Add(radTreeNode5);
            radTreeNode1.Nodes.Add(radTreeNode7);
            radTreeNode1.Text = "Node1";
            radTreeNode8.Expanded = true;
            radTreeNode9.Text = "Node10";
            radTreeNode10.Text = "Node11";
            radTreeNode8.Nodes.Add(radTreeNode9);
            radTreeNode8.Nodes.Add(radTreeNode10);
            radTreeNode8.Text = "Node2";
            radTreeNode11.Text = "Node3";
            radTreeNode12.Expanded = true;
            radTreeNode13.Text = "Node12";
            radTreeNode14.Text = "Node13";
            radTreeNode12.Nodes.Add(radTreeNode13);
            radTreeNode12.Nodes.Add(radTreeNode14);
            radTreeNode12.Text = "Node4";
            radTreeNode15.Text = "Node5";
            radTreeNode16.Text = "Node6";
            this.radTreeView1.Nodes.Add(radTreeNode1);
            this.radTreeView1.Nodes.Add(radTreeNode8);
            this.radTreeView1.Nodes.Add(radTreeNode11);
            this.radTreeView1.Nodes.Add(radTreeNode12);
            this.radTreeView1.Nodes.Add(radTreeNode15);
            this.radTreeView1.Nodes.Add(radTreeNode16);
            this.radTreeView1.Size = new System.Drawing.Size(290, 400);
            this.radTreeView1.Location = new System.Drawing.Point(10, 20);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(14, 31);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(133, 23);
            this.btnAddRoot.TabIndex = 1;
            this.btnAddRoot.Text = "Add Root Node";
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(14, 60);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(133, 23);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "Add Child Node";
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(14, 28);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(133, 23);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Load XML File";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(14, 57);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(133, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save XML File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(14, 89);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Selected Node";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // radGroupNodeOpts
            // 
            this.radGroupNodeOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupNodeOpts.Controls.Add(this.btnAddRoot);
            this.radGroupNodeOpts.Controls.Add(this.btnRemove);
            this.radGroupNodeOpts.Controls.Add(this.btnAddChild);
            this.radGroupNodeOpts.FooterImageIndex = -1;
            this.radGroupNodeOpts.FooterImageKey = "";
            this.radGroupNodeOpts.ForeColor = System.Drawing.Color.Black;
            this.radGroupNodeOpts.HeaderImageIndex = -1;
            this.radGroupNodeOpts.HeaderImageKey = "";
            this.radGroupNodeOpts.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupNodeOpts.HeaderText = "Node Actions";
            this.radGroupNodeOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupNodeOpts.Name = "radGroupNodeOpts";
            this.radGroupNodeOpts.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupNodeOpts.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupNodeOpts.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupNodeOpts.Size = new System.Drawing.Size(180, 125);
            this.radGroupNodeOpts.TabIndex = 0;
            this.radGroupNodeOpts.Text = "Node Actions";
            // 
            // radGroupXml
            // 
            this.radGroupXml.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupXml.Controls.Add(this.btnLoadFile);
            this.radGroupXml.Controls.Add(this.btnSaveFile);
            this.radGroupXml.FooterImageIndex = -1;
            this.radGroupXml.FooterImageKey = "";
            this.radGroupXml.ForeColor = System.Drawing.Color.Black;
            this.radGroupXml.HeaderImageIndex = -1;
            this.radGroupXml.HeaderImageKey = "";
            this.radGroupXml.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupXml.HeaderText = "XML Actions";
            this.radGroupXml.Location = new System.Drawing.Point(10, 151);
            this.radGroupXml.Name = "radGroupXml";
            this.radGroupXml.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupXml.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupXml.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupXml.Size = new System.Drawing.Size(180, 95);
            this.radGroupXml.TabIndex = 1;
            this.radGroupXml.Text = "XML Actions";
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.Controls.Add(this.radTreeView1);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNodeOpts)).EndInit();
            this.radGroupNodeOpts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupXml)).EndInit();
            this.radGroupXml.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadTreeView radTreeView1;
		private Telerik.WinControls.UI.RadButton btnAddRoot;
		private Telerik.WinControls.UI.RadButton btnAddChild;
		private Telerik.WinControls.UI.RadButton btnLoadFile;
		private Telerik.WinControls.UI.RadButton btnSaveFile;
		private Telerik.WinControls.UI.RadButton btnRemove;
        private Telerik.WinControls.UI.RadGroupBox radGroupXml;
        private Telerik.WinControls.UI.RadGroupBox radGroupNodeOpts;
	}
}