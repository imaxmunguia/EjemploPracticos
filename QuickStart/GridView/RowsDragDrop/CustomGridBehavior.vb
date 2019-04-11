Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.RowsDragDrop
    Public Class CustomGridBehavior
        Inherits BaseGridBehavior
        Private m_selectedRows As New List(Of GridViewRowInfo)()

        Public ReadOnly Property SelectedRows() As List(Of GridViewRowInfo)
            Get
                Return Me.m_selectedRows
            End Get
        End Property

        Public Overrides Function OnMouseDown(e As MouseEventArgs) As Boolean
            m_selectedRows.Clear()
            Dim result As Boolean = MyBase.OnMouseDown(e)

            If (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
                m_selectedRows.AddRange(Me.GridControl.SelectedRows)
            Else
                m_selectedRows.Add(Me.GridControl.CurrentRow)
            End If

            Return result
        End Function
    End Class
End Namespace
