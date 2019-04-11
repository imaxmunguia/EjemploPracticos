Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.RibbonBar.ResizingDemo
	Partial Class Form1
		Inherits RadRibbonForm
		Private recentDocsList As List(Of String) = New List(Of String)(New String() {"<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>" })

		Private recentPlacesList As List(Of String) = New List(Of String)(New String(){ "<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>" })

		Public Sub New()
			InitializeComponent()

			AddHandler recentDocumentsListControl.VisualItemFormatting, AddressOf recentDocumentsListControl_VisualItemFormatting
			AddHandler recentDocumentsListControl.CreatingVisualListItem, AddressOf recentDocumentsListControl_CreatingVisualListItem
			recentDocumentsListControl.DataSource = recentDocsList

			AddHandler recentPlacesListControl.VisualItemFormatting, AddressOf recentPlacesListControl_VisualItemFormatting
			AddHandler recentPlacesListControl.CreatingVisualListItem, AddressOf recentPlacesListControl_CreatingVisualListItem
			recentPlacesListControl.DataSource = recentPlacesList

			Me.AllowAero = False

            Me.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radRibbonBar1.RibbonBarElement.TabStripElement.Items(0)

			Me.MinimumSize = New Size(210, 140)
			Me.DoubleBuffered = True
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.ApplyGalleryStyle()
		End Sub

		Private Sub ApplyGalleryStyle()
			For Each item As RadGalleryItem In Me.radGalleryElement1.Items
				Dim childrenCount As Integer = item.Children.Count

				If childrenCount > 0 Then
					Dim element As RadElement = item.Children(0)

					If TypeOf element Is FillPrimitive Then
						Dim fillPrimitive As FillPrimitive = TryCast(element, FillPrimitive)
						fillPrimitive.BackColor = Color.White
					End If
				End If
			Next item
		End Sub

		Private Sub recentPlacesListControl_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New PinnedListVisualItem()
		End Sub

		Private Sub recentPlacesListControl_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			args.VisualItem.Image = My.Resources.open32
		End Sub

		Private Sub recentDocumentsListControl_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			args.VisualItem.Image = My.Resources.plain_text
		End Sub

		Private Sub recentDocumentsListControl_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New PinnedListVisualItem()
		End Sub

		Private Sub flowLayoutPanel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles flowLayoutPanel2.Paint 
			e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, flowLayoutPanel2.Width - 1, flowLayoutPanel2.Height - 1)

			MyBase.OnPaint(e)
		End Sub

		Private Sub radRibbonBarBackstageView1_ItemClicked(ByVal sender As Object, ByVal e As BackstageItemEventArgs) handles radRibbonBarBackstageView1.ItemClicked
			If TypeOf e.Item Is BackstageButtonItem Then
				Me.radRibbonBarBackstageView1.HidePopup()
			End If
		End Sub
	End Class

	Public Class PinnedListVisualItem
		Inherits RadListVisualItem
		Private pinImage As RadButtonElement

		Public Sub New()
			AdjustVisibility()
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			pinImage = New RadButtonElement()
			pinImage.Image = My.Resources.pin
			pinImage.Alignment = ContentAlignment.MiddleCenter
			pinImage.ImageAlignment = ContentAlignment.MiddleCenter
			pinImage.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			pinImage.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			AddHandler pinImage.RadPropertyChanged, AddressOf pinImage_RadPropertyChanged
			Me.Children.Add(pinImage)
		End Sub

		Private Sub pinImage_RadPropertyChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.RadPropertyChangedEventArgs)
			If e.Property is ContainsMouseProperty Then
				AdjustVisibility()
			End If
		End Sub

		Private Sub AdjustVisibility()
			If pinImage.ContainsMouse Then
				pinImage.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
				pinImage.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Else
				pinImage.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Hidden
				pinImage.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			End If
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			pinImage.Measure(availableSize)
			Return MyBase.MeasureOverride(availableSize)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			finalSize.Width -= 36
			MyBase.ArrangeOverride(finalSize)
			finalSize.Width += 36
			pinImage.Arrange(New RectangleF(finalSize.Width - 36, 0, 36, 36))

			Return finalSize
		End Function

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadListVisualItem)
			End Get
		End Property
	End Class
End Namespace