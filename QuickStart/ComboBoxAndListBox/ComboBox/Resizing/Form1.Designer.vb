Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Resizing
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
			Me.radGroupSizingMode = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioUpDown = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioBottomUpDown = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioRightBottom = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupSizingMode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSizingMode.SuspendLayout()
			CType(Me.radRadioUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioBottomUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(282, 318)
			Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSizingMode)
			Me.settingsPanel.Location = New System.Drawing.Point(726, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 734)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSizingMode, 0)
			' 
			' radGroupSizingMode
			' 
			Me.radGroupSizingMode.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSizingMode.Controls.Add(Me.radRadioUpDown)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioBottomUpDown)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioRightBottom)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioNone)
			Me.radGroupSizingMode.FooterImageIndex = -1
			Me.radGroupSizingMode.FooterImageKey = ""
			Me.radGroupSizingMode.FooterText = ""
			Me.radGroupSizingMode.ForeColor = System.Drawing.Color.Black
			Me.radGroupSizingMode.HeaderImageIndex = -1
			Me.radGroupSizingMode.HeaderImageKey = ""
			Me.radGroupSizingMode.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupSizingMode.HeaderText = " Sizing Mode "
			Me.radGroupSizingMode.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSizingMode.Name = "radGroupSizingMode"
			Me.radGroupSizingMode.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSizingMode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSizingMode.Size = New System.Drawing.Size(180, 156)
			Me.radGroupSizingMode.TabIndex = 0
			Me.radGroupSizingMode.Text = " Sizing Mode "
			' 
			' radRadioUpDown
			' 
			Me.radRadioUpDown.ForeColor = System.Drawing.Color.Black
			Me.radRadioUpDown.Location = New System.Drawing.Point(13, 112)
			Me.radRadioUpDown.Name = "radRadioUpDown"
			Me.radRadioUpDown.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioUpDown.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioUpDown.Size = New System.Drawing.Size(64, 16)
			Me.radRadioUpDown.TabIndex = 3
			Me.radRadioUpDown.Text = "UpDown"
			Me.radRadioUpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radRadioUpDown.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSizingMode_ToggleStateChanged);
			' 
			' radRadioBottomUpDown
			' 
			Me.radRadioBottomUpDown.ForeColor = System.Drawing.Color.Black
			Me.radRadioBottomUpDown.Location = New System.Drawing.Point(13, 78)
			Me.radRadioBottomUpDown.Name = "radRadioBottomUpDown"
			Me.radRadioBottomUpDown.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioBottomUpDown.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioBottomUpDown.Size = New System.Drawing.Size(111, 29)
			Me.radRadioBottomUpDown.TabIndex = 2
			Me.radRadioBottomUpDown.Text = "RightBottom and" & Constants.vbCrLf & "UpDown"
			Me.radRadioBottomUpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radRadioBottomUpDown.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSizingMode_ToggleStateChanged);
			' 
			' radRadioRightBottom
			' 
			Me.radRadioRightBottom.ForeColor = System.Drawing.Color.Black
			Me.radRadioRightBottom.Location = New System.Drawing.Point(13, 57)
			Me.radRadioRightBottom.Name = "radRadioRightBottom"
			Me.radRadioRightBottom.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioRightBottom.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRightBottom.Size = New System.Drawing.Size(83, 16)
			Me.radRadioRightBottom.TabIndex = 1
			Me.radRadioRightBottom.Text = "RightBottom"
			Me.radRadioRightBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radRadioRightBottom.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSizingMode_ToggleStateChanged);
			' 
			' radRadioNone
			' 
			Me.radRadioNone.ForeColor = System.Drawing.Color.Black
			Me.radRadioNone.Location = New System.Drawing.Point(13, 36)
			Me.radRadioNone.Name = "radRadioNone"
			Me.radRadioNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioNone.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioNone.Size = New System.Drawing.Size(47, 16)
			Me.radRadioNone.TabIndex = 0
			Me.radRadioNone.Text = "None"
			Me.radRadioNone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radRadioNone.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSizingMode_ToggleStateChanged);
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DataSource = Me.employeesBindingSource
			Me.radComboDemo.DisplayMember = "LastName"
			Me.radComboDemo.DropDownHeight = 80
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Location = New System.Drawing.Point(28, 42)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			Me.radComboDemo.Text = ""
			Me.radComboDemo.ThemeName = "ControlDefault"
			Me.radComboDemo.ValueMember = "EmployeeID"
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(927, 736)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupSizingMode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSizingMode.ResumeLayout(False)
			CType(Me.radRadioUpDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioBottomUpDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupSizingMode As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioUpDown As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioBottomUpDown As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioRightBottom As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioNone As Telerik.WinControls.UI.RadRadioButton
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace
