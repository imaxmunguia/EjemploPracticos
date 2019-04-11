Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.RadColorSelector.FirstLook

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
			Me.radColorSelector1 = New Telerik.WinControls.UI.RadColorSelector()
			Me.radCheckBox9 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox5 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox6 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox7 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox8 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox2 = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox3 = New Telerik.WinControls.UI.RadTextBox()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCheckBox9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 867)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radColorSelector1
			' 
			Me.radColorSelector1.AddNewColorButtonText = "Add Custom Color"
			Me.radColorSelector1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radColorSelector1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(198))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(247))))))
			Me.radColorSelector1.BasicTabHeading = "Basic"
			Me.radColorSelector1.Location = New System.Drawing.Point(175, 218)
			Me.radColorSelector1.MinimumSize = New System.Drawing.Size(508, 395)
			Me.radColorSelector1.Name = "radColorSelector1"
			Me.radColorSelector1.OldColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))))
			Me.radColorSelector1.OldColorLabelHeading = "Current"
			Me.radColorSelector1.ProfessionalTabHeading = "Professional"
			Me.radColorSelector1.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))))
			Me.radColorSelector1.SelectedColorLabelHeading = "New"
			Me.radColorSelector1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1)
			Me.radColorSelector1.Size = New System.Drawing.Size(631, 433)
			Me.radColorSelector1.SystemTabHeading = "System"
			Me.radColorSelector1.TabIndex = 0
			Me.radColorSelector1.WebTabHeading = "Web"
'			Me.radColorSelector1.ColorChanged += New Telerik.WinControls.ColorChangedEventHandler(Me.radColorSelector1_ColorChanged);
			' 
			' radCheckBox9
			' 
			Me.radCheckBox9.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox9.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox9.Location = New System.Drawing.Point(9, 115)
			Me.radCheckBox9.Name = "radCheckBox9"
			' 
			' 
			' 
			Me.radCheckBox9.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox9.Size = New System.Drawing.Size(110, 29)
			Me.radCheckBox9.TabIndex = 4
			Me.radCheckBox9.Text = "Allow Color Pick" & Constants.vbCrLf & "From Screen"
'			Me.radCheckBox9.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox9_Click);
			' 
			' radCheckBox5
			' 
			Me.radCheckBox5.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox5.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox5.Location = New System.Drawing.Point(9, 67)
			Me.radCheckBox5.Name = "radCheckBox5"
			' 
			' 
			' 
			Me.radCheckBox5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox5.Size = New System.Drawing.Size(139, 17)
			Me.radCheckBox5.TabIndex = 2
			Me.radCheckBox5.Text = "Show HEX Color Value"
'			Me.radCheckBox5.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox5_Click);
			' 
			' radCheckBox6
			' 
			Me.radCheckBox6.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox6.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox6.Location = New System.Drawing.Point(9, 21)
			Me.radCheckBox6.Name = "radCheckBox6"
			' 
			' 
			' 
			Me.radCheckBox6.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox6.Size = New System.Drawing.Size(128, 17)
			Me.radCheckBox6.TabIndex = 0
			Me.radCheckBox6.Text = "Show Custom Colors"
'			Me.radCheckBox6.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox6_Click);
			' 
			' radCheckBox7
			' 
			Me.radCheckBox7.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox7.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox7.Location = New System.Drawing.Point(9, 44)
			Me.radCheckBox7.Name = "radCheckBox7"
			' 
			' 
			' 
			Me.radCheckBox7.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox7.Size = New System.Drawing.Size(117, 17)
			Me.radCheckBox7.TabIndex = 1
			Me.radCheckBox7.Text = "Allow Color Saving"
'			Me.radCheckBox7.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox7_Click);
			' 
			' radCheckBox8
			' 
			Me.radCheckBox8.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox8.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox8.Location = New System.Drawing.Point(9, 92)
			Me.radCheckBox8.Name = "radCheckBox8"
			' 
			' 
			' 
			Me.radCheckBox8.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox8.Size = New System.Drawing.Size(146, 17)
			Me.radCheckBox8.TabIndex = 3
			Me.radCheckBox8.Text = "Allow HEX Value Editing"
'			Me.radCheckBox8.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox8_Click);
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(15, 23)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(91, 14)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "New Color Label:"
			Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radTextBox1
			' 
			Me.radTextBox1.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Location = New System.Drawing.Point(30, 43)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Size = New System.Drawing.Size(122, 20)
			Me.radTextBox1.TabIndex = 4
'			Me.radTextBox1.TextChanged += New System.EventHandler(Me.radTextBox1_TextChanged);
			' 
			' radLabel3
			' 
			Me.radLabel3.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Location = New System.Drawing.Point(15, 115)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Size = New System.Drawing.Size(88, 14)
			Me.radLabel3.TabIndex = 7
			Me.radLabel3.Text = "Add Color Label:"
			Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radTextBox2
			' 
			Me.radTextBox2.ForeColor = System.Drawing.Color.Black
			Me.radTextBox2.Location = New System.Drawing.Point(30, 89)
			Me.radTextBox2.Name = "radTextBox2"
			' 
			' 
			' 
			Me.radTextBox2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBox2.Size = New System.Drawing.Size(122, 20)
			Me.radTextBox2.TabIndex = 6
'			Me.radTextBox2.TextChanged += New System.EventHandler(Me.radTextBox2_TextChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(15, 69)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(106, 14)
			Me.radLabel2.TabIndex = 7
			Me.radLabel2.Text = "Current Color Label:"
			Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radTextBox3
			' 
			Me.radTextBox3.ForeColor = System.Drawing.Color.Black
			Me.radTextBox3.Location = New System.Drawing.Point(30, 135)
			Me.radTextBox3.Name = "radTextBox3"
			' 
			' 
			' 
			Me.radTextBox3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBox3.Size = New System.Drawing.Size(122, 20)
			Me.radTextBox3.TabIndex = 6
'			Me.radTextBox3.TextChanged += New System.EventHandler(Me.radTextBox3_TextChanged);
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox3.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox3.Location = New System.Drawing.Point(8, 66)
			Me.radCheckBox3.Name = "radCheckBox3"
			' 
			' 
			' 
			Me.radCheckBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox3.Size = New System.Drawing.Size(135, 17)
			Me.radCheckBox3.TabIndex = 2
			Me.radCheckBox3.Text = "Show Web Colors Tab"
'			Me.radCheckBox3.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox3_Click);
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox1.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox1.Location = New System.Drawing.Point(8, 20)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox1.Size = New System.Drawing.Size(140, 17)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "Show Basic Colors Tab"
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_Click);
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox2.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox2.Location = New System.Drawing.Point(8, 43)
			Me.radCheckBox2.Name = "radCheckBox2"
			' 
			' 
			' 
			Me.radCheckBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox2.Size = New System.Drawing.Size(150, 17)
			Me.radCheckBox2.TabIndex = 1
			Me.radCheckBox2.Text = "Show System Colors Tab"
'			Me.radCheckBox2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox2_Click);
			' 
			' radCheckBox4
			' 
			Me.radCheckBox4.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox4.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox4.Location = New System.Drawing.Point(8, 89)
			Me.radCheckBox4.Name = "radCheckBox4"
			' 
			' 
			' 
			Me.radCheckBox4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox4.Size = New System.Drawing.Size(122, 29)
			Me.radCheckBox4.TabIndex = 3
			Me.radCheckBox4.Text = "Show Professional" & Constants.vbCrLf & "Colors Tab"
'			Me.radCheckBox4.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox4_Click);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radCheckBox3)
			Me.radGroupBox1.Controls.Add(Me.radCheckBox1)
			Me.radGroupBox1.Controls.Add(Me.radCheckBox4)
			Me.radGroupBox1.Controls.Add(Me.radCheckBox2)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = " Color Tab Visibility "
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 132)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = " Color Tab Visibility "
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.Controls.Add(Me.radTextBox1)
			Me.radGroupBox2.Controls.Add(Me.radTextBox3)
			Me.radGroupBox2.Controls.Add(Me.radLabel3)
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radTextBox2)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = " Captions "
			Me.radGroupBox2.Location = New System.Drawing.Point(15, 143)
			Me.radGroupBox2.Name = "radGroupBox2"
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.Size = New System.Drawing.Size(162, 182)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = " Captions "
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Controls.Add(Me.radCheckBox9)
			Me.radGroupBox3.Controls.Add(Me.radCheckBox6)
			Me.radGroupBox3.Controls.Add(Me.radCheckBox5)
			Me.radGroupBox3.Controls.Add(Me.radCheckBox8)
			Me.radGroupBox3.Controls.Add(Me.radCheckBox7)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.FooterText = ""
			Me.radGroupBox3.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox3.HeaderText = " Color Tab Visibility "
			Me.radGroupBox3.Location = New System.Drawing.Point(15, 331)
			Me.radGroupBox3.Name = "radGroupBox3"
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.Size = New System.Drawing.Size(162, 161)
			Me.radGroupBox3.TabIndex = 2
			Me.radGroupBox3.Text = " Color Tab Visibility "
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radColorSelector1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 869)
			Me.Controls.SetChildIndex(Me.radColorSelector1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCheckBox9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radColorSelector1 As Telerik.WinControls.UI.RadColorSelector
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radTextBox3 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radTextBox2 As Telerik.WinControls.UI.RadTextBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox5 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox6 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox7 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox8 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox9 As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox

	End Class
End Namespace
