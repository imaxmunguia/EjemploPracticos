Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.DataProviders
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports NorthwindDataSetTableAdapters
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.LayoutType
    Partial Public Class Form1
        Inherits ExamplesForm
        Private radPivotGrid1 As RadPivotGrid


        Public Sub New()

            Me.radPivotGrid1 = New RadPivotGrid()
            Me.radPivotGrid1.Dock = DockStyle.Fill
            Me.Controls.Add(Me.radPivotGrid1)

            Me.InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radPivotGrid1.PivotGridElement.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "OrderDate", _
             .[Step] = DateTimeStep.Year, _
             .GroupComparer = New GroupNameComparer() _
            })

            Me.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "ShipCountry", _
             .GroupComparer = New GrandTotalComparer(), _
             .CustomName = "Country", _
             .SortOrder = Pivot.Core.SortOrder.Descending _
            })
            Me.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "FirstName", _
             .GroupComparer = New GrandTotalComparer(), _
             .CustomName = "Employee", _
             .SortOrder = Pivot.Core.SortOrder.Ascending _
            })

            Me.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Quantity", _
             .AggregateFunction = AggregateFunctions.Sum _
            })
            Me.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "UnitPrice", _
             .AggregateFunction = AggregateFunctions.Max _
            })

            Dim dataset As NorthwindDataSet = New NorthwindDataSet()

            Dim adapter As New OrdersViewTableAdapter()

            adapter.Fill(dataset.OrdersView)
            Me.radPivotGrid1.AggregatesPosition = PivotAxis.Columns
            Me.radPivotGrid1.PivotGridElement.DataSource = dataset.OrdersView
        End Sub


        Private Sub radioTabularHeader_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles radioTabularColumnHeader.ToggleStateChanged, radioTabularRowHeader.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                If sender Is Me.radioTabularColumnHeader Then
                    Me.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Tabular
                Else
                    Me.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Tabular
                End If
            End If
        End Sub

        Private Sub radioCompactHeader_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles radioCompactColumnHeader.ToggleStateChanged, radioCompactRowHeader.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                If sender Is Me.radioCompactColumnHeader Then
                    Me.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Compact
                Else
                    Me.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Compact
                End If
            End If
        End Sub
    End Class
End Namespace
