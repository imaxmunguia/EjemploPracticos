Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.CreateRowInfo
	Public Class ExpandableGridViewFilteringRowInfo
		Inherits GridViewFilteringRowInfo
		#Region "Fields"

		Private childRows_Renamed As GridViewChildRowCollection

		#End Region

		#Region "Initialization"

		Public Sub New(ByVal view As GridViewInfo)
			MyBase.New(view)
			Me.SuspendPropertyNotifications()
			Me.IsExpanded = True
			Me.ResumePropertyNotifications()

			Me.childRows_Renamed = New GridViewChildRowCollection()
			Dim list As List(Of GridViewRowInfo) = New List(Of GridViewRowInfo)()
			list.Add(New GridViewFilteringChildRowInfo(view))
			Me.childRows_Renamed.Load(list)
		End Sub

		#End Region

		#Region "Properties"

		Public Overrides ReadOnly Property HasChildViews() As Boolean
			Get
				Return Me.IsExpanded
			End Get
		End Property

		Public Overrides ReadOnly Property ChildRows() As GridViewChildRowCollection
			Get
				Return Me.childRows_Renamed
			End Get
		End Property

		#End Region
	End Class
End Namespace
