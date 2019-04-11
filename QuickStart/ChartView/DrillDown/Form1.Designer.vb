Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.DrillDown
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
            Me.btnSpy = New Telerik.WinControls.UI.RadButton()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.radChartView1 = New RadChartView()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()

            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Size = New System.Drawing.Size(196, 279)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            
            ' 
            ' 
            ' 
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.AreaDesign = cartesianArea1
            Me.radChartView1.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            ' 
            ' 
            ' 
            Me.radChartView1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 480, 320)
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New System.Drawing.Size(1265, 555)
            Me.radChartView1.TabIndex = 0
            Me.radChartView1.Text = "radChartView1"
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = Me.chartDataSet
            Me.bindingSource1.Position = 0


            ' radDropDownList1
            ' 
            Me.radDropDownList1.Location = New System.Drawing.Point(5, 21)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(165, 20)
            Me.radDropDownList1.TabIndex = 1
            Me.radDropDownList1.Text = "radDropDownList1"
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
            Me.radGroupBox1.HeaderText = "Drill Navigator Style"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 46)
            Me.radGroupBox1.Name = "radGroupBox1"
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(175, 58)
            Me.radGroupBox1.TabIndex = 2
            Me.radGroupBox1.Text = "Drill Navigator Style"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1265, 555)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()

            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents radChartView1 As Telerik.WinControls.UI.RadChartView
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private chartDataSet As Telerik.Examples.WinControls.DataSources.ChartDataSet
        Private btnSpy As Telerik.WinControls.UI.RadButton
        Friend WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    End Class
End Namespace


