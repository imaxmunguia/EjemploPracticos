Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Integration.Magnifier
    Partial Public Class Form1
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.magnifier1 = New Telerik.Examples.WinControls.Integration.Magnifier.Magnifier()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.magnifier1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
            ' 
            ' 
            ' 
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(3, 37)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(98, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Magnification level:"
            ' 
            ' radToggleButton1
            ' 
            Me.radToggleButton1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
            Me.radToggleButton1.Location = New System.Drawing.Point(16, 72)
            Me.radToggleButton1.Name = "radToggleButton1"
            ' 
            ' 
            ' 
            Me.radToggleButton1.RootElement.ToolTipText = Nothing
            Me.radToggleButton1.Size = New System.Drawing.Size(135, 23)
            Me.radToggleButton1.TabIndex = 3
            Me.radToggleButton1.Text = "Toggle items' opacity"
            '			Me.radToggleButton1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radToggleButton1_ToggleStateChanged);
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radSpinEditor1)
            Me.radGroupBox1.Controls.Add(Me.label1)
            Me.radGroupBox1.Controls.Add(Me.radToggleButton1)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.FooterText = ""
            Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Magnifier Options"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 6)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox1.Size = New System.Drawing.Size(180, 115)
            Me.radGroupBox1.TabIndex = 0
            Me.radGroupBox1.Text = "Magnifier Options"
            ' 
            ' radSpinEditor1
            ' 
            Me.radSpinEditor1.BackColor = System.Drawing.Color.White
            Me.radSpinEditor1.DecimalPlaces = 2
            Me.radSpinEditor1.ForeColor = System.Drawing.Color.Black
            Me.radSpinEditor1.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
            Me.radSpinEditor1.Location = New System.Drawing.Point(107, 34)
            Me.radSpinEditor1.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.radSpinEditor1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.radSpinEditor1.Name = "radSpinEditor1"
            ' 
            ' 
            ' 
            Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radSpinEditor1.ShowBorder = True
            Me.radSpinEditor1.Size = New System.Drawing.Size(44, 20)
            Me.radSpinEditor1.TabIndex = 1
            Me.radSpinEditor1.TabStop = False
            Me.radSpinEditor1.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '			Me.radSpinEditor1.ValueChanged += New System.EventHandler(Me.radSpinEditor1_ValueChanged);
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radPanel1.BackColor = System.Drawing.SystemColors.Control
            Me.radPanel1.Controls.Add(Me.magnifier1)
            Me.radPanel1.Location = New System.Drawing.Point(356, 188)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(482, 438)
            Me.radPanel1.TabIndex = 1
            Me.radPanel1.Text = "radPanel1"
            ' 
            ' magnifier1
            ' 
            Me.magnifier1.BackColor = System.Drawing.Color.Transparent
            Me.magnifier1.Columns = 7
            Me.magnifier1.DefaultCellSize = New System.Drawing.Size(56, 56)
            Me.magnifier1.ForeColor = System.Drawing.Color.Black
            Me.magnifier1.Location = New System.Drawing.Point(26, 13)
            Me.magnifier1.Name = "magnifier1"
            ' 
            ' 
            ' 
            Me.magnifier1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.magnifier1.Size = New System.Drawing.Size(429, 411)
            Me.magnifier1.TabIndex = 0
            Me.magnifier1.Text = "magnifier1"
            CType(Me.magnifier1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            CType(Me.magnifier1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' Form1
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1224, 820)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType(Me.magnifier1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private magnifier1 As Magnifier
        Private label1 As System.Windows.Forms.Label
        Private WithEvents radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace
