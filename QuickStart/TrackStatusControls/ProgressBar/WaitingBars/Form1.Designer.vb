Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.WaitingBars
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.RadWaitingBar2 = New Telerik.WinControls.UI.RadWaitingBar()
            Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
            Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadWaitingBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(541, 30)
            Me.settingsPanel.Size = New System.Drawing.Size(902, 986)
            Me.settingsPanel.ThemeName = "ControlDefault"
            '
            'RadWaitingBar2
            '
            Me.RadWaitingBar2.Location = New System.Drawing.Point(260, 274)
            Me.RadWaitingBar2.Name = "RadWaitingBar2"
            Me.RadWaitingBar2.Size = New System.Drawing.Size(250, 30)
            Me.RadWaitingBar2.TabIndex = 2
            Me.RadWaitingBar2.Text = "Waiting"
            Me.RadWaitingBar2.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left
            Me.RadWaitingBar2.WaitingIndicatorSize = New System.Drawing.Size(50, 30)
            CType(Me.RadWaitingBar2.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer))
            CType(Me.RadWaitingBar2.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer))
            '
            'RadButton2
            '
            Me.RadButton2.Location = New System.Drawing.Point(188, 96)
            Me.RadButton2.Name = "RadButton2"
            Me.RadButton2.Size = New System.Drawing.Size(130, 24)
            Me.RadButton2.TabIndex = 1
            Me.RadButton2.Text = "Stop Waiting"
            '
            'RadButton1
            '
            Me.RadButton1.Location = New System.Drawing.Point(335, 96)
            Me.RadButton1.Name = "RadButton1"
            Me.RadButton1.Size = New System.Drawing.Size(130, 24)
            Me.RadButton1.TabIndex = 0
            Me.RadButton1.Text = "Start Waiting"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.RadButton2)
            Me.Controls.Add(Me.RadButton1)
            Me.Controls.Add(Me.RadWaitingBar2)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1302, 567)
            Me.Controls.SetChildIndex(Me.RadWaitingBar2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.RadButton1, 0)
            Me.Controls.SetChildIndex(Me.RadButton2, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadWaitingBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents RadWaitingBar2 As Telerik.WinControls.UI.RadWaitingBar
        Private WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
        Private WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    End Class

End Namespace