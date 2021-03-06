Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Properties

Namespace Telerik.Examples.WinControls.GridView.TabbedChildViews
	Public Class CustomDetailViewCellElement
		Inherits GridDetailViewCellElement
		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDetailViewCellElement)
			End Get
		End Property

		Protected Overrides Function CreatePageViewItem(ByVal pageViewProvider As IRadPageViewProvider, ByVal viewInfo As GridViewInfo) As RadPageViewItem
			Dim item As RadPageViewItem = MyBase.CreatePageViewItem(pageViewProvider, viewInfo)

			Dim explorerBarItem As RadPageViewExplorerBarItem = TryCast(item, RadPageViewExplorerBarItem)
			If explorerBarItem IsNot Nothing Then
				explorerBarItem.AssociatedContentAreaElement.Children(0).MaxSize = New System.Drawing.Size(0, 152)
			End If

			Return item
		End Function
	End Class
End Namespace
