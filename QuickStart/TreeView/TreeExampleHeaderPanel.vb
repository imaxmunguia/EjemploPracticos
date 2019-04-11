Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Drawing

Namespace Telerik.Examples
	Public Class TreeExampleHeaderPanel
		Inherits RadPanel
		Protected Overrides Sub OnLoad(ByVal desiredSize As Size)
			MyBase.OnLoad(desiredSize)

			Me.PanelElement.PanelFill.BackColor = Color.FromArgb(220, 238, 253)
			Me.PanelElement.PanelFill.BackColor2 = Color.FromArgb(170, 207, 253)
			Me.PanelElement.PanelFill.NumberOfColors = 2
			Me.PanelElement.PanelFill.GradientStyle = Telerik.WinControls.GradientStyles.Linear
			Me.PanelElement.PanelBorder.BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
			Me.PanelElement.PanelBorder.TopColor = Color.FromArgb(61, 107, 192)
			Me.PanelElement.PanelBorder.LeftColor = Color.FromArgb(61, 107, 192)
			Me.PanelElement.PanelBorder.RightColor = Color.FromArgb(61, 107, 192)
			Me.PanelElement.PanelBorder.BottomColor = Color.FromArgb(187, 217, 253)
			Me.PanelElement.PanelBorder.TopShadowColor = Color.FromArgb(228,242,253)
			Me.PanelElement.PanelBorder.LeftShadowColor = Color.FromArgb(211,232,253)
			Me.PanelElement.PanelBorder.RightShadowColor = Color.FromArgb(211,232,253)
			Me.PanelElement.PanelBorder.LeftWidth = 1
			Me.PanelElement.PanelBorder.TopWidth = 1
			Me.PanelElement.PanelBorder.RightWidth = 1
			Me.PanelElement.PanelBorder.BottomWidth = 1
			Me.PanelElement.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.PanelElement.Padding = New System.Windows.Forms.Padding(8, 4, 2, 2)
			Me.PanelElement.PanelBorder.BorderDrawMode = Telerik.WinControls.BorderDrawModes.VerticalOverHorizontal
		End Sub
	End Class
End Namespace