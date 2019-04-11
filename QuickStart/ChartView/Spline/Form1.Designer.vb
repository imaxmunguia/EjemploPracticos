Namespace Telerik.Examples.WinControls.ChartView.Spline
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim styleSheet1 As New Telerik.WinControls.StyleSheet()
			Dim styleSheet3 As New Telerik.WinControls.StyleSheet()
			Dim styleSheet2 As New Telerik.WinControls.StyleSheet()
			Dim styleSheet4 As New Telerik.WinControls.StyleSheet()
			Dim styleSheet5 As New Telerik.WinControls.StyleSheet()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radDropDownList1)
			Me.settingsPanel.Controls.Add(Me.radDropDownList2)
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(982, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.Style = Nothing
			Me.settingsPanel.Size = New System.Drawing.Size(238, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			' 
			' radChartView1
			' 
			Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radChartView1.Location = New System.Drawing.Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.Style = Nothing
			Me.radChartView1.Size = New System.Drawing.Size(1221, 749)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(27, 7)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.Style = styleSheet1
			Me.radLabel1.Size = New System.Drawing.Size(61, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Chart type:"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = True
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New System.Drawing.Point(27, 32)
			Me.radDropDownList1.MaxDropDownItems = 0
			Me.radDropDownList1.Name = "radDropDownList1"
			' 
			' 
			' 
			Me.radDropDownList1.RootElement.Style = styleSheet3
			Me.radDropDownList1.ShowImageInEditorArea = True
			Me.radDropDownList1.Size = New System.Drawing.Size(106, 20)
			Me.radDropDownList1.TabIndex = 2
'			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(27, 59)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.Style = styleSheet2
			Me.radLabel2.Size = New System.Drawing.Size(86, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Combine mode:"
			' 
			' radDropDownList2
			' 
			Me.radDropDownList2.DropDownAnimationEnabled = True
			Me.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList2.Location = New System.Drawing.Point(27, 84)
			Me.radDropDownList2.MaxDropDownItems = 0
			Me.radDropDownList2.Name = "radDropDownList2"
			' 
			' 
			' 
			Me.radDropDownList2.RootElement.Style = styleSheet4
			Me.radDropDownList2.ShowImageInEditorArea = True
			Me.radDropDownList2.Size = New System.Drawing.Size(106, 20)
			Me.radDropDownList2.TabIndex = 4
'			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New System.Drawing.Point(27, 110)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.Style = styleSheet5
			Me.radCheckBox1.Size = New System.Drawing.Size(79, 18)
			Me.radCheckBox1.TabIndex = 5
			Me.radCheckBox1.Text = "Show labels"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			' 
			' Form1
			' 
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1221, 749)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
