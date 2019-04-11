Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Forms.MDI
	Partial Public Class RadChildForm2
		Inherits Telerik.WinControls.UI.RadForm
	   Public Sub New()
			InitializeComponent()
			Me.radStatusBar1.ThemeName = "Desert"
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
