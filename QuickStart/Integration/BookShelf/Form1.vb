Imports System.Diagnostics
Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Integration.BookShelf
    Public Class Form1

        Private Shared ReadOnly ExternalPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\..\BookShelf\Bin\BookShelf.exe"

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