Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.ViewModels
Imports Telerik.Pivot.DataProviders
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Microsoft.VisualBasic
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.Printing
    Partial Public Class Form1

        Private radPivotGrid1 As RadPivotGrid
        Private radPrintDocument1 As RadPrintDocument

        Private orders As New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Public Sub New()
            InitializeComponent()

            Me.radPivotGrid1 = New RadPivotGrid()
            Me.radPivotGrid1.ColumnWidth = 110
            Me.radPivotGrid1.Dock = DockStyle.Fill

            Me.radPrintDocument1 = New RadPrintDocument()
            Me.radPrintDocument1.AssociatedObject = Me.radPivotGrid1

            Me.Controls.Add(Me.radPivotGrid1)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.LoadData()

            Me.provider = New LocalDataSourceProvider() With { _
             .ItemsSource = orders _
            }

            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Product" _
            })
            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Promotion" _
            })

            provider.RowGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "Date", _
             .[Step] = DateTimeStep.Day _
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
            provider.AggregatesLevel = 21

            Me.radPivotGrid1.ColumnGrandTotalsPosition = TotalsPos.Last
            Me.radPivotGrid1.ColumnsSubTotalsPosition = TotalsPos.Last

            Me.radPivotGrid1.RowGrandTotalsPosition = TotalsPos.Last
            Me.radPivotGrid1.RowsSubTotalsPosition = TotalsPos.None

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
                     .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), _
                     .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), _
                     .Promotion = items(4), _
                     .Advertisement = items(5) _
                    }
                    orders.Add(o)
                End While
            End Using
        End Sub

        Private Sub buttonPrint_Click(sender As Object, e As EventArgs) Handles buttonPrint.Click
            Me.radPivotGrid1.Print(True, Me.radPrintDocument1)
        End Sub

        Private Sub buttonPrintPreview_Click(sender As Object, e As EventArgs) Handles buttonPrintPreview.Click
            Me.radPivotGrid1.PrintPreview(Me.radPrintDocument1)
        End Sub

        Private Sub buttonPrintSettings_Click(sender As Object, e As EventArgs) Handles buttonPrintSettings.Click
            Dim dialog As New PivotGridPrintSettingsDialog(Me.radPrintDocument1)
            dialog.ThemeName = Me.radPivotGrid1.ThemeName
            If dialog.ShowDialog() = DialogResult.OK Then
                Me.radPivotGrid1.PrintPreview(Me.radPrintDocument1)
            End If
        End Sub

    End Class
End Namespace