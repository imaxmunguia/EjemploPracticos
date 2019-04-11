Imports System
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class Legend
		Inherits RadControl
		Private legendElement As LegendElement

		Public Sub New()
		End Sub

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			MyBase.CreateChildItems(parent)
			legendElement = New LegendElement()
			parent.Children.Add(legendElement)

			Me.BackColor = Color.White
		End Sub

		Public Sub BuildLegend(ByVal element As RadChartElement)
			Me.legendElement.BuildLegend(element)
		End Sub
	End Class
End Namespace
