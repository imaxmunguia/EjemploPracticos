Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If Me.radSplitContainer1 IsNot Nothing Then
                Dim width As Integer = Me.ClientSize.Width
                Dim height As Integer = Me.ClientSize.Height
                Me.radSplitContainer1.Location = New Point((width - radSplitContainer1.Size.Width) \ 2, (height - radSplitContainer1.Size.Height) \ 2)
            End If
        End Sub


        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Dim button As RadButtonElement = New RadButtonElement("button")
            surface1.Element.Children.Add(New SurfaceObject(65, 154, button))
            AddHandler surface1.Element.CurrentObjectChanged, AddressOf Element_CurrentObjectChanged
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(0), SurfaceObject)

            radButtonRemove.Enabled = False
        End Sub

        Private Sub Element_CurrentObjectChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentObject As SurfaceObject = DirectCast(sender, SurfaceElement).CurrentObject
            Me.radPropertyGrid1.SelectedObject = New RadElementWrapper(currentObject, DirectCast(currentObject.Children(0), RadItem))
        End Sub

        Private Sub radMenuItem1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem1.Click
            Dim button As RadButtonElement = New RadButtonElement("button")
            surface1.Element.Children.Add(New SurfaceObject(10, 10, button))
            radButtonRemove.Enabled = True
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
        End Sub

        Private Sub radMenuItem2_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem2.Click
            Dim label As RadLabelElement = New RadLabelElement()
            label.Text = "label"
            surface1.Element.Children.Add(New SurfaceObject(10, 10, label))
            radButtonRemove.Enabled = True
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
        End Sub

        Private Sub radMenuItem3_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem3.Click
            Dim checkbox As RadCheckBoxElement = New RadCheckBoxElement()
            checkbox.Text = "checkbox"
            surface1.Element.Children.Add(New SurfaceObject(10, 10, checkbox))
            radButtonRemove.Enabled = True
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
        End Sub

        Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem4.Click
            Dim radioButton As RadRadioButtonElement = New RadRadioButtonElement()
            radioButton.Text = "radio button"
            surface1.Element.Children.Add(New SurfaceObject(10, 10, radioButton))
            radButtonRemove.Enabled = True
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
        End Sub

        Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem5.Click
            Dim scrollbar As RadScrollBarElement = New RadScrollBarElement()
            surface1.Element.Children.Add(New SurfaceObject(10, 10, scrollbar))
            radButtonRemove.Enabled = True
            surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
        End Sub

        Private Sub radButtonRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonRemove.Click
            If surface1.Element.Children.Count > 1 Then
                surface1.Element.Children.Remove(surface1.Element.CurrentObject)
                surface1.Element.CurrentObject = DirectCast(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
                surface1.Element.Invalidate()
            End If

            radButtonRemove.Enabled = surface1.Element.Children.Count > 1
        End Sub
    End Class
End Namespace
