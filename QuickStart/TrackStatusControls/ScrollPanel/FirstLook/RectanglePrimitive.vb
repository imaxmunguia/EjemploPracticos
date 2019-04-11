Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Telerik.WinControls.Paint
Imports System.ComponentModel

Namespace Telerik.WinControls.Primitives
	''' <summary>Represents a rectangle that is drawn on the sceen.</summary>
	Public Class RectanglePrimitive
		Inherits BasePrimitive
		''' <summary><para>Initializes a new instance of the RectanglePrimitive class.</para></summary>
		Public Sub New()
			Me.AutoSizeMode = RadAutoSizeMode.Auto
		End Sub

		''' <summary>Draws the primitive on the screen.</summary>
		Public Overrides Sub PaintPrimitive(ByVal graphics As IGraphics, ByVal angle As Single, ByVal scale As SizeF)
			graphics.DrawRectangle(New Rectangle(0, 0, Size.Width - 1, Size.Height - 1), ForeColor)
		End Sub
	End Class
End Namespace