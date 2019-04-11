Imports Microsoft.VisualBasic
Imports System.Drawing
Namespace Telerik.Examples.WinControls.GridView.MultipleViews
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
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.radGroupViewOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupSpacing = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioGCView = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioHTML = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioTable = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupViewOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupViewOpts.SuspendLayout()
			CType(Me.radGroupSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSpacing.SuspendLayout()
			CType(Me.radRadioGCView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioHTML, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioTable, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupViewOpts)
			Me.settingsPanel.Location = New System.Drawing.Point(727, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 525)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupViewOpts, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.AutoSize = False
			Me.radGridView1.BackColor = System.Drawing.Color.White
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.HeaderText = "ID "
			gridViewTextBoxColumn1.Width = 190
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewTextBoxColumn2.FieldName = "CompanyName"
			gridViewTextBoxColumn2.HeaderText = "CompanyName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "CompanyName"
			gridViewTextBoxColumn2.Width = 100
			gridViewTextBoxColumn3.FieldName = "ContactName"
			gridViewTextBoxColumn3.HeaderText = "ContactName"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "ContactName"
			gridViewTextBoxColumn3.Width = 130
			gridViewTextBoxColumn4.FieldName = "ContactTitle"
			gridViewTextBoxColumn4.HeaderText = "ContactTitle"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.IsVisible = False
			gridViewTextBoxColumn4.Name = "ContactTitle"
			gridViewTextBoxColumn4.Width = 100
			gridViewTextBoxColumn5.FieldName = "Address"
			gridViewTextBoxColumn5.HeaderText = "Address"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.IsVisible = False
			gridViewTextBoxColumn5.Name = "Address"
			gridViewTextBoxColumn5.Width = 100
			gridViewTextBoxColumn6.FieldName = "City"
			gridViewTextBoxColumn6.HeaderText = "City"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "City"
			gridViewTextBoxColumn6.Width = 200
			gridViewTextBoxColumn7.FieldName = "Region"
			gridViewTextBoxColumn7.HeaderText = "Region"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.IsVisible = False
			gridViewTextBoxColumn7.Name = "Region"
			gridViewTextBoxColumn7.Width = 100
			gridViewTextBoxColumn8.FieldName = "PostalCode"
			gridViewTextBoxColumn8.HeaderText = "PostalCode"
			gridViewTextBoxColumn8.IsAutoGenerated = True
			gridViewTextBoxColumn8.IsVisible = False
			gridViewTextBoxColumn8.Name = "PostalCode"
			gridViewTextBoxColumn9.FieldName = "Country"
			gridViewTextBoxColumn9.HeaderText = "Country"
			gridViewTextBoxColumn9.IsAutoGenerated = True
			gridViewTextBoxColumn9.Name = "Country"
			gridViewTextBoxColumn9.Width = 150
			gridViewTextBoxColumn10.FieldName = "Phone"
			gridViewTextBoxColumn10.HeaderText = "Phone"
			gridViewTextBoxColumn10.IsAutoGenerated = True
			gridViewTextBoxColumn10.Name = "Phone"
			gridViewTextBoxColumn10.Width = 100
			gridViewTextBoxColumn11.FieldName = "Fax"
			gridViewTextBoxColumn11.HeaderText = "Fax"
			gridViewTextBoxColumn11.IsAutoGenerated = True
			gridViewTextBoxColumn11.IsVisible = False
			gridViewTextBoxColumn11.Name = "Fax"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn6)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn7)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn11)
			Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource
			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(928, 527)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.ThemeName = "ControlDefault"
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.BackColor = System.Drawing.Color.White
			Me.radSpinEditor1.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditor1.Location = New System.Drawing.Point(81, 36)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditor1.ShowBorder = True
			Me.radSpinEditor1.Size = New System.Drawing.Size(55, 20)
			Me.radSpinEditor1.TabIndex = 2
			Me.radSpinEditor1.ThemeName = "ControlDefault"
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 1, 0, 0, -2147483648})
'			Me.radSpinEditor1.ValueChanged += New System.EventHandler(Me.radSpinEditor1_ValueChanged);
			' 
			' radSpinEditor2
			' 
			Me.radSpinEditor2.BackColor = System.Drawing.Color.White
			Me.radSpinEditor2.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditor2.Location = New System.Drawing.Point(81, 62)
			Me.radSpinEditor2.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.radSpinEditor2.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditor2.Name = "radSpinEditor2"
			' 
			' 
			' 
			Me.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinEditor2.ShowBorder = True
			Me.radSpinEditor2.Size = New System.Drawing.Size(55, 20)
			Me.radSpinEditor2.TabIndex = 3
			Me.radSpinEditor2.Value = New Decimal(New Integer() { 1, 0, 0, -2147483648})
'			Me.radSpinEditor2.ValueChanged += New System.EventHandler(Me.radSpinEditor2_ValueChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Location = New System.Drawing.Point(6, 36)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(69, 13)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Cell Spacing:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(6, 62)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(74, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Row Spacing:"
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' radGroupViewOpts
			' 
			Me.radGroupViewOpts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupViewOpts.Controls.Add(Me.radGroupSpacing)
			Me.radGroupViewOpts.Controls.Add(Me.radRadioGCView)
			Me.radGroupViewOpts.Controls.Add(Me.radRadioHTML)
			Me.radGroupViewOpts.Controls.Add(Me.radRadioTable)
			Me.radGroupViewOpts.FooterImageIndex = -1
			Me.radGroupViewOpts.FooterImageKey = ""
			Me.radGroupViewOpts.FooterText = ""
			Me.radGroupViewOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupViewOpts.HeaderImageIndex = -1
			Me.radGroupViewOpts.HeaderImageKey = ""
			Me.radGroupViewOpts.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupViewOpts.HeaderText = "View Options"
			Me.radGroupViewOpts.Location = New System.Drawing.Point(10, 6)
			Me.radGroupViewOpts.Name = "radGroupViewOpts"
			' 
			' 
			' 
			Me.radGroupViewOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupViewOpts.Size = New System.Drawing.Size(180, 196)
			Me.radGroupViewOpts.TabIndex = 0
			Me.radGroupViewOpts.Text = "View Options"
			' 
			' radGroupSpacing
			' 
			Me.radGroupSpacing.Controls.Add(Me.label1)
			Me.radGroupSpacing.Controls.Add(Me.radSpinEditor1)
			Me.radGroupSpacing.Controls.Add(Me.radSpinEditor2)
			Me.radGroupSpacing.Controls.Add(Me.label2)
			Me.radGroupSpacing.FooterImageIndex = -1
			Me.radGroupSpacing.FooterImageKey = ""
			Me.radGroupSpacing.FooterText = ""
			Me.radGroupSpacing.ForeColor = System.Drawing.Color.Black
			Me.radGroupSpacing.HeaderImageIndex = -1
			Me.radGroupSpacing.HeaderImageKey = ""
			Me.radGroupSpacing.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupSpacing.HeaderText = "Spacing Options"
			Me.radGroupSpacing.Location = New System.Drawing.Point(9, 87)
			Me.radGroupSpacing.Name = "radGroupSpacing"
			' 
			' 
			' 
			Me.radGroupSpacing.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSpacing.Size = New System.Drawing.Size(143, 98)
			Me.radGroupSpacing.TabIndex = 8
			Me.radGroupSpacing.Text = "Spacing Options"
			' 
			' radRadioGCView
			' 
			Me.radRadioGCView.AllowShowFocusCues = True
			Me.radRadioGCView.ForeColor = System.Drawing.Color.Black
			Me.radRadioGCView.Location = New System.Drawing.Point(12, 66)
			Me.radRadioGCView.Name = "radRadioGCView"
			Me.radRadioGCView.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioGCView.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioGCView.Size = New System.Drawing.Size(127, 16)
			Me.radRadioGCView.TabIndex = 7
			Me.radRadioGCView.Text = "Column Groups View"
'			Me.radRadioGCView.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioTable_ToggleStateChanged);
			' 
			' radRadioHTML
			' 
			Me.radRadioHTML.AllowShowFocusCues = True
			Me.radRadioHTML.ForeColor = System.Drawing.Color.Black
			Me.radRadioHTML.Location = New System.Drawing.Point(12, 45)
			Me.radRadioHTML.Name = "radRadioHTML"
			Me.radRadioHTML.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioHTML.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioHTML.Size = New System.Drawing.Size(79, 16)
			Me.radRadioHTML.TabIndex = 7
			Me.radRadioHTML.Text = "HTML View"
'			Me.radRadioHTML.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioTable_ToggleStateChanged);
			' 
			' radRadioTable
			' 
			Me.radRadioTable.AllowShowFocusCues = True
			Me.radRadioTable.ForeColor = System.Drawing.Color.Black
			Me.radRadioTable.Location = New System.Drawing.Point(12, 24)
			Me.radRadioTable.Name = "radRadioTable"
			Me.radRadioTable.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioTable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioTable.Size = New System.Drawing.Size(76, 16)
			Me.radRadioTable.TabIndex = 7
			Me.radRadioTable.Text = "Table View"
'			Me.radRadioTable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioTable_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(928, 527)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupViewOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupViewOpts.ResumeLayout(False)
			Me.radGroupViewOpts.PerformLayout()
			CType(Me.radGroupSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSpacing.ResumeLayout(False)
			Me.radGroupSpacing.PerformLayout()
			CType(Me.radRadioGCView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioHTML, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioTable, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private radGroupViewOpts As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioGCView As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioHTML As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioTable As Telerik.WinControls.UI.RadRadioButton
		Private radGroupSpacing As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace
