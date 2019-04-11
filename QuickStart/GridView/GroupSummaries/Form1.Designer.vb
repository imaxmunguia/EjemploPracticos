Imports Microsoft.VisualBasic
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.GridView.GroupSummaries
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
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radGridViewDemo = New Telerik.WinControls.UI.RadGridView()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSetGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radComboFunction = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboPosition = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBox3 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radButtonAddSummary = New Telerik.WinControls.UI.RadButton()
			Me.radComboColumn = New Telerik.WinControls.UI.RadDropDownList()
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.radLblTip = New Telerik.WinControls.UI.RadLabel()
			Me.radLblFuncName = New Telerik.WinControls.UI.RadLabel()
			Me.radLblColumn = New Telerik.WinControls.UI.RadLabel()
			Me.radLblPosition = New Telerik.WinControls.UI.RadLabel()
			Me.radLblIn = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupOptions = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxPinRow = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridViewDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewDemo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSetGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboFunction, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonAddSummary, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboColumn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblTip, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblFuncName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblColumn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblIn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupOptions.SuspendLayout()
			CType(Me.radCheckBoxPinRow, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupOptions)
			Me.settingsPanel.Controls.Add(Me.radLblTip)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(751, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radLblTip, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupOptions, 0)
			' 
			' radGridViewDemo
			' 
			Me.radGridViewDemo.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridViewDemo.ForeColor = System.Drawing.Color.Black
			Me.radGridViewDemo.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridViewDemo.MasterTemplate.Caption = "Products"
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.FormatString = "{0: ddd, MM/dd}"
			gridViewTextBoxColumn1.HeaderText = "Customer ID"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewTextBoxColumn1.Width = 117
			gridViewDateTimeColumn1.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn1.FieldName = "OrderDate"
			gridViewDateTimeColumn1.HeaderText = "Order Date"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "OrderDate"
			gridViewDateTimeColumn1.Width = 117
			gridViewDateTimeColumn2.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn2.FieldName = "ShippedDate"
			gridViewDateTimeColumn2.HeaderText = "Shipped Date"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.Name = "ShippedDate"
			gridViewDateTimeColumn2.Width = 117
			gridViewDecimalColumn1.DataType = GetType(Decimal)
			gridViewDecimalColumn1.FieldName = "Freight"
			gridViewDecimalColumn1.HeaderText = "Freight"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.Name = "Freight"
			gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn1.Width = 117
			gridViewTextBoxColumn2.FieldName = "ShipName"
			gridViewTextBoxColumn2.HeaderText = "Ship Name"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "ShipName"
			gridViewTextBoxColumn2.Width = 117
			gridViewTextBoxColumn3.FieldName = "ShipAddress"
			gridViewTextBoxColumn3.HeaderText = "Ship Address"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "ShipAddress"
			gridViewTextBoxColumn3.Width = 117
			gridViewTextBoxColumn4.FieldName = "ShipCity"
			gridViewTextBoxColumn4.HeaderText = "Ship City"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "ShipCity"
			gridViewTextBoxColumn4.Width = 117
			gridViewTextBoxColumn5.FieldName = "ShipCountry"
			gridViewTextBoxColumn5.HeaderText = "Ship Country"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "ShipCountry"
			gridViewTextBoxColumn5.Width = 119
			Me.radGridViewDemo.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewDateTimeColumn1, gridViewDateTimeColumn2, gridViewDecimalColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5})
			Me.radGridViewDemo.MasterTemplate.DataSource = Me.ordersBindingSource
			Me.radGridViewDemo.Name = "radGridViewDemo"
			Me.radGridViewDemo.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridViewDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridViewDemo.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridViewDemo.Size = New System.Drawing.Size(952, 725)
			Me.radGridViewDemo.TabIndex = 5
			Me.radGridViewDemo.TabStop = False
			Me.radGridViewDemo.Text = "radGridView1"
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSetGridView
			' 
			' nwindDataSetGridView
			' 
			Me.nwindDataSetGridView.DataSetName = "NwindDataSetGridView"
			Me.nwindDataSetGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radComboFunction
			' 
			Me.radComboFunction.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radComboFunction.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboFunction.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboFunction.ForeColor = System.Drawing.Color.Black
			Me.radComboFunction.Location = New System.Drawing.Point(21, 60)
			Me.radComboFunction.Name = "radComboFunction"
			' 
			' 
			' 
			Me.radComboFunction.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboFunction.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboFunction.Size = New System.Drawing.Size(138, 20)
			Me.radComboFunction.TabIndex = 0
			Me.radComboFunction.TabStop = False
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "Group Header Row"
			' 
			' radComboPosition
			' 
			Me.radComboPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radComboPosition.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboPosition.ForeColor = System.Drawing.Color.Black
			Me.radComboPosition.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem2, Me.radComboBoxItem3, Me.radComboBoxItem4}))
			Me.radComboPosition.Location = New System.Drawing.Point(21, 201)
			Me.radComboPosition.Name = "radComboPosition"
			' 
			' 
			' 
			Me.radComboPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboPosition.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboPosition.Size = New System.Drawing.Size(138, 20)
			Me.radComboPosition.TabIndex = 2
			Me.radComboPosition.TabStop = False
'			Me.radComboPosition.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox2_SelectedIndexChanged);
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "Group Header Row"
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "Top Summary Rows"
			' 
			' radComboBoxItem4
			' 
			Me.radComboBoxItem4.Text = "Bottom Summary Rows"
			' 
			' radComboBox3
			' 
			Me.radComboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radComboBox3.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox3.ForeColor = System.Drawing.Color.Black
			Me.radComboBox3.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem6, Me.radComboBoxItem5}))
			Me.radComboBox3.Location = New System.Drawing.Point(21, 265)
			Me.radComboBox3.Name = "radComboBox3"
			' 
			' 
			' 
			Me.radComboBox3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBox3.Size = New System.Drawing.Size(138, 20)
			Me.radComboBox3.TabIndex = 3
			Me.radComboBox3.TabStop = False
			' 
			' radComboBoxItem6
			' 
			Me.radComboBoxItem6.Text = "Row 1"
			' 
			' radComboBoxItem5
			' 
			Me.radComboBoxItem5.Text = "New Row"
			' 
			' radButtonAddSummary
			' 
			Me.radButtonAddSummary.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonAddSummary.Location = New System.Drawing.Point(21, 306)
			Me.radButtonAddSummary.Name = "radButtonAddSummary"
			Me.radButtonAddSummary.Size = New System.Drawing.Size(138, 21)
			Me.radButtonAddSummary.TabIndex = 4
			Me.radButtonAddSummary.Text = "Add"
'			Me.radButtonAddSummary.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radComboColumn
			' 
			Me.radComboColumn.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radComboColumn.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboColumn.ForeColor = System.Drawing.Color.Black
			Me.radComboColumn.Location = New System.Drawing.Point(21, 124)
			Me.radComboColumn.Name = "radComboColumn"
			' 
			' 
			' 
			Me.radComboColumn.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboColumn.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboColumn.Size = New System.Drawing.Size(138, 20)
			Me.radComboColumn.TabIndex = 1
			Me.radComboColumn.TabStop = False
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' radLblTip
			' 
			Me.radLblTip.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLblTip.AutoSize = False
			Me.radLblTip.ForeColor = System.Drawing.Color.Black
            Me.radLblTip.Location = New System.Drawing.Point(10, 386)
            Me.radLblTip.MaximumSize = New System.Drawing.Size(175, 0)
			Me.radLblTip.Name = "radLblTip"
			' 
			' 
			' 
			Me.radLblTip.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblTip.Size = New System.Drawing.Size(180, 106)
			Me.radLblTip.TabIndex = 9
			Me.radLblTip.Text = "The grid is initially grouped by Customer ID and the sum of each customer's order" & "s' freight is calculated." & Constants.vbCrLf & Constants.vbCrLf & "You can use the controls below in order to apply cu" & "stom group summaries."
			' 
			' radLblFuncName
			' 
			Me.radLblFuncName.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLblFuncName.ForeColor = System.Drawing.Color.Black
			Me.radLblFuncName.Location = New System.Drawing.Point(21, 31)
			Me.radLblFuncName.Name = "radLblFuncName"
			' 
			' 
			' 
			Me.radLblFuncName.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblFuncName.Size = New System.Drawing.Size(94, 18)
			Me.radLblFuncName.TabIndex = 10
			Me.radLblFuncName.Text = "1. Select function:"
			' 
			' radLblColumn
			' 
			Me.radLblColumn.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLblColumn.ForeColor = System.Drawing.Color.Black
			Me.radLblColumn.Location = New System.Drawing.Point(21, 95)
			Me.radLblColumn.Name = "radLblColumn"
			' 
			' 
			' 
			Me.radLblColumn.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblColumn.Size = New System.Drawing.Size(90, 18)
			Me.radLblColumn.TabIndex = 10
			Me.radLblColumn.Text = "2. Select column:"
			' 
			' radLblPosition
			' 
			Me.radLblPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLblPosition.ForeColor = System.Drawing.Color.Black
			Me.radLblPosition.Location = New System.Drawing.Point(21, 159)
			Me.radLblPosition.Name = "radLblPosition"
			' 
			' 
			' 
			Me.radLblPosition.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblPosition.Size = New System.Drawing.Size(132, 33)
			Me.radLblPosition.TabIndex = 10
			Me.radLblPosition.Text = "3. Select location for the" & Constants.vbCrLf & "summary:"
			' 
			' radLblIn
			' 
			Me.radLblIn.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLblIn.ForeColor = System.Drawing.Color.Black
			Me.radLblIn.Location = New System.Drawing.Point(21, 236)
			Me.radLblIn.Name = "radLblIn"
			' 
			' 
			' 
			Me.radLblIn.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblIn.Size = New System.Drawing.Size(102, 18)
			Me.radLblIn.TabIndex = 10
			Me.radLblIn.Text = "4. Add summary in:"
			' 
			' radGroupOptions
			' 
			Me.radGroupOptions.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupOptions.Controls.Add(Me.radCheckBoxPinRow)
			Me.radGroupOptions.Controls.Add(Me.radLblFuncName)
			Me.radGroupOptions.Controls.Add(Me.radLblIn)
			Me.radGroupOptions.Controls.Add(Me.radComboBox3)
			Me.radGroupOptions.Controls.Add(Me.radLblPosition)
			Me.radGroupOptions.Controls.Add(Me.radComboColumn)
			Me.radGroupOptions.Controls.Add(Me.radLblColumn)
			Me.radGroupOptions.Controls.Add(Me.radComboPosition)
			Me.radGroupOptions.Controls.Add(Me.radButtonAddSummary)
			Me.radGroupOptions.Controls.Add(Me.radComboFunction)
			Me.radGroupOptions.FooterImageIndex = -1
			Me.radGroupOptions.FooterImageKey = ""
			Me.radGroupOptions.ForeColor = System.Drawing.Color.Black
			Me.radGroupOptions.HeaderImageIndex = -1
			Me.radGroupOptions.HeaderImageKey = ""
			Me.radGroupOptions.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupOptions.HeaderText = "Options"
			Me.radGroupOptions.Location = New System.Drawing.Point(10, 6)
			Me.radGroupOptions.Name = "radGroupOptions"
			Me.radGroupOptions.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupOptions.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupOptions.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupOptions.Size = New System.Drawing.Size(180, 374)
			Me.radGroupOptions.TabIndex = 0
			Me.radGroupOptions.Text = "Options"
			' 
			' radCheckBoxPinRow
			' 
			Me.radCheckBoxPinRow.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxPinRow.Location = New System.Drawing.Point(21, 343)
			Me.radCheckBoxPinRow.Name = "radCheckBoxPinRow"
			' 
			' 
			' 
			Me.radCheckBoxPinRow.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxPinRow.Size = New System.Drawing.Size(80, 18)
			Me.radCheckBoxPinRow.TabIndex = 11
			Me.radCheckBoxPinRow.Text = "Show Totals"
'			Me.radCheckBoxPinRow.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxPinRow_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridViewDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(952, 725)
			Me.Controls.SetChildIndex(Me.radGridViewDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridViewDemo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSetGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboFunction, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonAddSummary, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboColumn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblTip, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblFuncName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblColumn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblIn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupOptions.ResumeLayout(False)
			Me.radGroupOptions.PerformLayout()
			CType(Me.radCheckBoxPinRow, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridViewDemo As Telerik.WinControls.UI.RadGridView
		Private nwindDataSetGridView As NorthwindDataSet
		Private radComboFunction As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private WithEvents radComboPosition As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBox3 As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem6 As Telerik.WinControls.UI.RadListDataItem
		Private WithEvents radButtonAddSummary As Telerik.WinControls.UI.RadButton
		Private radComboColumn As Telerik.WinControls.UI.RadDropDownList
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As OrdersTableAdapter
		Private radLblTip As Telerik.WinControls.UI.RadLabel
		Private radLblFuncName As Telerik.WinControls.UI.RadLabel
		Private radLblColumn As Telerik.WinControls.UI.RadLabel
		Private radLblPosition As Telerik.WinControls.UI.RadLabel
		Private radLblIn As Telerik.WinControls.UI.RadLabel
		Private radGroupOptions As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckBoxPinRow As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
