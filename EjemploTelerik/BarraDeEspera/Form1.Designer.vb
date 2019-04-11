<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(24, 38)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(238, 24)
        Me.RadWaitingBar1.TabIndex = 0
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        Me.RadWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WaitingBarContentElement).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        CType(Me.RadWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WaitingBarIndicatorElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(56, 103)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "RadButton1"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(56, 133)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "RadButton2"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(56, 164)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(110, 24)
        Me.RadButton3.TabIndex = 3
        Me.RadButton3.Text = "RadButton3"
        '
        'bgw
        '
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(56, 194)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(110, 24)
        Me.RadButton4.TabIndex = 4
        Me.RadButton4.Text = "RadButton4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadWaitingBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
End Class
