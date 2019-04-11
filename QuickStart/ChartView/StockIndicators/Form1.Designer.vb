Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ChartView.StockIndicators
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
            Dim horizontalAxis As New Telerik.WinControls.UI.DateTimeCategoricalAxis()
            Dim verticalAxis As New Telerik.WinControls.UI.LinearAxis()
            Dim horizontalAxis2 As New Telerik.WinControls.UI.DateTimeCategoricalAxis()
            Dim verticalAxis2 As New Telerik.WinControls.UI.LinearAxis()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radDropDownList3 = New Telerik.WinControls.UI.RadDropDownList()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radChartView2.SuspendLayout()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownList3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radDropDownList3)
            Me.settingsPanel.Controls.Add(Me.radDropDownList2)
            Me.settingsPanel.Controls.Add(Me.radDropDownList1)
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.radLabel2)
            Me.settingsPanel.Controls.Add(Me.radLabel3)
            Me.settingsPanel.Location = New System.Drawing.Point(962, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(336, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.radChartView1.Location = New System.Drawing.Point(77, 400)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowLegend = False
            Me.radChartView1.ShowTitle = False
            Me.radChartView1.Size = New System.Drawing.Size(480, 160)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.Title = "Chart title"
            Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
            '
            '
            horizontalAxis2.LabelFormat = "{0:dd.MM}"
            horizontalAxis2.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine
            horizontalAxis2.MajorTickInterval = 5
            Me.radChartView1.Area.Axes.Add(horizontalAxis2)
            '
            '
            verticalAxis2.Minimum = 0
            verticalAxis2.Maximum = 100
            verticalAxis2.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right
            verticalAxis2.AxisType = Telerik.Charting.AxisType.Second
            Me.radChartView1.Area.Axes.Add(verticalAxis2)
            ' 
            ' radChartView2
            ' 
            Me.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView2.Location = New System.Drawing.Point(77, 58)
            Me.radChartView2.Name = "radChartView2"
            Me.radChartView2.ShowLegend = False
            Me.radChartView2.ShowTitle = False
            Me.radChartView2.Size = New System.Drawing.Size(480, 320)
            Me.radChartView2.TabIndex = 2
            Me.radChartView2.Text = "radChartView2"
            Me.radChartView2.Title = "Chart title"
            Me.radChartView2.View.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
            Me.radChartView2.ShowTitle = True
            Me.radChartView2.Title = "Investor Adviser: International Software Company (ISC)"
            Me.radChartView2.ChartElement.TitlePosition = Telerik.WinControls.UI.TitlePosition.Top
            Me.radChartView2.ChartElement.TitleElement.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
            '
            '            
            horizontalAxis.LabelFormat = "{0:dd.MM}"
            horizontalAxis.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine
            horizontalAxis.MajorTickInterval = 5
            Me.radChartView2.Area.Axes.Add(horizontalAxis)
            '
            '
            verticalAxis.Minimum = 50
            verticalAxis.Maximum = 80
            verticalAxis.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second
            Me.radChartView2.Area.Axes.Add(verticalAxis)
            ' 
            ' radDropDownList1
            ' 
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownList1.Location = New System.Drawing.Point(114, 32)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(119, 20)
            Me.radDropDownList1.TabIndex = 1
            Me.radDropDownList1.Text = "radDropDownList1"
            ' 
            ' radDropDownList2
            ' 
            Me.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownList2.Location = New System.Drawing.Point(114, 82)
            Me.radDropDownList2.Name = "radDropDownList2"
            Me.radDropDownList2.Size = New System.Drawing.Size(119, 20)
            Me.radDropDownList2.TabIndex = 2
            Me.radDropDownList2.Text = "radDropDownList2"
            ' 
            ' radDropDownList3
            ' 
            Me.radDropDownList3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownList3.Location = New System.Drawing.Point(114, 132)
            Me.radDropDownList3.Name = "radDropDownList3"
            Me.radDropDownList3.Size = New System.Drawing.Size(119, 20)
            Me.radDropDownList3.TabIndex = 3
            Me.radDropDownList3.Text = "radDropDownList3"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New System.Drawing.Point(114, 8)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(120, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Series Type:"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Location = New System.Drawing.Point(114, 58)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(120, 18)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "Moving Average indicator:"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Location = New System.Drawing.Point(114, 108)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(120, 18)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "Financial indicator:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Controls.Add(Me.radChartView2)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1195, 832)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            Me.Controls.SetChildIndex(Me.radChartView2, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radChartView2.ResumeLayout(False)
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownList3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region

        Private radDropDownList3 As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radChartView1 As Telerik.WinControls.UI.RadChartView
        Private radChartView2 As Telerik.WinControls.UI.RadChartView
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace