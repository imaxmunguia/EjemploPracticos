
Namespace Telerik.Examples.WinControls.ChartView.MultiAxes
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
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1091, 3)
			Me.settingsPanel.Size = New System.Drawing.Size(202, 468)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Location = New System.Drawing.Point(3, 3)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New System.Drawing.Size(641, 443)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1296, 934)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
	End Class
End Namespace
