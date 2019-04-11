Imports System
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class LegendItemElement
		Inherits LightVisualElement
		Private stack As StackLayoutElement
		Private box As LightVisualElement
		Private text As LightVisualElement

		Public Sub New(ByVal text As String, ByVal color As Color)
			Me.text.Text = text
			Me.box.BackColor = color
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			stack = New StackLayoutElement()
			stack.FitInAvailableSize = True
			stack.StretchHorizontally = False
			stack.StretchVertically = False
			stack.ShouldHandleMouseInput = False
			stack.NotifyParentOnMouseInput = True
			Me.Children.Add(stack)

			box = New LightVisualElement()
			box.DrawFill = True
			box.DrawBorder = True
			box.GradientStyle = GradientStyles.Solid
			box.BorderGradientStyle = GradientStyles.Solid
			box.BorderColor = Color.White
			box.MinSize = New System.Drawing.Size(15, 15)
			box.Padding = New System.Windows.Forms.Padding(4)
			box.StretchHorizontally = False
			box.StretchVertically = False
			box.ShouldHandleMouseInput = False
			box.NotifyParentOnMouseInput = True
			stack.Children.Add(box)

			text = New LightVisualElement()
			text.DrawFill = False
			text.DrawBorder = False
			text.ForeColor = Color.Black
			text.Font = New System.Drawing.Font("Segoe UI", 9.0f)
			text.TextAlignment = ContentAlignment.TopLeft
			text.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			text.StretchVertically = False
			text.StretchHorizontally = False
			text.ShouldHandleMouseInput = False
			text.NotifyParentOnMouseInput = True
			stack.Children.Add(text)
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = False
			Me.StretchVertically = False
			Me.ShouldHandleMouseInput = False
			Me.NotifyParentOnMouseInput = True
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim size As SizeF = MyBase.MeasureOverride(availableSize)
			Return size
		End Function
	End Class
End Namespace
