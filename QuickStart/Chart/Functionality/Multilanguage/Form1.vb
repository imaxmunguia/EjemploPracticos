Imports Microsoft.VisualBasic
Imports System
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.Functionality.Multilanguage
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radComboBox1.Text = "Select language"
			radComboBox1.SelectedIndex = 0
			Me.Refresh()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox1.SelectedIndexChanged
			Dim fileName As String = String.Empty
			Select Case radComboBox1.SelectedIndex
				'english
				Case 0
					fileName = "..\Chart\Functionality\Multilanguage\EN.xml"
				'german
				Case 1
					fileName = "..\Chart\Functionality\Multilanguage\DE.xml"
				'spanish
				Case 2
					fileName = "..\Chart\Functionality\Multilanguage\ES.xml"
				'french
				Case 3
					fileName = "..\Chart\Functionality\Multilanguage\FR.xml"
			End Select
			If System.IO.File.Exists(fileName) Then
				SetExplode(radComboBox1.SelectedIndex)
				Me.Refresh()
			End If
		End Sub
		Private Sub SetExplode(ByVal itemIndex As Integer)
			Dim s As ChartSeries = radChart1.Series(0)
			Dim index As Integer = 0
			For Each seriesItem As ChartSeriesItem In s.Items
				seriesItem.Appearance.Exploded = index = itemIndex
				index += 1
			Next seriesItem
		End Sub

	End Class
End Namespace