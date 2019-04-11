Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing.Drawing2D
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.FolderTree
	Partial Public Class Form1
		Inherits ExamplesForm
		Private showCellBorders As Boolean = True
		Private lineStyle As DashStyle = DashStyle.Dot
		Private lineColor As Color = Color.Black

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared Function CreateDataSource() As DataTable
			Dim dataSource As New DataTable("fileSystem")
			dataSource.Columns.Add("ID", GetType(Integer))
			dataSource.Columns.Add("ParentID", GetType(Integer))
			dataSource.Columns.Add("Name", GetType(String))
			dataSource.Columns.Add("Date", GetType(DateTime))
			dataSource.Columns.Add("Type", GetType(String))
			dataSource.Columns.Add("Size", GetType(Integer))

			dataSource.Rows.Add(1, Nothing, "Program Files", DateTime.Now.AddDays(-100), "Folder", 5120)
			dataSource.Rows.Add(2, 1, "Visual Studio 2010", DateTime.Now.AddDays(-100), "Folder", 3220)
			dataSource.Rows.Add(3, 2, "bin", DateTime.Now.AddDays(-100), "Folder", 3220)
			dataSource.Rows.Add(4, 2, "READEME.txt", DateTime.Now.AddDays(-100), "Text Document", 3)

			dataSource.Rows.Add(5, 1, "Telerik RadControls", DateTime.Now.AddDays(-10), "Folder", 3120)
			dataSource.Rows.Add(6, 5, "RadControls for Winforms", DateTime.Now.AddDays(-10), "Folder", 101)
			dataSource.Rows.Add(7, 5, "RadControls for Silverlight", DateTime.Now.AddDays(-10), "Folder", 123)
			dataSource.Rows.Add(8, 5, "RadControls for WPF", DateTime.Now.AddDays(-10), "Folder", 221)
			dataSource.Rows.Add(9, 5, "RadControls for ASP.NET AJAX", DateTime.Now.AddDays(-10), "Folder", 121)

			dataSource.Rows.Add(10, 1, "Microsoft Office 2010", DateTime.Now.AddDays(-120), "Folder", 1230)
			dataSource.Rows.Add(11, 10, "Microsoft Word 2010", DateTime.Now.AddDays(-120), "Folder", 1230)
			dataSource.Rows.Add(12, 10, "Microsoft Excel 2010", DateTime.Now.AddDays(-120), "Folder", 1230)
			dataSource.Rows.Add(13, 10, "Microsoft Powerpoint 2010", DateTime.Now.AddDays(-120), "Folder", 1230)

			dataSource.Rows.Add(14, 1, "Debug Diagnostic Tools v1.0", DateTime.Now.AddDays(-400), "Folder", 2120)
			dataSource.Rows.Add(15, 1, "Designer's 3D Tools", DateTime.Now.AddDays(-500), "Folder", 1120)
			dataSource.Rows.Add(16, 1, "Communication", DateTime.Now.AddDays(-700), "Folder", 120)

			dataSource.Rows.Add(17, Nothing, "My Documents", DateTime.Now.AddDays(-200), "Folder", 1024)
			dataSource.Rows.Add(18, 17, "Salaries.xlsx", DateTime.Now.AddDays(-200), "Excel File", 1)
			dataSource.Rows.Add(19, 17, "RecessionAnalysis.xlsx", DateTime.Now.AddDays(-200), "Excel File", 1)

			dataSource.Rows.Add(20, Nothing, "Windows", DateTime.Now.AddDays(-100), "Folder", 10240)

			dataSource.Rows.Add(21, 20, "System32", DateTime.Now.AddDays(-220), "Folder", 510)
			dataSource.Rows.Add(22, 20, "assembly", DateTime.Now.AddDays(-20), "Folder", 240)

			dataSource.Rows.Add(23, 22, "System.Data.dll", DateTime.Now.AddDays(-20), "Assembly File", 4)
			dataSource.Rows.Add(24, 22, "System.Core.dll", DateTime.Now.AddDays(-20), "Assembly File", 2)
			dataSource.Rows.Add(25, 22, "System.Drawings.dll", DateTime.Now.AddDays(-20), "Assembly File", 3)
			dataSource.Rows.Add(26, 22, "Telerik.WinControls.UI.dll", DateTime.Now.AddDays(-20), "Assembly File", 5)

			dataSource.Rows.Add(27, Nothing, "Users", DateTime.Now.AddDays(-100), "Folder", 5512)
			dataSource.Rows.Add(28, 27, "Administrator", DateTime.Now.AddDays(-100), "Folder", 1512)
			dataSource.Rows.Add(29, 27, "Guest", DateTime.Now.AddDays(-100), "Folder", 2512)
			dataSource.Rows.Add(30, 27, "User1", DateTime.Now.AddDays(-100), "Folder", 3512)

			dataSource.Rows.Add(31, Nothing, "Share", DateTime.Now.AddDays(-50), "Folder", 15360)
			dataSource.Rows.Add(32, 31, "Photos", DateTime.Now.AddDays(-50), "Folder", 360)
			dataSource.Rows.Add(33, 32, "Flowers.JPG", DateTime.Now.AddDays(-50), "JPEG File", 1)
			dataSource.Rows.Add(34, 32, "Panda.GIF", DateTime.Now.AddDays(-50), "GIF File", 3)
			dataSource.Rows.Add(35, 32, "Landscape.png", DateTime.Now.AddDays(-50), "PNG File", 4)

			dataSource.Rows.Add(36, Nothing, "Music", DateTime.Now.AddDays(-2), "Folder", 0)
			dataSource.Rows.Add(37, 36, "Mozart", DateTime.Now.AddDays(-3), "Folder", 0)
			dataSource.Rows.Add(38, 36, "Pavarotti", DateTime.Now.AddDays(-40), "Folder", 0)
			dataSource.Rows.Add(39, 36, "AC/DC", DateTime.Now.AddDays(-50), "Folder", 0)
			dataSource.Rows.Add(40, 36, "Queen", DateTime.Now.AddDays(-8), "Folder", 0)

			dataSource.Rows.Add(33, Nothing, "Boot.ini", DateTime.Now.AddDays(-10), "INI File", 0)

			Return dataSource
		End Function

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.TableElement.RowHeight = 40
			AddHandler radGridView1.ViewCellFormatting, AddressOf radGridView1_ViewCellFormatting
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.DataSource = CreateDataSource()
			Me.radGridView1.Relations.AddSelfReference(Me.radGridView1.MasterTemplate, "ID", "ParentID")

			Me.radGridView1.Columns("ID").IsVisible = False
			Me.radGridView1.Columns("ParentID").IsVisible = False
			Me.radGridView1.Columns("Size").FormatString = "{0} MB"

			Me.radDropDownList1.SelectedIndex = 2
			Me.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = lineColor
		End Sub

		Private Sub radGridView1_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.Row Is GridViewDataRowInfo Then
				If showCellBorders Then
					e.CellElement.ResetValue(GridDataCellElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
				Else
					e.CellElement.DrawBorder = False
				End If

				Dim cell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)
				If cell IsNot Nothing AndAlso cell.SelfReferenceLayout IsNot Nothing Then
					For Each element As RadElement In cell.SelfReferenceLayout.StackLayoutElement.Children
						Dim linkItem As GridLinkItem = TryCast(element, GridLinkItem)
						If linkItem IsNot Nothing Then
							linkItem.LineStyle = lineStyle
							linkItem.ForeColor = lineColor
						End If
						Dim expanderItem As GridExpanderItem = TryCast(element, GridExpanderItem)
						If expanderItem IsNot Nothing Then
							expanderItem.LinkLineStyle = lineStyle
							expanderItem.LinkLineColor = lineColor
						End If
					Next element
				End If
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			Dim dataCell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)

			If dataCell.ColumnInfo.Name = "Name" Then
				Dim dataRow As GridViewDataRowInfo = TryCast(dataCell.RowInfo, GridViewDataRowInfo)
				dataCell.ImageAlignment = ContentAlignment.MiddleLeft

				Dim valueType As String = Convert.ToString(dataRow.Cells("Type").Value).ToUpperInvariant()

				If valueType.Contains("FILE") OrElse valueType.Contains("DOCUMENT") Then
					dataCell.Image = Me.imageList1.Images(2)
				ElseIf dataRow.IsExpanded Then
					dataCell.Image = Me.imageList1.Images(1)
				Else
					dataCell.Image = Me.imageList1.Images(0)
				End If

				dataCell.TextImageRelation = TextImageRelation.ImageBeforeText
			Else
				dataCell.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
				dataCell.ResetValue(LightVisualElement.ImageAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
				dataCell.ResetValue(LightVisualElement.TextImageRelationProperty, Telerik.WinControls.ValueResetFlags.Local)
				dataCell.ResetValue(LightVisualElement.ImageLayoutProperty, Telerik.WinControls.ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radCheckBoxShowCellBorders_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowCellBorders.ToggleStateChanged
			showCellBorders = radCheckBoxShowCellBorders.IsChecked
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownList1.SelectedIndexChanged
			lineStyle = CType(Me.radDropDownList1.SelectedIndex, DashStyle)
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radCheckBoxShowLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowLines.ToggleStateChanged
			Me.radGridView1.TableElement.ShowSelfReferenceLines = Me.radCheckBoxShowLines.IsChecked
		End Sub

		Private Sub radButtonBackColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonBackColor.Click
			Using dialog As New RadColorDialog()
				dialog.SelectedColor = lineColor
				If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					lineColor = dialog.SelectedColor
					Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = lineColor
					Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
				End If
			End Using
		End Sub

		Private Sub radButtonExpand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radButtonExpand.Click
			Me.radGridView1.MasterTemplate.ExpandAll()
		End Sub

		Private Sub radButtonCollapse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radButtonCollapse.Click
			Me.radGridView1.MasterTemplate.CollapseAll()
		End Sub
	End Class
End Namespace
