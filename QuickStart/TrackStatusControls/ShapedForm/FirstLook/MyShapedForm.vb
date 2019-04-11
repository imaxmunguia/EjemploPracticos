Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
	Partial Public Class MyShapedForm
		Inherits Telerik.WinControls.UI.ShapedForm
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal shape As ElementShape)
			InitializeComponent()
			If shape IsNot Nothing Then
				Me.Shape = shape
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Me.Close()
		End Sub

		Protected Overrides Function GetHitTest(ByVal point As Point) As Integer
			Dim result As Integer = MyBase.GetHitTest(point)
			If result = 1 Then
				result = 2
			End If
			Return result
		End Function
	End Class
End Namespace