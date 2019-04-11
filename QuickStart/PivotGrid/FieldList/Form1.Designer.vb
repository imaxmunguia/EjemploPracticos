Namespace Telerik.Examples.WinControls.PivotGrid.FieldList

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits Telerik.WinControls.UI.RadForm

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
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radPivotFieldList1 = New Telerik.WinControls.UI.RadPivotFieldList()
            DirectCast(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            DirectCast(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' radSplitContainer1
            ' 
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            ' 
            ' 
            ' 
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(882, 497)
            Me.radSplitContainer1.TabIndex = 0
            Me.radSplitContainer1.TabStop = False
            Me.radSplitContainer1.Text = "radSplitContainer1"
            ' 
            ' splitPanel1
            ' 
            Me.splitPanel1.Controls.Add(Me.radPivotGrid1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            ' 
            ' 
            ' 
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(654, 497)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2440273F, 0.0F)
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(214, 0)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            ' 
            ' radPivotGrid1
            ' 
            Me.radPivotGrid1.DataMember = Nothing
            Me.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPivotGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPivotGrid1.ShowFilterArea = True
            Me.radPivotGrid1.Name = "radPivotGrid1"
            Me.radPivotGrid1.Size = New System.Drawing.Size(654, 497)
            Me.radPivotGrid1.TabIndex = 0
            Me.radPivotGrid1.Text = "radPivotGrid1"
            ' 
            ' splitPanel2
            ' 
            Me.splitPanel2.Controls.Add(Me.radPivotFieldList1)
            Me.splitPanel2.Location = New System.Drawing.Point(657, 0)
            Me.splitPanel2.Name = "splitPanel2"
            ' 
            ' 
            ' 
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(225, 497)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2440273F, 0.0F)
            Me.splitPanel2.SizeInfo.MinimumSize = New System.Drawing.Size(225, 25)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-214, 0)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            ' 
            ' radPivotFieldList1
            ' 
            Me.radPivotFieldList1.AssociatedPivotGrid = Me.radPivotGrid1
            Me.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPivotFieldList1.Location = New System.Drawing.Point(0, 0)
            Me.radPivotFieldList1.MinimumSize = New System.Drawing.Size(225, 305)
            Me.radPivotFieldList1.Name = "radPivotFieldList1"
            Me.radPivotFieldList1.Size = New System.Drawing.Size(225, 497)
            Me.radPivotFieldList1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(882, 497)
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            DirectCast(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Private radPivotFieldList1 As Telerik.WinControls.UI.RadPivotFieldList
        Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid

    End Class
End Namespace