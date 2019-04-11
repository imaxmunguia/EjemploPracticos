Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.GridView.GridLayout
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.None

			Me.radGridView1.TableElement.BeginUpdate()

			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.MasterTemplate.AutoExpandGroups = True


			Me.radGridView1.DataSource = customersBindingSource

			Me.radGridView1.MasterTemplate.Columns(0).VisibleInColumnChooser = False
			Me.radGridView1.MasterTemplate.Columns(1).AllowGroup = False

			Me.radGridView1.TableElement.EndUpdate()

			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Dim s As String = "default.xml"
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
			dialog.Title = "Select a xml file"
			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				s = dialog.FileName
			End If

			Me.radGridView1.SaveLayout(s)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Dim s As String = "default.xml"
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
			dialog.Title = "Select a xml file"
			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				s = dialog.FileName
			End If

			Me.radGridView1.LoadLayout(s)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace