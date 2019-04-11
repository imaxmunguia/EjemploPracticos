Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls
Imports System.Xml.XPath
Imports System.Xml
Imports Telerik.QuickStart.WinControls
Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.FirstLook
    ''' <summary>
    ''' Example beautifying 
    ''' </summary>
    Partial Public Class Form1
    Inherits ExamplesForm
        Private check As Boolean

        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radProgressBar1
            Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground, False)

        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick

            If (Not check) Then
                If radProgressBar1.Value1 < radProgressBar1.Maximum Then
                    radProgressBar1.Value1 += 1
                    radProgressBar2.Value1 += 1
                    radProgressBar4.Value1 += 1
                    radProgressBar6.Value1 += 1
                Else
                    check = True
                End If
            Else
                If radProgressBar1.Value1 > radProgressBar1.Minimum Then
                    radProgressBar1.Value1 -= 1
                    radProgressBar2.Value1 -= 1
                    radProgressBar4.Value1 -= 1
                    radProgressBar6.Value1 -= 1

                Else
                    check = False
                End If
            End If
        End Sub

        Private Sub radTrackBar1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles radTrackBar1.Scroll
            radProgressBar5.Value1 = CInt(radTrackBar1.Value * 10)
        End Sub
    End Class
End Namespace