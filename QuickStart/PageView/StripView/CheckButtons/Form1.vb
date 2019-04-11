Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Imports View = Telerik.WinControls.UI.RadPageView

Namespace Telerik.Examples.WinControls.PageView.StripView.CheckButtons
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Static"

		Private Const themeName As String = "StripViewCheckButtons"


		#End Region

		#Region "Fields"

		Private view As View
		Private strip As RadPageViewStripElement

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)

			Me.view = New Telerik.WinControls.UI.RadPageView()
			Me.view.Size = New Size(400, 300)
			Me.view.Anchor = AnchorStyles.None
			Me.view.Parent = Me
			Me.strip = TryCast(Me.view.ViewElement, RadPageViewStripElement)
			AddHandler view.SelectedPageChanged, AddressOf view_SelectedPageChanged
            Me.view.ThemeName = themeName

			PageViewLabels.currIndex = 0

			For i As Integer = 0 To 9
				Dim page As New RadPageViewPage()
				page.Text = PageViewImages.Names(i)
				page.Image = PageViewImages.Images(i)
				page.Controls.Add(PageViewLabels.CreateLabel())

				Me.view.Pages.Add(page)
			Next i

			Me.strip.StripButtons = StripViewButtons.Scroll Or StripViewButtons.ItemList
			Me.enableAnimationCheck.Checked = strip.AnimatedStripScrolling
		End Sub

		Shared Sub New()
            ThemeResolutionService.LoadPackageResource("StripViewCheckButtons.tssp")
		End Sub

		#End Region

		#Region "Overrides"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			ExamplesForm.FillComboFromEnum(Me.animationTypeCombo, GetType(RadEasingType), Me.strip.StripScrollingAnimation)
			ExamplesForm.CenterControlOnParent(Me.view)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return themeName
		End Function

		#End Region

		#Region "Event Handlers"

		Private Sub view_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.strip.Header.Image = Me.view.SelectedPage.Image
		End Sub

		Private Sub enableAnimationCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles enableAnimationCheck.ToggleStateChanged
			Me.strip.AnimatedStripScrolling = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub animationTypeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles animationTypeCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.animationTypeCombo.SelectedItem, RadListDataItem)
			Me.strip.StripScrollingAnimation = CType(item.Value, RadEasingType)
		End Sub

		Private Sub shrinkItemsCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles shrinkItemsCheck.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.strip.ItemFitMode = StripViewItemFitMode.Shrink
			Else
				Me.strip.ItemFitMode = StripViewItemFitMode.None
			End If
		End Sub

		#End Region
	End Class
End Namespace
