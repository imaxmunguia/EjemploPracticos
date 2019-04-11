Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Editors.TextBoxControl
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub radBtnSetBackgroundImage_Click(sender As Object, e As System.EventArgs) Handles radBtnSetBackgroundImage.Click
            Using fileDialog As New OpenFileDialog()
                fileDialog.Multiselect = False
                fileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG;"

                If fileDialog.ShowDialog() = DialogResult.OK Then
                    Dim image__1 As Image = Image.FromStream(fileDialog.OpenFile())
                    Me.radTextBoxControl1.TextBoxElement.ViewElement.BackgroundImage = image__1
                End If
            End Using
        End Sub

        Protected Overrides Sub OnSizeChanged(e As System.EventArgs)
            MyBase.OnSizeChanged(e)

            If Me.radPanel1 IsNot Nothing Then
                Dim xCoord As Single = CSng(Me.Width - Me.radPanel1.Width) / 2
                Dim yCoord As Single = CSng(Me.Height - Me.radPanel1.Height) / 2
                Me.radPanel1.Location = Point.Round(New PointF(xCoord, yCoord))
            End If
        End Sub

        Private Sub radButtonSearch_Click(sender As Object, e As System.EventArgs) Handles radButtonSearch.Click
            Dim text As String = Me.radTextBoxControl1.Text

            If Not String.IsNullOrEmpty(text) Then
                Dim query As String = String.Format("http://www.bing.com/search?q={0}", text)
                Process.Start(query)
            End If
        End Sub
    End Class
End Namespace
