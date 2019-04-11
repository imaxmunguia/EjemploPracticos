Namespace Telerik.Examples.WinControls.PivotGrid.LayoutType
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits Telerik.QuickStart.WinControls.ExamplesForm

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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radioCompactColumnHeader = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioTabularColumnHeader = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radioCompactRowHeader = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioTabularRowHeader = New Telerik.WinControls.UI.RadRadioButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radioCompactColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioTabularColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.radioCompactRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioTabularRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(1024, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(234, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radioCompactColumnHeader)
            Me.radGroupBox1.Controls.Add(Me.radioTabularColumnHeader)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Column Headers Layout"
            Me.radGroupBox1.Location = New System.Drawing.Point(72, 10)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(152, 80)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Column Headers Layout"
            ' 
            ' radioCompactColumnHeader
            ' 
            Me.radioCompactColumnHeader.Location = New System.Drawing.Point(6, 46)
            Me.radioCompactColumnHeader.Name = "radioCompactColumnHeader"
            Me.radioCompactColumnHeader.Size = New System.Drawing.Size(110, 18)
            Me.radioCompactColumnHeader.TabIndex = 1
            Me.radioCompactColumnHeader.Text = "Compact"
            ' 
            ' radioTabularColumnHeader
            ' 
            Me.radioTabularColumnHeader.Location = New System.Drawing.Point(6, 22)
            Me.radioTabularColumnHeader.Name = "radioTabularColumnHeader"
            Me.radioTabularColumnHeader.Size = New System.Drawing.Size(110, 18)
            Me.radioTabularColumnHeader.TabIndex = 0
            Me.radioTabularColumnHeader.TabStop = True
            Me.radioTabularColumnHeader.Text = "Tabular"
            Me.radioTabularColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.radioCompactRowHeader)
            Me.radGroupBox2.Controls.Add(Me.radioTabularRowHeader)
            Me.radGroupBox2.FooterImageIndex = -1
            Me.radGroupBox2.FooterImageKey = ""
            Me.radGroupBox2.HeaderImageIndex = -1
            Me.radGroupBox2.HeaderImageKey = ""
            Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox2.HeaderText = "Row Headers Layout"
            Me.radGroupBox2.Location = New System.Drawing.Point(72, 116)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(152, 77)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "Row Headers Layout"
            ' 
            ' radioCompactRowHeader
            ' 
            Me.radioCompactRowHeader.Location = New System.Drawing.Point(6, 45)
            Me.radioCompactRowHeader.Name = "radioCompactRowHeader"
            Me.radioCompactRowHeader.Size = New System.Drawing.Size(110, 18)
            Me.radioCompactRowHeader.TabIndex = 3
            Me.radioCompactRowHeader.Text = "Compact"
            ' 
            ' radioTabularRowHeader
            ' 
            Me.radioTabularRowHeader.Location = New System.Drawing.Point(6, 21)
            Me.radioTabularRowHeader.Name = "radioTabularRowHeader"
            Me.radioTabularRowHeader.Size = New System.Drawing.Size(110, 18)
            Me.radioTabularRowHeader.TabIndex = 2
            Me.radioTabularRowHeader.TabStop = True
            Me.radioTabularRowHeader.Text = "Tabular"
            Me.radioTabularRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1258, 832)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            DirectCast(Me.radioCompactColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioTabularColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            DirectCast(Me.radioCompactRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioTabularRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radioTabularColumnHeader As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioCompactColumnHeader As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioCompactRowHeader As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radioTabularRowHeader As Telerik.WinControls.UI.RadRadioButton

    End Class
End Namespace