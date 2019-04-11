Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.GridLayout
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridGroupByExpression1 As New Telerik.WinControls.UI.GridGroupByExpression()
			Dim groupDescriptor1 As New Telerik.WinControls.Data.GroupDescriptor()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButton1)
			Me.settingsPanel.Controls.Add(Me.radButton2)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton1, 0)
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
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "Views.PNG")
			Me.imageList1.Images.SetKeyName(1, "Organize.PNG")
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = "Telerik.Examples.WinControls.Resources.RadToolStripVista.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1})
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(254))))))
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			'this.radGridView1.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn1.FieldName = "CustomerID"
			gridViewTextBoxColumn1.HeaderText = "CustomerID"
			gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn1.Name = "CustomerID"
			gridViewTextBoxColumn1.Width = 223
			gridViewTextBoxColumn2.FieldName = "CompanyName"
			gridViewTextBoxColumn2.HeaderText = "CompanyName"
			gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn2.Name = "CompanyName"
			gridViewTextBoxColumn2.Width = 267
			gridViewTextBoxColumn3.FieldName = "Country"
			gridViewTextBoxColumn3.HeaderText = "Country"
			gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn3.Name = "Country"
			gridViewTextBoxColumn3.Width = 223
			gridViewTextBoxColumn4.FieldName = "City"
			gridViewTextBoxColumn4.HeaderText = "City"
			gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn4.Name = "City"
			gridViewTextBoxColumn4.Width = 223
			gridViewTextBoxColumn5.FieldName = "ContactName"
			gridViewTextBoxColumn5.HeaderText = "ContactName"
			gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn5.Name = "ContactName"
			gridViewTextBoxColumn5.Width = 267
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)

			groupDescriptor1.Expression = "Country"
			Me.radGridView1.GroupDescriptors.Add(groupDescriptor1)

			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(1224, 737)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "Vista"
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton1.Location = New System.Drawing.Point(10, 9)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(180, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Save Layout"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton2.Location = New System.Drawing.Point(10, 38)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(180, 23)
			Me.radButton2.TabIndex = 0
			Me.radButton2.Text = "Load Layout"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private imageList1 As System.Windows.Forms.ImageList
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
