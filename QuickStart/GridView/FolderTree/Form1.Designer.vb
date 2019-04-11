Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.FolderTree
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radButtonExpand = New Telerik.WinControls.UI.RadButton()
			Me.radButtonCollapse = New Telerik.WinControls.UI.RadButton()
			Me.radCheckBoxShowCellBorders = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxShowLines = New Telerik.WinControls.UI.RadCheckBox()
			Me.radButtonBackColor = New Telerik.WinControls.UI.RadButton()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonExpand, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowCellBorders, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButtonCollapse)
			Me.settingsPanel.Controls.Add(Me.radButtonExpand)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(955, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonExpand, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonCollapse, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1156, 749)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "folder_blue_open1.png")
			Me.imageList1.Images.SetKeyName(1, "folder1.png")
			Me.imageList1.Images.SetKeyName(2, "new1.png")
			' 
			' radButtonExpand
			' 
			Me.radButtonExpand.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonExpand.Location = New System.Drawing.Point(10, 52)
			Me.radButtonExpand.Name = "radButtonExpand"
			Me.radButtonExpand.Size = New System.Drawing.Size(180, 24)
			Me.radButtonExpand.TabIndex = 2
			Me.radButtonExpand.Text = "Expand All"
'			Me.radButtonExpand.Click += New System.EventHandler(radButtonExpand_Click);
			' 
			' radButtonCollapse
			' 
			Me.radButtonCollapse.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonCollapse.Location = New System.Drawing.Point(10, 82)
			Me.radButtonCollapse.Name = "radButtonCollapse"
			Me.radButtonCollapse.Size = New System.Drawing.Size(180, 24)
			Me.radButtonCollapse.TabIndex = 3
			Me.radButtonCollapse.Text = "Collapse All"
'			Me.radButtonCollapse.Click += New System.EventHandler(radButtonCollapse_Click);
			' 
			' radCheckBoxShowCellBorders
			' 
			Me.radCheckBoxShowCellBorders.Location = New System.Drawing.Point(13, 47)
			Me.radCheckBoxShowCellBorders.Name = "radCheckBoxShowCellBorders"
			' 
			' 
			' 
			Me.radCheckBoxShowCellBorders.RootElement.StretchHorizontally = True
			Me.radCheckBoxShowCellBorders.RootElement.StretchVertically = True
			Me.radCheckBoxShowCellBorders.Size = New System.Drawing.Size(109, 18)
			Me.radCheckBoxShowCellBorders.TabIndex = 2
			Me.radCheckBoxShowCellBorders.Text = "Show cell borders"
			Me.radCheckBoxShowCellBorders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxShowCellBorders.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxShowCellBorders_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButtonBackColor)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowLines)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowCellBorders)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Customize lines"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 128)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 189)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Customize lines"
			' 
			' radDropDownList1
			' 
			radListDataItem1.Text = "Solid"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Dash"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "Dot"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "DashDot"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "DashDotDot"
			radListDataItem5.TextWrap = True
			Me.radDropDownList1.Items.Add(radListDataItem1)
			Me.radDropDownList1.Items.Add(radListDataItem2)
			Me.radDropDownList1.Items.Add(radListDataItem3)
			Me.radDropDownList1.Items.Add(radListDataItem4)
			Me.radDropDownList1.Items.Add(radListDataItem5)
			Me.radDropDownList1.Location = New System.Drawing.Point(16, 96)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.ShowImageInEditorArea = True
			Me.radDropDownList1.Size = New System.Drawing.Size(151, 21)
			Me.radDropDownList1.TabIndex = 5
'			Me.radDropDownList1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radDropDownList1_SelectedIndexChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(13, 72)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(55, 18)
			Me.radLabel1.TabIndex = 4
			Me.radLabel1.Text = "Line style:"
			' 
			' radCheckBoxShowLines
			' 
			Me.radCheckBoxShowLines.Location = New System.Drawing.Point(13, 23)
			Me.radCheckBoxShowLines.Name = "radCheckBoxShowLines"
			' 
			' 
			' 
			Me.radCheckBoxShowLines.RootElement.StretchHorizontally = True
			Me.radCheckBoxShowLines.RootElement.StretchVertically = True
			Me.radCheckBoxShowLines.Size = New System.Drawing.Size(109, 18)
			Me.radCheckBoxShowLines.TabIndex = 3
			Me.radCheckBoxShowLines.Text = "Show tree lines"
'			Me.radCheckBoxShowLines.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxShowLines_ToggleStateChanged);
			' 
			' radButtonBackColor
			' 
			Me.radButtonBackColor.Location = New System.Drawing.Point(59, 152)
			Me.radButtonBackColor.Name = "radButtonBackColor"
			Me.radButtonBackColor.Size = New System.Drawing.Size(59, 24)
			Me.radButtonBackColor.TabIndex = 9
'			Me.radButtonBackColor.Click += New System.EventHandler(Me.radButtonBackColor_Click);
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(16, 123)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(57, 18)
			Me.radLabel3.TabIndex = 10
			Me.radLabel3.Text = "Line color:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1156, 749)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonExpand, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonCollapse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowCellBorders, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents radButtonCollapse As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonExpand As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckBoxShowLines As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxShowCellBorders As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radButtonBackColor As Telerik.WinControls.UI.RadButton
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
