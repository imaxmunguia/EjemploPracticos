Imports System.Configuration
Imports System.IO
Imports System.Text.RegularExpressions
Imports OEE.Logic

Public Class Form1
    Private procesos As Int32 = 0
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        If (RadWaitingBar1.IsWaiting) Then
            Me.UseWaitCursor = False
            Me.RadWaitingBar1.StopWaiting()
            Me.RadWaitingBar1.ResetWaiting()
        Else
            Me.UseWaitCursor = True
            Me.RadWaitingBar1.StartWaiting()
        End If
    End Sub
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If Not bgw.IsBusy Then
            PonerPantallaEnModoEspera()
            bgw.RunWorkerAsync()
        End If
    End Sub
    Private Sub HacerAlgo()
        Dim mensaje As String = Regex.Replace(String.Format("{0} {1} {2}", "Isack ", " Munguia", " Mejia   "), "\s+", " ").Trim
        MessageBox.Show(mensaje)
    End Sub
    Private Async Function HacerAlgoAsync() As Task
        Await Task.Run(Sub()
                           Dim mensaje As String = Regex.Replace(String.Format("{0} {1} {2}", "Isack ", " Munguia", " Mejia   "), "\s+", " ").Trim
                           MessageBox.Show(mensaje)
                       End Sub)
    End Function
    Private Async Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        procesos += 1
        PonerPantallaEnModoEspera()
        Await HacerAlgoAsync()
        If (procesos = 1) Then
            PonerPantallaEnModoActivo()
        End If
        procesos -= 1
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim mColegas As Entity.Short = Mantenimientos.MantenimientoCorto.GetShorts().FirstOrDefault()
    End Sub
    Private Sub bgw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork
        HacerAlgo()
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        PonerPantallaEnModoActivo()
    End Sub
    Private Sub PonerPantallaEnModoEspera()
        Me.UseWaitCursor = True
        RadWaitingBar1.StartWaiting()
    End Sub
    Private Sub PonerPantallaEnModoActivo()
        Me.UseWaitCursor = False
        Me.RadWaitingBar1.StopWaiting()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Dim configs As List(Of RecargaElectronicaConfig) = ConfigurationManager.GetSection("RecargasElectronicasConfig")
    End Sub
End Class

Public Class clsPerson
    Public FirstName As String
    Public MI As String
    Public LastName As String
End Class
