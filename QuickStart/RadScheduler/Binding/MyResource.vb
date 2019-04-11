Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.RadScheduler.Binding
	Public Class MyResource
		Implements INotifyPropertyChanged
		Private id_Renamed As Guid = Guid.NewGuid()
		Private name_Renamed As String = String.Empty

		Public Sub New(ByVal name As String)
			Me.name_Renamed = name
		End Sub

		Public ReadOnly Property Id() As Guid
			Get
				Return Me.id_Renamed
			End Get
		End Property

		Public Property Name() As String
			Get
				Return Me.name_Renamed
			End Get
			Set(ByVal value As String)
				If Me.name_Renamed <> value Then
					Me.name_Renamed = value
					Me.OnPropertyChanged("Name")
				End If
			End Set
		End Property

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			If Me.PropertyChangedEvent IsNot Nothing Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub

		#End Region
	End Class
End Namespace
