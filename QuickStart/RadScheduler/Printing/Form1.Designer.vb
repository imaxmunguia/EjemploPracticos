Namespace Telerik.Examples.WinControls.RadScheduler.Printing
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
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
            Dim dateTimeInterval1 As New Telerik.WinControls.UI.DateTimeInterval()
            Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
            Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
            Me.radPrintDocument1 = New Telerik.WinControls.UI.RadPrintDocument()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radioDetails = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioMonthly = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioWeekly = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioDaily = New Telerik.WinControls.UI.RadRadioButton()
            Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
            Me.buttonPreview = New Telerik.WinControls.UI.RadButton()
            Me.buttonSettings = New Telerik.WinControls.UI.RadButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radioDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioWeekly, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioDaily, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonPreview, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.settingsPanel.Controls.Add(Me.buttonSettings)
            Me.settingsPanel.Controls.Add(Me.buttonPreview)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.buttonPrint)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(1122, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(238, 749)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrint, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonPreview, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonSettings, 0)
            ' 
            ' radScheduler1
            ' 
            dateTimeInterval1.[End] = New System.DateTime(CLng(0))
            dateTimeInterval1.Start = New System.DateTime(CLng(0))
            Me.radScheduler1.AccessibleInterval = dateTimeInterval1
            Me.radScheduler1.AppointmentTitleFormat = Nothing
            Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radScheduler1.DataSource = Nothing
            Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
            Me.radScheduler1.HeaderFormat = "dd dddd"
            Me.radScheduler1.Location = New System.Drawing.Point(0, 77)
            Me.radScheduler1.Name = "radScheduler1"
            schedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
            schedulerDailyPrintStyle1.DateEndRange = New System.DateTime(2012, 2, 13, 0, 0, 0, _
             0)
            schedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            schedulerDailyPrintStyle1.DateStartRange = New System.DateTime(2012, 2, 8, 0, 0, 0, _
             0)
            schedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0F, System.Drawing.FontStyle.Bold)
            Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
            Me.radScheduler1.Size = New System.Drawing.Size(1122, 672)
            Me.radScheduler1.TabIndex = 1
            Me.radScheduler1.Text = "radScheduler1"
            ' 
            ' radSchedulerNavigator1
            ' 
            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
            Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
            Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
            Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
            ' 
            ' 
            ' 
            Me.radSchedulerNavigator1.RootElement.StretchVertically = False
            Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1122, 77)
            Me.radSchedulerNavigator1.TabIndex = 2
            Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
            ' 
            ' radPrintDocument1
            ' 
            Me.radPrintDocument1.AssociatedObject = Me.radScheduler1
            Me.radPrintDocument1.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
            Me.radPrintDocument1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
            Me.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]"
            Me.radPrintDocument1.LeftHeader = "[Time Printed]"
            Me.radPrintDocument1.MiddleFooter = "***"
            Me.radPrintDocument1.MiddleHeader = "Weekly Task List"
            Me.radPrintDocument1.RightFooter = "Printed by: [User Name]"
            Me.radPrintDocument1.RightHeader = "[Date Printed]"
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radioDetails)
            Me.radGroupBox1.Controls.Add(Me.radioMonthly)
            Me.radGroupBox1.Controls.Add(Me.radioWeekly)
            Me.radGroupBox1.Controls.Add(Me.radioDaily)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Print Style"
            Me.radGroupBox1.Location = New System.Drawing.Point(19, 37)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(200, 128)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Print Style"
            ' 
            ' radioDetails
            ' 
            Me.radioDetails.Location = New System.Drawing.Point(18, 97)
            Me.radioDetails.Name = "radioDetails"
            Me.radioDetails.Size = New System.Drawing.Size(110, 18)
            Me.radioDetails.TabIndex = 3
            Me.radioDetails.Text = "Details Style"
            ' 
            ' radioMonthly
            ' 
            Me.radioMonthly.Location = New System.Drawing.Point(18, 73)
            Me.radioMonthly.Name = "radioMonthly"
            Me.radioMonthly.Size = New System.Drawing.Size(110, 18)
            Me.radioMonthly.TabIndex = 2
            Me.radioMonthly.Text = "Monthly Style"
            ' 
            ' radioWeekly
            ' 
            Me.radioWeekly.Location = New System.Drawing.Point(18, 49)
            Me.radioWeekly.Name = "radioWeekly"
            Me.radioWeekly.Size = New System.Drawing.Size(110, 18)
            Me.radioWeekly.TabIndex = 1
            Me.radioWeekly.Text = "Weekly Style"
            ' 
            ' radioDaily
            ' 
            Me.radioDaily.Location = New System.Drawing.Point(18, 25)
            Me.radioDaily.Name = "radioDaily"
            Me.radioDaily.Size = New System.Drawing.Size(110, 18)
            Me.radioDaily.TabIndex = 0
            Me.radioDaily.TabStop = True
            Me.radioDaily.Text = "Daily Style"
            Me.radioDaily.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' buttonPrint
            ' 
            Me.buttonPrint.Location = New System.Drawing.Point(19, 185)
            Me.buttonPrint.Name = "buttonPrint"
            Me.buttonPrint.Size = New System.Drawing.Size(130, 24)
            Me.buttonPrint.TabIndex = 2
            Me.buttonPrint.Text = "Print ..."
            ' 
            ' buttonPreview
            ' 
            Me.buttonPreview.Location = New System.Drawing.Point(19, 223)
            Me.buttonPreview.Name = "buttonPreview"
            Me.buttonPreview.Size = New System.Drawing.Size(130, 24)
            Me.buttonPreview.TabIndex = 3
            Me.buttonPreview.Text = "Print Preview"
            ' 
            ' buttonSettings
            ' 
            Me.buttonSettings.Location = New System.Drawing.Point(19, 261)
            Me.buttonSettings.Name = "buttonSettings"
            Me.buttonSettings.Size = New System.Drawing.Size(130, 24)
            Me.buttonSettings.TabIndex = 4
            Me.buttonSettings.Text = "Print Settings"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radScheduler1)
            Me.Controls.Add(Me.radSchedulerNavigator1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1360, 749)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
            Me.Controls.SetChildIndex(Me.radScheduler1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            DirectCast(Me.radioDetails, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioMonthly, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioWeekly, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioDaily, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonPreview, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
        Friend WithEvents radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
        Friend WithEvents radPrintDocument1 As Telerik.WinControls.UI.RadPrintDocument
        Friend WithEvents radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radioDaily As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioWeekly As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioMonthly As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioDetails As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents buttonPrint As Telerik.WinControls.UI.RadButton
        Friend WithEvents buttonPreview As Telerik.WinControls.UI.RadButton
        Friend WithEvents buttonSettings As Telerik.WinControls.UI.RadButton
    End Class
End Namespace