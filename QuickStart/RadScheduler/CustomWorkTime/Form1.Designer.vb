Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.CustomWorkTime
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
			Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(217, 1251)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radDateTimePicker2)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radDateTimePicker1)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "WorkTime Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 48)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(197, 131)
			Me.radGroupBox1.TabIndex = 5
			Me.radGroupBox1.Text = "WorkTime Settings"
			' 
			' radDateTimePicker2
			' 
			Me.radDateTimePicker2.AutoSize = True
			Me.radDateTimePicker2.CustomFormat = "HH:mm"
			Me.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.radDateTimePicker2.Location = New System.Drawing.Point(14, 95)
			Me.radDateTimePicker2.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker2.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.Name = "radDateTimePicker2"
			Me.radDateTimePicker2.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.ShowUpDown = True
			Me.radDateTimePicker2.Size = New System.Drawing.Size(150, 22)
			Me.radDateTimePicker2.TabIndex = 3
			Me.radDateTimePicker2.Text = "radDateTimePicker2"
			Me.radDateTimePicker2.Value = New System.DateTime(2010, 1, 18, 16, 45, 7, 444)
'			Me.radDateTimePicker2.ValueChanged += New System.EventHandler(Me.radDateTimePicker_ValueChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(14, 74)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(21, 14)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "To:"
			Me.radLabel2.TextWrap = True
			' 
			' radDateTimePicker1
			' 
			Me.radDateTimePicker1.AutoSize = True
			Me.radDateTimePicker1.CustomFormat = "HH:mm"
			Me.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.radDateTimePicker1.Location = New System.Drawing.Point(14, 45)
			Me.radDateTimePicker1.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker1.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.Name = "radDateTimePicker1"
			Me.radDateTimePicker1.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.ShowUpDown = True
			Me.radDateTimePicker1.Size = New System.Drawing.Size(150, 22)
			Me.radDateTimePicker1.TabIndex = 1
			Me.radDateTimePicker1.Text = "radDateTimePicker1"
			Me.radDateTimePicker1.Value = New System.DateTime(2010, 1, 18, 16, 44, 48, 954)
'			Me.radDateTimePicker1.ValueChanged += New System.EventHandler(Me.radDateTimePicker_ValueChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(14, 24)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(34, 14)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "From:"
			Me.radLabel1.TextWrap = True
			' 
			' radScheduler1
			' 
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 79)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New System.Drawing.Size(1257, 587)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
'			Me.radScheduler1.ActiveViewChanged += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerViewChangedEventArgs)(Me.radScheduler1_ActiveViewChanged);
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AutoSize = True
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1257, 79)
			Me.radSchedulerNavigator1.TabIndex = 2
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.ThemeName = "ControlDefault"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1257, 666)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator

	End Class
End Namespace