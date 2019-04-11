Imports Microsoft.VisualBasic
Imports Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding.General
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding
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
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.NorthwindDataSetAccess = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.employeesTableAdapter2 = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radGroupBindingOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioDB = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioArray = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDataTable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioUnbound = New Telerik.WinControls.UI.RadRadioButton()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.NorthwindDataSetAccess, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBindingOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBindingOpts.SuspendLayout()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 318)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBindingOpts)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBindingOpts, 0)
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.NorthwindDataSetAccess
			' 
			' NorthwindDataSetAccess
			' 
			Me.NorthwindDataSetAccess.DataSetName = "NwindDataSet"
			Me.NorthwindDataSetAccess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' CustomerBindingSource
			' 
			Me.CustomerBindingSource.DataSource = GetType(Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding.General.Customer)
'			Me.CustomerBindingSource.AddingNew += New System.ComponentModel.AddingNewEventHandler(Me.CustomerBindingSource_AddingNew);
			' 
			' employeesTableAdapter2
			' 
			Me.employeesTableAdapter2.ClearBeforeFill = True
			' 
			' radGroupBindingOpts
			' 
			Me.radGroupBindingOpts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioDB)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioArray)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioDataTable)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioUnbound)
			Me.radGroupBindingOpts.FooterImageIndex = -1
			Me.radGroupBindingOpts.FooterImageKey = ""
			Me.radGroupBindingOpts.FooterText = ""
			Me.radGroupBindingOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupBindingOpts.HeaderImageIndex = -1
			Me.radGroupBindingOpts.HeaderImageKey = ""
			Me.radGroupBindingOpts.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBindingOpts.HeaderText = " Binding options "
			Me.radGroupBindingOpts.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBindingOpts.Name = "radGroupBindingOpts"
			Me.radGroupBindingOpts.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBindingOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBindingOpts.Size = New System.Drawing.Size(180, 131)
			Me.radGroupBindingOpts.TabIndex = 0
			Me.radGroupBindingOpts.Text = " Binding options "
			' 
			' radRadioDB
			' 
			Me.radRadioDB.ForeColor = System.Drawing.Color.Black
			Me.radRadioDB.Location = New System.Drawing.Point(33, 96)
			Me.radRadioDB.Name = "radRadioDB"
			' 
			' 
			' 
			Me.radRadioDB.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDB.Size = New System.Drawing.Size(69, 16)
			Me.radRadioDB.TabIndex = 0
			Me.radRadioDB.Text = "Database"
'			Me.radRadioDB.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioBinding_ToggleStateChanged);
			' 
			' radRadioArray
			' 
			Me.radRadioArray.ForeColor = System.Drawing.Color.Black
			Me.radRadioArray.Location = New System.Drawing.Point(33, 74)
			Me.radRadioArray.Name = "radRadioArray"
			' 
			' 
			' 
			Me.radRadioArray.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioArray.Size = New System.Drawing.Size(47, 16)
			Me.radRadioArray.TabIndex = 0
			Me.radRadioArray.Text = "Array"
'			Me.radRadioArray.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioBinding_ToggleStateChanged);
			' 
			' radRadioDataTable
			' 
			Me.radRadioDataTable.ForeColor = System.Drawing.Color.Black
			Me.radRadioDataTable.Location = New System.Drawing.Point(33, 52)
			Me.radRadioDataTable.Name = "radRadioDataTable"
			' 
			' 
			' 
			Me.radRadioDataTable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDataTable.Size = New System.Drawing.Size(76, 16)
			Me.radRadioDataTable.TabIndex = 0
			Me.radRadioDataTable.Text = "Data Table"
'			Me.radRadioDataTable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioBinding_ToggleStateChanged);
			' 
			' radRadioUnbound
			' 
			Me.radRadioUnbound.ForeColor = System.Drawing.Color.Black
			Me.radRadioUnbound.Location = New System.Drawing.Point(33, 30)
			Me.radRadioUnbound.Name = "radRadioUnbound"
			' 
			' 
			' 
			Me.radRadioUnbound.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioUnbound.Size = New System.Drawing.Size(97, 16)
			Me.radRadioUnbound.TabIndex = 0
			Me.radRadioUnbound.Text = "Unbound mode"
'			Me.radRadioUnbound.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioBinding_ToggleStateChanged);
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 2
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.NorthwindDataSetAccess, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBindingOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBindingOpts.ResumeLayout(False)
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private NorthwindDataSetAccess As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter2 As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private WithEvents CustomerBindingSource As BindingSource
		Private employeesBindingSource As BindingSource
		Private radGroupBindingOpts As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioDB As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioArray As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioDataTable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioUnbound As Telerik.WinControls.UI.RadRadioButton
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace