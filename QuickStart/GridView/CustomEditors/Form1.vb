Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.CustomEditors
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim imagesPath As String = Path.Combine(Application.StartupPath, "..\GridView\CustomEditors\Images")
			Dim images() As String = Directory.GetFiles(imagesPath, "*.jpg")

			Dim r As New Random()
			Dim table As New DataTable()

			table.Columns.Add("Image", GetType(Image))
			table.Columns.Add("FileName", GetType(String))
			table.Columns.Add("Opacity", GetType(Integer))

			For i As Integer = 0 To images.Length - 1
				table.Rows.Add(Image.FromFile(images(i)), images(i), r.Next(100))
			Next i

			Me.radGridView1.TableElement.BeginUpdate()

			Me.radGridView1.DataSource = table
			Me.radGridView1.TableElement.RowHeight = 89
			Me.radGridView1.Columns(0).Width = 120
			Me.radGridView1.Columns(0).MaxWidth = 120
			Me.radGridView1.Columns(1).Width = 500
			Me.radGridView1.Columns(2).Width = 200
			Me.radGridView1.Columns(2).FormatString = "{0} %"

			Me.radGridView1.TableElement.EndUpdate()

			AddHandler radGridView1.ValueChanged, AddressOf radGridView1_ValueChanged
		End Sub

		' use this event to replace the default editor for a specific cell
		Private Sub radGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs) Handles radGridView1.EditorRequired
			If e.EditorType Is GetType(GridSpinEditor) AndAlso (Not Me.radGridView1.Columns(0).IsCurrent) Then
				e.EditorType = GetType(TrackBarEditor)
			ElseIf e.EditorType Is GetType(RadTextBoxEditor) Then
				e.EditorType = GetType(BrowseEditor)
			End If
		End Sub

		' use the event to customize the cell appearance
		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs) Handles radGridView1.CellFormatting
			If TypeOf e.CellElement Is GridImageCellElement Then
				Dim opacityValue As Object = e.CellElement.RowInfo.Cells("Opacity").Value
				Dim opacity As Integer = 0

				If opacityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(opacityValue)) Then
					opacity = Convert.ToInt32(opacityValue)
				End If

				e.CellElement.ImageOpacity = CDbl(opacity / 100.0)
				e.CellElement.ImageLayout = ImageLayout.Zoom
			End If
		End Sub

		' Fires when the cell changes its value
		Private Sub radGridView1_CellValueChanged(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles radGridView1.CellValueChanged
			Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
			If column IsNot Nothing AndAlso column.FieldName = "FileName" Then
				Dim value As Object = Nothing

				If e.Value IsNot Nothing AndAlso (Not Convert.IsDBNull(e.Value)) Then
					value = Image.FromFile(e.Value.ToString())
				End If

				Me.radGridView1.CurrentRow.Cells("Image").Value = value
			End If
		End Sub

		' Fires when the editor changes its value. The value is stored only inside the editor.
		Private Sub radGridView1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim editor As TrackBarEditor = TryCast(sender, TrackBarEditor)

			If editor IsNot Nothing Then
				Dim cell As GridCellElement = Me.radGridView1.TableElement.GetCellElement(Me.radGridView1.CurrentRow, Me.radGridView1.Columns("Opacity"))

				If cell IsNot Nothing Then
					cell.Text = editor.Value & " %"
				End If

				Dim imageCell As GridCellElement = Me.radGridView1.TableElement.GetCellElement(Me.radGridView1.CurrentRow, Me.radGridView1.Columns("Image"))

				If imageCell IsNot Nothing Then
					imageCell.ImageOpacity = CDbl(CInt(Fix(editor.Value)) / 100.0)
				End If
			End If
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
