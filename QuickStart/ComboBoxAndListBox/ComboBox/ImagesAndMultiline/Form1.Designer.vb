Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ImagesAndMultiline
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGroupBoxItemSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboTextImageRel = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem18 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem19 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem20 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem21 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem22 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboTextAlignment = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem23 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem24 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem25 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem26 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem27 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem28 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem29 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem30 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem31 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboImageAlignment = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem32 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem33 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem34 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem35 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem36 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem37 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem38 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem39 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem40 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem41 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem42 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem43 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radLblTextImageRel = New Telerik.WinControls.UI.RadLabel()
			Me.radLblTextAlignment = New Telerik.WinControls.UI.RadLabel()
			Me.radLblImageAlignment = New Telerik.WinControls.UI.RadLabel()
			Me.radTxtText = New Telerik.WinControls.UI.RadTextBox()
			Me.radTxtIndex = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLblIndex = New Telerik.WinControls.UI.RadLabel()
			Me.radLblDropDownStyle = New Telerik.WinControls.UI.RadLabel()
			Me.radComboDropDownStyle = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem15 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem16 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupBoxComboSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblDropDownAnim = New Telerik.WinControls.UI.RadLabel()
			Me.radComboDropDownAnim = New Telerik.WinControls.UI.RadDropDownList()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxItemSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxItemSettings.SuspendLayout()
			CType(Me.radComboTextImageRel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboTextAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboImageAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblTextImageRel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblTextAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblImageAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxComboSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxComboSettings.SuspendLayout()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDropDownAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 318)
			Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxComboSettings)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxItemSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxItemSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxComboSettings, 0)
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DataSource = Me.employeesBindingSource
			Me.radComboDemo.DisplayMember = "LastName"
			Me.radComboDemo.DropDownHeight = 303
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.Name = "radComboDemo"
			Me.radComboDemo.NullText = "Employees..."
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			Me.radComboDemo.Text = ""
			Me.radComboDemo.ThemeName = "ControlDefault"
			Me.radComboDemo.ValueMember = "EmployeeID"
'			Me.radComboDemo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox1_SelectedIndexChanged);
'			Me.radComboDemo.ItemDataBound += New Telerik.WinControls.UI.ListItemDataBoundEventHandler(Me.radComboDemo_ItemDataBound);
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
			' radGroupBoxItemSettings
			' 
			Me.radGroupBoxItemSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBoxItemSettings.Controls.Add(Me.radComboTextImageRel)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radComboTextAlignment)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radComboImageAlignment)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radLblTextImageRel)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radLblTextAlignment)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radLblImageAlignment)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radTxtText)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radTxtIndex)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radLabel1)
			Me.radGroupBoxItemSettings.Controls.Add(Me.radLblIndex)
			Me.radGroupBoxItemSettings.FooterImageIndex = -1
			Me.radGroupBoxItemSettings.FooterImageKey = ""
			Me.radGroupBoxItemSettings.FooterText = ""
			Me.radGroupBoxItemSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxItemSettings.HeaderImageIndex = -1
			Me.radGroupBoxItemSettings.HeaderImageKey = ""
			Me.radGroupBoxItemSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBoxItemSettings.HeaderText = " Item Settings "
			Me.radGroupBoxItemSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBoxItemSettings.Name = "radGroupBoxItemSettings"
			Me.radGroupBoxItemSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBoxItemSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxItemSettings.Size = New System.Drawing.Size(180, 266)
			Me.radGroupBoxItemSettings.TabIndex = 0
			Me.radGroupBoxItemSettings.Text = " Item Settings "
			' 
			' radComboBoxItem19
			' 
			Me.radComboBoxItem19.Text = "ImageAboveText"
			' 
			' radComboBoxItem20
			' 
			Me.radComboBoxItem20.Text = "ImageBeforeText"
			' 
			' radComboBoxItem21
			' 
			Me.radComboBoxItem21.Text = "TextAboveImage"
			' 
			' radComboBoxItem22
			' 
			Me.radComboBoxItem22.Text = "TextBeforeImage"
			' 
			' radComboBoxItem18
			' 
			Me.radComboBoxItem18.Text = "Overlay"
			' 
			' radComboTextImageRel
			' 
			Me.radComboTextImageRel.ForeColor = System.Drawing.Color.Black
			Me.radComboTextImageRel.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radComboBoxItem19, Me.radComboBoxItem20, Me.radComboBoxItem21, Me.radComboBoxItem22, Me.radComboBoxItem18})
			Me.radComboTextImageRel.Location = New System.Drawing.Point(12, 233)
			Me.radComboTextImageRel.Name = "radComboTextImageRel"
			' 
			' 
			' 
			Me.radComboTextImageRel.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboTextImageRel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboTextImageRel.Size = New System.Drawing.Size(139, 20)
			Me.radComboTextImageRel.TabIndex = 3
'			Me.radComboTextImageRel.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.comboTextImageRel_SelectedIndexChanged);
			' 
			' radComboBoxItem23
			' 
			Me.radComboBoxItem23.Text = "TopLeft"
			' 
			' radComboBoxItem24
			' 
			Me.radComboBoxItem24.Text = "TopCenter"
			' 
			' radComboBoxItem25
			' 
			Me.radComboBoxItem25.Text = "TopRight"
			' 
			' radComboBoxItem26
			' 
			Me.radComboBoxItem26.Text = "MiddleLeft"
			' 
			' radComboBoxItem27
			' 
			Me.radComboBoxItem27.Text = "MiddleCenter"
			' 
			' radComboBoxItem28
			' 
			Me.radComboBoxItem28.Text = "MiddleRight"
			' 
			' radComboBoxItem29
			' 
			Me.radComboBoxItem29.Text = "BottomLeft"
			' 
			' radComboBoxItem30
			' 
			Me.radComboBoxItem30.Text = "BottomCenter"
			' 
			' radComboBoxItem31
			' 
			Me.radComboBoxItem31.Text = "BottomRight"
			' 
			' radComboTextAlignment
			' 
			Me.radComboTextAlignment.ForeColor = System.Drawing.Color.Black
			Me.radComboTextAlignment.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radComboBoxItem23, Me.radComboBoxItem24, Me.radComboBoxItem25, Me.radComboBoxItem26, Me.radComboBoxItem27, Me.radComboBoxItem28, Me.radComboBoxItem29, Me.radComboBoxItem30, Me.radComboBoxItem31})
			Me.radComboTextAlignment.Location = New System.Drawing.Point(12, 187)
			Me.radComboTextAlignment.Name = "radComboTextAlignment"
			' 
			' 
			' 
			Me.radComboTextAlignment.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboTextAlignment.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboTextAlignment.Size = New System.Drawing.Size(139, 20)
			Me.radComboTextAlignment.TabIndex = 3
			Me.radComboTextAlignment.Text = ""
'			Me.radComboTextAlignment.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.comboTextAlign_SelectedIndexChanged);
			' 
			' radComboBoxItem32
			' 
			Me.radComboBoxItem32.Text = "TopLeft"
			' 
			' radComboBoxItem33
			' 
			Me.radComboBoxItem33.Text = "TopCenter"
			' 
			' radComboBoxItem34
			' 
			Me.radComboBoxItem34.Text = "TopRight"
			' 
			' radComboBoxItem35
			' 
			Me.radComboBoxItem35.Text = "MiddleLeft"
			' 
			' radComboBoxItem36
			' 
			Me.radComboBoxItem36.Text = "MiddleCenter"
			' 
			' radComboBoxItem37
			' 
			Me.radComboBoxItem37.Text = "MiddleRight"
			' 
			' radComboBoxItem38
			' 
			Me.radComboBoxItem38.Text = "BottomLeft"
			' 
			' radComboBoxItem39
			' 
			Me.radComboBoxItem39.Text = "BottomCenter"
			' 
			' radComboBoxItem40
			' 
			Me.radComboBoxItem40.Text = "BottomRight"
			' 
			' radComboBoxItem41
			' 
			Me.radComboBoxItem41.Text = "Text"
			' 
			' radComboBoxItem42
			' 
			Me.radComboBoxItem42.Text = "Image"
			' 
			' radComboBoxItem43
			' 
			Me.radComboBoxItem43.Text = "ImageAndText"
			' 
			' radComboImageAlignment
			' 
			Me.radComboImageAlignment.ForeColor = System.Drawing.Color.Black
			Me.radComboImageAlignment.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radComboBoxItem32, Me.radComboBoxItem33, Me.radComboBoxItem34, Me.radComboBoxItem35, Me.radComboBoxItem36, Me.radComboBoxItem37, Me.radComboBoxItem38, Me.radComboBoxItem39, Me.radComboBoxItem40})
			Me.radComboImageAlignment.Location = New System.Drawing.Point(12, 141)
			Me.radComboImageAlignment.Name = "radComboImageAlignment"
			' 
			' 
			' 
			Me.radComboImageAlignment.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboImageAlignment.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboImageAlignment.Size = New System.Drawing.Size(139, 20)
			Me.radComboImageAlignment.TabIndex = 3
			Me.radComboImageAlignment.Text = ""
'			Me.radComboImageAlignment.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.comboImageAlign_SelectedIndexChanged);
			' 
			' radLblTextImageRel
			' 
			Me.radLblTextImageRel.ForeColor = System.Drawing.Color.Black
			Me.radLblTextImageRel.Location = New System.Drawing.Point(12, 213)
			Me.radLblTextImageRel.Name = "radLblTextImageRel"
			' 
			' 
			' 
			Me.radLblTextImageRel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblTextImageRel.Size = New System.Drawing.Size(109, 14)
			Me.radLblTextImageRel.TabIndex = 2
			Me.radLblTextImageRel.Text = "Text-Image Relation:"
			' 
			' radLblTextAlignment
			' 
			Me.radLblTextAlignment.ForeColor = System.Drawing.Color.Black
			Me.radLblTextAlignment.Location = New System.Drawing.Point(12, 167)
			Me.radLblTextAlignment.Name = "radLblTextAlignment"
			' 
			' 
			' 
			Me.radLblTextAlignment.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblTextAlignment.Size = New System.Drawing.Size(83, 14)
			Me.radLblTextAlignment.TabIndex = 2
			Me.radLblTextAlignment.Text = "Text Alignment:"
			' 
			' radLblImageAlignment
			' 
			Me.radLblImageAlignment.ForeColor = System.Drawing.Color.Black
			Me.radLblImageAlignment.Location = New System.Drawing.Point(12, 121)
			Me.radLblImageAlignment.Name = "radLblImageAlignment"
			' 
			' 
			' 
			Me.radLblImageAlignment.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblImageAlignment.Size = New System.Drawing.Size(92, 14)
			Me.radLblImageAlignment.TabIndex = 2
			Me.radLblImageAlignment.Text = "Image Alignment:"
			' 
			' radTxtText
			' 
			Me.radTxtText.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Location = New System.Drawing.Point(44, 49)
			Me.radTxtText.Name = "radTxtText"
			' 
			' 
			' 
			Me.radTxtText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Size = New System.Drawing.Size(107, 20)
			Me.radTxtText.TabIndex = 1
'			Me.radTxtText.TextChanged += New System.EventHandler(Me.OnRadTextBox_TextChanged);
			' 
			' radTxtIndex
			' 
			Me.radTxtIndex.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Location = New System.Drawing.Point(44, 23)
			Me.radTxtIndex.Name = "radTxtIndex"
			Me.radTxtIndex.ReadOnly = True
			' 
			' 
			' 
			Me.radTxtIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Size = New System.Drawing.Size(107, 20)
			Me.radTxtIndex.TabIndex = 1
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(8, 52)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(29, 14)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Text:"
			' 
			' radLblIndex
			' 
			Me.radLblIndex.ForeColor = System.Drawing.Color.Black
			Me.radLblIndex.Location = New System.Drawing.Point(8, 26)
			Me.radLblIndex.Name = "radLblIndex"
			' 
			' 
			' 
			Me.radLblIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblIndex.Size = New System.Drawing.Size(35, 14)
			Me.radLblIndex.TabIndex = 0
			Me.radLblIndex.Text = "Index:"
			' 
			' radLblDropDownStyle
			' 
			Me.radLblDropDownStyle.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownStyle.Location = New System.Drawing.Point(12, 28)
			Me.radLblDropDownStyle.Name = "radLblDropDownStyle"
			' 
			' 
			' 
			Me.radLblDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownStyle.Size = New System.Drawing.Size(93, 14)
			Me.radLblDropDownStyle.TabIndex = 2
			Me.radLblDropDownStyle.Text = "Drop-Down Style:"
			' 
			' radComboDropDownStyle
			' 
			Me.radComboDropDownStyle.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownStyle.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radComboBoxItem15, Me.radComboBoxItem16})
			Me.radComboDropDownStyle.Location = New System.Drawing.Point(12, 47)
			Me.radComboDropDownStyle.Name = "radComboDropDownStyle"
			' 
			' 
			' 
			Me.radComboDropDownStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownStyle.Size = New System.Drawing.Size(139, 20)
			Me.radComboDropDownStyle.TabIndex = 3
			Me.radComboDropDownStyle.Text = ""
'			Me.radComboDropDownStyle.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.comboDropDownStyle_SelectedIndexChanged);
			' 
			' radComboBoxItem15
			' 
			Me.radComboBoxItem15.Text = "DropDown"
			' 
			' radComboBoxItem16
			' 
			Me.radComboBoxItem16.Text = "DropDownList"
			' 
			' radGroupBoxComboSettings
			' 
			Me.radGroupBoxComboSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBoxComboSettings.Controls.Add(Me.radLblDropDownAnim)
			Me.radGroupBoxComboSettings.Controls.Add(Me.radComboDropDownAnim)
			Me.radGroupBoxComboSettings.Controls.Add(Me.radLblDropDownStyle)
			Me.radGroupBoxComboSettings.Controls.Add(Me.radComboDropDownStyle)
			Me.radGroupBoxComboSettings.FooterImageIndex = -1
			Me.radGroupBoxComboSettings.FooterImageKey = ""
			Me.radGroupBoxComboSettings.FooterText = ""
			Me.radGroupBoxComboSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxComboSettings.HeaderImageIndex = -1
			Me.radGroupBoxComboSettings.HeaderImageKey = ""
			Me.radGroupBoxComboSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBoxComboSettings.HeaderText = " Combo Box Settings "
			Me.radGroupBoxComboSettings.Location = New System.Drawing.Point(10, 277)
			Me.radGroupBoxComboSettings.Name = "radGroupBoxComboSettings"
			Me.radGroupBoxComboSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBoxComboSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxComboSettings.Size = New System.Drawing.Size(180, 154)
			Me.radGroupBoxComboSettings.TabIndex = 1
			Me.radGroupBoxComboSettings.Text = " Combo Box Settings "
			' 
			' radLblDropDownAnim
			' 
			Me.radLblDropDownAnim.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownAnim.Location = New System.Drawing.Point(12, 72)
			Me.radLblDropDownAnim.Name = "radLblDropDownAnim"
			' 
			' 
			' 
			Me.radLblDropDownAnim.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownAnim.Size = New System.Drawing.Size(118, 14)
			Me.radLblDropDownAnim.TabIndex = 2
			Me.radLblDropDownAnim.Text = "Drop-Down Animation:"
			' 
			' radComboDropDownAnim
			' 
			Me.radComboDropDownAnim.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownAnim.Location = New System.Drawing.Point(12, 91)
			Me.radComboDropDownAnim.Name = "radComboDropDownAnim"
			' 
			' 
			' 
			Me.radComboDropDownAnim.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDropDownAnim.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownAnim.Size = New System.Drawing.Size(139, 20)
			Me.radComboDropDownAnim.TabIndex = 3
			Me.radComboDropDownAnim.Text = ""
'			Me.radComboDropDownAnim.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.OnRadComboAnimType_SelectedIndexChanged);
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.Size = New System.Drawing.Size(1224, 737)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxItemSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxItemSettings.ResumeLayout(False)
			Me.radGroupBoxItemSettings.PerformLayout()
			CType(Me.radComboTextImageRel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboTextAlignment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboImageAlignment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblTextImageRel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblTextAlignment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblImageAlignment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxComboSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxComboSettings.ResumeLayout(False)
			Me.radGroupBoxComboSettings.PerformLayout()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDropDownAnim, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		#End Region

		Private WithEvents radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBoxItemSettings As Telerik.WinControls.UI.RadGroupBox
		Private radTxtIndex As Telerik.WinControls.UI.RadTextBox
		Private radLblIndex As Telerik.WinControls.UI.RadLabel
		Private WithEvents radTxtText As Telerik.WinControls.UI.RadTextBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radComboDropDownStyle As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radComboTextImageRel As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radComboTextAlignment As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radComboImageAlignment As Telerik.WinControls.UI.RadDropDownList
		Private radLblDropDownStyle As Telerik.WinControls.UI.RadLabel
		Private radLblTextImageRel As Telerik.WinControls.UI.RadLabel
		Private radLblTextAlignment As Telerik.WinControls.UI.RadLabel
		Private radLblImageAlignment As Telerik.WinControls.UI.RadLabel
		Private radGroupBoxComboSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblDropDownAnim As Telerik.WinControls.UI.RadLabel
		Private WithEvents radComboDropDownAnim As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem15 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem16 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem18 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem19 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem20 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem21 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem22 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem23 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem24 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem25 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem26 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem27 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem28 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem29 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem30 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem31 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem32 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem33 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem34 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem35 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem36 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem37 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem38 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem39 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem40 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem41 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem42 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem43 As Telerik.WinControls.UI.RadListDataItem
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace