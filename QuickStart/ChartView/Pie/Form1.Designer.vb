Namespace Telerik.Examples.WinControls.ChartView.Pie
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.RadRadioButtonDonut = New Telerik.WinControls.UI.RadRadioButton()
            Me.RadRadioButtonPie = New Telerik.WinControls.UI.RadRadioButton()
            Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.RadSpinDonutRadius = New Telerik.WinControls.UI.RadSpinEditor()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadGroupBox1.SuspendLayout()
            CType(Me.RadRadioButtonDonut, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadRadioButtonPie, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSpinDonutRadius, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.RadSpinDonutRadius)
            Me.settingsPanel.Controls.Add(Me.RadLabel4)
            Me.settingsPanel.Controls.Add(Me.RadGroupBox1)
            Me.settingsPanel.Controls.Add(Me.radDropDownList1)
            Me.settingsPanel.Controls.Add(Me.radLabel3)
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.radLabel2)
            Me.settingsPanel.Controls.Add(Me.radSpinEditor1)
            Me.settingsPanel.Controls.Add(Me.radCheckBox1)
            Me.settingsPanel.Controls.Add(Me.radSpinEditor2)
            Me.settingsPanel.Location = New System.Drawing.Point(994, 46)
            Me.settingsPanel.Size = New System.Drawing.Size(220, 364)
            Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditor2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditor1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.RadGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.RadLabel4, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.RadSpinDonutRadius, 0)
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(14, 8)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(64, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "Start Angle:"
            '
            'radSpinEditor1
            '
            Me.radSpinEditor1.Location = New System.Drawing.Point(14, 32)
            Me.radSpinEditor1.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
            Me.radSpinEditor1.Name = "radSpinEditor1"
            '
            '
            '
            Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor1.Size = New System.Drawing.Size(100, 20)
            Me.radSpinEditor1.TabIndex = 2
            Me.radSpinEditor1.TabStop = False
            Me.radSpinEditor1.Value = New Decimal(New Integer() {270, 0, 0, 0})
            Me.radSpinEditor1.Wrap = True
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(14, 58)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(68, 18)
            Me.radLabel2.TabIndex = 3
            Me.radLabel2.Text = "Total Range:"
            '
            'radSpinEditor2
            '
            Me.radSpinEditor2.Location = New System.Drawing.Point(14, 82)
            Me.radSpinEditor2.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
            Me.radSpinEditor2.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
            Me.radSpinEditor2.Name = "radSpinEditor2"
            '
            '
            '
            Me.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor2.Size = New System.Drawing.Size(100, 20)
            Me.radSpinEditor2.TabIndex = 4
            Me.radSpinEditor2.TabStop = False
            Me.radSpinEditor2.Value = New Decimal(New Integer() {360, 0, 0, 0})
            '
            'radCheckBox1
            '
            Me.radCheckBox1.Location = New System.Drawing.Point(14, 158)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(82, 18)
            Me.radCheckBox1.TabIndex = 5
            Me.radCheckBox1.Text = "Show Labels"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radLabel3
            '
            Me.radLabel3.Location = New System.Drawing.Point(14, 108)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(87, 18)
            Me.radLabel3.TabIndex = 6
            Me.radLabel3.Text = "Selection Mode:"
            '
            'radDropDownList1
            '
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownList1.Location = New System.Drawing.Point(14, 132)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.NullText = "Choose selection mode"
            Me.radDropDownList1.Size = New System.Drawing.Size(106, 20)
            Me.radDropDownList1.TabIndex = 7
            '
            'radChartView1
            '
            Me.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowLegend = False
            Me.radChartView1.ShowTitle = False
            Me.radChartView1.Size = New System.Drawing.Size(1391, 832)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.Title = "Chart title"
            '
            'RadGroupBox1
            '
            Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.RadGroupBox1.Controls.Add(Me.RadRadioButtonDonut)
            Me.RadGroupBox1.Controls.Add(Me.RadRadioButtonPie)
            Me.RadGroupBox1.HeaderText = "Chart type"
            Me.RadGroupBox1.Location = New System.Drawing.Point(14, 181)
            Me.RadGroupBox1.Name = "RadGroupBox1"
            Me.RadGroupBox1.Size = New System.Drawing.Size(200, 80)
            Me.RadGroupBox1.TabIndex = 8
            Me.RadGroupBox1.Text = "Chart type"
            '
            'RadRadioButtonDonut
            '
            Me.RadRadioButtonDonut.Location = New System.Drawing.Point(6, 49)
            Me.RadRadioButtonDonut.Name = "RadRadioButtonDonut"
            Me.RadRadioButtonDonut.Size = New System.Drawing.Size(110, 18)
            Me.RadRadioButtonDonut.TabIndex = 1
            Me.RadRadioButtonDonut.Text = "Donut"
            '
            'RadRadioButtonPie
            '
            Me.RadRadioButtonPie.Location = New System.Drawing.Point(6, 24)
            Me.RadRadioButtonPie.Name = "RadRadioButtonPie"
            Me.RadRadioButtonPie.Size = New System.Drawing.Size(110, 18)
            Me.RadRadioButtonPie.TabIndex = 0
            Me.RadRadioButtonPie.Text = "Pie"
            Me.RadRadioButtonPie.IsChecked = True
            '
            'RadLabel4
            '
            Me.RadLabel4.Location = New System.Drawing.Point(14, 268)
            Me.RadLabel4.Name = "RadLabel4"
            Me.RadLabel4.Size = New System.Drawing.Size(105, 18)
            Me.RadLabel4.TabIndex = 9
            Me.RadLabel4.Text = "Donut radius factor:"
            '
            'RadSpinDonutRadius
            '
            Me.RadSpinDonutRadius.Location = New System.Drawing.Point(14, 293)
            Me.RadSpinDonutRadius.Name = "RadSpinDonutRadius"
            Me.RadSpinDonutRadius.Size = New System.Drawing.Size(100, 20)
            Me.RadSpinDonutRadius.TabIndex = 10
            Me.RadSpinDonutRadius.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1391, 832)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadGroupBox1.ResumeLayout(False)
            CType(Me.RadRadioButtonDonut, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadRadioButtonPie, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSpinDonutRadius, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents RadSpinDonutRadius As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents RadRadioButtonDonut As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents RadRadioButtonPie As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace