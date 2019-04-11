Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.Navigation
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
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker3 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupRenderOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupDateOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinNavigationStep = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRenderOpts.SuspendLayout()
			CType(Me.radGroupDateOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupDateOpts.SuspendLayout()
			CType(Me.radSpinNavigationStep, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel9)
			Me.settingsPanel.Controls.Add(Me.radGroupRenderOpts)
			Me.settingsPanel.Controls.Add(Me.radGroupDateOpts)
			Me.settingsPanel.Controls.Add(Me.radSpinNavigationStep)
			Me.settingsPanel.Location = New System.Drawing.Point(729, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 867)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinNavigationStep, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupDateOpts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRenderOpts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel9, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 7, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(346, 320)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.Size = New System.Drawing.Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(11, 142)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(86, 14)
			Me.radLabel1.TabIndex = 4
			Me.radLabel1.Text = "Navigate to date"
			Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox1.Location = New System.Drawing.Point(10, 50)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New System.Drawing.Size(149, 17)
			Me.radCheckBox1.TabIndex = 9
			Me.radCheckBox1.Text = "Show Navigation Buttons"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBox1.Click += New System.EventHandler(Me.radCheckBox1_Click);
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox2.Location = New System.Drawing.Point(10, 73)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New System.Drawing.Size(132, 17)
			Me.radCheckBox2.TabIndex = 10
			Me.radCheckBox2.Text = "Show Fast Navigation"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBox2.Click += New System.EventHandler(Me.radCheckBox2_Click);
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox3.Location = New System.Drawing.Point(10, 27)
			Me.radCheckBox3.Name = "radCheckBox3"
			Me.radCheckBox3.Size = New System.Drawing.Size(128, 17)
			Me.radCheckBox3.TabIndex = 11
			Me.radCheckBox3.Text = "Show Navigation Bar"
			Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBox3.Click += New System.EventHandler(Me.radCheckBox3_Click);
			' 
			' radLabel9
			' 
			Me.radLabel9.BackColor = System.Drawing.Color.Transparent
			Me.radLabel9.ForeColor = System.Drawing.Color.Black
			Me.radLabel9.Location = New System.Drawing.Point(37, 333)
			Me.radLabel9.Name = "radLabel9"
			' 
			' 
			' 
			Me.radLabel9.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel9.Size = New System.Drawing.Size(105, 14)
			Me.radLabel9.TabIndex = 23
			Me.radLabel9.Text = "Fast navigation step"
			Me.radLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radDateTimePicker3
			' 
			Me.radDateTimePicker3.AutoSize = True
			Me.radDateTimePicker3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radDateTimePicker3.Checked = True
			Me.radDateTimePicker3.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePicker3.Location = New System.Drawing.Point(11, 168)
			Me.radDateTimePicker3.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker3.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker3.Name = "radDateTimePicker3"
			Me.radDateTimePicker3.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker3.Size = New System.Drawing.Size(141, 22)
			Me.radDateTimePicker3.TabIndex = 13
			Me.radDateTimePicker3.Text = "radDateTimePicker3"
			Me.radDateTimePicker3.Value = New System.DateTime(2007, 9, 10, 10, 33, 34, 212)
'			Me.radDateTimePicker3.ValueChanged += New System.EventHandler(Me.radDateTimePicker3_ValueChanged);
			' 
			' radDateTimePicker1
			' 
			Me.radDateTimePicker1.AutoSize = True
			Me.radDateTimePicker1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radDateTimePicker1.Checked = True
			Me.radDateTimePicker1.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePicker1.Location = New System.Drawing.Point(11, 108)
			Me.radDateTimePicker1.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker1.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.Name = "radDateTimePicker1"
			Me.radDateTimePicker1.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker1.Size = New System.Drawing.Size(141, 22)
			Me.radDateTimePicker1.TabIndex = 19
			Me.radDateTimePicker1.Text = "radDateTimePicker1"
			Me.radDateTimePicker1.Value = New System.DateTime(1900, 8, 24, 14, 50, 0, 0)
'			Me.radDateTimePicker1.ValueChanged += New System.EventHandler(Me.radDateTimePicker1_ValueChanged);
			' 
			' radLabel8
			' 
			Me.radLabel8.BackColor = System.Drawing.Color.Transparent
			Me.radLabel8.ForeColor = System.Drawing.Color.Black
			Me.radLabel8.Location = New System.Drawing.Point(11, 82)
			Me.radLabel8.Name = "radLabel8"
			' 
			' 
			' 
			Me.radLabel8.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel8.Size = New System.Drawing.Size(86, 14)
			Me.radLabel8.TabIndex = 22
			Me.radLabel8.Text = "Range Min Date"
			Me.radLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radDateTimePicker2
			' 
			Me.radDateTimePicker2.AutoSize = True
			Me.radDateTimePicker2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radDateTimePicker2.Checked = True
			Me.radDateTimePicker2.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePicker2.Location = New System.Drawing.Point(11, 48)
			Me.radDateTimePicker2.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker2.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.Name = "radDateTimePicker2"
			Me.radDateTimePicker2.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radDateTimePicker2.Size = New System.Drawing.Size(141, 22)
			Me.radDateTimePicker2.TabIndex = 20
			Me.radDateTimePicker2.Text = "radDateTimePicker2"
			Me.radDateTimePicker2.Value = New System.DateTime(2100, 8, 24, 14, 50, 0, 0)
'			Me.radDateTimePicker2.ValueChanged += New System.EventHandler(Me.radDateTimePicker2_ValueChanged);
			' 
			' radLabel7
			' 
			Me.radLabel7.BackColor = System.Drawing.Color.Transparent
			Me.radLabel7.ForeColor = System.Drawing.Color.Black
			Me.radLabel7.Location = New System.Drawing.Point(11, 22)
			Me.radLabel7.Name = "radLabel7"
			' 
			' 
			' 
			Me.radLabel7.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel7.Size = New System.Drawing.Size(89, 14)
			Me.radLabel7.TabIndex = 21
			Me.radLabel7.Text = "Range Max Date"
			Me.radLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radGroupRenderOpts
			' 
			Me.radGroupRenderOpts.Controls.Add(Me.radCheckBox3)
			Me.radGroupRenderOpts.Controls.Add(Me.radCheckBox1)
			Me.radGroupRenderOpts.Controls.Add(Me.radCheckBox2)
			Me.radGroupRenderOpts.FooterImageIndex = -1
			Me.radGroupRenderOpts.FooterImageKey = ""
			Me.radGroupRenderOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderOpts.HeaderImageIndex = -1
			Me.radGroupRenderOpts.HeaderImageKey = ""
			Me.radGroupRenderOpts.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupRenderOpts.HeaderText = "Rendering Options"
			Me.radGroupRenderOpts.Location = New System.Drawing.Point(15, 6)
			Me.radGroupRenderOpts.Name = "radGroupRenderOpts"
			' 
			' 
			' 
			Me.radGroupRenderOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderOpts.Size = New System.Drawing.Size(162, 104)
			Me.radGroupRenderOpts.TabIndex = 13
			Me.radGroupRenderOpts.Text = "Rendering Options"
			' 
			' radGroupDateOpts
			' 
			Me.radGroupDateOpts.Controls.Add(Me.radLabel7)
			Me.radGroupDateOpts.Controls.Add(Me.radDateTimePicker3)
			Me.radGroupDateOpts.Controls.Add(Me.radDateTimePicker2)
			Me.radGroupDateOpts.Controls.Add(Me.radLabel8)
			Me.radGroupDateOpts.Controls.Add(Me.radDateTimePicker1)
			Me.radGroupDateOpts.Controls.Add(Me.radLabel1)
			Me.radGroupDateOpts.FooterImageIndex = -1
			Me.radGroupDateOpts.FooterImageKey = ""
			Me.radGroupDateOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupDateOpts.HeaderImageIndex = -1
			Me.radGroupDateOpts.HeaderImageKey = ""
			Me.radGroupDateOpts.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupDateOpts.HeaderText = "Date Options"
			Me.radGroupDateOpts.Location = New System.Drawing.Point(15, 116)
			Me.radGroupDateOpts.Name = "radGroupDateOpts"
			' 
			' 
			' 
			Me.radGroupDateOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupDateOpts.Size = New System.Drawing.Size(162, 202)
			Me.radGroupDateOpts.TabIndex = 13
			Me.radGroupDateOpts.Text = "Date Options"
			' 
			' radSpinNavigationStep
			' 
			Me.radSpinNavigationStep.BackColor = System.Drawing.Color.White
			Me.radSpinNavigationStep.ForeColor = System.Drawing.Color.Black
			Me.radSpinNavigationStep.Location = New System.Drawing.Point(37, 353)
			Me.radSpinNavigationStep.Name = "radSpinNavigationStep"
			' 
			' 
			' 
			Me.radSpinNavigationStep.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinNavigationStep.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinNavigationStep.ShowBorder = True
			Me.radSpinNavigationStep.Size = New System.Drawing.Size(120, 20)
			Me.radSpinNavigationStep.TabIndex = 24
			Me.radSpinNavigationStep.Value = New Decimal(New Integer() { 3, 0, 0, 0})
'			Me.radSpinNavigationStep.ValueChanged += New System.EventHandler(Me.radSpinNavigationStep_ValueChanged);
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 869)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRenderOpts.ResumeLayout(False)
			Me.radGroupRenderOpts.PerformLayout()
			CType(Me.radGroupDateOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupDateOpts.ResumeLayout(False)
			Me.radGroupDateOpts.PerformLayout()
			CType(Me.radSpinNavigationStep, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
		Private WithEvents radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDateTimePicker3 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private radGroupRenderOpts As Telerik.WinControls.UI.RadGroupBox
		Private radGroupDateOpts As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radSpinNavigationStep As Telerik.WinControls.UI.RadSpinEditor
	End Class
End Namespace