Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.Selection
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radGroupAllowSelect = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowSelectEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowSelectDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupMultiSelect = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioMultiSelectEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioMultiSelectDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupShowRowHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioShowRowHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioShowRowHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupAllowViewSelector = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioEnableAllowViewSelectorEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioEnableAllowViewSelectorDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupAllowRowHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowRowHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowRowHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupAllowColumnHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowColumnHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowColumnHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupColumnHeaders = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioColumnHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioColumnHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowSelect.SuspendLayout()
			CType(Me.radRadioAllowSelectEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowSelectDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupMultiSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupMultiSelect.SuspendLayout()
			CType(Me.radRadioMultiSelectEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioMultiSelectDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupShowRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupShowRowHeader.SuspendLayout()
			CType(Me.radRadioShowRowHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioShowRowHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowViewSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowViewSelector.SuspendLayout()
			CType(Me.radRadioEnableAllowViewSelectorEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioEnableAllowViewSelectorDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowRowHeader.SuspendLayout()
			CType(Me.radRadioAllowRowHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowRowHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowColumnHeader.SuspendLayout()
			CType(Me.radRadioAllowColumnHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowColumnHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupColumnHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupColumnHeaders.SuspendLayout()
			CType(Me.radRadioColumnHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioColumnHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupAllowSelect)
			Me.settingsPanel.Controls.Add(Me.radGroupMultiSelect)
			Me.settingsPanel.Controls.Add(Me.radGroupAllowColumnHeader)
			Me.settingsPanel.Controls.Add(Me.radGroupColumnHeaders)
			Me.settingsPanel.Controls.Add(Me.radGroupAllowRowHeader)
			Me.settingsPanel.Controls.Add(Me.radGroupAllowViewSelector)
			Me.settingsPanel.Controls.Add(Me.radGroupShowRowHeader)
			Me.settingsPanel.Controls.Add(Me.radButton1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(692, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupShowRowHeader, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAllowViewSelector, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAllowRowHeader, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupColumnHeaders, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAllowColumnHeader, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupMultiSelect, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAllowSelect, 0)
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton1.BackColor = System.Drawing.Color.Transparent
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.Location = New System.Drawing.Point(10, 481)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(180, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Clear Selections"
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 5, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(302, 290)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.ShowViewSelector = True
			Me.radCalendar1.Size = New System.Drawing.Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radGroupAllowSelect
			' 
			Me.radGroupAllowSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupAllowSelect.Controls.Add(Me.radRadioAllowSelectEnable)
			Me.radGroupAllowSelect.Controls.Add(Me.radRadioAllowSelectDisable)
			Me.radGroupAllowSelect.FooterImageIndex = -1
			Me.radGroupAllowSelect.FooterImageKey = ""
			Me.radGroupAllowSelect.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowSelect.HeaderImageIndex = -1
			Me.radGroupAllowSelect.HeaderImageKey = ""
			Me.radGroupAllowSelect.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupAllowSelect.HeaderText = "Allow Select"
			Me.radGroupAllowSelect.Location = New System.Drawing.Point(10, 6)
			Me.radGroupAllowSelect.Name = "radGroupAllowSelect"
			Me.radGroupAllowSelect.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupAllowSelect.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowSelect.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupAllowSelect.Size = New System.Drawing.Size(180, 66)
			Me.radGroupAllowSelect.TabIndex = 6
			Me.radGroupAllowSelect.Text = "Allow Select"
			' 
			' radRadioAllowSelectEnable
			' 
			Me.radRadioAllowSelectEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowSelectEnable.Location = New System.Drawing.Point(17, 24)
			Me.radRadioAllowSelectEnable.Name = "radRadioAllowSelectEnable"
			' 
			' 
			' 
			Me.radRadioAllowSelectEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowSelectEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioAllowSelectEnable.TabIndex = 7
			Me.radRadioAllowSelectEnable.Text = "Enable"
'			Me.radRadioAllowSelectEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowSelectEnable_ToggleStateChanged);
			' 
			' radRadioAllowSelectDisable
			' 
			Me.radRadioAllowSelectDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowSelectDisable.Location = New System.Drawing.Point(17, 41)
			Me.radRadioAllowSelectDisable.Name = "radRadioAllowSelectDisable"
			' 
			' 
			' 
			Me.radRadioAllowSelectDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowSelectDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioAllowSelectDisable.TabIndex = 7
			Me.radRadioAllowSelectDisable.Text = "Disable"
'			Me.radRadioAllowSelectDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowSelectEnable_ToggleStateChanged);
			' 
			' radGroupMultiSelect
			' 
			Me.radGroupMultiSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupMultiSelect.Controls.Add(Me.radRadioMultiSelectEnable)
			Me.radGroupMultiSelect.Controls.Add(Me.radRadioMultiSelectDisable)
			Me.radGroupMultiSelect.FooterImageIndex = -1
			Me.radGroupMultiSelect.FooterImageKey = ""
			Me.radGroupMultiSelect.ForeColor = System.Drawing.Color.Black
			Me.radGroupMultiSelect.HeaderImageIndex = -1
			Me.radGroupMultiSelect.HeaderImageKey = ""
			Me.radGroupMultiSelect.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupMultiSelect.HeaderText = "Allow Multi Select"
			Me.radGroupMultiSelect.Location = New System.Drawing.Point(10, 77)
			Me.radGroupMultiSelect.Name = "radGroupMultiSelect"
			Me.radGroupMultiSelect.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupMultiSelect.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupMultiSelect.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupMultiSelect.Size = New System.Drawing.Size(180, 63)
			Me.radGroupMultiSelect.TabIndex = 6
			Me.radGroupMultiSelect.Text = "Allow Multi Select"
			' 
			' radRadioMultiSelectEnable
			' 
			Me.radRadioMultiSelectEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioMultiSelectEnable.Location = New System.Drawing.Point(20, 24)
			Me.radRadioMultiSelectEnable.Name = "radRadioMultiSelectEnable"
			' 
			' 
			' 
			Me.radRadioMultiSelectEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioMultiSelectEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioMultiSelectEnable.TabIndex = 7
			Me.radRadioMultiSelectEnable.Text = "Enable"
'			Me.radRadioMultiSelectEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioMultiSelectEnable_ToggleStateChanged);
			' 
			' radRadioMultiSelectDisable
			' 
			Me.radRadioMultiSelectDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioMultiSelectDisable.Location = New System.Drawing.Point(20, 41)
			Me.radRadioMultiSelectDisable.Name = "radRadioMultiSelectDisable"
			' 
			' 
			' 
			Me.radRadioMultiSelectDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioMultiSelectDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioMultiSelectDisable.TabIndex = 7
			Me.radRadioMultiSelectDisable.Text = "Disable"
'			Me.radRadioMultiSelectDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioMultiSelectEnable_ToggleStateChanged);
			' 
			' radGroupShowRowHeader
			' 
			Me.radGroupShowRowHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupShowRowHeader.Controls.Add(Me.radRadioShowRowHeaderEnable)
			Me.radGroupShowRowHeader.Controls.Add(Me.radRadioShowRowHeaderDisable)
			Me.radGroupShowRowHeader.FooterImageIndex = -1
			Me.radGroupShowRowHeader.FooterImageKey = ""
			Me.radGroupShowRowHeader.ForeColor = System.Drawing.Color.Black
			Me.radGroupShowRowHeader.HeaderImageIndex = -1
			Me.radGroupShowRowHeader.HeaderImageKey = ""
			Me.radGroupShowRowHeader.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupShowRowHeader.HeaderText = "Show Row Selectors"
			Me.radGroupShowRowHeader.Location = New System.Drawing.Point(10, 212)
			Me.radGroupShowRowHeader.Name = "radGroupShowRowHeader"
			Me.radGroupShowRowHeader.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupShowRowHeader.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupShowRowHeader.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupShowRowHeader.Size = New System.Drawing.Size(180, 60)
			Me.radGroupShowRowHeader.TabIndex = 6
			Me.radGroupShowRowHeader.Text = "Show Row Selectors"
			' 
			' radRadioShowRowHeaderEnable
			' 
			Me.radRadioShowRowHeaderEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioShowRowHeaderEnable.Location = New System.Drawing.Point(22, 23)
			Me.radRadioShowRowHeaderEnable.Name = "radRadioShowRowHeaderEnable"
			' 
			' 
			' 
			Me.radRadioShowRowHeaderEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioShowRowHeaderEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioShowRowHeaderEnable.TabIndex = 7
			Me.radRadioShowRowHeaderEnable.Text = "Enable"
'			Me.radRadioShowRowHeaderEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRowHeaderEnable_ToggleStateChanged);
			' 
			' radRadioShowRowHeaderDisable
			' 
			Me.radRadioShowRowHeaderDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioShowRowHeaderDisable.Location = New System.Drawing.Point(22, 40)
			Me.radRadioShowRowHeaderDisable.Name = "radRadioShowRowHeaderDisable"
			' 
			' 
			' 
			Me.radRadioShowRowHeaderDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioShowRowHeaderDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioShowRowHeaderDisable.TabIndex = 7
			Me.radRadioShowRowHeaderDisable.Text = "Disable"
'			Me.radRadioShowRowHeaderDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRowHeaderEnable_ToggleStateChanged);
			' 
			' radGroupAllowViewSelector
			' 
			Me.radGroupAllowViewSelector.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupAllowViewSelector.Controls.Add(Me.radRadioEnableAllowViewSelectorEnable)
			Me.radGroupAllowViewSelector.Controls.Add(Me.radRadioEnableAllowViewSelectorDisable)
			Me.radGroupAllowViewSelector.FooterImageIndex = -1
			Me.radGroupAllowViewSelector.FooterImageKey = ""
			Me.radGroupAllowViewSelector.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowViewSelector.HeaderImageIndex = -1
			Me.radGroupAllowViewSelector.HeaderImageKey = ""
			Me.radGroupAllowViewSelector.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupAllowViewSelector.HeaderText = "Allow View Selector"
			Me.radGroupAllowViewSelector.Location = New System.Drawing.Point(10, 145)
			Me.radGroupAllowViewSelector.Name = "radGroupAllowViewSelector"
			Me.radGroupAllowViewSelector.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupAllowViewSelector.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowViewSelector.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupAllowViewSelector.Size = New System.Drawing.Size(180, 62)
			Me.radGroupAllowViewSelector.TabIndex = 6
			Me.radGroupAllowViewSelector.Text = "Allow View Selector"
			' 
			' radRadioEnableAllowViewSelectorEnable
			' 
			Me.radRadioEnableAllowViewSelectorEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioEnableAllowViewSelectorEnable.Location = New System.Drawing.Point(17, 23)
			Me.radRadioEnableAllowViewSelectorEnable.Name = "radRadioEnableAllowViewSelectorEnable"
			' 
			' 
			' 
			Me.radRadioEnableAllowViewSelectorEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioEnableAllowViewSelectorEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioEnableAllowViewSelectorEnable.TabIndex = 7
			Me.radRadioEnableAllowViewSelectorEnable.Text = "Enable"
'			Me.radRadioEnableAllowViewSelectorEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioEnableAllowViewSelectorEnable_ToggleStateChanged);
			' 
			' radRadioEnableAllowViewSelectorDisable
			' 
			Me.radRadioEnableAllowViewSelectorDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioEnableAllowViewSelectorDisable.Location = New System.Drawing.Point(17, 40)
			Me.radRadioEnableAllowViewSelectorDisable.Name = "radRadioEnableAllowViewSelectorDisable"
			' 
			' 
			' 
			Me.radRadioEnableAllowViewSelectorDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioEnableAllowViewSelectorDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioEnableAllowViewSelectorDisable.TabIndex = 7
			Me.radRadioEnableAllowViewSelectorDisable.Text = "Disable"
'			Me.radRadioEnableAllowViewSelectorDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioEnableAllowViewSelectorEnable_ToggleStateChanged);
			' 
			' radGroupAllowRowHeader
			' 
			Me.radGroupAllowRowHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupAllowRowHeader.Controls.Add(Me.radRadioAllowRowHeaderEnable)
			Me.radGroupAllowRowHeader.Controls.Add(Me.radRadioAllowRowHeaderDisable)
			Me.radGroupAllowRowHeader.FooterImageIndex = -1
			Me.radGroupAllowRowHeader.FooterImageKey = ""
			Me.radGroupAllowRowHeader.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowRowHeader.HeaderImageIndex = -1
			Me.radGroupAllowRowHeader.HeaderImageKey = ""
			Me.radGroupAllowRowHeader.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupAllowRowHeader.HeaderText = "Allow Row Selectors"
			Me.radGroupAllowRowHeader.Location = New System.Drawing.Point(10, 343)
			Me.radGroupAllowRowHeader.Name = "radGroupAllowRowHeader"
			Me.radGroupAllowRowHeader.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupAllowRowHeader.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowRowHeader.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupAllowRowHeader.Size = New System.Drawing.Size(180, 61)
			Me.radGroupAllowRowHeader.TabIndex = 6
			Me.radGroupAllowRowHeader.Text = "Allow Row Selectors"
			' 
			' radRadioAllowRowHeaderEnable
			' 
			Me.radRadioAllowRowHeaderEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowRowHeaderEnable.Location = New System.Drawing.Point(20, 23)
			Me.radRadioAllowRowHeaderEnable.Name = "radRadioAllowRowHeaderEnable"
			' 
			' 
			' 
			Me.radRadioAllowRowHeaderEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowRowHeaderEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioAllowRowHeaderEnable.TabIndex = 7
			Me.radRadioAllowRowHeaderEnable.Text = "Enable"
'			Me.radRadioAllowRowHeaderEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowRowHeader_ToggleStateChanged);
			' 
			' radRadioAllowRowHeaderDisable
			' 
			Me.radRadioAllowRowHeaderDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowRowHeaderDisable.Location = New System.Drawing.Point(20, 40)
			Me.radRadioAllowRowHeaderDisable.Name = "radRadioAllowRowHeaderDisable"
			' 
			' 
			' 
			Me.radRadioAllowRowHeaderDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowRowHeaderDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioAllowRowHeaderDisable.TabIndex = 7
			Me.radRadioAllowRowHeaderDisable.Text = "Disable"
'			Me.radRadioAllowRowHeaderDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowRowHeader_ToggleStateChanged);
			' 
			' radGroupAllowColumnHeader
			' 
			Me.radGroupAllowColumnHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupAllowColumnHeader.Controls.Add(Me.radRadioAllowColumnHeaderEnable)
			Me.radGroupAllowColumnHeader.Controls.Add(Me.radRadioAllowColumnHeaderDisable)
			Me.radGroupAllowColumnHeader.FooterImageIndex = -1
			Me.radGroupAllowColumnHeader.FooterImageKey = ""
			Me.radGroupAllowColumnHeader.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowColumnHeader.HeaderImageIndex = -1
			Me.radGroupAllowColumnHeader.HeaderImageKey = ""
			Me.radGroupAllowColumnHeader.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupAllowColumnHeader.HeaderText = "Allow Column Selector"
			Me.radGroupAllowColumnHeader.Location = New System.Drawing.Point(10, 409)
			Me.radGroupAllowColumnHeader.Name = "radGroupAllowColumnHeader"
			Me.radGroupAllowColumnHeader.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupAllowColumnHeader.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupAllowColumnHeader.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupAllowColumnHeader.Size = New System.Drawing.Size(180, 60)
			Me.radGroupAllowColumnHeader.TabIndex = 6
			Me.radGroupAllowColumnHeader.Text = "Allow Column Selector"
			' 
			' radRadioAllowColumnHeaderEnable
			' 
			Me.radRadioAllowColumnHeaderEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowColumnHeaderEnable.Location = New System.Drawing.Point(20, 21)
			Me.radRadioAllowColumnHeaderEnable.Name = "radRadioAllowColumnHeaderEnable"
			' 
			' 
			' 
			Me.radRadioAllowColumnHeaderEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowColumnHeaderEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioAllowColumnHeaderEnable.TabIndex = 7
			Me.radRadioAllowColumnHeaderEnable.Text = "Enable"
'			Me.radRadioAllowColumnHeaderEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowColumnHeaderEnable_ToggleStateChanged);
			' 
			' radRadioAllowColumnHeaderDisable
			' 
			Me.radRadioAllowColumnHeaderDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowColumnHeaderDisable.Location = New System.Drawing.Point(20, 38)
			Me.radRadioAllowColumnHeaderDisable.Name = "radRadioAllowColumnHeaderDisable"
			' 
			' 
			' 
			Me.radRadioAllowColumnHeaderDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAllowColumnHeaderDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioAllowColumnHeaderDisable.TabIndex = 7
			Me.radRadioAllowColumnHeaderDisable.Text = "Disable"
'			Me.radRadioAllowColumnHeaderDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioAllowColumnHeaderEnable_ToggleStateChanged);
			' 
			' radGroupColumnHeaders
			' 
			Me.radGroupColumnHeaders.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupColumnHeaders.Controls.Add(Me.radRadioColumnHeaderEnable)
			Me.radGroupColumnHeaders.Controls.Add(Me.radRadioColumnHeaderDisable)
			Me.radGroupColumnHeaders.FooterImageIndex = -1
			Me.radGroupColumnHeaders.FooterImageKey = ""
			Me.radGroupColumnHeaders.ForeColor = System.Drawing.Color.Black
			Me.radGroupColumnHeaders.HeaderImageIndex = -1
			Me.radGroupColumnHeaders.HeaderImageKey = ""
			Me.radGroupColumnHeaders.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupColumnHeaders.HeaderText = "Show Column Selectors"
			Me.radGroupColumnHeaders.Location = New System.Drawing.Point(10, 277)
			Me.radGroupColumnHeaders.Name = "radGroupColumnHeaders"
			Me.radGroupColumnHeaders.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupColumnHeaders.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupColumnHeaders.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupColumnHeaders.Size = New System.Drawing.Size(180, 61)
			Me.radGroupColumnHeaders.TabIndex = 6
			Me.radGroupColumnHeaders.Text = "Show Column Selectors"
			' 
			' radRadioColumnHeaderEnable
			' 
			Me.radRadioColumnHeaderEnable.ForeColor = System.Drawing.Color.Black
			Me.radRadioColumnHeaderEnable.Location = New System.Drawing.Point(22, 23)
			Me.radRadioColumnHeaderEnable.Name = "radRadioColumnHeaderEnable"
			' 
			' 
			' 
			Me.radRadioColumnHeaderEnable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioColumnHeaderEnable.Size = New System.Drawing.Size(56, 16)
			Me.radRadioColumnHeaderEnable.TabIndex = 7
			Me.radRadioColumnHeaderEnable.Text = "Enable"
'			Me.radRadioColumnHeaderEnable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioColumnHeaderEnable_ToggleStateChanged);
			' 
			' radRadioColumnHeaderDisable
			' 
			Me.radRadioColumnHeaderDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioColumnHeaderDisable.Location = New System.Drawing.Point(22, 40)
			Me.radRadioColumnHeaderDisable.Name = "radRadioColumnHeaderDisable"
			' 
			' 
			' 
			Me.radRadioColumnHeaderDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioColumnHeaderDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioColumnHeaderDisable.TabIndex = 7
			Me.radRadioColumnHeaderDisable.Text = "Disable"
'			Me.radRadioColumnHeaderDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioColumnHeaderEnable_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(893, 808)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowSelect, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowSelect.ResumeLayout(False)
			CType(Me.radRadioAllowSelectEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowSelectDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupMultiSelect, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupMultiSelect.ResumeLayout(False)
			CType(Me.radRadioMultiSelectEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioMultiSelectDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupShowRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupShowRowHeader.ResumeLayout(False)
			CType(Me.radRadioShowRowHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioShowRowHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowViewSelector, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowViewSelector.ResumeLayout(False)
			CType(Me.radRadioEnableAllowViewSelectorEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioEnableAllowViewSelectorDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowRowHeader.ResumeLayout(False)
			CType(Me.radRadioAllowRowHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowRowHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowColumnHeader.ResumeLayout(False)
			CType(Me.radRadioAllowColumnHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowColumnHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupColumnHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupColumnHeaders.ResumeLayout(False)
			CType(Me.radRadioColumnHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioColumnHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private radGroupAllowSelect As Telerik.WinControls.UI.RadGroupBox
		Private radGroupMultiSelect As Telerik.WinControls.UI.RadGroupBox
		Private radGroupShowRowHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowViewSelector As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowRowHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowColumnHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupColumnHeaders As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioAllowSelectEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAllowSelectDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioMultiSelectDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioMultiSelectEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioEnableAllowViewSelectorDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioEnableAllowViewSelectorEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioShowRowHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioShowRowHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioColumnHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioColumnHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAllowRowHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAllowRowHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAllowColumnHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAllowColumnHeaderDisable As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace