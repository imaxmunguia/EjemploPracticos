Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
	Public Class ComboBoxMouseOverBehavior
		Inherits PropertyChangeBehavior
		Private popupShown As Boolean
		Private popup As ZoomPopup = Nothing
		Private item As RadListVisualItem = Nothing

		Public Sub New()
			MyBase.New(RadItem.IsMouseOverProperty)
		End Sub

		Private comboPopup As DropDownPopupForm = Nothing

		Public Overrides Sub OnPropertyChange(ByVal element As RadElement, ByVal e As RadPropertyChangedEventArgs)
			If CBool(e.NewValue) = True Then
				Me.item = TryCast(element, RadListVisualItem)

				If (Not Me.popupShown) Then
					comboPopup = TryCast(item.ElementTree.Control, DropDownPopupForm)
					If comboPopup Is Nothing Then
						Return
					End If

					AddHandler comboPopup.PopupClosing, AddressOf comboPopup_PopupClosing
					If comboPopup.IsDisplayed Then
						Me.popupShown = True
						Me.popup = New ZoomPopup(element, New SizeF(1.1f, 1.1f))
						Me.popup.BeginInit()
						Me.WireEvents()
						Me.popup.EndInit()
						Me.popup.Show()
					End If
				End If
			End If
		End Sub

		Private Sub comboPopup_PopupClosing(ByVal sender As Object, ByVal args As RadPopupClosingEventArgs)
			If Me.popupShown Then ' && args.CloseReason == RadPopupCloseReason.Keyboard)
				Me.popup.Hide()
				'selectedItem.OwnerElement.SelectedItem = selectedItem;
			End If

			Dim comboPopup As RadPopupControlBase = TryCast(sender, RadPopupControlBase)
			RemoveHandler comboPopup.PopupClosing, AddressOf comboPopup_PopupClosing
		End Sub

		Private Sub WireEvents()
			Me.popup.Closed = AddressOf ClosePopup
		End Sub

		Private Sub UnWireEvents()
			Me.popup.Closed = Nothing
		End Sub

		Private Sub popup_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.comboPopup Is Nothing Then
				Return
			End If

			Dim dataItem As RadListDataItem = Me.item.Data
			Me.popup.Hide()
			Me.comboPopup.ClosePopup(RadPopupCloseReason.CloseCalled)
			Me.comboPopup.OwnerDropDownListElement.SelectedItem = dataItem

		End Sub

		Private Sub ClosePopup(ByVal sender As Object, ByVal ea As EventArgs)
			Me.popupShown = False
			Me.UnWireEvents()
			Me.item = Nothing
			Me.popup = Nothing
		End Sub
	End Class
End Namespace
