Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.TableElement
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
			Dim stringConverter1 As New System.ComponentModel.StringConverter()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim decimalConverter1 As New System.ComponentModel.DecimalConverter()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim int32Converter1 As New System.ComponentModel.Int32Converter()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxColumnHeaders = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxRowHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAutoSize = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFit = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAlternate = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditorHeaderHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorCellSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorRowSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxGroupPanel = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditorGroupRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxHotTracking = New Telerik.WinControls.UI.RadCheckBox()
			Me.furnitureDataSet = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxColumnHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAutoSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAlternate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorRowHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorCellSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorRowSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxGroupPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorGroupRowHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxHotTracking)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorGroupRowHeight)
			Me.settingsPanel.Controls.Add(Me.radLabel5)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxGroupPanel)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorRowSpacing)
			Me.settingsPanel.Controls.Add(Me.radLabel4)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorCellSpacing)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorRowHeight)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorHeaderHeight)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxAlternate)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxFit)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxAutoSize)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxRowHeader)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxColumnHeaders)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New System.Drawing.Point(818, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 611)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxColumnHeaders, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxRowHeader, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxAutoSize, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxFit, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxAlternate, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorHeaderHeight, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorRowHeight, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorCellSpacing, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel4, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorRowSpacing, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxGroupPanel, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel5, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorGroupRowHeight, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxHotTracking, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			gridViewTextBoxColumn1.DataTypeConverter = stringConverter1
			gridViewTextBoxColumn1.FieldName = "ProductName"
			gridViewTextBoxColumn1.HeaderText = "ProductName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "ProductName"
			gridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.None
			gridViewTextBoxColumn1.Width = 150
			gridViewTextBoxColumn2.DataTypeConverter = stringConverter1
			gridViewTextBoxColumn2.FieldName = "Manufacturer"
			gridViewTextBoxColumn2.HeaderText = "Manufacturer"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "Manufacturer"
			gridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.None
			gridViewTextBoxColumn2.Width = 150
			gridViewDecimalColumn1.DataType = GetType(Decimal)
			gridViewDecimalColumn1.DataTypeConverter = decimalConverter1
			gridViewDecimalColumn1.FieldName = "Price"
			gridViewDecimalColumn1.HeaderText = "Price"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.Name = "Price"
			gridViewDecimalColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.None
			gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.DataTypeConverter = int32Converter1
			gridViewDecimalColumn2.FieldName = "Quantity"
			gridViewDecimalColumn2.HeaderText = "Quantity"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.Name = "Quantity"
			gridViewDecimalColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.None
			gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewDecimalColumn2.Width = 80
			gridViewImageColumn1.DataType = GetType(System.Drawing.Image)
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.Name = "Photo"
			gridViewImageColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.None
			gridViewImageColumn1.Width = 100
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewDecimalColumn1, gridViewDecimalColumn2, gridViewImageColumn1})
			Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.Size = New System.Drawing.Size(1019, 613)
			Me.radGridView1.TabIndex = 0
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 49)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(64, 14)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Row height:"
			Me.radLabel1.TextWrap = True
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 95)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(108, 14)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Table header height:"
			Me.radLabel2.TextWrap = True
			' 
			' radCheckBoxColumnHeaders
			' 
			Me.radCheckBoxColumnHeaders.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxColumnHeaders.Location = New System.Drawing.Point(10, 328)
			Me.radCheckBoxColumnHeaders.Name = "radCheckBoxColumnHeaders"
			Me.radCheckBoxColumnHeaders.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxColumnHeaders.TabIndex = 3
			Me.radCheckBoxColumnHeaders.Text = "Show column headers"
'			Me.radCheckBoxColumnHeaders.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxColumnHeaders_ToggleStateChanged);
			' 
			' radCheckBoxRowHeader
			' 
			Me.radCheckBoxRowHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxRowHeader.Location = New System.Drawing.Point(10, 353)
			Me.radCheckBoxRowHeader.Name = "radCheckBoxRowHeader"
			Me.radCheckBoxRowHeader.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxRowHeader.TabIndex = 4
			Me.radCheckBoxRowHeader.Text = "Show row header column"
'			Me.radCheckBoxRowHeader.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxRowHeader_ToggleStateChanged);
			' 
			' radCheckBoxAutoSize
			' 
			Me.radCheckBoxAutoSize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxAutoSize.Location = New System.Drawing.Point(10, 377)
			Me.radCheckBoxAutoSize.Name = "radCheckBoxAutoSize"
			Me.radCheckBoxAutoSize.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxAutoSize.TabIndex = 5
			Me.radCheckBoxAutoSize.Text = "Auto size rows"
'			Me.radCheckBoxAutoSize.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAutoSize_ToggleStateChanged);
			' 
			' radCheckBoxFit
			' 
			Me.radCheckBoxFit.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFit.Location = New System.Drawing.Point(10, 401)
			Me.radCheckBoxFit.Name = "radCheckBoxFit"
			Me.radCheckBoxFit.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxFit.TabIndex = 6
			Me.radCheckBoxFit.Text = "Fit columns"
'			Me.radCheckBoxFit.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxFit_ToggleStateChanged);
			' 
			' radCheckBoxAlternate
			' 
			Me.radCheckBoxAlternate.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxAlternate.Location = New System.Drawing.Point(10, 425)
			Me.radCheckBoxAlternate.Name = "radCheckBoxAlternate"
			Me.radCheckBoxAlternate.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxAlternate.TabIndex = 7
			Me.radCheckBoxAlternate.Text = "Alternate rows"
'			Me.radCheckBoxAlternate.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAlternate_ToggleStateChanged);
			' 
			' radSpinEditorHeaderHeight
			' 
			Me.radSpinEditorHeaderHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorHeaderHeight.Location = New System.Drawing.Point(10, 116)
			Me.radSpinEditorHeaderHeight.Minimum = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.radSpinEditorHeaderHeight.Name = "radSpinEditorHeaderHeight"
			' 
			' 
			' 
			Me.radSpinEditorHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorHeaderHeight.ShowBorder = True
			Me.radSpinEditorHeaderHeight.Size = New System.Drawing.Size(180, 20)
			Me.radSpinEditorHeaderHeight.TabIndex = 8
			Me.radSpinEditorHeaderHeight.Value = New Decimal(New Integer() { 15, 0, 0, 0})
'			Me.radSpinEditorHeaderHeight.ValueChanged += New System.EventHandler(Me.radSpinEditorHeaderHeight_ValueChanged);
			' 
			' radSpinEditorRowHeight
			' 
			Me.radSpinEditorRowHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorRowHeight.Location = New System.Drawing.Point(10, 69)
			Me.radSpinEditorRowHeight.Minimum = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.radSpinEditorRowHeight.Name = "radSpinEditorRowHeight"
			' 
			' 
			' 
			Me.radSpinEditorRowHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorRowHeight.ShowBorder = True
			Me.radSpinEditorRowHeight.Size = New System.Drawing.Size(180, 20)
			Me.radSpinEditorRowHeight.TabIndex = 9
			Me.radSpinEditorRowHeight.Value = New Decimal(New Integer() { 15, 0, 0, 0})
'			Me.radSpinEditorRowHeight.ValueChanged += New System.EventHandler(Me.radSpinEditorRowHeight_ValueChanged);
			' 
			' radSpinEditorCellSpacing
			' 
			Me.radSpinEditorCellSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorCellSpacing.Location = New System.Drawing.Point(10, 210)
			Me.radSpinEditorCellSpacing.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorCellSpacing.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditorCellSpacing.Name = "radSpinEditorCellSpacing"
			' 
			' 
			' 
			Me.radSpinEditorCellSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorCellSpacing.ShowBorder = True
			Me.radSpinEditorCellSpacing.Size = New System.Drawing.Size(180, 20)
			Me.radSpinEditorCellSpacing.TabIndex = 11
'			Me.radSpinEditorCellSpacing.ValueChanged += New System.EventHandler(Me.radSpinEditorCellSpacing_ValueChanged);
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(10, 189)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(69, 14)
			Me.radLabel3.TabIndex = 10
			Me.radLabel3.Text = "Cell spacing:"
			Me.radLabel3.TextWrap = True
			' 
			' radSpinEditorRowSpacing
			' 
			Me.radSpinEditorRowSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorRowSpacing.Location = New System.Drawing.Point(10, 257)
			Me.radSpinEditorRowSpacing.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorRowSpacing.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditorRowSpacing.Name = "radSpinEditorRowSpacing"
			' 
			' 
			' 
			Me.radSpinEditorRowSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorRowSpacing.ShowBorder = True
			Me.radSpinEditorRowSpacing.Size = New System.Drawing.Size(180, 20)
			Me.radSpinEditorRowSpacing.TabIndex = 13
'			Me.radSpinEditorRowSpacing.ValueChanged += New System.EventHandler(Me.radSpinEditorRowSpacing_ValueChanged);
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel4.Location = New System.Drawing.Point(10, 236)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(72, 14)
			Me.radLabel4.TabIndex = 12
			Me.radLabel4.Text = "Row spacing:"
			Me.radLabel4.TextWrap = True
			' 
			' radCheckBoxGroupPanel
			' 
			Me.radCheckBoxGroupPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxGroupPanel.Location = New System.Drawing.Point(10, 304)
			Me.radCheckBoxGroupPanel.Name = "radCheckBoxGroupPanel"
			Me.radCheckBoxGroupPanel.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxGroupPanel.TabIndex = 14
			Me.radCheckBoxGroupPanel.Text = "Show group panel"
'			Me.radCheckBoxGroupPanel.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxGroupPanel_ToggleStateChanged);
			' 
			' radSpinEditorGroupRowHeight
			' 
			Me.radSpinEditorGroupRowHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorGroupRowHeight.Location = New System.Drawing.Point(10, 163)
			Me.radSpinEditorGroupRowHeight.Minimum = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.radSpinEditorGroupRowHeight.Name = "radSpinEditorGroupRowHeight"
			' 
			' 
			' 
			Me.radSpinEditorGroupRowHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorGroupRowHeight.ShowBorder = True
			Me.radSpinEditorGroupRowHeight.Size = New System.Drawing.Size(180, 20)
			Me.radSpinEditorGroupRowHeight.TabIndex = 16
			Me.radSpinEditorGroupRowHeight.Value = New Decimal(New Integer() { 15, 0, 0, 0})
'			Me.radSpinEditorGroupRowHeight.ValueChanged += New System.EventHandler(Me.radSpinEditorGroupRowHeight_ValueChanged);
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel5.Location = New System.Drawing.Point(10, 142)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(94, 14)
			Me.radLabel5.TabIndex = 15
			Me.radLabel5.Text = "Group row height:"
			Me.radLabel5.TextWrap = True
			' 
			' radCheckBoxHotTracking
			' 
			Me.radCheckBoxHotTracking.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxHotTracking.Location = New System.Drawing.Point(10, 449)
			Me.radCheckBoxHotTracking.Name = "radCheckBoxHotTracking"
			Me.radCheckBoxHotTracking.Size = New System.Drawing.Size(180, 18)
			Me.radCheckBoxHotTracking.TabIndex = 17
			Me.radCheckBoxHotTracking.Text = "Enable hot tracking"
'			Me.radCheckBoxHotTracking.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxHotTracking_ToggleStateChanged);
			' 
			' furnitureDataSet
			' 
			Me.furnitureDataSet.DataSetName = "FurnitureDataSet"
			Me.furnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.furnitureDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1019, 613)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxColumnHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAutoSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAlternate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorRowHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorCellSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorRowSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxGroupPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorGroupRowHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.furnitureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radCheckBoxFit As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxAutoSize As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxRowHeader As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxColumnHeaders As Telerik.WinControls.UI.RadCheckBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckBoxAlternate As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radSpinEditorRowSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorCellSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorRowHeight As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditorHeaderHeight As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditorGroupRowHeight As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckBoxGroupPanel As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxHotTracking As Telerik.WinControls.UI.RadCheckBox
		Private furnitureDataSet As Telerik.Examples.WinControls.DataSources.FurnitureDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter
	End Class
End Namespace
