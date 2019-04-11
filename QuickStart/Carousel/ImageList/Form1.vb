Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Carousel.ImageList
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			AddHandler radCarouselDemo.BackColorChanged, AddressOf radCarousel1_BackColorChanged
			AddHandler radCarouselDemo.Click, AddressOf radCarousel1_Click
			AddHandler radCarouselDemo.ItemDataBound, AddressOf CarouselElement_ItemDataBound
			AddHandler radCarouselDemo.Items.ItemsChanged, AddressOf Items_ItemsChanged
			AddHandler radCarouselDemo.SelectedIndexChanged, AddressOf CarouselElement_SelectedIndexChanged
			AddHandler radCarouselDemo.SelectedItemChanged, AddressOf radCarousel1_SelectedItemChanged
			AddHandler radCarouselDemo.SelectedValueChanged, AddressOf radCarousel1_SelectedValueChanged

			Me.radCarouselDemo.ImageList = Me.imageList4
			Me.radCarouselDemo.VisibleItemCount = 7
			CreateCarouselItems()

			Me.radRadioBezier.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radCarouselDemo.NavigationButtonsOffset = New Size(10,10)
		End Sub

		Private Sub CreateCarouselItems()
			For Each image As Image In Me.radCarouselDemo.ImageList.Images
				Dim carouselItem As New RadButtonElement()
				carouselItem.ImageAlignment = ContentAlignment.MiddleCenter
				carouselItem.TextAlignment = ContentAlignment.MiddleCenter
				carouselItem.DisplayStyle = DisplayStyle.Image
				carouselItem.TextImageRelation = TextImageRelation.ImageAboveText
				carouselItem.ShowBorder = False

				carouselItem.ForeColor = Color.WhiteSmoke
				carouselItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit

				carouselItem.BackColor = Color.YellowGreen
				carouselItem.Image = New Bitmap(image, image.Size.Width/2, image.Size.Height/2)

				Me.radCarouselDemo.Items.Add(carouselItem)
			Next image
		End Sub

		Private Sub radCarousel1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddTextToListBox("SelectedValueChanged")
		End Sub

		Private Sub radCarousel1_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddTextToListBox("SelectedItemChanged " & radCarouselDemo.SelectedItem.ToString())
		End Sub

		Private Sub CarouselElement_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddTextToListBox("SelectedIndexChanged " & radCarouselDemo.SelectedIndex.ToString())
		End Sub

		Private Sub Items_ItemsChanged(ByVal changed As RadItemCollection, ByVal target As RadItem, ByVal operation As ItemsChangeOperation)
			If target IsNot Nothing Then
				Me.AddTextToListBox(String.Format("Element {0} is {1}",target.ToString(),operation.ToString()))
			Else
				Me.AddTextToListBox(String.Format("Element is {0}",operation.ToString()))
			End If
		End Sub

		Private Sub CarouselElement_ItemDataBound(ByVal sender As Object, ByVal e As ItemDataBoundEventArgs)
			Me.AddTextToListBox("ItemDataBound")
		End Sub

		Private Sub radCarousel1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddTextToListBox("Click")
		End Sub

		Private Sub radCarousel1_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddTextToListBox("BackColorChanged")
		End Sub

		Private Sub AddTextToListBox(ByVal text As String)
			Dim label As New RadListDataItem()
			label.Text = String.Format("{0} {1}", text, DateTime.Now.ToString())
			AddTextToListBox(label)
		End Sub

		Private Sub AddTextToListBox(ByVal item As RadListDataItem)
			If radListEvents.IsDisposed Then
				Return
			End If

			If radListEvents.Items.Count > 40 Then
				radListEvents.Items.Clear()
			End If
			If radListEvents.RootElement.ElementState <> ElementState.Loaded Then
				Return
			End If

			radListEvents.Items.Add(item)
			radListEvents.ScrollToItem(item)
		End Sub

		Private Sub radSpinReflection(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
			Me.radCarouselDemo.ItemReflectionPercentage = CDbl(radSpinEditor1.Value)
		End Sub

		Private Sub radCheckEnableLooping_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			Me.radCarouselDemo.EnableLooping = Not Me.radCarouselDemo.EnableLooping
		End Sub

		Private Sub radCheckAutoLoop_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox2.ToggleStateChanged
			Me.radCarouselDemo.EnableAutoLoop = Not Me.radCarouselDemo.EnableAutoLoop
		End Sub

		Private Sub OnRadRadioPath_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioBezier.ToggleStateChanged
			Select Case Me.radRadioBezier.ToggleState
				Case ToggleState.On
					Dim carouselPath As New CarouselBezierPath()
					carouselPath.CtrlPoint1 = New Telerik.WinControls.UI.Point3D(125, 150, 400)
					carouselPath.CtrlPoint2 = New Telerik.WinControls.UI.Point3D(64, -80, -200)
					carouselPath.FirstPoint = New Telerik.WinControls.UI.Point3D(10, 10, -0)
					carouselPath.LastPoint = New Telerik.WinControls.UI.Point3D(19, 80, -100)
					carouselPath.ZScale = 200

					Me.radCarouselDemo.CarouselPath = carouselPath
				Case ToggleState.Off
					Dim ellipsePath As New CarouselEllipsePath()
					ellipsePath.Center = New Telerik.WinControls.UI.Point3D(50, 47, 0)
					ellipsePath.FinalAngle = 270
					ellipsePath.InitialAngle = 270
					ellipsePath.U = New Telerik.WinControls.UI.Point3D(31, -21, 0)
					ellipsePath.V = New Telerik.WinControls.UI.Point3D(0, 22, 200)
					ellipsePath.ZScale = 400
					Me.radCarouselDemo.CarouselPath = ellipsePath
			End Select
		End Sub
	End Class
End Namespace