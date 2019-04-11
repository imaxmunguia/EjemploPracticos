namespace Telerik.Examples.WinControls.DropDownListAndListControl.CreateItemVisualAndItemsFormatting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radio_CreateCheckBox = new Telerik.WinControls.UI.RadRadioButton();
            this.radio_CreateRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateRadioButton)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.btnSpy);
            this.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsPanel.Location = new System.Drawing.Point(887, 1);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(183, 491);
            this.settingsPanel.TabIndex = 0;
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
            this.btnSpy.Size = new System.Drawing.Size(163, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpy.ThemeName = "ControlDefault";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radListControl1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "ListControl";
            this.radGroupBox1.Location = new System.Drawing.Point(198, 55);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(270, 438);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "ListControl";
            // 
            // radListControl1
            //             
            this.radListControl1.DisplayMember = "";
            this.radListControl1.Location = new System.Drawing.Point(13, 23);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(244, 402);
            this.radListControl1.TabIndex = 1;
            this.radListControl1.Text = "radListControl1";
            this.radListControl1.ValueMember = "";
            this.radListControl1.CreatingVisualListItem += this.CreatingVisualListItem;
            
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.Controls.Add(this.radDropDownList1);
            this.radGroupBox4.FooterImageIndex = -1;
            this.radGroupBox4.FooterImageKey = "";
            this.radGroupBox4.HeaderImageIndex = -1;
            this.radGroupBox4.HeaderImageKey = "";
            this.radGroupBox4.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox4.HeaderText = "DropDownList";
            this.radGroupBox4.Location = new System.Drawing.Point(535, 55);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox4.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox4.Size = new System.Drawing.Size(270, 438);
            this.radGroupBox4.TabIndex = 9;
            this.radGroupBox4.Text = "DropDownList";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = false;
            this.radDropDownList1.DropDownHeight = 0;
            this.radDropDownList1.Location = new System.Drawing.Point(13, 23);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(244, 18);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.TabStop = false;
            this.radDropDownList1.CreatingVisualListItem += this.CreatingVisualListItem;            
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radio_CreateCheckBox);
            this.radGroupBox2.Controls.Add(this.radio_CreateRadioButton);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Custom object type:";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 54);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(163, 100);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Custom object type:";
            // 
            // radio_CreateCheckBox
            // 
            this.radio_CreateCheckBox.Location = new System.Drawing.Point(28, 65);
            this.radio_CreateCheckBox.Name = "radio_CreateCheckBox";
            this.radio_CreateCheckBox.TabIndex = 0;
            this.radio_CreateCheckBox.Text = "CheckBox";
           // this.radio_CreateCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_CreateCheckBox_ToggleStateChanged);
            // 
            // radio_CreateRadioButton
            // 
            this.radio_CreateRadioButton.Location = new System.Drawing.Point(28, 34);
            this.radio_CreateRadioButton.Name = "radio_CreateRadioButton";
            this.radio_CreateRadioButton.TabIndex = 0;
            this.radio_CreateRadioButton.Text = "Radio Button";
            this.radio_CreateRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
          //  this.radio_CreateRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_CreateRadioButton_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox4);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1071, 385);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_CreateRadioButton)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton radio_CreateRadioButton;
        private Telerik.WinControls.UI.RadRadioButton radio_CreateCheckBox;
        private new Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadButton btnSpy;
    }
}