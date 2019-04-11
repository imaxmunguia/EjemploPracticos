Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System

Namespace Telerik.Examples.WinControls.Integration.DemoHub

    Partial Public Class Form1
        Inherits Form
        Private Shared ReadOnly ExternalPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\..\DemoAppsHub\bin\DemoAppsHub.exe"

        Public Sub New()
            InitializeComponent()
			dim processStart as ProcessStartInfo = new ProcessStartInfo
			processStart.WorkingDirectory = Path.GetDirectoryName( ExternalPath)
			processStart.FileName = ExternalPath
			Process.Start(processStart)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.Close()
        End Sub
    End Class
End Namespace