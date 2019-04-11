Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.FirstLook
    Partial Class Form1
        Inherits ExamplesForm
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
            Dim radListDataItem28 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem29 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem30 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem31 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem32 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem33 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem34 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem10 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem11 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem12 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem17 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem18 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem19 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem20 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem21 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem22 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem23 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem24 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem25 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem26 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem27 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radListBoxDemo = New Telerik.WinControls.UI.RadListControl()
            Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
            Me.radComboSortStyle = New Telerik.WinControls.UI.RadDropDownList()
            Me.radComboSelectionMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLblSort = New Telerik.WinControls.UI.RadLabel()
            Me.radLblSelection = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupItem = New Telerik.WinControls.UI.RadGroupBox()
            Me.radComboTextOrientation = New Telerik.WinControls.UI.RadDropDownList()
            Me.radComboTextAlign = New Telerik.WinControls.UI.RadDropDownList()
            Me.radComboImageAlign = New Telerik.WinControls.UI.RadDropDownList()
            Me.radComboTextImage = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLblTextImage = New Telerik.WinControls.UI.RadLabel()
            Me.radLblTextOrientation = New Telerik.WinControls.UI.RadLabel()
            Me.radLblTextAlignment = New Telerik.WinControls.UI.RadLabel()
            Me.radLblImageAlign = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupSettings.SuspendLayout()
            DirectCast(Me.radComboSortStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radComboSelectionMode, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblSort, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblSelection, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupItem.SuspendLayout()
            DirectCast(Me.radComboTextOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radComboTextAlign, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radComboImageAlign, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radComboTextImage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblTextImage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblTextOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblTextAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLblImageAlign, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.radDropDownList1)
            Me.settingsPanel.Controls.Add(Me.radGroupItem)
            Me.settingsPanel.Controls.Add(Me.radGroupSettings)
            Me.settingsPanel.Location = New System.Drawing.Point(1101, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(255, 747)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupItem, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "MPEG.gif")
            Me.imageList1.Images.SetKeyName(6, "Quicktime.gif")
            Me.imageList1.Images.SetKeyName(7, "AudioCD.gif")
            Me.imageList1.Images.SetKeyName(8, "Folder.gif")
            Me.imageList1.Images.SetKeyName(9, "Help.gif")
            ' 
            ' radListBoxDemo
            ' 
            Me.radListBoxDemo.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radListBoxDemo.AutoSizeItems = True
            Me.radListBoxDemo.BackColor = System.Drawing.Color.Transparent
            Me.radListBoxDemo.CaseSensitiveSort = True
            Me.radListBoxDemo.ForeColor = System.Drawing.Color.Black
            Me.radListBoxDemo.ItemHeight = 18
            Me.radListBoxDemo.Location = New System.Drawing.Point(514, 190)
            Me.radListBoxDemo.Name = "radListBoxDemo"
            Me.radListBoxDemo.Size = New System.Drawing.Size(329, 368)
            Me.radListBoxDemo.TabIndex = 3
            Me.radListBoxDemo.Text = "(NONE)"
            ' 
            ' radGroupSettings
            ' 
            Me.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupSettings.Controls.Add(Me.radComboSortStyle)
            Me.radGroupSettings.Controls.Add(Me.radComboSelectionMode)
            Me.radGroupSettings.Controls.Add(Me.radLblSort)
            Me.radGroupSettings.Controls.Add(Me.radLblSelection)
            Me.radGroupSettings.FooterImageIndex = -1
            Me.radGroupSettings.FooterImageKey = ""
            Me.radGroupSettings.FooterText = ""
            Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
            Me.radGroupSettings.HeaderImageIndex = -1
            Me.radGroupSettings.HeaderImageKey = ""
            Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupSettings.HeaderText = "ListBox General Settings"
            Me.radGroupSettings.Location = New System.Drawing.Point(114, 54)
            Me.radGroupSettings.Name = "radGroupSettings"
            Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupSettings.Size = New System.Drawing.Size(180, 119)
            Me.radGroupSettings.TabIndex = 0
            Me.radGroupSettings.Text = "ListBox General Settings"
            ' 
            ' radComboSortStyle
            ' 
            Me.radComboSortStyle.DropDownAnimationEnabled = True
            Me.radComboSortStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboSortStyle.ForeColor = System.Drawing.Color.Black
            radListDataItem28.Text = "Ascending"
            radListDataItem28.TextWrap = True
            radListDataItem29.Text = "Descending"
            radListDataItem29.TextWrap = True
            radListDataItem30.Text = "None"
            radListDataItem30.TextWrap = True
            Me.radComboSortStyle.Items.Add(radListDataItem28)
            Me.radComboSortStyle.Items.Add(radListDataItem29)
            Me.radComboSortStyle.Items.Add(radListDataItem30)
            Me.radComboSortStyle.Location = New System.Drawing.Point(13, 85)
            Me.radComboSortStyle.MaxDropDownItems = 0
            Me.radComboSortStyle.Name = "radComboSortStyle"
            ' 
            ' 
            ' 
            Me.radComboSortStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboSortStyle.ShowImageInEditorArea = True
            Me.radComboSortStyle.Size = New System.Drawing.Size(138, 20)
            Me.radComboSortStyle.TabIndex = 1
            ' 
            ' radComboSelectionMode
            ' 
            Me.radComboSelectionMode.DropDownAnimationEnabled = True
            Me.radComboSelectionMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboSelectionMode.ForeColor = System.Drawing.Color.Black
            radListDataItem31.Text = "None"
            radListDataItem31.TextWrap = True
            radListDataItem32.Text = "One"
            radListDataItem32.TextWrap = True
            radListDataItem33.Text = "MultiSimple"
            radListDataItem33.TextWrap = True
            radListDataItem34.Text = "MultiExtended"
            radListDataItem34.TextWrap = True
            Me.radComboSelectionMode.Items.Add(radListDataItem31)
            Me.radComboSelectionMode.Items.Add(radListDataItem32)
            Me.radComboSelectionMode.Items.Add(radListDataItem33)
            Me.radComboSelectionMode.Items.Add(radListDataItem34)
            Me.radComboSelectionMode.Location = New System.Drawing.Point(13, 39)
            Me.radComboSelectionMode.MaxDropDownItems = 0
            Me.radComboSelectionMode.Name = "radComboSelectionMode"
            ' 
            ' 
            ' 
            Me.radComboSelectionMode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboSelectionMode.ShowImageInEditorArea = True
            Me.radComboSelectionMode.Size = New System.Drawing.Size(138, 20)
            Me.radComboSelectionMode.TabIndex = 1
            ' 
            ' radLblSort
            ' 
            Me.radLblSort.ForeColor = System.Drawing.Color.Black
            Me.radLblSort.Location = New System.Drawing.Point(13, 65)
            Me.radLblSort.Name = "radLblSort"
            Me.radLblSort.Size = New System.Drawing.Size(56, 18)
            Me.radLblSort.TabIndex = 0
            Me.radLblSort.Text = "Sort Style:"
            ' 
            ' radLblSelection
            ' 
            Me.radLblSelection.ForeColor = System.Drawing.Color.Black
            Me.radLblSelection.Location = New System.Drawing.Point(13, 19)
            Me.radLblSelection.Name = "radLblSelection"
            Me.radLblSelection.Size = New System.Drawing.Size(87, 18)
            Me.radLblSelection.TabIndex = 0
            Me.radLblSelection.Text = "Selection Mode:"
            ' 
            ' radGroupItem
            ' 
            Me.radGroupItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupItem.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupItem.Controls.Add(Me.radComboTextOrientation)
            Me.radGroupItem.Controls.Add(Me.radComboTextAlign)
            Me.radGroupItem.Controls.Add(Me.radComboImageAlign)
            Me.radGroupItem.Controls.Add(Me.radComboTextImage)
            Me.radGroupItem.Controls.Add(Me.radLblTextImage)
            Me.radGroupItem.Controls.Add(Me.radLblTextOrientation)
            Me.radGroupItem.Controls.Add(Me.radLblTextAlignment)
            Me.radGroupItem.Controls.Add(Me.radLblImageAlign)
            Me.radGroupItem.FooterImageIndex = -1
            Me.radGroupItem.FooterImageKey = ""
            Me.radGroupItem.FooterText = ""
            Me.radGroupItem.ForeColor = System.Drawing.Color.Black
            Me.radGroupItem.HeaderImageIndex = -1
            Me.radGroupItem.HeaderImageKey = ""
            Me.radGroupItem.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupItem.HeaderText = "Item Settings"
            Me.radGroupItem.Location = New System.Drawing.Point(114, 179)
            Me.radGroupItem.Name = "radGroupItem"
            Me.radGroupItem.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupItem.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupItem.Size = New System.Drawing.Size(180, 225)
            Me.radGroupItem.TabIndex = 0
            Me.radGroupItem.Text = "Item Settings"
            ' 
            ' radComboTextOrientation
            ' 
            Me.radComboTextOrientation.DropDownAnimationEnabled = True
            Me.radComboTextOrientation.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboTextOrientation.ForeColor = System.Drawing.Color.Black
            radListDataItem3.Text = "Horizontal"
            radListDataItem3.TextWrap = True
            radListDataItem4.Text = "Vertical"
            radListDataItem4.TextWrap = True
            Me.radComboTextOrientation.Items.Add(radListDataItem3)
            Me.radComboTextOrientation.Items.Add(radListDataItem4)
            Me.radComboTextOrientation.Location = New System.Drawing.Point(13, 182)
            Me.radComboTextOrientation.MaxDropDownItems = 0
            Me.radComboTextOrientation.Name = "radComboTextOrientation"
            ' 
            ' 
            ' 
            Me.radComboTextOrientation.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboTextOrientation.ShowImageInEditorArea = True
            Me.radComboTextOrientation.Size = New System.Drawing.Size(140, 20)
            Me.radComboTextOrientation.TabIndex = 1
            ' 
            ' radComboTextAlign
            ' 
            Me.radComboTextAlign.DropDownAnimationEnabled = True
            Me.radComboTextAlign.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboTextAlign.ForeColor = System.Drawing.Color.Black
            radListDataItem5.Text = "TopLeft"
            radListDataItem5.TextWrap = True
            radListDataItem6.Text = "TopCenter"
            radListDataItem6.TextWrap = True
            radListDataItem7.Text = "TopRight"
            radListDataItem7.TextWrap = True
            radListDataItem8.Text = "MiddleLeft"
            radListDataItem8.TextWrap = True
            radListDataItem9.Text = "MiddleCenter"
            radListDataItem9.TextWrap = True
            radListDataItem10.Text = "MiddleRight"
            radListDataItem10.TextWrap = True
            radListDataItem11.Text = "BottomLeft"
            radListDataItem11.TextWrap = True
            radListDataItem12.Text = "BottomCenter"
            radListDataItem12.TextWrap = True
            radListDataItem13.Text = "BottomRight"
            radListDataItem13.TextWrap = True
            Me.radComboTextAlign.Items.Add(radListDataItem5)
            Me.radComboTextAlign.Items.Add(radListDataItem6)
            Me.radComboTextAlign.Items.Add(radListDataItem7)
            Me.radComboTextAlign.Items.Add(radListDataItem8)
            Me.radComboTextAlign.Items.Add(radListDataItem9)
            Me.radComboTextAlign.Items.Add(radListDataItem10)
            Me.radComboTextAlign.Items.Add(radListDataItem11)
            Me.radComboTextAlign.Items.Add(radListDataItem12)
            Me.radComboTextAlign.Items.Add(radListDataItem13)
            Me.radComboTextAlign.Location = New System.Drawing.Point(13, 91)
            Me.radComboTextAlign.MaxDropDownItems = 0
            Me.radComboTextAlign.Name = "radComboTextAlign"
            ' 
            ' 
            ' 
            Me.radComboTextAlign.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboTextAlign.ShowImageInEditorArea = True
            Me.radComboTextAlign.Size = New System.Drawing.Size(140, 20)
            Me.radComboTextAlign.TabIndex = 1
            ' 
            ' radComboImageAlign
            ' 
            Me.radComboImageAlign.DropDownAnimationEnabled = True
            Me.radComboImageAlign.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboImageAlign.ForeColor = System.Drawing.Color.Black
            radListDataItem14.Text = "TopLeft"
            radListDataItem14.TextWrap = True
            radListDataItem15.Text = "TopCenter"
            radListDataItem15.TextWrap = True
            radListDataItem16.Text = "TopRight"
            radListDataItem16.TextWrap = True
            radListDataItem17.Text = "MiddleLeft"
            radListDataItem17.TextWrap = True
            radListDataItem18.Text = "MiddleCenter"
            radListDataItem18.TextWrap = True
            radListDataItem19.Text = "MiddleRight"
            radListDataItem19.TextWrap = True
            radListDataItem20.Text = "BottomLeft"
            radListDataItem20.TextWrap = True
            radListDataItem21.Text = "BottomCenter"
            radListDataItem21.TextWrap = True
            radListDataItem22.Text = "BottomRight"
            radListDataItem22.TextWrap = True
            Me.radComboImageAlign.Items.Add(radListDataItem14)
            Me.radComboImageAlign.Items.Add(radListDataItem15)
            Me.radComboImageAlign.Items.Add(radListDataItem16)
            Me.radComboImageAlign.Items.Add(radListDataItem17)
            Me.radComboImageAlign.Items.Add(radListDataItem18)
            Me.radComboImageAlign.Items.Add(radListDataItem19)
            Me.radComboImageAlign.Items.Add(radListDataItem20)
            Me.radComboImageAlign.Items.Add(radListDataItem21)
            Me.radComboImageAlign.Items.Add(radListDataItem22)
            Me.radComboImageAlign.Location = New System.Drawing.Point(13, 44)
            Me.radComboImageAlign.MaxDropDownItems = 0
            Me.radComboImageAlign.Name = "radComboImageAlign"
            ' 
            ' 
            ' 
            Me.radComboImageAlign.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboImageAlign.ShowImageInEditorArea = True
            Me.radComboImageAlign.Size = New System.Drawing.Size(140, 20)
            Me.radComboImageAlign.TabIndex = 1
            ' 
            ' radComboTextImage
            ' 
            Me.radComboTextImage.DropDownAnimationEnabled = True
            Me.radComboTextImage.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboTextImage.ForeColor = System.Drawing.Color.Black
            radListDataItem23.Text = "ImageAboveText"
            radListDataItem23.TextWrap = True
            radListDataItem24.Text = "ImageBeforeText"
            radListDataItem24.TextWrap = True
            radListDataItem25.Text = "TextAboveImage"
            radListDataItem25.TextWrap = True
            radListDataItem26.Text = "TextBeforeImage"
            radListDataItem26.TextWrap = True
            radListDataItem27.Text = "Overlay"
            radListDataItem27.TextWrap = True
            Me.radComboTextImage.Items.Add(radListDataItem23)
            Me.radComboTextImage.Items.Add(radListDataItem24)
            Me.radComboTextImage.Items.Add(radListDataItem25)
            Me.radComboTextImage.Items.Add(radListDataItem26)
            Me.radComboTextImage.Items.Add(radListDataItem27)
            Me.radComboTextImage.Location = New System.Drawing.Point(13, 137)
            Me.radComboTextImage.MaxDropDownItems = 0
            Me.radComboTextImage.Name = "radComboTextImage"
            ' 
            ' 
            ' 
            Me.radComboTextImage.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboTextImage.ShowImageInEditorArea = True
            Me.radComboTextImage.Size = New System.Drawing.Size(140, 20)
            Me.radComboTextImage.TabIndex = 1
            ' 
            ' radLblTextImage
            ' 
            Me.radLblTextImage.ForeColor = System.Drawing.Color.Black
            Me.radLblTextImage.Location = New System.Drawing.Point(13, 117)
            Me.radLblTextImage.Name = "radLblTextImage"
            Me.radLblTextImage.Size = New System.Drawing.Size(109, 18)
            Me.radLblTextImage.TabIndex = 0
            Me.radLblTextImage.Text = "Text-Image Relation:"
            ' 
            ' radLblTextOrientation
            ' 
            Me.radLblTextOrientation.ForeColor = System.Drawing.Color.Black
            Me.radLblTextOrientation.Location = New System.Drawing.Point(13, 162)
            Me.radLblTextOrientation.Name = "radLblTextOrientation"
            Me.radLblTextOrientation.Size = New System.Drawing.Size(89, 18)
            Me.radLblTextOrientation.TabIndex = 0
            Me.radLblTextOrientation.Text = "Text Orientation:"
            ' 
            ' radLblTextAlignment
            ' 
            Me.radLblTextAlignment.ForeColor = System.Drawing.Color.Black
            Me.radLblTextAlignment.Location = New System.Drawing.Point(13, 70)
            Me.radLblTextAlignment.Name = "radLblTextAlignment"
            Me.radLblTextAlignment.Size = New System.Drawing.Size(84, 18)
            Me.radLblTextAlignment.TabIndex = 0
            Me.radLblTextAlignment.Text = "Text Alignment:"
            ' 
            ' radLblImageAlign
            ' 
            Me.radLblImageAlign.ForeColor = System.Drawing.Color.Black
            Me.radLblImageAlign.Location = New System.Drawing.Point(13, 23)
            Me.radLblImageAlign.Name = "radLblImageAlign"
            Me.radLblImageAlign.Size = New System.Drawing.Size(95, 18)
            Me.radLblImageAlign.TabIndex = 0
            Me.radLblImageAlign.Text = "Image Alignment:"
            ' 
            ' radDropDownList1
            ' 
            Me.radDropDownList1.DropDownAnimationEnabled = True
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Text = "RadListDataItems"
            radListDataItem1.TextWrap = True
            radListDataItem2.Text = "DescriptionTextListDataItems"
            radListDataItem2.TextWrap = True
            Me.radDropDownList1.Items.Add(radListDataItem1)
            Me.radDropDownList1.Items.Add(radListDataItem2)
            Me.radDropDownList1.Location = New System.Drawing.Point(50, 25)
            Me.radDropDownList1.MaxDropDownItems = 0
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.ShowImageInEditorArea = True
            Me.radDropDownList1.Size = New System.Drawing.Size(180, 20)
            Me.radDropDownList1.TabIndex = 1
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New System.Drawing.Point(51, 2)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(75, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "Populate with"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radListBoxDemo)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Size = New System.Drawing.Size(1357, 749)
            Me.Controls.SetChildIndex(Me.radListBoxDemo, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupSettings.ResumeLayout(False)
            Me.radGroupSettings.PerformLayout()
            DirectCast(Me.radComboSortStyle, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radComboSelectionMode, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblSort, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblSelection, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupItem.ResumeLayout(False)
            Me.radGroupItem.PerformLayout()
            DirectCast(Me.radComboTextOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radComboTextAlign, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radComboImageAlign, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radComboTextImage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblTextImage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblTextOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblTextAlignment, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLblImageAlign, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents radListBoxDemo As Telerik.WinControls.UI.RadListControl
        Friend WithEvents imageList1 As System.Windows.Forms.ImageList
        Friend WithEvents radGroupSettings As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radComboSortStyle As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radComboSelectionMode As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLblSort As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radLblSelection As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radGroupItem As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radComboTextOrientation As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radComboTextImage As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLblTextOrientation As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radComboImageAlign As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLblImageAlign As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radComboTextAlign As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLblTextAlignment As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radLblTextImage As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
