Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ListView.CustomItems
	Public Partial Class Form1
		Inherits ListViewExamplesControl
		Public Sub New()
			InitializeComponent()

			Me.radListView1.ItemSize = New Size(200, 300)
			Me.radListView1.AllowArbitraryItemHeight = True
			Me.radListView1.ItemSpacing = 10
			Me.radListView1.EnableKineticScrolling = True

			Me.radListView1.ListViewElement.ViewElement.ViewElement.Margin = New Padding(0, 10, 0, 10)
			Me.radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal
		End Sub

		Private Sub radListView1_VisualItemCreating(sender As Object, e As Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs) Handles RadListView1.VisualItemCreating
			e.VisualItem = New CustomVisualItem()
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
			Me.albumsDataTableTableAdapter.Fill(Me.musicCollectionDataSet._AlbumsDataTable)
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged 
			Me.radListView1.EnableKineticScrolling = Me.radCheckBox1.Checked
		End Sub

		Public Overrides ReadOnly Property ContentControl() As Control
			Get
				Return Me.radListView1
			End Get
		End Property

	End Class
End Namespace
