Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Carousel.CarouselSettings
	Partial Public Class Form1
		Inherits ShapedForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radComboAutoLoop.DataSource = System.Enum.GetNames(GetType(AutoLoopDirections))
			Me.radTitleBar.TitleBarElement.SetValue(RadFormElement.IsFormActiveProperty, True)
			Me.radCarouselDemo.AutoLoopDirection = AutoLoopDirections.Forward
			Me.radCarouselDemo.EnableLooping = True
			Me.radCheckEnableLooping.Checked = Me.radCarouselDemo.EnableLooping
			Me.radSpinRestoreDuration.Value = Me.radCarouselDemo.AutoLoopPauseInterval
			Me.radSpinVisibleElements.Value = Me.radCarouselDemo.VisibleItemCount
			Me.radCheckAutoLoop.Checked = Me.radCarouselDemo.EnableAutoLoop
			Me.radCheckVirtualMode.Checked = Me.radCarouselDemo.VirtualMode
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckVirtualMode.ToggleStateChanged
			Me.radCarouselDemo.VirtualMode = Me.radCheckVirtualMode.Checked
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckAutoLoop.ToggleStateChanged
			Me.radCarouselDemo.EnableAutoLoop = Me.radCheckAutoLoop.Checked
		End Sub

		Private Sub radComboAutoLoop_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboAutoLoop.SelectedIndexChanged
			Dim direction As AutoLoopDirections = CType(Me.radComboAutoLoop.SelectedIndex, AutoLoopDirections)
			Me.radCarouselDemo.AutoLoopDirection = direction
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinRestoreDuration.ValueChanged
			Me.radCarouselDemo.AutoLoopPauseInterval = CInt(Fix(Me.radSpinRestoreDuration.Value))
		End Sub

		Private Sub OnVisibleItemsCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinVisibleElements.ValueChanged
			Dim itemCount As Integer

			If Integer.TryParse(Me.radSpinVisibleElements.Value.ToString(), itemCount) Then
				Me.radCarouselDemo.VisibleItemCount = itemCount
			End If
		End Sub

		Private Sub OnEnableLooping_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckEnableLooping.ToggleStateChanged
			Me.radCarouselDemo.EnableLooping = Me.radCheckEnableLooping.Checked
		End Sub
	End Class
End Namespace