﻿Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Data
Imports System

Namespace Telerik.Examples.WinControls.GridView.Printing
	Partial Public Class Form1
		Inherits ExamplesForm
#Region "Fields"

		Private Class ViewDefinitionInfo
			Public Columns As List(Of String)
			Public ViewDefinition As IGridViewDefinition
			Public RowHeight As Integer = 30
			Public HeaderHeight As Integer = 30
		End Class

		Private tableViewInfo As ViewDefinitionInfo
		Private htmlViewInfo As ViewDefinitionInfo
		Private columnGroupViewInfo As ViewDefinitionInfo
		Private currentViewInfo As ViewDefinitionInfo

		Private italicFont As New Font("Segoe UI", 9.0F, FontStyle.Italic)
		private isloaded as Boolean = false
#End Region

#Region "Initialization"

		Public Sub New()
			InitializeComponent()

			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ShowFilteringRow = False
			Me.radGridView1.ShowHeaderCellButtons = True
			Me.radGridView1.ShowGroupedColumns = True
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.EnableAlternatingRowColor = True			
		End Sub

		Private Sub InitializeGrid()
			Me.radGridView1.Columns("FirstName").Width = 80
			Me.radGridView1.Columns("LastName").Width = 80
			Me.radGridView1.Columns("Title").Width = 120
			Me.radGridView1.Columns("Photo").Width = 80
			Me.radGridView1.Columns("Photo").ImageLayout = ImageLayout.Stretch
			Me.radGridView1.Columns("City").Width = 70
			Me.radGridView1.Columns("Country").Width = 70
			Me.radGridView1.Columns("Address").Width = 200
			Me.radGridView1.Columns("Notes").Width = 260
			Me.radGridView1.Columns("Notes").WrapText = True
			Me.radGridView1.Columns("BirthDate").FormatString = "{0:d}"
			Me.radGridView1.Columns("BirthDate").Width = 120
			Me.radGridView1.Columns("HireDate").FormatString = "{0:d}"
			DirectCast(Me.radGridView1.Columns("Notes"), GridViewTextBoxColumn).Multiline = True

			tableViewInfo = New ViewDefinitionInfo()
			tableViewInfo.ViewDefinition = DirectCast(Me.radGridView1.ViewDefinition, TableViewDefinition)
			tableViewInfo.Columns = New List(Of String)() From { _
			 "FirstName", _
			 "LastName", _
			 "Title", _
			 "Country", _
			 "HomePhone", _
			 "Address", _
			 "Check", _
			 "Combo" _
			}

			' column groups view
			Dim cgv As New ColumnGroupsViewDefinition()
			columnGroupViewInfo = New ViewDefinitionInfo()
			columnGroupViewInfo.ViewDefinition = cgv
			columnGroupViewInfo.Columns = New List(Of String)() From { _
			 "Photo", _
			 "FirstName", _
			 "LastName", _
			 "Title", _
			 "Address", _
			 "City", _
			 "Country", _
			 "HomePhone", _
			 "Notes" _
			}
			columnGroupViewInfo.RowHeight = 90
			columnGroupViewInfo.HeaderHeight = 60

			cgv.ColumnGroups.Add(New GridViewColumnGroup())
			cgv.ColumnGroups.Add(New GridViewColumnGroup("General"))
			cgv.ColumnGroups.Add(New GridViewColumnGroup("Details"))
			cgv.ColumnGroups.Add(New GridViewColumnGroup("Notes"))

			cgv.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow())
			cgv.ColumnGroups(1).Rows.Add(New GridViewColumnGroupRow())
			cgv.ColumnGroups(1).Rows.Add(New GridViewColumnGroupRow())
			cgv.ColumnGroups(2).Rows.Add(New GridViewColumnGroupRow())
			cgv.ColumnGroups(2).Rows.Add(New GridViewColumnGroupRow())

			cgv.ColumnGroups(0).Rows(0).Columns.Add(Me.radGridView1.Columns("Photo"))
			cgv.ColumnGroups(0).ShowHeader = False

			cgv.ColumnGroups(1).Rows(0).Columns.Add(Me.radGridView1.Columns("Title"))
			cgv.ColumnGroups(1).Rows(1).Columns.Add(Me.radGridView1.Columns("FirstName"))
			cgv.ColumnGroups(1).Rows(1).Columns.Add(Me.radGridView1.Columns("LastName"))

			cgv.ColumnGroups(2).Rows(0).Columns.Add(Me.radGridView1.Columns("City"))
			cgv.ColumnGroups(2).Rows(0).Columns.Add(Me.radGridView1.Columns("Country"))
			cgv.ColumnGroups(2).Rows(0).Columns.Add(Me.radGridView1.Columns("HomePhone"))
			cgv.ColumnGroups(2).Rows(1).Columns.Add(Me.radGridView1.Columns("Address"))

			cgv.ColumnGroups(3).Rows.Add(New GridViewColumnGroupRow())
			cgv.ColumnGroups(3).Rows(0).Columns.Add(Me.radGridView1.Columns("Notes"))
			cgv.ColumnGroups(3).ShowHeader = False

			' html view
			htmlViewInfo = New ViewDefinitionInfo()
			htmlViewInfo.ViewDefinition = New HtmlViewDefinition()
			htmlViewInfo.Columns = New List(Of String)() From { _
			 "Photo", _
			 "Title", _
			 "FirstName", _
			 "LastName", _
			 "City", _
			 "Country", _
			 "Address", _
			 "Phone", _
			 "BirthDate", _
			 "HireDate", _
			 "HomePhone" _
			}

			Dim htmlView As New HtmlViewDefinition()
			htmlView.RowTemplate.Rows.Add(New RowDefinition())
			htmlView.RowTemplate.Rows.Add(New RowDefinition())
			htmlView.RowTemplate.Rows.Add(New RowDefinition())
			htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Photo", 0, 1, 3))
			htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("FirstName", 0, 1, 1))
			htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("LastName", 0, 2, 1))
			htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("BirthDate", 0, 1, 1))
			htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("Title", 0, 3, 1))
			htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("HireDate", 0, 1, 1))
			htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Address", 0, 1, 1))
			htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("City", 0, 1, 1))
			htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Country", 0, 1, 1))
			htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("HomePhone", 0, 1, 1))
			htmlView.RowTemplate.Rows(0).Height = 23
			htmlView.RowTemplate.Rows(1).Height = 23
			htmlView.RowTemplate.Rows(2).Height = 32

			htmlViewInfo.RowHeight = -1
			htmlViewInfo.HeaderHeight = -1
			htmlViewInfo.ViewDefinition = htmlView
		End Sub

		Private Sub InitializePrintDocument()
			Me.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]"
			Me.radPrintDocument1.LeftHeader = "[Time Printed]"
			Me.radPrintDocument1.MiddleFooter = "***"
			Me.radPrintDocument1.MiddleHeader = "Company employees info"
			Me.radPrintDocument1.RightFooter = "Printed by: [User Name]"
			Me.radPrintDocument1.RightHeader = "[Date Printed]"
		End Sub

		Private Sub SetView(info As ViewDefinitionInfo)
			currentViewInfo = info

			Me.radGridView1.FilterDescriptors.Clear()

			Me.radGridView1.BeginUpdate()

			For Each col As GridViewColumn In Me.radGridView1.Columns
				col.IsVisible = info.Columns.Contains(col.Name)
			Next

			Dim traverser As New GridTraverser(Me.radGridView1.MasterView)
			While traverser.MoveNext()
				If TypeOf traverser.Current Is GridViewDataRowInfo Then
					traverser.Current.Height = info.RowHeight
				End If
			End While

			Me.radGridView1.MasterView.TableHeaderRow.Height = info.HeaderHeight

			Me.radGridView1.EndUpdate(False)

			Me.radGridView1.ViewDefinition = info.ViewDefinition
			Me.radGridView1.PrintStyle.FitWidthMode = PrintFitWidthMode.NoFitCentered
		End Sub

#End Region

#Region "Event handlers"

		Protected Overrides Sub OnLoad(e As EventArgs) 
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Me.radGridView1.GroupDescriptors.Add(New Telerik.WinControls.Data.GroupDescriptor("Title Desc"))

			InitializeGrid()
			InitializePrintDocument()
			isloaded = true
			SetView(columnGroupViewInfo)
			
		End Sub

		Private Sub radRadioTable_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles radRadioButtonColumnGroups.ToggleStateChanged, radRadioButtonHtml.ToggleStateChanged, radRadioButtonTable.ToggleStateChanged
			if not isloaded then exit sub
			If Me.radRadioButtonColumnGroups.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
				SetView(columnGroupViewInfo)
			ElseIf Me.radRadioButtonHtml.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
				SetView(htmlViewInfo)
			Else
				SetView(tableViewInfo)
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(sender As Object, e As CellFormattingEventArgs) handles radGridView1.CellFormatting
			Dim cell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)
			If cell IsNot Nothing Then
				If cell.ColumnInfo.Name = "Notes" Then
					cell.Font = italicFont
					cell.Padding = New Padding(4)
				Else
					cell.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
					cell.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local)
				End If
			End If
		End Sub

		Private Sub radGridView1_PrintCellFormatting(sender As Object, e As PrintCellFormattingEventArgs) handles radGridView1.PrintCellFormatting
			If e.Column IsNot Nothing AndAlso e.Column.Name = "Notes" AndAlso TypeOf e.Row Is GridViewDataRowInfo Then
				e.PrintCell.Font = Me.italicFont
			End If
		End Sub

		Private Sub radButtonPrint_Click(sender As Object, e As EventArgs) Handles radButtonPrint.Click
            Me.radGridView1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub radButtonPrintPreview_Click(sender As Object, e As EventArgs) Handles radButtonPrintPreview.Click
            Dim dialog As New RadPrintPreviewDialog()
            dialog.ThemeName = Me.radGridView1.ThemeName
			dialog.Document = Me.radPrintDocument1
			dialog.StartPosition = FormStartPosition.CenterScreen
			dialog.ShowDialog()
		End Sub

		Private Sub radButtonPrintSettings_Click(sender As Object, e As EventArgs) Handles radButtonPrintSettings.Click
            Dim dialog As New GridViewPrintSettingsDialog()
            dialog.ThemeName = Me.radGridView1.ThemeName
			dialog.ShowPreviewButton = False
			dialog.PrintDocument = Me.radPrintDocument1
			dialog.StartPosition = FormStartPosition.CenterScreen
			If dialog.ShowDialog() = DialogResult.OK Then
				radButtonPrintPreview_Click(sender, e)
			End If
		End Sub

#End Region
	End Class
End Namespace
