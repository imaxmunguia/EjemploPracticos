Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports System

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.FirstLook
    Partial Public Class Form1

        Private itemsText As String() = New String() {"(NONE)", "(NONE)", "(NONE)", "AAC File", "ASA", "ASAX", _
         "ASCX", "ASPX", "MP3", "MPEG"}
        Private itemsDescriptionText As String() = New String() {"AudioCD", "File Folder", "Help and Support Center protocol", "Quicktime File", "ASA File", "ASP.NET Server Application", _
         "ASP.NET User Control", "ASP.NET Server Page", "Winamp Media File", "Movie Clip"}

        Public Sub New()
            InitializeComponent()
            MyBase.SetEnabledQsfbButton(QSFButtons.TransparentBackground, False)
            Me.radListBoxDemo.ItemHeight = 50
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.radDropDownList1.SelectedIndex = 0
            Me.radComboSelectionMode.SelectedIndex = 1
            Me.radListBoxDemo.SelectedIndex = 0
            Me.radComboSortStyle.SelectedIndex = 2
        End Sub

        Private Sub ClearSelectedItemControls()
            Me.radComboImageAlign.SelectedItem = Nothing
            Me.radComboTextAlign.SelectedItem = Nothing
            Me.radComboTextImage.SelectedItem = Nothing
            Me.radComboTextOrientation.SelectedItem = Nothing
        End Sub

        Private Sub radListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radListBoxDemo.SelectedIndexChanged
            Me.UpdateSettingsControls()
        End Sub

        Private Sub UpdateSettingsControls()
            For Each item As RadListDataItem In radListBoxDemo.SelectedItems
                Me.radComboImageAlign.SelectedIndex = Me.radComboImageAlign.ListElement.FindString(item.ImageAlignment.ToString())
                Me.radComboTextAlign.SelectedIndex = Me.radComboTextAlign.ListElement.FindString(item.TextAlignment.ToString())
                Me.radComboTextImage.SelectedIndex = Me.radComboTextImage.ListElement.FindString(item.TextImageRelation.ToString())
                Me.radComboTextOrientation.SelectedIndex = Me.radComboTextOrientation.ListElement.FindString(item.TextOrientation.ToString())
            Next
        End Sub

        Private Sub comboImageAlign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboImageAlign.SelectedIndexChanged
            Dim item As RadListDataItem = radListBoxDemo.SelectedItem
            If item Is Nothing Then
                Return
            End If

            Dim comboItem As RadListDataItem = Me.radComboImageAlign.SelectedItem
            Select Case comboItem.Text
                Case "TopLeft"
                    item.ImageAlignment = ContentAlignment.TopLeft
                    Exit Select
                Case "TopCenter"
                    item.ImageAlignment = ContentAlignment.TopCenter
                    Exit Select
                Case "TopRight"
                    item.ImageAlignment = ContentAlignment.TopRight
                    Exit Select
                Case "MiddleLeft"
                    item.ImageAlignment = ContentAlignment.MiddleLeft
                    Exit Select
                Case "MiddleCenter"
                    item.ImageAlignment = ContentAlignment.MiddleCenter
                    Exit Select
                Case "MiddleRight"
                    item.ImageAlignment = ContentAlignment.MiddleRight
                    Exit Select
                Case "BottomLeft"
                    item.ImageAlignment = ContentAlignment.BottomLeft
                    Exit Select
                Case "BottomCenter"
                    item.ImageAlignment = ContentAlignment.BottomCenter
                    Exit Select
                Case "BottomRight"
                    item.ImageAlignment = ContentAlignment.BottomRight
                    Exit Select
            End Select
        End Sub

        Private Sub comboTextAlign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboTextAlign.SelectedIndexChanged
            Dim item As RadListDataItem = radListBoxDemo.SelectedItem
            If item Is Nothing Then
                Return
            End If

            Dim comboItem As RadListDataItem = Me.radComboTextAlign.SelectedItem
            Select Case comboItem.Text
                Case "TopLeft"
                    item.TextAlignment = ContentAlignment.TopLeft
                    Exit Select
                Case "TopCenter"
                    item.TextAlignment = ContentAlignment.TopCenter
                    Exit Select
                Case "TopRight"
                    item.TextAlignment = ContentAlignment.TopRight
                    Exit Select
                Case "MiddleLeft"
                    item.TextAlignment = ContentAlignment.MiddleLeft
                    Exit Select
                Case "MiddleCenter"
                    item.TextAlignment = ContentAlignment.MiddleCenter
                    Exit Select
                Case "MiddleRight"
                    item.TextAlignment = ContentAlignment.MiddleRight
                    Exit Select
                Case "BottomLeft"
                    item.TextAlignment = ContentAlignment.BottomLeft
                    Exit Select
                Case "BottomCenter"
                    item.TextAlignment = ContentAlignment.BottomCenter
                    Exit Select
                Case "BottomRight"
                    item.TextAlignment = ContentAlignment.BottomRight
                    Exit Select
            End Select
        End Sub

        Private Sub comboTextImageRel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboTextImage.SelectedIndexChanged
            Dim item As RadListDataItem = radListBoxDemo.SelectedItem
            If item Is Nothing Then
                Return
            End If
            Dim comboItem As RadListDataItem = Me.radComboTextImage.SelectedItem
            Select Case comboItem.Text
                Case "ImageAboveText"
                    If True Then
                        item.TextImageRelation = TextImageRelation.ImageAboveText
                        Exit Select
                    End If
                Case "ImageBeforeText"
                    If True Then
                        item.TextImageRelation = TextImageRelation.ImageBeforeText
                        Exit Select
                    End If
                Case "TextAboveImage"
                    If True Then
                        item.TextImageRelation = TextImageRelation.TextAboveImage
                        Exit Select
                    End If
                Case "TextBeforeImage"
                    If True Then
                        item.TextImageRelation = TextImageRelation.TextBeforeImage
                        Exit Select
                    End If
                Case "Overlay"
                    If True Then
                        item.TextImageRelation = TextImageRelation.Overlay
                        Exit Select
                    End If
            End Select
        End Sub

        Private Sub comboTextOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboTextOrientation.SelectedIndexChanged
            Dim item As RadListDataItem = radListBoxDemo.SelectedItem

            Dim comboItem As RadListDataItem = Me.radComboTextOrientation.SelectedItem
            If item IsNot Nothing Then
                If comboItem.Text = "Vertical" Then
                    item.TextOrientation = Orientation.Vertical
                Else
                    item.TextOrientation = Orientation.Horizontal
                End If
            End If
        End Sub

        Private Sub comboSelectionMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboSelectionMode.SelectedIndexChanged
            radListBoxDemo.SelectionMode = CType(Me.radComboSelectionMode.SelectedIndex, SelectionMode)
        End Sub

        Private Sub comboSortStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboSortStyle.SelectedIndexChanged
            Select Case Me.radComboSortStyle.SelectedText
                Case "Ascending"
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
                    Exit Select
                Case "Descending"
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending
                    Exit Select
                Case "None"
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub OnSortStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radComboSortStyle.SelectedIndexChanged
            If Me.radComboSortStyle.SelectedItem.Text = SortStyle.Ascending.ToString() Then
                Me.radListBoxDemo.SortStyle = SortStyle.Ascending
            ElseIf Me.radComboSortStyle.SelectedItem.Text = SortStyle.Descending.ToString() Then
                Me.radListBoxDemo.SortStyle = SortStyle.Descending
            Else
                Me.radListBoxDemo.SortStyle = SortStyle.None
            End If
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownList1.SelectedIndexChanged
            Me.radListBoxDemo.Items.Clear()
            Dim item As RadListDataItem
            Dim isRadListDataItems As Boolean = Me.radDropDownList1.SelectedItem.Text = "RadListDataItems"

            For i As Integer = 0 To 9
                item = If(isRadListDataItems, New RadListDataItem(), New DescriptionTextListDataItem())
                item.Text = itemsText(i)
                item.Image = imageList1.Images(i)
                If Not isRadListDataItems Then
                    DirectCast(item, DescriptionTextListDataItem).DescriptionText = itemsDescriptionText(i)
                End If
                Me.radListBoxDemo.Items.Add(item)
            Next

            Me.radListBoxDemo.SelectedIndex = 0
            Me.radGroupItem.Enabled = isRadListDataItems
        End Sub
    End Class
End Namespace
