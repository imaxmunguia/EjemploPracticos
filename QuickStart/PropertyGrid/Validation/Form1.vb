Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports System.Text.RegularExpressions
Imports Telerik.QuickStart.WinControls
Imports System

Namespace Telerik.Examples.WinControls.PropertyGrid.Validation
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If Me.radPropertyGrid1 IsNot Nothing Then
                Dim width As Integer = Me.ClientSize.Width
                Dim height As Integer = Me.ClientSize.Height
                Me.radPropertyGrid1.Location = New Point((width - radPropertyGrid1.Size.Width) \ 2, (height - radPropertyGrid1.Size.Height) \ 2)
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            AddHandler Me.radPropertyGrid1.PropertyValidating, AddressOf radPropertyGrid1_PropertyValidating
            AddHandler Me.radPropertyGrid1.Edited, AddressOf radPropertyGrid1_Edited

            Dim person As New PersonInfo()
            person.Name = "John"
            person.Family = "Smith"
            person.Gender = Gender.Male
            person.Age = 34
            person.City = "London"
            person.Country = "England"
            person.Phone = "555-343-3456    "
            person.EMail = "john.smith@microsoft.com"

            radPropertyGrid1.SelectedObject = person
            radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical
            radPropertyGrid1.HelpVisible = True
            radPropertyGrid1.ToolbarVisible = True
            radPropertyGrid1.PropertyGridElement.SplitElement.HelpElementHeight = 110

            radPropertyGrid1.Items("Age").[Select]()
            radPropertyGrid1.Items("Age").BeginEdit()
            radPropertyGrid1.ActiveEditor.Value = 12
            radPropertyGrid1.EndEdit()

        End Sub

        Private Sub radPropertyGrid1_Edited(ByVal sender As Object, ByVal e As PropertyGridItemEditedEventArgs)
            Dim item As PropertyGridItem = TryCast(e.Item, PropertyGridItem)
            item.ErrorMessage = ""
        End Sub

        Private Sub radPropertyGrid1_PropertyValidating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.PropertyValidatingEventArgs)
            Dim item As PropertyGridItem = DirectCast(e.Item, PropertyGridItem)

            If e.Item.Name = "Age" AndAlso (CDec(e.NewValue) < 18 OrElse CDec(e.NewValue) > 56) Then
                item.ErrorMessage = "Age must be between 18 and 56!"
                e.Cancel = True
            End If
            If e.Item.Name = "Phone" Then
                Dim regex As New Regex("^(\(?[0-9]{3}\)?)?\-?[0-9]{3}\-?[0-9]{4}$")
                If e.NewValue Is Nothing OrElse Not regex.IsMatch(e.NewValue.ToString()) Then
                    item.ErrorMessage = "This is not a valid phone. Please enter valid phone to continue."
                    e.Cancel = True
                End If
            End If
            If e.Item.Name = "EMail" Then
                Dim regex As New Regex("^[A-Za-z0-9_\-\.]+@(([A-Za-z0-9\-])+\.)+([A-Za-z\-])+$")
                If e.NewValue Is Nothing OrElse Not regex.IsMatch(e.NewValue.ToString()) Then
                    item.ErrorMessage = "This is not a valid email address. Please enter valid email address to continue."
                    e.Cancel = True
                End If
            End If
            If e.Item.Name = "Country" OrElse e.Item.Name = "City" OrElse e.Item.Name = "Name" OrElse e.Item.Name = "Family" Then
                If String.IsNullOrEmpty(TryCast(e.NewValue, String)) Then
                    item.ErrorMessage = "Please enter valid data!"
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace
