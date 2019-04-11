Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources
Namespace Telerik.Examples.WinControls.GridView.FirstLook
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
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewCheckBoxColumn1 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Dim themeSource3 As New Telerik.WinControls.ThemeSource()
			Dim themeSource4 As New Telerik.WinControls.ThemeSource()
			Dim themeSource5 As New Telerik.WinControls.ThemeSource()
			Dim themeSource6 As New Telerik.WinControls.ThemeSource()
			Me.productsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.furnitureDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.furnitureDataSet2 = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radTextBoxDimension = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBoxMaterial = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBoxManufacturer = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBoxProductName = New Telerik.WinControls.UI.RadTextBox()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.cancelButton = New Telerik.WinControls.UI.RadButton()
			Me.updateButton = New Telerik.WinControls.UI.RadButton()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.productsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
			Me.furnitureDataSet1 = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
			Me.productsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.newButton = New Telerik.WinControls.UI.RadButton()
			Me.deleteButton = New Telerik.WinControls.UI.RadButton()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel5 = New Telerik.WinControls.UI.RadPanel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.furnitureDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
			Me.productsTableAdapter1 = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
			Me.productsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
			Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
			CType(Me.productsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.furnitureDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.furnitureDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radTextBoxDimension, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxProductName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.updateButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.furnitureDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deleteButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel4.SuspendLayout()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel5.SuspendLayout()
			CType(Me.furnitureDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' productsBindingSource1
			' 
			Me.productsBindingSource1.DataMember = "Products"
			Me.productsBindingSource1.DataSource = Me.furnitureDataSet2BindingSource
			' 
			' furnitureDataSet2BindingSource
			' 
			Me.furnitureDataSet2BindingSource.DataSource = Me.furnitureDataSet2
			Me.furnitureDataSet2BindingSource.Position = 0
			' 
			' furnitureDataSet2
			' 
			Me.furnitureDataSet2.DataSetName = "FurnitureDataSet2"
			Me.furnitureDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel1.Controls.Add(Me.radTextBoxDimension)
			Me.radPanel1.Controls.Add(Me.radTextBoxMaterial)
			Me.radPanel1.Controls.Add(Me.radTextBoxManufacturer)
			Me.radPanel1.Controls.Add(Me.radTextBoxProductName)
			Me.radPanel1.Controls.Add(Me.radComboBox1)
			Me.radPanel1.Controls.Add(Me.cancelButton)
			Me.radPanel1.Controls.Add(Me.updateButton)
			Me.radPanel1.Controls.Add(Me.radLabel6)
			Me.radPanel1.Controls.Add(Me.radLabel5)
			Me.radPanel1.Controls.Add(Me.radLabel4)
			Me.radPanel1.Controls.Add(Me.radLabel3)
			Me.radPanel1.Controls.Add(Me.radLabel2)
			Me.radPanel1.Location = New System.Drawing.Point(772, 293)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(264, 261)
			Me.radPanel1.TabIndex = 18
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			' 
			' radTextBoxDimension
			' 
			Me.radTextBoxDimension.Location = New System.Drawing.Point(101, 154)
			Me.radTextBoxDimension.Name = "radTextBoxDimension"
			Me.radTextBoxDimension.Size = New System.Drawing.Size(159, 20)
			Me.radTextBoxDimension.TabIndex = 24
			Me.radTextBoxDimension.ThemeName = "LightBlue"
			' 
			' radTextBoxMaterial
			' 
			Me.radTextBoxMaterial.Location = New System.Drawing.Point(101, 120)
			Me.radTextBoxMaterial.Name = "radTextBoxMaterial"
			Me.radTextBoxMaterial.Size = New System.Drawing.Size(159, 20)
			Me.radTextBoxMaterial.TabIndex = 23
			Me.radTextBoxMaterial.ThemeName = "LightBlue"
			' 
			' radTextBoxManufacturer
			' 
			Me.radTextBoxManufacturer.Location = New System.Drawing.Point(101, 49)
			Me.radTextBoxManufacturer.Name = "radTextBoxManufacturer"
			Me.radTextBoxManufacturer.Size = New System.Drawing.Size(159, 20)
			Me.radTextBoxManufacturer.TabIndex = 22
			Me.radTextBoxManufacturer.Text = "Pront Italy"
			Me.radTextBoxManufacturer.ThemeName = "LightBlue"
			' 
			' radTextBoxProductName
			' 
			Me.radTextBoxProductName.Location = New System.Drawing.Point(101, 15)
			Me.radTextBoxProductName.Name = "radTextBoxProductName"
			Me.radTextBoxProductName.Size = New System.Drawing.Size(159, 20)
			Me.radTextBoxProductName.TabIndex = 21
			Me.radTextBoxProductName.Text = "Chair Taskl"
			Me.radTextBoxProductName.ThemeName = "LightBlue"
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.AutoSizeItems = True
			Me.radComboBox1.Location = New System.Drawing.Point(101, 83)
			Me.radComboBox1.MaxDropDownItems = 3
			Me.radComboBox1.Name = "radComboBox1"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBox1.Size = New System.Drawing.Size(159, 22)
			Me.radComboBox1.TabIndex = 19

			' 
			' cancelButton
			' 
			Me.cancelButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cancelButton.BackColor = System.Drawing.Color.Transparent
			Me.cancelButton.Location = New System.Drawing.Point(183, 226)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(71, 22)
			Me.cancelButton.TabIndex = 18
			Me.cancelButton.Text = "Cancel"
			Me.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.cancelButton.ThemeName = "ControlDefault"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click);
			' 
			' updateButton
			' 
			Me.updateButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.updateButton.BackColor = System.Drawing.Color.Transparent
			Me.updateButton.Location = New System.Drawing.Point(101, 226)
			Me.updateButton.Name = "updateButton"
			Me.updateButton.Size = New System.Drawing.Size(76, 22)
			Me.updateButton.TabIndex = 18
			Me.updateButton.Text = "Update"
			Me.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.updateButton.ThemeName = "ControlDefault"
'			Me.updateButton.Click += New System.EventHandler(Me.updateButton_Click);
			' 
			' radLabel6
			' 
			Me.radLabel6.BackColor = System.Drawing.Color.Transparent
			Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel6.Location = New System.Drawing.Point(3, 120)
			Me.radLabel6.Name = "radLabel6"
			' 
			' 
			' 
			Me.radLabel6.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel6.Size = New System.Drawing.Size(38, 14)
			Me.radLabel6.TabIndex = 0
			Me.radLabel6.Text = "Lining:"
			Me.radLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel6.TextWrap = True
			Me.radLabel6.ThemeName = "RadLabelTheme"
			' 
			' radLabel5
			' 
			Me.radLabel5.BackColor = System.Drawing.Color.Transparent
			Me.radLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel5.Location = New System.Drawing.Point(3, 154)
			Me.radLabel5.Name = "radLabel5"
			' 
			' 
			' 
			Me.radLabel5.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel5.Size = New System.Drawing.Size(61, 14)
			Me.radLabel5.TabIndex = 0
			Me.radLabel5.Text = "Dimension:"
			Me.radLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel5.TextWrap = True
			Me.radLabel5.ThemeName = "RadLabelTheme"
			' 
			' radLabel4
			' 
			Me.radLabel4.BackColor = System.Drawing.Color.Transparent
			Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel4.Location = New System.Drawing.Point(3, 83)
			Me.radLabel4.Name = "radLabel4"
			' 
			' 
			' 
			Me.radLabel4.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel4.Size = New System.Drawing.Size(55, 14)
			Me.radLabel4.TabIndex = 0
			Me.radLabel4.Text = "Sales rep:"
			Me.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel4.TextWrap = True
			Me.radLabel4.ThemeName = "RadLabelTheme"
			' 
			' radLabel3
			' 
			Me.radLabel3.BackColor = System.Drawing.Color.Transparent
			Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel3.Location = New System.Drawing.Point(3, 49)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel3.Size = New System.Drawing.Size(74, 14)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Manufacturer:"
			Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel3.TextWrap = True
			Me.radLabel3.ThemeName = "RadLabelTheme"
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel2.Location = New System.Drawing.Point(3, 15)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel2.Size = New System.Drawing.Size(80, 14)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Product Name:"
			Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel2.TextWrap = True
			Me.radLabel2.ThemeName = "RadLabelTheme"
			' 
			' productsBindingSource4
			' 
			Me.productsBindingSource4.DataMember = "Products"
			Me.productsBindingSource4.DataSource = Me.furnitureDataSet1
			' 
			' furnitureDataSet1
			' 
			Me.furnitureDataSet1.DataSetName = "FurnitureDataSet1"
			Me.furnitureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsBindingSource6
			' 
			Me.productsBindingSource6.DataMember = "Products"
			Me.productsBindingSource6.DataSource = Me.furnitureDataSet1
			' 
			' productsBindingSource5
			' 
			Me.productsBindingSource5.DataMember = "Products"
			Me.productsBindingSource5.DataSource = Me.furnitureDataSet1
			' 
			' productsBindingSource3
			' 
			Me.productsBindingSource3.DataMember = "Products"
			Me.productsBindingSource3.DataSource = Me.furnitureDataSet1
			' 
			' radPanel2
			' 
			Me.radPanel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel2.BackColor = System.Drawing.Color.Transparent
			Me.radPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
			Me.radPanel2.Location = New System.Drawing.Point(21, 8)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New System.Drawing.Size(219, 161)
			Me.radPanel2.TabIndex = 21
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor3 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor4 = System.Drawing.Color.Transparent
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel1.Location = New System.Drawing.Point(73, 5)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			Me.radLabel1.Size = New System.Drawing.Size(97, 20)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Product Details"
			Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radLabel1.TextWrap = True
			Me.radLabel1.ThemeName = "ControlDefault"
			' 
			' newButton
			' 
			Me.newButton.AutoSize = True
			Me.newButton.BackColor = System.Drawing.Color.Transparent
			Me.newButton.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.newButton.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(122))))))
			Me.newButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.newButton.Location = New System.Drawing.Point(3, 5)
			Me.newButton.Name = "newButton"
			' 
			' 
			' 
			Me.newButton.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(122))))))
			Me.newButton.Size = New System.Drawing.Size(41, 24)
			Me.newButton.TabIndex = 17
			Me.newButton.Text = "New"
			Me.newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.newButton.Click += New System.EventHandler(Me.newButton_Click);
			CType(Me.newButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.newButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.newButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "New"
			CType(Me.newButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.newButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.newButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.newButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.newButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			CType(Me.newButton.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' deleteButton
			' 
			Me.deleteButton.AutoSize = True
			Me.deleteButton.BackColor = System.Drawing.Color.Transparent
			Me.deleteButton.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.deleteButton.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(122))))))
			Me.deleteButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.deleteButton.Location = New System.Drawing.Point(93, 5)
			Me.deleteButton.Name = "deleteButton"
			' 
			' 
			' 
			Me.deleteButton.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(122))))))
			Me.deleteButton.Size = New System.Drawing.Size(56, 24)
			Me.deleteButton.TabIndex = 17
			Me.deleteButton.Text = "Delete"
			Me.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.deleteButton.Click += New System.EventHandler(Me.deleteButton_Click);
			CType(Me.deleteButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.deleteButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.deleteButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Delete"
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(151))))))
			CType(Me.deleteButton.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radPanel3
			' 
			Me.radPanel3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel3.BackColor = System.Drawing.Color.Transparent
			Me.radPanel3.Controls.Add(Me.deleteButton)
			Me.radPanel3.Controls.Add(Me.newButton)
			Me.radPanel3.Controls.Add(Me.radGridView1)
			Me.radPanel3.Location = New System.Drawing.Point(12, 73)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New System.Drawing.Size(747, 481)
			Me.radPanel3.TabIndex = 19
			Me.radPanel3.ThemeName = "BusinessGrid"
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.12F
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.BackColor = System.Drawing.Color.Transparent
			Me.radGridView1.Cursor = System.Windows.Forms.Cursors.Default
			Me.radGridView1.EnableKeyMap = True
			Me.radGridView1.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.radGridView1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(143))))), (CInt(Fix((CByte(160))))))
			Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView1.Location = New System.Drawing.Point(1, 45)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowColumnChooser = False
			Me.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = False
			Me.radGridView1.MasterTemplate.AllowDragToGroup = False
			Me.radGridView1.MasterTemplate.AllowRowResize = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			Me.radGridView1.MasterTemplate.Caption = "Products"
			gridViewTextBoxColumn1.DataType = GetType(Integer)
			gridViewTextBoxColumn1.FieldName = "ID"
			gridViewTextBoxColumn1.HeaderText = "ID"
			gridViewTextBoxColumn1.IsVisible = False
			gridViewTextBoxColumn1.Name = "ID"
			gridViewImageColumn1.DataType = GetType(Byte())
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn2.FieldName = "ProductName"
			gridViewTextBoxColumn2.HeaderText = "ProductName"
			gridViewTextBoxColumn2.Name = "ProductName"
			gridViewTextBoxColumn3.FieldName = "Manufacturer"
			gridViewTextBoxColumn3.HeaderText = "Manufacturer"
			gridViewTextBoxColumn3.Name = "Manufacturer"
			gridViewTextBoxColumn4.FieldName = "Front"
			gridViewTextBoxColumn4.HeaderText = "Front"
			gridViewTextBoxColumn4.IsVisible = False
			gridViewTextBoxColumn4.Name = "Front"
			gridViewTextBoxColumn5.FieldName = "Back"
			gridViewTextBoxColumn5.HeaderText = "Back"
			gridViewTextBoxColumn5.IsVisible = False
			gridViewTextBoxColumn5.Name = "Back"
			gridViewTextBoxColumn6.FieldName = "Lining"
			gridViewTextBoxColumn6.HeaderText = "Lining"
			gridViewTextBoxColumn6.Name = "Lining"
			gridViewTextBoxColumn7.FieldName = "Dimensions"
			gridViewTextBoxColumn7.HeaderText = "Dimensions"
			gridViewTextBoxColumn7.Name = "Dimensions"
			gridViewTextBoxColumn8.DataType = GetType(Decimal)
			gridViewTextBoxColumn8.FieldName = "Price"
			gridViewTextBoxColumn8.FormatInfo = New System.Globalization.CultureInfo("en-US")
			gridViewTextBoxColumn8.FormatString = "{0:C}"
			gridViewTextBoxColumn8.HeaderText = "Price"
			gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn8.Name = "Price"
			gridViewTextBoxColumn9.DataType = GetType(Integer)
			gridViewTextBoxColumn9.FieldName = "Quantity"
			gridViewTextBoxColumn9.HeaderText = "Quantity"
			gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn9.Name = "Quantity"
			gridViewCheckBoxColumn1.DataType = GetType(Boolean)
			gridViewCheckBoxColumn1.FieldName = "Condition"
			gridViewCheckBoxColumn1.HeaderText = "Condition"
			gridViewCheckBoxColumn1.Name = "Condition"
			gridViewTextBoxColumn10.FieldName = "SalesRepresentative"
			gridViewTextBoxColumn10.HeaderText = "SalesRepresentative"
			gridViewTextBoxColumn10.Name = "SalesRepresentative"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewImageColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn6)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn7)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewCheckBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
			Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource1
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.MasterTemplate.ShowRowHeaderColumn = False
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(143))))), (CInt(Fix((CByte(160))))))
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New System.Drawing.Size(745, 435)
			Me.radGridView1.TabIndex = 16
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "BusinessGrid"
'			Me.radGridView1.CurrentRowChanged += New Telerik.WinControls.UI.CurrentRowChangedEventHandler(Me.radGridView1_CurrentRowChanged);
			' 
			' radPanel4
			' 
			Me.radPanel4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel4.BackColor = System.Drawing.Color.Transparent
			Me.radPanel4.Controls.Add(Me.radPanel5)
			Me.radPanel4.Controls.Add(Me.radLabel1)
			Me.radPanel4.Location = New System.Drawing.Point(772, 73)
			Me.radPanel4.Name = "radPanel4"
			' 
			' 
			' 
			Me.radPanel4.RootElement.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
			Me.radPanel4.Size = New System.Drawing.Size(264, 219)
			Me.radPanel4.TabIndex = 22
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
			' 
			' radPanel5
			' 
			Me.radPanel5.Controls.Add(Me.radPanel2)
			Me.radPanel5.Location = New System.Drawing.Point(0, 45)
			Me.radPanel5.Name = "radPanel5"
			Me.radPanel5.Size = New System.Drawing.Size(263, 175)
			Me.radPanel5.TabIndex = 1
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightWidth = 0F
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomWidth = 0F
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(249))))))
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.BottomLeftRounded = False
			Me.roundRectShape1.BottomRightRounded = False
			Me.roundRectShape1.Radius = 10
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("BusinessGrid.xml")
			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("RadComboBoxLightBlue.xml")
			themeSource3.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource3.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("RadLabelTheme.xml")
			themeSource4.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource4.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("RadTextBoxLightBlue.xml")
			themeSource5.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource5.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("BusinessGridScrollBar.xml")
			themeSource6.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource6.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("TitleBarBusinessGrid.xml")
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1, themeSource2, themeSource3, themeSource4, themeSource5, themeSource6})
			' 
			' furnitureDataSet1BindingSource
			' 
			Me.furnitureDataSet1BindingSource.DataSource = Me.furnitureDataSet1
			Me.furnitureDataSet1BindingSource.Position = 0
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.furnitureDataSet1
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' productsBindingSource2
			' 
			Me.productsBindingSource2.DataMember = "Products"
			Me.productsBindingSource2.DataSource = Me.furnitureDataSet2
			' 
			' radTitleBar1
			' 
			Me.radTitleBar1.BackColor = System.Drawing.Color.Transparent
			Me.radTitleBar1.Text = "Furniture DeTrevi"
			Me.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radTitleBar1.Location = New System.Drawing.Point(0, 0)
			Me.radTitleBar1.Name = "radTitleBar1"
			Me.radTitleBar1.Size = New System.Drawing.Size(1049, 67)
			Me.radTitleBar1.TabIndex = 23
			Me.radTitleBar1.TabStop = False
			Me.radTitleBar1.Text = "radTitleBar1"
			Me.radTitleBar1.ThemeName = "BusinessGrid"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(130))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(225))))))
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(130))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(225))))))
			Me.ClientSize = New System.Drawing.Size(1049, 565)
			Me.Controls.Add(Me.radTitleBar1)
			Me.Controls.Add(Me.radPanel4)
			Me.Controls.Add(Me.radPanel3)
			Me.Controls.Add(Me.radPanel1)
			Me.MinimumSize = New System.Drawing.Size(630, 530)
			Me.Name = "Form1"
			Me.Text = "Furniture DeTrevi"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.productsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.furnitureDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.furnitureDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radTextBoxDimension, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxMaterial, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxProductName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.updateButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.furnitureDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.newButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deleteButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			Me.radPanel3.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel4.ResumeLayout(False)
			Me.radPanel4.PerformLayout()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel5.ResumeLayout(False)
			CType(Me.furnitureDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radPanel1 As RadPanel
		Private WithEvents newButton As RadButton
		Private WithEvents deleteButton As RadButton
		Private radPanel3 As RadPanel
		Private radLabel1 As RadLabel
		Private radLabel3 As RadLabel
		Private radLabel2 As RadLabel
		Private WithEvents cancelButton As RadButton
		Private WithEvents updateButton As RadButton
		Private radLabel6 As RadLabel
		Private radLabel5 As RadLabel
		Private radLabel4 As RadLabel
		Private radComboBox1 As RadDropDownList
		Private radPanel2 As RadPanel
		Private radPanel4 As RadPanel
		Private furnitureDataSet1 As FurnitureDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private furnitureDataSet1BindingSource As System.Windows.Forms.BindingSource
		Private furnitureDataSet2BindingSource As System.Windows.Forms.BindingSource
		Private furnitureDataSet2 As FurnitureDataSet
		Private productsBindingSource1 As System.Windows.Forms.BindingSource
		Private productsTableAdapter1 As Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private productsBindingSource2 As System.Windows.Forms.BindingSource
		Private productsBindingSource4 As System.Windows.Forms.BindingSource
		Private productsBindingSource6 As System.Windows.Forms.BindingSource
		Private productsBindingSource5 As System.Windows.Forms.BindingSource
		Private productsBindingSource3 As System.Windows.Forms.BindingSource
		Private radTextBoxProductName As RadTextBox
		Private radTextBoxManufacturer As RadTextBox
		Private radTextBoxMaterial As RadTextBox
		Private radTextBoxDimension As RadTextBox
		Private radPanel5 As RadPanel
		Private radTitleBar1 As RadTitleBar
	End Class
End Namespace
