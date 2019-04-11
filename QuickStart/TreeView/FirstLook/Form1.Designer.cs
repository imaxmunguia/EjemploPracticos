using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.FirstLook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radPanel1 = new Telerik.Examples.TreeExampleHeaderPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(982, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // btnSpy
            // 
            this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
            this.btnSpy.Location = new System.Drawing.Point(10, 7);
            this.btnSpy.Name = "btnSpy";
            this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            // 
            // 
            // 
            this.btnSpy.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSpy.Size = new System.Drawing.Size(180, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpy.ThemeName = "ControlDefault";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_feed.png");
            this.imageList1.Images.SetKeyName(1, "feed.png");
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Location = new System.Drawing.Point(7, 51);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(619, 30);
            this.radPanel1.TabIndex = 1;
            // 
            // radPanel2
            // 
            this.radPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            this.radPanel2.BackColor = System.Drawing.Color.Transparent;
            this.radPanel2.Controls.Add(this.radTreeView1);
            this.radPanel2.Controls.Add(this.radPanel3);
            this.radPanel2.Controls.Add(this.radPanel1);
            this.radPanel2.Location = new System.Drawing.Point(31, 50);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(633, 427);
            this.radPanel2.TabIndex = 2;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(233)))));
            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTreeView1.ImageIndex = 0;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(7, 81);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(619, 339);
            this.radTreeView1.TabIndex = 3;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.NodeFormatting += new Telerik.WinControls.UI.TreeNodeFormattingEventHandler(this.radTreeView1_NodeFormatting);
            // 
            // radPanel3
            // 
            this.radPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel3.BackColor = System.Drawing.Color.Transparent;
            this.radPanel3.Controls.Add(this.radDropDownButton1);
            this.radPanel3.Controls.Add(this.radLabel1);
            this.radPanel3.Controls.Add(this.radTextBox1);
            this.radPanel3.Location = new System.Drawing.Point(7, 7);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(619, 40);
            this.radPanel3.TabIndex = 2;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(0))).NumberOfColors = 0;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(233)))));
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Location = new System.Drawing.Point(288, 8);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(140, 24);
            this.radDropDownButton1.TabIndex = 4;
            this.radDropDownButton1.Text = "None";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(253, 10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Sort:";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(6, 10);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Type here to filter";
            this.radTextBox1.Size = new System.Drawing.Size(241, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1183, 749);
            this.Controls.SetChildIndex(this.radPanel2, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
        private RadButton btnSpy;
        private TreeExampleHeaderPanel radPanel1;
        private RadPanel radPanel2;
        private RadTreeView radTreeView1;
        private RadPanel radPanel3;
        private RadLabel radLabel1;
        private RadTextBox radTextBox1;
        private RadDropDownButton radDropDownButton1;
	}
}
