Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PivotGrid.KPIs

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits ExamplesForm

        'UserControl overrides dispose to clean up the component list.
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
            components = New System.ComponentModel.Container()
            Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPivotGrid1.SuspendLayout()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radPivotGrid1
            ' 
            Me.radPivotGrid1.Controls.Add(Me.radButton1)
            Me.radPivotGrid1.DataMember = Nothing
            Me.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPivotGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPivotGrid1.Name = "radPivotGrid1"
            Me.radPivotGrid1.Size = New System.Drawing.Size(539, 526)
            Me.radPivotGrid1.ShowFilterArea = True
            Me.radPivotGrid1.TabIndex = 0
            Me.radPivotGrid1.Text = "radPivotGrid1"
            Me.radPivotGrid1.ShowFilterArea = False
            ' 
            ' radButton1
            ' 
            Me.radButton1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.radButton1.Location = New System.Drawing.Point(165, 245)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(215, 31)
            Me.radButton1.TabIndex = 0
            Me.radButton1.Text = "Connect to ""Adventure Works"" Cube"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(797, 526)
            Me.Controls.Add(Me.radPivotGrid1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPivotGrid1.ResumeLayout(False)
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
        Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton

    End Class
End Namespace

