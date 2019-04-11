Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.DrillDown
	Public Class DrillDownDataInfo
		Implements INotifyPropertyChanged
		Private m_value As Double
		Private m_date As DateTime

		Public Sub New([date] As DateTime, value As Double)
			Me.m_date = [date]
			Me.m_value = value
		End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property Value() As Double
            Get
				Return Me.m_value
			End Get
			Set
                Me.m_value = Value
				Me.OnPropertyChanged("Value")
			End Set
		End Property

		Public Property [Date]() As DateTime
			Get
				Return Me.m_date
			End Get
			Set
                Me.m_date = Value
				Me.OnPropertyChanged("Date")
			End Set
		End Property



		Public Sub OnPropertyChanged(propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace


