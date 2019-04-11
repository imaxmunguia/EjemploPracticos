Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Chart.DataBinding.List
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			'initializes a simple list containing integers

			AddHandler radChart1.DataBound, AddressOf radChart1_DataBound

			Dim chartData As List(Of Integer) = New List(Of Integer)()
			chartData.Add(900)
			chartData.Add(860)
			chartData.Add(830)
			chartData.Add(890)
			chartData.Add(940)
			chartData.Add(1230)

			radChart1.ChartTitle.TextBlock.Text = "Units Sold"
			'assigning the list as a datasource and binding it to the chart
			radChart1.DataSource = chartData
			radChart1.DataBind()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Private Sub radChart1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, RadChart).Series(0).Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
		End Sub


	End Class
End Namespace