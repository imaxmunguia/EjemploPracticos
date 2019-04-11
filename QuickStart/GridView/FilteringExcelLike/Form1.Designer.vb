Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.GridView.FilteringExcelLike
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
            Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDateTimeColumn8 As New Telerik.WinControls.UI.GridViewDateTimeColumn()

            Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel1
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupSettings)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(916, 1)
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(200, 705)
            Me.settingsPanel.ThemeName = "ControlDefault"
            ' 
            ' customersBindingSource
            ' 
            Me.customersBindingSource.DataMember = "Customers"
            Me.customersBindingSource.DataSource = Me.nwindRadGridView
            ' 
            ' nwindRadGridView
            ' 
            Me.nwindRadGridView.DataSetName = "NwindRadGridView"
            Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' radRadioButton1
            ' 
            Me.radRadioButton1.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton1.Location = New System.Drawing.Point(5, 50)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton1.Size = New System.Drawing.Size(128, 29)
            Me.radRadioButton1.TabIndex = 1
            Me.radRadioButton1.Text = "Default"
            ' 
            ' radRadioButton2
            ' 
            Me.radRadioButton2.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton2.Location = New System.Drawing.Point(5, 85)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton2.Size = New System.Drawing.Size(128, 29)
            Me.radRadioButton2.TabIndex = 2
            Me.radRadioButton2.Text = "[Random Date] List"
            ' 
            ' radRadioButton3
            ' 
            Me.radRadioButton3.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton3.Location = New System.Drawing.Point(5, 120)
            Me.radRadioButton3.Name = "radRadioButton3"
            Me.radRadioButton3.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton3.Size = New System.Drawing.Size(128, 29)
            Me.radRadioButton3.TabIndex = 3
            Me.radRadioButton3.Text = "[Random Date] Grouped"
            ' 
            ' radRadioButton4
            ' 
            Me.radRadioButton4.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton4.Location = New System.Drawing.Point(5, 155)
            Me.radRadioButton4.Name = "radRadioButton4"
            Me.radRadioButton4.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioButton4.Size = New System.Drawing.Size(128, 29)
            Me.radRadioButton4.TabIndex = 4
            Me.radRadioButton4.Text = "[All] Simple List"
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            gridViewTextBoxColumn1.FieldName = "CompanyName"
            gridViewTextBoxColumn1.FormatString = ""
            gridViewTextBoxColumn1.HeaderText = "Company Name"
            gridViewTextBoxColumn1.IsAutoGenerated = True
            gridViewTextBoxColumn1.Name = "CompanyName"
            gridViewTextBoxColumn1.Width = 156
            gridViewTextBoxColumn2.FieldName = "ContactName"
            gridViewTextBoxColumn2.FormatString = ""
            gridViewTextBoxColumn2.HeaderText = "Contact Name"
            gridViewTextBoxColumn2.IsAutoGenerated = True
            gridViewTextBoxColumn2.Name = "ContactName"
            gridViewTextBoxColumn2.Width = 156
            gridViewTextBoxColumn3.FieldName = "ContactTitle"
            gridViewTextBoxColumn3.FormatString = ""
            gridViewTextBoxColumn3.HeaderText = "Contact Title"
            gridViewTextBoxColumn3.IsAutoGenerated = True
            gridViewTextBoxColumn3.Name = "ContactTitle"
            gridViewTextBoxColumn3.Width = 156
            gridViewTextBoxColumn4.FieldName = "Address"
            gridViewTextBoxColumn4.FormatString = ""
            gridViewTextBoxColumn4.HeaderText = "Address"
            gridViewTextBoxColumn4.IsAutoGenerated = True
            gridViewTextBoxColumn4.Name = "Address"
            gridViewTextBoxColumn4.Width = 156
            gridViewTextBoxColumn5.FieldName = "City"
            gridViewTextBoxColumn5.FormatString = ""
            gridViewTextBoxColumn5.HeaderText = "City"
            gridViewTextBoxColumn5.IsAutoGenerated = True
            gridViewTextBoxColumn5.Name = "City"
            gridViewTextBoxColumn5.Width = 156
            gridViewTextBoxColumn6.FieldName = "Country"
            gridViewTextBoxColumn6.FormatString = ""
            gridViewTextBoxColumn6.HeaderText = "Country"
            gridViewTextBoxColumn6.IsAutoGenerated = True
            gridViewTextBoxColumn6.Name = "Country"
            gridViewTextBoxColumn6.Width = 156
            gridViewTextBoxColumn7.FieldName = "Phone"
            gridViewTextBoxColumn7.FormatString = ""
            gridViewTextBoxColumn7.HeaderText = "Phone"
            gridViewTextBoxColumn7.IsAutoGenerated = True
            gridViewTextBoxColumn7.Name = "Phone"
            gridViewTextBoxColumn7.Width = 161
            gridViewTextBoxColumn7.IsVisible = False
            gridViewDateTimeColumn8.HeaderText = "Random Date"
            gridViewDateTimeColumn8.FormatString = "{0:d}"
            gridViewDateTimeColumn8.IsAutoGenerated = False
            gridViewDateTimeColumn8.Name = "Date"
            gridViewDateTimeColumn8.Width = 161
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, _
             gridViewTextBoxColumn7, gridViewDateTimeColumn8})
            Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.radGridView1.Size = New System.Drawing.Size(1117, 707)
            Me.radGridView1.TabIndex = 5
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' radGroupSettings
            ' 
            Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupSettings.Controls.Add(Me.radRadioButton1)
            Me.radGroupSettings.Controls.Add(Me.radRadioButton2)
            Me.radGroupSettings.Controls.Add(Me.radRadioButton3)
            Me.radGroupSettings.Controls.Add(Me.radRadioButton4)
            Me.radGroupSettings.FooterImageIndex = -1
            Me.radGroupSettings.FooterImageKey = ""
            Me.radGroupSettings.FooterText = ""
            Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
            Me.radGroupSettings.HeaderImageIndex = -1
            Me.radGroupSettings.HeaderImageKey = ""
            Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupSettings.HeaderText = "Filter Popup Settings"
            Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
            Me.radGroupSettings.Name = "radGroupSettings"
            Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupSettings.Size = New System.Drawing.Size(180, 200)
            Me.radGroupSettings.TabIndex = 6
            Me.radGroupSettings.Text = "Filter Popup Settings"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1117, 707)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region

        Private WithEvents radGridView1 As RadGridView
        Private customersBindingSource As System.Windows.Forms.BindingSource
        Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
        Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
        Private radRadioButton1 As RadRadioButton
        Private radRadioButton2 As RadRadioButton
        Private radRadioButton3 As RadRadioButton
        Private radRadioButton4 As RadRadioButton
        Private radGroupSettings As RadGroupBox
    End Class
End Namespace
