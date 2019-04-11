Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.DateTimePicker
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
			Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLblLongDateFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radLblShortDateFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLblTimeFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker3 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radBtnClearAll = New Telerik.WinControls.UI.RadButton()
			Me.radGroupExampleSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadio24Hours = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio12Hours = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblLongDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblShortDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblTimeFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnClearAll, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupExampleSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupExampleSettings.SuspendLayout()
			CType(Me.radRadio24Hours, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio12Hours, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radLblLongDateFormat)
			Me.radPanelDemoHolder.Controls.Add(Me.radDateTimePicker2)
			Me.radPanelDemoHolder.Controls.Add(Me.radDateTimePicker1)
			Me.radPanelDemoHolder.Controls.Add(Me.radLblShortDateFormat)
			Me.radPanelDemoHolder.Controls.Add(Me.radDateTimePicker3)
			Me.radPanelDemoHolder.Controls.Add(Me.radLblTimeFormat)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(410, 299)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(405, 139)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupExampleSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupExampleSettings, 0)
			' 
			' radDateTimePicker1
			' 
			Me.radDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radDateTimePicker1.AutoSize = True
			Me.radDateTimePicker1.Checked = True
			Me.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long
			Me.radDateTimePicker1.Location = New System.Drawing.Point(173, 25)
			Me.radDateTimePicker1.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker1.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.Name = "radDateTimePicker1"
			Me.radDateTimePicker1.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker1.Size = New System.Drawing.Size(191, 22)
			Me.radDateTimePicker1.TabIndex = 0
			Me.radDateTimePicker1.TabStop = False
			Me.radDateTimePicker1.Text = "radDateTimePicker1"
			Me.radDateTimePicker1.Value = New System.DateTime(2007, 8, 23, 15, 29, 8, 309)
			' 
			' radLblLongDateFormat
			' 
			Me.radLblLongDateFormat.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblLongDateFormat.Location = New System.Drawing.Point(56, 25)
			Me.radLblLongDateFormat.Name = "radLblLongDateFormat"
			' 
			' 
			' 
			Me.radLblLongDateFormat.Size = New System.Drawing.Size(95, 16)
			Me.radLblLongDateFormat.TabIndex = 1
			Me.radLblLongDateFormat.Text = "Long date format:"
			' 
			' radLblShortDateFormat
			' 
			Me.radLblShortDateFormat.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblShortDateFormat.Location = New System.Drawing.Point(56, 59)
			Me.radLblShortDateFormat.Name = "radLblShortDateFormat"
			' 
			' 
			' 
			Me.radLblShortDateFormat.Size = New System.Drawing.Size(97, 16)
			Me.radLblShortDateFormat.TabIndex = 3
			Me.radLblShortDateFormat.Text = "Short date format:"
			' 
			' radDateTimePicker2
			' 
			Me.radDateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radDateTimePicker2.AutoSize = True
			Me.radDateTimePicker2.Checked = True
			Me.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
			Me.radDateTimePicker2.Location = New System.Drawing.Point(173, 59)
			Me.radDateTimePicker2.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker2.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.Name = "radDateTimePicker2"
			Me.radDateTimePicker2.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker2.Size = New System.Drawing.Size(191, 22)
			Me.radDateTimePicker2.TabIndex = 2
			Me.radDateTimePicker2.TabStop = False
			Me.radDateTimePicker2.Text = "radDateTimePicker2"
			Me.radDateTimePicker2.Value = New System.DateTime(1980, 1, 1, 0, 0, 0, 0)
			' 
			' radLblTimeFormat
			' 
			Me.radLblTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblTimeFormat.Location = New System.Drawing.Point(56, 92)
			Me.radLblTimeFormat.Name = "radLblTimeFormat"
			' 
			' 
			' 
			Me.radLblTimeFormat.Size = New System.Drawing.Size(70, 16)
			Me.radLblTimeFormat.TabIndex = 5
			Me.radLblTimeFormat.Text = "Time format:"
			' 
			' radDateTimePicker3
			' 
			Me.radDateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radDateTimePicker3.AutoSize = True
			Me.radDateTimePicker3.Checked = True
			Me.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
			Me.radDateTimePicker3.Location = New System.Drawing.Point(173, 93)
			Me.radDateTimePicker3.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.radDateTimePicker3.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker3.Name = "radDateTimePicker3"
			Me.radDateTimePicker3.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radDateTimePicker3.ShowUpDown = True
			Me.radDateTimePicker3.Size = New System.Drawing.Size(191, 22)
			Me.radDateTimePicker3.TabIndex = 4
			Me.radDateTimePicker3.TabStop = False
			Me.radDateTimePicker3.Text = "radDateTimePicker3"
			Me.radDateTimePicker3.Value = New System.DateTime(1980, 1, 1, 0, 0, 0, 0)
			' 
			' radBtnClearAll
			' 
			Me.radBtnClearAll.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radBtnClearAll.Location = New System.Drawing.Point(16, 84)
			Me.radBtnClearAll.Name = "radBtnClearAll"
			Me.radBtnClearAll.Size = New System.Drawing.Size(128, 23)
			Me.radBtnClearAll.TabIndex = 6
			Me.radBtnClearAll.Text = "Clear All"
'			Me.radBtnClearAll.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radGroupExampleSettings
			' 
			Me.radGroupExampleSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupExampleSettings.Controls.Add(Me.radRadio24Hours)
			Me.radGroupExampleSettings.Controls.Add(Me.radRadio12Hours)
			Me.radGroupExampleSettings.Controls.Add(Me.radBtnClearAll)
			Me.radGroupExampleSettings.FooterImageIndex = -1
			Me.radGroupExampleSettings.FooterImageKey = ""
			Me.radGroupExampleSettings.FooterText = ""
			Me.radGroupExampleSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupExampleSettings.HeaderImageIndex = -1
			Me.radGroupExampleSettings.HeaderImageKey = ""
			Me.radGroupExampleSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupExampleSettings.HeaderText = " Settings "
			Me.radGroupExampleSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupExampleSettings.Name = "radGroupExampleSettings"
			Me.radGroupExampleSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupExampleSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupExampleSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupExampleSettings.Size = New System.Drawing.Size(180, 122)
			Me.radGroupExampleSettings.TabIndex = 7
			Me.radGroupExampleSettings.Text = " Settings "
			' 
			' radRadio24Hours
			' 
			Me.radRadio24Hours.Location = New System.Drawing.Point(16, 53)
			Me.radRadio24Hours.Name = "radRadio24Hours"
			' 
			' 
			' 
			Me.radRadio24Hours.Size = New System.Drawing.Size(66, 16)
			Me.radRadio24Hours.TabIndex = 7
			Me.radRadio24Hours.Text = "24 Hours"
'			Me.radRadio24Hours.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadRadioHourFormat_ToggleStateChanged);
			' 
			' radRadio12Hours
			' 
			Me.radRadio12Hours.Location = New System.Drawing.Point(16, 31)
			Me.radRadio12Hours.Name = "radRadio12Hours"
			' 
			' 
			' 
			Me.radRadio12Hours.Size = New System.Drawing.Size(66, 16)
			Me.radRadio12Hours.TabIndex = 7
			Me.radRadio12Hours.Text = "12 Hours"
'			Me.radRadio12Hours.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadRadioHourFormat_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblLongDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblShortDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblTimeFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnClearAll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupExampleSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupExampleSettings.ResumeLayout(False)
			CType(Me.radRadio24Hours, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio12Hours, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLblLongDateFormat As Telerik.WinControls.UI.RadLabel
		Private radLblShortDateFormat As Telerik.WinControls.UI.RadLabel
		Private radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLblTimeFormat As Telerik.WinControls.UI.RadLabel
		Private radDateTimePicker3 As Telerik.WinControls.UI.RadDateTimePicker
		Private WithEvents radBtnClearAll As Telerik.WinControls.UI.RadButton
		Private radGroupExampleSettings As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadio24Hours As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadio12Hours As Telerik.WinControls.UI.RadRadioButton

	End Class
End Namespace