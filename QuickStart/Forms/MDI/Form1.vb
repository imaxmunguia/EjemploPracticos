Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.IO
Imports System.Reflection
Imports System.Diagnostics

Namespace Telerik.Examples.WinControls.Forms.MDI
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.RadForm
		Private Shared ChildSize As New Size(580, 200)
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()
			Me.IsMdiContainer = True
			Me.Text = "RadForm MDI Parent with RadMenu"
			Me.ThemeName = "Desert"
			Me.radMenu1.ThemeName = "Desert"
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Dim child1 As New Form()
			child1.Size = ChildSize
			child1.Text = "Standard Windows Form1 with no menu"
			child1.MdiParent = Me
			child1.Show()

			Dim child4 As New RadChildForm2()
			child4.Size = ChildSize
			child4.Text = "RadForm2 with no menu"
			child4.ThemeName = "Desert"
			child4.MdiParent = Me
			child4.Show()

			Dim child2 As New RadChildForm()
			child2.Size = ChildSize
			child2.Text = "RadForm3 with RadMenu"
			child2.ThemeName = "Desert"
			child2.MdiParent = Me
			child2.Show()

		End Sub

		Private Sub radMenuItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem7.Click
			Me.Close()
		End Sub

		Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem5.Click
			If Me.ActiveMdiChild IsNot Nothing Then
				Me.ActiveMdiChild.Close()
			End If
		End Sub

		Private Sub radMenuItem8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem8.Click
			For Each form As Form In Me.MdiChildren
				form.Close()
			Next form
		End Sub

		Private i As Integer = 4

		Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem4.Click
			Dim child As New RadChildForm2()
			child.Size = ChildSize
			child.Text = "RadForm" & i.ToString()
			child.ThemeName = "Desert"
			child.MdiParent = Me
			child.Show()
			i += 1
		End Sub
	End Class
End Namespace