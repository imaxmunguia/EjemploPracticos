Imports System.Collections.Generic
Imports System

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	<Serializable()> _
	Public Class Album
		Private id As Integer
		Private artistId As Integer
		Private title As String
		Private tracks As New List(Of Track)()


		Public Sub New()
		End Sub

		Public Sub New(id As Integer, artistId As Integer, title As String)
			Me.id = id
			Me.artistId = artistId
			Me.title = title
		End Sub

		Public Property Id1() As Integer
			Get
				Return id
			End Get
			Set(value As Integer)
				id = Value
			End Set
		End Property

		Public Property ArtistId1() As Integer
			Get
				Return artistId
			End Get
			Set(value As Integer)
				artistId = Value
			End Set
		End Property

		Public Property Title1() As String
			Get
				Return title
			End Get
			Set(value As String)
				title = Value
			End Set
		End Property

		Public ReadOnly Property Tracks1() As List(Of Track)
			Get
				Return Me.tracks
			End Get
		End Property
	End Class
End Namespace
