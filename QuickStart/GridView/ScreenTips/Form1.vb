Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Reflection
Imports System.IO
'using Telerik.WinControls.UI.Export;

Namespace Telerik.Examples.WinControls.GridView.ScreenTips
	Partial Public Class Form1
		Inherits ExamplesForm
		Private executingAssembly As System.Reflection.Assembly

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			Me.radGridView1.EnableFiltering = False
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			AddHandler radGridView1.ScreenTipNeeded, AddressOf radGridView1_ScreenTipNeeded
			Me.radGridView1.TableElement.RowHeight = 60
			Me.radGridView1.TableElement.TableHeaderHeight = 35

			Me.BindGrid()

			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)
		End Sub

		Private Sub BindGrid()
			Dim imageColumn As New GridViewImageColumn("CarPicture")
			imageColumn.ImageLayout = ImageLayout.Zoom
			imageColumn.MaxWidth = 80
			imageColumn.MinWidth = 80
			imageColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
			imageColumn.HeaderText = "Car Picture"

			Dim col1 As New GridViewTextBoxColumn("CarName")
			col1.Width = 300
			col1.HeaderText = "Car"
			col1.HeaderTextAlignment = ContentAlignment.MiddleCenter

			Dim col2 As New GridViewDecimalColumn("Price")
			col2.HeaderText = "Price"
			col2.Width = 100
			col2.FormatString = "${0:N0}"
			col2.TextAlignment = ContentAlignment.MiddleRight
			col2.HeaderTextAlignment = ContentAlignment.MiddleCenter

			Dim dataColumn As New GridViewTextBoxColumn("MaxSpeed")
			dataColumn.TextAlignment = ContentAlignment.MiddleRight
			dataColumn.HeaderText = "Max Speed"
			dataColumn.FormatString = "{0} mph"
			dataColumn.Width = 100
			dataColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter

			Dim companyColumn As New GridViewTextBoxColumn("CompanyName")
			companyColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
			companyColumn.HeaderText = "Manufacturer"
			companyColumn.Width = 300

			Me.radGridView1.Columns.Add(imageColumn)
			Me.radGridView1.Columns.Add(col1)
			Me.radGridView1.Columns.Add(companyColumn)
			Me.radGridView1.Columns.Add(col2)
			Me.radGridView1.Columns.Add(dataColumn)

			radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.DataSource = CreateDataTable()
		End Sub

		Private Function CreateDataTable() As DataTable
			Dim table As New DataTable("Cars")

			table.Columns.Add("CarID", GetType(Integer))
			table.Columns.Add("CarPicture", GetType(Image))
			table.Columns.Add("CarName", GetType(String))
			table.Columns.Add("MaxSpeed", GetType(Integer))
			table.Columns.Add("Acceleration", GetType(String))
			table.Columns.Add("HorsePower", GetType(String))
			table.Columns.Add("Price", GetType(Double))
			table.Columns.Add("CompanyName", GetType(String))

			table.Rows.Add(1, Me.GetImageFromResource("SSC Ultimate Aero.png"), "SSC Ultimate Aero", 257, 2.7f, "1,183", 654400, "America�s Shelby Supercars")
			table.Rows.Add(2, Me.GetImageFromResource("Bugatti Veyron.png"), "Bugatti Veyron", 253, 2.5f, "1,001", 1148600, "Bugatti Automobiles SAS")
			table.Rows.Add(3, Me.GetImageFromResource("Koenigsegg CCX.png"), "Koenigsegg CCX", 250, 3.2f, 806, 695000, "Koenigsegg")
			table.Rows.Add(4, Me.GetImageFromResource("Saleen S7 Twin-Turbo.png"), "Saleen S7 Twin-Turbo", 248, 3.2f, 750, 555000, "Saleen, Hidden Creek Industries")
			table.Rows.Add(5, Me.GetImageFromResource("McLaren F1.png"), "McLaren F1", 240, 3.2f, 627, 970000, "McLaren Automotive")
			table.Rows.Add(6, Me.GetImageFromResource("Ferrari Enzo.png"), "Ferrari Enzo", 217, 3.4f, 660, 670000, "Ferrari")
			table.Rows.Add(7, Me.GetImageFromResource("Jaguar XJ220.png"), "Jaguar XJ220", 217, 4.0f, 542, 345000, "Jaguar")
			table.Rows.Add(8, Me.GetImageFromResource("Pagani Zonda F.png"), "Pagani Zonda F", 215, 3.5f, 650, 741000, "Pagani")
			table.Rows.Add(9, Me.GetImageFromResource("Lamborghini Murcielago LP640.png"), "Lamborghini Murcielago LP640", 213, 3.3f, 640, 430000, "Lamborghini")
			table.Rows.Add(10, Me.GetImageFromResource("Porsche Carrera GT.png"), "Porsche Carrera GT", 209, 3.9f, 612, 440000, "Porsche AG")

			Return table
		End Function

		Private Function GetImageFromResource(ByVal imageFileName As String) As Image
			Dim img As Image
			Dim imageStream As Stream

			If executingAssembly Is Nothing Then
				Me.executingAssembly = System.Reflection.Assembly.GetExecutingAssembly()
			End If

			imageStream = Me.executingAssembly.GetManifestResourceStream(imageFileName)
			img = Bitmap.FromStream(imageStream)

			If img Is Nothing Then
				imageStream = Me.executingAssembly.GetManifestResourceStream(String.Format(imageFileName))
				img = Bitmap.FromStream(imageStream)
			End If

			Return img
		End Function

		Private Sub ShowScreenTipForCell(ByVal cell As GridDataCellElement)
			Dim row As DataRowView = CType(cell.RowInfo.DataBoundItem, DataRowView)

			Dim screenTip As New RadOffice2007ScreenTipElement()
			screenTip.CaptionLabel.Margin = New Padding(3)

			Dim carImage As Image = CType(row("CarPicture"), Image)
			screenTip.MainTextLabel.Image = carImage
			screenTip.MainTextLabel.ImageAlignment = ContentAlignment.MiddleCenter
			'screenTip.MainTextLabel.Margin = new Padding(1, 0, 1, 0);
			'screenTip.MainTextLabel.Padding = new Padding(0, 0, 0, 3);

			Dim text As String = String.Format("<html><b>MaxSpeed:</b> {0}mph<br><b>Acceleration 0-62mph:</b> {1}sec<br><b>Horse Power:</b> {2} bhp", row("MaxSpeed"), row("Acceleration"), row("HorsePower"))
			screenTip.CaptionLabel.Text = text

			screenTip.MainTextLabel.Text = String.Empty
			screenTip.EnableCustomSize = False

			cell.ScreenTip = screenTip
		End Sub

		#Region "Event handling"

		Private Sub radGridView1_ScreenTipNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ScreenTipNeededEventArgs)
			Dim cell As GridDataCellElement = TryCast(e.Item, GridDataCellElement)

			If cell IsNot Nothing Then
				Me.ShowScreenTipForCell(cell)
			End If
		End Sub

		Private Sub OnRadGridViewDemo_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs) Handles radGridView1.ViewCellFormatting
			If TypeOf e.CellElement.RowElement.RowInfo Is GridViewTableHeaderRowInfo Then
				If e.CellElement.ColumnIndex = 0 Then
					e.CellElement.ToolTipText = "This is a picture column"
				ElseIf e.CellElement.ColumnIndex = 1 Then
					e.CellElement.ToolTipText = "This is a text column"
				ElseIf e.CellElement.ColumnIndex = 2 Then
					e.CellElement.ToolTipText = "This is a text column"
				ElseIf e.CellElement.ColumnIndex = 3 Then
					e.CellElement.ToolTipText = "This is a decimal column"
				ElseIf e.CellElement.ColumnIndex = 4 Then
					e.CellElement.ToolTipText = "This is a decimal column"
				End If
			End If
		End Sub

		#End Region

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
