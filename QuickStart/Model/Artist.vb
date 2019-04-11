Imports System.Collections.Generic
Imports System

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	<Serializable()> _
	Public Class Artist
		Private id As Integer
		Private name As String
		Private albums As New List(Of Album)()


		Public Sub New()
		End Sub

		Public Sub New(id As Integer, name As String)
			Me.id = id
			Me.name = name
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

		Public readonly Property Albums1() As List(Of Album)
			Get
				Return albums
			End Get			
		End Property
	End Class
End Namespace
