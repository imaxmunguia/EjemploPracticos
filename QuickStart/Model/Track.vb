Imports System

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	<Serializable()> _
	Public Class Track
		Private id As Integer
		Private name As String
		Private mediaType As String
		Private genre As String
		Private size As String


		Public Sub New()
		End Sub

		Public Sub New(id As Integer, name As String, mediaType As String, genre As String, size As String)
			Me.id = id
			Me.name = name
			Me.mediaType = mediaType
			Me.genre = genre
			Me.size = size
		End Sub

		Public Property Id1() As Integer
			Get
				Return id
			End Get
			Set(value As Integer)
				id = Value
			End Set
		End Property

		Public Property Name1() As String
			Get
				Return name
			End Get
			Set(value As String)
				name = Value
			End Set
		End Property

		Public Property MediaType1() As String
			Get
				Return mediaType
			End Get
			Set(value As String)
				mediaType = Value
			End Set
		End Property

		Public Property Genre1() As String
			Get
				Return genre
			End Get
			Set(value As String)
				genre = Value
			End Set
		End Property

		Public Property Size1() As String
			Get
				Return size
			End Get
			Set(value As String)
				size = Value
			End Set
		End Property
	End Class
End Namespace
