Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.Editors.ComboBox.MultiColumnComboBox
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radMultiColumnComboBox1
			Me.radMultiColumnComboBox1.AutoSizeDropDownToBestFit = True

			Dim multiColumnComboElement As RadMultiColumnComboBoxElement = Me.radMultiColumnComboBox1.MultiColumnComboBoxElement
			multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom
			multiColumnComboElement.DropDownMinSize = New Size(420, 300)

			multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = False

			Dim column As New GridViewTextBoxColumn("CustomerID")
			column.HeaderText = "Customer ID"
			multiColumnComboElement.Columns.Add(column)
			column = New GridViewTextBoxColumn("ContactName")
			column.HeaderText = "Contact Name"
			multiColumnComboElement.Columns.Add(column)
			column = New GridViewTextBoxColumn("ContactTitle")
			column.HeaderText = "Contact Title"
			multiColumnComboElement.Columns.Add(column)
			column = New GridViewTextBoxColumn("Country")
			column.HeaderText = "Country"
			multiColumnComboElement.Columns.Add(column)
			column = New GridViewTextBoxColumn("Phone")
			column.HeaderText = "Phone"
			multiColumnComboElement.Columns.Add(column)

			Me.SetTheme()
		End Sub

		Private Sub OnTextBoxItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup()
		End Sub

		Private Sub SetTheme()
			Me.radMultiColumnComboBox1.ThemeName = THEME
			Me.radCheckAutoFilter.ThemeName = THEME
			Me.radCheckRotate.ThemeName = THEME
			Me.radCheckRTL.ThemeName = THEME
			Me.radGroupSettings.ThemeName = THEME
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim nwindDataSet As New NorthwindDataSet()
			Dim customersTableAdapter As New CustomersTableAdapter()
			customersTableAdapter.Fill(nwindDataSet.Customers)

			Me.radMultiColumnComboBox1.DataSource = nwindDataSet.Customers


			Dim descriptor As New FilterDescriptor(Me.radMultiColumnComboBox1.DisplayMember, FilterOperator.StartsWith, String.Empty)
			Me.radMultiColumnComboBox1.EditorControl.FilterDescriptors.Add(descriptor)
			Me.radMultiColumnComboBox1.DropDownStyle = RadDropDownStyle.DropDown
			' Filtering END
		End Sub



		Private Sub OnCheckBoxRTL_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckRTL.ToggleStateChanged
			Me.radMultiColumnComboBox1.RightToLeft = If(Me.radCheckRTL.Checked, System.Windows.Forms.RightToLeft.Yes, System.Windows.Forms.RightToLeft.No)
		End Sub

		Private Sub OnCheckRotate_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckRotate.ToggleStateChanged
			Me.radMultiColumnComboBox1.DblClickRotate = Me.radCheckRotate.Checked
		End Sub

		Private Sub OnCheckAutoFilter_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckAutoFilter.ToggleStateChanged
			Me.radMultiColumnComboBox1.AutoFilter = Me.radCheckAutoFilter.Checked
		End Sub

	End Class
End Namespace