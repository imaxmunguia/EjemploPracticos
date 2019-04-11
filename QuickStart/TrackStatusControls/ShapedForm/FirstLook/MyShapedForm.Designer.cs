namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
{
	partial class MyShapedForm
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
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// radButton1
			// 
			this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
			this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.radButton1.ImageList = null;
			this.radButton1.Location = new System.Drawing.Point(109, 219);
			this.radButton1.Name = "radButton1";
			// 
			// radButton1.RootElement
			// 
			this.radButton1.RootElement.AccessibleDescription = "";
			this.radButton1.RootElement.ToolTipText = null;
			this.radButton1.Size = new System.Drawing.Size(75, 23);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Close";
			this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// MyShapedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 271);
			this.Controls.Add(this.radButton1);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Name = "MyShapedForm";
			this.Text = "MyShapedForm";
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadButton radButton1;
	}
}