Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.CommandBar.TextPad
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem17 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem18 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem19 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem20 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem21 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem22 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem23 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem24 As New Telerik.WinControls.UI.RadListDataItem()
			Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.radCommandBarLineElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radCommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radCommandBarButtonItem1 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem2 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem3 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem4 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem5 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarButtonItem6 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem7 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem8 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarButtonItem9 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem10 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarLineElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radCommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radCommandBarToggleButtonItem1 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem2 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem3 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarSeparatorItem3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarDropDownListItem1 = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.radCommandBarDropDownListItem2 = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.radCommandBarSeparatorItem4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarToggleButtonItem4 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem5 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem6 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem7 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarSeparatorItem5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarToggleButtonItem8 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radCommandBarToggleButtonItem9 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.settingsPanel.AutoScroll = True
			Me.settingsPanel.BackColor = System.Drawing.Color.Transparent
			Me.settingsPanel.Controls.Add(Me.btnSpy)
			Me.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.settingsPanel.Location = New System.Drawing.Point(884, 1)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.TabIndex = 0
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), System.Drawing.Image))
			Me.btnSpy.Location = New System.Drawing.Point(10, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			' 
			' 
			' 
			Me.btnSpy.RootElement.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New System.Drawing.Size(180, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.btnSpy.ThemeName = "ControlDefault"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = My.Resources.WordExample_bg
			Me.pictureBox1.Location = New System.Drawing.Point(-5, -1)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(642, 339)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.AutoSize = True
			Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.None
			Me.radCommandBar1.Location = New System.Drawing.Point(4, 56)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.radCommandBarLineElement1, Me.radCommandBarLineElement2})
			Me.radCommandBar1.Size = New System.Drawing.Size(624, 85)
			Me.radCommandBar1.TabIndex = 1
			Me.radCommandBar1.Text = "radCommandBar1"
			Me.radCommandBar1.ThemeName = "ControlDefault"
			' 
			' radCommandBarLineElement1
			' 
			Me.radCommandBarLineElement1.BorderLeftShadowColor = System.Drawing.Color.Empty
			Me.radCommandBarLineElement1.DisplayName = Nothing
			Me.radCommandBarLineElement1.MinSize = New System.Drawing.Size(25, 25)
			Me.radCommandBarLineElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radCommandBarStripElement1})
			Me.radCommandBarLineElement1.Text = ""
			' 
			' radCommandBarStripElement1
			' 
			Me.radCommandBarStripElement1.DisplayName = "Commands Strip"
			Me.radCommandBarStripElement1.FloatingForm = Nothing
			Me.radCommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radCommandBarButtonItem1, Me.radCommandBarButtonItem2, Me.radCommandBarButtonItem3, Me.radCommandBarButtonItem4, Me.radCommandBarButtonItem5, Me.radCommandBarSeparatorItem1, Me.radCommandBarButtonItem6, Me.radCommandBarButtonItem7, Me.radCommandBarButtonItem8, Me.radCommandBarSeparatorItem2, Me.radCommandBarButtonItem9, Me.radCommandBarButtonItem10})
			Me.radCommandBarStripElement1.Name = "radCommandBarStripElement1"
			Me.radCommandBarStripElement1.Text = ""
			' 
			' radCommandBarButtonItem1
			' 
			Me.radCommandBarButtonItem1.AccessibleDescription = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.AccessibleName = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.DisplayName = "New File Button"
			Me.radCommandBarButtonItem1.Image = (CType(resources.GetObject("radCommandBarButtonItem1.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem1.Name = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.Text = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem1.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem2
			' 
			Me.radCommandBarButtonItem2.AccessibleDescription = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.AccessibleName = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.DisplayName = "Open File Button"
			Me.radCommandBarButtonItem2.Image = (CType(resources.GetObject("radCommandBarButtonItem2.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem2.Name = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.Text = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem2.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem3
			' 
			Me.radCommandBarButtonItem3.AccessibleDescription = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.AccessibleName = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.DisplayName = "Save File Button"
			Me.radCommandBarButtonItem3.Image = (CType(resources.GetObject("radCommandBarButtonItem3.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem3.Name = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.Text = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem3.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem4
			' 
			Me.radCommandBarButtonItem4.AccessibleDescription = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.AccessibleName = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.DisplayName = "Undo Button"
			Me.radCommandBarButtonItem4.Image = (CType(resources.GetObject("radCommandBarButtonItem4.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem4.Name = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.Text = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem4.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem5
			' 
			Me.radCommandBarButtonItem5.AccessibleDescription = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.AccessibleName = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.DisplayName = "Redo Button"
			Me.radCommandBarButtonItem5.Image = (CType(resources.GetObject("radCommandBarButtonItem5.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem5.Name = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.Text = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem5.VisibleInOverflowMenu = True
			' 
			' radCommandBarSeparatorItem1
			' 
			Me.radCommandBarSeparatorItem1.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem1.Name = "radCommandBarSeparatorItem1"
			Me.radCommandBarSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem1.VisibleInOverflowMenu = False
			' 
			' radCommandBarButtonItem6
			' 
			Me.radCommandBarButtonItem6.AccessibleDescription = "radCommandBarButtonItem6"
			Me.radCommandBarButtonItem6.AccessibleName = "radCommandBarButtonItem6"
			Me.radCommandBarButtonItem6.DisplayName = "Cut Button"
			Me.radCommandBarButtonItem6.Image = (CType(resources.GetObject("radCommandBarButtonItem6.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem6.Name = "radCommandBarButtonItem6"
			Me.radCommandBarButtonItem6.Text = "radCommandBarButtonItem6"
			Me.radCommandBarButtonItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem6.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem7
			' 
			Me.radCommandBarButtonItem7.AccessibleDescription = "radCommandBarButtonItem7"
			Me.radCommandBarButtonItem7.AccessibleName = "radCommandBarButtonItem7"
			Me.radCommandBarButtonItem7.DisplayName = "Copy Button"
			Me.radCommandBarButtonItem7.Image = (CType(resources.GetObject("radCommandBarButtonItem7.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem7.Name = "radCommandBarButtonItem7"
			Me.radCommandBarButtonItem7.Text = "radCommandBarButtonItem7"
			Me.radCommandBarButtonItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem7.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem8
			' 
			Me.radCommandBarButtonItem8.AccessibleDescription = "radCommandBarButtonItem8"
			Me.radCommandBarButtonItem8.AccessibleName = "radCommandBarButtonItem8"
			Me.radCommandBarButtonItem8.DisplayName = "Paste Button"
			Me.radCommandBarButtonItem8.Image = (CType(resources.GetObject("radCommandBarButtonItem8.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem8.Name = "radCommandBarButtonItem8"
			Me.radCommandBarButtonItem8.Text = "radCommandBarButtonItem8"
			Me.radCommandBarButtonItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem8.VisibleInOverflowMenu = True
			' 
			' radCommandBarSeparatorItem2
			' 
			Me.radCommandBarSeparatorItem2.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem2.Name = "radCommandBarSeparatorItem2"
			Me.radCommandBarSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem2.VisibleInOverflowMenu = False
			' 
			' radCommandBarButtonItem9
			' 
			Me.radCommandBarButtonItem9.AccessibleDescription = "radCommandBarButtonItem9"
			Me.radCommandBarButtonItem9.AccessibleName = "radCommandBarButtonItem9"
			Me.radCommandBarButtonItem9.DisplayName = "Print Button"
			Me.radCommandBarButtonItem9.Image = (CType(resources.GetObject("radCommandBarButtonItem9.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem9.Name = "radCommandBarButtonItem9"
			Me.radCommandBarButtonItem9.Text = "radCommandBarButtonItem9"
			Me.radCommandBarButtonItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem9.VisibleInOverflowMenu = True
			' 
			' radCommandBarButtonItem10
			' 
			Me.radCommandBarButtonItem10.AccessibleDescription = "radCommandBarButtonItem10"
			Me.radCommandBarButtonItem10.AccessibleName = "radCommandBarButtonItem10"
			Me.radCommandBarButtonItem10.DisplayName = "Print Preview Button"
			Me.radCommandBarButtonItem10.Image = (CType(resources.GetObject("radCommandBarButtonItem10.Image"), System.Drawing.Image))
			Me.radCommandBarButtonItem10.Name = "radCommandBarButtonItem10"
			Me.radCommandBarButtonItem10.Text = "radCommandBarButtonItem10"
			Me.radCommandBarButtonItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem10.VisibleInOverflowMenu = True
			' 
			' radCommandBarLineElement2
			' 
			Me.radCommandBarLineElement2.DisplayName = Nothing
			Me.radCommandBarLineElement2.MinSize = New System.Drawing.Size(25, 25)
			Me.radCommandBarLineElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radCommandBarStripElement2})
			' 
			' radCommandBarStripElement2
			' 
			Me.radCommandBarStripElement2.DisplayName = "Text Style Strip"
			Me.radCommandBarStripElement2.FloatingForm = Nothing
			Me.radCommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radCommandBarToggleButtonItem1, Me.radCommandBarToggleButtonItem2, Me.radCommandBarToggleButtonItem3, Me.radCommandBarSeparatorItem3, Me.radCommandBarDropDownListItem1, Me.radCommandBarDropDownListItem2, Me.radCommandBarSeparatorItem4, Me.radCommandBarToggleButtonItem4, Me.radCommandBarToggleButtonItem5, Me.radCommandBarToggleButtonItem6, Me.radCommandBarToggleButtonItem7, Me.radCommandBarSeparatorItem5, Me.radCommandBarToggleButtonItem8, Me.radCommandBarToggleButtonItem9})
			Me.radCommandBarStripElement2.Name = "radCommandBarStripElement2"
			Me.radCommandBarStripElement2.Text = ""
			' 
			' radCommandBarToggleButtonItem1
			' 
			Me.radCommandBarToggleButtonItem1.AccessibleDescription = "radCommandBarToggleButtonItem1"
			Me.radCommandBarToggleButtonItem1.AccessibleName = "radCommandBarToggleButtonItem1"
			Me.radCommandBarToggleButtonItem1.DisplayName = "Bold Toggle Button"
			Me.radCommandBarToggleButtonItem1.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem1.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem1.Name = "radCommandBarToggleButtonItem1"
			Me.radCommandBarToggleButtonItem1.Text = "radCommandBarToggleButtonItem1"
			Me.radCommandBarToggleButtonItem1.UseVerticalText = False
			Me.radCommandBarToggleButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem1.VisibleInOverflowMenu = True
			' 
			' radCommandBarToggleButtonItem2
			' 
			Me.radCommandBarToggleButtonItem2.AccessibleDescription = "radCommandBarToggleButtonItem2"
			Me.radCommandBarToggleButtonItem2.AccessibleName = "radCommandBarToggleButtonItem2"
			Me.radCommandBarToggleButtonItem2.DisplayName = "Italic Toggle Button"
			Me.radCommandBarToggleButtonItem2.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem2.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem2.Name = "radCommandBarToggleButtonItem2"
			Me.radCommandBarToggleButtonItem2.Text = "radCommandBarToggleButtonItem2"
			Me.radCommandBarToggleButtonItem2.UseVerticalText = False
			Me.radCommandBarToggleButtonItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem2.VisibleInOverflowMenu = True
			' 
			' radCommandBarToggleButtonItem3
			' 
			Me.radCommandBarToggleButtonItem3.AccessibleDescription = "radCommandBarToggleButtonItem3"
			Me.radCommandBarToggleButtonItem3.AccessibleName = "radCommandBarToggleButtonItem3"
			Me.radCommandBarToggleButtonItem3.DisplayName = "Underline Toggle Button"
			Me.radCommandBarToggleButtonItem3.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem3.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem3.Name = "radCommandBarToggleButtonItem3"
			Me.radCommandBarToggleButtonItem3.Text = "radCommandBarToggleButtonItem3"
			Me.radCommandBarToggleButtonItem3.UseVerticalText = False
			Me.radCommandBarToggleButtonItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem3.VisibleInOverflowMenu = True
			' 
			' radCommandBarSeparatorItem3
			' 
			Me.radCommandBarSeparatorItem3.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem3.Name = "radCommandBarSeparatorItem3"
			Me.radCommandBarSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem3.VisibleInOverflowMenu = False
			' 
			' radCommandBarDropDownListItem1
			' 
			Me.radCommandBarDropDownListItem1.DisplayName = "Font Family Dropdown"
			radListDataItem13.Text = "Arial"
			radListDataItem13.TextWrap = True
			radListDataItem14.Text = "Tahoma"
			radListDataItem14.TextWrap = True
			radListDataItem15.Text = "Verdana"
			radListDataItem15.TextWrap = True
			radListDataItem16.Text = "Times New Roman"
			radListDataItem16.TextWrap = True
			radListDataItem17.Text = "Segoe UI"
			radListDataItem17.TextWrap = True
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem13)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem14)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem15)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem16)
			Me.radCommandBarDropDownListItem1.Items.Add(radListDataItem17)
			Me.radCommandBarDropDownListItem1.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radCommandBarDropDownListItem1.Name = "radCommandBarDropDownListItem1"
			Me.radCommandBarDropDownListItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarDropDownListItem1.VisibleInOverflowMenu = True
			' 
			' radCommandBarDropDownListItem2
			' 
			Me.radCommandBarDropDownListItem2.DisplayName = "Font Size Dropdown"
			radListDataItem18.Text = "8"
			radListDataItem18.TextWrap = True
			radListDataItem19.Text = "10"
			radListDataItem19.TextWrap = True
			radListDataItem20.Text = "12"
			radListDataItem20.TextWrap = True
			radListDataItem21.Text = "16"
			radListDataItem21.TextWrap = True
			radListDataItem22.Text = "18"
			radListDataItem22.TextWrap = True
			radListDataItem23.Text = "22"
			radListDataItem23.TextWrap = True
			radListDataItem24.Text = "24"
			radListDataItem24.TextWrap = True
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem18)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem19)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem20)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem21)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem22)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem23)
			Me.radCommandBarDropDownListItem2.Items.Add(radListDataItem24)
			Me.radCommandBarDropDownListItem2.MaxSize = New System.Drawing.Size(46, 0)
			Me.radCommandBarDropDownListItem2.MinSize = New System.Drawing.Size(46, 0)
			Me.radCommandBarDropDownListItem2.Name = "radCommandBarDropDownListItem2"
			Me.radCommandBarDropDownListItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarDropDownListItem2.VisibleInOverflowMenu = True
			' 
			' radCommandBarSeparatorItem4
			' 
			Me.radCommandBarSeparatorItem4.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem4.Name = "radCommandBarSeparatorItem4"
			Me.radCommandBarSeparatorItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem4.VisibleInOverflowMenu = False
			' 
			' radCommandBarToggleButtonItem4
			' 
			Me.radCommandBarToggleButtonItem4.AccessibleDescription = "radCommandBarToggleButtonItem4"
			Me.radCommandBarToggleButtonItem4.AccessibleName = "radCommandBarToggleButtonItem4"
			Me.radCommandBarToggleButtonItem4.DisplayName = "Left Align Button"
			Me.radCommandBarToggleButtonItem4.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem4.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem4.Name = "radCommandBarToggleButtonItem4"
			Me.radCommandBarToggleButtonItem4.Text = "radCommandBarToggleButtonItem4"
			Me.radCommandBarToggleButtonItem4.UseVerticalText = False
			Me.radCommandBarToggleButtonItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem4.VisibleInOverflowMenu = True
'			Me.radCommandBarToggleButtonItem4.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.alignment_ToggleStateChanging);
			' 
			' radCommandBarToggleButtonItem5
			' 
			Me.radCommandBarToggleButtonItem5.AccessibleDescription = "radCommandBarToggleButtonItem5"
			Me.radCommandBarToggleButtonItem5.AccessibleName = "radCommandBarToggleButtonItem5"
			Me.radCommandBarToggleButtonItem5.DisplayName = "Center Align Button"
			Me.radCommandBarToggleButtonItem5.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem5.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem5.Name = "radCommandBarToggleButtonItem5"
			Me.radCommandBarToggleButtonItem5.Text = "radCommandBarToggleButtonItem5"
			Me.radCommandBarToggleButtonItem5.UseVerticalText = False
			Me.radCommandBarToggleButtonItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem5.VisibleInOverflowMenu = True
'			Me.radCommandBarToggleButtonItem5.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.alignment_ToggleStateChanging);
			' 
			' radCommandBarToggleButtonItem6
			' 
			Me.radCommandBarToggleButtonItem6.AccessibleDescription = "radCommandBarToggleButtonItem6"
			Me.radCommandBarToggleButtonItem6.AccessibleName = "radCommandBarToggleButtonItem6"
			Me.radCommandBarToggleButtonItem6.DisplayName = "Right Align Button"
			Me.radCommandBarToggleButtonItem6.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem6.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem6.Name = "radCommandBarToggleButtonItem6"
			Me.radCommandBarToggleButtonItem6.Text = "radCommandBarToggleButtonItem6"
			Me.radCommandBarToggleButtonItem6.UseVerticalText = False
			Me.radCommandBarToggleButtonItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem6.VisibleInOverflowMenu = True
'			Me.radCommandBarToggleButtonItem6.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.alignment_ToggleStateChanging);
			' 
			' radCommandBarToggleButtonItem7
			' 
			Me.radCommandBarToggleButtonItem7.AccessibleDescription = "radCommandBarToggleButtonItem7"
			Me.radCommandBarToggleButtonItem7.AccessibleName = "radCommandBarToggleButtonItem7"
			Me.radCommandBarToggleButtonItem7.DisplayName = "Justify Text Button"
			Me.radCommandBarToggleButtonItem7.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem7.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem7.Name = "radCommandBarToggleButtonItem7"
			Me.radCommandBarToggleButtonItem7.Text = "radCommandBarToggleButtonItem7"
			Me.radCommandBarToggleButtonItem7.UseVerticalText = False
			Me.radCommandBarToggleButtonItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem7.VisibleInOverflowMenu = True
'			Me.radCommandBarToggleButtonItem7.ToggleStateChanging += New Telerik.WinControls.UI.StateChangingEventHandler(Me.alignment_ToggleStateChanging);
			' 
			' radCommandBarSeparatorItem5
			' 
			Me.radCommandBarSeparatorItem5.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem5.Name = "radCommandBarSeparatorItem5"
			Me.radCommandBarSeparatorItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem5.VisibleInOverflowMenu = False
			' 
			' radCommandBarToggleButtonItem8
			' 
			Me.radCommandBarToggleButtonItem8.AccessibleDescription = "radCommandBarToggleButtonItem8"
			Me.radCommandBarToggleButtonItem8.AccessibleName = "radCommandBarToggleButtonItem8"
			Me.radCommandBarToggleButtonItem8.DisplayName = "Bulleted List Button"
			Me.radCommandBarToggleButtonItem8.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem8.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem8.Name = "radCommandBarToggleButtonItem8"
			Me.radCommandBarToggleButtonItem8.Text = "radCommandBarToggleButtonItem8"
			Me.radCommandBarToggleButtonItem8.UseVerticalText = False
			Me.radCommandBarToggleButtonItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem8.VisibleInOverflowMenu = True
			' 
			' radCommandBarToggleButtonItem9
			' 
			Me.radCommandBarToggleButtonItem9.AccessibleDescription = "radCommandBarToggleButtonItem9"
			Me.radCommandBarToggleButtonItem9.AccessibleName = "radCommandBarToggleButtonItem9"
			Me.radCommandBarToggleButtonItem9.DisplayName = "Ordered List Button"
			Me.radCommandBarToggleButtonItem9.Image = (CType(resources.GetObject("radCommandBarToggleButtonItem9.Image"), System.Drawing.Image))
			Me.radCommandBarToggleButtonItem9.Name = "radCommandBarToggleButtonItem9"
			Me.radCommandBarToggleButtonItem9.Text = "radCommandBarToggleButtonItem9"
			Me.radCommandBarToggleButtonItem9.UseVerticalText = False
			Me.radCommandBarToggleButtonItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarToggleButtonItem9.VisibleInOverflowMenu = True
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.radCommandBar1)
			Me.panel1.Controls.Add(Me.pictureBox1)
			Me.panel1.Location = New System.Drawing.Point(12, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(634, 336)
			Me.panel1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1069, 711)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private radCommandBarLineElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private radCommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private radCommandBarButtonItem1 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem2 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem3 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem4 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem5 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarButtonItem6 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem7 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem8 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem2 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarButtonItem9 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem10 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarLineElement2 As Telerik.WinControls.UI.CommandBarRowElement
		Private radCommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
		Private radCommandBarToggleButtonItem1 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem2 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem3 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarSeparatorItem3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarDropDownListItem1 As Telerik.WinControls.UI.CommandBarDropDownList
		Private radCommandBarDropDownListItem2 As Telerik.WinControls.UI.CommandBarDropDownList
		Private radCommandBarSeparatorItem4 As Telerik.WinControls.UI.CommandBarSeparator
		Private WithEvents radCommandBarToggleButtonItem4 As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents radCommandBarToggleButtonItem5 As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents radCommandBarToggleButtonItem6 As Telerik.WinControls.UI.CommandBarToggleButton
		Private WithEvents radCommandBarToggleButtonItem7 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarSeparatorItem5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarToggleButtonItem8 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radCommandBarToggleButtonItem9 As Telerik.WinControls.UI.CommandBarToggleButton
		Private Shadows settingsPanel As Telerik.WinControls.UI.RadPanel
		Private btnSpy As Telerik.WinControls.UI.RadButton
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace