Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.RadScheduler.CustomAppointmentDialog
	Partial Public Class Form1
		Inherits ExamplesForm
		Private appointmentDialog As CustomEditAppointmentDialog = Nothing

		Public Sub New()
			InitializeComponent()

			Me.radSchedulerDemo.AppointmentFactory = New CustomAppointmentFactory()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub radSchedulerDemo_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs) Handles radSchedulerDemo.AppointmentEditDialogShowing
			If Me.appointmentDialog Is Nothing Then
				Me.appointmentDialog = New CustomEditAppointmentDialog()
			End If
			Me.appointmentDialog.ThemeName = Me.radSchedulerDemo.ThemeName
			e.AppointmentEditDialog = Me.appointmentDialog
		End Sub
	End Class
End Namespace
