Imports Microsoft.VisualBasic
Imports Telerik.QuickStart.WinControls
Imports System
Imports Telerik.WinControls.UI
Imports System.Drawing

Namespace Telerik.Examples.WinControls.PropertyGrid.Events
	Public Partial Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)

			If Not Me.radPropertyGrid1 Is Nothing Then
				Me.radPropertyGrid1.Location = New Point((Me.ClientSize.Width - radPropertyGrid1.Size.Width) / 2, Me.radPropertyGrid1.Location.Y)
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radPropertyGrid1.SelectedObject = New PropertyGridElement()
		End Sub

		Private Sub ShowEventMessage(ByVal eventName As String)
			Me.radTextBoxEvents.Text += String.Format("{0} fired" & Environment.NewLine, eventName)
			Me.radTextBoxEvents.SelectionStart = Me.radTextBoxEvents.Text.Length
			Me.radTextBoxEvents.ScrollToCaret()
		End Sub

		Private Sub radPropertyGrid1_ContextMenuOpening(ByVal sender As Object, ByVal e As PropertyGridContextMenuOpeningEventArgs) Handles radPropertyGrid1.ContextMenuOpening
			Me.ShowEventMessage("ContextMenuOpening")
		End Sub

		Private Sub radPropertyGrid1_Edited(ByVal sender As Object, ByVal e As PropertyGridItemEditedEventArgs) Handles radPropertyGrid1.Edited
			Me.ShowEventMessage("Edited")
		End Sub

		Private Sub radPropertyGrid1_Editing(ByVal sender As Object, ByVal e As PropertyGridItemEditingEventArgs) Handles radPropertyGrid1.Editing
			Me.ShowEventMessage("Editing")
		End Sub

		Private Sub radPropertyGrid1_EditorInitialized(ByVal sender As Object, ByVal e As PropertyGridItemEditorInitializedEventArgs) Handles radPropertyGrid1.EditorInitialized
			Me.ShowEventMessage("EditorInitialized")
		End Sub

		Private Sub radPropertyGrid1_EditorRequired(ByVal sender As Object, ByVal e As PropertyGridEditorRequiredEventArgs) Handles radPropertyGrid1.EditorRequired
			Me.ShowEventMessage("EditorRequired")
		End Sub

		Private Sub radPropertyGrid1_ItemExpandedChanged(ByVal sender As Object, ByVal e As RadPropertyGridEventArgs) Handles radPropertyGrid1.ItemExpandedChanged
			Me.ShowEventMessage("ItemExpandedChanged")
		End Sub

		Private Sub radPropertyGrid1_ItemExpandedChanging(ByVal sender As Object, ByVal e As RadPropertyGridCancelEventArgs) Handles radPropertyGrid1.ItemExpandedChanging
			Me.ShowEventMessage("ItemExpandedChanging")
		End Sub

		Private Sub radPropertyGrid1_ItemMouseDoubleClick(ByVal sender As Object, ByVal e As RadPropertyGridEventArgs) Handles radPropertyGrid1.ItemMouseDoubleClick
			Me.ShowEventMessage("ItemMouseDoubleClick")
		End Sub

		Private Sub radPropertyGrid1_PropertyValidated(ByVal sender As Object, ByVal e As PropertyValidatedEventArgs) Handles radPropertyGrid1.PropertyValidated
			Me.ShowEventMessage("PropertyValidated")
		End Sub

		Private Sub radPropertyGrid1_PropertyValidating(ByVal sender As Object, ByVal e As PropertyValidatingEventArgs) Handles radPropertyGrid1.PropertyValidating
			Me.ShowEventMessage("PropertyValidating")
		End Sub

		Private Sub radPropertyGrid1_PropertyValueChanged(ByVal sender As Object, ByVal e As PropertyGridItemValueChangedEventArgs) Handles radPropertyGrid1.PropertyValueChanged
			Me.ShowEventMessage("PropertyValueChanged")
		End Sub

		Private Sub radPropertyGrid1_PropertyValueChanging(ByVal sender As Object, ByVal e As PropertyGridItemValueChangingEventArgs) Handles radPropertyGrid1.PropertyValueChanging
			Me.ShowEventMessage("PropertyValueChanging")
		End Sub

		Private Sub radPropertyGrid1_SelectedGridItemChanged(ByVal sender As Object, ByVal e As RadPropertyGridEventArgs) Handles radPropertyGrid1.SelectedGridItemChanged
			Me.ShowEventMessage("SelectedGridItemChanged")
		End Sub

		Private Sub radPropertyGrid1_SelectedGridItemChanging(ByVal sender As Object, ByVal e As RadPropertyGridCancelEventArgs) Handles radPropertyGrid1.SelectedGridItemChanging
			Me.ShowEventMessage("SelectedGridItemChanging")
		End Sub
	End Class
End Namespace
