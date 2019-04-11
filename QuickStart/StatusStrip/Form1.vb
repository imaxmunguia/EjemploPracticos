Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.StatusStrip
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.ShapedForm
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()
			Me.Shape = New RoundRectShape(5)
			Me.Padding = New Padding(1, 1, 1, 0)
			Me.radSplitButtonElement1.GetChildAt(1).GetChildAt(0).GetChildAt(2).AutoSize = True

			Me.timer1.Start()
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Me.radProgressBarElement1.PerformStepValue1()
			If Me.radProgressBarElement1.Value1 >= Me.radProgressBarElement1.Maximum Then
				Me.radProgressBarElement1.Value1 = Me.radProgressBarElement1.Minimum
			End If
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement1.Click
			MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
	End Class
End Namespace