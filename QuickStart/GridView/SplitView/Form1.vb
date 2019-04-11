Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Layouts
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.SplitView
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor"

		Public Sub New()
			InitializeComponent()
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub SplitGridControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.order_DetailsTableAdapter.Fill(Me.northwindDataSet.Order_Details)
			Me.gridView.DataSource = Me.northwindDataSet.Order_Details

			For Each dataColumn As GridViewDataColumn In Me.gridView.Columns
				dataColumn.Width = 100
			Next dataColumn

			Me.gridView.SynchronizeCurrentRowInSplitMode = False
			Me.radRadioButtonVertical.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.gridView.Columns("UnitPrice").FormatString = "{0:C}"
			Me.gridView.Columns("Discount").FormatString = "{0:0%;0:0%;-}"
		End Sub

		Private Sub radRadioButtonNone_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonNone.ToggleStateChanged
			Me.gridView.SplitMode = RadGridViewSplitMode.None
		End Sub

		Private Sub radRadioButtonVertical_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonVertical.ToggleStateChanged
			Me.gridView.SplitMode = RadGridViewSplitMode.Vertical
		End Sub

		Private Sub radRadioButtonHorizontal_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonHorizontal.ToggleStateChanged
			Me.gridView.SplitMode = RadGridViewSplitMode.Horizontal
		End Sub

		#End Region

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.gridView.SynchronizeCurrentRowInSplitMode = True
			Else
				Me.gridView.SynchronizeCurrentRowInSplitMode = False
			End If
		End Sub
	End Class
End Namespace
