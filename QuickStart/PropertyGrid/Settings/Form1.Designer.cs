namespace Telerik.Examples.WinControls.PropertyGrid.Settings
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
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListPropertySort = new Telerik.WinControls.UI.RadDropDownList();
            this.radSpinEditorItemSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemIndent = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBoxAutoExpandGroups = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxReadOnly = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxSearchVisible = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxHelpVisible = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPropertySort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoExpandGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSearchVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHelpVisible)).BeginInit();
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
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.HelpVisible = false;
            this.radPropertyGrid1.Location = new System.Drawing.Point(350, 25);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.Size = new System.Drawing.Size(315, 343);
            this.radPropertyGrid1.TabIndex = 1;
            this.radPropertyGrid1.Text = "radPropertyGrid1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radDropDownListPropertySort);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemSpacing);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemIndent);
            this.radGroupBox1.Controls.Add(this.radSpinEditorItemHeight);
            this.radGroupBox1.Controls.Add(this.radCheckBoxAutoExpandGroups);
            this.radGroupBox1.Controls.Add(this.radCheckBoxReadOnly);
            this.radGroupBox1.Controls.Add(this.radCheckBoxSearchVisible);
            this.radGroupBox1.Controls.Add(this.radCheckBoxHelpVisible);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "UI Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 72);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 256);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "UI Settings";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(6, 210);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(71, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Property sort";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(6, 184);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Item spacing";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(6, 158);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Item indent";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 132);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Item height";
            // 
            // radDropDownListPropertySort
            // 
            this.radDropDownListPropertySort.DropDownAnimationEnabled = true;
            this.radDropDownListPropertySort.Location = new System.Drawing.Point(83, 208);
            this.radDropDownListPropertySort.Name = "radDropDownListPropertySort";
            this.radDropDownListPropertySort.ShowImageInEditorArea = true;
            this.radDropDownListPropertySort.Size = new System.Drawing.Size(92, 20);
            this.radDropDownListPropertySort.TabIndex = 2;
            this.radDropDownListPropertySort.Text = "radDropDownList1";
            this.radDropDownListPropertySort.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListPropertySort_SelectedIndexChanged);
            // 
            // radSpinEditorItemSpacing
            // 
            this.radSpinEditorItemSpacing.Location = new System.Drawing.Point(83, 182);
            this.radSpinEditorItemSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing";
            // 
            // 
            // 
            this.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemSpacing.ShowBorder = true;
            this.radSpinEditorItemSpacing.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemSpacing.TabIndex = 1;
            this.radSpinEditorItemSpacing.TabStop = false;
            this.radSpinEditorItemSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorItemSpacing_ValueChanged);
            // 
            // radSpinEditorItemIndent
            // 
            this.radSpinEditorItemIndent.Location = new System.Drawing.Point(83, 156);
            this.radSpinEditorItemIndent.Name = "radSpinEditorItemIndent";
            // 
            // 
            // 
            this.radSpinEditorItemIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemIndent.ShowBorder = true;
            this.radSpinEditorItemIndent.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemIndent.TabIndex = 1;
            this.radSpinEditorItemIndent.TabStop = false;
            this.radSpinEditorItemIndent.ValueChanged += new System.EventHandler(this.radSpinEditorItemIndent_ValueChanged);
            // 
            // radSpinEditorItemHeight
            // 
            this.radSpinEditorItemHeight.Location = new System.Drawing.Point(83, 130);
            this.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight";
            // 
            // 
            // 
            this.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemHeight.ShowBorder = true;
            this.radSpinEditorItemHeight.Size = new System.Drawing.Size(92, 20);
            this.radSpinEditorItemHeight.TabIndex = 1;
            this.radSpinEditorItemHeight.TabStop = false;
            this.radSpinEditorItemHeight.ValueChanged += new System.EventHandler(this.radSpinEditorItemHeight_ValueChanged);
            // 
            // radCheckBoxAutoExpandGroups
            // 
            this.radCheckBoxAutoExpandGroups.Location = new System.Drawing.Point(6, 94);
            this.radCheckBoxAutoExpandGroups.Name = "radCheckBoxAutoExpandGroups";
            this.radCheckBoxAutoExpandGroups.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxAutoExpandGroups.TabIndex = 0;
            this.radCheckBoxAutoExpandGroups.Text = "Auto expand groups";
            this.radCheckBoxAutoExpandGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAutoExpandGroups_ToggleStateChanged);
            // 
            // radCheckBoxReadOnly
            // 
            this.radCheckBoxReadOnly.Location = new System.Drawing.Point(6, 70);
            this.radCheckBoxReadOnly.Name = "radCheckBoxReadOnly";
            this.radCheckBoxReadOnly.Size = new System.Drawing.Size(70, 18);
            this.radCheckBoxReadOnly.TabIndex = 0;
            this.radCheckBoxReadOnly.Text = "Read only";
            this.radCheckBoxReadOnly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxReadOnly_ToggleStateChanged);
            // 
            // radCheckBoxSearchVisible
            // 
            this.radCheckBoxSearchVisible.Location = new System.Drawing.Point(6, 46);
            this.radCheckBoxSearchVisible.Name = "radCheckBoxSearchVisible";
            this.radCheckBoxSearchVisible.Size = new System.Drawing.Size(88, 18);
            this.radCheckBoxSearchVisible.TabIndex = 0;
            this.radCheckBoxSearchVisible.Text = "Search visible";
            this.radCheckBoxSearchVisible.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxSearchVisible_ToggleStateChanged);
            // 
            // radCheckBoxHelpVisible
            // 
            this.radCheckBoxHelpVisible.Location = new System.Drawing.Point(6, 22);
            this.radCheckBoxHelpVisible.Name = "radCheckBoxHelpVisible";
            this.radCheckBoxHelpVisible.Size = new System.Drawing.Size(78, 18);
            this.radCheckBoxHelpVisible.TabIndex = 0;
            this.radCheckBoxHelpVisible.Text = "Help visible";
            this.radCheckBoxHelpVisible.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxHelpVisible_ToggleStateChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPropertySort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoExpandGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSearchVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHelpVisible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxHelpVisible;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemIndent;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxSearchVisible;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemSpacing;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListPropertySort;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxReadOnly;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAutoExpandGroups;
    }
}
