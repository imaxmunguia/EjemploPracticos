Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.Scatter
	Public Class RealEstateData
		Private type_Renamed As String
		Private sqFeet As Double
		Private price_Renamed As Double

		Public Sub New(ByVal type As String, ByVal squareFeet As Double, ByVal price As Double)
			Me.type_Renamed = type
			Me.sqFeet = squareFeet
			Me.price_Renamed = price
		End Sub

		Public ReadOnly Property Type() As String
			Get
				Return Me.type_Renamed
			End Get
		End Property

		Public ReadOnly Property SquareFeet() As Double
			Get
				Return Me.sqFeet
			End Get
		End Property

		Public ReadOnly Property Price() As Double
			Get
				Return price_Renamed
			End Get
		End Property

		Public ReadOnly Property PricePerSqFeet() As Double
			Get
				Return Me.Price / Me.SquareFeet
			End Get
		End Property
	End Class

End Namespace
