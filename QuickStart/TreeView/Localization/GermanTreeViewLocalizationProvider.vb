Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Localization
	Public Class GermanTreeViewLocalizationProvider
		Inherits TreeViewLocalizationProvider
		Public Overrides Function GetLocalizedString(ByVal id As String) As String
			Select Case id
				Case TreeViewStringId.ContextMenuCollapse
					Return "Zusammenklappen"
				Case TreeViewStringId.ContextMenuDelete
					Return "Löschen"
				Case TreeViewStringId.ContextMenuEdit
					Return "Edieren"
				Case TreeViewStringId.ContextMenuExpand
					Return "Expandieren"
				Case TreeViewStringId.ContextMenuNew
					Return "Neu"
			End Select

			Return ""
		End Function
	End Class
End Namespace