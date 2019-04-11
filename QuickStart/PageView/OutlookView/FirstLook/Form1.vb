Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView.OutlookView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)
			Me.radPageViewPage1.Image = My.Resources.OutlookViewNotes
			Me.radPageViewPage2.Image = My.Resources.OutlookViewTasks
			Me.radPageViewPage3.Image = My.Resources.OutlookViewContacts
			Me.radPageViewPage4.Image = My.Resources.OutlookViewCalendar
			Me.radPageViewPage6.Image = My.Resources.OutlookViewMail
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
