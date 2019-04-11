Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.Theming
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource3 As New Telerik.WinControls.ThemeSource()
			Dim themeSource4 As New Telerik.WinControls.ThemeSource()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem41 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem60 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem70 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem71 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem72 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem73 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem74 = New Telerik.WinControls.UI.RadMenuItem()
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
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem17.Class = "RadMenuItem"
			Me.radMenuItem17.DescriptionText = ""
			Me.radMenuItem17.ImageKey = "1_undo.gif"
			Me.radMenuItem17.IsMainMenuItem = False
			Me.radMenuItem17.Text = "Add Folder to Gallery…"
			Me.radMenuItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem17.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem17.ToolTipText = Nothing
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem18.Class = "RadMenuItem"
			Me.radMenuItem18.DescriptionText = ""
			Me.radMenuItem18.ImageKey = "2_redo.gif"
			Me.radMenuItem18.IsMainMenuItem = False
			Me.radMenuItem18.Text = "Import from Camera or Scanner…"
			Me.radMenuItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem18.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem18.ToolTipText = Nothing
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem22.Class = "RadMenuItem"
			Me.radMenuItem22.DescriptionText = ""
			Me.radMenuItem22.HintText = "Ctrl+C"
			Me.radMenuItem22.ImageKey = "6_Find.gif"
			Me.radMenuItem22.IsMainMenuItem = False
			Me.radMenuItem22.Text = "Copy"
			Me.radMenuItem22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem22.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem22.ToolTipText = Nothing
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem20.Class = "RadMenuItem"
			Me.radMenuItem20.DescriptionText = ""
			Me.radMenuItem20.HintText = "Ctrl+M"
			Me.radMenuItem20.ImageKey = "4_Copy.gif"
			Me.radMenuItem20.IsMainMenuItem = False
			Me.radMenuItem20.Text = "Rename"
			Me.radMenuItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem20.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem20.ToolTipText = Nothing
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_1.Class = "RadMenuItem"
			Me.radMenuItem1_1.DescriptionText = ""
			Me.radMenuItem1_1.HintText = "Ctrl+N"
			Me.radMenuItem1_1.ImageKey = "1_New.gif"
			Me.radMenuItem1_1.IsMainMenuItem = False
			Me.radMenuItem1_1.Text = "New"
			Me.radMenuItem1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_1.ToolTipText = Nothing
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
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AutoSize = False
			Me.radMenuSeparatorItem1.IsMainMenuItem = False
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem19.Class = "RadMenuItem"
			Me.radMenuItem19.DescriptionText = ""
			Me.radMenuItem19.HintText = "Del"
			Me.radMenuItem19.ImageKey = "3_Cut.gif"
			Me.radMenuItem19.IsMainMenuItem = False
			Me.radMenuItem19.Text = "Delete"
			Me.radMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem19.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem19.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.IsMainMenuItem = False
			Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem23.Class = "RadMenuItem"
			Me.radMenuItem23.DescriptionText = ""
			Me.radMenuItem23.HintText = "Ctrl+A"
			Me.radMenuItem23.IsMainMenuItem = False
			Me.radMenuItem23.Text = "Select All"
			Me.radMenuItem23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem23.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem23.ToolTipText = Nothing
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem24.Class = "RadMenuItem"
			Me.radMenuItem24.DescriptionText = ""
			Me.radMenuItem24.IsMainMenuItem = False
			Me.radMenuItem24.Text = "Share With Devices…"
			Me.radMenuItem24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem24.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem24.ToolTipText = Nothing
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1.Class = "RadMenuItem"
			Me.radMenuItem1.DescriptionText = ""
			Me.radMenuItem1.HintText = "Alt+Enter"
			Me.radMenuItem1.IsMainMenuItem = False
			Me.radMenuItem1.Text = "Properties"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2.Class = "RadMenuItem"
			Me.radMenuItem2.DescriptionText = ""
			Me.radMenuItem2.IsMainMenuItem = False
			Me.radMenuItem2.Text = "Options"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem3.Class = "RadMenuItem"
			Me.radMenuItem3.DescriptionText = ""
			Me.radMenuItem3.IsMainMenuItem = False
			Me.radMenuItem3.Text = "Exit"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' radMenuItem41
			' 
			Me.radMenuItem41.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem41.Class = "RadMenuItem"
			Me.radMenuItem41.DescriptionText = ""
			Me.radMenuItem41.ImageIndex = 5
			Me.radMenuItem41.IsMainMenuItem = False
			Me.radMenuItem41.Text = "Print..."
			Me.radMenuItem41.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem41.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem41.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem4.Class = "RadMenuItem"
			Me.radMenuItem4.DescriptionText = ""
			Me.radMenuItem4.ImageIndex = 6
			Me.radMenuItem4.IsMainMenuItem = False
			Me.radMenuItem4.Text = "Order Prints"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem4.ToolTipText = Nothing
			' 
			' radMenuItem60
			' 
			Me.radMenuItem60.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem60.Class = "RadMenuItem"
			Me.radMenuItem60.DescriptionText = ""
			Me.radMenuItem60.ImageKey = "1_Table-of-contents.gif"
			Me.radMenuItem60.IsMainMenuItem = False
			Me.radMenuItem60.Text = "E-mail selected item"
			Me.radMenuItem60.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem60.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem60.ToolTipText = Nothing
			' 
			' radMenuItem70
			' 
			Me.radMenuItem70.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem70.Class = "RadMenuItem"
			Me.radMenuItem70.DescriptionText = ""
			Me.radMenuItem70.IsMainMenuItem = False
			Me.radMenuItem70.Text = "Data Disc…"
			Me.radMenuItem70.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem70.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem70.ToolTipText = Nothing
			' 
			' radMenuItem71
			' 
			Me.radMenuItem71.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem71.Class = "RadMenuItem"
			Me.radMenuItem71.DescriptionText = ""
			Me.radMenuItem71.IsMainMenuItem = False
			Me.radMenuItem71.Text = "Video DVD…"
			Me.radMenuItem71.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem71.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem71.ToolTipText = Nothing
			' 
			' radMenuItem72
			' 
			Me.radMenuItem72.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem72.Class = "RadMenuItem"
			Me.radMenuItem72.DescriptionText = ""
			Me.radMenuItem72.ImageIndex = 8
			Me.radMenuItem72.IsMainMenuItem = False
			Me.radMenuItem72.Text = "Picture Manager"
			Me.radMenuItem72.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem72.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem72.ToolTipText = Nothing
			' 
			' radMenuItem73
			' 
			Me.radMenuItem73.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem73.Class = "RadMenuItem"
			Me.radMenuItem73.DescriptionText = ""
			Me.radMenuItem73.ImageIndex = 7
			Me.radMenuItem73.IsMainMenuItem = False
			Me.radMenuItem73.Text = "Paint"
			Me.radMenuItem73.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem73.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem73.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Class = "RadMenuItem"
			Me.radMenuSeparatorItem3.IsMainMenuItem = False
			Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.ToolTipText = Nothing
			' 
			' radMenuItem74
			' 
			Me.radMenuItem74.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem74.Class = "RadMenuItem"
			Me.radMenuItem74.DescriptionText = ""
			Me.radMenuItem74.ImageKey = "3_Thesaurus.gif"
			Me.radMenuItem74.IsMainMenuItem = False
			Me.radMenuItem74.Text = "Choose Program…"
			Me.radMenuItem74.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem74.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem74.ToolTipText = Nothing
			' 
			' radMenuItem81
			' 
			Me.radMenuItem81.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem81.Class = "RadMenuItem"
			Me.radMenuItem81.DescriptionText = ""
			Me.radMenuItem81.ImageIndex = 2
			Me.radMenuItem81.IsMainMenuItem = False
			Me.radMenuItem81.Text = "About RadMenu"
			Me.radMenuItem81.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem81.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem81.ToolTipText = Nothing
			' 
			' radMenuItem76
			' 
			Me.radMenuItem76.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem76.Class = "RadMenuItem"
			Me.radMenuItem76.DescriptionText = ""
			Me.radMenuItem76.ImageKey = "1_View.gif"
			Me.radMenuItem76.IsMainMenuItem = False
			Me.radMenuItem76.Text = "Normal"
			Me.radMenuItem76.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem76.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem76.ToolTipText = Nothing
			' 
			' radMenuItem77
			' 
			Me.radMenuItem77.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem77.Class = "RadMenuItem"
			Me.radMenuItem77.DescriptionText = ""
			Me.radMenuItem77.ImageKey = "2_Web.gif"
			Me.radMenuItem77.IsMainMenuItem = False
			Me.radMenuItem77.Text = "Web Layout"
			Me.radMenuItem77.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem77.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem77.ToolTipText = Nothing
			' 
			' radMenuItem78
			' 
			Me.radMenuItem78.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem78.Class = "RadMenuItem"
			Me.radMenuItem78.DescriptionText = ""
			Me.radMenuItem78.ImageKey = "3_Print-layout.gif"
			Me.radMenuItem78.IsMainMenuItem = False
			Me.radMenuItem78.Text = "Print Layout"
			Me.radMenuItem78.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem78.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem78.ToolTipText = Nothing
			' 
			' radMenuItem79
			' 
			Me.radMenuItem79.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem79.Class = "RadMenuItem"
			Me.radMenuItem79.DescriptionText = ""
			Me.radMenuItem79.ImageKey = "4_Reading-Layout.gif"
			Me.radMenuItem79.IsMainMenuItem = False
			Me.radMenuItem79.Text = "Reading Layout"
			Me.radMenuItem79.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem79.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem79.ToolTipText = Nothing
			' 
			' radMenuItem80
			' 
			Me.radMenuItem80.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem80.Class = "RadMenuItem"
			Me.radMenuItem80.DescriptionText = ""
			Me.radMenuItem80.ImageKey = "5_Outline.gif"
			Me.radMenuItem80.IsMainMenuItem = False
			Me.radMenuItem80.Text = "Outline"
			Me.radMenuItem80.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem80.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem80.ToolTipText = Nothing
			' 
			' radMenuItem66
			' 
			Me.radMenuItem66.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem66.CheckOnClick = True
			Me.radMenuItem66.Class = "RadMenuItem"
			Me.radMenuItem66.DescriptionText = ""
			Me.radMenuItem66.IsChecked = True
			Me.radMenuItem66.IsMainMenuItem = False
			Me.radMenuItem66.Text = "Do Not Show n Table of Contents"
			Me.radMenuItem66.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem66.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radMenuItem66.ToolTipText = Nothing
			' 
			' radMenuItem67
			' 
			Me.radMenuItem67.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem67.Class = "RadMenuItem"
			Me.radMenuItem67.DescriptionText = ""
			Me.radMenuItem67.IsMainMenuItem = False
			Me.radMenuItem67.Text = "Level 1"
			Me.radMenuItem67.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem67.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem67.ToolTipText = Nothing
			' 
			' radMenuItem68
			' 
			Me.radMenuItem68.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem68.Class = "RadMenuItem"
			Me.radMenuItem68.DescriptionText = ""
			Me.radMenuItem68.IsMainMenuItem = False
			Me.radMenuItem68.Text = "Level 2"
			Me.radMenuItem68.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem68.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem68.ToolTipText = Nothing
			' 
			' radMenuItem69
			' 
			Me.radMenuItem69.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem69.Class = "RadMenuItem"
			Me.radMenuItem69.DescriptionText = ""
			Me.radMenuItem69.IsMainMenuItem = False
			Me.radMenuItem69.Text = "Level 3"
			Me.radMenuItem69.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem69.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem69.ToolTipText = Nothing
			' 
			' radMenuItem34
			' 
			Me.radMenuItem34.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem34.Class = "RadMenuItem"
			Me.radMenuItem34.DescriptionText = ""
			Me.radMenuItem34.ImageKey = "5_Clip-art.gif"
			Me.radMenuItem34.IsMainMenuItem = False
			Me.radMenuItem34.Text = "Clip Art"
			Me.radMenuItem34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem34.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem34.ToolTipText = Nothing
			' 
			' radMenuItem35
			' 
			Me.radMenuItem35.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem35.Class = "RadMenuItem"
			Me.radMenuItem35.DescriptionText = ""
			Me.radMenuItem35.ImageKey = "6_From-file.gif"
			Me.radMenuItem35.IsMainMenuItem = False
			Me.radMenuItem35.Text = "From File"
			Me.radMenuItem35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem35.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem35.ToolTipText = Nothing
			' 
			' radMenuItem36
			' 
			Me.radMenuItem36.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem36.Class = "RadMenuItem"
			Me.radMenuItem36.DescriptionText = ""
			Me.radMenuItem36.ImageKey = "7_From-scanner.gif"
			Me.radMenuItem36.IsMainMenuItem = False
			Me.radMenuItem36.Text = "From Scanner or Camera"
			Me.radMenuItem36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem36.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem36.ToolTipText = Nothing
			' 
			' radMenuItem48
			' 
			Me.radMenuItem48.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem48.Class = "RadMenuItem"
			Me.radMenuItem48.DescriptionText = ""
			Me.radMenuItem48.IsMainMenuItem = False
			Me.radMenuItem48.Text = "Portrait"
			Me.radMenuItem48.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem48.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem48.ToolTipText = Nothing
			' 
			' radMenuItem49
			' 
			Me.radMenuItem49.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem49.Class = "RadMenuItem"
			Me.radMenuItem49.DescriptionText = ""
			Me.radMenuItem49.IsMainMenuItem = False
			Me.radMenuItem49.Text = "Landscape"
			Me.radMenuItem49.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem49.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem49.ToolTipText = Nothing
			' 
			' radMenuItem50
			' 
			Me.radMenuItem50.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem50.Class = "RadMenuItem"
			Me.radMenuItem50.DescriptionText = ""
			Me.radMenuItem50.IsMainMenuItem = False
			Me.radMenuItem50.Text = "Letter"
			Me.radMenuItem50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem50.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem50.ToolTipText = Nothing
			' 
			' radMenuItem51
			' 
			Me.radMenuItem51.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem51.Class = "RadMenuItem"
			Me.radMenuItem51.DescriptionText = ""
			Me.radMenuItem51.IsMainMenuItem = False
			Me.radMenuItem51.Text = "Tabloid"
			Me.radMenuItem51.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem51.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem51.ToolTipText = Nothing
			' 
			' radMenuItem52
			' 
			Me.radMenuItem52.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem52.Class = "RadMenuItem"
			Me.radMenuItem52.DescriptionText = ""
			Me.radMenuItem52.IsMainMenuItem = False
			Me.radMenuItem52.Text = "Legal"
			Me.radMenuItem52.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem52.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem52.ToolTipText = Nothing
			' 
			' radMenuItem53
			' 
			Me.radMenuItem53.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem53.Class = "RadMenuItem"
			Me.radMenuItem53.DescriptionText = ""
			Me.radMenuItem53.IsMainMenuItem = False
			Me.radMenuItem53.Text = "A3"
			Me.radMenuItem53.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem53.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem53.ToolTipText = Nothing
			' 
			' radMenuItem54
			' 
			Me.radMenuItem54.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem54.Class = "RadMenuItem"
			Me.radMenuItem54.DescriptionText = ""
			Me.radMenuItem54.IsMainMenuItem = False
			Me.radMenuItem54.Text = "A4"
			Me.radMenuItem54.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem54.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem54.ToolTipText = Nothing
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_2.Class = "RadMenuItem"
			Me.radMenuItem1_2.DescriptionText = ""
			Me.radMenuItem1_2.HintText = "Ctrl+O"
			Me.radMenuItem1_2.ImageKey = "2_Open.gif"
			Me.radMenuItem1_2.IsMainMenuItem = False
			Me.radMenuItem1_2.Text = "Open"
			Me.radMenuItem1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_2.ToolTipText = Nothing
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_1.Class = "RadMenuItem"
			Me.radMenuItem2_1.DescriptionText = ""
			Me.radMenuItem2_1.HintText = "Ctrl+Z"
			Me.radMenuItem2_1.ImageKey = "1_Properties.gif"
			Me.radMenuItem2_1.IsMainMenuItem = False
			Me.radMenuItem2_1.Text = "Properties"
			Me.radMenuItem2_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_1.ToolTipText = Nothing
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_2.Class = "RadMenuItem"
			Me.radMenuItem2_2.DescriptionText = ""
			Me.radMenuItem2_2.HintText = "Ctrl+Y"
			Me.radMenuItem2_2.ImageKey = "2_Inspect_Document.gif"
			Me.radMenuItem2_2.IsMainMenuItem = False
			Me.radMenuItem2_2.Text = "Inspect Document"
			Me.radMenuItem2_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_2.ToolTipText = Nothing
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_3.Class = "RadMenuItem"
			Me.radMenuItem2_3.DescriptionText = ""
			Me.radMenuItem2_3.HintText = "Ctrl+X"
			Me.radMenuItem2_3.ImageKey = "3_Encrypt_Document.gif"
			Me.radMenuItem2_3.IsMainMenuItem = False
			Me.radMenuItem2_3.Text = "Encrypt Document"
			Me.radMenuItem2_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_3.ToolTipText = Nothing
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_4.Class = "RadMenuItem"
			Me.radMenuItem2_4.DescriptionText = ""
			Me.radMenuItem2_4.HintText = "Ctrl+C"
			Me.radMenuItem2_4.ImageKey = "4_Restrict_Permission.gif"
			Me.radMenuItem2_4.IsMainMenuItem = False
			Me.radMenuItem2_4.Text = "Restrict Permission"
			Me.radMenuItem2_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_4.ToolTipText = Nothing
			' 
			' radMenuItem2_5
			' 
			Me.radMenuItem2_5.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_5.Class = "RadMenuItem"
			Me.radMenuItem2_5.DescriptionText = ""
			Me.radMenuItem2_5.HintText = "Ctrl+V"
			Me.radMenuItem2_5.ImageKey = "5_Add_a_Digital_Signature.gif"
			Me.radMenuItem2_5.IsMainMenuItem = False
			Me.radMenuItem2_5.Text = "Add a Digital Signature"
			Me.radMenuItem2_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_5.ToolTipText = Nothing
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem4_1.Class = "RadMenuItem"
			Me.radMenuItem4_1.DescriptionText = ""
			Me.radMenuItem4_1.HintText = "Ctrl+Shift+B"
			Me.radMenuItem4_1.ImageKey = "1_Blog.gif"
			Me.radMenuItem4_1.IsMainMenuItem = False
			Me.radMenuItem4_1.Text = "Blog"
			Me.radMenuItem4_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem4_1.ToolTipText = Nothing
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem4_2.Class = "RadMenuItem"
			Me.radMenuItem4_2.DescriptionText = ""
			Me.radMenuItem4_2.HintText = "Shift+F6"
			Me.radMenuItem4_2.ImageKey = "2_Document_Management.gif"
			Me.radMenuItem4_2.IsMainMenuItem = False
			Me.radMenuItem4_2.Text = "Document Management"
			Me.radMenuItem4_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem4_2.ToolTipText = Nothing
			' 
			' radMenuItem5_1
			' 
			Me.radMenuItem5_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5_1.Class = "RadMenuItem"
			Me.radMenuItem5_1.DescriptionText = ""
			Me.radMenuItem5_1.HintText = "Shift+Alt+D"
			Me.radMenuItem5_1.ImageKey = "1_Word_Document.gif"
			Me.radMenuItem5_1.IsMainMenuItem = False
			Me.radMenuItem5_1.Text = "Word Document"
			Me.radMenuItem5_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5_1.ToolTipText = Nothing
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_3.Class = "RadMenuItem"
			Me.radMenuItem1_3.DescriptionText = ""
			Me.radMenuItem1_3.ImageKey = "3_Save.gif"
			Me.radMenuItem1_3.IsMainMenuItem = False
			Me.radMenuItem1_3.Text = "Save"
			Me.radMenuItem1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_3.ToolTipText = Nothing
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_4.Class = "RadMenuItem"
			Me.radMenuItem1_4.DescriptionText = ""
			Me.radMenuItem1_4.ImageKey = "4_Save_as.gif"
			Me.radMenuItem1_4.IsMainMenuItem = False
			Me.radMenuItem1_4.Text = "Save as"
			Me.radMenuItem1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_4.ToolTipText = Nothing
			' 
			' radMenuItem1_5
			' 
			Me.radMenuItem1_5.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_5.Class = "RadMenuItem"
			Me.radMenuItem1_5.DescriptionText = ""
			Me.radMenuItem1_5.ImageKey = "5_Print.gif"
			Me.radMenuItem1_5.IsMainMenuItem = False
			Me.radMenuItem1_5.Text = "Print"
			Me.radMenuItem1_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_5.ToolTipText = Nothing
			' 
			' radMenuItem1_6
			' 
			Me.radMenuItem1_6.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_6.Class = "RadMenuItem"
			Me.radMenuItem1_6.DescriptionText = ""
			Me.radMenuItem1_6.ImageKey = "6_Prepare.gif"
			Me.radMenuItem1_6.IsMainMenuItem = False
			Me.radMenuItem1_6.Text = "Prepare"
			Me.radMenuItem1_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_6.ToolTipText = Nothing
			' 
			' radMenuItem1_7
			' 
			Me.radMenuItem1_7.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_7.Class = "RadMenuItem"
			Me.radMenuItem1_7.DescriptionText = ""
			Me.radMenuItem1_7.ImageKey = "7_Send.gif"
			Me.radMenuItem1_7.IsMainMenuItem = False
			Me.radMenuItem1_7.Text = "Send"
			Me.radMenuItem1_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_7.ToolTipText = Nothing
			' 
			' radMenuItem1_8
			' 
			Me.radMenuItem1_8.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_8.Class = "RadMenuItem"
			Me.radMenuItem1_8.DescriptionText = ""
			Me.radMenuItem1_8.ImageKey = "8_Publish.gif"
			Me.radMenuItem1_8.IsMainMenuItem = False
			Me.radMenuItem1_8.Text = "Publish"
			Me.radMenuItem1_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_8.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_8.ToolTipText = Nothing
			' 
			' radMenuItem1_9
			' 
			Me.radMenuItem1_9.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1_9.Class = "RadMenuItem"
			Me.radMenuItem1_9.DescriptionText = ""
			Me.radMenuItem1_9.ImageKey = "9_Close.gif"
			Me.radMenuItem1_9.IsMainMenuItem = False
			Me.radMenuItem1_9.Text = "Close"
			Me.radMenuItem1_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_9.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1_9.ToolTipText = Nothing
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem7.Class = "RadMenuItem"
			Me.radMenuItem7.DescriptionText = ""
			Me.radMenuItem7.IsMainMenuItem = False
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem7.ToolTipText = Nothing
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem8.Class = "RadMenuItem"
			Me.radMenuItem8.DescriptionText = ""
			Me.radMenuItem8.IsMainMenuItem = False
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem8.ToolTipText = Nothing
			' 
			' radMenuItem2_6
			' 
			Me.radMenuItem2_6.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_6.Class = "RadMenuItem"
			Me.radMenuItem2_6.DescriptionText = ""
			Me.radMenuItem2_6.ImageKey = "6_Mark_As_Final.gif"
			Me.radMenuItem2_6.IsMainMenuItem = False
			Me.radMenuItem2_6.Text = "Mark As Final"
			Me.radMenuItem2_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_6.ToolTipText = Nothing
			' 
			' radMenuItem2_7
			' 
			Me.radMenuItem2_7.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2_7.Class = "RadMenuItem"
			Me.radMenuItem2_7.DescriptionText = ""
			Me.radMenuItem2_7.ImageKey = "7_Run_Compatibility_Checker.gif"
			Me.radMenuItem2_7.IsMainMenuItem = False
			Me.radMenuItem2_7.Text = "Run Compatibility Checker"
			Me.radMenuItem2_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2_7.ToolTipText = Nothing
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem3_1.Class = "RadMenuItem"
			Me.radMenuItem3_1.DescriptionText = ""
			Me.radMenuItem3_1.ImageKey = "1_Print.gif"
			Me.radMenuItem3_1.IsMainMenuItem = False
			Me.radMenuItem3_1.Text = "Print"
			Me.radMenuItem3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem3_1.ToolTipText = Nothing
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem3_2.Class = "RadMenuItem"
			Me.radMenuItem3_2.DescriptionText = ""
			Me.radMenuItem3_2.ImageKey = "2_Quick_Print.gif"
			Me.radMenuItem3_2.IsMainMenuItem = False
			Me.radMenuItem3_2.Text = "Quick Print"
			Me.radMenuItem3_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem3_2.ToolTipText = Nothing
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem3_3.Class = "RadMenuItem"
			Me.radMenuItem3_3.DescriptionText = ""
			Me.radMenuItem3_3.ImageKey = "3_Print_Preview.gif"
			Me.radMenuItem3_3.IsMainMenuItem = False
			Me.radMenuItem3_3.Text = "Print Preview"
			Me.radMenuItem3_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem3_3.ToolTipText = Nothing
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem4_3.Class = "RadMenuItem"
			Me.radMenuItem4_3.DescriptionText = ""
			Me.radMenuItem4_3.ImageKey = "3_Create_Document_Workspace.gif"
			Me.radMenuItem4_3.IsMainMenuItem = False
			Me.radMenuItem4_3.Text = "Create Document Workspace"
			Me.radMenuItem4_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem4_3.ToolTipText = Nothing
			' 
			' radMenuItem5_2
			' 
			Me.radMenuItem5_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5_2.Class = "RadMenuItem"
			Me.radMenuItem5_2.DescriptionText = ""
			Me.radMenuItem5_2.ImageKey = "2_Word_Template.gif"
			Me.radMenuItem5_2.IsMainMenuItem = False
			Me.radMenuItem5_2.Text = "Word Template"
			Me.radMenuItem5_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5_2.ToolTipText = Nothing
			' 
			' radMenuItem5_3
			' 
			Me.radMenuItem5_3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5_3.Class = "RadMenuItem"
			Me.radMenuItem5_3.DescriptionText = ""
			Me.radMenuItem5_3.ImageKey = "3_Word_97_document.gif"
			Me.radMenuItem5_3.IsMainMenuItem = False
			Me.radMenuItem5_3.Text = "Word97 Document"
			Me.radMenuItem5_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5_3.ToolTipText = Nothing
			' 
			' radMenuItem5_4
			' 
			Me.radMenuItem5_4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5_4.Class = "RadMenuItem"
			Me.radMenuItem5_4.DescriptionText = ""
			Me.radMenuItem5_4.ImageKey = "4_ Find_addins.gif"
			Me.radMenuItem5_4.IsMainMenuItem = False
			Me.radMenuItem5_4.Text = "Find addins"
			Me.radMenuItem5_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5_4.ToolTipText = Nothing
			' 
			' radMenuItem5_5
			' 
			Me.radMenuItem5_5.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5_5.Class = "RadMenuItem"
			Me.radMenuItem5_5.DescriptionText = ""
			Me.radMenuItem5_5.ImageKey = "5_Other_Formats.gif"
			Me.radMenuItem5_5.IsMainMenuItem = False
			Me.radMenuItem5_5.Text = "Other Formats"
			Me.radMenuItem5_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5_5.ToolTipText = Nothing
			' 
			' radMenuItem6_1
			' 
			Me.radMenuItem6_1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem6_1.Class = "RadMenuItem"
			Me.radMenuItem6_1.DescriptionText = ""
			Me.radMenuItem6_1.ImageKey = "1_E-mail.gif"
			Me.radMenuItem6_1.IsMainMenuItem = False
			Me.radMenuItem6_1.Text = "E-mail"
			Me.radMenuItem6_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem6_1.ToolTipText = Nothing
			' 
			' radMenuItem6_2
			' 
			Me.radMenuItem6_2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem6_2.Class = "RadMenuItem"
			Me.radMenuItem6_2.DescriptionText = ""
			Me.radMenuItem6_2.ImageKey = "2_Internet_Fax.gif"
			Me.radMenuItem6_2.IsMainMenuItem = False
			Me.radMenuItem6_2.Text = "Internet Fax"
			Me.radMenuItem6_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem6_2.ToolTipText = Nothing
			' 
			' radThemeManager1
			' 
			themeSource3.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource3.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("Telerik.Examples.WinControls.Resources.MenuFirstLook.xml")
			themeSource4.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource4.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("Telerik.Examples.WinControls.Resources.MenuFirstLook_Button.xml")
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource3, themeSource4})
			' 
			' radMenu1
			' 
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = System.Drawing.Color.Transparent
			Me.radMenu1.Dock = System.Windows.Forms.DockStyle.None
			Me.radMenu1.ImageList = Me.imageList1
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem5, Me.radMenuItem6})
			Me.radMenu1.Location = New System.Drawing.Point(18, 48)
			' 
			' 
			' 
			Me.radMenu1.MenuElement.AllowMerge = False
			Me.radMenu1.MenuElement.ContextItem = Nothing
			Me.radMenu1.MenuElement.ToolTipText = Nothing
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.RootElement.BackColor = System.Drawing.Color.Transparent
			Me.radMenu1.RootElement.ToolTipText = Nothing
			Me.radMenu1.Size = New System.Drawing.Size(355, 22)
			Me.radMenu1.TabIndex = 1
			Me.radMenu1.Text = "radMenu1"
			Me.radMenu1.ThemeName = "ControlDefault"
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem5.Class = "RadMenuItem"
			Me.radMenuItem5.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem5.DescriptionText = ""
			Me.radMenuItem5.IsMainMenuItem = True
			Me.radMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1_1, Me.radMenuItem1_2, Me.radMenuSeparatorItem1, Me.radMenuItem1_3, Me.radMenuSeparatorItem2, Me.radMenuItem1_4, Me.radMenuItem1_5, Me.radMenuSeparatorItem3, Me.radMenuItem1_6, Me.radMenuItem1_7, Me.radMenuItem1_8, Me.radMenuItem1_9})
			Me.radMenuItem5.PopupDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radMenuItem5.Text = "File"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem5.ToolTipText = Nothing
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem6.Class = "RadMenuItem"
			Me.radMenuItem6.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem6.DescriptionText = ""
			Me.radMenuItem6.IsMainMenuItem = True
			Me.radMenuItem6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem2_3, Me.radMenuItem2_4, Me.radMenuItem2_5, Me.radMenuItem2_6, Me.radMenuItem2_7})
			Me.radMenuItem6.PopupDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radMenuItem6.Text = "Edit"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem6.ToolTipText = Nothing
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = System.Drawing.Color.White
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.Controls.Add(Me.radMenu1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(971, 727)
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
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
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem

	End Class
End Namespace