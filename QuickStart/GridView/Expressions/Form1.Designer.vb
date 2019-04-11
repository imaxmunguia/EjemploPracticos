Imports Microsoft.VisualBasic
Imports System

Namespace Telerik.Examples.WinControls.GridView.Expressions
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
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radGroupPreDef = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupNumericText = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioAverage = New Telerik.WinControls.UI.RadRadioButton()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radRadioNumExpr2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioNumExpr1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupCheckBox = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radRadioCheckExpr2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioCheckExpr1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radButtonExprEditor = New Telerik.WinControls.UI.RadButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupPreDef, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupPreDef.SuspendLayout()
            DirectCast(Me.radGroupNumericText, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupNumericText.SuspendLayout()
            DirectCast(Me.radRadioAverage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioNumExpr2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioNumExpr1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupCheckBox.SuspendLayout()
            DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioCheckExpr2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioCheckExpr1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupPreDef)
            Me.settingsPanel.Controls.Add(Me.radButtonExprEditor)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(751, 1)
            ' 
            ' 
            ' 
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(200, 806)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupPreDef, 0)
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radGridView1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(248)), CInt(CByte(248)), CInt(CByte(248)))
            Me.radGridView1.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.Location = New System.Drawing.Point(186, 286)
            ' 
            ' 
            ' 
            Me.radGridView1.MasterTemplate.AllowColumnChooser = False
            Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.Caption = Nothing
            Me.radGridView1.MasterTemplate.MultiSelect = True
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.MultiSelect = True
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            ' 
            ' 
            ' 
            Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.radGridView1.Size = New System.Drawing.Size(580, 176)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridView1"
            Me.radGridView1.ThemeName = "Telerik"
            ' 
            ' radGroupPreDef
            ' 
            Me.radGroupPreDef.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupPreDef.Controls.Add(Me.radGroupNumericText)
            Me.radGroupPreDef.Controls.Add(Me.radGroupCheckBox)
            Me.radGroupPreDef.FooterImageIndex = -1
            Me.radGroupPreDef.FooterImageKey = ""
            Me.radGroupPreDef.ForeColor = System.Drawing.Color.Black
            Me.radGroupPreDef.HeaderImageIndex = -1
            Me.radGroupPreDef.HeaderImageKey = ""
            Me.radGroupPreDef.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupPreDef.HeaderText = "Predefined Expressions"
            Me.radGroupPreDef.Location = New System.Drawing.Point(10, 6)
            Me.radGroupPreDef.Name = "radGroupPreDef"
            Me.radGroupPreDef.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupPreDef.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGroupPreDef.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupPreDef.Size = New System.Drawing.Size(180, 264)
            Me.radGroupPreDef.TabIndex = 0
            Me.radGroupPreDef.Text = "Predefined Expressions"
            ' 
            ' radGroupNumericText
            ' 
            Me.radGroupNumericText.Controls.Add(Me.radRadioAverage)
            Me.radGroupNumericText.Controls.Add(Me.radLabel3)
            Me.radGroupNumericText.Controls.Add(Me.radRadioNumExpr2)
            Me.radGroupNumericText.Controls.Add(Me.radRadioNumExpr1)
            Me.radGroupNumericText.FooterImageIndex = -1
            Me.radGroupNumericText.FooterImageKey = ""
            Me.radGroupNumericText.ForeColor = System.Drawing.Color.Black
            Me.radGroupNumericText.HeaderImageIndex = -1
            Me.radGroupNumericText.HeaderImageKey = ""
            Me.radGroupNumericText.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupNumericText.HeaderText = "NumericText Column"
            Me.radGroupNumericText.Location = New System.Drawing.Point(9, 24)
            Me.radGroupNumericText.Name = "radGroupNumericText"
            Me.radGroupNumericText.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupNumericText.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGroupNumericText.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupNumericText.Size = New System.Drawing.Size(144, 116)
            Me.radGroupNumericText.TabIndex = 1
            Me.radGroupNumericText.Text = "NumericText Column"
            ' 
            ' radRadioAverage
            ' 
            Me.radRadioAverage.ForeColor = System.Drawing.Color.Black
            Me.radRadioAverage.Location = New System.Drawing.Point(6, 91)
            Me.radRadioAverage.Name = "radRadioAverage"
            ' 
            ' 
            ' 
            Me.radRadioAverage.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioAverage.Size = New System.Drawing.Size(88, 16)
            Me.radRadioAverage.TabIndex = 2
            Me.radRadioAverage.Text = "Avg(Decimal)"
            'Me.radRadioAverage.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioNumExpr1_ToggleStateChanged)
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.ForeColor = System.Drawing.Color.Black
            Me.radLabel3.Location = New System.Drawing.Point(6, 27)
            Me.radLabel3.Name = "radLabel3"
            ' 
            ' 
            ' 
            Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radLabel3.Size = New System.Drawing.Size(102, 18)
            Me.radLabel3.TabIndex = 4
            Me.radLabel3.Text = "Choose expression:"
            ' 
            ' radRadioNumExpr2
            ' 
            Me.radRadioNumExpr2.ForeColor = System.Drawing.Color.Black
            Me.radRadioNumExpr2.Location = New System.Drawing.Point(6, 69)
            Me.radRadioNumExpr2.Name = "radRadioNumExpr2"
            ' 
            ' 
            ' 
            Me.radRadioNumExpr2.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioNumExpr2.Size = New System.Drawing.Size(86, 16)
            Me.radRadioNumExpr2.TabIndex = 5
            Me.radRadioNumExpr2.Text = "Decimal + 15"
            'Me.radRadioNumExpr2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioNumExpr1_ToggleStateChanged)
            ' 
            ' radRadioNumExpr1
            ' 
            Me.radRadioNumExpr1.ForeColor = System.Drawing.Color.Black
            Me.radRadioNumExpr1.Location = New System.Drawing.Point(6, 47)
            Me.radRadioNumExpr1.Name = "radRadioNumExpr1"
            ' 
            ' 
            ' 
            Me.radRadioNumExpr1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioNumExpr1.Size = New System.Drawing.Size(102, 16)
            Me.radRadioNumExpr1.TabIndex = 3
            Me.radRadioNumExpr1.Text = "(Decimal - 3) * 2"
            'Me.radRadioNumExpr1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioNumExpr1_ToggleStateChanged)
            ' 
            ' radGroupCheckBox
            ' 
            Me.radGroupCheckBox.Controls.Add(Me.radLabel5)
            Me.radGroupCheckBox.Controls.Add(Me.radRadioCheckExpr2)
            Me.radGroupCheckBox.Controls.Add(Me.radRadioCheckExpr1)
            Me.radGroupCheckBox.FooterImageIndex = -1
            Me.radGroupCheckBox.FooterImageKey = ""
            Me.radGroupCheckBox.ForeColor = System.Drawing.Color.Black
            Me.radGroupCheckBox.HeaderImageIndex = -1
            Me.radGroupCheckBox.HeaderImageKey = ""
            Me.radGroupCheckBox.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupCheckBox.HeaderText = "CheckBox Column"
            Me.radGroupCheckBox.Location = New System.Drawing.Point(9, 145)
            Me.radGroupCheckBox.Name = "radGroupCheckBox"
            Me.radGroupCheckBox.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            ' 
            ' 
            ' 
            Me.radGroupCheckBox.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radGroupCheckBox.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupCheckBox.Size = New System.Drawing.Size(144, 109)
            Me.radGroupCheckBox.TabIndex = 1
            Me.radGroupCheckBox.Text = "CheckBox Column"
            ' 
            ' radLabel5
            ' 
            Me.radLabel5.ForeColor = System.Drawing.Color.Black
            Me.radLabel5.Location = New System.Drawing.Point(6, 26)
            Me.radLabel5.Name = "radLabel5"
            ' 
            ' 
            ' 
            Me.radLabel5.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radLabel5.Size = New System.Drawing.Size(102, 18)
            Me.radLabel5.TabIndex = 4
            Me.radLabel5.Text = "Choose expression:"
            ' 
            ' radRadioCheckExpr2
            ' 
            Me.radRadioCheckExpr2.ForeColor = System.Drawing.Color.Black
            Me.radRadioCheckExpr2.Location = New System.Drawing.Point(7, 68)
            Me.radRadioCheckExpr2.Name = "radRadioCheckExpr2"
            ' 
            ' 
            ' 
            Me.radRadioCheckExpr2.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioCheckExpr2.Size = New System.Drawing.Size(140, 16)
            Me.radRadioCheckExpr2.TabIndex = 5
            ' 
            ' radRadioCheckExpr1
            ' 
            Me.radRadioCheckExpr1.ForeColor = System.Drawing.Color.Black
            Me.radRadioCheckExpr1.Location = New System.Drawing.Point(7, 46)
            Me.radRadioCheckExpr1.Name = "radRadioCheckExpr1"
            ' 
            ' 
            ' 
            Me.radRadioCheckExpr1.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radRadioCheckExpr1.Size = New System.Drawing.Size(138, 16)
            Me.radRadioCheckExpr1.TabIndex = 3
            Me.radRadioCheckExpr1.Text = "Decimal < 600"
            'Me.radRadioCheckExpr1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCheckExpr1_ToggleStateChanged)
            '
            ' radButtonExprEditor
            '
            Me.radButtonExprEditor.Size = New System.Drawing.Size(120, 28)
            Me.radButtonExprEditor.Location = New System.Drawing.Point(0, 300)
            Me.radButtonExprEditor.Text = "Show Expression Editor"
            'Me.radButtonExprEditor.Click += New System.EventHandler(radButtonExprEditor_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(952, 808)
            'Me.Load += New System.EventHandler(Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupPreDef, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupPreDef.ResumeLayout(False)
            DirectCast(Me.radGroupNumericText, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupNumericText.ResumeLayout(False)
            Me.radGroupNumericText.PerformLayout()
            DirectCast(Me.radRadioAverage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioNumExpr2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioNumExpr1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupCheckBox.ResumeLayout(False)
            Me.radGroupCheckBox.PerformLayout()
            DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioCheckExpr2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioCheckExpr1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radGroupPreDef As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radRadioNumExpr1 As Telerik.WinControls.UI.RadRadioButton
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radRadioNumExpr2 As Telerik.WinControls.UI.RadRadioButton
        Private radGroupNumericText As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radGroupCheckBox As Telerik.WinControls.UI.RadGroupBox
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radRadioCheckExpr2 As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioCheckExpr1 As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioAverage As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radButtonExprEditor As Telerik.WinControls.UI.RadButton
    End Class
End Namespace

