Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.GridView.ExportHierarchy
	Partial Friend Class Form1
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
			Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
			Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.ordersTableAdapter = New DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.order_detailsTableAdapter = New DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()

			Me.radComboBoxSummaries = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radRadioButtonExcel = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonCsv = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonHtml = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonPdf = New Telerik.WinControls.UI.RadRadioButton()
			Me.radCheckBoxExportVisual = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxExportHierarchy = New Telerik.WinControls.UI.RadCheckBox()
			Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxSummaries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonCsv, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonPdf, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxExportVisual, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxExportHierarchy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1125, 1)
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "NwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			'
			' ordersTableAdapter
			'
			Me.ordersTableAdapter.ClearBeforeFill = True
			'
			' orders_detailsTableAdapter
			'
			Me.order_detailsTableAdapter.ClearBeforeFill = True
			' 
			' radComboBoxSummaries
			' 
			Me.radComboBoxSummaries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxSummaries.ForeColor = System.Drawing.Color.Black
			Me.radComboBoxSummaries.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem3, Me.radComboBoxItem4, Me.radComboBoxItem5, Me.radComboBoxItem6}))
			Me.radComboBoxSummaries.Location = New System.Drawing.Point(9, 180)
			Me.radComboBoxSummaries.Name = "radComboBoxSummaries"
			Me.radComboBoxSummaries.NullText = "How to export summaries"
			Me.radComboBoxSummaries.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxSummaries.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBoxSummaries.Size = New System.Drawing.Size(143, 20)
			Me.radComboBoxSummaries.TabIndex = 5
			Me.radComboBoxSummaries.TabStop = False
'			Me.radComboBoxSummaries.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBoxSummaries_SelectedIndexChanged);
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "All Summaries"
			' 
			' radComboBoxItem4
			'
			Me.radComboBoxItem4.Text = "OnlyTop Summaries"
			' 
			' radComboBoxItem5
			' 
			Me.radComboBoxItem5.Text = "Only Bottom Summaries"
			' 
			' radComboBoxItem6
			' 
			Me.radComboBoxItem6.Text = "Do not export summaries"
			' 
			' radRadioButtonExcel
			' 
			Me.radRadioButtonExcel.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonExcel.Location = New System.Drawing.Point(9, 20)
			Me.radRadioButtonExcel.Name = "radRadioButtonExcel"
			Me.radRadioButtonExcel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonExcel.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButtonExcel.TabIndex = 0
			Me.radRadioButtonExcel.Text = "Export to ExcelML"
'			Me.radRadioButtonExcel.ToggleStateChanged += New StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
			' 
			' radRadioButtonCsv
			' 
			Me.radRadioButtonCsv.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCsv.Location = New System.Drawing.Point(9, 42)
			Me.radRadioButtonCsv.Name = "radRadioButtonCsv"
			Me.radRadioButtonCsv.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCsv.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButtonCsv.TabIndex = 0
			Me.radRadioButtonCsv.Text = "Export to CSV"
'			Me.radRadioButtonCsv.ToggleStateChanged += New StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
			' 
			' radRadioButtonHtml
			' 
			Me.radRadioButtonHtml.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonHtml.Location = New System.Drawing.Point(9, 64)
			Me.radRadioButtonHtml.Name = "radRadioButtonHtml"
			Me.radRadioButtonHtml.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonHtml.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButtonHtml.TabIndex = 0
			Me.radRadioButtonHtml.Text = "Export to HTML"
'			Me.radRadioButtonHtml.ToggleStateChanged += New StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
			' 
			' radRadioButtonPdf
			' 
			Me.radRadioButtonPdf.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonPdf.Location = New System.Drawing.Point(9, 86)
			Me.radRadioButtonPdf.Name = "radRadioButtonPdf"
			Me.radRadioButtonPdf.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonPdf.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButtonPdf.TabIndex = 0
			Me.radRadioButtonPdf.Text = "Export to PDF"
'			Me.radRadioButtonPdf.ToggleStateChanged += New StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
			' 
			' radCheckBoxExportHierarchy
			' 
			Me.radCheckBoxExportHierarchy.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportHierarchy.Location = New System.Drawing.Point(9, 130)
			Me.radCheckBoxExportHierarchy.Name = "radCheckBoxExportHierarchy"
			Me.radCheckBoxExportHierarchy.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportHierarchy.Size = New System.Drawing.Size(125, 18)
			Me.radCheckBoxExportHierarchy.TabIndex = 2
			Me.radCheckBoxExportHierarchy.Text = "Export Hierarchy"
			Me.radCheckBoxExportHierarchy.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxExportVisual
			' 
			Me.radCheckBoxExportVisual.Enabled = False
			Me.radCheckBoxExportVisual.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportVisual.Location = New System.Drawing.Point(9, 152)
			Me.radCheckBoxExportVisual.Name = "radCheckBoxExportVisual"
			Me.radCheckBoxExportVisual.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportVisual.Size = New System.Drawing.Size(125, 18)
			Me.radCheckBoxExportVisual.TabIndex = 2
			Me.radCheckBoxExportVisual.Text = "Export Visual Settings"
			Me.radCheckBoxExportVisual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radButtonExport
			' 
			Me.radButtonExport.ForeColor = System.Drawing.Color.Black
			Me.radButtonExport.Location = New System.Drawing.Point(10, 230)
			Me.radButtonExport.Name = "radButtonExport"
			Me.radButtonExport.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButtonExport.Size = New System.Drawing.Size(144, 30)
			Me.radButtonExport.TabIndex = 1
			Me.radButtonExport.Text = "Run Export"
'			Me.radButtonExport.Click += New System.EventHandler(Me.radButtonExport_Click);
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.DataSource = Me.nwindDataSet
			Me.radGridView1.MasterTemplate.DataMember = "Orders"
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New System.Drawing.Size(1326, 749)
			Me.radGridView1.TabIndex = 7
			Me.radGridView1.Text = "radGridView1"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radButtonExport)
			Me.radGroupSettings.Controls.Add(Me.radRadioButtonExcel)
			Me.radGroupSettings.Controls.Add(Me.radRadioButtonCsv)
			Me.radGroupSettings.Controls.Add(Me.radRadioButtonHtml)
			Me.radGroupSettings.Controls.Add(Me.radRadioButtonPdf)
			Me.radGroupSettings.Controls.Add(Me.radComboBoxSummaries)
			Me.radGroupSettings.Controls.Add(Me.radCheckBoxExportHierarchy)
			Me.radGroupSettings.Controls.Add(Me.radCheckBoxExportVisual)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSettings.HeaderText = "Export Settings"
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 300)
			Me.radGroupSettings.TabIndex = 8
			Me.radGroupSettings.Text = "Export Settings"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1326, 749)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxSummaries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonExcel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonCsv, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonPdf, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxExportVisual, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxExportHierarchy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		#End Region

		Private saveFileDialog As System.Windows.Forms.SaveFileDialog
		Private radGridView1 As RadGridView
		Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private ordersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private order_detailsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private radCheckBoxExportVisual As RadCheckBox
		Private radCheckBoxExportHierarchy As RadCheckBox
		Private WithEvents radButtonExport As RadButton
		Private WithEvents radComboBoxSummaries As RadDropDownList
		Private radComboBoxItem3 As RadListDataItem
		Private radComboBoxItem4 As RadListDataItem
		Private radComboBoxItem5 As RadListDataItem
		Private radComboBoxItem6 As RadListDataItem
		Private radGroupSettings As RadGroupBox

		Private WithEvents radRadioButtonExcel As RadRadioButton
		Private WithEvents radRadioButtonHtml As RadRadioButton
		Private WithEvents radRadioButtonCsv As RadRadioButton
		Private WithEvents radRadioButtonPdf As RadRadioButton
	End Class
End Namespace
