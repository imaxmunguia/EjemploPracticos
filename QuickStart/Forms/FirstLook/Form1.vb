Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.FirstLook
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.RadForm
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()
			Me.radGridView1.TableElement.RowHeight = 60
			Me.radGridView1.TableElement.Text = ""
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Me.radProgressBarElement1.PerformStepValue1()
			If Me.radProgressBarElement1.Value1 >= Me.radProgressBarElement1.Maximum Then
				Me.radProgressBarElement1.Value1 = Me.radProgressBarElement1.Minimum
			End If
		End Sub

		Private Sub OnRadMenuItemChangeTheme_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem22.Click, radMenuItem26.Click, radMenuItem12.Click
			Dim menuItem As RadMenuItem = CType(sender, RadMenuItem)

			For Each sibling As RadMenuItem In menuItem.HierarchyParent.Items
				sibling.IsChecked = False
			Next sibling

			menuItem.IsChecked = True

			Dim themeName As String = CStr((menuItem).Tag)
			ChangeThemeName(Me, themeName)
		End Sub

		Private Sub ChangeThemeName(ByVal control As Control, ByVal themeName As String)
			Dim radControl As IComponentTreeHandler = TryCast(control, IComponentTreeHandler)
			If radControl IsNot Nothing Then
				radControl.ThemeName = themeName
			End If

			For Each child As Control In control.Controls
				ChangeThemeName(child, themeName)
			Next child
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Desert")
		End Sub

		Private Sub radMenuItem17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem17.Click
			Dim aboutBox As RadAboutBox.RadAboutBox1 = New Telerik.Examples.WinControls.Forms.RadAboutBox.RadAboutBox1()


			aboutBox.ThemeName = Me.ThemeName
			aboutBox.ShowDialog(Me)
		End Sub
	End Class
End Namespace
