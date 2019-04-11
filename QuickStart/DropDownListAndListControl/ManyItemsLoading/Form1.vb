Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System.Diagnostics

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ManyItemsLoading
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const itemsCount As Integer = 150000
		Private items() As String


		Public Sub New()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme Or QSFButtons.TransparentBackground, False)
			InitializeComponent()
			Me.CreateBindingList(100)
			Me.radListControl1.DataSource = items
			Me.radDropDownList1.DataSource = items
			Me.radSpinEditor1.Value = itemsCount
			Me.radLabelElapsed.Text = "Press Bind Button to measure binding time with " & Me.radSpinEditor1.Value & " items."
		End Sub

		Private Sub CreateBindingList(ByVal count As Integer)
			items = New String(count - 1){}
			For i As Integer = 0 To count - 1
				items(i) = "Item " & i
			Next i
		End Sub

		Private Sub button_Bind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_Bind.Click
			Dim stopWatch As New Stopwatch()
			stopWatch.Start()
			Me.CreateBindingList(CInt(Fix(Me.radSpinEditor1.Value)))
			stopWatch.Stop()
			Me.radLabelElapsed.Text = "Time needed to create the BindingList: " & stopWatch.ElapsedMilliseconds & " ms"
			stopWatch.Reset()
			stopWatch.Start()
			Me.radListControl1.DataSource = items
			stopWatch.Stop()
			Me.radLabelElapsedListControl.Text = "Time needed to databind RadListControl: " & stopWatch.ElapsedMilliseconds & " ms"
			stopWatch.Reset()
			stopWatch.Start()
			Me.radDropDownList1.DataSource = items
			Me.radDropDownList1.ShowDropDown()
			stopWatch.Stop()
			Me.radLabelElapsedDropDownList.Text = "Time neededto databind RadDropDownList: " & stopWatch.ElapsedMilliseconds & " ms"

			Me.button_Bind.Text = "Bind Again"
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpinEditor1.ValueChanged
			Me.radLabelElapsed.Text = "Press the Bind button to measure the binding time with " & Me.radSpinEditor1.Value & " items."
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
