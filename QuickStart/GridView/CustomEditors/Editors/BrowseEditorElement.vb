Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.CustomEditors
	Public Class BrowseEditorElement
		Inherits LightVisualElement
		Private textBox_Renamed As RadTextBoxItem
		Private button_Renamed As RadButtonElement

		Public ReadOnly Property TextBox() As RadTextBoxItem
			Get
				Return Me.textBox_Renamed
			End Get
		End Property

		Public ReadOnly Property Button() As RadButtonElement
			Get
				Return Me.button_Renamed
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			textBox_Renamed = New RadTextBoxItem()
			textBox_Renamed.RouteMessages = False
			button_Renamed = New RadButtonElement("...")
			button_Renamed.Padding = New Padding(2, 0, 2, 0)
			Me.Children.Add(textBox_Renamed)
			Me.Children.Add(button_Renamed)
		End Sub

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim clientRect As RectangleF = GetClientRectangle(finalSize)
			Dim buttonRect As New RectangleF(clientRect.Right - button_Renamed.DesiredSize.Width, clientRect.Top, button_Renamed.DesiredSize.Width, clientRect.Height)
			Dim textRect As New RectangleF(clientRect.Left, clientRect.Top + (clientRect.Height - textBox_Renamed.DesiredSize.Height) / 2, buttonRect.Left - clientRect.Left - 2, textBox_Renamed.DesiredSize.Height)

			For Each element As RadElement In Me.Children
				If element Is Me.textBox_Renamed Then
					element.Arrange(textRect)
				ElseIf element Is Me.button_Renamed Then
					element.Arrange(buttonRect)
				Else
					ArrangeElement(element, finalSize)
				End If
			Next element

			Return finalSize
		End Function
	End Class
End Namespace
