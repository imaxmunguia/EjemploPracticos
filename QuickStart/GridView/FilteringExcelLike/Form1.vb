Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO
Imports Telerik.Data
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Export
Imports System


Namespace Telerik.Examples.WinControls.GridView.FilteringExcelLike
    Partial Public Class Form1
        Inherits ExamplesForm
        Private ReadOnly endDate As DateTime = DateTime.Today
        Private ReadOnly range As Integer = 730
        Private random As New Random()

        Public Sub New()
            InitializeComponent()
            Me.radGridView1.AutoGenerateColumns = False
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.radGridView1.TableElement.BeginUpdate()
            Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
            Me.radGridView1.EnableFiltering = True
            Me.radGridView1.AllowAddNewRow = False
            Me.radGridView1.[ReadOnly] = True
            Me.radGridView1.MasterTemplate.ShowHeaderCellButtons = True
            Me.radGridView1.MasterTemplate.ShowFilteringRow = False
            Me.radGridView1.TableElement.EndUpdate()

            For Each row As GridViewRowInfo In Me.radGridView1.Rows
                row.Cells("Date").Value = GetRandomDate()
            Next

            Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        End Sub

        Private Sub radGridView1_FilterPopupRequired(sender As Object, e As FilterPopupRequiredEventArgs) Handles radGridView1.FilterPopupRequired
            If Me.radRadioButton4.IsChecked Then
                e.FilterPopup = New RadSimpleListFilterPopup(e.Column)
            ElseIf e.Column.Name = "Date" Then
                If Me.radRadioButton1.IsChecked Then
                    Return
                ElseIf Me.radRadioButton2.IsChecked Then
                    e.FilterPopup = New RadListFilterPopup(e.Column)
                ElseIf Me.radRadioButton3.IsChecked Then
                    e.FilterPopup = New RadListFilterPopup(e.Column, True)
                End If
            End If
        End Sub

        Private Function GetRandomDate() As DateTime
            Return Me.endDate.AddDays(-Me.random.[Next](range))
        End Function

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "ControlDefault"
        End Function


    End Class
End Namespace
