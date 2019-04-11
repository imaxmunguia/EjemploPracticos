Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Pivot.DataProviders
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Pivot.Core
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.PivotGrid
Imports Microsoft.VisualBasic
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.FieldList

    Partial Public Class Form1
        Inherits RadForm

        Private orders As New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Public Sub New()
            InitializeComponent()
            Me.LoadData()

            Me.provider = New LocalDataSourceProvider() With { _
             .ItemsSource = orders _
            }

            provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "Date", _
             .[Step] = DateTimeStep.Year _
            })
            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Promotion", _
             .GroupComparer = New GroupNameComparer() _
            })

            provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Product", _
             .GroupComparer = New GroupNameComparer(), _
             .SortOrder = Telerik.Pivot.Core.SortOrder.Descending _
            })
            provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Advertisement", _
             .GroupComparer = New GroupNameComparer() _
            })

            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Quantity", _
             .AggregateFunction = AggregateFunctions.Sum _
            })
            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Net", _
             .AggregateFunction = AggregateFunctions.Sum _
            })

            provider.AggregatesPosition = PivotAxis.Columns
            provider.AggregatesLevel = 2

            Me.radPivotGrid1.PivotGridElement.DataProvider = provider
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