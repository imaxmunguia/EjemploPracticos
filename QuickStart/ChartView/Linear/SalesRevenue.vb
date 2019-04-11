Imports System

Namespace Telerik.Examples.WinControls.ChartView.Linear
	Public Class SalesRevenue
		Private month_Renamed As String
		Private revenue_Renamed As Double

		Public Sub New(ByVal month As String, ByVal revenue As Double)
			Me.month_Renamed = month
			Me.revenue_Renamed = revenue
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property

		Public ReadOnly Property Revenue() As Double
			Get
				Return Me.revenue_Renamed
			End Get
		End Property
	End Class
End Namespace
