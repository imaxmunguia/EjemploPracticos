Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports System.Collections
Imports System.Globalization
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.Globalization
	''' <summary>
	''' Represents a globalization example of mask box
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()

			AddHandler Load, AddressOf Form1_Load

			Me.SelectedControl = Me.radMaskedEditDateTime
			Me.SetTheme()
		End Sub

		Private Sub SetTheme()
			Me.radLblCulture.ThemeName = THEME
			Me.radLblFullDateTime.ThemeName = THEME
			Me.radMaskedEditDateTime.ThemeName = THEME
			Me.radComboCultures.ThemeName = THEME

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim cultures As New SortedList()

			Dim temp As CultureInfo
			For i As Integer = 0 To CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length - 1
				temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)(i)
				cultures.Add(temp.EnglishName, temp)
			Next i

			Dim ie As IEnumerator = cultures.Keys.GetEnumerator()
			Do While ie.MoveNext()
				Dim name As String = CStr(ie.Current)
				Me.radComboCultures.Items.Add(New RadListDataItem(name, cultures(name)))
			Loop

			radComboCultures.SelectedItem = radComboCultures.Items(radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName))
			AddHandler radComboCultures.SelectedIndexChanged, AddressOf CulturesList_SelectedIndexChanged
		End Sub

		Private Sub CulturesList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radMaskedEditDateTime.Culture = (TryCast(radComboCultures.SelectedValue, CultureInfo))
		End Sub
	End Class
End Namespace