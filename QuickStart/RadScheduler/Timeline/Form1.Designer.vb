Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.Timeline
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
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radDateTimePickerStart = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radDateTimePickerEnd = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorTimeSlots = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radRadioButtonWeek = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonMonth = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonHour = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonDay = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePickerStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePickerEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorTimeSlots, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonWeek, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonMonth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonHour, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonDay, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 832)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			' 
			' radScheduler1
			' 
			Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Timeline
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New System.Drawing.Size(1257, 834)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radDateTimePickerStart
			' 
			Me.radDateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radDateTimePickerStart.AutoSize = True
			Me.radDateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePickerStart.Location = New System.Drawing.Point(13, 43)
			Me.radDateTimePickerStart.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePickerStart.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePickerStart.Name = "radDateTimePickerStart"
			Me.radDateTimePickerStart.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePickerStart.Size = New System.Drawing.Size(154, 22)
			Me.radDateTimePickerStart.TabIndex = 1
			Me.radDateTimePickerStart.Text = "radDateTimePicker1"
			Me.radDateTimePickerStart.Value = New System.DateTime(2010, 1, 12, 9, 56, 48, 405)
'			Me.radDateTimePickerStart.ValueChanged += New System.EventHandler(Me.radDateTimePickerStart_ValueChanged);
			' 
			' radDateTimePickerEnd
			' 
			Me.radDateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radDateTimePickerEnd.AutoSize = True
			Me.radDateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePickerEnd.Location = New System.Drawing.Point(13, 91)
			Me.radDateTimePickerEnd.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePickerEnd.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePickerEnd.Name = "radDateTimePickerEnd"
			Me.radDateTimePickerEnd.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePickerEnd.Size = New System.Drawing.Size(154, 22)
			Me.radDateTimePickerEnd.TabIndex = 2
			Me.radDateTimePickerEnd.Text = "radDateTimePicker2"
			Me.radDateTimePickerEnd.Value = New System.DateTime(2010, 1, 12, 9, 57, 3, 799)
'			Me.radDateTimePickerEnd.ValueChanged += New System.EventHandler(Me.radDateTimePickerEnd_ValueChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(13, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(91, 14)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Range Start Date"
			Me.radLabel1.TextWrap = True
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(13, 71)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(88, 14)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "Range End Date"
			Me.radLabel2.TextWrap = True
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorTimeSlots)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonWeek)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonMonth)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonHour)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonDay)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Time scales"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 37)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 186)
			Me.radGroupBox2.TabIndex = 6
			Me.radGroupBox2.Text = "Time scales"
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel4.Location = New System.Drawing.Point(13, 134)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(94, 14)
			Me.radLabel4.TabIndex = 9
			Me.radLabel4.Text = "Visible Time Slots"
			Me.radLabel4.TextWrap = True
			' 
			' radSpinEditorTimeSlots
			' 
			Me.radSpinEditorTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorTimeSlots.Location = New System.Drawing.Point(13, 154)
			Me.radSpinEditorTimeSlots.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorTimeSlots.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditorTimeSlots.Name = "radSpinEditorTimeSlots"
			' 
			' 
			' 
			Me.radSpinEditorTimeSlots.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorTimeSlots.ShowBorder = True
			Me.radSpinEditorTimeSlots.Size = New System.Drawing.Size(156, 20)
			Me.radSpinEditorTimeSlots.TabIndex = 8
			Me.radSpinEditorTimeSlots.Text = "radSpinEditorTimeSlots"
			Me.radSpinEditorTimeSlots.Value = New Decimal(New Integer() { 7, 0, 0, 0})
'			Me.radSpinEditorTimeSlots.ValueChanged += New System.EventHandler(Me.radSpinEditorTimeSlots_ValueChanged);
			' 
			' radRadioButtonWeek
			' 
			Me.radRadioButtonWeek.Location = New System.Drawing.Point(13, 80)
			Me.radRadioButtonWeek.Name = "radRadioButtonWeek"
			Me.radRadioButtonWeek.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonWeek.TabIndex = 2
			Me.radRadioButtonWeek.Text = "Week"
'			Me.radRadioButtonWeek.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonDay_ToggleStateChanged);
			' 
			' radRadioButtonMonth
			' 
			Me.radRadioButtonMonth.Location = New System.Drawing.Point(13, 104)
			Me.radRadioButtonMonth.Name = "radRadioButtonMonth"
			Me.radRadioButtonMonth.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonMonth.TabIndex = 2
			Me.radRadioButtonMonth.Text = "Month"
'			Me.radRadioButtonMonth.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonDay_ToggleStateChanged);
			' 
			' radRadioButtonHour
			' 
			Me.radRadioButtonHour.Location = New System.Drawing.Point(13, 56)
			Me.radRadioButtonHour.Name = "radRadioButtonHour"
			Me.radRadioButtonHour.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonHour.TabIndex = 1
			Me.radRadioButtonHour.Text = "Hour"
'			Me.radRadioButtonHour.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonDay_ToggleStateChanged);
			' 
			' radRadioButtonDay
			' 
			Me.radRadioButtonDay.Location = New System.Drawing.Point(13, 32)
			Me.radRadioButtonDay.Name = "radRadioButtonDay"
			Me.radRadioButtonDay.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonDay.TabIndex = 0
			Me.radRadioButtonDay.Text = "Day"
			Me.radRadioButtonDay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radRadioButtonDay.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonDay_ToggleStateChanged);
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.radLabel1)
			Me.radGroupBox3.Controls.Add(Me.radDateTimePickerEnd)
			Me.radGroupBox3.Controls.Add(Me.radDateTimePickerStart)
			Me.radGroupBox3.Controls.Add(Me.radLabel2)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox3.HeaderText = "Date options"
			Me.radGroupBox3.Location = New System.Drawing.Point(10, 229)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New System.Drawing.Size(180, 128)
			Me.radGroupBox3.TabIndex = 7
			Me.radGroupBox3.Text = "Date options"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1257, 834)
			Me.Tag = ""
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePickerStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePickerEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorTimeSlots, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonWeek, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonMonth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonHour, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonDay, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radDateTimePickerEnd As Telerik.WinControls.UI.RadDateTimePicker
		Private WithEvents radDateTimePickerStart As Telerik.WinControls.UI.RadDateTimePicker
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButtonHour As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonDay As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonWeek As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonMonth As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorTimeSlots As Telerik.WinControls.UI.RadSpinEditor
	End Class
End Namespace