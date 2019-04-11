Imports Microsoft.VisualBasic
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.Examples.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.ItemDragDrop
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
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn12 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn13 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn4 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDateTimeColumn3 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn4 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn5 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn5 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn6 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn14 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn15 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn16 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn17 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn18 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn19 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn7 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn20 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn8 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn9 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn21 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn10 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn11 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn12 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn13 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewCheckBoxColumn1 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGridView2 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.radGridView3 = New Telerik.WinControls.UI.RadGridView()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
			Me.textBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.dragModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dragModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.dragModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1093, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 549)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.dragModeCombo, 0)
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radGridView2
			' 
			Me.radGridView2.BackColor = System.Drawing.Color.Transparent
			Me.radGridView2.Cursor = System.Windows.Forms.Cursors.Default
			Me.radGridView2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView2.ForeColor = System.Drawing.Color.Black
			Me.radGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView2.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "EmployeeID"
			gridViewDecimalColumn1.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn1.HeaderText = "EmployeeID"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.IsVisible = False
			gridViewDecimalColumn1.Name = "EmployeeID"
			gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn1.FieldName = "LastName"
			gridViewTextBoxColumn1.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn1.HeaderText = "LastName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.IsVisible = False
			gridViewTextBoxColumn1.Name = "LastName"
			gridViewTextBoxColumn2.FieldName = "FirstName"
			gridViewTextBoxColumn2.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn2.HeaderText = "FirstName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "FirstName"
			gridViewTextBoxColumn3.FieldName = "Title"
			gridViewTextBoxColumn3.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn3.HeaderText = "Title"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "Title"
			gridViewTextBoxColumn4.FieldName = "TitleOfCourtesy"
			gridViewTextBoxColumn4.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn4.HeaderText = "TitleOfCourtesy"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.IsVisible = False
			gridViewTextBoxColumn4.Name = "TitleOfCourtesy"
			gridViewDateTimeColumn1.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn1.FieldName = "BirthDate"
			gridViewDateTimeColumn1.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn1.HeaderText = "BirthDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.IsVisible = False
			gridViewDateTimeColumn1.Name = "BirthDate"
			gridViewDateTimeColumn2.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn2.FieldName = "HireDate"
			gridViewDateTimeColumn2.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn2.HeaderText = "HireDate"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.IsVisible = False
			gridViewDateTimeColumn2.Name = "HireDate"
			gridViewTextBoxColumn5.FieldName = "Address"
			gridViewTextBoxColumn5.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn5.HeaderText = "Address"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "Address"
			gridViewTextBoxColumn6.FieldName = "City"
			gridViewTextBoxColumn6.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn6.HeaderText = "City"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.IsVisible = False
			gridViewTextBoxColumn6.Name = "City"
			gridViewTextBoxColumn7.FieldName = "Region"
			gridViewTextBoxColumn7.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn7.HeaderText = "Region"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.IsVisible = False
			gridViewTextBoxColumn7.Name = "Region"
			gridViewTextBoxColumn8.FieldName = "PostalCode"
			gridViewTextBoxColumn8.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn8.HeaderText = "PostalCode"
			gridViewTextBoxColumn8.IsAutoGenerated = True
			gridViewTextBoxColumn8.IsVisible = False
			gridViewTextBoxColumn8.Name = "PostalCode"
			gridViewTextBoxColumn9.FieldName = "Country"
			gridViewTextBoxColumn9.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn9.HeaderText = "Country"
			gridViewTextBoxColumn9.IsAutoGenerated = True
			gridViewTextBoxColumn9.IsVisible = False
			gridViewTextBoxColumn9.Name = "Country"
			gridViewTextBoxColumn10.FieldName = "HomePhone"
			gridViewTextBoxColumn10.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn10.HeaderText = "HomePhone"
			gridViewTextBoxColumn10.IsAutoGenerated = True
			gridViewTextBoxColumn10.IsVisible = False
			gridViewTextBoxColumn10.Name = "HomePhone"
			gridViewTextBoxColumn11.FieldName = "Extension"
			gridViewTextBoxColumn11.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn11.HeaderText = "Extension"
			gridViewTextBoxColumn11.IsAutoGenerated = True
			gridViewTextBoxColumn11.IsVisible = False
			gridViewTextBoxColumn11.Name = "Extension"
			gridViewImageColumn1.DataType = GetType(Byte())
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.IsVisible = False
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn12.FieldName = "Notes"
			gridViewTextBoxColumn12.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn12.HeaderText = "Notes"
			gridViewTextBoxColumn12.IsAutoGenerated = True
			gridViewTextBoxColumn12.IsVisible = False
			gridViewTextBoxColumn12.Name = "Notes"
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "ReportsTo"
			gridViewDecimalColumn2.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn2.HeaderText = "ReportsTo"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.IsVisible = False
			gridViewDecimalColumn2.Name = "ReportsTo"
			gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			Me.radGridView2.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewDateTimeColumn1, gridViewDateTimeColumn2, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewTextBoxColumn8, gridViewTextBoxColumn9, gridViewTextBoxColumn10, gridViewTextBoxColumn11, gridViewImageColumn1, gridViewTextBoxColumn12, gridViewDecimalColumn2})
			Me.radGridView2.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView2.MasterTemplate.EnableGrouping = False
			Me.radGridView2.Name = "radGridView2"
			Me.radGridView2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' 
			' 
			Me.radGridView2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView2.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView2.ShowGroupPanel = False
			Me.radGridView2.Size = New System.Drawing.Size(607, 418)
			Me.radGridView2.TabIndex = 0
			Me.radGridView2.Text = "radGridViewPreview"
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' radGridView3
			' 
			Me.radGridView3.BackColor = System.Drawing.Color.Transparent
			Me.radGridView3.Cursor = System.Windows.Forms.Cursors.Default
			Me.radGridView3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView3.ForeColor = System.Drawing.Color.Black
			Me.radGridView3.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView3.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			gridViewDecimalColumn3.DataType = GetType(Integer)
			gridViewDecimalColumn3.FieldName = "OrderID"
			gridViewDecimalColumn3.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn3.HeaderText = "OrderID"
			gridViewDecimalColumn3.IsAutoGenerated = True
			gridViewDecimalColumn3.Name = "OrderID"
			gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			gridViewTextBoxColumn13.FieldName = "CustomerID"
			gridViewTextBoxColumn13.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn13.HeaderText = "CustomerID"
			gridViewTextBoxColumn13.IsAutoGenerated = True
			gridViewTextBoxColumn13.IsVisible = False
			gridViewTextBoxColumn13.Name = "CustomerID"
			gridViewDecimalColumn4.DataType = GetType(Integer)
			gridViewDecimalColumn4.FieldName = "EmployeeID"
			gridViewDecimalColumn4.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn4.HeaderText = "EmployeeID"
			gridViewDecimalColumn4.IsAutoGenerated = True
			gridViewDecimalColumn4.IsVisible = False
			gridViewDecimalColumn4.Name = "EmployeeID"
			gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDateTimeColumn3.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn3.FieldName = "OrderDate"
			gridViewDateTimeColumn3.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn3.HeaderText = "OrderDate"
			gridViewDateTimeColumn3.IsAutoGenerated = True
			gridViewDateTimeColumn3.Name = "OrderDate"
			gridViewDateTimeColumn4.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn4.FieldName = "RequiredDate"
			gridViewDateTimeColumn4.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn4.HeaderText = "RequiredDate"
			gridViewDateTimeColumn4.IsAutoGenerated = True
			gridViewDateTimeColumn4.IsVisible = False
			gridViewDateTimeColumn4.Name = "RequiredDate"
			gridViewDateTimeColumn5.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn5.FieldName = "ShippedDate"
			gridViewDateTimeColumn5.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn5.HeaderText = "ShippedDate"
			gridViewDateTimeColumn5.IsAutoGenerated = True
			gridViewDateTimeColumn5.IsVisible = False
			gridViewDateTimeColumn5.Name = "ShippedDate"
			gridViewDecimalColumn5.DataType = GetType(Integer)
			gridViewDecimalColumn5.FieldName = "ShipVia"
			gridViewDecimalColumn5.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn5.HeaderText = "ShipVia"
			gridViewDecimalColumn5.IsAutoGenerated = True
			gridViewDecimalColumn5.IsVisible = False
			gridViewDecimalColumn5.Name = "ShipVia"
			gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn6.DataType = GetType(Decimal)
			gridViewDecimalColumn6.FieldName = "Freight"
			gridViewDecimalColumn6.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn6.HeaderText = "Freight"
			gridViewDecimalColumn6.IsAutoGenerated = True
			gridViewDecimalColumn6.IsVisible = False
			gridViewDecimalColumn6.Name = "Freight"
			gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn14.FieldName = "ShipName"
			gridViewTextBoxColumn14.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn14.HeaderText = "ShipName"
			gridViewTextBoxColumn14.IsAutoGenerated = True
			gridViewTextBoxColumn14.Name = "ShipName"
			gridViewTextBoxColumn15.FieldName = "ShipAddress"
			gridViewTextBoxColumn15.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn15.HeaderText = "ShipAddress"
			gridViewTextBoxColumn15.IsAutoGenerated = True
			gridViewTextBoxColumn15.IsVisible = False
			gridViewTextBoxColumn15.Name = "ShipAddress"
			gridViewTextBoxColumn16.FieldName = "ShipCity"
			gridViewTextBoxColumn16.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn16.HeaderText = "ShipCity"
			gridViewTextBoxColumn16.IsAutoGenerated = True
			gridViewTextBoxColumn16.IsVisible = False
			gridViewTextBoxColumn16.Name = "ShipCity"
			gridViewTextBoxColumn17.FieldName = "ShipRegion"
			gridViewTextBoxColumn17.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn17.HeaderText = "ShipRegion"
			gridViewTextBoxColumn17.IsAutoGenerated = True
			gridViewTextBoxColumn17.IsVisible = False
			gridViewTextBoxColumn17.Name = "ShipRegion"
			gridViewTextBoxColumn18.FieldName = "ShipPostalCode"
			gridViewTextBoxColumn18.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn18.HeaderText = "ShipPostalCode"
			gridViewTextBoxColumn18.IsAutoGenerated = True
			gridViewTextBoxColumn18.IsVisible = False
			gridViewTextBoxColumn18.Name = "ShipPostalCode"
			gridViewTextBoxColumn19.FieldName = "ShipCountry"
			gridViewTextBoxColumn19.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn19.HeaderText = "ShipCountry"
			gridViewTextBoxColumn19.IsAutoGenerated = True
			gridViewTextBoxColumn19.IsVisible = False
			gridViewTextBoxColumn19.Name = "ShipCountry"
			Me.radGridView3.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn3, gridViewTextBoxColumn13, gridViewDecimalColumn4, gridViewDateTimeColumn3, gridViewDateTimeColumn4, gridViewDateTimeColumn5, gridViewDecimalColumn5, gridViewDecimalColumn6, gridViewTextBoxColumn14, gridViewTextBoxColumn15, gridViewTextBoxColumn16, gridViewTextBoxColumn17, gridViewTextBoxColumn18, gridViewTextBoxColumn19})
			Me.radGridView3.MasterTemplate.DataSource = Me.ordersBindingSource
			Me.radGridView3.MasterTemplate.EnableGrouping = False
			Me.radGridView3.Name = "radGridView3"
			Me.radGridView3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' 
			' 
			Me.radGridView3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView3.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView3.ShowGroupPanel = False
			Me.radGridView3.Size = New System.Drawing.Size(607, 418)
			Me.radGridView3.TabIndex = 1
			Me.radGridView3.Text = "radGridViewPreview"
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.northwindDataSet
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButtonClear)
			Me.radGroupBox1.Controls.Add(Me.textBox1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Events"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 91)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 235)
			Me.radGroupBox1.TabIndex = 9
			Me.radGroupBox1.Text = "Events"
			' 
			' radButtonClear
			' 
			Me.radButtonClear.Location = New System.Drawing.Point(23, 197)
			Me.radButtonClear.Name = "radButtonClear"
			Me.radButtonClear.Size = New System.Drawing.Size(134, 23)
			Me.radButtonClear.TabIndex = 10
			Me.radButtonClear.Text = "Clear"
'			Me.radButtonClear.Click += New System.EventHandler(Me.radButtonClear_Click);
			' 
			' textBox1
			' 
			Me.textBox1.ForeColor = System.Drawing.Color.Black
			Me.textBox1.Location = New System.Drawing.Point(23, 22)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			' 
			' 
			' 
			Me.textBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.textBox1.RootElement.StretchVertically = True
			Me.textBox1.Size = New System.Drawing.Size(134, 169)
			Me.textBox1.TabIndex = 0
			Me.textBox1.TabStop = False
'			Me.textBox1.TextChanged += New System.EventHandler(Me.textBox1_TextChanged);
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Location = New System.Drawing.Point(287, 55)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New System.Drawing.Size(628, 466)
			Me.radPageView1.TabIndex = 9
			Me.radPageView1.Text = "radPageView1"
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radGridView1)
			Me.radPageViewPage1.Location = New System.Drawing.Point(10, 37)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(607, 418)
			Me.radPageViewPage1.Text = "Products"
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = System.Drawing.Color.Transparent
			Me.radGridView1.Cursor = System.Windows.Forms.Cursors.Default
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			gridViewDecimalColumn7.DataType = GetType(Integer)
			gridViewDecimalColumn7.FieldName = "ProductID"
			gridViewDecimalColumn7.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn7.HeaderText = "ProductID"
			gridViewDecimalColumn7.IsAutoGenerated = True
			gridViewDecimalColumn7.IsVisible = False
			gridViewDecimalColumn7.Name = "ProductID"
			gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn20.FieldName = "ProductName"
			gridViewTextBoxColumn20.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn20.HeaderText = "ProductName"
			gridViewTextBoxColumn20.IsAutoGenerated = True
			gridViewTextBoxColumn20.Name = "ProductName"
			gridViewDecimalColumn8.DataType = GetType(Integer)
			gridViewDecimalColumn8.FieldName = "SupplierID"
			gridViewDecimalColumn8.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn8.HeaderText = "SupplierID"
			gridViewDecimalColumn8.IsAutoGenerated = True
			gridViewDecimalColumn8.IsVisible = False
			gridViewDecimalColumn8.Name = "SupplierID"
			gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn9.DataType = GetType(Integer)
			gridViewDecimalColumn9.FieldName = "CategoryID"
			gridViewDecimalColumn9.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn9.HeaderText = "CategoryID"
			gridViewDecimalColumn9.IsAutoGenerated = True
			gridViewDecimalColumn9.IsVisible = False
			gridViewDecimalColumn9.Name = "CategoryID"
			gridViewDecimalColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn21.FieldName = "QuantityPerUnit"
			gridViewTextBoxColumn21.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn21.HeaderText = "QuantityPerUnit"
			gridViewTextBoxColumn21.IsAutoGenerated = True
			gridViewTextBoxColumn21.Name = "QuantityPerUnit"
			gridViewDecimalColumn10.DataType = GetType(Decimal)
			gridViewDecimalColumn10.FieldName = "UnitPrice"
			gridViewDecimalColumn10.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn10.HeaderText = "UnitPrice"
			gridViewDecimalColumn10.IsAutoGenerated = True
			gridViewDecimalColumn10.Name = "UnitPrice"
			gridViewDecimalColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn11.DataType = GetType(Short)
			gridViewDecimalColumn11.FieldName = "UnitsInStock"
			gridViewDecimalColumn11.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn11.HeaderText = "UnitsInStock"
			gridViewDecimalColumn11.IsAutoGenerated = True
			gridViewDecimalColumn11.IsVisible = False
			gridViewDecimalColumn11.Name = "UnitsInStock"
			gridViewDecimalColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn12.DataType = GetType(Short)
			gridViewDecimalColumn12.FieldName = "UnitsOnOrder"
			gridViewDecimalColumn12.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn12.HeaderText = "UnitsOnOrder"
			gridViewDecimalColumn12.IsAutoGenerated = True
			gridViewDecimalColumn12.IsVisible = False
			gridViewDecimalColumn12.Name = "UnitsOnOrder"
			gridViewDecimalColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn13.DataType = GetType(Short)
			gridViewDecimalColumn13.FieldName = "ReorderLevel"
			gridViewDecimalColumn13.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn13.HeaderText = "ReorderLevel"
			gridViewDecimalColumn13.IsAutoGenerated = True
			gridViewDecimalColumn13.IsVisible = False
			gridViewDecimalColumn13.Name = "ReorderLevel"
			gridViewDecimalColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewCheckBoxColumn1.DataType = GetType(Boolean)
			gridViewCheckBoxColumn1.FieldName = "Discontinued"
			gridViewCheckBoxColumn1.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewCheckBoxColumn1.HeaderText = "Discontinued"
			gridViewCheckBoxColumn1.IsAutoGenerated = True
			gridViewCheckBoxColumn1.IsVisible = False
			gridViewCheckBoxColumn1.Name = "Discontinued"
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn7, gridViewTextBoxColumn20, gridViewDecimalColumn8, gridViewDecimalColumn9, gridViewTextBoxColumn21, gridViewDecimalColumn10, gridViewDecimalColumn11, gridViewDecimalColumn12, gridViewDecimalColumn13, gridViewCheckBoxColumn1})
			Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New System.Drawing.Size(607, 418)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridViewPreview"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radGridView2)
			Me.radPageViewPage2.Location = New System.Drawing.Point(10, 37)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(607, 418)
			Me.radPageViewPage2.Text = "Company Info"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radGridView3)
			Me.radPageViewPage3.Location = New System.Drawing.Point(10, 37)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(607, 418)
			Me.radPageViewPage3.Text = "Orders"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(90, 16)
			Me.radLabel1.TabIndex = 10
			Me.radLabel1.Text = "Item Drag Mode:"
			' 
			' dragModeCombo
			' 
			Me.dragModeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.dragModeCombo.AutoCompleteDataSource = Nothing
			Me.dragModeCombo.AutoSize = True
			Me.dragModeCombo.DropDownAnimationEnabled = False
			Me.dragModeCombo.DropDownAnimationFrames = 1
			Me.dragModeCombo.Location = New System.Drawing.Point(10, 59)
			Me.dragModeCombo.Name = "dragModeCombo"
			Me.dragModeCombo.Size = New System.Drawing.Size(180, 20)
			Me.dragModeCombo.TabIndex = 11
			Me.dragModeCombo.TabStop = False
			Me.dragModeCombo.Text = "radDropDownList1"
'			Me.dragModeCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.dragModeCombo_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1294, 551)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dragModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As RadGroupBox
		Private WithEvents textBox1 As RadTextBox
		Private WithEvents radButtonClear As RadButton
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private radGridView2 As RadGridView
		Private productsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private radGridView3 As RadGridView
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private ordersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As RadPageViewPage
		Private radPageViewPage2 As RadPageViewPage
		Private radPageViewPage3 As RadPageViewPage
		Private radGridView1 As RadGridView
		Private WithEvents dragModeCombo As RadDropDownList
		Private radLabel1 As RadLabel
	End Class
End Namespace
