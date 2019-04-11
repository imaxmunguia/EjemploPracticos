Imports System
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.WaitingBars
    ''' <summary>
    ''' Example beautifying
    ''' </summary>
    Partial Class Form1
        Inherits ExamplesForm
        Private [step] As Integer

        Public Sub New()
            InitializeComponent()
            Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground, False)
            Me.SelectedControl = Me.RadWaitingBar2

        End Sub


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Me.RadWaitingBar2.StartWaiting()
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
            Me.RadWaitingBar2.StartWaiting()
        End Sub

        Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton2.Click
            Me.RadWaitingBar2.StopWaiting()
        End Sub

    End Class
End Namespace