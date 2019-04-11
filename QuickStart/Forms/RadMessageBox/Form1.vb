Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Forms.RadMessageBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			AddHandler Load, AddressOf Form1_Load
			AddHandler radBtnShow.Click, AddressOf radButton1_Click
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboButtons.SelectedIndex = 0
			Me.radComboMessageType.SelectedIndex = 0
			Me.radComboThemes.SelectedIndex = 0

            Dim TempOffice2007SilverTheme As Office2010SilverTheme = New Office2010SilverTheme()
            Dim TempOffice2007BlackTheme As Office2010BlackTheme = New Office2010BlackTheme()
            Dim TempOffice2007BlueTheme As Office2010BlueTheme = New Office2010BlueTheme()
            Dim TempDesertTheme As DesertTheme = New DesertTheme()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim buttons As MessageBoxButtons = Me.RetrieveButtonsFromCombo()
			Dim icon As RadMessageIcon = Me.RetrieveIconFromCombo()
			Dim rtl As RightToLeft = RightToLeft.No

			If Me.radCheckRTL.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				rtl = RightToLeft.Yes
			End If

			Dim ds As DialogResult

			Dim themeName As String = Me.radComboThemes.SelectedItem.Text
			Telerik.WinControls.RadMessageBox.SetThemeName(themeName)
            Telerik.WinControls.RadMessageBox.Instance.MinimumSize = New System.Drawing.Size(100, 100)
			ds = Telerik.WinControls.RadMessageBox.Show(Me, Me.radTxtMessage.Text, Me.radTxtCaption.Text, buttons, icon, MessageBoxDefaultButton.Button1, rtl)

			Me.radTxtDialogResult.Text = String.Format("{0}", ds)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim buttons As MessageBoxButtons = Me.RetrieveButtonsFromCombo()
			Dim icon As MessageBoxIcon = MessageBoxIcon.None

			Select Case Me.radComboMessageType.SelectedIndex
				Case 1
					icon = MessageBoxIcon.Information
				Case 2
					icon = MessageBoxIcon.Question
				Case 3
					icon = MessageBoxIcon.Exclamation
				Case 4
					icon = MessageBoxIcon.Error
			End Select

			Dim ds As DialogResult

			If Me.radCheckRTL.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				ds = MessageBox.Show(Me, Me.radTxtMessage.Text, Me.radTxtCaption.Text, buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
			Else
				ds = MessageBox.Show(Me, Me.radTxtMessage.Text, Me.radTxtCaption.Text, buttons, icon)
			End If

			Me.radTxtDialogResult.Text = String.Format("{0}", ds)
		End Sub

		Private Function RetrieveButtonsFromCombo() As MessageBoxButtons
			Select Case Me.radComboButtons.SelectedIndex
				Case 1
					Return MessageBoxButtons.OKCancel
				Case 2
					Return MessageBoxButtons.YesNo
				Case 3
					Return MessageBoxButtons.YesNoCancel
				Case 4
					Return MessageBoxButtons.RetryCancel
				Case 5
					Return MessageBoxButtons.AbortRetryIgnore
			End Select

			Return MessageBoxButtons.OK
		End Function

		Private Function RetrieveIconFromCombo() As RadMessageIcon
			Select Case Me.radComboMessageType.SelectedIndex
				Case 1
					Return RadMessageIcon.Info
				Case 2
					Return RadMessageIcon.Question
				Case 3
					Return RadMessageIcon.Exclamation
				Case 4
					Return RadMessageIcon.Error
			End Select
			Return RadMessageIcon.None
		End Function
	End Class
End Namespace
