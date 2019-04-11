Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollPanel.FirstLook
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
			Me.radScrollPanelDemo = New Telerik.WinControls.UI.RadTestScrollView()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radButton5 = New Telerik.WinControls.UI.RadButton()
			Me.radGroupHorziontal = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioHAutoHide = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioHAlwaysHide = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioHAlwaysShow = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioVAutoHide = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioVAlwaysHide = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioVAlwaysShow = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScrollPanelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupHorziontal, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupHorziontal.SuspendLayout()
			CType(Me.radRadioHAutoHide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioHAlwaysHide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioHAlwaysShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioVAutoHide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioVAlwaysHide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioVAlwaysShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupHorziontal)
			Me.settingsPanel.Location = New System.Drawing.Point(553, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 724)
			' 
			' radScrollPanelDemo
			' 
			Me.radScrollPanelDemo.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radScrollPanelDemo.BackColor = System.Drawing.Color.White
			Me.radScrollPanelDemo.ForeColor = System.Drawing.Color.Black
			Me.radScrollPanelDemo.Location = New System.Drawing.Point(192, 97)
			Me.radScrollPanelDemo.Margin = New System.Windows.Forms.Padding(2)
			Me.radScrollPanelDemo.Name = "radScrollPanelDemo"
			' 
			' 
			' 
			Me.radScrollPanelDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radScrollPanelDemo.RootElement.ToolTipText = Nothing
			Me.radScrollPanelDemo.Size = New System.Drawing.Size(370, 533)
			Me.radScrollPanelDemo.TabIndex = 33
			Me.radScrollPanelDemo.Text = "radScrollPanel1"
			Me.radScrollPanelDemo.UsePhysicalScrolling = False
			Me.radScrollPanelDemo.Value = New System.Drawing.Point(0, 0)
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.ForeColor = System.Drawing.Color.Black
			Me.radComboBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2}))
			Me.radComboBox1.Location = New System.Drawing.Point(16, 252)
			Me.radComboBox1.MaxDropDownItems = 2
			Me.radComboBox1.Name = "radComboBox1"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBox1.RootElement.ToolTipText = Nothing
			Me.radComboBox1.Size = New System.Drawing.Size(130, 20)
			Me.radComboBox1.TabIndex = 55
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.Text = "Logical"
'			Me.radComboBox1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox1_SelectedIndexChanged);
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "Logical"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "Physical"
			' 
			' radButton1
			' 
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Location = New System.Drawing.Point(16, 44)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Size = New System.Drawing.Size(130, 23)
			Me.radButton1.TabIndex = 56
			Me.radButton1.Text = "Square"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.ForeColor = System.Drawing.Color.Black
			Me.radButton2.Location = New System.Drawing.Point(16, 73)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton2.Size = New System.Drawing.Size(130, 23)
			Me.radButton2.TabIndex = 57
			Me.radButton2.Text = "Triangle"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radButton3
			' 
			Me.radButton3.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Location = New System.Drawing.Point(16, 102)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Size = New System.Drawing.Size(130, 23)
			Me.radButton3.TabIndex = 58
			Me.radButton3.Text = "Fill"
'			Me.radButton3.Click += New System.EventHandler(Me.radButton3_Click);
			' 
			' radButton4
			' 
			Me.radButton4.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Location = New System.Drawing.Point(16, 161)
			Me.radButton4.Name = "radButton4"
			' 
			' 
			' 
			Me.radButton4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Size = New System.Drawing.Size(130, 23)
			Me.radButton4.TabIndex = 59
			Me.radButton4.Text = "Square"
'			Me.radButton4.Click += New System.EventHandler(Me.radButton4_Click);
			' 
			' radButton5
			' 
			Me.radButton5.ForeColor = System.Drawing.Color.Black
			Me.radButton5.Location = New System.Drawing.Point(16, 190)
			Me.radButton5.Name = "radButton5"
			' 
			' 
			' 
			Me.radButton5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton5.Size = New System.Drawing.Size(130, 23)
			Me.radButton5.TabIndex = 60
			Me.radButton5.Text = "Triangle"
'			Me.radButton5.Click += New System.EventHandler(Me.radButton5_Click);
			' 
			' radGroupHorziontal
			' 
			Me.radGroupHorziontal.Controls.Add(Me.radRadioHAutoHide)
			Me.radGroupHorziontal.Controls.Add(Me.radRadioHAlwaysHide)
			Me.radGroupHorziontal.Controls.Add(Me.radRadioHAlwaysShow)
			Me.radGroupHorziontal.FooterImageIndex = -1
			Me.radGroupHorziontal.FooterImageKey = ""
			Me.radGroupHorziontal.FooterText = ""
			Me.radGroupHorziontal.HeaderImageIndex = -1
			Me.radGroupHorziontal.HeaderImageKey = ""
			Me.radGroupHorziontal.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupHorziontal.HeaderText = "Horizontal Scroll"
			Me.radGroupHorziontal.Location = New System.Drawing.Point(13, 9)
			Me.radGroupHorziontal.Name = "radGroupHorziontal"
			' 
			' 
			' 
			Me.radGroupHorziontal.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupHorziontal.Size = New System.Drawing.Size(170, 108)
			Me.radGroupHorziontal.TabIndex = 0
			Me.radGroupHorziontal.Text = "Horizontal Scroll"
			' 
			' radRadioHAutoHide
			' 
			Me.radRadioHAutoHide.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAutoHide.Location = New System.Drawing.Point(16, 75)
			Me.radRadioHAutoHide.Name = "radRadioHAutoHide"
			Me.radRadioHAutoHide.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioHAutoHide.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAutoHide.Size = New System.Drawing.Size(70, 16)
			Me.radRadioHAutoHide.TabIndex = 0
			Me.radRadioHAutoHide.Text = "Auto Hide"
'			Me.radRadioHAutoHide.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnHorizontalRadioOption_ToggleStateChanged);
			' 
			' radRadioHAlwaysHide
			' 
			Me.radRadioHAlwaysHide.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAlwaysHide.Location = New System.Drawing.Point(16, 53)
			Me.radRadioHAlwaysHide.Name = "radRadioHAlwaysHide"
			Me.radRadioHAlwaysHide.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioHAlwaysHide.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAlwaysHide.Size = New System.Drawing.Size(82, 16)
			Me.radRadioHAlwaysHide.TabIndex = 0
			Me.radRadioHAlwaysHide.Text = "Always Hide"
'			Me.radRadioHAlwaysHide.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnHorizontalRadioOption_ToggleStateChanged);
			' 
			' radRadioHAlwaysShow
			' 
			Me.radRadioHAlwaysShow.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAlwaysShow.Location = New System.Drawing.Point(16, 31)
			Me.radRadioHAlwaysShow.Name = "radRadioHAlwaysShow"
			Me.radRadioHAlwaysShow.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioHAlwaysShow.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioHAlwaysShow.Size = New System.Drawing.Size(87, 16)
			Me.radRadioHAlwaysShow.TabIndex = 0
			Me.radRadioHAlwaysShow.Text = "Always Show"
'			Me.radRadioHAlwaysShow.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnHorizontalRadioOption_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radRadioVAutoHide)
			Me.radGroupBox1.Controls.Add(Me.radRadioVAlwaysHide)
			Me.radGroupBox1.Controls.Add(Me.radRadioVAlwaysShow)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Vertical Scroll"
			Me.radGroupBox1.Location = New System.Drawing.Point(13, 123)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(170, 108)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Vertical Scroll"
			' 
			' radRadioVAutoHide
			' 
			Me.radRadioVAutoHide.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAutoHide.Location = New System.Drawing.Point(16, 75)
			Me.radRadioVAutoHide.Name = "radRadioVAutoHide"
			Me.radRadioVAutoHide.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioVAutoHide.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAutoHide.Size = New System.Drawing.Size(70, 16)
			Me.radRadioVAutoHide.TabIndex = 0
			Me.radRadioVAutoHide.Text = "Auto Hide"
'			Me.radRadioVAutoHide.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnVerticalRadioOption_ToggleStateChanged);
			' 
			' radRadioVAlwaysHide
			' 
			Me.radRadioVAlwaysHide.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAlwaysHide.Location = New System.Drawing.Point(16, 53)
			Me.radRadioVAlwaysHide.Name = "radRadioVAlwaysHide"
			Me.radRadioVAlwaysHide.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioVAlwaysHide.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAlwaysHide.Size = New System.Drawing.Size(82, 16)
			Me.radRadioVAlwaysHide.TabIndex = 0
			Me.radRadioVAlwaysHide.Text = "Always Hide"
'			Me.radRadioVAlwaysHide.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnVerticalRadioOption_ToggleStateChanged);
			' 
			' radRadioVAlwaysShow
			' 
			Me.radRadioVAlwaysShow.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAlwaysShow.Location = New System.Drawing.Point(16, 31)
			Me.radRadioVAlwaysShow.Name = "radRadioVAlwaysShow"
			Me.radRadioVAlwaysShow.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioVAlwaysShow.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioVAlwaysShow.Size = New System.Drawing.Size(87, 16)
			Me.radRadioVAlwaysShow.TabIndex = 0
			Me.radRadioVAlwaysShow.Text = "Always Show"
'			Me.radRadioVAlwaysShow.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnVerticalRadioOption_ToggleStateChanged);
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radButton1)
			Me.radGroupBox2.Controls.Add(Me.radLabel3)
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radButton3)
			Me.radGroupBox2.Controls.Add(Me.radComboBox1)
			Me.radGroupBox2.Controls.Add(Me.radButton5)
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.Controls.Add(Me.radButton2)
			Me.radGroupBox2.Controls.Add(Me.radButton4)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Element Control"
			Me.radGroupBox2.Location = New System.Drawing.Point(13, 246)
			Me.radGroupBox2.Name = "radGroupBox2"
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.Size = New System.Drawing.Size(170, 280)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Element Control"
			' 
			' radLabel3
			' 
			Me.radLabel3.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Location = New System.Drawing.Point(16, 141)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Size = New System.Drawing.Size(52, 14)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Scroll To:"
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(16, 232)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(79, 14)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Scrolling Type:"
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(16, 24)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(87, 14)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Toggle Element:"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radScrollPanelDemo)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(754, 726)
			Me.Controls.SetChildIndex(Me.radScrollPanelDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radScrollPanelDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupHorziontal, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupHorziontal.ResumeLayout(False)
			Me.radGroupHorziontal.PerformLayout()
			CType(Me.radRadioHAutoHide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioHAlwaysHide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioHAlwaysShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioVAutoHide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioVAlwaysHide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioVAlwaysShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radScrollPanelDemo As Telerik.WinControls.UI.RadTestScrollView
		Private WithEvents radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton4 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton5 As Telerik.WinControls.UI.RadButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioVAutoHide As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioVAlwaysHide As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioVAlwaysShow As Telerik.WinControls.UI.RadRadioButton
		Private radGroupHorziontal As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioHAutoHide As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioHAlwaysHide As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioHAlwaysShow As Telerik.WinControls.UI.RadRadioButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace