Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadScheduler.CustomAppointmentDialog
	Public Class CustomAppointmentFactory
		Implements IAppointmentFactory
		#Region "IAppointmentFactory Members"

		Public Function CreateNewAppointment() As IEvent Implements IAppointmentFactory.CreateNewAppointment
			Return New OutlookLikeAppointment()
		End Function

		#End Region
	End Class
End Namespace
