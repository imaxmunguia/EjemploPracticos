Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports Telerik.Examples.WinControls.Properties
Imports Telerik.Data.Expressions
Imports System.Reflection

Namespace Telerik.Examples.WinControls.GridView.Expressions
    Partial Public Class Form1
        Inherits ExamplesForm
#Region "Fields"
        Private Const InitialRowsNum As Integer = 5
        Private bitmaps As New List(Of Bitmap)()

        Private columnNum As Integer
        Private columnTypes As String() = New String() {"NumericText", "Decimal", "DateTime", "CheckBox", "CustomExpression"}
#End Region

        Public Sub New()
            InitializeComponent()
            ExpressionContext.Context = New CustomExpressionContext()
            LoadExpressionFunctionListFromExternalXML()
        End Sub

        Private Sub LoadExpressionFunctionListFromExternalXML()
            Dim path As String = "ExpressionItemsListData.xml"
            Dim stream As IO.Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)
            RadExpressionEditorForm.ExpressionItemsList.LoadFromXML(stream)
        End Sub

        Private Sub CreateBitmaps()
            Dim bmp As New Bitmap(My.Resources.Chart_Bar)
            bmp.MakeTransparent(Color.Magenta)
            bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.Chart_Gantt)
            bmp.MakeTransparent(Color.Magenta)
            bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.Chart_Pie)
            bmp.MakeTransparent(Color.Magenta)
            bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.Chart_Dot)
            bmp.MakeTransparent(Color.Magenta)
            bitmaps.Add(bmp)
        End Sub

        Private Sub SetPreferences()
            Me.radGridView1.MasterTemplate.EnableSorting = True
            Me.radGridView1.TableElement.RowHeight = 35

            Me.SelectedControl = Me.radGridView1
        End Sub

        Private Sub InitializeGrid()
            For i As Integer = 0 To Me.columnTypes.Length - 1
                AppendNewColumn(Me.columnTypes(i), False)
            Next

            Dim radiusColumn As New GridViewDecimalColumn()
            radiusColumn.Name = "Radius"
            radiusColumn.HeaderText = "Radius"
            Me.radGridView1.Columns.Insert(4, radiusColumn)


            Me.radGridView1.Columns("DateTime").FormatString = "{0:d}"
            Me.radGridView1.Columns("DateTime").TextAlignment = ContentAlignment.MiddleRight
            CreateBitmaps()
            Dim rowInfo As GridViewRowInfo = Me.radGridView1.Rows.AddNew()
            rowInfo.Cells(0).Value = "7432"
            rowInfo.Cells(1).Value = 23
            rowInfo.Cells(2).Value = DateTime.Now
            rowInfo.Cells(3).Value = True
            rowInfo.Cells(4).Value = 12.37

            rowInfo = Me.radGridView1.Rows.AddNew()
            rowInfo.Cells(0).Value = "890"
            rowInfo.Cells(1).Value = 574
            rowInfo.Cells(2).Value = DateTime.Now.AddMonths(-10)
            rowInfo.Cells(3).Value = True
            rowInfo.Cells(4).Value = 5.63

            rowInfo = Me.radGridView1.Rows.AddNew()
            rowInfo.Cells(0).Value = "5435"
            rowInfo.Cells(1).Value = 23444
            rowInfo.Cells(2).Value = DateTime.Now.AddDays(45)
            rowInfo.Cells(3).Value = True
            rowInfo.Cells(4).Value = 37.12

            rowInfo = Me.radGridView1.Rows.AddNew()
            rowInfo.Cells(0).Value = "132323"
            rowInfo.Cells(1).Value = 3455
            rowInfo.Cells(2).Value = DateTime.Now.AddMonths(34)
            rowInfo.Cells(3).Value = True
            rowInfo.Cells(4).Value = 23.54

            Me.radGridView1.RowCount = 4
            Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)

            Me.radGridView1.ShowGroupPanel = False
            Me.radGridView1.EnableGrouping = False
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False

            Me.radGridView1.Columns("CustomExpression").Expression = "ROUND(PI() * POWER(Radius, 2) + Decimal)"
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            For i As Integer = 0 To bitmaps.Count - 1
                bitmaps(i).Dispose()
            Next

            bitmaps.Clear()

            MyBase.OnHandleDestroyed(e)
        End Sub

        Private Function AppendNewColumn(ByVal columnType As String, ByVal numberInTheHeader As Boolean) As GridViewDataColumn
            Dim newColumn As GridViewDataColumn = Nothing
            Select Case columnType
                Case "NumericText"
                    newColumn = New GridViewMaskBoxColumn()
                    DirectCast(newColumn, GridViewMaskBoxColumn).Mask = "f"
                    newColumn.Name = "NumericText"
                    newColumn.EnableExpressionEditor = True
                    Exit Select
                Case "Decimal"
                    newColumn = New GridViewDecimalColumn()
                    newColumn.Name = "Decimal"
                    newColumn.DataType = GetType([Decimal])
                    Exit Select
                Case "DateTime"
                    newColumn = New GridViewDateTimeColumn()
                    newColumn.Name = "DateTime"
                    newColumn.DataType = GetType(DateTime)
                    Exit Select
                Case "CheckBox"
                    newColumn = New GridViewCheckBoxColumn()
                    newColumn.Name = "CheckBox"
                    newColumn.EnableExpressionEditor = True
                    Exit Select
                Case "CustomExpression"
                    newColumn = New GridViewDecimalColumn()
                    newColumn.EnableExpressionEditor = True
                    newColumn.Name = "CustomExpression"
                    newColumn.HeaderText = "Custom Expression"
                    newColumn.Width = 80
                    Exit Select
            End Select



            If numberInTheHeader Then
                newColumn.HeaderText = (System.Math.Max(System.Threading.Interlocked.Increment(Me.columnNum), Me.columnNum - 1)).ToString() & " - " & columnType
            Else
                newColumn.HeaderText = columnType
            End If

            Me.radGridView1.Columns.Add(newColumn)

            Return newColumn
        End Function

#Region "Event Handlers"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            SetPreferences()
            InitializeGrid()

            Me.radRadioCheckExpr1.ToggleState = ToggleState.[On]
            Me.radRadioNumExpr1.ToggleState = ToggleState.[On]

            Dim info As Globalization.CultureInfo = Threading.Thread.CurrentThread.CurrentCulture
            Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.InvariantCulture
            Me.radRadioCheckExpr2.Text = String.Format("DateTime > #{0}#", System.DateTime.Now.AddDays(60).ToShortDateString())
            Threading.Thread.CurrentThread.CurrentCulture = info
        End Sub

        Private Sub radButtonExprEditor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radButtonExprEditor.Click
            RadExpressionEditorForm.Show(Me.radGridView1, Me.radGridView1.Columns(5))
        End Sub

        Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.MasterTemplate.AllowAddNewRow = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radRadioNumExpr1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioAverage.ToggleStateChanged, radRadioNumExpr2.ToggleStateChanged, radRadioNumExpr1.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("NumericText") Then
                If Me.radRadioNumExpr1.ToggleState = ToggleState.[On] Then
                    Me.radGridView1.Columns("NumericText").Expression = Me.radRadioNumExpr1.Text
                End If

                If Me.radRadioNumExpr2.ToggleState = ToggleState.[On] Then
                    Me.radGridView1.Columns("NumericText").Expression = Me.radRadioNumExpr2.Text
                End If

                If Me.radRadioAverage.ToggleState = ToggleState.[On] Then
                    Me.radGridView1.Columns("NumericText").Expression = Me.radRadioAverage.Text
                End If
            End If
        End Sub

        Private Sub radRadioCheckExpr1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioCheckExpr1.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("CheckBox") Then
                If Me.radRadioCheckExpr1.ToggleState = ToggleState.[On] Then
                    Me.radGridView1.Columns("CheckBox").Expression = Me.radRadioCheckExpr1.Text
                End If

                If Me.radRadioCheckExpr2.ToggleState = ToggleState.[On] Then
                    Me.radGridView1.Columns("CheckBox").Expression = Me.radRadioCheckExpr2.Text
                End If
            End If
        End Sub
#End Region

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "ControlDefault"
        End Function
    End Class
End Namespace
