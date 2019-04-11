Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class OrderForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ordersBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Validate()
			Me.ordersBindingSource.EndEdit()
			Me.ordersTableAdapter.Update(Me.nwindRadGridView.Orders)

		End Sub

		Private Sub OrderForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindRadGridView.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindRadGridView.Orders)

		End Sub
	End Class
End Namespace