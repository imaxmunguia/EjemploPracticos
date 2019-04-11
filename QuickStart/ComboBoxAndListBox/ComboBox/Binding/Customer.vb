Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Binding.General
	Public Class Customer
		Public Sub New()
			Me.id_Renamed = -1
			Me.name_Renamed = String.Empty
		End Sub
		Public Sub New(ByVal id As Integer, ByVal name As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
		End Sub
		'Fields
		Private id_Renamed As Integer
		Private name_Renamed As String
		'Properties
		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
	End Class
End Namespace
