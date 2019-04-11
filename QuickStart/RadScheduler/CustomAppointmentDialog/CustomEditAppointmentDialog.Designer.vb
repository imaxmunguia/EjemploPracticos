Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.CustomAppointmentDialog
	Partial Public Class CustomEditAppointmentDialog
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomEditAppointmentDialog))
			Me.timeEnd = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.dateEnd = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.timeStart = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.dateStart = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.lblEndTime = New Telerik.WinControls.UI.RadLabel()
			Me.lblStartTime = New Telerik.WinControls.UI.RadLabel()
			Me.chkAllDay = New Telerik.WinControls.UI.RadCheckBox()
			Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
			Me.txtLocation = New Telerik.WinControls.UI.RadTextBox()
			Me.txtSubject = New Telerik.WinControls.UI.RadTextBox()
			Me.lblLocation = New Telerik.WinControls.UI.RadLabel()
			Me.lblSubject = New Telerik.WinControls.UI.RadLabel()
			Me.cmbShowTimeAs = New Telerik.WinControls.UI.RadDropDownList()
			Me.lblStatus = New Telerik.WinControls.UI.RadLabel()
			Me.ribbonBarAppointment = New Telerik.WinControls.UI.RadRibbonBar()
			Me.tabAppointment = New Telerik.WinControls.UI.RibbonTab()
			Me.grActions = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.btnSave = New Telerik.WinControls.UI.RadButtonElement()
			Me.btnDelete = New Telerik.WinControls.UI.RadButtonElement()
			Me.grOptions = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.btnRecurrence = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonFormBehavior1 = New Telerik.WinControls.UI.RadRibbonFormBehavior()
			Me.txtEmail = New Telerik.WinControls.UI.RadTextBox()
			Me.lblEmail = New Telerik.WinControls.UI.RadLabel()
			CType(Me.timeEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblEndTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAllDay, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblLocation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblSubject, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonBarAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' timeEnd
			' 
			Me.timeEnd.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.timeEnd.Checked = True
			Me.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
			Me.timeEnd.Location = New System.Drawing.Point(211, 242)
			Me.timeEnd.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.timeEnd.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.timeEnd.Name = "timeEnd"
			Me.timeEnd.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.timeEnd.ShowUpDown = True
			Me.timeEnd.Size = New System.Drawing.Size(88, 22)
			Me.timeEnd.TabIndex = 5
			Me.timeEnd.TabStop = False
			Me.timeEnd.Value = New System.DateTime(2008, 9, 12, 16, 55, 40, 944)
			' 
			' dateEnd
			' 
			Me.dateEnd.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dateEnd.Checked = True
			Me.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
			Me.dateEnd.Location = New System.Drawing.Point(89, 242)
			Me.dateEnd.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.dateEnd.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.dateEnd.Name = "dateEnd"
			Me.dateEnd.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.dateEnd.Size = New System.Drawing.Size(116, 22)
			Me.dateEnd.TabIndex = 4
			Me.dateEnd.TabStop = False
			Me.dateEnd.Value = New System.DateTime(2008, 9, 12, 16, 55, 37, 429)
			' 
			' timeStart
			' 
			Me.timeStart.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.timeStart.Checked = True
			Me.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
			Me.timeStart.Location = New System.Drawing.Point(211, 214)
			Me.timeStart.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.timeStart.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.timeStart.Name = "timeStart"
			Me.timeStart.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.timeStart.ShowUpDown = True
			Me.timeStart.Size = New System.Drawing.Size(88, 22)
			Me.timeStart.TabIndex = 3
			Me.timeStart.TabStop = False
			Me.timeStart.Value = New System.DateTime(2008, 9, 12, 16, 55, 34, 944)
			' 
			' dateStart
			' 
			Me.dateStart.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dateStart.Checked = True
			Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
			Me.dateStart.Location = New System.Drawing.Point(89, 214)
			Me.dateStart.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
			Me.dateStart.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.dateStart.Name = "dateStart"
			Me.dateStart.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.dateStart.Size = New System.Drawing.Size(116, 22)
			Me.dateStart.TabIndex = 2
			Me.dateStart.TabStop = False
			Me.dateStart.ThemeName = "ControlDefault"
			Me.dateStart.Value = New System.DateTime(2008, 9, 12, 16, 51, 38, 596)
			' 
			' lblEndTime
			' 
			Me.lblEndTime.BackColor = System.Drawing.Color.Transparent
			Me.lblEndTime.Location = New System.Drawing.Point(7, 243)
			Me.lblEndTime.Name = "lblEndTime"
			Me.lblEndTime.Size = New System.Drawing.Size(54, 16)
			Me.lblEndTime.TabIndex = 14
			Me.lblEndTime.Text = "End time:"
			' 
			' lblStartTime
			' 
			Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
			Me.lblStartTime.Location = New System.Drawing.Point(7, 220)
			Me.lblStartTime.Name = "lblStartTime"
			Me.lblStartTime.Size = New System.Drawing.Size(58, 16)
			Me.lblStartTime.TabIndex = 13
			Me.lblStartTime.Text = "Start time:"
			' 
			' chkAllDay
			' 
			Me.chkAllDay.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkAllDay.BackColor = System.Drawing.Color.Transparent
			Me.chkAllDay.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkAllDay.Location = New System.Drawing.Point(305, 219)
			Me.chkAllDay.Name = "chkAllDay"
			' 
			' 
			' 
			Me.chkAllDay.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkAllDay.Size = New System.Drawing.Size(87, 17)
			Me.chkAllDay.TabIndex = 6
			Me.chkAllDay.Text = "All day event"
			' 
			' txtDescription
			' 
			Me.txtDescription.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtDescription.Location = New System.Drawing.Point(7, 340)
			Me.txtDescription.Multiline = True
			Me.txtDescription.Name = "txtDescription"
			' 
			' 
			' 
			Me.txtDescription.RootElement.StretchVertically = True
			Me.txtDescription.Size = New System.Drawing.Size(573, 205)
			Me.txtDescription.TabIndex = 9
			Me.txtDescription.TabStop = False
			' 
			' txtLocation
			' 
			Me.txtLocation.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtLocation.Location = New System.Drawing.Point(89, 185)
			Me.txtLocation.Name = "txtLocation"
			Me.txtLocation.Size = New System.Drawing.Size(491, 20)
			Me.txtLocation.TabIndex = 1
			Me.txtLocation.TabStop = False
			' 
			' txtSubject
			' 
			Me.txtSubject.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtSubject.Location = New System.Drawing.Point(89, 159)
			Me.txtSubject.Name = "txtSubject"
			Me.txtSubject.Size = New System.Drawing.Size(491, 20)
			Me.txtSubject.TabIndex = 0
			Me.txtSubject.TabStop = False
			' 
			' lblLocation
			' 
			Me.lblLocation.BackColor = System.Drawing.Color.Transparent
			Me.lblLocation.Location = New System.Drawing.Point(7, 189)
			Me.lblLocation.Name = "lblLocation"
			Me.lblLocation.Size = New System.Drawing.Size(52, 16)
			Me.lblLocation.TabIndex = 12
			Me.lblLocation.Text = "Location:"
			' 
			' lblSubject
			' 
			Me.lblSubject.BackColor = System.Drawing.Color.Transparent
			Me.lblSubject.Location = New System.Drawing.Point(7, 162)
			Me.lblSubject.Name = "lblSubject"
			Me.lblSubject.Size = New System.Drawing.Size(47, 16)
			Me.lblSubject.TabIndex = 11
			Me.lblSubject.Text = "Subject:"
			' 
			' cmbShowTimeAs
			' 
			Me.cmbShowTimeAs.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmbShowTimeAs.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbShowTimeAs.Location = New System.Drawing.Point(89, 275)
			Me.cmbShowTimeAs.Name = "cmbShowTimeAs"
			' 
			' 
			' 
			Me.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbShowTimeAs.Size = New System.Drawing.Size(210, 20)
			Me.cmbShowTimeAs.TabIndex = 7
			Me.cmbShowTimeAs.TabStop = False
			' 
			' lblStatus
			' 
			Me.lblStatus.BackColor = System.Drawing.Color.Transparent
			Me.lblStatus.Location = New System.Drawing.Point(7, 275)
			Me.lblStatus.Name = "lblStatus"
			Me.lblStatus.Size = New System.Drawing.Size(77, 16)
			Me.lblStatus.TabIndex = 15
			Me.lblStatus.Text = "Show time as:"
			' 
			' ribbonBarAppointment
			' 
			Me.ribbonBarAppointment.AutoSize = True
			Me.ribbonBarAppointment.CommandTabs.AddRange(New Telerik.WinControls.RadItem() { Me.tabAppointment})
			Me.ribbonBarAppointment.Dock = System.Windows.Forms.DockStyle.Top
			Me.ribbonBarAppointment.EnableKeyMap = True
			' 
			' 
			' 
			Me.ribbonBarAppointment.ExitButton.Text = "Exit"
			Me.ribbonBarAppointment.Location = New System.Drawing.Point(0, 0)
			Me.ribbonBarAppointment.Name = "ribbonBarAppointment"
			' 
			' 
			' 
			Me.ribbonBarAppointment.OptionsButton.Text = "Options"
			Me.ribbonBarAppointment.Size = New System.Drawing.Size(616, 153)
			Me.ribbonBarAppointment.StartButtonImage = (CType(resources.GetObject("ribbonBarAppointment.StartButtonImage"), System.Drawing.Image))
			Me.ribbonBarAppointment.TabIndex = 10
			CType(Me.ribbonBarAppointment.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = ""
            Me.ribbonBarAppointment.RibbonBarElement.QuickAccessToolBar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' tabAppointment
			' 
			Me.tabAppointment.Alignment = System.Drawing.ContentAlignment.BottomLeft
			' 
			' tabAppointment.ContentPanel
			' 
			Me.tabAppointment.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.tabAppointment.ContentPanel.CausesValidation = True
			Me.tabAppointment.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tabAppointment.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.tabAppointment.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.tabAppointment.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.tabAppointment.IsSelected = True
			Me.tabAppointment.Items.AddRange(New Telerik.WinControls.RadItem() { Me.grActions, Me.grOptions})
			Me.tabAppointment.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.tabAppointment.Name = "tabAppointment"
			Me.tabAppointment.StretchHorizontally = False
			Me.tabAppointment.Text = "Appointment"
			' 
			' grActions
			' 
			Me.grActions.Items.AddRange(New Telerik.WinControls.RadItem() { Me.btnSave, Me.btnDelete})
			Me.grActions.Name = "grActions"
			Me.grActions.Text = "Actions"
			' 
			' btnSave
			' 
			Me.btnSave.Class = "RibbonBarButtonElement"
			Me.btnSave.Image = My.Resources.SaveAppointment
			Me.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.btnSave.ImageIndex = 0
			Me.btnSave.MeasureTrailingSpaces = False
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Text = "Save &&" & Constants.vbLf & "Close"
			Me.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
			' 
			' btnDelete
			' 
			Me.btnDelete.Alignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.btnDelete.Class = "RibbonBarButtonElement"
			Me.btnDelete.Image = My.Resources.DeleteAppointment
			Me.btnDelete.ImageIndex = 1
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.StretchVertically = False
			Me.btnDelete.Text = "Delete"
			Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click);
			' 
			' grOptions
			' 
			Me.grOptions.Items.AddRange(New Telerik.WinControls.RadItem() { Me.btnRecurrence})
			Me.grOptions.Name = "grOptions"
			Me.grOptions.Text = "Options"
			' 
			' btnRecurrence
			' 
			Me.btnRecurrence.Class = "RibbonBarButtonElement"
			Me.btnRecurrence.Image = My.Resources.RecurrenceAppointment
			Me.btnRecurrence.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.btnRecurrence.ImageIndex = 2
			Me.btnRecurrence.Name = "btnRecurrence"
			Me.btnRecurrence.Text = "Recurrence"
			Me.btnRecurrence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnRecurrence.Click += New System.EventHandler(Me.btnRecurrence_Click);
			' 
			' radRibbonFormBehavior1
			' 
			Me.radRibbonFormBehavior1.Form = Me
			' 
			' txtEmail
			' 
			Me.txtEmail.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtEmail.Location = New System.Drawing.Point(89, 301)
			Me.txtEmail.Name = "txtEmail"
			Me.txtEmail.Size = New System.Drawing.Size(210, 20)
			Me.txtEmail.TabIndex = 8
			Me.txtEmail.TabStop = False
			' 
			' lblEmail
			' 
			Me.lblEmail.BackColor = System.Drawing.Color.Transparent
			Me.lblEmail.Location = New System.Drawing.Point(7, 301)
			Me.lblEmail.Name = "lblEmail"
			Me.lblEmail.Size = New System.Drawing.Size(38, 16)
			Me.lblEmail.TabIndex = 16
			Me.lblEmail.Text = "Email:"
			' 
			' CustomEditAppointmentDialog
			' 
			Me.AcceptButton = Me.btnSave
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
			Me.ClientSize = New System.Drawing.Size(616, 590)
			Me.Controls.Add(Me.txtEmail)
			Me.Controls.Add(Me.lblEmail)
			Me.Controls.Add(Me.cmbShowTimeAs)
			Me.Controls.Add(Me.lblStatus)
			Me.Controls.Add(Me.txtLocation)
			Me.Controls.Add(Me.txtSubject)
			Me.Controls.Add(Me.lblLocation)
			Me.Controls.Add(Me.lblSubject)
			Me.Controls.Add(Me.txtDescription)
			Me.Controls.Add(Me.chkAllDay)
			Me.Controls.Add(Me.timeEnd)
			Me.Controls.Add(Me.dateEnd)
			Me.Controls.Add(Me.timeStart)
			Me.Controls.Add(Me.dateStart)
			Me.Controls.Add(Me.lblEndTime)
			Me.Controls.Add(Me.lblStartTime)
			Me.Controls.Add(Me.ribbonBarAppointment)
			Me.FormBehavior = Me.radRibbonFormBehavior1
			Me.MinimumSize = New System.Drawing.Size(600, 365)
			Me.Name = "CustomEditAppointmentDialog"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New System.Drawing.Size(600, 365)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = ""
			CType(Me.timeEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblEndTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblStartTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAllDay, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblLocation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblSubject, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonBarAppointment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblEmail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ribbonBarAppointment As Telerik.WinControls.UI.RadRibbonBar
		Private radRibbonFormBehavior1 As Telerik.WinControls.UI.RadRibbonFormBehavior
		Private tabAppointment As Telerik.WinControls.UI.RibbonTab
		Private grActions As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents btnSave As Telerik.WinControls.UI.RadButtonElement
		Protected timeEnd As Telerik.WinControls.UI.RadDateTimePicker
		Protected dateEnd As Telerik.WinControls.UI.RadDateTimePicker
		Protected timeStart As Telerik.WinControls.UI.RadDateTimePicker
		Protected dateStart As Telerik.WinControls.UI.RadDateTimePicker
		Private lblEndTime As Telerik.WinControls.UI.RadLabel
		Private lblStartTime As Telerik.WinControls.UI.RadLabel
		Protected chkAllDay As Telerik.WinControls.UI.RadCheckBox
		Protected txtLocation As Telerik.WinControls.UI.RadTextBox
		Protected txtSubject As Telerik.WinControls.UI.RadTextBox
		Private lblLocation As Telerik.WinControls.UI.RadLabel
		Private lblSubject As Telerik.WinControls.UI.RadLabel
		Protected txtDescription As Telerik.WinControls.UI.RadTextBox
		Private WithEvents btnDelete As Telerik.WinControls.UI.RadButtonElement
		Private grOptions As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents btnRecurrence As Telerik.WinControls.UI.RadButtonElement
		Protected cmbShowTimeAs As Telerik.WinControls.UI.RadDropDownList
		Private lblStatus As Telerik.WinControls.UI.RadLabel
		Protected txtEmail As Telerik.WinControls.UI.RadTextBox
		Private lblEmail As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace