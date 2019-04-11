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
Imports System.Xml.Serialization

Namespace Telerik.Examples.WinControls.GridView.Theming

	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
			radGridView1.ShowGroupPanel = True
			Me.radGridView1.EnableHotTracking = True
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			radGridView1.TableElement.BeginUpdate()
			'populate and bind the datasource
			aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders)
			radGridView1.MasterTemplate.AutoExpandGroups = True
			radGridView1.MasterTemplate.EnableFiltering = True
			radGridView1.TableElement.EndUpdate(False)
			'TODO
			'radGridView1.MasterTemplate.BestFitColumns();
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			radGridView1.EnableHotTracking = Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
