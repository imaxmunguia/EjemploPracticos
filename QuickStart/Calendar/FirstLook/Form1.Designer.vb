Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.FirstLook
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
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.cbTitleFormat = New Telerik.WinControls.UI.RadDropDownList()
			Me.lbRenderingDirection = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.chShowSelector = New Telerik.WinControls.UI.RadCheckBox()
			Me.chRowHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.chColumnHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.lbTitleFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.chNavigationButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.chFastNavigationButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.chViewHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.chAllowFishEye = New Telerik.WinControls.UI.RadCheckBox()
			Me.nudHeaderHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.nudHeaderWidth = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radioButton16 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioButton15 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chShowSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chNavigationButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chFastNavigationButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chViewHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chAllowFishEye, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudHeaderWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(930, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.AllowColumnHeaderSelectors = True
			Me.radCalendar1.AllowFishEye = True
			Me.radCalendar1.AllowMultipleSelect = True
			Me.radCalendar1.AllowMultipleView = True
			Me.radCalendar1.AllowRowHeaderSelectors = True
			Me.radCalendar1.AllowViewSelector = True
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FastNavigationNextImage = (CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.FastNavigationPrevImage = (CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image))
            Me.radCalendar1.FocusedDate = System.DateTime.Now
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(210, 173)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.NavigationNextImage = (CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.NavigationPrevImage = (CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0)))), New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.ShowFastNavigationButtons = False
			Me.radCalendar1.ShowFooter = True
			Me.radCalendar1.ShowRowHeaders = True
			Me.radCalendar1.ShowViewSelector = True
			Me.radCalendar1.Size = New System.Drawing.Size(711, 486)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' cbTitleFormat
			' 
			Me.cbTitleFormat.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cbTitleFormat.ForeColor = System.Drawing.Color.Black
			radListDataItem5.Text = "MMMM yyyy"
			radListDataItem5.TextWrap = True
			radListDataItem6.Text = "MM/yy"
			radListDataItem6.TextWrap = True
			radListDataItem7.Text = "MM-yy"
			radListDataItem7.TextWrap = True
			radListDataItem8.Text = "MMM yyyy"
			radListDataItem8.TextWrap = True
			Me.cbTitleFormat.Items.Add(radListDataItem5)
			Me.cbTitleFormat.Items.Add(radListDataItem6)
			Me.cbTitleFormat.Items.Add(radListDataItem7)
			Me.cbTitleFormat.Items.Add(radListDataItem8)
			Me.cbTitleFormat.Location = New System.Drawing.Point(14, 263)
			Me.cbTitleFormat.MaxDropDownItems = 4
			Me.cbTitleFormat.Name = "cbTitleFormat"
			' 
			' 
			' 
			Me.cbTitleFormat.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cbTitleFormat.RootElement.ForeColor = System.Drawing.Color.Black
			Me.cbTitleFormat.ShowImageInEditorArea = True
			Me.cbTitleFormat.Size = New System.Drawing.Size(93, 21)
			Me.cbTitleFormat.TabIndex = 1
			Me.cbTitleFormat.Text = "MMMM yyyy"
'			Me.cbTitleFormat.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.cbTitleFormat_SelectedIndexChanged);
			' 
			' lbRenderingDirection
			' 
			Me.lbRenderingDirection.BackColor = System.Drawing.Color.Transparent
			Me.lbRenderingDirection.ForeColor = System.Drawing.Color.Black
			Me.lbRenderingDirection.Location = New System.Drawing.Point(11, 26)
			Me.lbRenderingDirection.Name = "lbRenderingDirection"
			' 
			' 
			' 
			Me.lbRenderingDirection.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lbRenderingDirection.Size = New System.Drawing.Size(135, 18)
			Me.lbRenderingDirection.TabIndex = 4
			Me.lbRenderingDirection.Text = "Select rendering direction"
			Me.lbRenderingDirection.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox3.Location = New System.Drawing.Point(13, 153)
			Me.radCheckBox3.Name = "radCheckBox3"
			' 
			' 
			' 
			Me.radCheckBox3.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox3.Size = New System.Drawing.Size(79, 18)
			Me.radCheckBox3.TabIndex = 19
			Me.radCheckBox3.Text = "Right to left"
'			Me.radCheckBox3.Click += New System.EventHandler(Me.radCheckBox3_Click);
			' 
			' chShowSelector
			' 
			Me.chShowSelector.BackColor = System.Drawing.Color.Transparent
			Me.chShowSelector.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chShowSelector.Location = New System.Drawing.Point(13, 72)
			Me.chShowSelector.Name = "chShowSelector"
			' 
			' 
			' 
			Me.chShowSelector.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chShowSelector.Size = New System.Drawing.Size(90, 18)
			Me.chShowSelector.TabIndex = 8
			Me.chShowSelector.Text = "Show selector"
			Me.chShowSelector.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chShowSelector.Click += New System.EventHandler(Me.chShowSelector_Click);
			' 
			' chRowHeader
			' 
			Me.chRowHeader.BackColor = System.Drawing.Color.Transparent
			Me.chRowHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chRowHeader.Location = New System.Drawing.Point(13, 26)
			Me.chRowHeader.Name = "chRowHeader"
			' 
			' 
			' 
			Me.chRowHeader.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chRowHeader.Size = New System.Drawing.Size(107, 18)
			Me.chRowHeader.TabIndex = 6
			Me.chRowHeader.Text = "Show row header"
			Me.chRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chRowHeader.Click += New System.EventHandler(Me.chRowHeader_Click);
			' 
			' chColumnHeader
			' 
			Me.chColumnHeader.BackColor = System.Drawing.Color.Transparent
			Me.chColumnHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chColumnHeader.Location = New System.Drawing.Point(13, 49)
			Me.chColumnHeader.Name = "chColumnHeader"
			' 
			' 
			' 
			Me.chColumnHeader.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chColumnHeader.Size = New System.Drawing.Size(129, 18)
			Me.chColumnHeader.TabIndex = 7
			Me.chColumnHeader.Text = "Show column  header"
			Me.chColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chColumnHeader.Click += New System.EventHandler(Me.chColumnHeader_Click);
			' 
			' lbTitleFormat
			' 
			Me.lbTitleFormat.BackColor = System.Drawing.Color.Transparent
			Me.lbTitleFormat.ForeColor = System.Drawing.Color.Black
			Me.lbTitleFormat.Location = New System.Drawing.Point(13, 243)
			Me.lbTitleFormat.Name = "lbTitleFormat"
			' 
			' 
			' 
			Me.lbTitleFormat.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lbTitleFormat.Size = New System.Drawing.Size(66, 18)
			Me.lbTitleFormat.TabIndex = 6
			Me.lbTitleFormat.Text = "Title format:"
			Me.lbTitleFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox2.Location = New System.Drawing.Point(13, 222)
			Me.radCheckBox2.Name = "radCheckBox2"
			' 
			' 
			' 
			Me.radCheckBox2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox2.Size = New System.Drawing.Size(124, 18)
			Me.radCheckBox2.TabIndex = 18
			Me.radCheckBox2.Text = "Show Navigation Bar"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBox2.Click += New System.EventHandler(Me.radCheckBox2_Click);
			' 
			' chNavigationButtons
			' 
			Me.chNavigationButtons.BackColor = System.Drawing.Color.Transparent
			Me.chNavigationButtons.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chNavigationButtons.Location = New System.Drawing.Point(13, 95)
			Me.chNavigationButtons.Name = "chNavigationButtons"
			' 
			' 
			' 
			Me.chNavigationButtons.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chNavigationButtons.Size = New System.Drawing.Size(145, 18)
			Me.chNavigationButtons.TabIndex = 9
			Me.chNavigationButtons.Text = "Show navigation buttons"
			Me.chNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chNavigationButtons.Click += New System.EventHandler(Me.chNavigationButtons_Click);
			' 
			' chFastNavigationButtons
			' 
			Me.chFastNavigationButtons.BackColor = System.Drawing.Color.Transparent
			Me.chFastNavigationButtons.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chFastNavigationButtons.Location = New System.Drawing.Point(13, 118)
			Me.chFastNavigationButtons.Name = "chFastNavigationButtons"
			' 
			' 
			' 
			Me.chFastNavigationButtons.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chFastNavigationButtons.Size = New System.Drawing.Size(132, 33)
			Me.chFastNavigationButtons.TabIndex = 10
			Me.chFastNavigationButtons.Text = "Show fast navigation " & Constants.vbCrLf & "buttons"
'			Me.chFastNavigationButtons.Click += New System.EventHandler(Me.chFastNavigationButtons_Click);
			' 
			' chViewHeader
			' 
			Me.chViewHeader.BackColor = System.Drawing.Color.Transparent
			Me.chViewHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chViewHeader.Location = New System.Drawing.Point(13, 176)
			Me.chViewHeader.Name = "chViewHeader"
			' 
			' 
			' 
			Me.chViewHeader.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chViewHeader.Size = New System.Drawing.Size(111, 18)
			Me.chViewHeader.TabIndex = 11
			Me.chViewHeader.Text = "Show view header"
			Me.chViewHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.chViewHeader.Visible = False
'			Me.chViewHeader.Click += New System.EventHandler(Me.chViewHeader_Click);
			' 
			' chAllowFishEye
			' 
			Me.chAllowFishEye.BackColor = System.Drawing.Color.Transparent
			Me.chAllowFishEye.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chAllowFishEye.Location = New System.Drawing.Point(13, 199)
			Me.chAllowFishEye.Name = "chAllowFishEye"
			' 
			' 
			' 
			Me.chAllowFishEye.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chAllowFishEye.Size = New System.Drawing.Size(92, 18)
			Me.chAllowFishEye.TabIndex = 12
			Me.chAllowFishEye.Text = "Allow fish eye "
			Me.chAllowFishEye.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chAllowFishEye.Click += New System.EventHandler(Me.chAllowFishEye_Click);
			' 
			' nudHeaderHeight
			' 
			Me.nudHeaderHeight.BackColor = System.Drawing.Color.White
			Me.nudHeaderHeight.ForeColor = System.Drawing.Color.Black
			Me.nudHeaderHeight.Location = New System.Drawing.Point(14, 159)
			Me.nudHeaderHeight.Minimum = New Decimal(New Integer() { 17, 0, 0, 0})
			Me.nudHeaderHeight.Name = "nudHeaderHeight"
			' 
			' 
			' 
			Me.nudHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.nudHeaderHeight.RootElement.ForeColor = System.Drawing.Color.Black
			Me.nudHeaderHeight.ShowBorder = True
			Me.nudHeaderHeight.Size = New System.Drawing.Size(132, 21)
			Me.nudHeaderHeight.TabIndex = 20
			Me.nudHeaderHeight.TabStop = False
			Me.nudHeaderHeight.Value = New Decimal(New Integer() { 17, 0, 0, 0})
'			Me.nudHeaderHeight.ValueChanged += New System.EventHandler(Me.nudHeaderHeight_ValueChanged);
			' 
			' nudHeaderWidth
			' 
			Me.nudHeaderWidth.BackColor = System.Drawing.Color.White
			Me.nudHeaderWidth.ForeColor = System.Drawing.Color.Black
			Me.nudHeaderWidth.Location = New System.Drawing.Point(14, 115)
			Me.nudHeaderWidth.Minimum = New Decimal(New Integer() { 17, 0, 0, 0})
			Me.nudHeaderWidth.Name = "nudHeaderWidth"
			' 
			' 
			' 
			Me.nudHeaderWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.nudHeaderWidth.RootElement.ForeColor = System.Drawing.Color.Black
			Me.nudHeaderWidth.ShowBorder = True
			Me.nudHeaderWidth.Size = New System.Drawing.Size(132, 21)
			Me.nudHeaderWidth.TabIndex = 20
			Me.nudHeaderWidth.TabStop = False
			Me.nudHeaderWidth.Value = New Decimal(New Integer() { 17, 0, 0, 0})
'			Me.nudHeaderWidth.ValueChanged += New System.EventHandler(Me.nudHeaderWidth_ValueChanged);
			' 
			' radioButton16
			' 
			Me.radioButton16.ForeColor = System.Drawing.Color.Black
			Me.radioButton16.Location = New System.Drawing.Point(14, 47)
			Me.radioButton16.Name = "radioButton16"
			' 
			' 
			' 
			Me.radioButton16.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radioButton16.Size = New System.Drawing.Size(101, 16)
			Me.radioButton16.TabIndex = 21
			Me.radioButton16.Text = "Render In Rows"
'			Me.radioButton16.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radioButton16_ToggleStateChanged);
			' 
			' radioButton15
			' 
			Me.radioButton15.ForeColor = System.Drawing.Color.Black
			Me.radioButton15.Location = New System.Drawing.Point(14, 69)
			Me.radioButton15.Name = "radioButton15"
			' 
			' 
			' 
			Me.radioButton15.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radioButton15.Size = New System.Drawing.Size(118, 16)
			Me.radioButton15.TabIndex = 21
			Me.radioButton15.Text = "Render In Columns"
'			Me.radioButton15.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radioButton15_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.cbTitleFormat)
			Me.radGroupBox1.Controls.Add(Me.chRowHeader)
			Me.radGroupBox1.Controls.Add(Me.chFastNavigationButtons)
			Me.radGroupBox1.Controls.Add(Me.lbTitleFormat)
			Me.radGroupBox1.Controls.Add(Me.chViewHeader)
			Me.radGroupBox1.Controls.Add(Me.chNavigationButtons)
			Me.radGroupBox1.Controls.Add(Me.chColumnHeader)
			Me.radGroupBox1.Controls.Add(Me.radCheckBox3)
			Me.radGroupBox1.Controls.Add(Me.chAllowFishEye)
			Me.radGroupBox1.Controls.Add(Me.chShowSelector)
			Me.radGroupBox1.Controls.Add(Me.radCheckBox2)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Calendar Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 297)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Calendar Settings"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.Controls.Add(Me.radioButton16)
			Me.radGroupBox2.Controls.Add(Me.radioButton15)
			Me.radGroupBox2.Controls.Add(Me.lbRenderingDirection)
			Me.radGroupBox2.Controls.Add(Me.nudHeaderHeight)
			Me.radGroupBox2.Controls.Add(Me.nudHeaderWidth)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Rendering Options"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 309)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 192)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Rendering Options"
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(14, 141)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(79, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Header Height"
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(14, 95)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(76, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Header Width"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1131, 832)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chShowSelector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chNavigationButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chFastNavigationButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chViewHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chAllowFishEye, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudHeaderWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents cbTitleFormat As Telerik.WinControls.UI.RadDropDownList
		Private lbRenderingDirection As Telerik.WinControls.UI.RadLabel
		Private lbTitleFormat As Telerik.WinControls.UI.RadLabel
		Private WithEvents chRowHeader As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chColumnHeader As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chShowSelector As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chNavigationButtons As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chFastNavigationButtons As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chViewHeader As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chAllowFishEye As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents nudHeaderHeight As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents nudHeaderWidth As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radioButton16 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radioButton15 As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace