Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.GridView.ErrorInfo
	Friend Class EmployeePositions
		Private display_Renamed As String
		Private position_Renamed As EmployeePosition

		Public Sub New()
		End Sub

		Public Sub New(ByVal display As String, ByVal position As EmployeePosition)
			Me.display_Renamed = display
			Me.position_Renamed = position
		End Sub

		Public Property Display() As String
			Get
				Return display_Renamed
			End Get
			Set(ByVal value As String)
				display_Renamed = value
			End Set
		End Property

		Public Property Position() As EmployeePosition
			Get
				Return position_Renamed
			End Get
			Set(ByVal value As EmployeePosition)
				position_Renamed = value
			End Set
		End Property
	End Class
End Namespace
