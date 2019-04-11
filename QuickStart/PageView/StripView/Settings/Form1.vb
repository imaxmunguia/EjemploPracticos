Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.StripView.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private strip As RadPageViewStripElement
		Private imageIndex As Integer

		#End Region

		#Region "Constructor/Initialization"

		Public Sub New()
			InitializeComponent()

			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)

			Me.strip = TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement)
			Me.strip.ItemDragMode = PageViewItemDragMode.Preview

			ExamplesForm.FillComboFromEnum(Me.stripAlignCombo, GetType(StripViewAlignment), Me.strip.StripAlignment)
			ExamplesForm.FillComboFromEnum(Me.itemAlignCombo, GetType(StripViewItemAlignment), Me.strip.ItemAlignment)
			ExamplesForm.FillComboFromEnum(Me.fitModeCombo, GetType(StripViewItemFitMode), Me.strip.ItemFitMode)
			ExamplesForm.FillComboFromEnum(Me.sizeModeCombo, GetType(PageViewItemSizeMode), Me.strip.ItemSizeMode)
			ExamplesForm.FillComboFromEnum(Me.orientationCombo, GetType(PageViewContentOrientation), Me.strip.ItemContentOrientation)

			Me.spacingSpin.Value = Me.strip.ItemSpacing

			For Each page As RadPageViewPage In Me.radPageView1.Pages
				page.Image = PageViewImages.Images(Me.imageIndex)
				Me.imageIndex += 1
				page.Controls.Add(PageViewLabels.CreateLabel())
			Next page

			AddHandler Me.radPageView1.NewPageRequested, AddressOf radPageView1_NewPageRequested
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ExamplesForm.CenterControlOnParent(Me.radPageView1)

			MyBase.OnLoad(e)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		#End Region

		#Region "Event Handlers"

		Private Sub radPageView1_NewPageRequested(ByVal sender As Object, ByVal e As EventArgs)
			Me.addPageButton_Click(Nothing, EventArgs.Empty)
		End Sub

		Private Sub stripAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles stripAlignCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.stripAlignCombo.SelectedItem, RadListDataItem)
			Me.strip.StripAlignment = CType(item.Value, StripViewAlignment)
		End Sub

		Private Sub itemAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles itemAlignCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.itemAlignCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemAlignment = CType(item.Value, StripViewItemAlignment)
		End Sub

		Private Sub fitModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles fitModeCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.fitModeCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemFitMode = CType(item.Value, StripViewItemFitMode)
		End Sub

		Private Sub sizeModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles sizeModeCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.sizeModeCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemSizeMode = CType(item.Value, PageViewItemSizeMode)
		End Sub

		Private Sub orientationCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles orientationCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.orientationCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemContentOrientation = CType(item.Value, PageViewContentOrientation)
		End Sub

		Private Sub spacingSpin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spacingSpin.ValueChanged
			strip.ItemSpacing = CInt(Fix(Me.spacingSpin.Value))
		End Sub

		Private Sub addPageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addPageButton.Click
			Dim page As New RadPageViewPage()
			page.Text = "Page " & (strip.Items.Count + 1)

			If Me.imageIndex = PageViewImages.Images.Length Then
				Me.imageIndex = 0
			End If

			page.Image = PageViewImages.Images(Me.imageIndex)
			Me.imageIndex += 1
			page.Controls.Add(PageViewLabels.CreateLabel())

			Me.radPageView1.Pages.Add(page)
			Me.radPageView1.SelectedPage = page
		End Sub

		#End Region
	End Class
End Namespace
