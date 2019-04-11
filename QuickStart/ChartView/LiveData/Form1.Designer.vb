'using Telerik.Examples.WinControls.ChartView.FirstLook;
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ChartView.LiveData
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
            Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
            Me.exampleCustomShapeControl1 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
            Me.exampleCustomShapeControl2 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
            Me.exampleCustomShapeControl3 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.SuspendLayout()
            DirectCast(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel4.SuspendLayout()
            DirectCast(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel3.SuspendLayout()
            DirectCast(Me.exampleCustomShapeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.exampleCustomShapeControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.exampleCustomShapeControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(938, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(164, 360)
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.BackColor = System.Drawing.Color.Transparent
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radChartView1.Location = New System.Drawing.Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowLegend = False
            Me.radChartView1.ShowTitle = True
            Me.radChartView1.Size = New System.Drawing.Size(846, 126)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.Title = "Messages Sent/Received"
            ' 
            ' radChartView2
            ' 
            Me.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView2.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radChartView2.Location = New System.Drawing.Point(0, 0)
            Me.radChartView2.Name = "radChartView2"
            Me.radChartView2.ShowLegend = False
            Me.radChartView2.ShowTitle = True
            Me.radChartView2.Size = New System.Drawing.Size(567, 234)
            Me.radChartView2.TabIndex = 2
            Me.radChartView2.Text = "radChartView2"
            Me.radChartView2.Title = "Site Activity by Time of Day"
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Controls.Add(Me.radChartView1)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(846, 126)
            Me.radPanel1.TabIndex = 3
            Me.radPanel1.Text = "radPanel1"
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.Controls.Add(Me.radPanel4)
            Me.radPanel2.Controls.Add(Me.radPanel3)
            Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.radPanel2.Location = New System.Drawing.Point(0, 126)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Size = New System.Drawing.Size(846, 234)
            Me.radPanel2.TabIndex = 4
            Me.radPanel2.Text = "radPanel2"
            ' 
            ' radPanel4
            ' 
            Me.radPanel4.Controls.Add(Me.radChartView2)
            Me.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel4.Location = New System.Drawing.Point(0, 0)
            Me.radPanel4.Name = "radPanel4"
            Me.radPanel4.Size = New System.Drawing.Size(567, 234)
            Me.radPanel4.TabIndex = 1
            Me.radPanel4.Text = "radPanel4"
            ' 
            ' radPanel3
            ' 
            Me.radPanel3.BackColor = System.Drawing.Color.White
            Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl1)
            Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl2)
            Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl3)
            Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.radPanel3.Location = New System.Drawing.Point(567, 0)
            Me.radPanel3.Name = "radPanel3"
            Me.radPanel3.Size = New System.Drawing.Size(279, 234)
            Me.radPanel3.TabIndex = 0
            DirectCast(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
            ' 
            ' exampleCustomShapeControl1
            ' 
            Me.exampleCustomShapeControl1.LeftText = "1,200"
            Me.exampleCustomShapeControl1.Location = New System.Drawing.Point(90, 45)
            Me.exampleCustomShapeControl1.Name = "exampleCustomShapeControl1"
            Me.exampleCustomShapeControl1.RightText = "AVG Messages per second"
            Me.exampleCustomShapeControl1.Size = New System.Drawing.Size(190, 45)
            Me.exampleCustomShapeControl1.TabIndex = 0
            Me.exampleCustomShapeControl1.Text = "exampleCustomShapeControl1"
            ' 
            ' exampleCustomShapeControl2
            ' 
            Me.exampleCustomShapeControl2.LeftText = "53,210"
            Me.exampleCustomShapeControl2.Location = New System.Drawing.Point(65, 100)
            Me.exampleCustomShapeControl2.Name = "exampleCustomShapeControl2"
            Me.exampleCustomShapeControl2.RightText = "AVG Messages per minute"
            Me.exampleCustomShapeControl2.Size = New System.Drawing.Size(215, 45)
            Me.exampleCustomShapeControl2.TabIndex = 0
            Me.exampleCustomShapeControl2.Text = "exampleCustomShapeControl2"
            ' 
            ' exampleCustomShapeControl3
            ' 
            Me.exampleCustomShapeControl3.LeftText = "3,729,600"
            Me.exampleCustomShapeControl3.Location = New System.Drawing.Point(40, 155)
            Me.exampleCustomShapeControl3.Name = "exampleCustomShapeControl3"
            Me.exampleCustomShapeControl3.RightText = "AVG Messages per hour"
            Me.exampleCustomShapeControl3.Size = New System.Drawing.Size(240, 45)
            Me.exampleCustomShapeControl3.TabIndex = 0
            Me.exampleCustomShapeControl3.Text = "exampleCustomShapeControl3"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Controls.Add(Me.radPanel2)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(846, 360)
            Me.Controls.SetChildIndex(Me.radPanel2, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            DirectCast(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel4.ResumeLayout(False)
            DirectCast(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel3.ResumeLayout(False)
            DirectCast(Me.exampleCustomShapeControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.exampleCustomShapeControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.exampleCustomShapeControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radChartView1 As Telerik.WinControls.UI.RadChartView
        Private radChartView2 As Telerik.WinControls.UI.RadChartView
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private radPanel4 As Telerik.WinControls.UI.RadPanel
        Private radPanel3 As Telerik.WinControls.UI.RadPanel
        Private exampleCustomShapeControl1 As ExampleCustomShapeControl
        Private exampleCustomShapeControl2 As ExampleCustomShapeControl
        Private exampleCustomShapeControl3 As ExampleCustomShapeControl
    End Class
End Namespace