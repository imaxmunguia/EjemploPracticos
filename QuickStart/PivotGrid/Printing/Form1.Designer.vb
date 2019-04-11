Namespace Telerik.Examples.WinControls.PivotGrid.Printing

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits QuickStart.WinControls.ExamplesForm

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
            Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
            Me.buttonPrintPreview = New Telerik.WinControls.UI.RadButton()
            Me.buttonPrintSettings = New Telerik.WinControls.UI.RadButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.settingsPanel.Controls.Add(Me.buttonPrint)
            Me.settingsPanel.Controls.Add(Me.buttonPrintPreview)
            Me.settingsPanel.Controls.Add(Me.buttonPrintSettings)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(940, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(286, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintSettings, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintPreview, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrint, 0)
            ' 
            ' buttonPrint
            ' 
            Me.buttonPrint.Location = New System.Drawing.Point(18, 59)
            Me.buttonPrint.Name = "buttonPrint"
            Me.buttonPrint.Size = New System.Drawing.Size(130, 24)
            Me.buttonPrint.TabIndex = 1
            Me.buttonPrint.Text = "Print"
            ' 
            ' buttonPrintPreview
            ' 
            Me.buttonPrintPreview.Location = New System.Drawing.Point(18, 89)
            Me.buttonPrintPreview.Name = "buttonPrintPreview"
            Me.buttonPrintPreview.Size = New System.Drawing.Size(130, 24)
            Me.buttonPrintPreview.TabIndex = 1
            Me.buttonPrintPreview.Text = "Print Preview"
            ' 
            ' buttonPrintSettings
            ' 
            Me.buttonPrintSettings.Location = New System.Drawing.Point(18, 119)
            Me.buttonPrintSettings.Name = "buttonPrintSettings"
            Me.buttonPrintSettings.Size = New System.Drawing.Size(130, 24)
            Me.buttonPrintSettings.TabIndex = 1
            Me.buttonPrintSettings.Text = "Print Settings"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1226, 832)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents buttonPrint As Telerik.WinControls.UI.RadButton
        Friend WithEvents buttonPrintPreview As Telerik.WinControls.UI.RadButton
        Friend WithEvents buttonPrintSettings As Telerik.WinControls.UI.RadButton

    End Class
End Namespace