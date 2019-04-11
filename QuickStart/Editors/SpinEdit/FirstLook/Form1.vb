Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.SpinEdit.FirstLook

	''' <summary>
	''' example forms
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()

			AddHandler radSpinDemo.ValueChanging, AddressOf radSpinEdit1_ValueChanging
			AddHandler radSpinDemo.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radSpinDemo.RightToLeftChanged, AddressOf radSpinEditor1_RightToLeftChanged
			AddHandler radSpinDemo.PropertyChanged, AddressOf radSpinEditor1_PropertyChanged

			Me.SetTheme()
		End Sub

		Private Sub radSpinEditor1_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			Dim item As New RadListDataItem()
			item.Text = "PropertyChanged" & Constants.vbLf
			item.Font = New Font("Lucida Sans Unicode", 7.2f)
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub radSpinEditor1_RightToLeftChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As New RadListDataItem()
			item.Text = "RightToLeftChanged fired" & Constants.vbLf
			item.Font = New Font("Lucida Sans Unicode", 7.2f)
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As New RadListDataItem()
			item.Font = New Font("Lucida Sans Unicode", 7.2f)
			item.Text = "ValueChanged fired" & Constants.vbLf
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
		End Sub

		Private Sub radSpinEdit1_ValueChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ValueChangingEventArgs)
			Dim item As New RadListDataItem()
			item.Text = "ValueChanging fired" & Constants.vbLf
			item.Font = New Font("Lucida Sans Unicode", 7.2f)
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub OnCheckRightToLeft_StateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			Me.radSpinDemo.RightToLeft = If(Me.radCheckBox1.Checked, System.Windows.Forms.RightToLeft.Yes, System.Windows.Forms.RightToLeft.No)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Me.radListBox1.Items.Clear()
		End Sub
	End Class
End Namespace