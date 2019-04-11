Namespace Telerik.Examples.WinControls.ChartView.Polar
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
			Dim polarAxis1 As New Telerik.WinControls.UI.PolarAxis()
			Dim polarAxis2 As New Telerik.WinControls.UI.PolarAxis()
			Dim polarAxis3 As New Telerik.WinControls.UI.PolarAxis()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim styleSheet1 As New Telerik.WinControls.StyleSheet()
			Dim styleSheet2 As New Telerik.WinControls.StyleSheet()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(994, 46)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.Style = Nothing
			Me.settingsPanel.Size = New System.Drawing.Size(160, 347)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Polar
			Me.radChartView1.Axes.Add(polarAxis1)
			Me.radChartView1.Axes.Add(polarAxis2)
			Me.radChartView1.Axes.Add(polarAxis3)
			Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radChartView1.Location = New System.Drawing.Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.Style = Nothing
			Me.radChartView1.Size = New System.Drawing.Size(1306, 815)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radDropDownList1.DropDownAnimationEnabled = True
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Selected = True
			radListDataItem1.Text = "Line"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Area"
			radListDataItem2.TextWrap = True
			Me.radDropDownList1.Items.Add(radListDataItem1)
			Me.radDropDownList1.Items.Add(radListDataItem2)
			Me.radDropDownList1.Location = New System.Drawing.Point(5, 37)
			Me.radDropDownList1.MaxDropDownItems = 0
			Me.radDropDownList1.Name = "radDropDownList1"
			' 
			' 
			' 
			Me.radDropDownList1.RootElement.Style = styleSheet1
			Me.radDropDownList1.ShowImageInEditorArea = True
			Me.radDropDownList1.Size = New System.Drawing.Size(143, 20)
			Me.radDropDownList1.TabIndex = 1
			Me.radDropDownList1.Text = "Line"
'			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Series type"
			Me.radGroupBox1.Location = New System.Drawing.Point(4, 5)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Style = styleSheet2
			Me.radGroupBox1.Size = New System.Drawing.Size(153, 91)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Series type"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1306, 815)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace