Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.ColumnChooser
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radGridView1.TableElement.BeginUpdate()

			Me.BindGrid()
			Me.radGridView1.Columns(0).IsVisible = False

			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.TableElement.EndUpdate(True)
			Me.radGridView1.ShowColumnChooser()
		End Sub

		Private Sub BindGrid()
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
		End Sub

		Private Sub btnOpenCondFormatting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radBtnLaunchColChooser.Click
			radGridView1.ShowColumnChooser()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace