Namespace Telerik.Examples.WinControls.GridView.Printing
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn12 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim radPrintWatermark1 As New Telerik.WinControls.UI.RadPrintWatermark()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radRadioButtonTable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonHtml = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonColumnGroups = New Telerik.WinControls.UI.RadRadioButton()
			Me.radButtonPrint = New Telerik.WinControls.UI.RadButton()
			Me.radButtonPrintPreview = New Telerik.WinControls.UI.RadButton()
			Me.radButtonPrintSettings = New Telerik.WinControls.UI.RadButton()
			Me.radPrintDocument1 = New Telerik.WinControls.UI.RadPrintDocument()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radRadioButtonTable, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radRadioButtonColumnGroups, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.settingsPanel.AutoScroll = True
			Me.settingsPanel.BackColor = System.Drawing.Color.Transparent
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radButtonPrint)
			Me.settingsPanel.Controls.Add(Me.radButtonPrintPreview)
			Me.settingsPanel.Controls.Add(Me.radButtonPrintSettings)
			Me.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.settingsPanel.Location = New System.Drawing.Point(381, 90)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New System.Drawing.Size(261, 354)
			Me.settingsPanel.TabIndex = 0
			Me.settingsPanel.Visible = False
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "EmployeeID"
			gridViewDecimalColumn1.HeaderText = "EmployeeID"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.IsVisible = False
			gridViewDecimalColumn1.Name = "EmployeeID"
			gridViewTextBoxColumn1.FieldName = "TitleOfCourtesy"
			gridViewTextBoxColumn1.HeaderText = "TitleOfCourtesy"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "TitleOfCourtesy"
			gridViewTextBoxColumn2.FieldName = "FirstName"
			gridViewTextBoxColumn2.HeaderText = "FirstName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "FirstName"
			gridViewTextBoxColumn2.Width = 100
			gridViewTextBoxColumn3.FieldName = "LastName"
			gridViewTextBoxColumn3.HeaderText = "LastName"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "LastName"
			gridViewTextBoxColumn3.Width = 100
			gridViewTextBoxColumn4.FieldName = "Title"
			gridViewTextBoxColumn4.HeaderText = "Title"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Title"
			gridViewTextBoxColumn4.Width = 80
			gridViewDateTimeColumn1.FieldName = "BirthDate"
			gridViewDateTimeColumn1.HeaderText = "BirthDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.IsVisible = False
			gridViewDateTimeColumn1.Name = "BirthDate"
			gridViewDateTimeColumn2.FieldName = "HireDate"
			gridViewDateTimeColumn2.HeaderText = "HireDate"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.IsVisible = False
			gridViewDateTimeColumn2.Name = "HireDate"
			gridViewTextBoxColumn5.FieldName = "Country"
			gridViewTextBoxColumn5.HeaderText = "Country"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "Country"
			gridViewImageColumn1.DataType = GetType(Byte())
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.IsVisible = False
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn6.FieldName = "Address"
			gridViewTextBoxColumn6.HeaderText = "Address"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "Address"
			gridViewTextBoxColumn6.Width = 150
			gridViewTextBoxColumn7.FieldName = "City"
			gridViewTextBoxColumn7.HeaderText = "City"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.IsVisible = False
			gridViewTextBoxColumn7.Name = "City"
			gridViewTextBoxColumn8.FieldName = "Region"
			gridViewTextBoxColumn8.HeaderText = "Region"
			gridViewTextBoxColumn8.IsAutoGenerated = True
			gridViewTextBoxColumn8.IsVisible = False
			gridViewTextBoxColumn8.Name = "Region"
			gridViewTextBoxColumn9.FieldName = "PostalCode"
			gridViewTextBoxColumn9.HeaderText = "PostalCode"
			gridViewTextBoxColumn9.IsAutoGenerated = True
			gridViewTextBoxColumn9.IsVisible = False
			gridViewTextBoxColumn9.Name = "PostalCode"
			gridViewTextBoxColumn10.FieldName = "HomePhone"
			gridViewTextBoxColumn10.HeaderText = "Phone"
			gridViewTextBoxColumn10.IsAutoGenerated = True
			gridViewTextBoxColumn10.Name = "HomePhone"
			gridViewTextBoxColumn10.Width = 80
			gridViewTextBoxColumn11.FieldName = "Extension"
			gridViewTextBoxColumn11.HeaderText = "Extension"
			gridViewTextBoxColumn11.IsAutoGenerated = True
			gridViewTextBoxColumn11.IsVisible = False
			gridViewTextBoxColumn11.Name = "Extension"
			gridViewTextBoxColumn12.FieldName = "Notes"
			gridViewTextBoxColumn12.HeaderText = "Notes"
			gridViewTextBoxColumn12.IsAutoGenerated = True
			gridViewTextBoxColumn12.IsVisible = False
			gridViewTextBoxColumn12.Name = "Notes"
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "ReportsTo"
			gridViewDecimalColumn2.HeaderText = "ReportsTo"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.IsVisible = False
			gridViewDecimalColumn2.Name = "ReportsTo"
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewDateTimeColumn1, _
				gridViewDateTimeColumn2, gridViewTextBoxColumn5, gridViewImageColumn1, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewTextBoxColumn8, _
				gridViewTextBoxColumn9, gridViewTextBoxColumn10, gridViewTextBoxColumn11, gridViewTextBoxColumn12, gridViewDecimalColumn2})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1317, 732)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radRadioButtonTable
			' 
			Me.radRadioButtonTable.Location = New System.Drawing.Point(5, 21)
			Me.radRadioButtonTable.Name = "radRadioButtonTable"
			Me.radRadioButtonTable.TabIndex = 1
			Me.radRadioButtonTable.Text = "Table"
			
			' 
			' radRadioButtonHtml
			' 
			Me.radRadioButtonHtml.Location = New System.Drawing.Point(5, 45)
			Me.radRadioButtonHtml.Name = "radRadioButtonHtml"
			Me.radRadioButtonHtml.TabIndex = 1
			Me.radRadioButtonHtml.TabStop = True
			Me.radRadioButtonHtml.Text = "HTML"
			
			' 
			' radRadioButtonColumnGroups
			' 
			Me.radRadioButtonColumnGroups.Location = New System.Drawing.Point(5, 69)
			Me.radRadioButtonColumnGroups.Name = "radRadioButtonColumnGroups"
			Me.radRadioButtonColumnGroups.TabIndex = 1
			Me.radRadioButtonColumnGroups.Text = "Column groups"
			Me.radRadioButtonColumnGroups.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			
			' 
			' radButtonPrint
			' 
			Me.radButtonPrint.Location = New System.Drawing.Point(24, 173)
			Me.radButtonPrint.Name = "radButtonPrint"
			Me.radButtonPrint.TabIndex = 2
			Me.radButtonPrint.Text = "Print"
			
			' 
			' radButtonPrintPreview
			' 
			Me.radButtonPrintPreview.Location = New System.Drawing.Point(25, 203)
			Me.radButtonPrintPreview.Name = "radButtonPrintPreview"
			Me.radButtonPrintPreview.TabIndex = 2
			Me.radButtonPrintPreview.Text = "Print preview"
			
			' 
			' radButtonPrintSettings
			' 
			Me.radButtonPrintSettings.Location = New System.Drawing.Point(25, 233)
			Me.radButtonPrintSettings.Name = "radButtonPrintSettings"
			Me.radButtonPrintSettings.TabIndex = 2
			Me.radButtonPrintSettings.Text = "Print settings"
			
			' 
			' radPrintDocument1
			' 
			Me.radPrintDocument1.AssociatedObject = Me.radGridView1
			'Me.radPrintDocument1.DefaultPageSettings = DirectCast(resources.GetObject("radPrintDocument1.DefaultPageSettings"), System.Drawing.Printing.PageSettings)
			Me.radPrintDocument1.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.radPrintDocument1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			radPrintWatermark1.Font = New System.Drawing.Font("Microsoft Sans Serif", 144F)
			radPrintWatermark1.ImageOpacity = CByte(127)
			radPrintWatermark1.Pages = Nothing
			radPrintWatermark1.Text = Nothing
			radPrintWatermark1.TextAngle = 0F
			radPrintWatermark1.TextOpacity = CByte(127)
			Me.radPrintDocument1.Watermark = radPrintWatermark1
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonTable)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonColumnGroups)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonHtml)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Print style"
			Me.radGroupBox1.Location = New System.Drawing.Point(24, 50)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New System.Drawing.Size(130, 100)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = "Print style"
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1317, 732)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radRadioButtonTable, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radRadioButtonColumnGroups, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButtonPrint, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButtonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButtonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		friend withevents radGridView1 As Telerik.WinControls.UI.RadGridView
		friend withevents radRadioButtonTable As Telerik.WinControls.UI.RadRadioButton
		friend withevents radRadioButtonHtml As Telerik.WinControls.UI.RadRadioButton
		friend withevents radRadioButtonColumnGroups As Telerik.WinControls.UI.RadRadioButton
		friend withevents radButtonPrint As Telerik.WinControls.UI.RadButton
		friend withevents radButtonPrintPreview As Telerik.WinControls.UI.RadButton
		friend withevents radButtonPrintSettings As Telerik.WinControls.UI.RadButton
		friend withevents radPrintDocument1 As Telerik.WinControls.UI.RadPrintDocument
		friend withevents radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		friend withevents northwindDataSet As DataSources.NorthwindDataSet
		friend withevents employeesBindingSource As System.Windows.Forms.BindingSource
		friend withevents employeesTableAdapter As DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace
