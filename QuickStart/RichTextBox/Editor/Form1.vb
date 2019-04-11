Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System

Namespace Telerik.Examples.WinControls.RichTextBox.Editor
    Partial Public Class Form1
        Inherits Form
        Private Shared ReadOnly ExternalPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\..\TelerikEditor\bin\TelerikEditor.exe"

        Public Sub New()
            InitializeComponent()

            If Program.EditorLoaded Then
                Process.Start(New ProcessStartInfo(ExternalPath, "singleinstance"))
            Else
                Process.Start(New ProcessStartInfo(ExternalPath))

            End If
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.Close()
        End Sub
    End Class
End Namespace