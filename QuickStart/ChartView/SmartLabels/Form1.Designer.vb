
Namespace Telerik.Examples.WinControls.ChartView.SmartLabels
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
            Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
            Dim CartesianArea2 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.customTableLayoutPanel1 = New Telerik.Examples.WinControls.ChartView.FirstLook.CustomTableLayoutPanel()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.customTableLayoutPanel1.SuspendLayout()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(1380, 3)
            Me.settingsPanel.Size = New System.Drawing.Size(171, 493)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            '
            'radCheckBox1
            '
            Me.radCheckBox1.Location = New System.Drawing.Point(6, 48)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(126, 18)
            Me.radCheckBox1.TabIndex = 1
            Me.radCheckBox1.Text = "Draw connecting line"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBox2
            '
            Me.radCheckBox2.Location = New System.Drawing.Point(6, 72)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(115, 18)
            Me.radCheckBox2.TabIndex = 1
            Me.radCheckBox2.Text = "Draw labels border"
            Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBox3
            '
            Me.radCheckBox3.Location = New System.Drawing.Point(6, 120)
            Me.radCheckBox3.Name = "radCheckBox3"
            Me.radCheckBox3.Size = New System.Drawing.Size(124, 18)
            Me.radCheckBox3.TabIndex = 1
            Me.radCheckBox3.Text = "Sync labels line color"
            Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBox4
            '
            Me.radCheckBox4.Location = New System.Drawing.Point(6, 96)
            Me.radCheckBox4.Name = "radCheckBox4"
            Me.radCheckBox4.Size = New System.Drawing.Size(140, 18)
            Me.radCheckBox4.TabIndex = 1
            Me.radCheckBox4.Text = "Sync labels border color"
            Me.radCheckBox4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radSpinEditor1)
            Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
            Me.radGroupBox1.Controls.Add(Me.radCheckBox4)
            Me.radGroupBox1.Controls.Add(Me.radCheckBox3)
            Me.radGroupBox1.Controls.Add(Me.radCheckBox2)
            Me.radGroupBox1.Controls.Add(Me.radCheckBox1)
            Me.radGroupBox1.HeaderText = "Settings"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.radGroupBox1.Name = "radGroupBox1"
            '
            '
            '
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(300, 201)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Settings"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(6, 145)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(89, 18)
            Me.radLabel1.TabIndex = 4
            Me.radLabel1.Text = "Distance to label"
            '
            'radSpinEditor1
            '
            Me.radSpinEditor1.Location = New System.Drawing.Point(6, 169)
            Me.radSpinEditor1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditor1.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
            Me.radSpinEditor1.Name = "radSpinEditor1"
            Me.radSpinEditor1.Size = New System.Drawing.Size(159, 20)
            Me.radSpinEditor1.TabIndex = 3
            Me.radSpinEditor1.TabStop = False
            '
            'radDropDownList1
            '
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownList1.Location = New System.Drawing.Point(6, 22)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(159, 20)
            Me.radDropDownList1.TabIndex = 2
            Me.radDropDownList1.Text = "radDropDownList1"
            '
            'customTableLayoutPanel1
            '
            Me.customTableLayoutPanel1.ColumnCount = 2
            Me.customTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.customTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.customTableLayoutPanel1.Controls.Add(Me.radChartView1, 0, 0)
            Me.customTableLayoutPanel1.Controls.Add(Me.radChartView2, 1, 0)
            Me.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.customTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.customTableLayoutPanel1.Name = "customTableLayoutPanel1"
            Me.customTableLayoutPanel1.RowCount = 1
            Me.customTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.customTableLayoutPanel1.Size = New System.Drawing.Size(1554, 1084)
            Me.customTableLayoutPanel1.TabIndex = 1
            '
            'radChartView1
            '
            Me.radChartView1.AreaDesign = CartesianArea1
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(3, 3)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New System.Drawing.Size(771, 1078)
            Me.radChartView1.TabIndex = 0
            Me.radChartView1.Text = "radChartView1"
            '
            'radChartView2
            '
            Me.radChartView2.AreaDesign = CartesianArea2
            Me.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView2.Location = New System.Drawing.Point(780, 3)
            Me.radChartView2.Name = "radChartView2"
            Me.radChartView2.ShowGrid = False
            Me.radChartView2.Size = New System.Drawing.Size(771, 1078)
            Me.radChartView2.TabIndex = 0
            Me.radChartView2.Text = "radChartView1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.customTableLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1554, 1084)
            Me.Controls.SetChildIndex(Me.customTableLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.customTableLayoutPanel1.ResumeLayout(False)
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private customTableLayoutPanel1 As FirstLook.CustomTableLayoutPanel
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor

	End Class
End Namespace