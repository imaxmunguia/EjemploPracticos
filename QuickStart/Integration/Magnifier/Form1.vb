Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Integration.Magnifier
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            MyBase.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)

            FillMagnifierWithButtons()
            SetTheme()

            Me.radPanel1.Text = ""
            radToggleButton1.ToggleState = ToggleState.On
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
        End Sub

        Private Sub FillMagnifierWithButtons()
            For i As Integer = 0 To 48
                Dim button As New RadButtonElement(i.ToString())

                button.StretchHorizontally = False
                button.StretchVertically = False
                button.Alignment = ContentAlignment.MiddleCenter
                button.TextAlignment = ContentAlignment.MiddleCenter
                button.TextElement.Parent.Alignment = ContentAlignment.MiddleCenter
                button.MinSize = New Size(33, 33)
                Me.magnifier1.Items.Add(button)
            Next i
        End Sub

        Private Sub SetTheme()
            Me.radGroupBox1.ThemeName = MainForm.DefaultTheme
            Me.radToggleButton1.ThemeName = MainForm.DefaultTheme
            Me.radSpinEditor1.ThemeName = MainForm.DefaultTheme
            Me.radPanel1.ThemeName = MainForm.DefaultTheme
            Me.magnifier1.ThemeName = "OfficeGlass"
        End Sub

        Private Sub radToggleButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radToggleButton1.ToggleStateChanged
            Dim rand As New Random()

            For Each item As RadItem In Me.magnifier1.Items
                If args.ToggleState = ToggleState.On Then
                    item.Opacity = CDbl(rand.Next(100) + 10) / 100.0R
                Else
                    item.Opacity = 1
                End If
            Next item
        End Sub

        Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
            Me.magnifier1.ZoomFactor = CSng(Me.radSpinEditor1.Value)
        End Sub
    End Class
End Namespace
