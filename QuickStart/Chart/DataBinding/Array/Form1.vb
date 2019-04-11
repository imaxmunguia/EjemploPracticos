Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.DataBinding.Array
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			'initialize a simple array of double values to be displayed
			radChart1.DataSource = New Double() { 1.4, 1.9, 3.6, 3.6, 4.1 }

			radChart1.ChartTitle.TextBlock.Text = "Units Purchased (Thousands)"
			radChart1.DataBind()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace