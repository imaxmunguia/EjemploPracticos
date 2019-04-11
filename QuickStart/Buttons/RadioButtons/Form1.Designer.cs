namespace Telerik.Examples.WinControls.Buttons.RadioButtons
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
            this.radTextBoxEvents = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioDonut = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioSquare = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioOffice = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioRound = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioRegular = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCustShape = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDonut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRegular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCustShape)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radRadioDonut);
            this.radPanelDemoHolder.Controls.Add(this.radRadioRegular);
            this.radPanelDemoHolder.Controls.Add(this.radRadioSquare);
            this.radPanelDemoHolder.Controls.Add(this.radRadioCustShape);
            this.radPanelDemoHolder.Controls.Add(this.radRadioRound);
            this.radPanelDemoHolder.Controls.Add(this.radRadioOffice);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(384, 219);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(175, 182);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radTextBoxEvents
            // 
            this.radTextBoxEvents.ForeColor = System.Drawing.Color.Black;
            this.radTextBoxEvents.Location = new System.Drawing.Point(12, 21);
            this.radTextBoxEvents.Multiline = true;
            this.radTextBoxEvents.Name = "radTextBoxEvents";
            // 
            // 
            // 
            this.radTextBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBoxEvents.RootElement.StretchVertically = true;
            this.radTextBoxEvents.Size = new System.Drawing.Size(139, 170);
            this.radTextBoxEvents.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radTextBoxEvents);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.FooterText = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = " Events ";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.Size = new System.Drawing.Size(162, 203);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = " Events ";
            // 
            // radRadioDonut
            // 
            this.radRadioDonut.ForeColor = System.Drawing.Color.Black;
            this.radRadioDonut.Location = new System.Drawing.Point(33, 115);
            this.radRadioDonut.Name = "radRadioDonut";
            this.radRadioDonut.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioDonut.AutoSize = true;
            // 
            // 
            // 
            this.radRadioDonut.RootElement.ForeColor = System.Drawing.Color.Black;
            //this.radRadioDonut.Size = new System.Drawing.Size(50, 16);
            this.radRadioDonut.TabIndex = 0;
            this.radRadioDonut.Text = "Donut";
            this.radRadioDonut.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // radRadioSquare
            // 
            this.radRadioSquare.ForeColor = System.Drawing.Color.Black;
            this.radRadioSquare.Location = new System.Drawing.Point(33, 95);
            this.radRadioSquare.Name = "radRadioSquare";
            this.radRadioSquare.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioSquare.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioSquare.AutoSize = true;
            this.radRadioSquare.TabIndex = 0;
            this.radRadioSquare.Text = "Square";
            this.radRadioSquare.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // radRadioOffice
            // 
            this.radRadioOffice.ForeColor = System.Drawing.Color.Black;
            this.radRadioOffice.Location = new System.Drawing.Point(33, 135);
            this.radRadioOffice.Name = "radRadioOffice";
            this.radRadioOffice.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioOffice.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioOffice.AutoSize = true;
            this.radRadioOffice.TabIndex = 0;
            this.radRadioOffice.Text = "Office Tab";
            this.radRadioOffice.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // radRadioRound
            // 
            this.radRadioRound.ForeColor = System.Drawing.Color.Black;
            this.radRadioRound.Location = new System.Drawing.Point(33, 74);
            this.radRadioRound.Name = "radRadioRound";
            this.radRadioRound.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioRound.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioRound.AutoSize = true;
            this.radRadioRound.TabIndex = 0;
            this.radRadioRound.Text = "Round Rectangle";
            this.radRadioRound.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // radRadioRegular
            // 
            this.radRadioRegular.ForeColor = System.Drawing.Color.Black;
            this.radRadioRegular.Location = new System.Drawing.Point(33, 32);
            this.radRadioRegular.Name = "radRadioRegular";
            this.radRadioRegular.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioRegular.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioRegular.AutoSize = true;
            this.radRadioRegular.TabIndex = 0;
            this.radRadioRegular.Text = "Regular";
            this.radRadioRegular.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // radRadioCustShape
            // 
            this.radRadioCustShape.ForeColor = System.Drawing.Color.Black;
            this.radRadioCustShape.Location = new System.Drawing.Point(33, 54);
            this.radRadioCustShape.Name = "radRadioCustShape";
            this.radRadioCustShape.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioCustShape.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioCustShape.AutoSize = true;
            this.radRadioCustShape.TabIndex = 0;
            this.radRadioCustShape.Text = "Custom Shape";
            this.radRadioCustShape.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCustShape_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 536);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDonut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRegular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCustShape)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxEvents;
        private Telerik.WinControls.UI.RadRadioButton radRadioDonut;
        private Telerik.WinControls.UI.RadRadioButton radRadioSquare;
        private Telerik.WinControls.UI.RadRadioButton radRadioOffice;
        private Telerik.WinControls.UI.RadRadioButton radRadioRound;
        private Telerik.WinControls.UI.RadRadioButton radRadioCustShape;
        private Telerik.WinControls.UI.RadRadioButton radRadioRegular;
	}
}
