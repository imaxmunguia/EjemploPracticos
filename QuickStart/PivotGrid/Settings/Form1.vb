Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.ViewModels
Imports Telerik.Pivot.DataProviders
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Microsoft.VisualBasic
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.Settings
    Partial Public Class Form1
        Inherits ExamplesForm
        Private pivot As RadPivotGrid

        Private suspendEvents As Boolean = False
        Private orders As New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Public Sub New()
            InitializeComponent()

            Me.pivot = New RadPivotGrid()
            Me.pivot.Dock = DockStyle.Fill

            Me.Controls.Add(Me.pivot)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.LoadData()

            Me.provider = New LocalDataSourceProvider() With { _
             .ItemsSource = orders _
            }

            provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Product", _
             .GroupComparer = New GroupNameComparer(), _
             .SortOrder = Telerik.Pivot.Core.SortOrder.Descending _
            })
            provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Promotion", _
             .GroupComparer = New GroupNameComparer() _
            })

            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Advertisement", _
             .GroupComparer = New GroupNameComparer() _
            })
            provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "Date", _
             .[Step] = DateTimeStep.Month _
            })

            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Quantity", _
             .AggregateFunction = AggregateFunctions.Sum _
            })
            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Net", _
             .AggregateFunction = AggregateFunctions.Sum _
            })

            provider.AggregatesPosition = PivotAxis.Rows
            provider.AggregatesLevel = 2

            Me.pivot.ColumnGrandTotalsPosition = TotalsPos.First
            Me.pivot.ColumnsSubTotalsPosition = TotalsPos.First

            Me.pivot.RowGrandTotalsPosition = TotalsPos.Last
            Me.pivot.RowsSubTotalsPosition = TotalsPos.First
            AddHandler pivot.PivotGridElement.UpdateCompleted, AddressOf pivotGridElement_DataUpdated
            Me.pivot.PivotGridElement.DataProvider = provider
        End Sub

        Private Sub RowGrandTotalChecked(sender As Object, e As StateChangedEventArgs) Handles rowGrandTotalNone.ToggleStateChanged, rowGrandTotalLast.ToggleStateChanged, rowGrandTotalFirst.ToggleStateChanged
            If Me.suspendEvents Then
                Return
            End If

            If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
                Me.pivot.RowGrandTotalsPosition = GetPosition(sender)
                Me.pivot.PivotGridElement.RefreshData()
            End If
        End Sub

        Private Sub RowSubTotalChecked(sender As Object, e As StateChangedEventArgs) Handles rowSubTotalNone.ToggleStateChanged, rowSubTotalLast.ToggleStateChanged, rowSubTotalFirst.ToggleStateChanged
            If Me.suspendEvents Then
                Return
            End If

            If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
                Me.pivot.RowsSubTotalsPosition = GetPosition(sender)
                Me.pivot.PivotGridElement.RefreshData()
            End If
        End Sub

        Private Sub ColumnGrandTotalChecked(sender As Object, e As StateChangedEventArgs) Handles columnGrandTotalNone.ToggleStateChanged, columnGrandTotalLast.ToggleStateChanged, columnGrandTotalFirst.ToggleStateChanged
            If Me.suspendEvents Then
                Return
            End If

            If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
                Me.pivot.ColumnGrandTotalsPosition = GetPosition(sender)
                Me.pivot.PivotGridElement.RefreshData()
            End If
        End Sub

        Private Sub ColumnSubTotalChecked(sender As Object, e As StateChangedEventArgs) Handles columnSubTotalNone.ToggleStateChanged, columnSubTotalLast.ToggleStateChanged, columnSubTotalFirst.ToggleStateChanged
            If Me.suspendEvents Then
                Return
            End If

            If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
                Me.pivot.ColumnsSubTotalsPosition = GetPosition(sender)
                Me.pivot.PivotGridElement.RefreshData()
            End If
        End Sub

        Private Sub AggregatesPositionChecked(sender As Object, args As StateChangedEventArgs) Handles aggregatePositionColumns.ToggleStateChanged, aggregatePositionRows.ToggleStateChanged
            If Me.suspendEvents Then
                Return
            End If

            Me.provider.AggregatesPosition = If((sender Is Me.aggregatePositionRows), PivotAxis.Rows, PivotAxis.Columns)
            Me.pivot.PivotGridElement.RefreshData()
        End Sub

        Private Sub radSpinEditor1_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditor1.ValueChanged
            If Me.suspendEvents Then
                Return
            End If

            If Me.pivot IsNot Nothing Then
                provider.AggregatesLevel = CInt(Me.radSpinEditor1.Value)
                Me.pivot.PivotGridElement.RefreshData()
            End If
        End Sub

        Private Function GetPosition(sender As Object) As TotalsPos
            If sender Is Me.rowGrandTotalFirst OrElse sender Is Me.columnGrandTotalFirst OrElse sender Is Me.rowSubTotalFirst OrElse sender Is Me.columnSubTotalFirst Then
                Return TotalsPos.First
            End If

            If sender Is Me.rowGrandTotalLast OrElse sender Is Me.columnGrandTotalLast OrElse sender Is Me.rowSubTotalLast OrElse sender Is Me.columnSubTotalLast Then
                Return TotalsPos.Last
            End If

            Return TotalsPos.None
        End Function

        Private Sub pivotGridElement_DataUpdated(sender As Object, e As EventArgs)
            Me.suspendEvents = True

            Select Case Me.pivot.RowGrandTotalsPosition
                Case TotalsPos.First
                    Me.rowGrandTotalFirst.IsChecked = True
                    Exit Select
                Case TotalsPos.Last
                    Me.rowGrandTotalLast.IsChecked = True
                    Exit Select
                Case TotalsPos.None
                    Me.rowGrandTotalNone.IsChecked = True
                    Exit Select
            End Select

            Select Case Me.pivot.ColumnGrandTotalsPosition
                Case TotalsPos.First
                    Me.columnGrandTotalFirst.IsChecked = True
                    Exit Select
                Case TotalsPos.Last
                    Me.columnGrandTotalLast.IsChecked = True
                    Exit Select
                Case TotalsPos.None
                    Me.columnGrandTotalNone.IsChecked = True
                    Exit Select
            End Select

            Select Case Me.pivot.RowsSubTotalsPosition
                Case TotalsPos.First
                    Me.rowSubTotalFirst.IsChecked = True
                    Exit Select
                Case TotalsPos.Last
                    Me.rowSubTotalLast.IsChecked = True
                    Exit Select
                Case TotalsPos.None
                    Me.rowSubTotalNone.IsChecked = True
                    Exit Select
            End Select

            Select Case Me.pivot.ColumnsSubTotalsPosition
                Case TotalsPos.First
                    Me.columnSubTotalFirst.IsChecked = True
                    Exit Select
                Case TotalsPos.Last
                    Me.columnSubTotalLast.IsChecked = True
                    Exit Select
                Case TotalsPos.None
                    Me.columnSubTotalNone.IsChecked = True
                    Exit Select
            End Select

            Select Case Me.provider.AggregatesPosition
                Case PivotAxis.Columns
                    Me.aggregatePositionColumns.IsChecked = True
                    Exit Select
                Case PivotAxis.Rows
                    Me.aggregatePositionRows.IsChecked = True
                    Exit Select
            End Select

            Me.radSpinEditor1.Value = Me.provider.AggregatesLevel

            Me.suspendEvents = False
        End Sub

        Private Sub LoadData()
            Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.[GetType]()).GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
                While streamReader.Peek() <> -1
                    Dim items As String() = streamReader.ReadLine().Split(ControlChars.Tab)
                    Dim o As New Order2() With { _
                     .[Date] = DateTime.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), _
                     .Product = items(1), _
                     .Quantity = Integer.Parse(items(2)), _
                     .Net = Double.Parse(items(3)), _
                     .Promotion = items(4), _
                     .Advertisement = items(5) _
                    }
                    orders.Add(o)
                End While
            End Using
        End Sub

    End Class
End Namespace