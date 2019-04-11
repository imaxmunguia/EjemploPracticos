Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.ColumnTypes
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
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.radGroupBoxColumns = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxCustom = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxBrowse = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCalculator = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxColor = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxHyperlink = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxMaskBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxLookUp = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxImage = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxText = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxDecimal = New Telerik.WinControls.UI.RadCheckBox()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxColumns.SuspendLayout()
            CType(Me.radCheckBoxCustom, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxHyperlink, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxMaskBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radGroupBoxColumns)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(303, 747)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxColumns, 0)
            '
            'radGridView1
            '
            Me.radGridView1.BackColor = System.Drawing.Color.White
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.EnableHotTracking = False
            Me.radGridView1.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            'radGridView1
            '
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.Caption = Nothing
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(1277, 749)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.Text = "radGridView1"
            Me.radGridView1.ThemeName = "Telerik"
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "NwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'carsBindingSource
            '
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.nwindDataSet
            '
            'carsTableAdapter
            '
            Me.carsTableAdapter.ClearBeforeFill = True
            '
            'employeesBindingSource
            '
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.nwindDataSet
            '
            'employeesTableAdapter
            '
            Me.employeesTableAdapter.ClearBeforeFill = True
            '
            'radGroupBoxColumns
            '
            Me.radGroupBoxColumns.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCustom)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxBrowse)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCalculator)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxColor)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxHyperlink)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxMaskBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxLookUp)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxImage)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxText)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxDecimal)
            Me.radGroupBoxColumns.FooterImageIndex = -1
            Me.radGroupBoxColumns.FooterImageKey = ""
            Me.radGroupBoxColumns.ForeColor = System.Drawing.Color.Black
            Me.radGroupBoxColumns.HeaderImageIndex = -1
            Me.radGroupBoxColumns.HeaderImageKey = ""
            Me.radGroupBoxColumns.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupBoxColumns.HeaderText = "Columns"
            Me.radGroupBoxColumns.Location = New System.Drawing.Point(15, 6)
            Me.radGroupBoxColumns.Name = "radGroupBoxColumns"
            Me.radGroupBoxColumns.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            '
            '
            '
            Me.radGroupBoxColumns.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBoxColumns.Size = New System.Drawing.Size(115, 298)
            Me.radGroupBoxColumns.TabIndex = 2
            Me.radGroupBoxColumns.Text = "Columns"
            '
            'radCheckBoxCustom
            '
            Me.radCheckBoxCustom.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxCustom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxCustom.Location = New System.Drawing.Point(19, 267)
            Me.radCheckBoxCustom.Name = "radCheckBoxCustom"
            '
            '
            '
            Me.radCheckBoxCustom.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCustom.Size = New System.Drawing.Size(59, 18)
            Me.radCheckBoxCustom.TabIndex = 34
            Me.radCheckBoxCustom.Text = "Custom"
            Me.radCheckBoxCustom.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxCustom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxCheckBox
            '
            Me.radCheckBoxCheckBox.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxCheckBox.Location = New System.Drawing.Point(19, 243)
            Me.radCheckBoxCheckBox.Name = "radCheckBoxCheckBox"
            '
            '
            '
            Me.radCheckBoxCheckBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCheckBox.Size = New System.Drawing.Size(69, 18)
            Me.radCheckBoxCheckBox.TabIndex = 33
            Me.radCheckBoxCheckBox.Text = "CheckBox"
            Me.radCheckBoxCheckBox.ThemeName = "GridFeaturesBrowser"
            '
            'radCheckBoxBrowse
            '
            Me.radCheckBoxBrowse.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxBrowse.Location = New System.Drawing.Point(19, 219)
            Me.radCheckBoxBrowse.Name = "radCheckBoxBrowse"
            '
            '
            '
            Me.radCheckBoxBrowse.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxBrowse.Size = New System.Drawing.Size(56, 18)
            Me.radCheckBoxBrowse.TabIndex = 32
            Me.radCheckBoxBrowse.Text = "Browse"
            Me.radCheckBoxBrowse.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxBrowse.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxCalculator
            '
            Me.radCheckBoxCalculator.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxCalculator.Location = New System.Drawing.Point(19, 195)
            Me.radCheckBoxCalculator.Name = "radCheckBoxCalculator"
            '
            '
            '
            Me.radCheckBoxCalculator.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCalculator.Size = New System.Drawing.Size(70, 18)
            Me.radCheckBoxCalculator.TabIndex = 31
            Me.radCheckBoxCalculator.Text = "Calculator"
            Me.radCheckBoxCalculator.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxCalculator.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxColor
            '
            Me.radCheckBoxColor.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxColor.Location = New System.Drawing.Point(19, 171)
            Me.radCheckBoxColor.Name = "radCheckBoxColor"
            '
            '
            '
            Me.radCheckBoxColor.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxColor.Size = New System.Drawing.Size(47, 18)
            Me.radCheckBoxColor.TabIndex = 28
            Me.radCheckBoxColor.Text = "Color"
            Me.radCheckBoxColor.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxColor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxHyperlink
            '
            Me.radCheckBoxHyperlink.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxHyperlink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxHyperlink.Location = New System.Drawing.Point(19, 147)
            Me.radCheckBoxHyperlink.Name = "radCheckBoxHyperlink"
            '
            '
            '
            Me.radCheckBoxHyperlink.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxHyperlink.Size = New System.Drawing.Size(68, 18)
            Me.radCheckBoxHyperlink.TabIndex = 28
            Me.radCheckBoxHyperlink.Text = "Hyperlink"
            Me.radCheckBoxHyperlink.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxHyperlink.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxMaskBox
            '
            Me.radCheckBoxMaskBox.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxMaskBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxMaskBox.Location = New System.Drawing.Point(19, 123)
            Me.radCheckBoxMaskBox.Name = "radCheckBoxMaskBox"
            '
            '
            '
            Me.radCheckBoxMaskBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxMaskBox.Size = New System.Drawing.Size(65, 18)
            Me.radCheckBoxMaskBox.TabIndex = 28
            Me.radCheckBoxMaskBox.Text = "MaskBox"
            Me.radCheckBoxMaskBox.ThemeName = "GridFeaturesBrowser"
            '
            'radCheckBoxLookUp
            '
            Me.radCheckBoxLookUp.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxLookUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxLookUp.Location = New System.Drawing.Point(19, 99)
            Me.radCheckBoxLookUp.Name = "radCheckBoxLookUp"
            '
            '
            '
            Me.radCheckBoxLookUp.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxLookUp.Size = New System.Drawing.Size(59, 18)
            Me.radCheckBoxLookUp.TabIndex = 30
            Me.radCheckBoxLookUp.Text = "LookUp"
            Me.radCheckBoxLookUp.ThemeName = "GridFeaturesBrowser"
            '
            'radCheckBoxImage
            '
            Me.radCheckBoxImage.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxImage.Location = New System.Drawing.Point(19, 75)
            Me.radCheckBoxImage.Name = "radCheckBoxImage"
            '
            '
            '
            Me.radCheckBoxImage.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxImage.Size = New System.Drawing.Size(51, 18)
            Me.radCheckBoxImage.TabIndex = 29
            Me.radCheckBoxImage.Text = "Image"
            Me.radCheckBoxImage.ThemeName = "GridFeaturesBrowser"
            Me.radCheckBoxImage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxText
            '
            Me.radCheckBoxText.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxText.Location = New System.Drawing.Point(19, 51)
            Me.radCheckBoxText.Name = "radCheckBoxText"
            '
            '
            '
            Me.radCheckBoxText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxText.Size = New System.Drawing.Size(41, 18)
            Me.radCheckBoxText.TabIndex = 28
            Me.radCheckBoxText.Text = "Text"
            Me.radCheckBoxText.ThemeName = "GridFeaturesBrowser"
            '
            'radCheckBoxDecimal
            '
            Me.radCheckBoxDecimal.BackColor = System.Drawing.Color.Transparent
            Me.radCheckBoxDecimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
            Me.radCheckBoxDecimal.Location = New System.Drawing.Point(19, 27)
            Me.radCheckBoxDecimal.Name = "radCheckBoxDecimal"
            '
            '
            '
            Me.radCheckBoxDecimal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxDecimal.Size = New System.Drawing.Size(60, 18)
            Me.radCheckBoxDecimal.TabIndex = 27
            Me.radCheckBoxDecimal.Text = "Decimal"
            Me.radCheckBoxDecimal.ThemeName = "GridFeaturesBrowser"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1277, 749)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxColumns.ResumeLayout(False)
            Me.radGroupBoxColumns.PerformLayout()
            CType(Me.radCheckBoxCustom, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxBrowse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCalculator, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxHyperlink, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxMaskBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxLookUp, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxDecimal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents radGroupBoxColumns As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radCheckBoxCustom As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxBrowse As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxCalculator As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxColor As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxHyperlink As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxMaskBox As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxLookUp As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxImage As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxText As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxDecimal As Telerik.WinControls.UI.RadCheckBox


	End Class
End Namespace
