Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.Animation
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Dim inputBinding13 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord13 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier13 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand2 As New Telerik.WinControls.Elements.ClickCommand()
			Dim inputBinding14 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord14 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier14 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding15 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord15 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier15 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding16 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord16 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier16 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding17 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord17 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier17 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding18 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord18 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier18 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding19 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord19 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier19 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding20 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord20 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier20 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding21 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord21 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier21 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding22 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord22 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier22 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding23 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord23 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier23 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding24 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord24 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier24 As New Telerik.WinControls.Keyboard.ChordModifier()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem4 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckEnabled = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditorFrames = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLblFrames = New Telerik.WinControls.UI.RadLabel()
			Me.radLblAnim = New Telerik.WinControls.UI.RadLabel()
			Me.radComboAnimation = New Telerik.WinControls.UI.RadDropDownList()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radCheckEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.HintText = "Ctrl+N"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "New"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.HintText = "Ctrl+P"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Print..."
			Me.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem9.ToolTipText = Nothing
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.HintText = "Ctrl+O"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Open..."
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.ToolTipText = Nothing
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.HintText = "Ctrl+S"
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Save"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.ToolTipText = Nothing
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.HintText = "Ctrl+Z"
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Undo"
			Me.radMenuItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem11.ToolTipText = Nothing
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.HintText = "Ctrl+X"
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Cut"
			Me.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem13.ToolTipText = Nothing
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.HintText = "Ctrl+C"
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Copy"
			Me.radMenuItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem14.ToolTipText = Nothing
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.HintText = "Ctrl+V"
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Paste"
			Me.radMenuItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem15.ToolTipText = Nothing
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.HintText = "Ctrl+F"
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Find..."
			Me.radMenuItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem17.ToolTipText = Nothing
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.HintText = "Ctrl+H"
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Replace..."
			Me.radMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem19.ToolTipText = Nothing
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.HintText = "Ctrl+G"
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Go To..."
			Me.radMenuItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem20.ToolTipText = Nothing
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.HintText = "Ctrl+A"
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "Select All"
			Me.radMenuItem21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem21.ToolTipText = Nothing
			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.BackColor = System.Drawing.Color.Transparent
			chordModifier13.AltModifier = False
			chordModifier13.ControlModifier = True
			chordModifier13.ShiftModifier = False
			chord13.ChordModifier = chordModifier13
			chord13.Keys = "Ctrl+N"
			inputBinding13.Chord = chord13
			clickCommand2.ContextType = Nothing
			clickCommand2.ImageList = Nothing
			clickCommand2.Name = "ActionCommand"
			clickCommand2.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand2.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand2.Type = ""
			inputBinding13.Command = clickCommand2
			inputBinding13.CommandContext = Me.radMenuItem4
			chordModifier14.AltModifier = False
			chordModifier14.ControlModifier = True
			chordModifier14.ShiftModifier = False
			chord14.ChordModifier = chordModifier14
			chord14.Keys = "Ctrl+P"
			inputBinding14.Chord = chord14
			inputBinding14.Command = clickCommand2
			inputBinding14.CommandContext = Me.radMenuItem9
			chordModifier15.AltModifier = False
			chordModifier15.ControlModifier = True
			chordModifier15.ShiftModifier = False
			chord15.ChordModifier = chordModifier15
			chord15.Keys = "Ctrl+O"
			inputBinding15.Chord = chord15
			inputBinding15.Command = clickCommand2
			inputBinding15.CommandContext = Me.radMenuItem5
			chordModifier16.AltModifier = False
			chordModifier16.ControlModifier = True
			chordModifier16.ShiftModifier = False
			chord16.ChordModifier = chordModifier16
			chord16.Keys = "Ctrl+S"
			inputBinding16.Chord = chord16
			inputBinding16.Command = clickCommand2
			inputBinding16.CommandContext = Me.radMenuItem6
			chordModifier17.AltModifier = False
			chordModifier17.ControlModifier = True
			chordModifier17.ShiftModifier = False
			chord17.ChordModifier = chordModifier17
			chord17.Keys = "Ctrl+Z"
			inputBinding17.Chord = chord17
			inputBinding17.Command = clickCommand2
			inputBinding17.CommandContext = Me.radMenuItem11
			chordModifier18.AltModifier = False
			chordModifier18.ControlModifier = True
			chordModifier18.ShiftModifier = False
			chord18.ChordModifier = chordModifier18
			chord18.Keys = "Ctrl+X"
			inputBinding18.Chord = chord18
			inputBinding18.Command = clickCommand2
			inputBinding18.CommandContext = Me.radMenuItem13
			chordModifier19.AltModifier = False
			chordModifier19.ControlModifier = True
			chordModifier19.ShiftModifier = False
			chord19.ChordModifier = chordModifier19
			chord19.Keys = "Ctrl+C"
			inputBinding19.Chord = chord19
			inputBinding19.Command = clickCommand2
			inputBinding19.CommandContext = Me.radMenuItem14
			chordModifier20.AltModifier = False
			chordModifier20.ControlModifier = True
			chordModifier20.ShiftModifier = False
			chord20.ChordModifier = chordModifier20
			chord20.Keys = "Ctrl+V"
			inputBinding20.Chord = chord20
			inputBinding20.Command = clickCommand2
			inputBinding20.CommandContext = Me.radMenuItem15
			chordModifier21.AltModifier = False
			chordModifier21.ControlModifier = True
			chordModifier21.ShiftModifier = False
			chord21.ChordModifier = chordModifier21
			chord21.Keys = "Ctrl+F"
			inputBinding21.Chord = chord21
			inputBinding21.Command = clickCommand2
			inputBinding21.CommandContext = Me.radMenuItem17
			chordModifier22.AltModifier = False
			chordModifier22.ControlModifier = True
			chordModifier22.ShiftModifier = False
			chord22.ChordModifier = chordModifier22
			chord22.Keys = "Ctrl+H"
			inputBinding22.Chord = chord22
			inputBinding22.Command = clickCommand2
			inputBinding22.CommandContext = Me.radMenuItem19
			chordModifier23.AltModifier = False
			chordModifier23.ControlModifier = True
			chordModifier23.ShiftModifier = False
			chord23.ChordModifier = chordModifier23
			chord23.Keys = "Ctrl+G"
			inputBinding23.Chord = chord23
			inputBinding23.Command = clickCommand2
			inputBinding23.CommandContext = Me.radMenuItem20
			chordModifier24.AltModifier = False
			chordModifier24.ControlModifier = True
			chordModifier24.ShiftModifier = False
			chord24.ChordModifier = chordModifier24
			chord24.Keys = "Ctrl+A"
			inputBinding24.Chord = chord24
			inputBinding24.Command = clickCommand2
			inputBinding24.CommandContext = Me.radMenuItem21
			Me.radMenuDemo.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() { inputBinding13, inputBinding14, inputBinding15, inputBinding16, inputBinding17, inputBinding18, inputBinding19, inputBinding20, inputBinding21, inputBinding22, inputBinding23, inputBinding24})
			Me.radMenuDemo.DropDownAnimationEnabled = True
			Me.radMenuDemo.DropDownAnimationFrames = 7
			Me.radMenuDemo.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2})
			Me.radMenuDemo.Location = New System.Drawing.Point(1, 1)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.RootElement.ToolTipText = Nothing
			Me.radMenuDemo.Size = New System.Drawing.Size(499, 27)
			Me.radMenuDemo.TabIndex = 5
			Me.radMenuDemo.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem6, Me.radMenuItem7, Me.radMenuSeparatorItem1, Me.radMenuItem8, Me.radMenuItem9, Me.radMenuSeparatorItem2, Me.radMenuItem10})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "File"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Save As..."
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "New item"
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Page Setup..."
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "New item"
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Exit"
			Me.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem10.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem11, Me.radMenuItem12, Me.radMenuSeparatorItem3, Me.radMenuItem13, Me.radMenuItem14, Me.radMenuItem15, Me.radMenuItem16, Me.radMenuSeparatorItem4, Me.radMenuItem17, Me.radMenuItem18, Me.radMenuItem19, Me.radMenuItem20, Me.radMenuSeparatorItem5, Me.radMenuItem21})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "Edit"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Redo"
			Me.radMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem12.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Class = "RadMenuItem"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Text = "New item"
			Me.radMenuSeparatorItem3.ToolTipText = Nothing
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.HintText = "Del"
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Delete"
			Me.radMenuItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem16.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem4
			' 
			Me.radMenuSeparatorItem4.Class = "RadMenuItem"
			Me.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4"
			Me.radMenuSeparatorItem4.Text = "New item"
			Me.radMenuSeparatorItem4.ToolTipText = Nothing
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.HintText = "F3"
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Find Next"
			Me.radMenuItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem18.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.Class = "RadMenuItem"
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Text = "New item"
			Me.radMenuSeparatorItem5.ToolTipText = Nothing
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radCheckEnabled)
			Me.radGroupSettings.Controls.Add(Me.radSpinEditorFrames)
			Me.radGroupSettings.Controls.Add(Me.radLblFrames)
			Me.radGroupSettings.Controls.Add(Me.radLblAnim)
			Me.radGroupSettings.Controls.Add(Me.radComboAnimation)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSettings.HeaderText = " Animation "
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 5)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 159)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " Animation "
			' 
			' radCheckEnabled
			' 
			Me.radCheckEnabled.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckEnabled.Location = New System.Drawing.Point(13, 30)
			Me.radCheckEnabled.Name = "radCheckEnabled"
			' 
			' 
			' 
			Me.radCheckEnabled.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckEnabled.Size = New System.Drawing.Size(64, 17)
			Me.radCheckEnabled.TabIndex = 3
			Me.radCheckEnabled.Text = "Enabled"
'			Me.radCheckEnabled.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadCheck_ToggleStateChanged);
			' 
			' radSpinEditorFrames
			' 
			Me.radSpinEditorFrames.BackColor = System.Drawing.Color.White
			Me.radSpinEditorFrames.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditorFrames.Location = New System.Drawing.Point(30, 119)
			Me.radSpinEditorFrames.Maximum = New Decimal(New Integer() { 40, 0, 0, 0})
			Me.radSpinEditorFrames.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radSpinEditorFrames.Name = "radSpinEditorFrames"
			' 
			' 
			' 
			Me.radSpinEditorFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorFrames.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditorFrames.ShowBorder = True
			Me.radSpinEditorFrames.Size = New System.Drawing.Size(120, 20)
			Me.radSpinEditorFrames.TabIndex = 2
			Me.radSpinEditorFrames.TabStop = False
			Me.radSpinEditorFrames.Value = New Decimal(New Integer() { 20, 0, 0, 0})
'			Me.radSpinEditorFrames.ValueChanged += New System.EventHandler(Me.radSpinEditorFrames_ValueChanged);
			' 
			' radLblFrames
			' 
			Me.radLblFrames.ForeColor = System.Drawing.Color.Black
			Me.radLblFrames.Location = New System.Drawing.Point(13, 99)
			Me.radLblFrames.Name = "radLblFrames"
			' 
			' 
			' 
			Me.radLblFrames.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblFrames.Size = New System.Drawing.Size(48, 16)
			Me.radLblFrames.TabIndex = 1
			Me.radLblFrames.Text = "Frames:"
			' 
			' radLblAnim
			' 
			Me.radLblAnim.ForeColor = System.Drawing.Color.Black
			Me.radLblAnim.Location = New System.Drawing.Point(13, 53)
			Me.radLblAnim.Name = "radLblAnim"
			' 
			' 
			' 
			Me.radLblAnim.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblAnim.Size = New System.Drawing.Size(116, 16)
			Me.radLblAnim.TabIndex = 1
			Me.radLblAnim.Text = "DropDown Animation:"
			' 
			' radComboAnimation
			' 
			Me.radComboAnimation.ForeColor = System.Drawing.Color.Black
			Me.radComboAnimation.Location = New System.Drawing.Point(30, 73)
			Me.radComboAnimation.Name = "radComboAnimation"
			' 
			' 
			' 
			Me.radComboAnimation.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboAnimation.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboAnimation.Size = New System.Drawing.Size(120, 20)
			Me.radComboAnimation.TabIndex = 0
			Me.radComboAnimation.TabStop = False
'			Me.radComboAnimation.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboAnimation_SelectedIndexChanged);
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.BackColor = System.Drawing.Color.White
			Me.radPanel1.Controls.Add(Me.radMenuDemo)
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(362, 237)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radPanel1.Size = New System.Drawing.Size(500, 350)
			Me.radPanel1.TabIndex = 6
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
			Me.Size = New System.Drawing.Size(1224, 820)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radCheckEnabled, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblAnim, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboAnimation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem4 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem21 As Telerik.WinControls.UI.RadMenuItem
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblAnim As Telerik.WinControls.UI.RadLabel
		Private WithEvents radComboAnimation As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radSpinEditorFrames As Telerik.WinControls.UI.RadSpinEditor
		Private radLblFrames As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckEnabled As Telerik.WinControls.UI.RadCheckBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
