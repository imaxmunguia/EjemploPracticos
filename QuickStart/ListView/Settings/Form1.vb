Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ListView.Settings
	Public Partial Class Form1
		Inherits ListViewExamplesControl
		Public Sub New()
			InitializeComponent()

			Me.radGroupBoxDetailView.Visible = False
			Me.radGroupBoxIconView.Visible = False
			Me.radGroupBoxIconView.Location = Me.radGroupBoxDetailView.Location



			SyncSettings()
		End Sub

		Private Sub radDropDownListViewType_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListViewType.SelectedIndexChanged
			Select Case Me.radDropDownListViewType.Text
				Case "List View"
					Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView
					Exit Select
				Case "Icon View"
					Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
					Exit Select
				Case "Detail View"
					Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
					Exit Select
			End Select
		End Sub

		Private Sub radCheckBoxShowCheckboxes_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxShowCheckboxes.ToggleStateChanged
			Me.radListView1.ShowCheckBoxes = Me.radCheckBoxShowCheckboxes.Checked
		End Sub

		Private Sub radCheckBoxGroups_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxGroups.ToggleStateChanged
			Me.radListView1.ShowGroups = Me.radCheckBoxGroups.Checked
		End Sub

		Private Sub radCheckBoxArbWidth_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxArbWidth.ToggleStateChanged
			Me.radListView1.AllowArbitraryItemWidth = Me.radCheckBoxArbWidth.Checked
		End Sub

		Private Sub radCheckBoxArbHeight_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxArbHeight.ToggleStateChanged
			Me.radListView1.AllowArbitraryItemHeight = Me.radCheckBoxArbHeight.Checked
		End Sub

		Private Sub radCheckBoxFullRowSelect_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxFullRowSelect.ToggleStateChanged
			Me.radListView1.FullRowSelect = Me.radCheckBoxFullRowSelect.Checked
		End Sub

		Private Sub radCheckBoxColHeaders_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColHeaders.ToggleStateChanged
			Me.radListView1.ShowColumnHeaders = Me.radCheckBoxColHeaders.Checked
		End Sub

		Private Sub radCheckBoxColResize_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColResize.ToggleStateChanged
			Me.radListView1.AllowColumnResize = Me.radCheckBoxColResize.Checked
		End Sub

		Private Sub radCheckBoxColReorder_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColReorder.ToggleStateChanged
			Me.radListView1.AllowColumnReorder = Me.radCheckBoxColReorder.Checked
		End Sub

		Private Sub radCheckBoxColSort_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColSort.ToggleStateChanged
			Me.radListView1.EnableColumnSort = Me.radCheckBoxColSort.Checked
		End Sub

		Private Sub radSpinEditorHeaderHeight_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorHeaderHeight.ValueChanged
			Me.radListView1.HeaderHeight = CSng(Me.radSpinEditorHeaderHeight.Value)
		End Sub

		Private Sub radSpinEditorGroupIndent_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorGroupIndent.ValueChanged
			Me.radListView1.GroupIndent = CInt(Me.radSpinEditorGroupIndent.Value)
		End Sub

		Private Sub radSpinEditorItemSpacing_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorItemSpacing.ValueChanged
			Me.radListView1.ItemSpacing = CInt(Me.radSpinEditorItemSpacing.Value)
		End Sub

		Private Sub radSpinEditorItemWidth_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorItemWidth.ValueChanged
			Me.radListView1.ItemSize = New Size(CInt(Me.radSpinEditorItemWidth.Value), Me.radListView1.ItemSize.Height)
		End Sub

		Private Sub radSpinEditorItemHeight_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorItemHeight.ValueChanged
			Me.radListView1.ItemSize = New Size(Me.radListView1.ItemSize.Width, CInt(Me.radSpinEditorItemHeight.Value))
		End Sub

		Private Sub radSpinEditorGroupHeight_ValueChanged(sender As Object, e As EventArgs) Handles radSpinEditorGroupHeight.ValueChanged
			Me.radListView1.GroupItemSize = New Size(Me.radListView1.GroupItemSize.Width, CInt(Me.radSpinEditorGroupHeight.Value))
		End Sub

		Private Sub radDropDownList2_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownList2.SelectedIndexChanged
			If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView Then
				Me.radListView1.ListViewElement.ViewElement.Orientation = If((Me.radDropDownList2.Text = "Vertical"), Orientation.Vertical, Orientation.Horizontal)
			End If
		End Sub

		Private Sub radListView1_ViewTypeChanged(sender As Object, e As EventArgs) Handles radListView1.ViewTypeChanged
			Me.radGroupBoxDetailView.Visible = False
			Me.radGroupBoxIconView.Visible = False

			If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView Then
				Me.radGroupBoxDetailView.Visible = True
				Me.radListView1.ItemSize = New Size(200, 32)
			End If
			If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView Then
				Me.radGroupBoxIconView.Visible = True
				Me.radListView1.ItemSize = New Size(155, 46)
			End If
			If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView Then
				Me.radListView1.ItemSize = New Size(200, 32)
			End If

			SyncSettings()
		End Sub

		Private Sub SyncSettings()
			Me.radCheckBoxArbWidth.Checked = Me.radListView1.AllowArbitraryItemWidth
			Me.radCheckBoxArbHeight.Checked = Me.radListView1.AllowArbitraryItemHeight
			Me.radCheckBoxFullRowSelect.Checked = Me.radListView1.FullRowSelect

			Me.radSpinEditorItemSpacing.Value = Me.radListView1.ItemSpacing
			Me.radSpinEditorGroupIndent.Value = Me.radListView1.GroupIndent

			Me.radSpinEditorItemWidth.Value = Me.radListView1.ItemSize.Width
			Me.radSpinEditorItemHeight.Value = Me.radListView1.ItemSize.Height

			Me.radSpinEditorGroupHeight.Value = Me.radListView1.GroupItemSize.Height
		End Sub

		Public Overrides ReadOnly Property ContentControl() As Control
			Get
				Return Me.radPanel2
			End Get
		End Property
	End Class
End Namespace