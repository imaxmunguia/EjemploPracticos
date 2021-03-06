Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports System.Threading
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Export.ExcelML

Namespace Telerik.Examples.WinControls.GridView.ExportToExcelEvents
	Partial Public Class Form1
		Inherits ExamplesForm
		Private dataSet1 As DataSet

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.InitializeGridAndDataSet()
			Me.radComboBox1.SelectedIndex = 0
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radButton1.Click
			Dim saveDialog1 As New SaveFileDialog()
			saveDialog1.Filter = "Excel (*.xls)|*.xls"

			If saveDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then

				Me.radProgressBar1.Text = "Exporting to ExcelML..."
				Me.radProgressBar1.Value1 = 0
				Me.radProgressBar1.Visible = True
				Me.radGridView1.Enabled = False
				Me.radComboBox1.Enabled = False
				Me.radButton1.Enabled = False

				Dim thread2 As New Thread(New ParameterizedThreadStart(AddressOf RunExportToExcelML))
				thread2.Start(saveDialog1.FileName)
			End If
		End Sub

        Private Delegate Sub CustomDelegate(ByVal obj As Object, ByVal text As String)

        Private Sub MessageShow(ByVal obj As Object, ByVal text As String)
            RadMessageBox.Show(Me, text)
        End Sub

        Private Sub MessageShowError(ByVal obj As Object, ByVal text As String)
            RadMessageBox.SetThemeName("Breeze")
            RadMessageBox.Show(Me, text, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Sub

		Private Sub RunExportToExcelML(ByVal fileName As Object)
            Try
                Dim exporter As New ExportToExcelML(Me.radGridView1)
                exporter.ExportVisualSettings = True
                If Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                    exporter.SheetMaxRows = ExcelMaxRows._1048576
                End If

                AddHandler exporter.ExcelCellFormatting, AddressOf exporter_ExcelCellFormatting
                AddHandler exporter.ExcelTableCreated, AddressOf exporter_ExcelTableCreated

                exporter.RunExport(fileName.ToString())

                RadMessageBox.SetThemeName("Breeze")
                Dim text As String = "Export finished successfully!"
                Dim ev As CustomDelegate = AddressOf Me.MessageShow
                If Me.InvokeRequired Then
                    ev.Invoke(Me, text)
                Else
                    RadMessageBox.Show(Me, text)
                End If
            Catch ex As System.IO.IOException
                If Me.InvokeRequired Then
                    Dim ev As CustomDelegate = AddressOf Me.MessageShowError
                    ev.Invoke(Me, ex.Message)
                Else
                    RadMessageBox.SetThemeName("Breeze")
                    RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                End If
            Finally
                Me.WorkCompleted()
            End Try
        End Sub

		''' <summary>
		''' using ExcelTableCreated event for adding custom header row
		''' </summary>
		Private Sub exporter_ExcelTableCreated(ByVal sender As Object, ByVal e As ExcelTableCreatedEventArgs)
			If e.SheetIndex = 0 Then 'add header row only for the first excel sheet
				Dim style As SingleStyleElement = (CType(sender, ExportToExcelML)).AddCustomExcelRow(e.ExcelTableElement, 48, "TABLE's TITLE")
				style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center
				style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center

				style.InteriorStyle.Pattern = InteriorPatternType.Solid
				style.InteriorStyle.Color = Color.Red
				style.FontStyle.Color = Color.White
				style.FontStyle.Bold = True
				style.FontStyle.Size = 26
			End If
		End Sub

		''' <summary>
		''' using ExcelCellFormatting event for updating progress bar and applying custom format in excel file
		''' </summary>
		Private Sub exporter_ExcelCellFormatting(ByVal sender As Object, ByVal e As ExcelCellFormattingEventArgs)

			If e.GridRowInfoType Is GetType(GridViewDataRowInfo) Then
				'update progress bar
				Dim position As Integer = CInt(Fix(100 * CDbl(e.GridRowIndex) / CDbl(Me.radGridView1.RowCount - 1)))
				Me.UpdateProgressBar(position)

				'do some formatting
				If e.GridColumnIndex = 3 AndAlso CInt(Fix(e.ExcelCellElement.Data.DataItem)) < 200 Then
					e.ExcelStyleElement.InteriorStyle.Color = Color.Yellow
				End If
			End If
		End Sub


		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox1.SelectedIndexChanged
			Dim rowCount As Integer

			Select Case Me.radComboBox1.SelectedIndex
				Case 1
					rowCount = 1000
				Case 2
					rowCount = 10000
				Case 3
					rowCount = 100000
				Case Else
					rowCount = 100
			End Select

			Me.radProgressBar1.Text = "Adding data to the grid..."
			Me.radProgressBar1.Value1 = 0
			Me.radProgressBar1.Visible = True

			Me.radGridView1.DataSource = Nothing
			Me.radGridView1.Enabled = False
			Me.radComboBox1.Enabled = False
			Me.radButton1.Enabled = False

			Dim thread As New Thread(New ParameterizedThreadStart(AddressOf PopulateData))
			thread.Start(rowCount)
		End Sub

		Private Sub PopulateData(ByVal rowNumber As Object)
			Me.dataSet1.Clear()

			Dim rdm As New Random()

			For i As Integer = 1 To CInt(Fix(rowNumber))
				Dim position As Integer = CInt(Fix(100 * (CDbl(i) / CInt(Fix(rowNumber)))))
				Me.UpdateProgressBar(position)


				Dim day As Integer = rdm.Next(1, 28)
				Dim month As Integer = rdm.Next(1, 12)
				Dim year As Integer = rdm.Next(1980, 2020)

				Dim randomDate As New DateTime(year, month, day)

				Dim randomNumber As Integer = rdm.Next(1, 1000)
				Me.dataSet1.Tables("Table1").Rows.Add(i, String.Format("Row Number: {0}", i), randomDate, randomNumber)
			Next i

			Me.WorkCompleted()
		End Sub

		Private Sub InitializeGridAndDataSet()
			'Initialize DataSet
			Dim table1 As New DataTable("Table1")
			table1.Columns.Add(New DataColumn("Id", GetType(Int32)))
			table1.Columns.Add(New DataColumn("Description", GetType(String)))
			table1.Columns.Add(New DataColumn("Date", GetType(DateTime)))
			table1.Columns.Add(New DataColumn("Random", GetType(Int32)))

			Me.dataSet1 = New DataSet()
			dataSet1.Tables.Add(table1)

			'Initialize RadgridView
			Me.radGridView1.TableElement.BeginUpdate()

			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False

			Me.radGridView1.Columns.Add(New GridViewTextBoxColumn("Id"))
			Me.radGridView1.Columns.Add(New GridViewTextBoxColumn("Description"))
			Me.radGridView1.Columns.Add(New GridViewTextBoxColumn("Date"))
			Me.radGridView1.Columns.Add(New GridViewTextBoxColumn("Random"))

			Me.radGridView1.Columns("Id").Width = 100
			Me.radGridView1.Columns("Id").HeaderText = "ID"

			Me.radGridView1.Columns("Description").Width = 200
			Me.radGridView1.Columns("Description").HeaderText = "Text Column"

			Me.radGridView1.Columns("Date").Width = 120
			Me.radGridView1.Columns("Date").FormatString = "{0:MM/dd/yyyy}"
			Me.radGridView1.Columns("Date").HeaderText = "Random Date"

			Me.radGridView1.Columns("Date").ExcelExportType = DisplayFormatType.Custom
			Me.radGridView1.Columns("Date").ExcelExportFormatString = "dddd, dd.MM.yyyy"

			Me.radGridView1.Columns("Random").Width = 140
			Me.radGridView1.Columns("Random").HeaderText = "Random Number"

			Me.radGridView1.TableElement.EndUpdate()
		End Sub

        Public Delegate Sub ProgressBarValueDelegate(ByVal value As Integer)

        Private Sub ProgressBarUpdate(ByVal value As Integer)
            If value < 100 Then
                Me.radProgressBar1.Value1 = value
            Else
                Me.radProgressBar1.Value1 = 100
            End If
        End Sub

		Private Sub UpdateProgressBar(ByVal value As Integer)
            If Me.InvokeRequired Then
                Dim progressBarValueDelegate As ProgressBarValueDelegate = AddressOf Me.ProgressBarUpdate
                progressBarValueDelegate.Invoke(value)
            Else
                If value < 100 Then
                    Me.radProgressBar1.Value1 = value
                Else
                    Me.radProgressBar1.Value1 = 100
                End If
            End If
        End Sub

		Private Sub WorkCompleted()
			If Me.InvokeRequired Then
				Me.Invoke(New EventHandler(AddressOf AnonymousMethod1))
			Else
				Me.radProgressBar1.Visible = False

				Me.radGridView1.DataSource = Me.dataSet1.Tables("Table1")
				Me.radGridView1.Enabled = True
				Me.radComboBox1.Enabled = True
				Me.radButton1.Enabled = True
			End If
		End Sub
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.radProgressBar1.Visible = False
			Me.radGridView1.RootElement.UpdateLayout()
			Me.radGridView1.DataSource = Me.dataSet1.Tables("Table1")
			Me.radGridView1.Enabled = True
			Me.radComboBox1.Enabled = True
			Me.radButton1.Enabled = True
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
