
Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.ChartView.FirstLook
    Partial Class Form1
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
            Me.tableLayoutPanel1 = New Telerik.Examples.WinControls.ChartView.FirstLook.CustomTableLayoutPanel()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
            Me.radChartView3 = New Telerik.WinControls.UI.RadChartView()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
            Me.legend1 = New Telerik.Examples.WinControls.ChartView.FirstLook.Legend()
            Me.legend2 = New Telerik.Examples.WinControls.ChartView.FirstLook.Legend()
            Me.legend3 = New Telerik.Examples.WinControls.ChartView.FirstLook.Legend()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.legend1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.legend2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.legend3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(1501, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(0, 0)
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 4
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radChartView1, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radChartView2, 2, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radChartView3, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radGridView1, 2, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel2, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel3, 2, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel4, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.legend1, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.legend2, 3, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.legend3, 1, 4)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 5
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(0, 0)
            Me.tableLayoutPanel1.TabIndex = 1
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.SetColumnSpan(Me.radGridView1, 2)
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Margin = New System.Windows.Forms.Padding(0)
            Me.radGridView1.Size = New System.Drawing.Size(592, 458)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.Text = "radGridView1"
            Me.radGridView1.GridViewElement.BorderColor = System.Drawing.Color.White

            ' 
            ' radChartView1
            ' 
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 45)
            Me.radChartView1.Margin = New System.Windows.Forms.Padding(0)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.Size = New System.Drawing.Size(1, 1)
            Me.radChartView1.TabIndex = 0
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(10)
            ' 
            ' radChartView2
            ' 
            Me.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie
            Me.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView2.Location = New System.Drawing.Point(1, 45)
            Me.radChartView2.Margin = New System.Windows.Forms.Padding(0)
            Me.radChartView2.Name = "radChartView2"
            Me.radChartView2.Size = New System.Drawing.Size(1, 1)
            Me.radChartView2.TabIndex = 1
            Me.radChartView2.Text = "radChartView2"
            Me.radChartView2.View.Margin = New System.Windows.Forms.Padding(10)
            ' 
            ' radChartView3
            ' 
            Me.radChartView3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView3.Location = New System.Drawing.Point(0, 23)
            Me.radChartView3.Margin = New System.Windows.Forms.Padding(0)
            Me.radChartView3.Name = "radChartView3"
            Me.radChartView3.Size = New System.Drawing.Size(1, 1)
            Me.radChartView3.TabIndex = 2
            Me.radChartView3.Text = "radChartView3"
            Me.radChartView3.View.Margin = New System.Windows.Forms.Padding(10)
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.BackColor = System.Drawing.Color.FromArgb(238, 239, 238)
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel1, 4)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(2, 45)
            Me.radPanel1.TabIndex = 4
            Me.radPanel1.Text = "SALES DASHBOARD 2012"
            DirectCast(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "SALES DASHBOARD 2012"
            DirectCast(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(238, 239, 238)
            DirectCast(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.BackColor = System.Drawing.Color.White
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel2, 2)
            Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel2.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radPanel2.Location = New System.Drawing.Point(0, 0)
            Me.radPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.radPanel2.Name = "radPanel1"
            Me.radPanel2.Size = New System.Drawing.Size(2, 45)
            Me.radPanel2.TabIndex = 4
            Me.radPanel2.Text = "SALES DASHBOARD 2012"
            DirectCast(Me.radPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Total sales by product"
            DirectCast(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
            DirectCast(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ' 
            ' radPanel3
            ' 
            Me.radPanel3.BackColor = System.Drawing.Color.White
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel3, 2)
            Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel3.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radPanel3.Location = New System.Drawing.Point(0, 0)
            Me.radPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.radPanel3.Name = "radPanel1"
            Me.radPanel3.Size = New System.Drawing.Size(2, 45)
            Me.radPanel3.TabIndex = 4
            Me.radPanel3.Text = "SALES DASHBOARD 2012"
            DirectCast(Me.radPanel3.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Sales breakdown by region"
            DirectCast(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
            DirectCast(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            ' 
            ' radPanel4
            ' 
            Me.radPanel4.BackColor = System.Drawing.Color.White
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel4, 4)
            Me.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel4.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radPanel4.Location = New System.Drawing.Point(0, 0)
            Me.radPanel4.Margin = New System.Windows.Forms.Padding(0)
            Me.radPanel4.Name = "radPanel1"
            Me.radPanel4.Size = New System.Drawing.Size(2, 45)
            Me.radPanel4.TabIndex = 4
            Me.radPanel4.Text = "SALES DASHBOARD 2012"
            DirectCast(Me.radPanel4.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Percent of target"
            DirectCast(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
            DirectCast(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)

            ' 
            ' legend1
            ' 
            Me.legend1.BackColor = System.Drawing.Color.White
            Me.legend1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.legend1.Location = New System.Drawing.Point(-99, 45)
            Me.legend1.Margin = New System.Windows.Forms.Padding(0)
            Me.legend1.Name = "legend1"
            Me.legend1.Size = New System.Drawing.Size(100, 1)
            Me.legend1.TabIndex = 5
            ' 
            ' legend2
            ' 
            Me.legend2.BackColor = System.Drawing.Color.White
            Me.legend2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.legend2.Location = New System.Drawing.Point(-98, 45)
            Me.legend2.Margin = New System.Windows.Forms.Padding(0)
            Me.legend2.Name = "legend2"
            Me.legend2.Size = New System.Drawing.Size(100, 1)
            Me.legend2.TabIndex = 6
            ' 
            ' legend3
            ' 
            Me.legend3.BackColor = System.Drawing.Color.White
            Me.legend3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.legend3.Location = New System.Drawing.Point(-99, 23)
            Me.legend3.Margin = New System.Windows.Forms.Padding(0)
            Me.legend3.Name = "legend3"
            Me.legend3.Size = New System.Drawing.Size(100, 1)
            Me.legend3.TabIndex = 7
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(0, 0)
            Me.Controls.SetChildIndex(Me.tableLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.legend1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.legend2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.legend3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tableLayoutPanel1 As CustomTableLayoutPanel
        Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
        Private WithEvents radChartView1 As Telerik.WinControls.UI.RadChartView
        Private WithEvents radChartView2 As Telerik.WinControls.UI.RadChartView
        Private WithEvents radChartView3 As Telerik.WinControls.UI.RadChartView
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private radPanel3 As Telerik.WinControls.UI.RadPanel
        Private radPanel4 As Telerik.WinControls.UI.RadPanel
        Private legend1 As Legend
        Private legend2 As Legend
        Private legend3 As Legend

    End Class
End Namespace