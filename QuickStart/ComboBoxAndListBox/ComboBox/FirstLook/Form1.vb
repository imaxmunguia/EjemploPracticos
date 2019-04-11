Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports System.IO
Imports Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.FirstLook
	''' <summary>
	''' RadDropDownList example: Music Collection
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			me.BackColor = Color.Transparent
			Me.cmbArtist.DropDownAnimationEnabled = False
			Me.cmbArtist.AutoSizeItems = True
			AddHandler cmbArtist.ItemDataBound, AddressOf cmbArtist_ItemDataBound
			Me.cmbArtist.DropDownMinSize = New Size(0, 200)
			AddHandler artistsBindingSource.CurrentItemChanged, AddressOf artistsBindingSource_CurrentItemChanged
			Me.buttonSortAscending.ThemeClassName = String.Empty
			Me.buttonSortDescending.ThemeClassName = String.Empty

			Me.songsTableAdapter.Fill(Me.musicCollectionDataSet.Songs)
			Me.artistsTableAdapter.Fill(Me.musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)

			Me.SelectedControl = Me.cmbArtist
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)

			Me.cmbArtist.SelectedIndex = 0
			Me.cmbArtist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbAlbum.SelectedIndex = 0
			Me.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbSong.SelectedIndex = 0
			Me.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			If Me.radPanelDemoHolder IsNot Nothing Then
				Dim xCoord As Single = (CSng(Me.Width - Me.radPanelDemoHolder.Width)) / 2
				Dim yCoord As Single = (CSng(Me.Height - Me.radPanelDemoHolder.Height)) / 2

				Me.radPanelDemoHolder.Location = Point.Round(New PointF(xCoord, yCoord))
			End If

			MyBase.OnSizeChanged(e)
		End Sub

		Private Sub artistsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim imageIndex As Integer = CInt(Fix((TryCast(Me.artistsBindingSource.Current, DataRowView))("ImageIndex")))

			If imageIndex >= 0 AndAlso imageIndex < Me.ArtistsLargeImageList.Images.Count Then
				Me.pictureBox.Image = Me.ArtistsLargeImageList.Images(imageIndex)
			End If

			Me.cmbAlbum.SelectedIndex = 0
			Me.cmbSong.SelectedIndex = 0
		End Sub

		Private Sub cmbArtist_ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs)
			Dim item As RadListDataItem = args.NewItem
			Dim dataBoundItem As Object = item.DataBoundItem
			item.TextImageRelation = TextImageRelation.ImageBeforeText
			Dim desc As PropertyDescriptor = TypeDescriptor.GetProperties(dataBoundItem).Find("ImageIndex", False)
			item.Image = Me.cmbArtist.ImageList.Images(System.Convert.ToInt32(desc.GetValue(dataBoundItem)))
		End Sub

		Private Sub cmbArtist_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cmbArtist.SelectedIndexChanged
            Dim selectedSongInfo As New StringBuilder()
            selectedSongInfo.AppendLine(Me.cmbArtist.Text)
            selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
            selectedSongInfo.AppendLine(Me.cmbSong.Text)

            Me.lblSelectedSong.Text = selectedSongInfo.ToString()
        End Sub
        Private Sub cmbArtist_SelectedIndexChanged2(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cmbAlbum.SelectedIndexChanged
            Dim selectedSongInfo As New StringBuilder()
            selectedSongInfo.AppendLine(Me.cmbArtist.Text)
            selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
            selectedSongInfo.AppendLine(Me.cmbSong.Text)

            Me.lblSelectedSong.Text = selectedSongInfo.ToString()
        End Sub

        Private Sub cmbArtist_SelectedIndexChanged3(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cmbSong.SelectedIndexChanged
            Dim selectedSongInfo As New StringBuilder()
            selectedSongInfo.AppendLine(Me.cmbArtist.Text)
            selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
            selectedSongInfo.AppendLine(Me.cmbSong.Text)

            Me.lblSelectedSong.Text = selectedSongInfo.ToString()
        End Sub

		Private Sub cmbAlbum_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub cmbSong_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.AddSortingButtons()
		End Sub

		Private Sub AddSortingButtons()
			AddHandler buttonSortAscending.ToolTipTextNeeded, AddressOf buttonSortAscending_ToolTipTextNeeded
			AddHandler buttonSortAscending.MouseClick, AddressOf SortAsc
			AddHandler buttonSortDescending.ToolTipTextNeeded, AddressOf buttonSortDescending_ToolTipTextNeeded
			AddHandler buttonSortDescending.MouseClick, AddressOf SortDesc
		End Sub

		Private Sub buttonSortDescending_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Descending"
		End Sub

		Private Sub buttonSortAscending_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Ascending"
		End Sub

		Private Sub SortDesc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " desc"
		End Sub

		Private Sub SortAsc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " asc"
		End Sub
	End Class
End Namespace
