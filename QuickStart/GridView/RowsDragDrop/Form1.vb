Imports System.Collections.Generic
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System

Namespace Telerik.Examples.WinControls.GridView.RowsDragDrop
    Partial Public Class Form1
        Inherits ExamplesForm
        Private boldFont As Font = Nothing

        Public Sub New()
            InitializeComponent()

            Me.SubscribeForGridEvents(Me.gridBasket)
            Me.SubscribeForGridEvents(Me.gridViewProducts)
            AddHandler Me.gridBasket.SelectionChanged, AddressOf gridBasket_SelectionChanged
        End Sub

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "ControlDefault"
        End Function

        Private Sub PrepareGrid(grid As RadGridView)
            Dim imageColumn As New GridViewImageColumn("Image", "Image")
            imageColumn.Width = 50
            imageColumn.HeaderText = [String].Empty
            Dim nameColumn As New GridViewTextBoxColumn("Name", "Name")
            nameColumn.Width = 70
            Dim countryColumn As New GridViewTextBoxColumn("Country", "Country")
            countryColumn.Width = 90
            Dim priceColumn As New GridViewDecimalColumn("Price", "Price")
            priceColumn.Width = 90
            priceColumn.FormatString = "{0:c}"

            grid.Columns.Add(imageColumn)
            grid.Columns.Add(nameColumn)
            grid.Columns.Add(countryColumn)
            grid.Columns.Add(priceColumn)
            grid.TableElement.RowHeight = 50
            grid.MasterTemplate.AllowRowReorder = True
            grid.[ReadOnly] = True
            grid.MultiSelect = True
            grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

            grid.GridBehavior = New CustomGridBehavior()
        End Sub

        Private Sub SubscribeForGridEvents(grid As RadGridView)
            Dim dragDropService As RadDragDropService = grid.GridViewElement.GetService(Of RadDragDropService)()
            AddHandler dragDropService.PreviewDragOver, AddressOf dragDropService_PreviewDragOver
            AddHandler dragDropService.PreviewDragDrop, AddressOf dragDropService_PreviewDragDrop
            AddHandler dragDropService.PreviewDragHint, AddressOf dragDropService_PreviewDragHint
            AddHandler grid.CellFormatting, AddressOf grid_CellFormatting
            AddHandler grid.Rows.CollectionChanged, AddressOf Rows_CollectionChanged
        End Sub

        Private Function GetTargetRowIndex(row As GridDataRowElement, dropLocation As Point) As Integer
            Dim halfHeight As Integer = row.Size.Height / 2
            Dim index As Integer = row.RowInfo.Index

            If dropLocation.Y > halfHeight Then
                index += 1
            End If

            Return index
        End Function

        Private Sub MoveRows(targetGrid As RadGridView, dragGrid As RadGridView, dragRows As IList(Of GridViewRowInfo), index As Integer)
            For i As Integer = dragRows.Count - 1 To 0 Step -1
                Dim row As GridViewRowInfo = dragRows(i)

                If TypeOf row Is GridViewSummaryRowInfo Then
                    Continue For
                End If

                Dim newRow As GridViewRowInfo = targetGrid.Rows.NewRow()
                Me.InitializeRow(newRow, row)
                targetGrid.Rows.Insert(index, newRow)
                row.IsSelected = False
                dragGrid.Rows.Remove(row)
                index += 1
            Next
        End Sub

        Private Sub InitializeRow(destRow As GridViewRowInfo, sourceRow As GridViewRowInfo)
            destRow.Cells("Image").Value = sourceRow.Cells("Image").Value
            destRow.Cells("Name").Value = sourceRow.Cells("Name").Value
            destRow.Cells("Country").Value = sourceRow.Cells("Country").Value
            destRow.Cells("Price").Value = sourceRow.Cells("Price").Value
        End Sub

#Region "Event handlers"

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.PrepareGrid(Me.gridBasket)

            Me.gridBasket.Rows.Add(Me.imageList1.Images(0), "Banana", "Ecuador", 50)
            Me.gridBasket.Rows.Add(Me.imageList1.Images(1), "Eggplant", "Turkey", 5)

            Dim summaryItem As New GridViewSummaryRowItem()
            summaryItem.Add(New GridViewSummaryItem("Price", "Total {0:c}", GridAggregateFunction.Sum))
            Me.gridBasket.MasterTemplate.SummaryRowsBottom.Add(summaryItem)

            Me.PrepareGrid(Me.gridViewProducts)

            Me.gridViewProducts.Rows.Add(Me.imageList1.Images(2), "Mushroom", "Ecuador", 20)
            Me.gridViewProducts.Rows.Add(Me.imageList1.Images(3), "Onion", "Italy", 30)
            Me.gridViewProducts.Rows.Add(Me.imageList1.Images(4), "Pear", "China", 100)
            Me.gridViewProducts.Rows.Add(Me.imageList1.Images(5), "Watermelon", "Bulgaria", 10)
        End Sub

        Private Sub btnCheckoutSelectedProducts_Click(sender As Object, e As EventArgs) Handles btnCheckoutSelectedProducts.Click
            Dim index As Integer = If(Me.gridBasket.RowCount > 0, Me.gridBasket.RowCount - 1, 0)
            Me.MoveRows(Me.gridBasket, Me.gridViewProducts, New List(Of GridViewRowInfo)(Me.gridViewProducts.SelectedRows), index)
        End Sub

        Private Sub btnCheckoutAllProducts_Click(sender As Object, e As EventArgs) Handles btnCheckoutAllProducts.Click
            Dim index As Integer = If(Me.gridBasket.RowCount > 0, Me.gridBasket.RowCount - 1, 0)
            Me.MoveRows(Me.gridBasket, Me.gridViewProducts, Me.gridViewProducts.Rows, index)
        End Sub

        Private Sub btnReturnSelectedProducts_Click(sender As Object, e As EventArgs) Handles btnReturnSelectedProducts.Click
            Dim index As Integer = If(Me.gridViewProducts.RowCount > 0, Me.gridViewProducts.RowCount - 1, 0)
            Me.MoveRows(Me.gridViewProducts, Me.gridBasket, New List(Of GridViewRowInfo)(Me.gridBasket.SelectedRows), index)
        End Sub

        Private Sub btnReturnAllProducts_Click(sender As Object, e As EventArgs) Handles btnReturnAllProducts.Click
            Dim index As Integer = If(Me.gridViewProducts.RowCount > 0, Me.gridViewProducts.RowCount - 1, 0)
            Me.MoveRows(Me.gridViewProducts, Me.gridBasket, Me.gridBasket.Rows, index)
        End Sub

        Private Sub radPanel1_SizeChanged(sender As Object, e As EventArgs) Handles radPanel1.SizeChanged
            Dim padding As Integer = 20
            Dim width As Integer = (Me.radPanel1.Size.Width - 3 * padding) / 2
            Dim heigh As Integer = Me.radPanel1.Size.Height - 2 * padding

            Me.gbProducts.Location = New Point(padding, padding)
            Me.gbProducts.Size = New Size(width, heigh)
            Me.gbBasket.Location = New Point(Me.gbProducts.Right + padding, padding)
            Me.gbBasket.Size = New Size(width, heigh)
        End Sub

        Private Sub Rows_CollectionChanged(sender As Object, e As Telerik.WinControls.Data.NotifyCollectionChangedEventArgs)
            Dim rows As GridViewRowCollection = TryCast(sender, GridViewRowCollection)

            If rows.Owner.MasterTemplate Is Me.gridBasket.MasterTemplate Then
                Dim isSummaryRowOnlySelected As Boolean = Me.gridBasket.SelectedRows.Count = 1 AndAlso TypeOf Me.gridBasket.SelectedRows(0) Is GridViewSummaryRowInfo
                Dim isEnabled As Boolean = rows.Count > 0 AndAlso Not isSummaryRowOnlySelected

                btnReturnAllProducts.Enabled = isEnabled
                btnReturnSelectedProducts.Enabled = isEnabled
            Else
                btnCheckoutAllProducts.Enabled = rows.Count > 0
                btnCheckoutSelectedProducts.Enabled = rows.Count > 0
            End If
        End Sub

        Private Sub grid_CellFormatting(sender As Object, e As CellFormattingEventArgs)
            Dim dataCell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)

            If dataCell IsNot Nothing AndAlso dataCell.ColumnInfo.Name = "Name" AndAlso TypeOf dataCell.RowElement Is GridDataRowElement Then
                If boldFont Is Nothing Then
                    boldFont = New Font(dataCell.Font, FontStyle.Bold)
                End If

                dataCell.Font = boldFont
            Else
                e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            End If
        End Sub

        Private Sub gridBasket_SelectionChanged(sender As Object, e As EventArgs)
            Dim grid As RadGridView = TryCast(sender, RadGridView)

            btnReturnSelectedProducts.Enabled = True
            btnReturnAllProducts.Enabled = True

            If grid Is Me.gridBasket Then
                Dim isSummaryRowOnlySelected As Boolean = Me.gridBasket.SelectedRows.Count = 1 AndAlso TypeOf Me.gridBasket.SelectedRows(0) Is GridViewSummaryRowInfo
                btnReturnSelectedProducts.Enabled = Not isSummaryRowOnlySelected
            End If
        End Sub

#End Region

#Region "Drag & drop logic"

        Private Sub dragDropService_PreviewDragDrop(sender As Object, e As RadDropEventArgs)
            Dim dragInstance As SnapshotDragItem = TryCast(e.DragInstance, SnapshotDragItem)

            If dragInstance Is Nothing Then
                Return
            End If

            Dim dropTarget As RadItem = TryCast(e.HitTarget, RadItem)
            Dim targetGrid As RadGridView = TryCast(dropTarget.ElementTree.Control, RadGridView)

            If targetGrid Is Nothing Then
                Return
            End If

            Dim dragGrid As RadGridView = TryCast(dragInstance.Item.ElementTree.Control, RadGridView)

            If Not targetGrid Is dragGrid Then
                e.Handled = True

                Dim behavior As CustomGridBehavior = DirectCast(dragGrid.GridBehavior, CustomGridBehavior)
                Dim dropTargetRow As GridDataRowElement = TryCast(dropTarget, GridDataRowElement)
                Dim index As Integer = If(dropTargetRow IsNot Nothing, Me.GetTargetRowIndex(dropTargetRow, e.DropLocation), targetGrid.RowCount)
                Me.MoveRows(targetGrid, dragGrid, behavior.SelectedRows, index)
            End If
        End Sub

        Private Sub dragDropService_PreviewDragOver(sender As Object, e As RadDragOverEventArgs)
            If TypeOf e.DragInstance Is SnapshotDragItem Then
                e.CanDrop = TypeOf e.HitTarget Is GridDataRowElement OrElse TypeOf e.HitTarget Is GridTableElement OrElse TypeOf e.HitTarget Is GridSummaryRowElement
            End If
        End Sub

        Private Sub dragDropService_PreviewDragHint(sender As Object, e As PreviewDragHintEventArgs)
            Dim dragInstance As SnapshotDragItem = TryCast(e.DragInstance, SnapshotDragItem)

            If dragInstance Is Nothing Then
                Return
            End If

            Dim rowInfo As GridViewRowInfo = TryCast(e.DragInstance.GetDataContext(), GridViewRowInfo)

            If rowInfo IsNot Nothing AndAlso rowInfo.ViewTemplate.MasterTemplate.SelectedRows.Count > 1 Then
                e.DragHint = New Bitmap(Me.imageList1.Images(6))
                e.UseDefaultHint = False
            End If
        End Sub

#End Region
    End Class
End Namespace
