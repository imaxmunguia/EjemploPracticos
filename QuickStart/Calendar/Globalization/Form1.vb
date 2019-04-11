Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports System.Collections
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Globalization
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.SelectedControl = Me.radCalendar1
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		#Region "Event Handlers"
		Private Sub radComboCultureList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboCultureList.SelectedIndexChanged
			Me.radCalendar1.Culture = TryCast(radComboCultureList.SelectedValue, CultureInfo)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim cultures As New SortedList()

			Dim temp As CultureInfo
			For i As Integer = 0 To CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length - 1
				temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)(i)
				cultures.Add(temp.EnglishName, temp)
			Next i

			Dim ie As IEnumerator = cultures.Keys.GetEnumerator()
			Do While ie.MoveNext()
				Dim name As String = CStr(ie.Current)
				Dim item As New RadListDataItem(name)
				item.Value = cultures(name)
				radComboCultureList.Items.Add(item)
			Loop
			radCalendar1.Culture = CultureInfo.CurrentCulture
            radComboCultureList.SelectedIndex = radComboCultureList.FindString(CultureInfo.CurrentCulture.EnglishName)
            radCalendar1.FocusedDate = DateTime.Now
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			TryCast(Me.radCalendar1.RootElement.Children(0), RadCalendarElement).CalendarNavigationElement.Text = Me.radTextBox1.Text
			Me.radCalendar1.Invalidate()
		End Sub
		#End Region
	End Class
End Namespace