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

Namespace Telerik.Examples.WinControls.PageView.StripView.NewItem
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private strip As RadPageViewStripElement
		Private imageIndex As Integer

		#End Region

		#Region "Constructor/Initialization"

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)

			Me.strip = TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement)

			For i As Integer = 0 To 4
				Dim page As New RadPageViewPage()
				page.Text = PageViewImages.Names(i)
				page.Image = PageViewImages.Images(i)

				Me.radPageView1.Pages.Add(page)
			Next i

			AddHandler Me.radPageView1.NewPageRequested, AddressOf radPageView1_NewPageRequested

			Me.newItemVisibilityCombo.DataSource = System.Enum.GetValues(GetType(StripViewNewItemVisibility))
			Me.stripAlignCombo.DataSource = System.Enum.GetValues(GetType(StripViewAlignment))

			Me.newItemVisibilityCombo.SelectedValue = StripViewNewItemVisibility.End
			Me.stripAlignCombo.SelectedValue = Me.strip.StripAlignment

			Me.shrinkItemsCheck.Checked = True
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub radPageView1_NewPageRequested(ByVal sender As Object, ByVal e As EventArgs)
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
			Me.radPageView1.ViewElement.EnsureItemVisible(Me.strip.NewItem)
		End Sub

		Private Sub newItemVisibilityCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles newItemVisibilityCombo.SelectedIndexChanged
			If e.Position <> -1 Then
				Me.strip.NewItemVisibility = CType(Me.newItemVisibilityCombo.SelectedValue, StripViewNewItemVisibility)
			End If
		End Sub

		Private Sub stripAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles stripAlignCombo.SelectedIndexChanged
			If e.Position <> -1 Then
				Me.strip.StripAlignment = CType(Me.stripAlignCombo.SelectedValue, StripViewAlignment)
			End If
		End Sub

		Private Sub shrinkItemsCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles shrinkItemsCheck.ToggleStateChanged
			Me.strip.ItemFitMode = If(Me.shrinkItemsCheck.Checked, StripViewItemFitMode.Shrink, StripViewItemFitMode.None)
		End Sub

		#End Region
	End Class
End Namespace
