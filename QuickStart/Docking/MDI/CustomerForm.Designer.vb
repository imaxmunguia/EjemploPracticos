Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class CustomerForm
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
			Dim customerIDLabel As System.Windows.Forms.Label
			Dim companyNameLabel As System.Windows.Forms.Label
			Dim contactNameLabel As System.Windows.Forms.Label
			Dim contactTitleLabel As System.Windows.Forms.Label
			Dim addressLabel As System.Windows.Forms.Label
			Dim cityLabel As System.Windows.Forms.Label
			Dim regionLabel As System.Windows.Forms.Label
			Dim postalCodeLabel As System.Windows.Forms.Label
			Dim countryLabel As System.Windows.Forms.Label
			Dim phoneLabel As System.Windows.Forms.Label
			Dim faxLabel As System.Windows.Forms.Label
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomerForm))
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
			Dim gridViewCheckBoxColumn1 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.customersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
			Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
			Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
			Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.customerIDTextBox = New System.Windows.Forms.TextBox()
			Me.companyNameTextBox = New System.Windows.Forms.TextBox()
			Me.contactNameTextBox = New System.Windows.Forms.TextBox()
			Me.contactTitleTextBox = New System.Windows.Forms.TextBox()
			Me.addressTextBox = New System.Windows.Forms.TextBox()
			Me.cityTextBox = New System.Windows.Forms.TextBox()
			Me.regionTextBox = New System.Windows.Forms.TextBox()
			Me.postalCodeTextBox = New System.Windows.Forms.TextBox()
			Me.countryTextBox = New System.Windows.Forms.TextBox()
			Me.phoneTextBox = New System.Windows.Forms.TextBox()
			Me.faxTextBox = New System.Windows.Forms.TextBox()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			customerIDLabel = New System.Windows.Forms.Label()
			companyNameLabel = New System.Windows.Forms.Label()
			contactNameLabel = New System.Windows.Forms.Label()
			contactTitleLabel = New System.Windows.Forms.Label()
			addressLabel = New System.Windows.Forms.Label()
			cityLabel = New System.Windows.Forms.Label()
			regionLabel = New System.Windows.Forms.Label()
			postalCodeLabel = New System.Windows.Forms.Label()
			countryLabel = New System.Windows.Forms.Label()
			phoneLabel = New System.Windows.Forms.Label()
			faxLabel = New System.Windows.Forms.Label()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.customersBindingNavigator.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerIDLabel
			' 
			customerIDLabel.AutoSize = True
			customerIDLabel.Location = New System.Drawing.Point(26, 330)
			customerIDLabel.Name = "customerIDLabel"
			customerIDLabel.Size = New System.Drawing.Size(68, 13)
			customerIDLabel.TabIndex = 2
			customerIDLabel.Text = "Customer ID:"
			' 
			' companyNameLabel
			' 
			companyNameLabel.AutoSize = True
			companyNameLabel.Location = New System.Drawing.Point(9, 356)
			companyNameLabel.Name = "companyNameLabel"
			companyNameLabel.Size = New System.Drawing.Size(85, 13)
			companyNameLabel.TabIndex = 4
			companyNameLabel.Text = "Company Name:"
			' 
			' contactNameLabel
			' 
			contactNameLabel.AutoSize = True
			contactNameLabel.Location = New System.Drawing.Point(16, 382)
			contactNameLabel.Name = "contactNameLabel"
			contactNameLabel.Size = New System.Drawing.Size(78, 13)
			contactNameLabel.TabIndex = 6
			contactNameLabel.Text = "Contact Name:"
			' 
			' contactTitleLabel
			' 
			contactTitleLabel.AutoSize = True
			contactTitleLabel.Location = New System.Drawing.Point(24, 408)
			contactTitleLabel.Name = "contactTitleLabel"
			contactTitleLabel.Size = New System.Drawing.Size(70, 13)
			contactTitleLabel.TabIndex = 8
			contactTitleLabel.Text = "Contact Title:"
			' 
			' addressLabel
			' 
			addressLabel.AutoSize = True
			addressLabel.Location = New System.Drawing.Point(296, 330)
			addressLabel.Name = "addressLabel"
			addressLabel.Size = New System.Drawing.Size(48, 13)
			addressLabel.TabIndex = 10
			addressLabel.Text = "Address:"
			' 
			' cityLabel
			' 
			cityLabel.AutoSize = True
			cityLabel.Location = New System.Drawing.Point(67, 434)
			cityLabel.Name = "cityLabel"
			cityLabel.Size = New System.Drawing.Size(27, 13)
			cityLabel.TabIndex = 12
			cityLabel.Text = "City:"
			' 
			' regionLabel
			' 
			regionLabel.AutoSize = True
			regionLabel.Location = New System.Drawing.Point(300, 408)
			regionLabel.Name = "regionLabel"
			regionLabel.Size = New System.Drawing.Size(44, 13)
			regionLabel.TabIndex = 14
			regionLabel.Text = "Region:"
			' 
			' postalCodeLabel
			' 
			postalCodeLabel.AutoSize = True
			postalCodeLabel.Location = New System.Drawing.Point(27, 460)
			postalCodeLabel.Name = "postalCodeLabel"
			postalCodeLabel.Size = New System.Drawing.Size(67, 13)
			postalCodeLabel.TabIndex = 16
			postalCodeLabel.Text = "Postal Code:"
			' 
			' countryLabel
			' 
			countryLabel.AutoSize = True
			countryLabel.Location = New System.Drawing.Point(298, 434)
			countryLabel.Name = "countryLabel"
			countryLabel.Size = New System.Drawing.Size(46, 13)
			countryLabel.TabIndex = 18
			countryLabel.Text = "Country:"
			' 
			' phoneLabel
			' 
			phoneLabel.AutoSize = True
			phoneLabel.Location = New System.Drawing.Point(303, 356)
			phoneLabel.Name = "phoneLabel"
			phoneLabel.Size = New System.Drawing.Size(41, 13)
			phoneLabel.TabIndex = 20
			phoneLabel.Text = "Phone:"
			' 
			' faxLabel
			' 
			faxLabel.AutoSize = True
			faxLabel.Location = New System.Drawing.Point(317, 382)
			faxLabel.Name = "faxLabel"
			faxLabel.Size = New System.Drawing.Size(27, 13)
			faxLabel.TabIndex = 22
			faxLabel.Text = "Fax:"
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' customersBindingNavigator
			' 
			Me.customersBindingNavigator.AddNewItem = Nothing
			Me.customersBindingNavigator.BindingSource = Me.customersBindingSource
			Me.customersBindingNavigator.CountItem = Me.bindingNavigatorCountItem
			Me.customersBindingNavigator.DeleteItem = Nothing
			Me.customersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
			Me.customersBindingNavigator.Location = New System.Drawing.Point(0, 0)
			Me.customersBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
			Me.customersBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
			Me.customersBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
			Me.customersBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
			Me.customersBindingNavigator.Name = "customersBindingNavigator"
			Me.customersBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
			Me.customersBindingNavigator.Size = New System.Drawing.Size(601, 25)
			Me.customersBindingNavigator.TabIndex = 0
			Me.customersBindingNavigator.Text = "bindingNavigator1"
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
			' customerIDTextBox
			' 
			Me.customerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "CustomerID", True))
			Me.customerIDTextBox.Location = New System.Drawing.Point(100, 327)
			Me.customerIDTextBox.Name = "customerIDTextBox"
			Me.customerIDTextBox.Size = New System.Drawing.Size(157, 20)
			Me.customerIDTextBox.TabIndex = 3
			' 
			' companyNameTextBox
			' 
			Me.companyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "CompanyName", True))
			Me.companyNameTextBox.Location = New System.Drawing.Point(100, 353)
			Me.companyNameTextBox.Name = "companyNameTextBox"
			Me.companyNameTextBox.Size = New System.Drawing.Size(157, 20)
			Me.companyNameTextBox.TabIndex = 5
			' 
			' contactNameTextBox
			' 
			Me.contactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "ContactName", True))
			Me.contactNameTextBox.Location = New System.Drawing.Point(100, 379)
			Me.contactNameTextBox.Name = "contactNameTextBox"
			Me.contactNameTextBox.Size = New System.Drawing.Size(157, 20)
			Me.contactNameTextBox.TabIndex = 7
			' 
			' contactTitleTextBox
			' 
			Me.contactTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "ContactTitle", True))
			Me.contactTitleTextBox.Location = New System.Drawing.Point(100, 405)
			Me.contactTitleTextBox.Name = "contactTitleTextBox"
			Me.contactTitleTextBox.Size = New System.Drawing.Size(157, 20)
			Me.contactTitleTextBox.TabIndex = 9
			' 
			' addressTextBox
			' 
			Me.addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "Address", True))
			Me.addressTextBox.Location = New System.Drawing.Point(350, 327)
			Me.addressTextBox.Name = "addressTextBox"
			Me.addressTextBox.Size = New System.Drawing.Size(157, 20)
			Me.addressTextBox.TabIndex = 11
			' 
			' cityTextBox
			' 
			Me.cityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "City", True))
			Me.cityTextBox.Location = New System.Drawing.Point(100, 431)
			Me.cityTextBox.Name = "cityTextBox"
			Me.cityTextBox.Size = New System.Drawing.Size(157, 20)
			Me.cityTextBox.TabIndex = 13
			' 
			' regionTextBox
			' 
			Me.regionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "Region", True))
			Me.regionTextBox.Location = New System.Drawing.Point(350, 405)
			Me.regionTextBox.Name = "regionTextBox"
			Me.regionTextBox.Size = New System.Drawing.Size(157, 20)
			Me.regionTextBox.TabIndex = 15
			' 
			' postalCodeTextBox
			' 
			Me.postalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "PostalCode", True))
			Me.postalCodeTextBox.Location = New System.Drawing.Point(100, 457)
			Me.postalCodeTextBox.Name = "postalCodeTextBox"
			Me.postalCodeTextBox.Size = New System.Drawing.Size(157, 20)
			Me.postalCodeTextBox.TabIndex = 17
			' 
			' countryTextBox
			' 
			Me.countryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "Country", True))
			Me.countryTextBox.Location = New System.Drawing.Point(350, 431)
			Me.countryTextBox.Name = "countryTextBox"
			Me.countryTextBox.Size = New System.Drawing.Size(157, 20)
			Me.countryTextBox.TabIndex = 19
			' 
			' phoneTextBox
			' 
			Me.phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "Phone", True))
			Me.phoneTextBox.Location = New System.Drawing.Point(350, 353)
			Me.phoneTextBox.Name = "phoneTextBox"
			Me.phoneTextBox.Size = New System.Drawing.Size(157, 20)
			Me.phoneTextBox.TabIndex = 21
			' 
			' faxTextBox
			' 
			Me.faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.customersBindingSource, "Fax", True))
			Me.faxTextBox.Location = New System.Drawing.Point(350, 379)
			Me.faxTextBox.Name = "faxTextBox"
			Me.faxTextBox.Size = New System.Drawing.Size(157, 20)
			Me.faxTextBox.TabIndex = 23
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radGridView1.Location = New System.Drawing.Point(0, 25)
			' 
			' 
			' 
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.HeaderText = "CustomerID"
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewTextBoxColumn2.FieldName = "CompanyName"
			gridViewTextBoxColumn2.HeaderText = "CompanyName"
			gridViewTextBoxColumn2.Name = "CompanyName"
			gridViewTextBoxColumn3.FieldName = "ContactName"
			gridViewTextBoxColumn3.HeaderText = "ContactName"
			gridViewTextBoxColumn3.Name = "ContactName"
			gridViewTextBoxColumn4.FieldName = "ContactTitle"
			gridViewTextBoxColumn4.HeaderText = "ContactTitle"
			gridViewTextBoxColumn4.Name = "ContactTitle"
			gridViewTextBoxColumn5.FieldName = "Address"
			gridViewTextBoxColumn5.HeaderText = "Address"
			gridViewTextBoxColumn5.Name = "Address"
			gridViewTextBoxColumn6.FieldName = "City"
			gridViewTextBoxColumn6.HeaderText = "City"
			gridViewTextBoxColumn6.Name = "City"
			gridViewTextBoxColumn7.FieldName = "Region"
			gridViewTextBoxColumn7.HeaderText = "Region"
			gridViewTextBoxColumn7.Name = "Region"
			gridViewTextBoxColumn8.FieldName = "PostalCode"
			gridViewTextBoxColumn8.HeaderText = "PostalCode"
			gridViewTextBoxColumn8.Name = "PostalCode"
			gridViewTextBoxColumn9.FieldName = "Country"
			gridViewTextBoxColumn9.HeaderText = "Country"
			gridViewTextBoxColumn9.Name = "Country"
			gridViewTextBoxColumn10.FieldName = "Phone"
			gridViewTextBoxColumn10.HeaderText = "Phone"
			gridViewTextBoxColumn10.Name = "Phone"
			gridViewTextBoxColumn11.FieldName = "Fax"
			gridViewTextBoxColumn11.HeaderText = "Fax"
			gridViewTextBoxColumn11.Name = "Fax"
			gridViewCheckBoxColumn1.DataType = GetType(Boolean)
			gridViewCheckBoxColumn1.FieldName = "Bool"
			gridViewCheckBoxColumn1.HeaderText = "Bool"
			gridViewCheckBoxColumn1.Name = "Bool"
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
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewCheckBoxColumn1)
			Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource

			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(601, 280)
			Me.radGridView1.TabIndex = 24
			Me.radGridView1.Text = "radGridView1"
			' 
			' CustomerForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 510)
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(faxLabel)
			Me.Controls.Add(Me.faxTextBox)
			Me.Controls.Add(phoneLabel)
			Me.Controls.Add(Me.phoneTextBox)
			Me.Controls.Add(countryLabel)
			Me.Controls.Add(Me.countryTextBox)
			Me.Controls.Add(postalCodeLabel)
			Me.Controls.Add(Me.postalCodeTextBox)
			Me.Controls.Add(regionLabel)
			Me.Controls.Add(Me.regionTextBox)
			Me.Controls.Add(cityLabel)
			Me.Controls.Add(Me.cityTextBox)
			Me.Controls.Add(addressLabel)
			Me.Controls.Add(Me.addressTextBox)
			Me.Controls.Add(contactTitleLabel)
			Me.Controls.Add(Me.contactTitleTextBox)
			Me.Controls.Add(contactNameLabel)
			Me.Controls.Add(Me.contactNameTextBox)
			Me.Controls.Add(companyNameLabel)
			Me.Controls.Add(Me.companyNameTextBox)
			Me.Controls.Add(customerIDLabel)
			Me.Controls.Add(Me.customerIDTextBox)
			Me.Controls.Add(Me.customersBindingNavigator)
			Me.Name = "CustomerForm"
			Me.Text = "CustomerForm"
'			Me.Load += New System.EventHandler(Me.CustomerForm_Load);
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.customersBindingNavigator.ResumeLayout(False)
			Me.customersBindingNavigator.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private customersBindingNavigator As System.Windows.Forms.BindingNavigator
		Private bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
		Private bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
		Private bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private customerIDTextBox As System.Windows.Forms.TextBox
		Private companyNameTextBox As System.Windows.Forms.TextBox
		Private contactNameTextBox As System.Windows.Forms.TextBox
		Private contactTitleTextBox As System.Windows.Forms.TextBox
		Private addressTextBox As System.Windows.Forms.TextBox
		Private cityTextBox As System.Windows.Forms.TextBox
		Private regionTextBox As System.Windows.Forms.TextBox
		Private postalCodeTextBox As System.Windows.Forms.TextBox
		Private countryTextBox As System.Windows.Forms.TextBox
		Private phoneTextBox As System.Windows.Forms.TextBox
		Private faxTextBox As System.Windows.Forms.TextBox
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace