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

Namespace Telerik.Examples.WinControls.Editors.ComboBox.MusicCollection
	''' <summary>
	''' RadComboBox example: Music Collection
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()


			AddHandler cmbArtist.ItemDataBound, AddressOf cmbArtist_ItemDataBound
			AddHandler artistsBindingSource.CurrentItemChanged, AddressOf artistsBindingSource_CurrentItemChanged


			Me.songsTableAdapter.Fill(Me.musicCollectionDataSet.Songs)
			Me.artistsTableAdapter.Fill(Me.musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)

			Me.cmbArtist.SelectedIndex = -1
			Me.cmbAlbum.SelectedIndex = -1
			Me.cmbSong.SelectedIndex = -1

			Me.SelectedControl = Me.cmbArtist
		End Sub

		Private Sub artistsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim imageIndex As Integer = CInt(Fix((TryCast(Me.artistsBindingSource.Current, DataRowView))("ImageIndex")))
			If imageIndex >= 0 AndAlso imageIndex < Me.ArtistsLargeImageList.Images.Count Then
				Me.pictureBox.Image = Me.ArtistsLargeImageList.Images(imageIndex)
			End If
		End Sub

		Private Sub cmbArtist_ItemDataBound(ByVal sender As Object, ByVal e As ItemDataBoundEventArgs)
			Dim item As RadComboBoxItem = TryCast(e.DataBoundItem, RadComboBoxItem)
			item.TextImageRelation = TextImageRelation.ImageBeforeText
			Dim desc As PropertyDescriptor = TypeDescriptor.GetProperties(e.DataItem).Find("ImageIndex", False)
			item.ImageIndex = CInt(Fix(desc.GetValue(e.DataItem)))
		End Sub

		Private Sub cmbArtist_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbArtist.TextChanged
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub cmbAlbum_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAlbum.TextChanged
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub cmbSong_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSong.TextChanged
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
            Dim path As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "..\Resources\")

            radButton1.Image = Image.FromFile(System.IO.Path.Combine(path, "Sort Ascending.bmp"))
			AddHandler radButton1.ToolTipTextNeeded, AddressOf AnonymousMethod1
			AddHandler radButton1.MouseClick, AddressOf SortAsc
            radButton2.Image = Image.FromFile(System.IO.Path.Combine(path, "Sort Descending.bmp"))
			AddHandler radButton2.ToolTipTextNeeded, AddressOf AnonymousMethod2
			AddHandler radButton2.MouseClick, AddressOf SortDesc

		End Sub
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Ascending"
		End Sub
		Private Sub AnonymousMethod2(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Descending"
		End Sub


		'private void AddSortingButtons()
		'{
		'    StackLayoutPanel stackLayout = new StackLayoutPanel();
		'    stackLayout.Orientation = Orientation.Vertical;

		'    RadArrowButtonElement buttonAsc = new RadArrowButtonElement();
		'    //buttonAsc.AutoSize = false;
		'    buttonAsc.BackColor = Color.FromArgb( 16, 132, 192 );
		'    buttonAsc.MinSize = new Size( 10, 10 );
		'    buttonAsc.Direction = Telerik.WinControls.ArrowDirection.Down;
		'    buttonAsc.MouseUp += new MouseEventHandler( buttonAsc_MouseUp );

		'    RadArrowButtonElement buttonDesc = new RadArrowButtonElement();
		'    //buttonDesc.AutoSize = false;
		'    buttonDesc.BackColor = Color.FromArgb( 16, 132, 192 );
		'    buttonDesc.MinSize = new Size( 10, 10 );
		'    buttonDesc.Direction = Telerik.WinControls.ArrowDirection.Up;
		'    buttonDesc.MouseUp += new MouseEventHandler( buttonDesc_MouseUp );

		'    stackLayout.Children.Add( buttonDesc );
		'    stackLayout.Children.Add( buttonAsc );

		'    this.radPanel1.RootElement.Children[0].Children.Add( stackLayout );
		'}

		Private Sub SortDesc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " desc"
		End Sub

		Private Sub SortAsc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " asc"
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click

		End Sub
	End Class
End Namespace
