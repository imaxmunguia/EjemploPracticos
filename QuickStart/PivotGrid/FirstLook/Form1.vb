Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Pivot.Core
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.Examples.WinControls.DataSources
Imports NorthwindDataSetTableAdapters
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Private radPivotGrid1 As RadPivotGrid

        Public Sub New()
            InitializeComponent()

            Me.radPivotGrid1 = New RadPivotGrid()
            Me.radPivotGrid1.Dock = DockStyle.Fill
            Me.radPivotGrid1.PivotGridElement.ShowFilterArea = True

            Me.Controls.Add(Me.radPivotGrid1)

            Me.FillWithData()
        End Sub

        Private Sub FillWithData()
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "OrderDate", _
             .[Step] = DateTimeStep.Year, _
             .GroupComparer = New GroupNameComparer() _
            })
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "OrderDate", _
             .[Step] = DateTimeStep.Quarter, _
             .GroupComparer = New GroupNameComparer() _
            })
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "OrderDate", _
             .[Step] = DateTimeStep.Month, _
             .GroupComparer = New GroupNameComparer() _
            })

            Me.radPivotGrid1.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "FirstName", _
             .GroupComparer = New GrandTotalComparer(), _
             .CustomName = "Employee" _
            })

            Me.radPivotGrid1.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Quantity", _
             .AggregateFunction = AggregateFunctions.Sum _
            })
            Me.radPivotGrid1.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Discount", _
             .AggregateFunction = AggregateFunctions.Average _
            })

            Me.radPivotGrid1.FilterDescriptions.Add(New PropertyFilterDescription() With { _
             .PropertyName = "ShipCountry", _
             .CustomName = "Country" _
            })

            Dim dataset As NorthwindDataSet = New NorthwindDataSet()

            Dim adapter As New OrdersViewTableAdapter()

            adapter.Fill(dataset.OrdersView)
            Me.radPivotGrid1.AggregatesPosition = PivotAxis.Columns
            Me.radPivotGrid1.PivotGridElement.DataSource = dataset.OrdersView
            Me.radPivotGrid1.AllowFieldsDragDrop = False
            Me.radPivotGrid1.ErrorString = "Error"
            Me.radPivotGrid1.EmptyValueString = "No Data"
        End Sub

    End Class
End Namespace