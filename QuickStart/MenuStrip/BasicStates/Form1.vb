Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.BasicStates
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)

		End Sub

		Private Sub disableItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem12.Click, radMenuItem13.Click, radMenuItem14.Click, radMenuItem15.Click
			Dim item As RadMenuItem = CType(sender, RadMenuItem)
			item.Enabled = False
		End Sub

		Private Sub removeItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem8.Click, radMenuItem9.Click, radMenuItem10.Click, radMenuItem11.Click
			Dim item As IHierarchicalItem = CType(sender, IHierarchicalItem)
			Dim parentItem As RadMenuItem = CType(item.ParentItem, RadMenuItem)
			parentItem.Items.Remove(CType(sender, RadMenuItem))
		End Sub

		Private Sub addItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem4.Click, radMenuItem5.Click, radMenuItem6.Click, radMenuItem7.Click
			Dim item As New RadMenuItem()
			item.Text = "New " & (TryCast(sender, RadMenuItem)).Text

			Dim hItem As IHierarchicalItem = CType(sender, IHierarchicalItem)
			Dim parentItem As RadMenuItemBase = CType(hItem.ParentItem, RadMenuItemBase)
			parentItem.Items.Add(item)
		End Sub
	End Class
End Namespace