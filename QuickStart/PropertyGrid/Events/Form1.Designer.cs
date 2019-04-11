namespace Telerik.Examples.WinControls.PropertyGrid.Events
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBoxEvents = new Telerik.WinControls.UI.RadTextBox();
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1081, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 788);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radTextBoxEvents);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Events";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 37);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 467);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Events";
            // 
            // radTextBoxEvents
            // 
            this.radTextBoxEvents.AcceptsReturn = true;
            this.radTextBoxEvents.Location = new System.Drawing.Point(14, 23);
            this.radTextBoxEvents.Multiline = true;
            this.radTextBoxEvents.Name = "radTextBoxEvents";
            // 
            // 
            // 
            this.radTextBoxEvents.RootElement.StretchVertically = true;
            this.radTextBoxEvents.Size = new System.Drawing.Size(153, 431);
            this.radTextBoxEvents.TabIndex = 0;
            this.radTextBoxEvents.TabStop = false;
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Location = new System.Drawing.Point(350, 25);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.ToolbarVisible = true;
            this.radPropertyGrid1.Size = new System.Drawing.Size(350, 530);
            this.radPropertyGrid1.TabIndex = 1;
            this.radPropertyGrid1.Text = "radPropertyGrid1";
            this.radPropertyGrid1.SelectedGridItemChanging += new Telerik.WinControls.UI.RadPropertyGridCancelEventHandler(this.radPropertyGrid1_SelectedGridItemChanging);
            this.radPropertyGrid1.SelectedGridItemChanged += new Telerik.WinControls.UI.RadPropertyGridEventHandler(this.radPropertyGrid1_SelectedGridItemChanged);
            this.radPropertyGrid1.ContextMenuOpening += new Telerik.WinControls.UI.PropertyGridContextMenuOpeningEventHandler(this.radPropertyGrid1_ContextMenuOpening);
            this.radPropertyGrid1.ItemMouseDoubleClick += new Telerik.WinControls.UI.RadPropertyGridEventHandler(this.radPropertyGrid1_ItemMouseDoubleClick);
            this.radPropertyGrid1.ItemExpandedChanging += new Telerik.WinControls.UI.RadPropertyGridCancelEventHandler(this.radPropertyGrid1_ItemExpandedChanging);
            this.radPropertyGrid1.ItemExpandedChanged += new Telerik.WinControls.UI.RadPropertyGridEventHandler(this.radPropertyGrid1_ItemExpandedChanged);
            this.radPropertyGrid1.EditorRequired += new Telerik.WinControls.UI.PropertyGridEditorRequiredEventHandler(this.radPropertyGrid1_EditorRequired);
            this.radPropertyGrid1.Editing += new Telerik.WinControls.UI.PropertyGridItemEditingEventHandler(this.radPropertyGrid1_Editing);
            this.radPropertyGrid1.EditorInitialized += new Telerik.WinControls.UI.PropertyGridItemEditorInitializedEventHandler(this.radPropertyGrid1_EditorInitialized);
            this.radPropertyGrid1.Edited += new Telerik.WinControls.UI.PropertyGridItemEditedEventHandler(this.radPropertyGrid1_Edited);
            this.radPropertyGrid1.PropertyValueChanging += new Telerik.WinControls.UI.PropertyGridItemValueChangingEventHandler(this.radPropertyGrid1_PropertyValueChanging);
            this.radPropertyGrid1.PropertyValueChanged += new Telerik.WinControls.UI.PropertyGridItemValueChangedEventHandler(this.radPropertyGrid1_PropertyValueChanged);
            this.radPropertyGrid1.PropertyValidating += new Telerik.WinControls.UI.PropertyValidatingEventHandler(this.radPropertyGrid1_PropertyValidating);
            this.radPropertyGrid1.PropertyValidated += new Telerik.WinControls.UI.PropertyValidatedEventHandler(this.radPropertyGrid1_PropertyValidated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPropertyGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1282, 790);
            this.Controls.SetChildIndex(this.radPropertyGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxEvents;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
    }
}
