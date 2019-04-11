Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Pie
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			'specifies a datasource of an array of double values
			radChart2.DataSource = New Double(){1.4, 1.9, 3.6, 4.2, 6.1}

			radChart2.DataBind()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace