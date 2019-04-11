Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.TrackStatusControls.Theming
	''' <summary>
	''' Example Beautifying
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			'radTextBox1.NullText = textBox1.Text;
		End Sub

		Private Sub radTextBox2_TextChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.TextChangingEventArgs)

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace