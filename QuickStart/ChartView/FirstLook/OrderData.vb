Imports System
Imports System.Collections.Generic

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class OrderData
		Private _amount As Double
		Private _country As String
		Private _date As Date
		Private _productName As String
		Private _region As String
		Private _target As Double

		Public Property Amount() As Double
			Get
				Return _amount
			End Get
			Set(ByVal value As Double)
				_amount = value
			End Set
		End Property

		Public Property Country() As String
			Get
				Return _country
			End Get
			Set(ByVal value As String)
				_country = value
			End Set
		End Property

		Public Property [Date]() As Date
			Get
				Return _date
			End Get
			Set(ByVal value As Date)
				_date = value
			End Set
		End Property

		Public ReadOnly Property PercentTarget() As Double
			Get
				Return Me.Amount / Me.Target
			End Get
		End Property

		Public Property Product() As String
			Get
				Return _productName
			End Get
			Set(ByVal value As String)
				_productName = value
			End Set
		End Property

		Public Property Region() As String
			Get
				Return _region
			End Get
			Set(ByVal value As String)
				_region = value
			End Set
		End Property

		Public Property Target() As Double
			Get
				Return _target
			End Get
			Set(ByVal value As Double)
				_target = value
			End Set
		End Property
	End Class

	Public MustInherit Class OrderView
		Private _data As List(Of OrderData)

		Public Sub New()
			_data = New List(Of OrderData)()
		End Sub

		Public Overridable ReadOnly Property Value() As Double
			Get
'INSTANT VB NOTE: The local variable Value was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim Value_Renamed As Double = 0
				For Each order As OrderData In _data
					Value_Renamed += order.Amount
				Next order
				Return Value_Renamed
			End Get
		End Property

		Public ReadOnly Property Data() As List(Of OrderData)
			Get
				Return Me._data
			End Get
		End Property

	End Class

	Public Class OrderByMonth
		Inherits OrderView
		Private _month As String

		Public Sub New(ByVal month As String)
			MyBase.New()
			_month = month
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me._month
			End Get
		End Property
	End Class

	Public Class OrderByMonthTotalRange
		Inherits OrderByMonth
		Public Sub New(ByVal month As String)
			MyBase.New(month)
		End Sub

		Public Overrides ReadOnly Property Value() As Double
			Get
'INSTANT VB NOTE: The local variable value was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim value_Renamed As Double = 0
				For Each order As OrderData In Data
					value_Renamed += order.PercentTarget
				Next order
				Return value_Renamed
			End Get
		End Property
	End Class

	Public Class OrdersByRegion
		Inherits OrderView
		Private _name As String

		Public Sub New(ByVal name As String)
			MyBase.New()
			Me._name = name
		End Sub

		Public ReadOnly Property Name() As String
			Get
				Return Me._name
			End Get
		End Property
	End Class
End Namespace
