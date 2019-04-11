Imports System

Namespace Telerik.Examples.WinControls.ChartView.Themes
	Public Class LineAreaSeriesData
		Private month_Renamed As String
		Private profit_Renamed As Double

		Public Sub New(ByVal profit As Double, ByVal month As String)
			Me.profit_Renamed = profit
			Me.month_Renamed = month
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property

		Public ReadOnly Property Profit() As Double
			Get
				Return Me.profit_Renamed
			End Get
		End Property
	End Class
End Namespace
