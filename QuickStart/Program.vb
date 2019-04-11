Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Drawing
Imports Telerik.WinControls.UI
Imports System.Text
Imports System.Diagnostics

Namespace Telerik.QuickStart.WinControls
    Friend NotInheritable Class Program
        Private Sub New()
        End Sub

        Public Shared EditorLoaded As Boolean = False
        Private Shared mutex As Threading.Mutex

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main(args As String())
            Try
                Dim appPath As New StringBuilder(256)
                Dim paths As String() = Application.StartupPath.Split("\"c)
                For i As Integer = 0 To paths.Length - 3
                    appPath.Append(paths(i))
                    appPath.Append("\"c)
                Next

                If appPath.Length > 0 Then
                    Process.Start(New ProcessStartInfo(appPath.ToString() & "TelerikEditor\bin\TelerikEditor.exe", "singleinstance"))
                    mutex = New Threading.Mutex(True, "TelerikEditorExample")
                    Program.EditorLoaded = True

                End If
            Catch
            End Try

            AddHandler Application.ApplicationExit, AddressOf OnApplicationExit
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End Sub

        Private Shared Sub OnApplicationExit(sender As Object, e As EventArgs)
            Try
                If mutex IsNot Nothing Then
                    mutex.ReleaseMutex()
                    mutex.Close()
                End If
            Catch
            End Try
        End Sub
    End Class
End Namespace