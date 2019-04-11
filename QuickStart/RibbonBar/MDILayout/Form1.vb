Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.RadRibbonForm
		Private mdiChildCount As Integer = 0

		Public Sub New()
			InitializeComponent()
            Me.AllowAero = False
            Me.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radRibbonBar1.RibbonBarElement.TabStripElement.Items(0)
			Me.IsMdiContainer = True
			Me.MinimumSize = New Size(210, 140)
		End Sub

		Private Sub radRibbonBarChunk2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radRibbonBarChunk2.Click
			Me.AddNewChildForm()
		End Sub

		Private Sub PrepareMDIContainerForThemeChange()
			If Me.ActiveMdiChild Is Nothing Then
				Return
			End If
			If Me.ActiveMdiChild.WindowState = FormWindowState.Maximized Then
				Me.ActiveMdiChild.WindowState = FormWindowState.Normal
			End If
		End Sub

		Private Sub AddNewChildForm()
			Dim form As Form = If(Me.MdiChildren.Length Mod 2 = 0, New Form(), New Telerik.WinControls.UI.RadForm())
			form.MdiParent = Me
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "MDI Child Form " + (Me.mdiChildCount += 1);
            Me.mdiChildCount = Me.mdiChildCount+1
			form.Text = "MDI Child Form " & Me.mdiChildCount
			form.Show()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddNewChildForm()
			AddNewChildForm()
			AddNewChildForm()
			AddNewChildForm()
		End Sub

		Private Sub radButtonElement5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement5.Click
			Me.AddNewChildForm()
		End Sub

		Private Sub radButtonElement29_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement29.Click
			If Me.ActiveMdiChild IsNot Nothing Then
				Me.ActiveMdiChild.Close()
			End If
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement1.Click
			Me.PrepareMDIContainerForThemeChange()
            ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Blue")
		End Sub

		Private Sub radButtonElement2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement2.Click
			Me.PrepareMDIContainerForThemeChange()
            ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Black")
		End Sub

		Private Sub radButtonElement3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement3.Click
			Me.PrepareMDIContainerForThemeChange()
            ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Silver")
		End Sub
	End Class
End Namespace