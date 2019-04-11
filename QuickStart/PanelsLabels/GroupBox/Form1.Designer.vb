Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.PanelsLabels.GroupBox
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton5 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton6 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton11 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton10 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton9 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton8 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton7 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.roudRectShape = New Telerik.WinControls.RoundRectShape(10)
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.radRadioButton11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1052, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGroupBox1.Controls.Add(Me.radGroupBox2)
			Me.radGroupBox1.Controls.Add(Me.radGroupBox3)
			Me.radGroupBox1.Controls.Add(Me.radGroupBox4)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImage = My.Resources.info2
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Telerik Groupbox "
            Me.radGroupBox1.Location = New System.Drawing.Point(35, 35)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox1.Size = New System.Drawing.Size(381, 271)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Telerik Groupbox "
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Groupbox style"
            Me.radGroupBox2.Location = New System.Drawing.Point(52, 181)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(277, 47)
			Me.radGroupBox2.TabIndex = 0
			Me.radGroupBox2.Text = "Groupbox style"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton2.Location = New System.Drawing.Point(12, 24)
			Me.radRadioButton2.Name = "radRadioButton2"
			' 
			' 
			' 
			Me.radRadioButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton2.Size = New System.Drawing.Size(66, 16)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Standard"
'			Me.radRadioButton2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton2_ToggleStateChanged);
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.Location = New System.Drawing.Point(128, 24)
			Me.radRadioButton1.Name = "radRadioButton1"
			' 
			' 
			' 
			Me.radRadioButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.Size = New System.Drawing.Size(50, 16)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "Office"
'			Me.radRadioButton1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Controls.Add(Me.radRadioButton3)
			Me.radGroupBox3.Controls.Add(Me.radRadioButton5)
			Me.radGroupBox3.Controls.Add(Me.radRadioButton6)
			Me.radGroupBox3.Controls.Add(Me.radRadioButton4)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox3.HeaderText = "Header Position"
            Me.radGroupBox3.Location = New System.Drawing.Point(52, 43)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New System.Drawing.Size(116, 129)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Header Position"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton3.Location = New System.Drawing.Point(12, 21)
			Me.radRadioButton3.Name = "radRadioButton3"
			' 
			' 
			' 
			Me.radRadioButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton3.Size = New System.Drawing.Size(40, 16)
			Me.radRadioButton3.TabIndex = 0
			Me.radRadioButton3.Text = "Top"
'			Me.radRadioButton3.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton3_ToggleStateChanged);
			' 
			' radRadioButton5
			' 
			Me.radRadioButton5.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton5.Location = New System.Drawing.Point(12, 65)
			Me.radRadioButton5.Name = "radRadioButton5"
			' 
			' 
			' 
			Me.radRadioButton5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton5.Size = New System.Drawing.Size(56, 16)
			Me.radRadioButton5.TabIndex = 2
			Me.radRadioButton5.Text = "Bottom"
'			Me.radRadioButton5.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton5_ToggleStateChanged);
			' 
			' radRadioButton6
			' 
			Me.radRadioButton6.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton6.Location = New System.Drawing.Point(12, 87)
			Me.radRadioButton6.Name = "radRadioButton6"
			' 
			' 
			' 
			Me.radRadioButton6.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton6.Size = New System.Drawing.Size(39, 16)
			Me.radRadioButton6.TabIndex = 3
			Me.radRadioButton6.Text = "Left"
'			Me.radRadioButton6.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton6_ToggleStateChanged);
			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton4.Location = New System.Drawing.Point(12, 43)
			Me.radRadioButton4.Name = "radRadioButton4"
			' 
			' 
			' 
			Me.radRadioButton4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton4.Size = New System.Drawing.Size(47, 16)
			Me.radRadioButton4.TabIndex = 1
			Me.radRadioButton4.Text = "Right"
'			Me.radRadioButton4.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton4_ToggleStateChanged);
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.Controls.Add(Me.radRadioButton11)
			Me.radGroupBox4.Controls.Add(Me.radRadioButton10)
			Me.radGroupBox4.Controls.Add(Me.radRadioButton9)
			Me.radGroupBox4.Controls.Add(Me.radRadioButton8)
			Me.radGroupBox4.Controls.Add(Me.radRadioButton7)
			Me.radGroupBox4.FooterImageIndex = -1
			Me.radGroupBox4.FooterImageKey = ""
			Me.radGroupBox4.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox4.HeaderImageIndex = -1
			Me.radGroupBox4.HeaderImageKey = ""
			Me.radGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox4.HeaderText = "Text and Image Relation"
            Me.radGroupBox4.Location = New System.Drawing.Point(176, 43)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox4.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox4.Size = New System.Drawing.Size(155, 129)
			Me.radGroupBox4.TabIndex = 2
			Me.radGroupBox4.Text = "Text and Image Relation"
			' 
			' radRadioButton11
			' 
			Me.radRadioButton11.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton11.Location = New System.Drawing.Point(16, 109)
			Me.radRadioButton11.Name = "radRadioButton11"
			' 
			' 
			' 
			Me.radRadioButton11.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton11.Size = New System.Drawing.Size(111, 16)
			Me.radRadioButton11.TabIndex = 4
			Me.radRadioButton11.Text = "Text before image"
'			Me.radRadioButton11.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton11_ToggleStateChanged);
			' 
			' radRadioButton10
			' 
			Me.radRadioButton10.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton10.Location = New System.Drawing.Point(16, 87)
			Me.radRadioButton10.Name = "radRadioButton10"
			' 
			' 
			' 
			Me.radRadioButton10.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton10.Size = New System.Drawing.Size(110, 16)
			Me.radRadioButton10.TabIndex = 3
			Me.radRadioButton10.Text = "Text above image"
'			Me.radRadioButton10.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton10_ToggleStateChanged);
			' 
			' radRadioButton9
			' 
			Me.radRadioButton9.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton9.Location = New System.Drawing.Point(16, 65)
			Me.radRadioButton9.Name = "radRadioButton9"
			' 
			' 
			' 
			Me.radRadioButton9.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton9.Size = New System.Drawing.Size(59, 16)
			Me.radRadioButton9.TabIndex = 2
			Me.radRadioButton9.Text = "Overlay"
'			Me.radRadioButton9.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton9_ToggleStateChanged);
			' 
			' radRadioButton8
			' 
			Me.radRadioButton8.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton8.Location = New System.Drawing.Point(16, 43)
			Me.radRadioButton8.Name = "radRadioButton8"
			' 
			' 
			' 
			Me.radRadioButton8.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton8.Size = New System.Drawing.Size(108, 16)
			Me.radRadioButton8.TabIndex = 1
			Me.radRadioButton8.Text = "Image before text"
'			Me.radRadioButton8.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton8_ToggleStateChanged);
			' 
			' radRadioButton7
			' 
			Me.radRadioButton7.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton7.Location = New System.Drawing.Point(16, 21)
			Me.radRadioButton7.Name = "radRadioButton7"
			' 
			' 
			' 
			Me.radRadioButton7.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton7.Size = New System.Drawing.Size(107, 16)
			Me.radRadioButton7.TabIndex = 0
			Me.radRadioButton7.Text = "Image above text"
'			Me.radRadioButton7.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton7_ToggleStateChanged);
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.Controls.Add(Me.radGroupBox1)
			Me.radPanel1.Location = New System.Drawing.Point(432, 252)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(450, 347)
			Me.radPanel1.TabIndex = 2
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roudRectShape
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3F
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.01F
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(255))))))
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(162))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(254))))))
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1253, 832)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			CType(Me.radRadioButton11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton6 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton5 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton4 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton7 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton8 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton9 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton10 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton11 As Telerik.WinControls.UI.RadRadioButton
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Protected roudRectShape As Telerik.WinControls.RoundRectShape

	End Class
End Namespace
