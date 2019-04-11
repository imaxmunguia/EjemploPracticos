Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System

Namespace Telerik.Examples.WinControls.Integration.PhotoAlbum

    Partial Public Class Form1
        Inherits Form
        Private Shared ReadOnly ExternalPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\..\PhotoAlbum\Bin\PhotoAlbum.exe"

        Public Sub New()
            InitializeComponent()
            Dim processStart As ProcessStartInfo = New ProcessStartInfo
            processStart.WorkingDirectory = Path.GetDirectoryName(ExternalPath)
            processStart.FileName = ExternalPath
            Process.Start(processStart)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.Close()
        End Sub
    End Class
End Namespace