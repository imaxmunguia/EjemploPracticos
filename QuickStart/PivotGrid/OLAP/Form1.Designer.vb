Namespace Telerik.Examples.WinControls.PivotGrid.OLAP
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits Telerik.QuickStart.WinControls.ExamplesForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
            Me.radPivotFieldList1 = New Telerik.WinControls.UI.RadPivotFieldList()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPivotGrid1.SuspendLayout()
            DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.radPivotGrid1.TabIndex = 0
            Me.radPivotGrid1.Text = "radPivotGrid1"
            ' 
            ' radPivotFieldList1
            ' 
            Me.radPivotFieldList1.AssociatedPivotGrid = Me.radPivotGrid1
            Me.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Right
            Me.radPivotFieldList1.Location = New System.Drawing.Point(539, 0)
            Me.radPivotFieldList1.MinimumSize = New System.Drawing.Size(225, 305)
            Me.radPivotFieldList1.Name = "radPivotFieldList1"
            Me.radPivotFieldList1.Size = New System.Drawing.Size(258, 526)
            Me.radPivotFieldList1.TabIndex = 1
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
            Me.Controls.Add(Me.radPivotFieldList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPivotGrid1.ResumeLayout(False)
            DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


        Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
        Private radPivotFieldList1 As Telerik.WinControls.UI.RadPivotFieldList
        Friend WithEvents radButton1 As Telerik.WinControls.UI.RadButton
    End Class
End Namespace