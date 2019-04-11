Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.DocumentManager
	Partial Public Class Form1
		Inherits ExamplesForm
		Private docCounter As Integer = 11
		Public Sub New()
			InitializeComponent()

			Me.radDock1.ShowDocumentCloseButton = True
			Me.radDock1.DocumentManager.DocumentCloseActivation = DocumentCloseActivation.FirstInZOrder
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Me.radDock1.DocumentManager.ActivateNextDocument()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Me.radDock1.DocumentManager.ActivatePreviousDocument()
		End Sub

		Private Sub sortNone_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles sortNone.ToggleStateChanged
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.None
		End Sub

		Private Sub sortByName_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles sortByText.ToggleStateChanged
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ByText
		End Sub

		Private Sub sortByActivation_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles sortByActivation.ToggleStateChanged
			Me.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ZOrdered
		End Sub

		Private Sub addDoc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addDoc.Click
			Dim docWindow As New DocumentWindow("documentWindow" & docCounter)
			docCounter += 1
			Me.radDock1.AddDocument(docWindow)
		End Sub
	End Class
End Namespace
