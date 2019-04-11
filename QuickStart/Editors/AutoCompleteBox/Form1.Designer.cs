namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radButtonSend = new Telerik.WinControls.UI.RadButton();
            this.radButtonTo = new Telerik.WinControls.UI.RadButton();
            this.radButtonCc = new Telerik.WinControls.UI.RadButton();
            this.radLabelSubject = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxControlSubject = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radAutoCompleteBox1 = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.radAutoCompleteBox2 = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radListControlRecipients = new Telerik.WinControls.UI.RadListControl();
            this.radLabel1Recipients = new Telerik.WinControls.UI.RadLabel();
            this.radListControlCarbonCopy = new Telerik.WinControls.UI.RadListControl();
            this.radLabelCarbonCopy = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListAutoCompleteMode = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelAutoComplete = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlRecipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1Recipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlCarbonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCarbonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAutoCompleteMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAutoComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabelAutoComplete);
            this.settingsPanel.Controls.Add(this.radDropDownListAutoCompleteMode);
            this.settingsPanel.Controls.Add(this.radLabelCarbonCopy);
            this.settingsPanel.Controls.Add(this.radLabel1Recipients);
            this.settingsPanel.Controls.Add(this.radListControlCarbonCopy);
            this.settingsPanel.Controls.Add(this.radListControlRecipients);
            this.settingsPanel.Location = new System.Drawing.Point(1085, 19);
            this.settingsPanel.Size = new System.Drawing.Size(0, 624);
            this.settingsPanel.Controls.SetChildIndex(this.radListControlRecipients, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radListControlCarbonCopy, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1Recipients, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabelCarbonCopy, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownListAutoCompleteMode, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabelAutoComplete, 0);
            // 
            // radButtonSend
            // 
            this.radButtonSend.Image = global::Telerik.Examples.WinControls.Properties.Resources.send_email;
            this.radButtonSend.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButtonSend.Location = new System.Drawing.Point(3, 3);
            this.radButtonSend.Name = "radButtonSend";
            this.tableLayoutPanel1.SetRowSpan(this.radButtonSend, 3);
            this.radButtonSend.Size = new System.Drawing.Size(59, 85);
            this.radButtonSend.TabIndex = 1;
            this.radButtonSend.Text = "Send";
            this.radButtonSend.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButtonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radButtonTo
            // 
            this.radButtonTo.Location = new System.Drawing.Point(68, 3);
            this.radButtonTo.Name = "radButtonTo";
            this.radButtonTo.Size = new System.Drawing.Size(43, 24);
            this.radButtonTo.TabIndex = 2;
            this.radButtonTo.Text = "To...";
            // 
            // radButtonCc
            // 
            this.radButtonCc.Location = new System.Drawing.Point(68, 35);
            this.radButtonCc.Name = "radButtonCc";
            this.radButtonCc.Size = new System.Drawing.Size(43, 24);
            this.radButtonCc.TabIndex = 3;
            this.radButtonCc.Text = "Cc...";
            // 
            // radLabelSubject
            // 
            this.radLabelSubject.Location = new System.Drawing.Point(68, 69);
            this.radLabelSubject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.radLabelSubject.Name = "radLabelSubject";
            this.radLabelSubject.Size = new System.Drawing.Size(45, 18);
            this.radLabelSubject.TabIndex = 4;
            this.radLabelSubject.Text = "Subject:";
            // 
            // radTextBoxControlSubject
            // 
            this.radTextBoxControlSubject.Location = new System.Drawing.Point(119, 67);
            this.radTextBoxControlSubject.Name = "radTextBoxControlSubject";
            this.radTextBoxControlSubject.Size = new System.Drawing.Size(563, 26);
            this.radTextBoxControlSubject.TabIndex = 5;
            this.radTextBoxControlSubject.Text = "Re: Feedback";
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.radTextBoxControlSubject.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2, 5, 2, 0);
            // 
            // radAutoCompleteBox1
            // 
            this.radAutoCompleteBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radAutoCompleteBox1.Location = new System.Drawing.Point(119, 35);
            this.radAutoCompleteBox1.MaximumSize = new System.Drawing.Size(563, 0);
            this.radAutoCompleteBox1.MinimumSize = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox1.Multiline = true;
            this.radAutoCompleteBox1.Name = "radAutoCompleteBox1";
            // 
            // 
            // 
            this.radAutoCompleteBox1.RootElement.MaxSize = new System.Drawing.Size(563, 0);
            this.radAutoCompleteBox1.RootElement.MinSize = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox1.RootElement.StretchHorizontally = false;
            this.radAutoCompleteBox1.RootElement.StretchVertically = false;
            this.radAutoCompleteBox1.Size = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox1.TabIndex = 6;
            this.radAutoCompleteBox1.Text = "Samuel Jackson;";
            // 
            // radAutoCompleteBox2
            // 
            this.radAutoCompleteBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radAutoCompleteBox2.Location = new System.Drawing.Point(119, 3);
            this.radAutoCompleteBox2.MaximumSize = new System.Drawing.Size(563, 0);
            this.radAutoCompleteBox2.MinimumSize = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox2.Multiline = true;
            this.radAutoCompleteBox2.Name = "radAutoCompleteBox2";
            // 
            // 
            // 
            this.radAutoCompleteBox2.RootElement.MaxSize = new System.Drawing.Size(563, 0);
            this.radAutoCompleteBox2.RootElement.MinSize = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox2.RootElement.StretchHorizontally = false;
            this.radAutoCompleteBox2.RootElement.StretchVertically = false;
            this.radAutoCompleteBox2.Size = new System.Drawing.Size(563, 26);
            this.radAutoCompleteBox2.TabIndex = 7;
            this.radAutoCompleteBox2.Text = "Joe Smith;";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.tableLayoutPanel1);
            this.radPanel1.Location = new System.Drawing.Point(14, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(685, 450);
            this.radPanel1.TabIndex = 8;
            this.radPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radAutoCompleteBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButtonSend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButtonTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radTextBoxControlSubject, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radAutoCompleteBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radButtonCc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radLabelSubject, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 450);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // radListControlRecipients
            // 
            this.radListControlRecipients.CaseSensitiveSort = true;
            this.radListControlRecipients.ItemHeight = 18;
            this.radListControlRecipients.Location = new System.Drawing.Point(29, 76);
            this.radListControlRecipients.Name = "radListControlRecipients";
            this.radListControlRecipients.Size = new System.Drawing.Size(14, 119);
            this.radListControlRecipients.TabIndex = 1;
            this.radListControlRecipients.Text = "Recipients List";
            // 
            // radLabel1Recipients
            // 
            this.radLabel1Recipients.Location = new System.Drawing.Point(29, 52);
            this.radLabel1Recipients.Name = "radLabel1Recipients";
            this.radLabel1Recipients.Size = new System.Drawing.Size(77, 18);
            this.radLabel1Recipients.TabIndex = 2;
            this.radLabel1Recipients.Text = "Recipients List";
            // 
            // radListControlCarbonCopy
            // 
            this.radListControlCarbonCopy.CaseSensitiveSort = true;
            this.radListControlCarbonCopy.ItemHeight = 18;
            this.radListControlCarbonCopy.Location = new System.Drawing.Point(29, 225);
            this.radListControlCarbonCopy.Name = "radListControlCarbonCopy";
            this.radListControlCarbonCopy.Size = new System.Drawing.Size(14, 129);
            this.radListControlCarbonCopy.TabIndex = 3;
            this.radListControlCarbonCopy.Text = "radListControl2";
            // 
            // radLabelCarbonCopy
            // 
            this.radLabelCarbonCopy.Location = new System.Drawing.Point(29, 201);
            this.radLabelCarbonCopy.Name = "radLabelCarbonCopy";
            this.radLabelCarbonCopy.Size = new System.Drawing.Size(91, 18);
            this.radLabelCarbonCopy.TabIndex = 4;
            this.radLabelCarbonCopy.Text = "Carbon Copy List";
            // 
            // radDropDownListAutoCompleteMode
            // 
            this.radDropDownListAutoCompleteMode.DropDownAnimationEnabled = true;
            radListDataItem4.Text = "Suggest";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Append";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "SuggestAppend";
            radListDataItem6.TextWrap = true;
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem4);
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem5);
            this.radDropDownListAutoCompleteMode.Items.Add(radListDataItem6);
            this.radDropDownListAutoCompleteMode.Location = new System.Drawing.Point(29, 400);
            this.radDropDownListAutoCompleteMode.MaxDropDownItems = 0;
            this.radDropDownListAutoCompleteMode.Name = "radDropDownListAutoCompleteMode";
            this.radDropDownListAutoCompleteMode.ShowImageInEditorArea = true;
            this.radDropDownListAutoCompleteMode.Size = new System.Drawing.Size(126, 20);
            this.radDropDownListAutoCompleteMode.TabIndex = 5;
            // 
            // radLabelAutoComplete
            // 
            this.radLabelAutoComplete.Location = new System.Drawing.Point(29, 373);
            this.radLabelAutoComplete.Name = "radLabelAutoComplete";
            this.radLabelAutoComplete.Size = new System.Drawing.Size(111, 18);
            this.radLabelAutoComplete.TabIndex = 6;
            this.radLabelAutoComplete.Text = "AutoComplete Mode";
            // 
            // radPanel2
            // 
            this.radPanel2.AutoScroll = true;
            this.radPanel2.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.email;
            this.tableLayoutPanel1.SetColumnSpan(this.radPanel2, 3);
            this.radPanel2.Location = new System.Drawing.Point(3, 99);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(679, 348);
            this.radPanel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1039, 624);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlRecipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1Recipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControlCarbonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCarbonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListAutoCompleteMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelAutoComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonSend;
        private Telerik.WinControls.UI.RadButton radButtonTo;
        private Telerik.WinControls.UI.RadButton radButtonCc;
        private Telerik.WinControls.UI.RadLabel radLabelSubject;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControlSubject;
        private Telerik.WinControls.UI.RadAutoCompleteBox radAutoCompleteBox1;
        private Telerik.WinControls.UI.RadAutoCompleteBox radAutoCompleteBox2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        //private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabelCarbonCopy;
        private Telerik.WinControls.UI.RadListControl radListControlCarbonCopy;
        private Telerik.WinControls.UI.RadLabel radLabel1Recipients;
        private Telerik.WinControls.UI.RadListControl radListControlRecipients;
        private Telerik.WinControls.UI.RadLabel radLabelAutoComplete;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListAutoCompleteMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}