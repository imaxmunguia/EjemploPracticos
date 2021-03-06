Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations


Namespace Telerik.Examples.WinControls.GridView.RowColumnOperations
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.TableElement.CellSpacing = -1
			Me.radGridView1.TableElement.EnableHotTracking = False
			Me.radGridView1.TableElement.TableHeaderHeight = 35
			Me.radGridView1.TableElement.GroupHeaderHeight = 40
			Me.radGridView1.TableElement.RowHeight = 30
		End Sub


		#Region "Event handlers"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radGridView1.TableElement.BeginUpdate()

			'populate and bind the datasource
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.radGridView1.DataSource = customersBindingSource

			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("CustomerID"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("Region"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("Fax"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("CompanyName"))
			Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("PostalCode"))

			Me.radGridView1.Columns("ContactName").HeaderText = "Contact Name"
			Me.radGridView1.Columns("ContactName").MinWidth = 80

			Me.radGridView1.Columns("ContactTitle").HeaderText = "Contact Title"

			Me.radGridView1.Columns("Address").MinWidth = 100

			Me.radGridView1.Columns("City").MinWidth = 60

			Me.radGridView1.Columns("Country").MinWidth = 70

			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.TableElement.EndUpdate(True)

			chkColResize.ToggleState = If(Me.radGridView1.MasterTemplate.AllowColumnResize, ToggleState.On, ToggleState.Off)
			chkRowResize.ToggleState = If(Me.radGridView1.MasterTemplate.AllowRowResize, ToggleState.On, ToggleState.Off)
			chkColReorder.ToggleState = If(Me.radGridView1.MasterTemplate.AllowColumnReorder, ToggleState.On, ToggleState.Off)
			chkColChooser.ToggleState = If(Me.radGridView1.MasterTemplate.AllowColumnChooser, ToggleState.On, ToggleState.Off)
			chkContextMenu.ToggleState = If(Me.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu, ToggleState.On, ToggleState.Off)
			chkFiltering.ToggleState = If(Me.radGridView1.MasterTemplate.EnableFiltering, ToggleState.On, ToggleState.Off)
			chkColAutosize.ToggleState = If(Me.radGridView1.MasterTemplate.AllowAutoSizeColumns, ToggleState.On, ToggleState.Off)
		End Sub

		Private Sub chkColResize_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkColResize.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowColumnResize = chkColResize.ToggleState = ToggleState.On
		End Sub

		Private Sub chkRowResize_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkRowResize.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowRowResize = chkRowResize.ToggleState = ToggleState.On
		End Sub

		Private Sub chkColReorder_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkColReorder.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowColumnReorder = chkColReorder.ToggleState = ToggleState.On
		End Sub

		Private Sub chkColChooser_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkColChooser.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowColumnChooser = chkColChooser.ToggleState = ToggleState.On
		End Sub

		Private Sub chkContextMenu_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkContextMenu.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = chkContextMenu.ToggleState = ToggleState.On
		End Sub

		Private Sub chkFiltering_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkFiltering.ToggleStateChanged
			Me.radGridView1.MasterTemplate.EnableFiltering = chkFiltering.ToggleState = ToggleState.On
			Me.radGridView1.MasterTemplate.ShowFilteringRow = chkFiltering.ToggleState = ToggleState.On
		End Sub

		Private Sub chkColAutosize_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkColAutosize.ToggleStateChanged
			Me.radGridView1.MasterTemplate.AllowAutoSizeColumns = chkColAutosize.ToggleState = ToggleState.On
		End Sub

		#End Region

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
