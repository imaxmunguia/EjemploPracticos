namespace Telerik.Examples.WinControls.Editors.FirstLook
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
            this.radTxtDemo1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTxtDemo2 = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupNull = new Telerik.WinControls.UI.RadGroupBox();
            this.radLblNulltext = new Telerik.WinControls.UI.RadLabel();
            this.radTxtNullText = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupMulti = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckCancel = new Telerik.WinControls.UI.RadCheckBox();
            this.radLblNewValue = new Telerik.WinControls.UI.RadLabel();
            this.radLblOldValue = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDemo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDemo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNull)).BeginInit();
            this.radGroupNull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNulltext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtNullText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupMulti)).BeginInit();
            this.radGroupMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNewValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblOldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radLabel2);
            this.radPanelDemoHolder.Controls.Add(this.radLabel1);
            this.radPanelDemoHolder.Controls.Add(this.radTxtDemo2);
            this.radPanelDemoHolder.Controls.Add(this.radTxtDemo1);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(269, 182);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(261, 208);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupMulti);
            this.settingsPanel.Controls.Add(this.radGroupNull);
            this.settingsPanel.Location = new System.Drawing.Point(598, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 569);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupNull, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupMulti, 0);
            // 
            // radTxtDemo1
            // 
            this.radTxtDemo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTxtDemo1.ForeColor = System.Drawing.Color.Black;
            this.radTxtDemo1.Location = new System.Drawing.Point(54, 39);
            this.radTxtDemo1.Name = "radTxtDemo1";
            this.radTxtDemo1.NullText = "Type here...";
            // 
            // 
            // 
            this.radTxtDemo1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTxtDemo1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtDemo1.RootElement.ToolTipText = null;
            this.radTxtDemo1.Size = new System.Drawing.Size(153, 20);
            this.radTxtDemo1.TabIndex = 0;
            // 
            // radTxtDemo2
            // 
            this.radTxtDemo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTxtDemo2.ForeColor = System.Drawing.Color.Black;
            this.radTxtDemo2.Location = new System.Drawing.Point(54, 92);
            this.radTxtDemo2.Multiline = true;
            this.radTxtDemo2.Name = "radTxtDemo2";
            this.radTxtDemo2.NullText = "Type here...";
            // 
            // 
            // 
            this.radTxtDemo2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtDemo2.RootElement.StretchVertically = true;
            this.radTxtDemo2.RootElement.ToolTipText = null;
            this.radTxtDemo2.Size = new System.Drawing.Size(153, 94);
            this.radTxtDemo2.TabIndex = 0;
            this.radTxtDemo2.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.radTextBox2_TextChanging);
            // 
            // radGroupNull
            // 
            this.radGroupNull.Controls.Add(this.radLblNulltext);
            this.radGroupNull.Controls.Add(this.radTxtNullText);
            this.radGroupNull.FooterImageIndex = -1;
            this.radGroupNull.FooterImageKey = "";
            this.radGroupNull.FooterText = "";
            this.radGroupNull.ForeColor = System.Drawing.Color.Black;
            this.radGroupNull.HeaderImageIndex = -1;
            this.radGroupNull.HeaderImageKey = "";
            this.radGroupNull.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupNull.HeaderText = " Null Text ";
            this.radGroupNull.Location = new System.Drawing.Point(15, 6);
            this.radGroupNull.Name = "radGroupNull";
            // 
            // 
            // 
            this.radGroupNull.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupNull.Size = new System.Drawing.Size(162, 82);
            this.radGroupNull.TabIndex = 0;
            this.radGroupNull.Text = " Null Text ";
            // 
            // radLblNulltext
            // 
            this.radLblNulltext.AutoSize = false;
            this.radLblNulltext.ForeColor = System.Drawing.Color.Black;
            this.radLblNulltext.Location = new System.Drawing.Point(7, 24);
            this.radLblNulltext.Name = "radLblNulltext";
            // 
            // 
            // 
            this.radLblNulltext.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblNulltext.RootElement.StretchHorizontally = true;
            this.radLblNulltext.RootElement.StretchVertically = true;
            this.radLblNulltext.Size = new System.Drawing.Size(141, 16);
            this.radLblNulltext.TabIndex = 1;
            this.radLblNulltext.Text = "Enter new Null Text:";
            // 
            // radTxtNullText
            // 
            this.radTxtNullText.ForeColor = System.Drawing.Color.Black;
            this.radTxtNullText.Location = new System.Drawing.Point(7, 46);
            this.radTxtNullText.Name = "radTxtNullText";
            // 
            // 
            // 
            this.radTxtNullText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTxtNullText.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtNullText.RootElement.ToolTipText = null;
            this.radTxtNullText.Size = new System.Drawing.Size(148, 20);
            this.radTxtNullText.TabIndex = 0;
            this.radTxtNullText.TextChanged += new System.EventHandler(this.radTxtNullText_TextChanged);
            // 
            // radGroupMulti
            // 
            this.radGroupMulti.Controls.Add(this.radCheckCancel);
            this.radGroupMulti.Controls.Add(this.radLblNewValue);
            this.radGroupMulti.Controls.Add(this.radLblOldValue);
            this.radGroupMulti.FooterImageIndex = -1;
            this.radGroupMulti.FooterImageKey = "";
            this.radGroupMulti.FooterText = "";
            this.radGroupMulti.ForeColor = System.Drawing.Color.Black;
            this.radGroupMulti.HeaderImageIndex = -1;
            this.radGroupMulti.HeaderImageKey = "";
            this.radGroupMulti.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupMulti.HeaderText = " Multiline TextBox settings";
            this.radGroupMulti.Location = new System.Drawing.Point(15, 103);
            this.radGroupMulti.Name = "radGroupMulti";
            // 
            // 
            // 
            this.radGroupMulti.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupMulti.Size = new System.Drawing.Size(166, 194);
            this.radGroupMulti.TabIndex = 1;
            this.radGroupMulti.Text = " Multiline TextBox settings";
            // 
            // radCheckCancel
            // 
            this.radCheckCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckCancel.Location = new System.Drawing.Point(7, 164);
            this.radCheckCancel.Name = "radCheckCancel";
            this.radCheckCancel.Size = new System.Drawing.Size(108, 17);
            this.radCheckCancel.TabIndex = 2;
            this.radCheckCancel.Text = "Cancel On Event";
            // 
            // radLblNewValue
            // 
            this.radLblNewValue.ForeColor = System.Drawing.Color.Black;
            this.radLblNewValue.Location = new System.Drawing.Point(7, 90);
            this.radLblNewValue.MaximumSize = new System.Drawing.Size(155, 67);
            this.radLblNewValue.Name = "radLblNewValue";
            // 
            // 
            // 
            this.radLblNewValue.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblNewValue.RootElement.MaxSize = new System.Drawing.Size(155, 67);
            this.radLblNewValue.Size = new System.Drawing.Size(60, 14);
            this.radLblNewValue.TabIndex = 1;
            this.radLblNewValue.Text = "New value:";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblNewValue.GetChildAt(0))).Text = "New value:";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblNewValue.GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblNewValue.GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLblNewValue.GetChildAt(0).GetChildAt(2).GetChildAt(1))).StretchVertically = true;
            // 
            // radLblOldValue
            // 
            this.radLblOldValue.ForeColor = System.Drawing.Color.Black;
            this.radLblOldValue.Location = new System.Drawing.Point(7, 25);
            this.radLblOldValue.MaximumSize = new System.Drawing.Size(155, 67);
            this.radLblOldValue.Name = "radLblOldValue";
            // 
            // 
            // 
            this.radLblOldValue.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblOldValue.RootElement.MaxSize = new System.Drawing.Size(155, 67);
            this.radLblOldValue.Size = new System.Drawing.Size(55, 14);
            this.radLblOldValue.TabIndex = 1;
            this.radLblOldValue.Text = "Old value:";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblOldValue.GetChildAt(0))).Text = "Old value:";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblOldValue.GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLblOldValue.GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLblOldValue.GetChildAt(0).GetChildAt(2).GetChildAt(1))).StretchVertically = true;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(54, 17);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.RootElement.StretchHorizontally = true;
            this.radLabel1.RootElement.StretchVertically = true;
            this.radLabel1.Size = new System.Drawing.Size(153, 16);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Single-line text box:";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(54, 70);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.RootElement.StretchHorizontally = true;
            this.radLabel2.RootElement.StretchVertically = true;
            this.radLabel2.Size = new System.Drawing.Size(153, 16);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Multi-line text box:";
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(799, 571);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDemo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDemo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNull)).EndInit();
            this.radGroupNull.ResumeLayout(false);
            this.radGroupNull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNulltext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtNullText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupMulti)).EndInit();
            this.radGroupMulti.ResumeLayout(false);
            this.radGroupMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNewValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblOldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadTextBox radTxtDemo1;
		private Telerik.WinControls.UI.RadTextBox radTxtDemo2;
        private Telerik.WinControls.UI.RadGroupBox radGroupNull;
        private Telerik.WinControls.UI.RadGroupBox radGroupMulti;
        private Telerik.WinControls.UI.RadLabel radLblNewValue;
        private Telerik.WinControls.UI.RadLabel radLblOldValue;
        private Telerik.WinControls.UI.RadLabel radLblNulltext;
        private Telerik.WinControls.UI.RadTextBox radTxtNullText;
        private Telerik.WinControls.UI.RadCheckBox radCheckCancel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
	}
}