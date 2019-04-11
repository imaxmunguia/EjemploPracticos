Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational

	Public Class DataContext
		Private Shared m_artists As List(Of Artist) = Nothing
		Private Shared m_topArtists As List(Of Artist) = Nothing


		Public Sub New()
		End Sub

		Public Shared ReadOnly Property Artists() As List(Of Artist)
			Get
				If m_artists Is Nothing Then
					Dim stream As MemoryStream = New MemoryStream(My.Resources.ChinookModel)

					Dim formatter As New BinaryFormatter()
					m_artists = DirectCast(formatter.Deserialize(stream), List(Of Artist))
					stream.Dispose()
				End If

				Return m_artists
			End Get
		End Property

		Public Shared ReadOnly Property TopArtists() As List(Of Artist)
			Get
				If m_topArtists Is Nothing Then
					Using stream As New MemoryStream(My.Resources.ChinookModel)
						Dim formatter As New BinaryFormatter()
						'formatter.Binder = new MySerializationBinder
						Dim parsedObject As Object = formatter.Deserialize(stream)
						m_topArtists = DirectCast(parsedObject, List(Of Artist))

						While m_topArtists.Count > 50
							m_topArtists.RemoveAt(m_topArtists.Count - 1)
						End While
					End Using
				End If

				Return m_topArtists
			End Get
		End Property
	End Class
End Namespace
