Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PropertyGrid.Settings
	Public Partial Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListPropertySort = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditorItemSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorItemIndent = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorItemHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBoxAutoExpandGroups = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxReadOnly = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxSearchVisible = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxHelpVisible = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListPropertySort, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorItemIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAutoExpandGroups, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxReadOnly, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxSearchVisible, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxHelpVisible, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1081, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 788)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radPropertyGrid1
			' 
			Me.radPropertyGrid1.HelpVisible = False
			Me.radPropertyGrid1.Location = New System.Drawing.Point(350, 25)
			Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.Size = New System.Drawing.Size(315, 353)
			Me.radPropertyGrid1.TabIndex = 1
			Me.radPropertyGrid1.Text = "radPropertyGrid1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radDropDownListPropertySort)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorItemSpacing)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorItemIndent)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorItemHeight)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxAutoExpandGroups)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxReadOnly)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxSearchVisible)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxHelpVisible)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "UI Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 72)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 256)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "UI Settings"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(6, 210)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(71, 18)
			Me.radLabel4.TabIndex = 3
			Me.radLabel4.Text = "Property sort"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(6, 184)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(70, 18)
			Me.radLabel3.TabIndex = 3
			Me.radLabel3.Text = "Item spacing"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(6, 158)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(64, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Item indent"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(6, 132)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(64, 18)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Item height"
			' 
			' radDropDownListPropertySort
			' 
			Me.radDropDownListPropertySort.DropDownAnimationEnabled = True
			Me.radDropDownListPropertySort.Location = New System.Drawing.Point(83, 208)
			Me.radDropDownListPropertySort.Name = "radDropDownListPropertySort"
			Me.radDropDownListPropertySort.ShowImageInEditorArea = True
			Me.radDropDownListPropertySort.Size = New System.Drawing.Size(92, 20)
			Me.radDropDownListPropertySort.TabIndex = 2
			Me.radDropDownListPropertySort.Text = "radDropDownList1"
'			Me.radDropDownListPropertySort.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radDropDownListPropertySort_SelectedIndexChanged);
			' 
			' radSpinEditorItemSpacing
			' 
			Me.radSpinEditorItemSpacing.Location = New System.Drawing.Point(83, 182)
			Me.radSpinEditorItemSpacing.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing"
			' 
			' 
			' 
			Me.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemSpacing.ShowBorder = True
			Me.radSpinEditorItemSpacing.Size = New System.Drawing.Size(92, 20)
			Me.radSpinEditorItemSpacing.TabIndex = 1
			Me.radSpinEditorItemSpacing.TabStop = False
'			Me.radSpinEditorItemSpacing.ValueChanged += New System.EventHandler(Me.radSpinEditorItemSpacing_ValueChanged);
			' 
			' radSpinEditorItemIndent
			' 
			Me.radSpinEditorItemIndent.Location = New System.Drawing.Point(83, 156)
			Me.radSpinEditorItemIndent.Name = "radSpinEditorItemIndent"
			' 
			' 
			' 
			Me.radSpinEditorItemIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemIndent.ShowBorder = True
			Me.radSpinEditorItemIndent.Size = New System.Drawing.Size(92, 20)
			Me.radSpinEditorItemIndent.TabIndex = 1
			Me.radSpinEditorItemIndent.TabStop = False
'			Me.radSpinEditorItemIndent.ValueChanged += New System.EventHandler(Me.radSpinEditorItemIndent_ValueChanged);
			' 
			' radSpinEditorItemHeight
			' 
			Me.radSpinEditorItemHeight.Location = New System.Drawing.Point(83, 130)
			Me.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight"
			' 
			' 
			' 
			Me.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemHeight.ShowBorder = True
			Me.radSpinEditorItemHeight.Size = New System.Drawing.Size(92, 20)
			Me.radSpinEditorItemHeight.TabIndex = 1
			Me.radSpinEditorItemHeight.TabStop = False
'			Me.radSpinEditorItemHeight.ValueChanged += New System.EventHandler(Me.radSpinEditorItemHeight_ValueChanged);
			' 
			' radCheckBoxAutoExpandGroups
			' 
			Me.radCheckBoxAutoExpandGroups.Location = New System.Drawing.Point(6, 94)
			Me.radCheckBoxAutoExpandGroups.Name = "radCheckBoxAutoExpandGroups"
			Me.radCheckBoxAutoExpandGroups.Size = New System.Drawing.Size(122, 18)
			Me.radCheckBoxAutoExpandGroups.TabIndex = 0
			Me.radCheckBoxAutoExpandGroups.Text = "Auto expand groups"
'			Me.radCheckBoxAutoExpandGroups.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAutoExpandGroups_ToggleStateChanged);
			' 
			' radCheckBoxReadOnly
			' 
			Me.radCheckBoxReadOnly.Location = New System.Drawing.Point(6, 70)
			Me.radCheckBoxReadOnly.Name = "radCheckBoxReadOnly"
			Me.radCheckBoxReadOnly.Size = New System.Drawing.Size(70, 18)
			Me.radCheckBoxReadOnly.TabIndex = 0
			Me.radCheckBoxReadOnly.Text = "Read only"
'			Me.radCheckBoxReadOnly.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxReadOnly_ToggleStateChanged);
			' 
			' radCheckBoxSearchVisible
			' 
			Me.radCheckBoxSearchVisible.Location = New System.Drawing.Point(6, 46)
			Me.radCheckBoxSearchVisible.Name = "radCheckBoxSearchVisible"
			Me.radCheckBoxSearchVisible.Size = New System.Drawing.Size(88, 18)
			Me.radCheckBoxSearchVisible.TabIndex = 0
			Me.radCheckBoxSearchVisible.Text = "Search visible"
'			Me.radCheckBoxSearchVisible.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxSearchVisible_ToggleStateChanged);
			' 
			' radCheckBoxHelpVisible
			' 
			Me.radCheckBoxHelpVisible.Location = New System.Drawing.Point(6, 22)
			Me.radCheckBoxHelpVisible.Name = "radCheckBoxHelpVisible"
			Me.radCheckBoxHelpVisible.Size = New System.Drawing.Size(78, 18)
			Me.radCheckBoxHelpVisible.TabIndex = 0
			Me.radCheckBoxHelpVisible.Text = "Help visible"
'			Me.radCheckBoxHelpVisible.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxHelpVisible_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPropertyGrid1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1282, 790)
			Me.Controls.SetChildIndex(Me.radPropertyGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListPropertySort, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorItemIndent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAutoExpandGroups, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxReadOnly, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxSearchVisible, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxHelpVisible, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckBoxHelpVisible As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radSpinEditorItemHeight As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditorItemIndent As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radCheckBoxSearchVisible As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radSpinEditorItemSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radDropDownListPropertySort As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckBoxReadOnly As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxAutoExpandGroups As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
