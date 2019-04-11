Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.Forms.RadMessageBox
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
			Me.radTxtMessage = New Telerik.WinControls.UI.RadTextBox()
			Me.radCheckRTL = New Telerik.WinControls.UI.RadCheckBox()
			Me.radTxtCaption = New Telerik.WinControls.UI.RadTextBox()
			Me.radBtnShow = New Telerik.WinControls.UI.RadButton()
			Me.radComboMessageType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem10 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem11 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboButtons = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboThemes = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem15 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem16 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem17 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem18 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem19 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem20 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblDialog = New Telerik.WinControls.UI.RadLabel()
			Me.radLblTheme = New Telerik.WinControls.UI.RadLabel()
			Me.radLblButtons = New Telerik.WinControls.UI.RadLabel()
			Me.radLblType = New Telerik.WinControls.UI.RadLabel()
			Me.radLblText = New Telerik.WinControls.UI.RadLabel()
			Me.radLblCaption = New Telerik.WinControls.UI.RadLabel()
			Me.radTxtDialogResult = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTxtMessage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboMessageType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboThemes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radLblDialog, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblTheme, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtDialogResult, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(940, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 597)
            Me.settingsPanel.ThemeName = "Breeze"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' radTxtMessage
			' 
			Me.radTxtMessage.AcceptsReturn = True
			Me.radTxtMessage.ForeColor = System.Drawing.Color.Black
			Me.radTxtMessage.Location = New System.Drawing.Point(9, 94)
			Me.radTxtMessage.Multiline = True
			Me.radTxtMessage.Name = "radTxtMessage"
			' 
			' 
			' 
			Me.radTxtMessage.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtMessage.RootElement.StretchVertically = True
			Me.radTxtMessage.Size = New System.Drawing.Size(144, 41)
			Me.radTxtMessage.TabIndex = 0
			Me.radTxtMessage.Text = "Hello, World!"
			' 
			' radCheckRTL
			' 
			Me.radCheckRTL.AllowShowFocusCues = True
			Me.radCheckRTL.BackColor = System.Drawing.Color.Transparent
			Me.radCheckRTL.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckRTL.Location = New System.Drawing.Point(9, 306)
			Me.radCheckRTL.Name = "radCheckRTL"
			' 
			' 
			' 
			Me.radCheckRTL.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckRTL.Size = New System.Drawing.Size(81, 17)
			Me.radCheckRTL.TabIndex = 9
			Me.radCheckRTL.Text = "RightToLeft"
			' 
			' radTxtCaption
			' 
			Me.radTxtCaption.ForeColor = System.Drawing.Color.Black
			Me.radTxtCaption.Location = New System.Drawing.Point(9, 49)
			Me.radTxtCaption.Name = "radTxtCaption"
			Me.radTxtCaption.NullText = "Type caption..."
			' 
			' 
			' 
			Me.radTxtCaption.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtCaption.Size = New System.Drawing.Size(144, 20)
			Me.radTxtCaption.TabIndex = 1
			Me.radTxtCaption.Text = "Message"
			' 
			' radBtnShow
			' 
			Me.radBtnShow.AllowShowFocusCues = True
			Me.radBtnShow.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radBtnShow.Location = New System.Drawing.Point(456, 284)
			Me.radBtnShow.Name = "radBtnShow"
			' 
			' 
			' 
			Me.radBtnShow.Size = New System.Drawing.Size(229, 30)
			Me.radBtnShow.TabIndex = 5
			Me.radBtnShow.Text = "Show RadMessageBox"
			' 
			' radComboMessageType
			' 
			Me.radComboMessageType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboMessageType.ForeColor = System.Drawing.Color.Black
			Me.radComboMessageType.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem7, Me.radComboBoxItem8, Me.radComboBoxItem9, Me.radComboBoxItem10, Me.radComboBoxItem11}))
			Me.radComboMessageType.Location = New System.Drawing.Point(9, 161)
			Me.radComboMessageType.Name = "radComboMessageType"
			' 
			' 
			' 
			Me.radComboMessageType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboMessageType.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboMessageType.Size = New System.Drawing.Size(144, 20)
			Me.radComboMessageType.TabIndex = 8
			' 
			' radComboBoxItem7
			' 
			Me.radComboBoxItem7.Text = "None"
			' 
			' radComboBoxItem8
			' 
			Me.radComboBoxItem8.Text = "Info"
			' 
			' radComboBoxItem9
			' 
			Me.radComboBoxItem9.Text = "Question"
			' 
			' radComboBoxItem10
			' 
			Me.radComboBoxItem10.Text = "Exclamation"
			' 
			' radComboBoxItem11
			' 
			Me.radComboBoxItem11.Text = "Error"
			' 
			' radComboButtons
			' 
			Me.radComboButtons.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboButtons.ForeColor = System.Drawing.Color.Black
			Me.radComboButtons.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem3, Me.radComboBoxItem4, Me.radComboBoxItem5, Me.radComboBoxItem6}))
			Me.radComboButtons.Location = New System.Drawing.Point(9, 207)
			Me.radComboButtons.Name = "radComboButtons"
			' 
			' 
			' 
			Me.radComboButtons.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboButtons.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboButtons.Size = New System.Drawing.Size(144, 20)
			Me.radComboButtons.TabIndex = 6
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "OK"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "OK, Cancel"
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "Yes, No"
			' 
			' radComboBoxItem4
			' 
			Me.radComboBoxItem4.Text = "Yes, No, Cancel"
			' 
			' radComboBoxItem5
			' 
			Me.radComboBoxItem5.Text = "Retry, Cancel"
			' 
			' radComboBoxItem6
			' 
			Me.radComboBoxItem6.Text = "Abort, Retry, Ignore"
			' 
			' radComboThemes
			' 
			Me.radComboThemes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboThemes.ForeColor = System.Drawing.Color.Black
			Me.radComboThemes.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem15, Me.radComboBoxItem16, Me.radComboBoxItem17, Me.radComboBoxItem18, Me.radComboBoxItem19, Me.radComboBoxItem20}))
			Me.radComboThemes.Location = New System.Drawing.Point(9, 279)
			Me.radComboThemes.Name = "radComboThemes"
			' 
			' 
			' 
			Me.radComboThemes.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboThemes.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboThemes.Size = New System.Drawing.Size(144, 20)
			Me.radComboThemes.TabIndex = 11
			' 
			' radComboBoxItem15
			' 
			Me.radComboBoxItem15.Text = "ControlDefault"
			' 
			' radComboBoxItem16
			' 
			Me.radComboBoxItem16.Text = "Desert"
			' 
			' radComboBoxItem17
			' 
            Me.radComboBoxItem17.Text = "TelerikMetro"
			' 
			' radComboBoxItem18
			' 
            Me.radComboBoxItem18.Text = "Office2010Blue"
			' 
			' radComboBoxItem19
			' 
            Me.radComboBoxItem19.Text = "Office2010Black"
			' 
			' radComboBoxItem20
			' 
            Me.radComboBoxItem20.Text = "Office2010Silver"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radLblDialog)
			Me.radGroupSettings.Controls.Add(Me.radLblTheme)
			Me.radGroupSettings.Controls.Add(Me.radLblButtons)
			Me.radGroupSettings.Controls.Add(Me.radCheckRTL)
			Me.radGroupSettings.Controls.Add(Me.radLblType)
			Me.radGroupSettings.Controls.Add(Me.radTxtMessage)
			Me.radGroupSettings.Controls.Add(Me.radComboThemes)
			Me.radGroupSettings.Controls.Add(Me.radLblText)
			Me.radGroupSettings.Controls.Add(Me.radLblCaption)
			Me.radGroupSettings.Controls.Add(Me.radComboButtons)
			Me.radGroupSettings.Controls.Add(Me.radTxtDialogResult)
			Me.radGroupSettings.Controls.Add(Me.radTxtCaption)
			Me.radGroupSettings.Controls.Add(Me.radComboMessageType)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSettings.HeaderText = " MessageBox Settings "
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 5)
			Me.radGroupSettings.Name = "radGroupSettings"
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 348)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " MessageBox Settings "
			' 
			' radLblDialog
			' 
			Me.radLblDialog.ForeColor = System.Drawing.Color.Black
			Me.radLblDialog.Location = New System.Drawing.Point(9, 236)
			Me.radLblDialog.Name = "radLblDialog"
			' 
			' 
			' 
			Me.radLblDialog.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblDialog.Size = New System.Drawing.Size(75, 14)
			Me.radLblDialog.TabIndex = 12
			Me.radLblDialog.Text = "Dialog Result:"
			' 
			' radLblTheme
			' 
			Me.radLblTheme.ForeColor = System.Drawing.Color.Black
			Me.radLblTheme.Location = New System.Drawing.Point(9, 259)
			Me.radLblTheme.Name = "radLblTheme"
			' 
			' 
			' 
			Me.radLblTheme.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblTheme.Size = New System.Drawing.Size(111, 14)
			Me.radLblTheme.TabIndex = 2
			Me.radLblTheme.Text = "MessageBox Theme:"
			' 
			' radLblButtons
			' 
			Me.radLblButtons.ForeColor = System.Drawing.Color.Black
			Me.radLblButtons.Location = New System.Drawing.Point(9, 187)
			Me.radLblButtons.Name = "radLblButtons"
			' 
			' 
			' 
			Me.radLblButtons.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblButtons.Size = New System.Drawing.Size(46, 14)
			Me.radLblButtons.TabIndex = 2
			Me.radLblButtons.Text = "Buttons:"
			' 
			' radLblType
			' 
			Me.radLblType.ForeColor = System.Drawing.Color.Black
			Me.radLblType.Location = New System.Drawing.Point(9, 141)
			Me.radLblType.Name = "radLblType"
			' 
			' 
			' 
			Me.radLblType.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblType.Size = New System.Drawing.Size(81, 14)
			Me.radLblType.TabIndex = 2
			Me.radLblType.Text = "Message Type:"
			' 
			' radLblText
			' 
			Me.radLblText.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Location = New System.Drawing.Point(9, 74)
			Me.radLblText.Name = "radLblText"
			' 
			' 
			' 
			Me.radLblText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Size = New System.Drawing.Size(78, 14)
			Me.radLblText.TabIndex = 2
			Me.radLblText.Text = "Message Text:"
			' 
			' radLblCaption
			' 
			Me.radLblCaption.ForeColor = System.Drawing.Color.Black
			Me.radLblCaption.Location = New System.Drawing.Point(9, 28)
			Me.radLblCaption.Name = "radLblCaption"
			' 
			' 
			' 
			Me.radLblCaption.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblCaption.Size = New System.Drawing.Size(95, 14)
			Me.radLblCaption.TabIndex = 0
			Me.radLblCaption.Text = "Message Caption:"
			' 
			' radTxtDialogResult
			' 
			Me.radTxtDialogResult.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radTxtDialogResult.ForeColor = System.Drawing.Color.Black
			Me.radTxtDialogResult.Location = New System.Drawing.Point(93, 233)
			Me.radTxtDialogResult.Name = "radTxtDialogResult"
			' 
			' 
			' 
			Me.radTxtDialogResult.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtDialogResult.Size = New System.Drawing.Size(78, 20)
			Me.radTxtDialogResult.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radBtnShow)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(20)
			Me.Size = New System.Drawing.Size(1141, 599)
			Me.Controls.SetChildIndex(Me.radBtnShow, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radTxtMessage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboMessageType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboThemes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radLblDialog, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblTheme, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtDialogResult, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTxtMessage As Telerik.WinControls.UI.RadTextBox
		Private radCheckRTL As Telerik.WinControls.UI.RadCheckBox
		Private radTxtCaption As Telerik.WinControls.UI.RadTextBox
		Private radBtnShow As Telerik.WinControls.UI.RadButton
		Private radComboMessageType As Telerik.WinControls.UI.RadDropDownList
		Private radComboButtons As Telerik.WinControls.UI.RadDropDownList
		Private radComboThemes As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem6 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem7 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem8 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem9 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem10 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem11 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem15 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem16 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem17 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem18 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem19 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem20 As Telerik.WinControls.UI.RadListDataItem
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblCaption As Telerik.WinControls.UI.RadLabel
		Private radLblText As Telerik.WinControls.UI.RadLabel
		Private radLblType As Telerik.WinControls.UI.RadLabel
		Private radLblButtons As Telerik.WinControls.UI.RadLabel
		Private radLblTheme As Telerik.WinControls.UI.RadLabel
		Private radLblDialog As Telerik.WinControls.UI.RadLabel
		Private radTxtDialogResult As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace
