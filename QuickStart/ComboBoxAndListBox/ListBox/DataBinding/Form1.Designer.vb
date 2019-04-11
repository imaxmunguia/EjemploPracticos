Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.DataBinding
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
			Me.radListBoxDemo = New Telerik.WinControls.UI.RadListControl()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radGroupOptions = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioArray = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDB = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDataTable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioUnbound = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupOptions.SuspendLayout()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupOptions)
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 784)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupOptions, 0)
			' 
			' radListBoxDemo
			' 
			Me.radListBoxDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radListBoxDemo.ForeColor = System.Drawing.Color.Black
			Me.radListBoxDemo.Location = New System.Drawing.Point(375, 313)
			Me.radListBoxDemo.Name = "radListBoxDemo"
			' 
			' 
			' 
			Me.radListBoxDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radListBoxDemo.RootElement.ToolTipText = Nothing
			Me.radListBoxDemo.Size = New System.Drawing.Size(230, 160)
			Me.radListBoxDemo.TabIndex = 6
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "NwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' radGroupOptions
			' 
			Me.radGroupOptions.Controls.Add(Me.radRadioArray)
			Me.radGroupOptions.Controls.Add(Me.radRadioDB)
			Me.radGroupOptions.Controls.Add(Me.radRadioDataTable)
			Me.radGroupOptions.Controls.Add(Me.radRadioUnbound)
			Me.radGroupOptions.FooterImageIndex = -1
			Me.radGroupOptions.FooterImageKey = ""
			Me.radGroupOptions.FooterText = ""
			Me.radGroupOptions.ForeColor = System.Drawing.Color.Black
			Me.radGroupOptions.HeaderImageIndex = -1
			Me.radGroupOptions.HeaderImageKey = ""
			Me.radGroupOptions.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupOptions.HeaderText = "Binding Options"
			Me.radGroupOptions.Location = New System.Drawing.Point(15, 6)
			Me.radGroupOptions.Name = "radGroupOptions"
			' 
			' 
			' 
			Me.radGroupOptions.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupOptions.Size = New System.Drawing.Size(162, 126)
			Me.radGroupOptions.TabIndex = 0
			Me.radGroupOptions.Text = "Binding Options"
			' 
			' radRadioArray
			' 
			Me.radRadioArray.ForeColor = System.Drawing.Color.Black
			Me.radRadioArray.Location = New System.Drawing.Point(20, 74)
			Me.radRadioArray.Name = "radRadioArray"
			Me.radRadioArray.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioArray.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioArray.Size = New System.Drawing.Size(47, 16)
			Me.radRadioArray.TabIndex = 0
			Me.radRadioArray.Text = "Array"
'			Me.radRadioArray.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioOptions_ToggleStateChanged);
			' 
			' radRadioDB
			' 
			Me.radRadioDB.ForeColor = System.Drawing.Color.Black
			Me.radRadioDB.Location = New System.Drawing.Point(20, 96)
			Me.radRadioDB.Name = "radRadioDB"
			Me.radRadioDB.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioDB.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDB.Size = New System.Drawing.Size(69, 16)
			Me.radRadioDB.TabIndex = 0
			Me.radRadioDB.Text = "Database"
'			Me.radRadioDB.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioOptions_ToggleStateChanged);
			' 
			' radRadioDataTable
			' 
			Me.radRadioDataTable.ForeColor = System.Drawing.Color.Black
			Me.radRadioDataTable.Location = New System.Drawing.Point(20, 52)
			Me.radRadioDataTable.Name = "radRadioDataTable"
			Me.radRadioDataTable.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioDataTable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDataTable.Size = New System.Drawing.Size(76, 16)
			Me.radRadioDataTable.TabIndex = 0
			Me.radRadioDataTable.Text = "Data Table"
'			Me.radRadioDataTable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioOptions_ToggleStateChanged);
			' 
			' radRadioUnbound
			' 
			Me.radRadioUnbound.ForeColor = System.Drawing.Color.Black
			Me.radRadioUnbound.Location = New System.Drawing.Point(20, 30)
			Me.radRadioUnbound.Name = "radRadioUnbound"
			Me.radRadioUnbound.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioUnbound.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioUnbound.Size = New System.Drawing.Size(97, 16)
			Me.radRadioUnbound.TabIndex = 0
			Me.radRadioUnbound.Text = "Unbound mode"
'			Me.radRadioUnbound.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioOptions_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radListBoxDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 786)
			Me.Controls.SetChildIndex(Me.radListBoxDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupOptions.ResumeLayout(False)
			Me.radGroupOptions.PerformLayout()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListBoxDemo As Telerik.WinControls.UI.RadListControl
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private radGroupOptions As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioArray As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioDB As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioDataTable As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioUnbound As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace