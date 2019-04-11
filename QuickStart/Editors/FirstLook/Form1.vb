Imports Microsoft.VisualBasic
Imports System
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Editors.FirstLook
	''' <summary>
	''' example form         
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()
			Me.SetTheme()
		End Sub

		Private Sub radPanelDemoHolder_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub SetTheme()
			Me.radTxtDemo1.ThemeName = THEME
			Me.radTxtDemo2.ThemeName = THEME
			Me.radTxtNullText.ThemeName = THEME
			Me.radCheckCancel.ThemeName = THEME
			Me.radGroupMulti.ThemeName = THEME
			Me.radGroupNull.ThemeName = THEME
			Me.radLblNewValue.ThemeName = THEME
			Me.radLblNulltext.ThemeName = THEME
			Me.radLblOldValue.ThemeName = THEME
			Me.radLabel1.ThemeName = THEME
			Me.radLabel2.ThemeName = THEME
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			radTxtDemo1.NullText = Me.radTxtNullText.Text
		End Sub

		Private Sub radTextBox2_TextChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.TextChangingEventArgs) Handles radTxtDemo2.TextChanging
			e.Cancel = Me.radCheckCancel.Checked
			Me.radLblOldValue.Text = "Old Value: " & e.OldValue
			Me.radLblNewValue.Text = "New Value: " & e.NewValue
		End Sub

		Private Sub radTxtNullText_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTxtNullText.TextChanged
			radTxtDemo1.NullText = Me.radTxtNullText.Text
			radTxtDemo2.NullText = Me.radTxtNullText.Text
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radTxtDemo2.AcceptsReturn = True
		End Sub
	End Class
End Namespace