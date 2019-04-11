Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadDesktopAlert.FirstLook
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
			Me.components = New System.ComponentModel.Container()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem17 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem18 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem19 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem20 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem22 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem11 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem12 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.spinOpacity = New Telerik.WinControls.UI.RadSpinEditor()
			Me.optionsButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.pinButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.closeButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.spinEditorHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.spinEditorWidth = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.ddScreenPosition = New Telerik.WinControls.UI.RadDropDownList()
			Me.ddThemeName = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
			Me.ddAnimationDirection = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.checkPopupAnimation = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.fadeOutCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.fadeInCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.spinPopupAnimationFrames = New Telerik.WinControls.UI.RadSpinEditor()
			Me.autoCloseDelaySpin = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.autoCloseCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.spinFadeDuration = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.txtContent = New Telerik.WinControls.UI.RadTextBox()
			Me.txtCaption = New Telerik.WinControls.UI.RadTextBox()
			Me.btnPreview = New Telerik.WinControls.UI.RadButton()
			Me.radDesktopAlert1 = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.spinOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optionsButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pinButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.closeButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ddScreenPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ddThemeName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ddAnimationDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkPopupAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fadeOutCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fadeInCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinPopupAnimationFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.autoCloseDelaySpin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.autoCloseCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinFadeDuration, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtContent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.btnPreview)
			Me.radPanelDemoHolder.Controls.Add(Me.radGroupBox3)
			Me.radPanelDemoHolder.Controls.Add(Me.radGroupBox2)
			Me.radPanelDemoHolder.Controls.Add(Me.radGroupBox1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(133, 178)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(652, 375)
			Me.radPanelDemoHolder.ThemeName = "ControlDefault"
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(717, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 730)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.spinOpacity)
			Me.radGroupBox1.Controls.Add(Me.optionsButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.pinButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.closeButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.radLabel5)
			Me.radGroupBox1.Controls.Add(Me.radLabel12)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.spinEditorHeight)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.spinEditorWidth)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.ddScreenPosition)
			Me.radGroupBox1.Controls.Add(Me.ddThemeName)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Appearance"
			Me.radGroupBox1.Location = New System.Drawing.Point(26, 18)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(197, 314)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Appearance"
			' 
			' spinOpacity
			' 
			Me.spinOpacity.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.spinOpacity.DecimalPlaces = 1
			Me.spinOpacity.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.spinOpacity.Location = New System.Drawing.Point(91, 277)
			Me.spinOpacity.Maximum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinOpacity.Name = "spinOpacity"
			' 
			' 
			' 
			Me.spinOpacity.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinOpacity.ShowBorder = True
			Me.spinOpacity.Size = New System.Drawing.Size(93, 20)
			Me.spinOpacity.TabIndex = 1
			Me.spinOpacity.TabStop = False
			Me.spinOpacity.Value = New Decimal(New Integer() { 8, 0, 0, 65536})
'			Me.spinOpacity.ValueChanged += New System.EventHandler(Me.SpinOpacity_ValueChanged);
			' 
			' optionsButtonCheck
			' 
			Me.optionsButtonCheck.Location = New System.Drawing.Point(17, 253)
			Me.optionsButtonCheck.Name = "optionsButtonCheck"
			Me.optionsButtonCheck.Size = New System.Drawing.Size(97, 18)
			Me.optionsButtonCheck.TabIndex = 4
			Me.optionsButtonCheck.Text = "Options button"
			Me.optionsButtonCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.optionsButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.optionsButtonCheck_ToggleStateChanged);
			' 
			' pinButtonCheck
			' 
			Me.pinButtonCheck.Location = New System.Drawing.Point(107, 229)
			Me.pinButtonCheck.Name = "pinButtonCheck"
			Me.pinButtonCheck.Size = New System.Drawing.Size(73, 18)
			Me.pinButtonCheck.TabIndex = 4
			Me.pinButtonCheck.Text = "Pin button"
			Me.pinButtonCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.pinButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.pinButtonCheck_ToggleStateChanged);
			' 
			' closeButtonCheck
			' 
			Me.closeButtonCheck.Location = New System.Drawing.Point(17, 229)
			Me.closeButtonCheck.Name = "closeButtonCheck"
			Me.closeButtonCheck.Size = New System.Drawing.Size(84, 18)
			Me.closeButtonCheck.TabIndex = 4
			Me.closeButtonCheck.Text = "Close button"
			Me.closeButtonCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.closeButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.closeButtonCheck_ToggleStateChanged);
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New System.Drawing.Point(32, 192)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(42, 18)
			Me.radLabel5.TabIndex = 3
			Me.radLabel5.Text = "Height:"
			' 
			' radLabel12
			' 
			Me.radLabel12.Location = New System.Drawing.Point(13, 277)
			Me.radLabel12.Name = "radLabel12"
			Me.radLabel12.Size = New System.Drawing.Size(72, 18)
			Me.radLabel12.TabIndex = 3
			Me.radLabel12.Text = "Alert opacity:"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(32, 168)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(39, 18)
			Me.radLabel4.TabIndex = 3
			Me.radLabel4.Text = "Width:"
			' 
			' spinEditorHeight
			' 
			Me.spinEditorHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.spinEditorHeight.Location = New System.Drawing.Point(77, 192)
			Me.spinEditorHeight.Maximum = New Decimal(New Integer() { 300, 0, 0, 0})
			Me.spinEditorHeight.Minimum = New Decimal(New Integer() { 70, 0, 0, 0})
			Me.spinEditorHeight.Name = "spinEditorHeight"
			' 
			' 
			' 
			Me.spinEditorHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinEditorHeight.ShowBorder = True
			Me.spinEditorHeight.Size = New System.Drawing.Size(107, 20)
			Me.spinEditorHeight.TabIndex = 1
			Me.spinEditorHeight.TabStop = False
			Me.spinEditorHeight.Value = New Decimal(New Integer() { 100, 0, 0, 0})
'			Me.spinEditorHeight.ValueChanged += New System.EventHandler(Me.SpinEditorHeight_ValueChanged);
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(13, 144)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(54, 18)
			Me.radLabel3.TabIndex = 3
			Me.radLabel3.Text = "Alert size:"
			' 
			' spinEditorWidth
			' 
			Me.spinEditorWidth.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.spinEditorWidth.Location = New System.Drawing.Point(77, 168)
			Me.spinEditorWidth.Maximum = New Decimal(New Integer() { 500, 0, 0, 0})
			Me.spinEditorWidth.Minimum = New Decimal(New Integer() { 150, 0, 0, 0})
			Me.spinEditorWidth.Name = "spinEditorWidth"
			' 
			' 
			' 
			Me.spinEditorWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinEditorWidth.ShowBorder = True
			Me.spinEditorWidth.Size = New System.Drawing.Size(107, 20)
			Me.spinEditorWidth.TabIndex = 1
			Me.spinEditorWidth.TabStop = False
			Me.spinEditorWidth.Value = New Decimal(New Integer() { 329, 0, 0, 0})
'			Me.spinEditorWidth.ValueChanged += New System.EventHandler(Me.SpinEditorWidth_ValueChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(14, 89)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(90, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Choose position:"
			' 
			' ddScreenPosition
			' 
			Me.ddScreenPosition.AutoSize = True
			Me.ddScreenPosition.DropDownAnimationEnabled = False
			Me.ddScreenPosition.DropDownHeight = 0
			radListDataItem15.Active = False
			radListDataItem15.Selected = False
			radListDataItem15.Text = "TopLeft"
			radListDataItem16.Active = False
			radListDataItem16.Selected = False
			radListDataItem16.Text = "TopCenter"
			radListDataItem17.Active = False
			radListDataItem17.Selected = False
			radListDataItem17.Text = "TopRight"
			radListDataItem18.Active = False
			radListDataItem18.Selected = False
			radListDataItem18.Text = "BottomLeft"
			radListDataItem19.Active = False
			radListDataItem19.Selected = False
			radListDataItem19.Text = "BottomCenter"
			radListDataItem20.Active = True
			radListDataItem20.Selected = True
			radListDataItem20.Text = "BottomRight"
			Me.ddScreenPosition.Items.Add(radListDataItem15)
			Me.ddScreenPosition.Items.Add(radListDataItem16)
			Me.ddScreenPosition.Items.Add(radListDataItem17)
			Me.ddScreenPosition.Items.Add(radListDataItem18)
			Me.ddScreenPosition.Items.Add(radListDataItem19)
			Me.ddScreenPosition.Items.Add(radListDataItem20)
			Me.ddScreenPosition.Location = New System.Drawing.Point(14, 113)
			Me.ddScreenPosition.Name = "ddScreenPosition"
			Me.ddScreenPosition.Size = New System.Drawing.Size(170, 18)
			Me.ddScreenPosition.TabIndex = 2
			Me.ddScreenPosition.TabStop = False
			Me.ddScreenPosition.Text = "BottomRight"
'			Me.ddScreenPosition.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.OnPositionList_IndexChaned);
			' 
			' ddThemeName
			' 
			Me.ddThemeName.AutoSize = True
			Me.ddThemeName.DropDownAnimationEnabled = False
			Me.ddThemeName.DropDownHeight = 0
			radListDataItem1.Active = False
			radListDataItem1.Selected = False
			radListDataItem1.Text = "Office2010Black"
			radListDataItem2.Active = False
			radListDataItem2.Selected = False
			radListDataItem2.Text = "Office2010Silver"
			radListDataItem3.Active = False
			radListDataItem3.Selected = False
			radListDataItem3.Text = "Office2010Blue"
			radListDataItem4.Active = False
			radListDataItem4.Selected = False
			radListDataItem4.Text = "Desert"
			radListDataItem22.Active = True
			radListDataItem22.Selected = True
			radListDataItem22.Text = "ControlDefault"
			Me.ddThemeName.Items.Add(radListDataItem1)
			Me.ddThemeName.Items.Add(radListDataItem2)
			Me.ddThemeName.Items.Add(radListDataItem3)
			Me.ddThemeName.Items.Add(radListDataItem4)
			Me.ddThemeName.Items.Add(radListDataItem22)
			Me.ddThemeName.Location = New System.Drawing.Point(14, 61)
			Me.ddThemeName.Name = "ddThemeName"
			Me.ddThemeName.Size = New System.Drawing.Size(170, 18)
			Me.ddThemeName.TabIndex = 2
			Me.ddThemeName.TabStop = False
			Me.ddThemeName.Text = "ControlDefault"
'			Me.ddThemeName.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.OnThemesList_IndexChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(14, 36)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(81, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Choose theme:"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radLabel11)
			Me.radGroupBox2.Controls.Add(Me.ddAnimationDirection)
			Me.radGroupBox2.Controls.Add(Me.radLabel8)
			Me.radGroupBox2.Controls.Add(Me.checkPopupAnimation)
			Me.radGroupBox2.Controls.Add(Me.radLabel7)
			Me.radGroupBox2.Controls.Add(Me.fadeOutCheck)
			Me.radGroupBox2.Controls.Add(Me.fadeInCheck)
			Me.radGroupBox2.Controls.Add(Me.spinPopupAnimationFrames)
			Me.radGroupBox2.Controls.Add(Me.autoCloseDelaySpin)
			Me.radGroupBox2.Controls.Add(Me.radLabel6)
			Me.radGroupBox2.Controls.Add(Me.autoCloseCheck)
			Me.radGroupBox2.Controls.Add(Me.spinFadeDuration)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Behavior"
			Me.radGroupBox2.Location = New System.Drawing.Point(229, 18)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(193, 314)
			Me.radGroupBox2.TabIndex = 0
			Me.radGroupBox2.Text = "Behavior"
			' 
			' radLabel11
			' 
			Me.radLabel11.Location = New System.Drawing.Point(13, 254)
			Me.radLabel11.Name = "radLabel11"
			Me.radLabel11.Size = New System.Drawing.Size(97, 18)
			Me.radLabel11.TabIndex = 8
			Me.radLabel11.Text = "Animation frames:"
			' 
			' ddAnimationDirection
			' 
			Me.ddAnimationDirection.AutoSize = True
			Me.ddAnimationDirection.DropDownAnimationEnabled = False
			Me.ddAnimationDirection.DropDownHeight = 0
			radListDataItem11.Active = False
			radListDataItem11.Selected = False
			radListDataItem11.Text = "Right"
			radListDataItem12.Active = False
			radListDataItem12.Selected = False
			radListDataItem12.Text = "Up"
			radListDataItem13.Active = False
			radListDataItem13.Selected = False
			radListDataItem13.Text = "Left"
			radListDataItem14.Active = True
			radListDataItem14.Selected = True
			radListDataItem14.Text = "Down"
			Me.ddAnimationDirection.Items.Add(radListDataItem11)
			Me.ddAnimationDirection.Items.Add(radListDataItem12)
			Me.ddAnimationDirection.Items.Add(radListDataItem13)
			Me.ddAnimationDirection.Items.Add(radListDataItem14)
			Me.ddAnimationDirection.Location = New System.Drawing.Point(13, 228)
			Me.ddAnimationDirection.Name = "ddAnimationDirection"
			Me.ddAnimationDirection.Size = New System.Drawing.Size(167, 18)
			Me.ddAnimationDirection.TabIndex = 7
			Me.ddAnimationDirection.TabStop = False
			Me.ddAnimationDirection.Text = "Down"
'			Me.ddAnimationDirection.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.ddAnimationDirection_SelectedIndexChanged);
			' 
			' radLabel8
			' 
			Me.radLabel8.Location = New System.Drawing.Point(13, 204)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New System.Drawing.Size(142, 18)
			Me.radLabel8.TabIndex = 6
			Me.radLabel8.Text = "Popup animation direction:"
			' 
			' checkPopupAnimation
			' 
			Me.checkPopupAnimation.Location = New System.Drawing.Point(43, 180)
			Me.checkPopupAnimation.Name = "checkPopupAnimation"
			Me.checkPopupAnimation.Size = New System.Drawing.Size(106, 18)
			Me.checkPopupAnimation.TabIndex = 5
			Me.checkPopupAnimation.Text = "Popup animation"
'			Me.checkPopupAnimation.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.checkPopupAnimation_ToggleStateChanged);
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New System.Drawing.Point(13, 120)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(127, 18)
			Me.radLabel7.TabIndex = 4
			Me.radLabel7.Text = "Fade duration in frames:"
			' 
			' fadeOutCheck
			' 
			Me.fadeOutCheck.Location = New System.Drawing.Point(96, 93)
			Me.fadeOutCheck.Name = "fadeOutCheck"
			Me.fadeOutCheck.Size = New System.Drawing.Size(65, 18)
			Me.fadeOutCheck.TabIndex = 3
			Me.fadeOutCheck.Text = "Fade-out"
			Me.fadeOutCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.fadeOutCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.fadeOutCheck_ToggleStateChanged);
			' 
			' fadeInCheck
			' 
			Me.fadeInCheck.Location = New System.Drawing.Point(32, 93)
			Me.fadeInCheck.Name = "fadeInCheck"
			Me.fadeInCheck.Size = New System.Drawing.Size(58, 18)
			Me.fadeInCheck.TabIndex = 3
			Me.fadeInCheck.Text = "Fade-in"
			Me.fadeInCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.fadeInCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.fadeInCheck_ToggleStateChanged);
			' 
			' spinPopupAnimationFrames
			' 
			Me.spinPopupAnimationFrames.Location = New System.Drawing.Point(14, 277)
			Me.spinPopupAnimationFrames.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.spinPopupAnimationFrames.Name = "spinPopupAnimationFrames"
			' 
			' 
			' 
			Me.spinPopupAnimationFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinPopupAnimationFrames.ShowBorder = True
			Me.spinPopupAnimationFrames.Size = New System.Drawing.Size(166, 20)
			Me.spinPopupAnimationFrames.TabIndex = 2
			Me.spinPopupAnimationFrames.TabStop = False
			Me.spinPopupAnimationFrames.Value = New Decimal(New Integer() { 50, 0, 0, 0})
'			Me.spinPopupAnimationFrames.ValueChanged += New System.EventHandler(Me.spinPopupAnimationFrames_ValueChanged);
			' 
			' autoCloseDelaySpin
			' 
			Me.autoCloseDelaySpin.Location = New System.Drawing.Point(70, 57)
			Me.autoCloseDelaySpin.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.autoCloseDelaySpin.Name = "autoCloseDelaySpin"
			' 
			' 
			' 
			Me.autoCloseDelaySpin.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.autoCloseDelaySpin.ShowBorder = True
			Me.autoCloseDelaySpin.Size = New System.Drawing.Size(110, 20)
			Me.autoCloseDelaySpin.TabIndex = 2
			Me.autoCloseDelaySpin.TabStop = False
			Me.autoCloseDelaySpin.Value = New Decimal(New Integer() { 10, 0, 0, 0})
'			Me.autoCloseDelaySpin.ValueChanged += New System.EventHandler(Me.autoCloseDelaySpin_ValueChanged);
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New System.Drawing.Point(13, 55)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(51, 18)
			Me.radLabel6.TabIndex = 1
			Me.radLabel6.Text = "Delay (s):"
			' 
			' autoCloseCheck
			' 
			Me.autoCloseCheck.Location = New System.Drawing.Point(60, 31)
			Me.autoCloseCheck.Name = "autoCloseCheck"
			Me.autoCloseCheck.Size = New System.Drawing.Size(73, 18)
			Me.autoCloseCheck.TabIndex = 0
			Me.autoCloseCheck.Text = "Auto close"
			Me.autoCloseCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.autoCloseCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.autoCloseCheck_ToggleStateChanged);
			' 
			' spinFadeDuration
			' 
			Me.spinFadeDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.spinFadeDuration.Location = New System.Drawing.Point(14, 144)
			Me.spinFadeDuration.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinFadeDuration.Name = "spinFadeDuration"
			' 
			' 
			' 
			Me.spinFadeDuration.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinFadeDuration.ShowBorder = True
			Me.spinFadeDuration.Size = New System.Drawing.Size(166, 20)
			Me.spinFadeDuration.TabIndex = 1
			Me.spinFadeDuration.TabStop = False
			Me.spinFadeDuration.Value = New Decimal(New Integer() { 80, 0, 0, 0})
'			Me.spinFadeDuration.ValueChanged += New System.EventHandler(Me.spinFadeDuration_ValueChanged);
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Controls.Add(Me.radLabel10)
			Me.radGroupBox3.Controls.Add(Me.radLabel9)
			Me.radGroupBox3.Controls.Add(Me.txtContent)
			Me.radGroupBox3.Controls.Add(Me.txtCaption)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox3.HeaderText = "Alert Content"
			Me.radGroupBox3.Location = New System.Drawing.Point(428, 18)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New System.Drawing.Size(199, 314)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Alert Content"
			' 
			' radLabel10
			' 
			Me.radLabel10.Location = New System.Drawing.Point(13, 158)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New System.Drawing.Size(74, 18)
			Me.radLabel10.TabIndex = 1
			Me.radLabel10.Text = "Alert content:"
			' 
			' radLabel9
			' 
			Me.radLabel9.Location = New System.Drawing.Point(13, 36)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New System.Drawing.Size(73, 18)
			Me.radLabel9.TabIndex = 1
			Me.radLabel9.Text = "Alert caption:"
			' 
			' txtContent
			' 
			Me.txtContent.Location = New System.Drawing.Point(13, 182)
			Me.txtContent.Multiline = True
			Me.txtContent.Name = "txtContent"
			' 
			' 
			' 
			Me.txtContent.RootElement.StretchVertically = True
			Me.txtContent.Size = New System.Drawing.Size(173, 119)
			Me.txtContent.TabIndex = 0
			Me.txtContent.TabStop = False
			Me.txtContent.Text = "<html><i>This will be the alert's content text</i>.<b><span><color=Blue>You can p" & "lace HTML formatted text here as well.</span></b></html>"
			' 
			' txtCaption
			' 
			Me.txtCaption.Location = New System.Drawing.Point(13, 59)
			Me.txtCaption.Multiline = True
			Me.txtCaption.Name = "txtCaption"
			' 
			' 
			' 
			Me.txtCaption.RootElement.StretchVertically = True
			Me.txtCaption.Size = New System.Drawing.Size(173, 84)
			Me.txtCaption.TabIndex = 0
			Me.txtCaption.TabStop = False
			Me.txtCaption.Text = "This will be the alert's caption text"
			' 
			' btnPreview
			' 
			Me.btnPreview.Location = New System.Drawing.Point(497, 338)
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.Size = New System.Drawing.Size(130, 24)
			Me.btnPreview.TabIndex = 2
			Me.btnPreview.Text = "Preview Alert"
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click);
			' 
			' radDesktopAlert1
			' 
			Me.radDesktopAlert1.ContentImage = My.Resources.Clock_Alarm
			Me.radDesktopAlert1.FixedSize = New System.Drawing.Size(329, 100)
			Me.radDesktopAlert1.PlaySound = False
			Me.radDesktopAlert1.SoundToPlay = Nothing
			Me.radDesktopAlert1.ThemeName = Nothing
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(918, 732)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.spinOpacity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optionsButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pinButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.closeButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ddScreenPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ddThemeName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ddAnimationDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkPopupAnimation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fadeOutCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fadeInCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinPopupAnimationFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.autoCloseDelaySpin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.autoCloseCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinFadeDuration, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtContent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnPreview, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents ddThemeName As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents ddScreenPosition As Telerik.WinControls.UI.RadDropDownList
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinEditorHeight As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinEditorWidth As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents optionsButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents pinButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents closeButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private WithEvents autoCloseCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents autoCloseDelaySpin As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents fadeOutCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents fadeInCheck As Telerik.WinControls.UI.RadCheckBox
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinFadeDuration As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents checkPopupAnimation As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents ddAnimationDirection As Telerik.WinControls.UI.RadDropDownList
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private txtContent As Telerik.WinControls.UI.RadTextBox
		Private txtCaption As Telerik.WinControls.UI.RadTextBox
		Private WithEvents btnPreview As Telerik.WinControls.UI.RadButton
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinPopupAnimationFrames As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinOpacity As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel12 As Telerik.WinControls.UI.RadLabel
		Private radDesktopAlert1 As Telerik.WinControls.UI.RadDesktopAlert
	End Class
End Namespace
