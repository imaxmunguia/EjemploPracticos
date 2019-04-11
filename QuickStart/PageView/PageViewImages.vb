Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports System.Drawing

Namespace Telerik.Examples.WinControls.PageView
	Friend Class PageViewImages
		Public Shared Images() As Image
		Public Shared Names() As String

		Shared Sub New()
			Names = New String() { "Brush.png", "Calendar 1.png", "CD Burner.png", "Chart Pie.png", "Configuration Tools.png", "Configuration.png", "Dice.png", "Download.png", "Home.png", "Logout.png" }

			Dim type As Type = GetType(PageViewImages)
			Images = New Image(9){}

			For i As Integer = 0 To 9
				Images(i) = ResourceHelper.ImageFromResource(type, Names(i))
			Next i
		End Sub
	End Class
End Namespace
