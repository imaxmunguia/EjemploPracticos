Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.RTL
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.radGridView1.MasterTemplate.Columns(0).VisibleInColumnChooser = False
			Me.radGridView1.MasterTemplate.Columns(1).AllowGroup = False

			Me.radToggleButton1.ToggleState = ToggleState.On
		End Sub

		Private Sub radToggleButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radToggleButton1.ToggleStateChanged
			If Me.radToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.RightToLeft = RightToLeft.Yes
			Else
				Me.radGridView1.RightToLeft = RightToLeft.No
			End If
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
