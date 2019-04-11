Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class CustomerForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub customersBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Validate()
			Me.customersBindingSource.EndEdit()
			Me.customersTableAdapter.Update(Me.nwindRadGridView.Customers)

		End Sub

		Private Sub CustomerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindRadGridView.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

		End Sub
	End Class
End Namespace