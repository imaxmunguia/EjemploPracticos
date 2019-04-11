Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
    Partial Class Form1
        Inherits ExamplesForm
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radCheckBox2)
            Me.settingsPanel.Controls.Add(Me.radCheckBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(989, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(304, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox2, 0)
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.ChartElement.TitlePosition = Telerik.WinControls.UI.TitlePosition.Top
            Me.radChartView1.ChartElement.TitleElement.Font = New System.Drawing.Font("Segoe UI Light", 20.0F)
            Me.radChartView1.ChartElement.TitleElement.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowLegend = False
            Me.radChartView1.ShowTitle = True
            Me.radChartView1.Size = New System.Drawing.Size(1190, 832)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.Title = "Stock Index"
            Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(20, 0, 20, 20)
            ' 
            ' radCheckBox1
            ' 
            Me.radCheckBox1.Location = New System.Drawing.Point(98, 5)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(91, 18)
            Me.radCheckBox1.TabIndex = 1
            Me.radCheckBox1.Text = "Show Labels"
            Me.radCheckBox1.Checked = True
            ' 
            ' radCheckBox2
            ' 
            Me.radCheckBox2.Location = New System.Drawing.Point(98, 30)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(91, 18)
            Me.radCheckBox2.TabIndex = 2
            Me.radCheckBox2.Text = "Enable custom appearance"
            Me.radCheckBox2.Checked = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1190, 832)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents radChartView1 As Telerik.WinControls.UI.RadChartView
    End Class
End Namespace
