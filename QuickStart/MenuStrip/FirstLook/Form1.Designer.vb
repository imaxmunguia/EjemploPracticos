Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim inputBinding1 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord1 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier1 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand1 As New Telerik.WinControls.Elements.ClickCommand()
			Dim inputBinding2 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord2 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier2 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand2 As New Telerik.WinControls.Elements.ClickCommand()
			Dim inputBinding3 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord3 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier3 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding4 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord4 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier4 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand3 As New Telerik.WinControls.Elements.ClickCommand()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem6 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem7 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuPrint = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem41 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuEmail = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem60 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuBurn = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem70 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem71 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuOpenWidth = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem72 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem73 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem74 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem81 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem76 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem77 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem78 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem79 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem80 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem66 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem67 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem68 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem69 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem34 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem35 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem36 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem48 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem49 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem50 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem51 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem52 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem53 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem54 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radPanelDemo = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemo.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(803, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 641)
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.ImageKey = "1_undo.gif"
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Add Folder to Gallery…"
			Me.radMenuItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem17.ToolTipText = Nothing
'			Me.radMenuItem17.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.ImageKey = "2_redo.gif"
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Import from Camera or Scanner…"
			Me.radMenuItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem18.ToolTipText = Nothing
'			Me.radMenuItem18.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.HintText = "Ctrl+C"
			Me.radMenuItem22.ImageKey = "6_Find.gif"
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Text = "Copy"
			Me.radMenuItem22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem22.ToolTipText = Nothing
'			Me.radMenuItem22.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.HintText = "Ctrl+M"
			Me.radMenuItem20.ImageKey = "4_Copy.gif"
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Rename"
			Me.radMenuItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem20.ToolTipText = Nothing
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.HintText = "Ctrl+N"
			Me.radMenuItem1_1.ImageKey = "1_New.gif"
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.Text = "New"
			Me.radMenuItem1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.ToolTipText = Nothing
'			Me.radMenuItem1_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenu1
			' 
			Me.radMenu1.AllItemsEqualHeight = True
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = System.Drawing.Color.Transparent
			chordModifier1.AltModifier = False
			chordModifier1.ControlModifier = True
			chordModifier1.ShiftModifier = False
			chord1.ChordModifier = chordModifier1
			chord1.Keys = "Ctrl+Z"
			inputBinding1.Chord = chord1
			clickCommand1.ContextType = Nothing
			clickCommand1.ImageList = Nothing
			clickCommand1.Name = "ActionCommand"
			clickCommand1.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand1.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand1.Type = ""
			inputBinding1.Command = clickCommand1
			inputBinding1.CommandContext = Me.radMenuItem17
			chordModifier2.AltModifier = False
			chordModifier2.ControlModifier = True
			chordModifier2.ShiftModifier = False
			chord2.ChordModifier = chordModifier2
			chord2.Keys = "Ctrl+Y"
			inputBinding2.Chord = chord2
			clickCommand2.ContextType = Nothing
			clickCommand2.ImageList = Nothing
			clickCommand2.Name = "ActionCommand"
			clickCommand2.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand2.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand2.Type = ""
			inputBinding2.Command = clickCommand2
			inputBinding2.CommandContext = Me.radMenuItem18
			chordModifier3.AltModifier = False
			chordModifier3.ControlModifier = True
			chordModifier3.ShiftModifier = False
			chord3.ChordModifier = chordModifier3
			chord3.Keys = "Ctrl+F"
			inputBinding3.Chord = chord3
			inputBinding3.Command = clickCommand2
			inputBinding3.CommandContext = Me.radMenuItem22
			chordModifier4.AltModifier = False
			chordModifier4.ControlModifier = True
			chordModifier4.ShiftModifier = False
			chord4.ChordModifier = chordModifier4
			chord4.Keys = "Ctrl+M"
			inputBinding4.Chord = chord4
			clickCommand3.ContextType = Nothing
			clickCommand3.ImageList = Nothing
			clickCommand3.Name = "ActionCommand"
			clickCommand3.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand3.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand3.Type = ""
			inputBinding4.Command = clickCommand3
			inputBinding4.CommandContext = Me.radMenuItem20
			Me.radMenu1.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() { inputBinding1, inputBinding2, inputBinding3, inputBinding4})
			Me.radMenu1.Dock = System.Windows.Forms.DockStyle.None
			Me.radMenu1.ImageList = Me.imageList1
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem9, Me.menuPrint, Me.menuEmail, Me.menuBurn, Me.menuOpenWidth, Me.radMenuItem16})
			Me.radMenu1.Location = New System.Drawing.Point(38, 28)
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenu1.RootElement.ToolTipText = Nothing
			Me.radMenu1.Size = New System.Drawing.Size(640, 30)
			Me.radMenu1.TabIndex = 0
			Me.radMenu1.Text = "radMenu1"
            CType(Me.radMenu1.GetChildAt(0), Telerik.WinControls.UI.RadMenuElement).AllItemsEqualHeight = True
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Lime
			Me.imageList1.Images.SetKeyName(0, "burner.png")
			Me.imageList1.Images.SetKeyName(1, "Email.png")
			Me.imageList1.Images.SetKeyName(2, "help.png")
			Me.imageList1.Images.SetKeyName(3, "New.png")
			Me.imageList1.Images.SetKeyName(4, "Open.png")
			Me.imageList1.Images.SetKeyName(5, "Print.png")
			Me.imageList1.Images.SetKeyName(6, "Order_prints.png")
			Me.imageList1.Images.SetKeyName(7, "paint.png")
			Me.imageList1.Images.SetKeyName(8, "Picture_Manager.png")
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem9.Image = (CType(resources.GetObject("radMenuItem9.Image"), System.Drawing.Image))
			Me.radMenuItem9.ImageIndex = 3
			Me.radMenuItem9.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem17, Me.radMenuItem18, Me.radMenuSeparatorItem1, Me.radMenuItem19, Me.radMenuItem20, Me.radMenuSeparatorItem2, Me.radMenuItem22, Me.radMenuSeparatorItem5, Me.radMenuItem23, Me.radMenuSeparatorItem6, Me.radMenuItem24, Me.radMenuSeparatorItem7, Me.radMenuItem1, Me.radMenuItem2, Me.radMenuSeparatorItem8, Me.radMenuItem3})
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "File"
			Me.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem9.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.HintText = "Del"
			Me.radMenuItem19.ImageKey = "3_Cut.gif"
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Delete"
			Me.radMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem19.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.Class = "RadMenuItem"
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Text = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.ToolTipText = Nothing
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.HintText = "Ctrl+A"
			Me.radMenuItem23.Name = "radMenuItem23"
			Me.radMenuItem23.Text = "Select All"
			Me.radMenuItem23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem23.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem6
			' 
			Me.radMenuSeparatorItem6.Class = "RadMenuItem"
			Me.radMenuSeparatorItem6.Name = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.Text = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.ToolTipText = Nothing
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.Name = "radMenuItem24"
			Me.radMenuItem24.Text = "Share With Devices…"
			Me.radMenuItem24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem24.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem7
			' 
			Me.radMenuSeparatorItem7.Class = "RadMenuItem"
			Me.radMenuSeparatorItem7.Name = "radMenuSeparatorItem7"
			Me.radMenuSeparatorItem7.Text = "New item"
			Me.radMenuSeparatorItem7.ToolTipText = Nothing
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.HintText = "Alt+Enter"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Properties"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Options"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem8
			' 
			Me.radMenuSeparatorItem8.Class = "RadMenuItem"
			Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.Text = "New item"
			Me.radMenuSeparatorItem8.ToolTipText = Nothing
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Exit"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' menuPrint
			' 
			Me.menuPrint.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuPrint.Enabled = False
			Me.menuPrint.Image = (CType(resources.GetObject("menuPrint.Image"), System.Drawing.Image))
			Me.menuPrint.ImageIndex = 5
			Me.menuPrint.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem41, Me.radMenuItem4})
			Me.menuPrint.Name = "menuPrint"
			Me.menuPrint.Text = "Print"
			Me.menuPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.menuPrint.ToolTipText = Nothing
			' 
			' radMenuItem41
			' 
			Me.radMenuItem41.Image = (CType(resources.GetObject("radMenuItem41.Image"), System.Drawing.Image))
			Me.radMenuItem41.ImageIndex = 5
			Me.radMenuItem41.Name = "radMenuItem41"
			Me.radMenuItem41.Text = "Print..."
			Me.radMenuItem41.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem41.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Image = (CType(resources.GetObject("radMenuItem4.Image"), System.Drawing.Image))
			Me.radMenuItem4.ImageIndex = 6
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Order Prints"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToolTipText = Nothing
			' 
			' menuEmail
			' 
			Me.menuEmail.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuEmail.Enabled = False
			Me.menuEmail.Image = (CType(resources.GetObject("menuEmail.Image"), System.Drawing.Image))
			Me.menuEmail.ImageIndex = 1
			Me.menuEmail.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem60})
			Me.menuEmail.Name = "menuEmail"
			Me.menuEmail.Text = "E-mail"
			Me.menuEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.menuEmail.ToolTipText = Nothing
			' 
			' radMenuItem60
			' 
			Me.radMenuItem60.ImageKey = "1_Table-of-contents.gif"
			Me.radMenuItem60.Name = "radMenuItem60"
			Me.radMenuItem60.Text = "E-mail selected item"
			Me.radMenuItem60.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem60.ToolTipText = Nothing
			' 
			' menuBurn
			' 
			Me.menuBurn.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuBurn.Enabled = False
			Me.menuBurn.Image = (CType(resources.GetObject("menuBurn.Image"), System.Drawing.Image))
			Me.menuBurn.ImageIndex = 0
			Me.menuBurn.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem70, Me.radMenuItem71})
			Me.menuBurn.Name = "menuBurn"
			Me.menuBurn.Text = "Burn"
			Me.menuBurn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.menuBurn.ToolTipText = Nothing
			' 
			' radMenuItem70
			' 
			Me.radMenuItem70.Name = "radMenuItem70"
			Me.radMenuItem70.Text = "Data Disc…"
			Me.radMenuItem70.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem70.ToolTipText = Nothing
			' 
			' radMenuItem71
			' 
			Me.radMenuItem71.Name = "radMenuItem71"
			Me.radMenuItem71.Text = "Video DVD…"
			Me.radMenuItem71.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem71.ToolTipText = Nothing
			' 
			' menuOpenWidth
			' 
			Me.menuOpenWidth.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuOpenWidth.Enabled = False
			Me.menuOpenWidth.Image = (CType(resources.GetObject("menuOpenWidth.Image"), System.Drawing.Image))
			Me.menuOpenWidth.ImageIndex = 4
			Me.menuOpenWidth.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem72, Me.radMenuItem73, Me.radMenuSeparatorItem3, Me.radMenuItem74})
			Me.menuOpenWidth.Name = "menuOpenWidth"
			Me.menuOpenWidth.Text = "Open With "
			Me.menuOpenWidth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.menuOpenWidth.ToolTipText = Nothing
			' 
			' radMenuItem72
			' 
			Me.radMenuItem72.Image = (CType(resources.GetObject("radMenuItem72.Image"), System.Drawing.Image))
			Me.radMenuItem72.ImageIndex = 8
			Me.radMenuItem72.Name = "radMenuItem72"
			Me.radMenuItem72.Text = "Picture Manager"
			Me.radMenuItem72.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem72.ToolTipText = Nothing
			' 
			' radMenuItem73
			' 
			Me.radMenuItem73.Image = (CType(resources.GetObject("radMenuItem73.Image"), System.Drawing.Image))
			Me.radMenuItem73.ImageIndex = 7
			Me.radMenuItem73.Name = "radMenuItem73"
			Me.radMenuItem73.Text = "Paint"
			Me.radMenuItem73.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem73.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Class = "RadMenuItem"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.ToolTipText = Nothing
			' 
			' radMenuItem74
			' 
			Me.radMenuItem74.ImageKey = "3_Thesaurus.gif"
			Me.radMenuItem74.Name = "radMenuItem74"
			Me.radMenuItem74.Text = "Choose Program…"
			Me.radMenuItem74.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem74.ToolTipText = Nothing
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem16.Image = (CType(resources.GetObject("radMenuItem16.Image"), System.Drawing.Image))
			Me.radMenuItem16.ImageIndex = 2
			Me.radMenuItem16.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem81})
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Help"
			Me.radMenuItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem16.ToolTipText = Nothing
			' 
			' radMenuItem81
			' 
			Me.radMenuItem81.Image = (CType(resources.GetObject("radMenuItem81.Image"), System.Drawing.Image))
			Me.radMenuItem81.ImageIndex = 2
			Me.radMenuItem81.Name = "radMenuItem81"
			Me.radMenuItem81.Text = "About RadMenu"
			Me.radMenuItem81.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem81.ToolTipText = Nothing
			' 
			' radMenuItem76
			' 
			Me.radMenuItem76.ImageKey = "1_View.gif"
			Me.radMenuItem76.Name = "radMenuItem76"
			Me.radMenuItem76.Text = "Normal"
			Me.radMenuItem76.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem76.ToolTipText = Nothing
			' 
			' radMenuItem77
			' 
			Me.radMenuItem77.ImageKey = "2_Web.gif"
			Me.radMenuItem77.Name = "radMenuItem77"
			Me.radMenuItem77.Text = "Web Layout"
			Me.radMenuItem77.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem77.ToolTipText = Nothing
			' 
			' radMenuItem78
			' 
			Me.radMenuItem78.ImageKey = "3_Print-layout.gif"
			Me.radMenuItem78.Name = "radMenuItem78"
			Me.radMenuItem78.Text = "Print Layout"
			Me.radMenuItem78.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem78.ToolTipText = Nothing
			' 
			' radMenuItem79
			' 
			Me.radMenuItem79.ImageKey = "4_Reading-Layout.gif"
			Me.radMenuItem79.Name = "radMenuItem79"
			Me.radMenuItem79.Text = "Reading Layout"
			Me.radMenuItem79.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem79.ToolTipText = Nothing
			' 
			' radMenuItem80
			' 
			Me.radMenuItem80.ImageKey = "5_Outline.gif"
			Me.radMenuItem80.Name = "radMenuItem80"
			Me.radMenuItem80.Text = "Outline"
			Me.radMenuItem80.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem80.ToolTipText = Nothing
			' 
			' radMenuItem66
			' 
			Me.radMenuItem66.CheckOnClick = True
			Me.radMenuItem66.IsChecked = True
			Me.radMenuItem66.Name = "radMenuItem66"
			Me.radMenuItem66.Text = "Do Not Show n Table of Contents"
			Me.radMenuItem66.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem66.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radMenuItem66.ToolTipText = Nothing
			' 
			' radMenuItem67
			' 
			Me.radMenuItem67.Name = "radMenuItem67"
			Me.radMenuItem67.Text = "Level 1"
			Me.radMenuItem67.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem67.ToolTipText = Nothing
			' 
			' radMenuItem68
			' 
			Me.radMenuItem68.Name = "radMenuItem68"
			Me.radMenuItem68.Text = "Level 2"
			Me.radMenuItem68.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem68.ToolTipText = Nothing
			' 
			' radMenuItem69
			' 
			Me.radMenuItem69.Name = "radMenuItem69"
			Me.radMenuItem69.Text = "Level 3"
			Me.radMenuItem69.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem69.ToolTipText = Nothing
			' 
			' radMenuItem34
			' 
			Me.radMenuItem34.ImageKey = "5_Clip-art.gif"
			Me.radMenuItem34.Name = "radMenuItem34"
			Me.radMenuItem34.Text = "Clip Art"
			Me.radMenuItem34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem34.ToolTipText = Nothing
			' 
			' radMenuItem35
			' 
			Me.radMenuItem35.ImageKey = "6_From-file.gif"
			Me.radMenuItem35.Name = "radMenuItem35"
			Me.radMenuItem35.Text = "From File"
			Me.radMenuItem35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem35.ToolTipText = Nothing
			' 
			' radMenuItem36
			' 
			Me.radMenuItem36.ImageKey = "7_From-scanner.gif"
			Me.radMenuItem36.Name = "radMenuItem36"
			Me.radMenuItem36.Text = "From Scanner or Camera"
			Me.radMenuItem36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem36.ToolTipText = Nothing
			' 
			' radMenuItem48
			' 
			Me.radMenuItem48.Name = "radMenuItem48"
			Me.radMenuItem48.Text = "Portrait"
			Me.radMenuItem48.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem48.ToolTipText = Nothing
			' 
			' radMenuItem49
			' 
			Me.radMenuItem49.Name = "radMenuItem49"
			Me.radMenuItem49.Text = "Landscape"
			Me.radMenuItem49.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem49.ToolTipText = Nothing
			' 
			' radMenuItem50
			' 
			Me.radMenuItem50.Name = "radMenuItem50"
			Me.radMenuItem50.Text = "Letter"
			Me.radMenuItem50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem50.ToolTipText = Nothing
			' 
			' radMenuItem51
			' 
			Me.radMenuItem51.Name = "radMenuItem51"
			Me.radMenuItem51.Text = "Tabloid"
			Me.radMenuItem51.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem51.ToolTipText = Nothing
			' 
			' radMenuItem52
			' 
			Me.radMenuItem52.Name = "radMenuItem52"
			Me.radMenuItem52.Text = "Legal"
			Me.radMenuItem52.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem52.ToolTipText = Nothing
			' 
			' radMenuItem53
			' 
			Me.radMenuItem53.Name = "radMenuItem53"
			Me.radMenuItem53.Text = "A3"
			Me.radMenuItem53.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem53.ToolTipText = Nothing
			' 
			' radMenuItem54
			' 
			Me.radMenuItem54.Name = "radMenuItem54"
			Me.radMenuItem54.Text = "A4"
			Me.radMenuItem54.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem54.ToolTipText = Nothing
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.HintText = "Ctrl+O"
			Me.radMenuItem1_2.ImageKey = "2_Open.gif"
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.Text = "Open"
			Me.radMenuItem1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.ToolTipText = Nothing
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.HintText = "Ctrl+Z"
			Me.radMenuItem2_1.ImageKey = "1_Properties.gif"
			Me.radMenuItem2_1.Name = "radMenuItem2_1"
			Me.radMenuItem2_1.Text = "Properties"
			Me.radMenuItem2_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.ToolTipText = Nothing
'			Me.radMenuItem2_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.HintText = "Ctrl+Y"
			Me.radMenuItem2_2.ImageKey = "2_Inspect_Document.gif"
			Me.radMenuItem2_2.Name = "radMenuItem2_2"
			Me.radMenuItem2_2.Text = "Inspect Document"
			Me.radMenuItem2_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.ToolTipText = Nothing
'			Me.radMenuItem2_2.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.HintText = "Ctrl+X"
			Me.radMenuItem2_3.ImageKey = "3_Encrypt_Document.gif"
			Me.radMenuItem2_3.Name = "radMenuItem2_3"
			Me.radMenuItem2_3.Text = "Encrypt Document"
			Me.radMenuItem2_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.ToolTipText = Nothing
'			Me.radMenuItem2_3.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.HintText = "Ctrl+C"
			Me.radMenuItem2_4.ImageKey = "4_Restrict_Permission.gif"
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.Text = "Restrict Permission"
			Me.radMenuItem2_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.ToolTipText = Nothing
'			Me.radMenuItem2_4.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem2_5
			' 
			Me.radMenuItem2_5.HintText = "Ctrl+V"
			Me.radMenuItem2_5.ImageKey = "5_Add_a_Digital_Signature.gif"
			Me.radMenuItem2_5.Name = "radMenuItem2_5"
			Me.radMenuItem2_5.Text = "Add a Digital Signature"
			Me.radMenuItem2_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_5.ToolTipText = Nothing
'			Me.radMenuItem2_5.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.HintText = "Ctrl+Shift+B"
			Me.radMenuItem4_1.ImageKey = "1_Blog.gif"
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.Text = "Blog"
			Me.radMenuItem4_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.ToolTipText = Nothing
'			Me.radMenuItem4_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.HintText = "Shift+F6"
			Me.radMenuItem4_2.ImageKey = "2_Document_Management.gif"
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.Text = "Document Management"
			Me.radMenuItem4_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.ToolTipText = Nothing
'			Me.radMenuItem4_2.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem5_1
			' 
			Me.radMenuItem5_1.HintText = "Shift+Alt+D"
			Me.radMenuItem5_1.ImageKey = "1_Word_Document.gif"
			Me.radMenuItem5_1.Name = "radMenuItem5_1"
			Me.radMenuItem5_1.Text = "Word Document"
			Me.radMenuItem5_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_1.ToolTipText = Nothing
'			Me.radMenuItem5_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.ImageKey = "3_Save.gif"
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.Text = "Save"
			Me.radMenuItem1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.ToolTipText = Nothing
'			Me.radMenuItem1_3.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.ImageKey = "4_Save_as.gif"
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.Text = "Save as"
			Me.radMenuItem1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.ToolTipText = Nothing
'			Me.radMenuItem1_4.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_5
			' 
			Me.radMenuItem1_5.ImageKey = "5_Print.gif"
			Me.radMenuItem1_5.Name = "radMenuItem1_5"
			Me.radMenuItem1_5.Text = "Print"
			Me.radMenuItem1_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_5.ToolTipText = Nothing
'			Me.radMenuItem1_5.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_6
			' 
			Me.radMenuItem1_6.ImageKey = "6_Prepare.gif"
			Me.radMenuItem1_6.Name = "radMenuItem1_6"
			Me.radMenuItem1_6.Text = "Prepare"
			Me.radMenuItem1_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_6.ToolTipText = Nothing
'			Me.radMenuItem1_6.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_7
			' 
			Me.radMenuItem1_7.ImageKey = "7_Send.gif"
			Me.radMenuItem1_7.Name = "radMenuItem1_7"
			Me.radMenuItem1_7.Text = "Send"
			Me.radMenuItem1_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_7.ToolTipText = Nothing
'			Me.radMenuItem1_7.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_8
			' 
			Me.radMenuItem1_8.ImageKey = "8_Publish.gif"
			Me.radMenuItem1_8.Name = "radMenuItem1_8"
			Me.radMenuItem1_8.Text = "Publish"
			Me.radMenuItem1_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_8.ToolTipText = Nothing
'			Me.radMenuItem1_8.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem1_9
			' 
			Me.radMenuItem1_9.ImageKey = "9_Close.gif"
			Me.radMenuItem1_9.Name = "radMenuItem1_9"
			Me.radMenuItem1_9.Text = "Close"
			Me.radMenuItem1_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_9.ToolTipText = Nothing
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.ToolTipText = Nothing
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.ToolTipText = Nothing
			' 
			' radMenuItem2_6
			' 
			Me.radMenuItem2_6.ImageKey = "6_Mark_As_Final.gif"
			Me.radMenuItem2_6.Name = "radMenuItem2_6"
			Me.radMenuItem2_6.Text = "Mark As Final"
			Me.radMenuItem2_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_6.ToolTipText = Nothing
'			Me.radMenuItem2_6.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem2_7
			' 
			Me.radMenuItem2_7.ImageKey = "7_Run_Compatibility_Checker.gif"
			Me.radMenuItem2_7.Name = "radMenuItem2_7"
			Me.radMenuItem2_7.Text = "Run Compatibility Checker"
			Me.radMenuItem2_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_7.ToolTipText = Nothing
'			Me.radMenuItem2_7.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.ImageKey = "1_Print.gif"
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.Text = "Print"
			Me.radMenuItem3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.ToolTipText = Nothing
'			Me.radMenuItem3_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.ImageKey = "2_Quick_Print.gif"
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.Text = "Quick Print"
			Me.radMenuItem3_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.ToolTipText = Nothing
'			Me.radMenuItem3_2.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.ImageKey = "3_Print_Preview.gif"
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.Text = "Print Preview"
			Me.radMenuItem3_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.ToolTipText = Nothing
'			Me.radMenuItem3_3.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.ImageKey = "3_Create_Document_Workspace.gif"
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.Text = "Create Document Workspace"
			Me.radMenuItem4_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.ToolTipText = Nothing
'			Me.radMenuItem4_3.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem5_2
			' 
			Me.radMenuItem5_2.ImageKey = "2_Word_Template.gif"
			Me.radMenuItem5_2.Name = "radMenuItem5_2"
			Me.radMenuItem5_2.Text = "Word Template"
			Me.radMenuItem5_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_2.ToolTipText = Nothing
'			Me.radMenuItem5_2.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem5_3
			' 
			Me.radMenuItem5_3.ImageKey = "3_Word_97_document.gif"
			Me.radMenuItem5_3.Name = "radMenuItem5_3"
			Me.radMenuItem5_3.Text = "Word97 Document"
			Me.radMenuItem5_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_3.ToolTipText = Nothing
			' 
			' radMenuItem5_4
			' 
			Me.radMenuItem5_4.ImageKey = "4_ Find_addins.gif"
			Me.radMenuItem5_4.Name = "radMenuItem5_4"
			Me.radMenuItem5_4.Text = "Find addins"
			Me.radMenuItem5_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_4.ToolTipText = Nothing
			' 
			' radMenuItem5_5
			' 
			Me.radMenuItem5_5.ImageKey = "5_Other_Formats.gif"
			Me.radMenuItem5_5.Name = "radMenuItem5_5"
			Me.radMenuItem5_5.Text = "Other Formats"
			Me.radMenuItem5_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_5.ToolTipText = Nothing
			' 
			' radMenuItem6_1
			' 
			Me.radMenuItem6_1.ImageKey = "1_E-mail.gif"
			Me.radMenuItem6_1.Name = "radMenuItem6_1"
			Me.radMenuItem6_1.Text = "E-mail"
			Me.radMenuItem6_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_1.ToolTipText = Nothing
'			Me.radMenuItem6_1.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radMenuItem6_2
			' 
			Me.radMenuItem6_2.ImageKey = "2_Internet_Fax.gif"
			Me.radMenuItem6_2.Name = "radMenuItem6_2"
			Me.radMenuItem6_2.Text = "Internet Fax"
			Me.radMenuItem6_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_2.ToolTipText = Nothing
'			Me.radMenuItem6_2.Click += New System.EventHandler(Me.radMenuItem_Click);
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.radButton1.BackColor = System.Drawing.Color.Transparent
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Image = My.Resources.pic1
			Me.radButton1.Location = New System.Drawing.Point(35, 179)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.RootElement.StretchHorizontally = False
			Me.radButton1.RootElement.StretchVertically = False
			Me.radButton1.RootElement.ToolTipText = Nothing
			Me.radButton1.Size = New System.Drawing.Size(151, 100)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"
			Me.radButton1.ThemeName = "MenuFirstLook_Button"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.radButton2.BackColor = System.Drawing.Color.Transparent
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton2.ForeColor = System.Drawing.Color.Black
			Me.radButton2.Image = My.Resources.pic2
			Me.radButton2.Location = New System.Drawing.Point(205, 179)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton2.RootElement.StretchHorizontally = False
			Me.radButton2.RootElement.StretchVertically = False
			Me.radButton2.RootElement.ToolTipText = Nothing
			Me.radButton2.Size = New System.Drawing.Size(151, 100)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "radButton2"
			Me.radButton2.ThemeName = "MenuFirstLook_Button"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton3
			' 
			Me.radButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.radButton3.BackColor = System.Drawing.Color.Transparent
			Me.radButton3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton3.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Image = My.Resources.pic3
			Me.radButton3.Location = New System.Drawing.Point(375, 179)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton3.RootElement.StretchHorizontally = False
			Me.radButton3.RootElement.StretchVertically = False
			Me.radButton3.RootElement.ToolTipText = Nothing
			Me.radButton3.Size = New System.Drawing.Size(151, 100)
			Me.radButton3.TabIndex = 3
			Me.radButton3.Text = "radButton3"
			Me.radButton3.ThemeName = "MenuFirstLook_Button"
'			Me.radButton3.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton4
			' 
			Me.radButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.radButton4.BackColor = System.Drawing.Color.Transparent
			Me.radButton4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton4.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Image = My.Resources.pic4
			Me.radButton4.Location = New System.Drawing.Point(545, 179)
			Me.radButton4.Name = "radButton4"
			' 
			' 
			' 
			Me.radButton4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton4.RootElement.StretchHorizontally = False
			Me.radButton4.RootElement.StretchVertically = False
			Me.radButton4.RootElement.ToolTipText = Nothing
			Me.radButton4.Size = New System.Drawing.Size(151, 100)
			Me.radButton4.TabIndex = 4
			Me.radButton4.Text = "radButton4"
			Me.radButton4.ThemeName = "MenuFirstLook_Button"
'			Me.radButton4.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Font = New System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.radLabel1.ForeColor = System.Drawing.Color.SteelBlue
			Me.radLabel1.Location = New System.Drawing.Point(39, 25)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.SteelBlue
			Me.radLabel1.RootElement.ToolTipText = Nothing
			Me.radLabel1.Size = New System.Drawing.Size(305, 24)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "Select a photo to enable the menu"
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = "Telerik.Examples.WinControls.Resources.MenuFirstLook.xml"
			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = "Telerik.Examples.WinControls.Resources.MenuFirstLook_Button.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1, themeSource2})
			' 
			' radPanelDemo
			' 
			Me.radPanelDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemo.Controls.Add(Me.radPanel1)
			Me.radPanelDemo.Controls.Add(Me.radButton1)
			Me.radPanelDemo.Controls.Add(Me.radLabel1)
			Me.radPanelDemo.Controls.Add(Me.radButton2)
			Me.radPanelDemo.Controls.Add(Me.radButton4)
			Me.radPanelDemo.Controls.Add(Me.radButton3)
			Me.radPanelDemo.Location = New System.Drawing.Point(137, 174)
			Me.radPanelDemo.Name = "radPanelDemo"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.RootElement.Shape = Me.roundRectShape1
			Me.radPanelDemo.Size = New System.Drawing.Size(731, 294)
			Me.radPanelDemo.TabIndex = 8
			CType(Me.radPanelDemo.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.White
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(214))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(237))))))
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(152))))), (CInt(Fix((CByte(207))))), (CInt(Fix((CByte(221))))))
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.54F
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanelDemo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(117))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(188))))))
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = My.Resources.menu_firstlook_bg
			Me.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
			Me.radPanel1.Controls.Add(Me.radMenu1)
			Me.radPanel1.Location = New System.Drawing.Point(7, 55)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(717, 87)
			Me.radPanel1.TabIndex = 7
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.Radius = 10
			' 
			' Form1
			' 
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.Controls.Add(Me.radPanelDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1004, 643)
			Me.Controls.SetChildIndex(Me.radPanelDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemo.ResumeLayout(False)
			Me.radPanelDemo.PerformLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private WithEvents radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_5 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_6 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_7 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem1_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_9 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_5 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_6 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2_7 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem5_1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem5_2 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem6_1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem6_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private menuPrint As Telerik.WinControls.UI.RadMenuItem
		Private menuEmail As Telerik.WinControls.UI.RadMenuItem
		Private menuBurn As Telerik.WinControls.UI.RadMenuItem
		Private menuOpenWidth As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private WithEvents radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem23 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem24 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem34 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem35 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem36 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem48 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem49 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem50 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem51 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem52 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem53 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem54 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem41 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem60 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem66 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem67 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem68 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem69 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem70 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem71 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem72 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem73 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem74 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem76 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem77 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem78 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem79 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem80 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem81 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem6 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem7 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton4 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radPanelDemo As Telerik.WinControls.UI.RadPanel
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape

	End Class
End Namespace