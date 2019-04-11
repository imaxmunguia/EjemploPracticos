Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Charting
'using Telerik.WinControls.RadControlSpy;
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls
Imports Telerik.Charting.Styles

Namespace Telerik.Examples.WinControls.Chart.FirstLook
	''' <summary>
	''' Example: First Look
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private rand As System.Random = New Random(DateTime.Now.Millisecond)
		Public Sub New()
			InitializeComponent()

			radChart1.ChartTitle.TextBlock.Text = "Units Sold (Thousands)"

			'traverse all the buttons in the form setting their mouse events
			For Each ctrl As Control In panel.Controls
				Dim btn As RadButton = TryCast(ctrl, RadButton)
				If btn Is Nothing Then
					Continue For
				End If

				AddHandler btn.MouseEnter, AddressOf radButton1_MouseEnter
				AddHandler btn.MouseLeave, AddressOf radButton1_MouseLeave
			Next ctrl

			'setup chart as a piechart by default
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Pie))
			radChart1.Update()

			radChart1.Skin = "Vista"

			radChart1.BorderStyle = BorderStyle.None

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Private Sub radButton1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			'setup style in case mouse leaves
			Dim btn As RadButton = (CType(sender, RadButton))
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(btn.RootElement.Children(0).Children(2), BorderPrimitive).Visibility = ElementVisibility.Hidden
			CType(btn.RootElement.Children(0).Children(1).Children(1), TextPrimitive).ForeColor = Color.FromArgb(75, 83, 62)
		End Sub

		Private Sub radButton1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			'setup style in case mouse enters
			Dim btn As RadButton = (CType(sender, RadButton))
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).GradientStyle = GradientStyles.Linear
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).NumberOfColors = 4
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).BackColor = Color.FromArgb(255, 255, 254)
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).BackColor2 = Color.FromArgb(253, 253, 250)
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).BackColor3 = Color.FromArgb(237, 245, 225)
			CType(btn.RootElement.Children(0).Children(0), FillPrimitive).BackColor4 = Color.FromArgb(252, 253, 250)
			CType(btn.RootElement.Children(0).Children(2), BorderPrimitive).ForeColor = Color.FromArgb(193, 206, 171)
			CType(btn.RootElement.Children(0).Children(2), BorderPrimitive).Visibility = ElementVisibility.Visible
			CType(btn.RootElement.Children(0).Children(1).Children(1), TextPrimitive).ForeColor = Color.FromArgb(103, 138, 51)
		End Sub
        Private Function GetRandomData(ByVal count As Integer, ByVal seriesType As ChartSeriesType) As Telerik.Charting.ChartSeries
            Dim series As New Telerik.Charting.ChartSeries()
            series.Type = seriesType
            For i As Integer = 0 To count - 1
                series.Items.Add(New ChartSeriesItem(rand.Next(0, 100)))
            Next i
            Return series
        End Function

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Pie))
			radChart1.Refresh()
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton4.Click
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Bar))
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Bar))
			radChart1.Refresh()
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton3.Click
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.StackedBar))
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.StackedBar))
			radChart1.Refresh()
		End Sub

		Private Sub radButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton7.Click
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Area))
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Area))
			radChart1.Refresh()
		End Sub

		Private Sub radButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton5.Click
			radChart1.Series.Clear()
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Line))
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Line))
			radChart1.Refresh()
		End Sub
	End Class
End Namespace