Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.MultipleViews
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		#Region "Fields"

		Private tableView As TableViewDefinition
		Private columnGroupsView As ColumnGroupsViewDefinition
		Private htmlView As HtmlViewDefinition

		#End Region

		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ShowFilteringRow = False
			Me.radGridView1.ShowHeaderCellButtons = True
		End Sub

		Private Sub SetTheme()
		End Sub

		Private Sub InitializeGrid()
			' column groups view
			Me.columnGroupsView = New ColumnGroupsViewDefinition()
			Me.columnGroupsView.ColumnGroups.Add(New GridViewColumnGroup("General"))
			Me.columnGroupsView.ColumnGroups.Add(New GridViewColumnGroup("Details"))
			Me.columnGroupsView.ColumnGroups(1).Groups.Add(New GridViewColumnGroup("Address"))
			Me.columnGroupsView.ColumnGroups(1).Groups.Add(New GridViewColumnGroup())
			Me.columnGroupsView.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow())
			Me.columnGroupsView.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow())
			Me.columnGroupsView.ColumnGroups(0).Rows(0).Columns.Add(Me.radGridView1.Columns("CustomerID"))
			Me.columnGroupsView.ColumnGroups(0).Rows(0).Columns.Add(Me.radGridView1.Columns("ContactName"))
			Me.columnGroupsView.ColumnGroups(0).Rows(1).Columns.Add(Me.radGridView1.Columns("CompanyName"))
			Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows.Add(New GridViewColumnGroupRow())
			Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows(0).Columns.Add(Me.radGridView1.Columns("City"))
			Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows(0).Columns.Add(Me.radGridView1.Columns("Country"))
			Me.columnGroupsView.ColumnGroups(1).Groups(1).Rows.Add(New GridViewColumnGroupRow())
			Me.columnGroupsView.ColumnGroups(1).Groups(1).Rows(0).Columns.Add(Me.radGridView1.Columns("Phone"))

			' html view
			Me.htmlView = New HtmlViewDefinition()
			Me.htmlView.RowTemplate.Rows.Add(New RowDefinition())
			Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("CustomerID"))
			Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("ContactName"))
			Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("City"))
			Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Country"))
			Me.htmlView.RowTemplate.Rows(0).Cells(2).RowSpan = 2
			Me.htmlView.RowTemplate.Rows(0).Cells(3).RowSpan = 2
			Me.htmlView.RowTemplate.Rows.Add(New RowDefinition())
			Me.htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("CompanyName"))
			Me.htmlView.RowTemplate.Rows(1).Cells(0).ColSpan = 2
		End Sub

		#Region "Event Handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, THEME)

			Me.customersTableAdapter.Fill(Me.northwindDataSet.Customers)

			' table view
			Me.tableView = CType(Me.radGridView1.ViewDefinition, TableViewDefinition)
			InitializeGrid()
			Me.radRadioHTML.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radGridView1.ViewDefinition = htmlView
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor2.ValueChanged
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(Me.radSpinEditor2.Value))
		End Sub

		Private Sub radRadioTable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioGCView.ToggleStateChanged, radRadioHTML.ToggleStateChanged, radRadioTable.ToggleStateChanged
			If Me.radRadioGCView.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = columnGroupsView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If

			If Me.radRadioHTML.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = htmlView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If

			If Me.radRadioTable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = tableView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			End If

			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(radSpinEditor1.Value))
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(radSpinEditor2.Value))
		End Sub

		#End Region ' Event Handlers
	End Class
End Namespace
