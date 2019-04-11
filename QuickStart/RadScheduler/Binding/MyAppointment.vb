Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.RadScheduler.Binding
	Public Class MyAppointment
		Implements INotifyPropertyChanged
		Private start_Renamed As DateTime = DateTime.Now
		Private end_Renamed As DateTime = DateTime.Now
		Private subject_Renamed As String = String.Empty
		Private description_Renamed As String = String.Empty
		Private location_Renamed As String = String.Empty
		Private visible_Renamed As Boolean = True
		Private email_Renamed As String = String.Empty
		Private id_Renamed As Guid = Guid.NewGuid()
		Private resources_Renamed As List(Of MyResource) = Nothing
		Private exceptions_Renamed As List(Of MyAppointment) = Nothing
		Private recurrenceRule_Renamed As String = Nothing
		Private masterAppointment_Renamed As MyAppointment = Nothing

		Public Sub New()
		End Sub

		Public Sub New(ByVal start As DateTime, ByVal [end] As DateTime, ByVal subject As String, ByVal description As String, ByVal location As String)
			Me.start_Renamed = start
			Me.end_Renamed = [end]
			Me.subject_Renamed = subject
			Me.description_Renamed = description
			Me.location_Renamed = location
		End Sub

		Public ReadOnly Property Id() As Guid
			Get
				Return Me.id_Renamed
			End Get
		End Property

		Public Property Start() As DateTime
			Get
				Return Me.start_Renamed
			End Get
			Set(ByVal value As DateTime)
				If Me.start_Renamed <> value Then
					Me.start_Renamed = value
					Me.OnPropertyChanged("Start")
				End If
			End Set
		End Property

		Public Property [End]() As DateTime
			Get
				Return Me.end_Renamed
			End Get
			Set(ByVal value As DateTime)
				If Me.end_Renamed <> value Then
					Me.end_Renamed = value
					Me.OnPropertyChanged("End")
				End If
			End Set
		End Property

		Public Property Subject() As String
			Get
				Return Me.subject_Renamed
			End Get
			Set(ByVal value As String)
				If Me.subject_Renamed <> value Then
					Me.subject_Renamed = value
					Me.OnPropertyChanged("Subject")
				End If
			End Set
		End Property

		Public Property Description() As String
			Get
				Return Me.description_Renamed
			End Get
			Set(ByVal value As String)
				If Me.description_Renamed <> value Then
					Me.description_Renamed = value
					Me.OnPropertyChanged("Description")
				End If
			End Set
		End Property

		Public Property Location() As String
			Get
				Return Me.location_Renamed
			End Get
			Set(ByVal value As String)
				If Me.location_Renamed <> value Then
					Me.location_Renamed = value
					Me.OnPropertyChanged("Location")
				End If
			End Set
		End Property

		Public Property Visible() As Boolean
			Get
				Return Me.visible_Renamed
			End Get
			Set(ByVal value As Boolean)
				If Me.visible_Renamed <> value Then
					Me.visible_Renamed = value
					Me.OnPropertyChanged("Visible")
				End If
			End Set
		End Property

		Public Property RecurrenceRule() As String
			Get
				Return Me.recurrenceRule_Renamed
			End Get
			Set(ByVal value As String)
				If Me.recurrenceRule_Renamed IsNot value Then
					Me.recurrenceRule_Renamed = value
					Me.OnPropertyChanged("RecurrenceRule")
				End If
			End Set
		End Property

		Public Property Email() As String
			Get
				Return Me.email_Renamed
			End Get
			Set(ByVal value As String)
				If Me.email_Renamed <> value Then
					Me.email_Renamed = value
					Me.OnPropertyChanged("Email")
				End If
			End Set
		End Property

		Public ReadOnly Property Resources() As List(Of MyResource)
			Get
				If Me.resources_Renamed Is Nothing Then
					Me.resources_Renamed = New List(Of MyResource)()
				End If

				Return Me.resources_Renamed
			End Get
		End Property

		Public ReadOnly Property Exceptions() As List(Of MyAppointment)
			Get
				If Me.exceptions_Renamed Is Nothing Then
					Me.exceptions_Renamed = New List(Of MyAppointment)()
				End If
				Return Me.exceptions_Renamed
			End Get
		End Property

		Public Property MasterAppointment() As MyAppointment
			Get
				Return Me.masterAppointment_Renamed
			End Get
			Set(ByVal value As MyAppointment)
				If Me.masterAppointment_Renamed IsNot value Then
					Me.masterAppointment_Renamed = value
					Me.OnPropertyChanged("MasterAppointment")
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
