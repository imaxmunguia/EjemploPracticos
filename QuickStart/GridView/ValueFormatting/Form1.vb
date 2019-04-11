Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.ValueFormatting
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SetPreferences()
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.SelectedControl = Me.radGridView1
		End Sub

		#Region "Event Handlers"

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SetPreferences()

			Me.order_DetailsTableAdapter1.Fill(Me.nwindDataSet1.Order_Details)
		End Sub

		Private Sub radButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonAdd.Click
			CType(Me.radGridView1.Columns("UnitPrice"), GridViewDataColumn).FormatString = radTextBox1.Text
			CType(Me.radGridView1.Columns("Discount"), GridViewDataColumn).FormatString = radTextBox1.Text
			CType(Me.radGridView1.Columns("OrderID"), GridViewDataColumn).FormatString = radTextBox1.Text
		End Sub

		Private Sub checkBoxFormatting_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckPrice.ToggleStateChanged, radCheckID.ToggleStateChanged, radCheckPercent.ToggleStateChanged
			Dim discount As GridViewDataColumn = CType(Me.radGridView1.Columns("Discount"), GridViewDataColumn)
			Dim orderId As GridViewDataColumn = CType(Me.radGridView1.Columns("OrderID"), GridViewDataColumn)
			Dim unitPrice As GridViewDataColumn = CType(Me.radGridView1.Columns("UnitPrice"), GridViewDataColumn)

			If Me.radCheckPercent.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				discount.FormatString = "{0:0.00%;0.00%;none}"
			Else
				discount.FormatString = ""
			End If

			If Me.radCheckID.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				orderId.FormatString = "#{0}"
			Else
				orderId.FormatString = ""
			End If

			If Me.radCheckPrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				unitPrice.FormatString = "${0}"
			Else
				unitPrice.FormatString = ""
			End If
		End Sub
		#End Region

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
