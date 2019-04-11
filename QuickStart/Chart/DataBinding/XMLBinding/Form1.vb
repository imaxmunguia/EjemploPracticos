Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.DataBinding.XMLBinding
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			radChart1.ChartTitle.TextBlock.Text = "Programming Books by Cost"
			'load the xml file to be displayed
			radChart1.DataSource = "..\Chart\DataBinding\XMLBinding\data.xml"
			radChart1.DataBind()
		End Sub
	End Class
End Namespace