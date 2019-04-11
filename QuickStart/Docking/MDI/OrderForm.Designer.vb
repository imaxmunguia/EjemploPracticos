Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class OrderForm
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
			Dim orderIDLabel As System.Windows.Forms.Label
			Dim customerIDLabel As System.Windows.Forms.Label
			Dim employeeIDLabel As System.Windows.Forms.Label
			Dim orderDateLabel As System.Windows.Forms.Label
			Dim requiredDateLabel As System.Windows.Forms.Label
			Dim shippedDateLabel As System.Windows.Forms.Label
			Dim shipViaLabel As System.Windows.Forms.Label
			Dim freightLabel As System.Windows.Forms.Label
			Dim shipNameLabel As System.Windows.Forms.Label
			Dim shipAddressLabel As System.Windows.Forms.Label
			Dim shipCityLabel As System.Windows.Forms.Label
			Dim shipRegionLabel As System.Windows.Forms.Label
			Dim shipPostalCodeLabel As System.Windows.Forms.Label
			Dim shipCountryLabel As System.Windows.Forms.Label
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn3 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn4 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.ordersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
			Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
			Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
			Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.orderIDTextBox = New System.Windows.Forms.TextBox()
			Me.customerIDTextBox = New System.Windows.Forms.TextBox()
			Me.employeeIDTextBox = New System.Windows.Forms.TextBox()
			Me.orderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
			Me.requiredDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
			Me.shippedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
			Me.shipViaTextBox = New System.Windows.Forms.TextBox()
			Me.freightTextBox = New System.Windows.Forms.TextBox()
			Me.shipNameTextBox = New System.Windows.Forms.TextBox()
			Me.shipAddressTextBox = New System.Windows.Forms.TextBox()
			Me.shipCityTextBox = New System.Windows.Forms.TextBox()
			Me.shipRegionTextBox = New System.Windows.Forms.TextBox()
			Me.shipPostalCodeTextBox = New System.Windows.Forms.TextBox()
			Me.shipCountryTextBox = New System.Windows.Forms.TextBox()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			orderIDLabel = New System.Windows.Forms.Label()
			customerIDLabel = New System.Windows.Forms.Label()
			employeeIDLabel = New System.Windows.Forms.Label()
			orderDateLabel = New System.Windows.Forms.Label()
			requiredDateLabel = New System.Windows.Forms.Label()
			shippedDateLabel = New System.Windows.Forms.Label()
			shipViaLabel = New System.Windows.Forms.Label()
			freightLabel = New System.Windows.Forms.Label()
			shipNameLabel = New System.Windows.Forms.Label()
			shipAddressLabel = New System.Windows.Forms.Label()
			shipCityLabel = New System.Windows.Forms.Label()
			shipRegionLabel = New System.Windows.Forms.Label()
			shipPostalCodeLabel = New System.Windows.Forms.Label()
			shipCountryLabel = New System.Windows.Forms.Label()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ordersBindingNavigator.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' orderIDLabel
			' 
			orderIDLabel.AutoSize = True
			orderIDLabel.Location = New System.Drawing.Point(33, 393)
			orderIDLabel.Name = "orderIDLabel"
			orderIDLabel.Size = New System.Drawing.Size(50, 13)
			orderIDLabel.TabIndex = 1
			orderIDLabel.Text = "Order ID:"
			' 
			' customerIDLabel
			' 
			customerIDLabel.AutoSize = True
			customerIDLabel.Location = New System.Drawing.Point(15, 419)
			customerIDLabel.Name = "customerIDLabel"
			customerIDLabel.Size = New System.Drawing.Size(68, 13)
			customerIDLabel.TabIndex = 3
			customerIDLabel.Text = "Customer ID:"
			' 
			' employeeIDLabel
			' 
			employeeIDLabel.AutoSize = True
			employeeIDLabel.Location = New System.Drawing.Point(13, 445)
			employeeIDLabel.Name = "employeeIDLabel"
			employeeIDLabel.Size = New System.Drawing.Size(70, 13)
			employeeIDLabel.TabIndex = 5
			employeeIDLabel.Text = "Employee ID:"
			' 
			' orderDateLabel
			' 
			orderDateLabel.AutoSize = True
			orderDateLabel.Location = New System.Drawing.Point(21, 472)
			orderDateLabel.Name = "orderDateLabel"
			orderDateLabel.Size = New System.Drawing.Size(62, 13)
			orderDateLabel.TabIndex = 7
			orderDateLabel.Text = "Order Date:"
			' 
			' requiredDateLabel
			' 
			requiredDateLabel.AutoSize = True
			requiredDateLabel.Location = New System.Drawing.Point(4, 498)
			requiredDateLabel.Name = "requiredDateLabel"
			requiredDateLabel.Size = New System.Drawing.Size(79, 13)
			requiredDateLabel.TabIndex = 9
			requiredDateLabel.Text = "Required Date:"
			' 
			' shippedDateLabel
			' 
			shippedDateLabel.AutoSize = True
			shippedDateLabel.Location = New System.Drawing.Point(8, 524)
			shippedDateLabel.Name = "shippedDateLabel"
			shippedDateLabel.Size = New System.Drawing.Size(75, 13)
			shippedDateLabel.TabIndex = 11
			shippedDateLabel.Text = "Shipped Date:"
			' 
			' shipViaLabel
			' 
			shipViaLabel.AutoSize = True
			shipViaLabel.Location = New System.Drawing.Point(34, 549)
			shipViaLabel.Name = "shipViaLabel"
			shipViaLabel.Size = New System.Drawing.Size(49, 13)
			shipViaLabel.TabIndex = 13
			shipViaLabel.Text = "Ship Via:"
			' 
			' freightLabel
			' 
			freightLabel.AutoSize = True
			freightLabel.Location = New System.Drawing.Point(356, 393)
			freightLabel.Name = "freightLabel"
			freightLabel.Size = New System.Drawing.Size(42, 13)
			freightLabel.TabIndex = 15
			freightLabel.Text = "Freight:"
			' 
			' shipNameLabel
			' 
			shipNameLabel.AutoSize = True
			shipNameLabel.Location = New System.Drawing.Point(336, 419)
			shipNameLabel.Name = "shipNameLabel"
			shipNameLabel.Size = New System.Drawing.Size(62, 13)
			shipNameLabel.TabIndex = 17
			shipNameLabel.Text = "Ship Name:"
			' 
			' shipAddressLabel
			' 
			shipAddressLabel.AutoSize = True
			shipAddressLabel.Location = New System.Drawing.Point(326, 445)
			shipAddressLabel.Name = "shipAddressLabel"
			shipAddressLabel.Size = New System.Drawing.Size(72, 13)
			shipAddressLabel.TabIndex = 19
			shipAddressLabel.Text = "Ship Address:"
			' 
			' shipCityLabel
			' 
			shipCityLabel.AutoSize = True
			shipCityLabel.Location = New System.Drawing.Point(347, 471)
			shipCityLabel.Name = "shipCityLabel"
			shipCityLabel.Size = New System.Drawing.Size(51, 13)
			shipCityLabel.TabIndex = 21
			shipCityLabel.Text = "Ship City:"
			' 
			' shipRegionLabel
			' 
			shipRegionLabel.AutoSize = True
			shipRegionLabel.Location = New System.Drawing.Point(330, 497)
			shipRegionLabel.Name = "shipRegionLabel"
			shipRegionLabel.Size = New System.Drawing.Size(68, 13)
			shipRegionLabel.TabIndex = 23
			shipRegionLabel.Text = "Ship Region:"
			' 
			' shipPostalCodeLabel
			' 
			shipPostalCodeLabel.AutoSize = True
			shipPostalCodeLabel.Location = New System.Drawing.Point(307, 523)
			shipPostalCodeLabel.Name = "shipPostalCodeLabel"
			shipPostalCodeLabel.Size = New System.Drawing.Size(91, 13)
			shipPostalCodeLabel.TabIndex = 25
			shipPostalCodeLabel.Text = "Ship Postal Code:"
			' 
			' shipCountryLabel
			' 
			shipCountryLabel.AutoSize = True
			shipCountryLabel.Location = New System.Drawing.Point(328, 549)
			shipCountryLabel.Name = "shipCountryLabel"
			shipCountryLabel.Size = New System.Drawing.Size(70, 13)
			shipCountryLabel.TabIndex = 27
			shipCountryLabel.Text = "Ship Country:"
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' ordersBindingNavigator
			' 
			Me.ordersBindingNavigator.AddNewItem = Nothing
			Me.ordersBindingNavigator.BindingSource = Me.ordersBindingSource
			Me.ordersBindingNavigator.CountItem = Me.bindingNavigatorCountItem
			Me.ordersBindingNavigator.DeleteItem = Nothing
			Me.ordersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
			Me.ordersBindingNavigator.Location = New System.Drawing.Point(0, 0)
			Me.ordersBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
			Me.ordersBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
			Me.ordersBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
			Me.ordersBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
			Me.ordersBindingNavigator.Name = "ordersBindingNavigator"
			Me.ordersBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
			Me.ordersBindingNavigator.Size = New System.Drawing.Size(632, 25)
			Me.ordersBindingNavigator.TabIndex = 0
			Me.ordersBindingNavigator.Text = "bindingNavigator1"
			' 
			' bindingNavigatorCountItem
			' 
			Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
			Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
			Me.bindingNavigatorCountItem.Text = "of {0}"
			Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
			' 
			' bindingNavigatorMoveFirstItem
			' 
			Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveFirstItem.Image = (CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
			Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveFirstItem.Text = "Move first"
			' 
			' bindingNavigatorMovePreviousItem
			' 
			Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMovePreviousItem.Image = (CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
			Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
			' 
			' bindingNavigatorSeparator
			' 
			Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
			Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
			' 
			' bindingNavigatorPositionItem
			' 
			Me.bindingNavigatorPositionItem.AccessibleName = "Position"
			Me.bindingNavigatorPositionItem.AutoSize = False
			Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
			Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
			Me.bindingNavigatorPositionItem.Text = "0"
			Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
			' 
			' bindingNavigatorSeparator1
			' 
			Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
			Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' bindingNavigatorMoveNextItem
			' 
			Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveNextItem.Image = (CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
			Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveNextItem.Text = "Move next"
			' 
			' bindingNavigatorMoveLastItem
			' 
			Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveLastItem.Image = (CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
			Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveLastItem.Text = "Move last"
			' 
			' bindingNavigatorSeparator2
			' 
			Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
			Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' orderIDTextBox
			' 
			Me.orderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "OrderID", True))
			Me.orderIDTextBox.Location = New System.Drawing.Point(89, 390)
			Me.orderIDTextBox.Name = "orderIDTextBox"
			Me.orderIDTextBox.Size = New System.Drawing.Size(200, 20)
			Me.orderIDTextBox.TabIndex = 2
			' 
			' customerIDTextBox
			' 
			Me.customerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "CustomerID", True))
			Me.customerIDTextBox.Location = New System.Drawing.Point(89, 416)
			Me.customerIDTextBox.Name = "customerIDTextBox"
			Me.customerIDTextBox.Size = New System.Drawing.Size(200, 20)
			Me.customerIDTextBox.TabIndex = 4
			' 
			' employeeIDTextBox
			' 
			Me.employeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "EmployeeID", True))
			Me.employeeIDTextBox.Location = New System.Drawing.Point(89, 442)
			Me.employeeIDTextBox.Name = "employeeIDTextBox"
			Me.employeeIDTextBox.Size = New System.Drawing.Size(200, 20)
			Me.employeeIDTextBox.TabIndex = 6
			' 
			' orderDateDateTimePicker
			' 
			Me.orderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ordersBindingSource, "OrderDate", True))
			Me.orderDateDateTimePicker.Location = New System.Drawing.Point(89, 468)
			Me.orderDateDateTimePicker.Name = "orderDateDateTimePicker"
			Me.orderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
			Me.orderDateDateTimePicker.TabIndex = 8
			' 
			' requiredDateDateTimePicker
			' 
			Me.requiredDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ordersBindingSource, "RequiredDate", True))
			Me.requiredDateDateTimePicker.Location = New System.Drawing.Point(89, 494)
			Me.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker"
			Me.requiredDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
			Me.requiredDateDateTimePicker.TabIndex = 10
			' 
			' shippedDateDateTimePicker
			' 
			Me.shippedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ordersBindingSource, "ShippedDate", True))
			Me.shippedDateDateTimePicker.Location = New System.Drawing.Point(89, 520)
			Me.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker"
			Me.shippedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
			Me.shippedDateDateTimePicker.TabIndex = 12
			' 
			' shipViaTextBox
			' 
			Me.shipViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipVia", True))
			Me.shipViaTextBox.Location = New System.Drawing.Point(89, 546)
			Me.shipViaTextBox.Name = "shipViaTextBox"
			Me.shipViaTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipViaTextBox.TabIndex = 14
			' 
			' freightTextBox
			' 
			Me.freightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "Freight", True))
			Me.freightTextBox.Location = New System.Drawing.Point(404, 390)
			Me.freightTextBox.Name = "freightTextBox"
			Me.freightTextBox.Size = New System.Drawing.Size(200, 20)
			Me.freightTextBox.TabIndex = 16
			' 
			' shipNameTextBox
			' 
			Me.shipNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipName", True))
			Me.shipNameTextBox.Location = New System.Drawing.Point(404, 416)
			Me.shipNameTextBox.Name = "shipNameTextBox"
			Me.shipNameTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipNameTextBox.TabIndex = 18
			' 
			' shipAddressTextBox
			' 
			Me.shipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipAddress", True))
			Me.shipAddressTextBox.Location = New System.Drawing.Point(404, 442)
			Me.shipAddressTextBox.Name = "shipAddressTextBox"
			Me.shipAddressTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipAddressTextBox.TabIndex = 20
			' 
			' shipCityTextBox
			' 
			Me.shipCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipCity", True))
			Me.shipCityTextBox.Location = New System.Drawing.Point(404, 468)
			Me.shipCityTextBox.Name = "shipCityTextBox"
			Me.shipCityTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipCityTextBox.TabIndex = 22
			' 
			' shipRegionTextBox
			' 
			Me.shipRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipRegion", True))
			Me.shipRegionTextBox.Location = New System.Drawing.Point(404, 494)
			Me.shipRegionTextBox.Name = "shipRegionTextBox"
			Me.shipRegionTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipRegionTextBox.TabIndex = 24
			' 
			' shipPostalCodeTextBox
			' 
			Me.shipPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipPostalCode", True))
			Me.shipPostalCodeTextBox.Location = New System.Drawing.Point(404, 520)
			Me.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox"
			Me.shipPostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipPostalCodeTextBox.TabIndex = 26
			' 
			' shipCountryTextBox
			' 
			Me.shipCountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ordersBindingSource, "ShipCountry", True))
			Me.shipCountryTextBox.Location = New System.Drawing.Point(404, 546)
			Me.shipCountryTextBox.Name = "shipCountryTextBox"
			Me.shipCountryTextBox.Size = New System.Drawing.Size(200, 20)
			Me.shipCountryTextBox.TabIndex = 28
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radGridView1.Location = New System.Drawing.Point(0, 25)
			' 
			' 
			' 
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "OrderID"
			gridViewDecimalColumn1.HeaderText = "OrderID"
			gridViewDecimalColumn1.Name = "OrderID"
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.HeaderText = "CustomerID"
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "EmployeeID"
			gridViewDecimalColumn2.HeaderText = "EmployeeID"
			gridViewDecimalColumn2.Name = "EmployeeID"
			gridViewDateTimeColumn1.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn1.FieldName = "OrderDate"
			gridViewDateTimeColumn1.HeaderText = "OrderDate"
			gridViewDateTimeColumn1.Name = "OrderDate"
			gridViewDateTimeColumn2.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn2.FieldName = "RequiredDate"
			gridViewDateTimeColumn2.HeaderText = "RequiredDate"
			gridViewDateTimeColumn2.Name = "RequiredDate"
			gridViewDateTimeColumn3.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn3.FieldName = "ShippedDate"
			gridViewDateTimeColumn3.HeaderText = "ShippedDate"
			gridViewDateTimeColumn3.Name = "ShippedDate"
			gridViewDecimalColumn3.DataType = GetType(Integer)
			gridViewDecimalColumn3.FieldName = "ShipVia"
			gridViewDecimalColumn3.HeaderText = "ShipVia"
			gridViewDecimalColumn3.Name = "ShipVia"
			gridViewDecimalColumn4.DataType = GetType(Decimal)
			gridViewDecimalColumn4.FieldName = "Freight"
			gridViewDecimalColumn4.HeaderText = "Freight"
			gridViewDecimalColumn4.Name = "Freight"
			gridViewTextBoxColumn2.FieldName = "ShipName"
			gridViewTextBoxColumn2.HeaderText = "ShipName"
			gridViewTextBoxColumn2.Name = "ShipName"
			gridViewTextBoxColumn3.FieldName = "ShipAddress"
			gridViewTextBoxColumn3.HeaderText = "ShipAddress"
			gridViewTextBoxColumn3.Name = "ShipAddress"
			gridViewTextBoxColumn4.FieldName = "ShipCity"
			gridViewTextBoxColumn4.HeaderText = "ShipCity"
			gridViewTextBoxColumn4.Name = "ShipCity"
			gridViewTextBoxColumn5.FieldName = "ShipRegion"
			gridViewTextBoxColumn5.HeaderText = "ShipRegion"
			gridViewTextBoxColumn5.Name = "ShipRegion"
			gridViewTextBoxColumn6.FieldName = "ShipPostalCode"
			gridViewTextBoxColumn6.HeaderText = "ShipPostalCode"
			gridViewTextBoxColumn6.Name = "ShipPostalCode"
			gridViewTextBoxColumn7.FieldName = "ShipCountry"
			gridViewTextBoxColumn7.HeaderText = "ShipCountry"
			gridViewTextBoxColumn7.Name = "ShipCountry"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn6)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn7)
			Me.radGridView1.MasterTemplate.DataSource = Me.ordersBindingSource

			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(632, 346)
			Me.radGridView1.TabIndex = 29
			Me.radGridView1.Text = "radGridView1"
			' 
			' OrderForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(632, 584)
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(shipCountryLabel)
			Me.Controls.Add(Me.shipCountryTextBox)
			Me.Controls.Add(shipPostalCodeLabel)
			Me.Controls.Add(Me.shipPostalCodeTextBox)
			Me.Controls.Add(shipRegionLabel)
			Me.Controls.Add(Me.shipRegionTextBox)
			Me.Controls.Add(shipCityLabel)
			Me.Controls.Add(Me.shipCityTextBox)
			Me.Controls.Add(shipAddressLabel)
			Me.Controls.Add(Me.shipAddressTextBox)
			Me.Controls.Add(shipNameLabel)
			Me.Controls.Add(Me.shipNameTextBox)
			Me.Controls.Add(freightLabel)
			Me.Controls.Add(Me.freightTextBox)
			Me.Controls.Add(shipViaLabel)
			Me.Controls.Add(Me.shipViaTextBox)
			Me.Controls.Add(shippedDateLabel)
			Me.Controls.Add(Me.shippedDateDateTimePicker)
			Me.Controls.Add(requiredDateLabel)
			Me.Controls.Add(Me.requiredDateDateTimePicker)
			Me.Controls.Add(orderDateLabel)
			Me.Controls.Add(Me.orderDateDateTimePicker)
			Me.Controls.Add(employeeIDLabel)
			Me.Controls.Add(Me.employeeIDTextBox)
			Me.Controls.Add(customerIDLabel)
			Me.Controls.Add(Me.customerIDTextBox)
			Me.Controls.Add(orderIDLabel)
			Me.Controls.Add(Me.orderIDTextBox)
			Me.Controls.Add(Me.ordersBindingNavigator)
			Me.Name = "OrderForm"
			Me.Text = "OrderForm"
'			Me.Load += New System.EventHandler(Me.OrderForm_Load);
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ordersBindingNavigator.ResumeLayout(False)
			Me.ordersBindingNavigator.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private ordersBindingNavigator As System.Windows.Forms.BindingNavigator
		Private bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
		Private bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
		Private bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private orderIDTextBox As System.Windows.Forms.TextBox
		Private customerIDTextBox As System.Windows.Forms.TextBox
		Private employeeIDTextBox As System.Windows.Forms.TextBox
		Private orderDateDateTimePicker As System.Windows.Forms.DateTimePicker
		Private requiredDateDateTimePicker As System.Windows.Forms.DateTimePicker
		Private shippedDateDateTimePicker As System.Windows.Forms.DateTimePicker
		Private shipViaTextBox As System.Windows.Forms.TextBox
		Private freightTextBox As System.Windows.Forms.TextBox
		Private shipNameTextBox As System.Windows.Forms.TextBox
		Private shipAddressTextBox As System.Windows.Forms.TextBox
		Private shipCityTextBox As System.Windows.Forms.TextBox
		Private shipRegionTextBox As System.Windows.Forms.TextBox
		Private shipPostalCodeTextBox As System.Windows.Forms.TextBox
		Private shipCountryTextBox As System.Windows.Forms.TextBox
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace