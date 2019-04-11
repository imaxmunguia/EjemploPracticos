Imports Microsoft.VisualBasic
Imports System.Drawing

Namespace Telerik.Examples.WinControls.Buttons.FirstLook
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
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.groupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioOverlay = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioTxtBeforeImg = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioTxtAboveImg = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioImgBeforeTxt = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioImgAboveTxt = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.radRadioOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioTxtBeforeImg, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioTxtAboveImg, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioImgBeforeTxt, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioImgAboveTxt, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel3)
			Me.radPanelDemoHolder.Controls.Add(Me.radButton3)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel2)
			Me.radPanelDemoHolder.Controls.Add(Me.radButton1)
			Me.radPanelDemoHolder.Controls.Add(Me.radButton2)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(306, 276)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(396, 185)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.groupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(808, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.groupBox1, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "print.gif")
			Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
			Me.imageList1.Images.SetKeyName(2, "bulb_off.GIF")
			Me.imageList1.Images.SetKeyName(3, "iconDropDown.bmp")
			Me.imageList1.Images.SetKeyName(4, "iconMoveToFolder.bmp")
			' 
			' radButton3
			' 
			Me.radButton3.AllowShowFocusCues = True
			Me.radButton3.AutoSize = True
			Me.radButton3.BackColor = System.Drawing.Color.Transparent
			Me.radButton3.ForeColor = System.Drawing.Color.Black
			Me.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton3.ImageIndex = 3
			Me.radButton3.ImageList = Me.imageList1
			Me.radButton3.Location = New System.Drawing.Point(225, 109)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton3.RootElement.StretchHorizontally = False
			Me.radButton3.RootElement.StretchVertically = False
			Me.radButton3.RootElement.ToolTipText = Nothing
			Me.radButton3.Size = New System.Drawing.Size(96, 29)
			Me.radButton3.TabIndex = 5
			Me.radButton3.Text = "Check Mail"
			Me.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image"), System.Drawing.Image))
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageIndex = 3
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Check Mail"
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(4)
			' 
			' radButton1
			' 
			Me.radButton1.AllowShowFocusCues = True
			Me.radButton1.BackColor = System.Drawing.Color.Transparent
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Location = New System.Drawing.Point(225, 47)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.RootElement.ToolTipText = Nothing
			Me.radButton1.Size = New System.Drawing.Size(96, 25)
			Me.radButton1.TabIndex = 3
			Me.radButton1.Text = "Check Mail"
			' 
			' radButton2
			' 
			Me.radButton2.AllowShowFocusCues = True
			Me.radButton2.BackColor = System.Drawing.Color.Transparent
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton2.ForeColor = System.Drawing.Color.Black
			Me.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton2.ImageIndex = 3
			Me.radButton2.ImageList = Me.imageList1
			Me.radButton2.ImageScalingSize = New System.Drawing.Size(24, 24)
			Me.radButton2.Location = New System.Drawing.Point(225, 78)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton2.RootElement.ToolTipText = Nothing
			Me.radButton2.Size = New System.Drawing.Size(96, 25)
			Me.radButton2.TabIndex = 3
			Me.radButton2.Text = "radButton2"
			Me.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.groupBox1.Controls.Add(Me.radRadioOverlay)
			Me.groupBox1.Controls.Add(Me.radRadioTxtBeforeImg)
			Me.groupBox1.Controls.Add(Me.radRadioTxtAboveImg)
			Me.groupBox1.Controls.Add(Me.radRadioImgBeforeTxt)
			Me.groupBox1.Controls.Add(Me.radRadioImgAboveTxt)
			Me.groupBox1.FooterImageIndex = -1
			Me.groupBox1.FooterImageKey = ""
			Me.groupBox1.FooterText = ""
			Me.groupBox1.ForeColor = System.Drawing.Color.Black
			Me.groupBox1.HeaderImageIndex = -1
			Me.groupBox1.HeaderImageKey = ""
			Me.groupBox1.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.groupBox1.HeaderText = "Text Image Relation"
			Me.groupBox1.Location = New System.Drawing.Point(10, 6)
			Me.groupBox1.Name = "groupBox1"
			' 
			' 
			' 
			Me.groupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.groupBox1.Size = New System.Drawing.Size(180, 152)
			Me.groupBox1.TabIndex = 19
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Text Image Relation"
			Me.groupBox1.ThemeName = "ControlDefault"
'			Me.groupBox1.Click += New System.EventHandler(Me.groupBox1_Click);
			' 
			' radRadioOverlay
			' 
			Me.radRadioOverlay.AllowShowFocusCues = True
			Me.radRadioOverlay.ForeColor = System.Drawing.Color.Black
			Me.radRadioOverlay.Location = New System.Drawing.Point(12, 122)
			Me.radRadioOverlay.Name = "radRadioOverlay"
			Me.radRadioOverlay.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioOverlay.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioOverlay.Size = New System.Drawing.Size(59, 16)
			Me.radRadioOverlay.TabIndex = 0
			Me.radRadioOverlay.Text = "Overlay"
'			Me.radRadioOverlay.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioImgAboveTxt_ToggleStateChanged);
			' 
			' radRadioTxtBeforeImg
			' 
			Me.radRadioTxtBeforeImg.AllowShowFocusCues = True
			Me.radRadioTxtBeforeImg.ForeColor = System.Drawing.Color.Black
			Me.radRadioTxtBeforeImg.Location = New System.Drawing.Point(12, 100)
			Me.radRadioTxtBeforeImg.Name = "radRadioTxtBeforeImg"
			Me.radRadioTxtBeforeImg.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioTxtBeforeImg.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioTxtBeforeImg.Size = New System.Drawing.Size(113, 16)
			Me.radRadioTxtBeforeImg.TabIndex = 0
			Me.radRadioTxtBeforeImg.Text = "Text Before Image"
'			Me.radRadioTxtBeforeImg.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioImgAboveTxt_ToggleStateChanged);
			' 
			' radRadioTxtAboveImg
			' 
			Me.radRadioTxtAboveImg.AllowShowFocusCues = True
			Me.radRadioTxtAboveImg.ForeColor = System.Drawing.Color.Black
			Me.radRadioTxtAboveImg.Location = New System.Drawing.Point(12, 78)
			Me.radRadioTxtAboveImg.Name = "radRadioTxtAboveImg"
			Me.radRadioTxtAboveImg.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioTxtAboveImg.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioTxtAboveImg.Size = New System.Drawing.Size(112, 16)
			Me.radRadioTxtAboveImg.TabIndex = 0
			Me.radRadioTxtAboveImg.Text = "Text Above Image"
'			Me.radRadioTxtAboveImg.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioImgAboveTxt_ToggleStateChanged);
			' 
			' radRadioImgBeforeTxt
			' 
			Me.radRadioImgBeforeTxt.AllowShowFocusCues = True
			Me.radRadioImgBeforeTxt.ForeColor = System.Drawing.Color.Black
			Me.radRadioImgBeforeTxt.Location = New System.Drawing.Point(12, 56)
			Me.radRadioImgBeforeTxt.Name = "radRadioImgBeforeTxt"
			Me.radRadioImgBeforeTxt.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioImgBeforeTxt.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioImgBeforeTxt.Size = New System.Drawing.Size(113, 16)
			Me.radRadioImgBeforeTxt.TabIndex = 0
			Me.radRadioImgBeforeTxt.Text = "Image Before Text"
'			Me.radRadioImgBeforeTxt.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioImgAboveTxt_ToggleStateChanged);
			' 
			' radRadioImgAboveTxt
			' 
			Me.radRadioImgAboveTxt.AllowShowFocusCues = True
			Me.radRadioImgAboveTxt.ForeColor = System.Drawing.Color.Black
			Me.radRadioImgAboveTxt.Location = New System.Drawing.Point(12, 34)
			Me.radRadioImgAboveTxt.Name = "radRadioImgAboveTxt"
			Me.radRadioImgAboveTxt.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioImgAboveTxt.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioImgAboveTxt.Size = New System.Drawing.Size(112, 16)
			Me.radRadioImgAboveTxt.TabIndex = 0
			Me.radRadioImgAboveTxt.Text = "Image Above Text"
			' 
			' radLabel3
			' 
			Me.radLabel3.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Location = New System.Drawing.Point(75, 118)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Size = New System.Drawing.Size(120, 14)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Text And Image Button"
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(75, 85)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(71, 14)
			Me.radLabel2.TabIndex = 6
			Me.radLabel2.Text = "Image Button"
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(75, 51)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(62, 14)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Text = "Text Button"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1009, 737)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.radRadioOverlay, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioTxtBeforeImg, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioTxtAboveImg, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioImgBeforeTxt, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioImgAboveTxt, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private imageList1 As System.Windows.Forms.ImageList
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents groupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radRadioOverlay As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioTxtBeforeImg As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioTxtAboveImg As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioImgBeforeTxt As Telerik.WinControls.UI.RadRadioButton
		Private radRadioImgAboveTxt As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace