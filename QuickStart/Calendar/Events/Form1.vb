Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Events
	Partial Public Class Form1
		Inherits ExamplesForm
		Private insertIndex As Integer = 0
		Private oldSelections As DateTimeCollection

		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.SelectedControl = Me.radCalendar1
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		#Region "Helper Methods"

		Private Sub AddEventRoot(ByVal text As String)
			Dim item As New RadListDataItem()
			item.Text = text
			Me.AddEventRoot(item)
		End Sub

		Private Sub AddEventRoot(ByVal item As RadListDataItem)
			insertIndex = 0
			item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			radListBoxEvents.Items.Insert(insertIndex, item)
			insertIndex += 1
		End Sub

		Private Sub AddTextToListBox(ByVal item As RadListDataItem)
			If radListBoxEvents.Items.Count > 100 Then
				radListBoxEvents.Items.Clear()
				insertIndex = 0
			End If
			radListBoxEvents.Items.Insert(insertIndex, item)
			insertIndex += 1
		End Sub

		Private Sub AddTextToListBox(ByVal text As String)
			Dim label As New RadListDataItem()
			label.Text = text
			AddTextToListBox(label)
		End Sub

		#End Region

		#Region "Event Handlers"
		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonClear.Click
			radListBoxEvents.Items.Clear()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.radCalendar1.FocusedDate = DateTime.Now
            AddHandler radCalendar1.SelectionChanging, AddressOf radCalendar1_SelectionChanging
			AddHandler radCalendar1.SelectionChanged, AddressOf radCalendar1_SelectionChanged
			AddHandler radCalendar1.ViewChanging, AddressOf radCalendar1_ViewChanging
			AddHandler radCalendar1.ViewChanged, AddressOf radCalendar1_ViewChanged
		End Sub

		Private Sub radCalendar1_ViewChanged(ByVal sender As Object, ByVal e As EventArgs)
			AddEventRoot("ViewChanged")
			AddTextToListBox(String.Format("    Changed to range: {0} - {1}", Me.radCalendar1.DefaultView.ViewStartDate.ToShortDateString(), Me.radCalendar1.DefaultView.ViewEndDate.ToShortDateString()))
		End Sub

		Private Sub radCalendar1_ViewChanging(ByVal sender As Object, ByVal e As ViewChangingEventArgs)
			AddEventRoot("ViewChanging")
			AddTextToListBox(String.Format("    Changing to {0} - {1}", e.View.ViewStartDate.ToShortDateString(), e.View.ViewEndDate.ToShortDateString()))
		End Sub

		Private Sub radCalendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			AddEventRoot("SelectionChanged")
			AddTextToListBox("    The following dates have been added to" & Constants.vbLf & "    SelectedDates collection in RadCalendar:")
			For i As Integer = 0 To Me.radCalendar1.SelectedDates.Count - 1
				If (Not oldSelections.Contains(Me.radCalendar1.SelectedDates(i))) Then
					AddTextToListBox("    " & Me.radCalendar1.SelectedDates(i))
				End If
			Next i
			If oldSelections IsNot Nothing Then
				' Remove if to reproduce exception. Click erratically on the Calendar and oldSelections becomes null.
				' SelectionChanged fires before SelectionChanging?
				oldSelections.BeginUpdate()
				oldSelections.Clear()
				oldSelections.EndUpdate()
			End If
			oldSelections = Nothing
		End Sub

		Private Sub radCalendar1_SelectionChanging(ByVal sender As Object, ByVal e As SelectionEventArgs)
			AddEventRoot("SelectionChanging")
			AddTextToListBox("     new dates are added to SelectedDates" & Constants.vbLf & "     collection in RadCalendar.")
			oldSelections = Me.radCalendar1.SelectedDates.Clone()
		End Sub
		#End Region
	End Class
End Namespace