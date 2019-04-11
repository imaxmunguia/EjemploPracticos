Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.IO
Imports System.Diagnostics
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.ColumnTypes
    Partial Public Class Form1
        Inherits ExamplesForm
        Private rand As New Random()

        Private Enum TitleOfCourtesy
            Mr
            Ms
            Mrs
            Dr
        End Enum

        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radGridView1

            AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
            AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit
        End Sub

        Private Sub BindGrid()
            Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
            Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
            radGridView1.DataSource = Me.nwindDataSet.Employees

            Dim decimalColumn As New GridViewDecimalColumn()
            decimalColumn.FieldName = "EmployeeID"
            decimalColumn.Name = "EmployeeID"
            decimalColumn.HeaderText = "Decimal"
            decimalColumn.DecimalPlaces = 0
            decimalColumn.Width = 100
            decimalColumn.IsVisible = False
            Me.radGridView1.Columns.Add(decimalColumn)

            Dim textBoxColumn As New GridViewTextBoxColumn()
            textBoxColumn.FieldName = "LastName"
            textBoxColumn.Name = "LastName"
            textBoxColumn.HeaderText = "Text"
            textBoxColumn.Width = 100
            textBoxColumn.IsVisible = False
            Me.radGridView1.Columns.Add(textBoxColumn)

            Dim imageColumn As New GridViewImageColumn()
            imageColumn.FieldName = "Photo"
            imageColumn.Name = "Photo"
            imageColumn.HeaderText = "Image"
            imageColumn.ImageLayout = ImageLayout.Zoom
            imageColumn.Width = 54
            Me.radGridView1.Columns.Add(imageColumn)

            Dim lookUpColumn As New GridViewComboBoxColumn()
            lookUpColumn.FieldName = "TitleOfCourtesy"
            lookUpColumn.Name = "LookUp"
            lookUpColumn.HeaderText = "LookUp"
            lookUpColumn.DataSource = New String() {"Mr.", "Mrs.", "Dr.", "Ms."}
            lookUpColumn.Width = 100
            lookUpColumn.IsVisible = False
            Me.radGridView1.Columns.Add(lookUpColumn)

            Dim maskBoxColumn As New GridViewMaskBoxColumn()
            maskBoxColumn.FieldName = "HomePhone"
            maskBoxColumn.Name = "MaskBox"
            maskBoxColumn.HeaderText = "MaskBox"
            maskBoxColumn.MaskType = MaskType.Standard
            maskBoxColumn.Mask = "(###) ###-####"
            maskBoxColumn.Width = 200
            maskBoxColumn.IsVisible = False
            Me.radGridView1.Columns.Add(maskBoxColumn)

            Dim hyperlinkColumn As New GridViewHyperlinkColumn("Hyperlink")
            hyperlinkColumn.[ReadOnly] = True
            hyperlinkColumn.Width = 210
            Me.radGridView1.Columns.Add(hyperlinkColumn)

            Dim colorColumn As New GridViewColorColumn("Color")
            colorColumn.Width = 100
            Me.radGridView1.Columns.Add(colorColumn)

            Dim calculatorColumn As New GridViewCalculatorColumn("Calculator")
            calculatorColumn.Width = 110
            Me.radGridView1.Columns.Add(calculatorColumn)

            Dim browseColumn As New GridViewBrowseColumn("Browse")
            browseColumn.Width = 210
            Me.radGridView1.Columns.Add(browseColumn)

            Dim checkBoxColumn As New GridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = "CheckBox"
            checkBoxColumn.Name = "CheckBox"
            checkBoxColumn.Width = 100
            checkBoxColumn.IsVisible = False
            Me.radGridView1.Columns.Add(checkBoxColumn)

            Dim commandColumn As GridViewDataColumn = New GridViewTextBoxColumn()
            commandColumn.HeaderText = "Custom"
            commandColumn.Name = "ProgressBar"
            commandColumn.DataType = GetType(Integer)
            commandColumn.[ReadOnly] = True
            commandColumn.Width = 100
            Me.radGridView1.Columns.Add(commandColumn)

            Me.PopulateUnboundColumns()
        End Sub

        Private Sub PopulateUnboundColumns()
            Me.radGridView1.TableElement.BeginUpdate()

            For i As Integer = 0 To Me.radGridView1.Rows.Count - 1
                Dim number As Integer = rand.[Next](0, 100)
                Me.radGridView1.Rows(i).Cells("CheckBox").Value = i Mod 2 = 0
                Me.radGridView1.Rows(i).Cells("ProgressBar").Value = number
                Me.radGridView1.Rows(i).Cells("Calculator").Value = number
            Next

            Me.radGridView1.Rows(0).Cells("Hyperlink").Value = "http://www.telerik.com"
            Me.radGridView1.Rows(1).Cells("Hyperlink").Value = "http://www.microsoft.com"
            Me.radGridView1.Rows(2).Cells("Hyperlink").Value = "http://www.google.com"
            Me.radGridView1.Rows(3).Cells("Hyperlink").Value = "http://www.cnn.com"
            Me.radGridView1.Rows(4).Cells("Hyperlink").Value = "http://www.bbc.com"
            Me.radGridView1.Rows(5).Cells("Hyperlink").Value = "http://www.telerikwatch.com"
            Me.radGridView1.Rows(6).Cells("Hyperlink").Value = "http://www.wikipedia.com"
            Me.radGridView1.Rows(7).Cells("Hyperlink").Value = "http://blogs.telerik.com/blogs.aspx"
            Me.radGridView1.Rows(8).Cells("Hyperlink").Value = "http://www.telerik.com/community/forums.aspx"

            Me.radGridView1.Rows(0).Cells("Color").Value = "Red"
            Me.radGridView1.Rows(1).Cells("Color").Value = "Orange"
            Me.radGridView1.Rows(2).Cells("Color").Value = "Yellow"
            Me.radGridView1.Rows(3).Cells("Color").Value = "Green"
            Me.radGridView1.Rows(4).Cells("Color").Value = "Blue"
            Me.radGridView1.Rows(5).Cells("Color").Value = "Indigo"
            Me.radGridView1.Rows(6).Cells("Color").Value = "Violet"
            Me.radGridView1.Rows(7).Cells("Color").Value = "White"
            Me.radGridView1.Rows(8).Cells("Color").Value = "Black"

            Me.radGridView1.Rows(0).Cells("Browse").Value = "C:\Music\Sting\If You Love Somebody Set Them Free.wav"
            Me.radGridView1.Rows(1).Cells("Browse").Value = "C:\Music\Sting\Russians.wav"
            Me.radGridView1.Rows(2).Cells("Browse").Value = "C:\Music\Sting\Fortress Around Your Heart.wav"
            Me.radGridView1.Rows(3).Cells("Browse").Value = "C:\Music\Sting\Love Is the Seventh Wave.wav"
            Me.radGridView1.Rows(4).Cells("Browse").Value = "C:\Music\Sheryl Crow\Run, Baby, Run.wav"
            Me.radGridView1.Rows(5).Cells("Browse").Value = "C:\Music\Sheryl Crow\Leaving Las Vegas.wav"
            Me.radGridView1.Rows(6).Cells("Browse").Value = "C:\Music\Sheryl Crow\Strong Enough.wav"
            Me.radGridView1.Rows(7).Cells("Browse").Value = "C:\Music\Sheryl Crow\Maybe Angels.wav"
            Me.radGridView1.Rows(8).Cells("Browse").Value = "C:\Music\Sheryl Crow\A Change Would Do You Good.wav"

            Me.radGridView1.TableElement.EndUpdate()
        End Sub


#Region "Event handling"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.radGridView1.MasterTemplate.EnableGrouping = False
            Me.radGridView1.MasterTemplate.EnableFiltering = False
            Me.radGridView1.MasterTemplate.EnableSorting = False
            Me.radGridView1.TableElement.EnableHotTracking = False
            Me.radGridView1.TableElement.TableHeaderHeight = 35
            Me.radGridView1.TableElement.RowHeight = 60

            Me.BindGrid()
        End Sub

        Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
            Dim comboBoxEditor As RadDropDownListEditor = TryCast(Me.radGridView1.ActiveEditor, RadDropDownListEditor)
            If comboBoxEditor IsNot Nothing Then
                comboBoxEditor.EditorElement.StretchVertically = False
                comboBoxEditor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
                comboBoxEditor.DropDownSizingMode = SizingMode.UpDownAndRightBottom
            End If
        End Sub

        Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
            If TypeOf e.CellElement.RowInfo Is GridViewFilteringRowInfo Then
                Return
            End If

            If e.CellElement.ColumnInfo.Name = "ProgressBar" Then
                Dim progressBarElement As RadProgressBarElement
                If e.CellElement.Children.Count = 0 Then
                    progressBarElement = New RadProgressBarElement()
                    e.CellElement.Children.Add(progressBarElement)
                    progressBarElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                Else
                    progressBarElement = TryCast(e.CellElement.Children(0), RadProgressBarElement)
                End If
                progressBarElement.Margin = New Padding(15)
                progressBarElement.StretchHorizontally = True


                Dim value As Integer = 0

                If e.CellElement.Value IsNot Nothing Then
                    Try
                        Int32.TryParse(CType(e.CellElement, GridDataCellElement).Value.ToString(), value)
                    Catch
                        value = 0
                    End Try
                End If

                If value < 0 Then
                    value = 0
                ElseIf value > 100 Then
                    value = 100
                End If

                progressBarElement.Value1 = value
            Else
                If e.CellElement.ColumnInfo.Name <> "CheckBox" AndAlso e.CellElement.ColumnInfo.Name <> "Hyperlink" AndAlso e.CellElement.ColumnInfo.Name <> "Color" AndAlso _
                    Not (e.CellElement.IsCurrent AndAlso Me.radGridView1.IsInEditMode) Then
                    e.CellElement.Children.Clear()
                End If

                If e.CellElement.ColumnInfo.Name = "MaskBox" Then
                    Dim result As Long
                    If e.CellElement.Text.Contains("(") OrElse (Not Long.TryParse(e.CellElement.Text, result)) Then
                        Return
                    End If
                    e.CellElement.Text = String.Format("{0:(000) 000-0000}", result)
                End If

                If e.CellElement.ColumnInfo.Name = "Color" Then
                    Dim cell As GridColorCellElement = TryCast(e.CellElement, GridColorCellElement)
                    cell.ColorBox.StretchVertically = False
                    cell.ColorBox.Alignment = ContentAlignment.MiddleCenter
                    cell.ColorBox.MinSize = New Size(20, 20)
                End If
            End If
        End Sub

        Private Sub radCheckBoxDecimal_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxDecimal.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("EmployeeID") Then
                Me.radGridView1.Columns("EmployeeID").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxText_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxText.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("LastName") Then
                Me.radGridView1.Columns("LastName").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxImage_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxImage.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("Photo") Then
                Me.radGridView1.Columns("Photo").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxLookUp_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxLookUp.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("LookUp") Then
                Me.radGridView1.Columns("LookUp").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxMaskBox_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxMaskBox.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("MaskBox") Then
                Me.radGridView1.Columns("MaskBox").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxHyperlink_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxHyperlink.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("Hyperlink") Then
                Me.radGridView1.Columns("Hyperlink").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxColor_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColor.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("Color") Then
                Me.radGridView1.Columns("Color").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxCalculator_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxCalculator.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("Calculator") Then
                Me.radGridView1.Columns("Calculator").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxBrowse_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxBrowse.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("Browse") Then
                Me.radGridView1.Columns("Browse").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxCheckBox_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxCheckBox.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("CheckBox") Then
                Me.radGridView1.Columns("CheckBox").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

        Private Sub radCheckBoxCustom_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxCustom.ToggleStateChanged
            If Me.radGridView1.Columns.Contains("ProgressBar") Then
                Me.radGridView1.Columns("ProgressBar").IsVisible = args.ToggleState = ToggleState.[On]
            End If
        End Sub

#End Region

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "ControlDefault"
        End Function
    End Class
End Namespace
