Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Integration.HTMLFormatting
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
            SetTheme()
        End Sub

        Private Sub SetTheme()
            Me.radListBox1.ThemeName = "ControlDefault"
            Me.radRadioButton1.ThemeName = "ControlDefault"
            Me.radCheckBox1.ThemeName = "ControlDefault"
            Me.radTextBox1.ThemeName = "ControlDefault"
            Me.radButton1.ThemeName = "ControlDefault"
            Me.radToggleButton1.ThemeName = "ControlDefault"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.radTextBox1.Text = Me.radLabel1.Text
            AddHandler radButton2.Click, AddressOf radButton2_Click
            Me.radTextBox1.Text = "<html><p><span style=""font-size: large"">RadLabel</span></p><p><span style=""font-size: medium""><strong>Arial, Bold</strong></span></p><p><span style=""font-size: small""><em><span style=""font-family: times new roman"">Times, Italic, <u>Underline</u></span></em></span></p><p><em><span style=""font-family: times new roman; color: #0080ff; font-size: 18pt"">Sample Text</span></em></p></html>"
        End Sub

        Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using dialog As New RadMarkupDialog()
                dialog.Value = Me.radTextBox1.Text

                Dim result As DialogResult = dialog.ShowDialog()

                If result = System.Windows.Forms.DialogResult.OK Then
                    Me.radTextBox1.Text = dialog.Value
                End If
            End Using
        End Sub

        Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBox1.TextChanged
            Me.radLabel1.Text = Me.radTextBox1.Text
        End Sub
    End Class
End Namespace