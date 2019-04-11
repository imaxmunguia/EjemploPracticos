Namespace Telerik.Examples.WinControls.ChartView.Scatter
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
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonEditShape = New Telerik.WinControls.UI.RadButton()
			Me.radDropDownListShapes = New Telerik.WinControls.UI.RadDropDownList()
			Me.radDropDownListSeries = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorPointRadius = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListSeries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorPointRadius, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			'
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radDropDownListSeries)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1031, 216)
			Me.settingsPanel.Size = New System.Drawing.Size(220, 358)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radChartView1
			' 
			Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radChartView1.Location = New System.Drawing.Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.Size = New System.Drawing.Size(1297, 732)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorPointRadius)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radButtonEditShape)
			Me.radGroupBox1.Controls.Add(Me.radDropDownListShapes)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Series1 Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(4, 47)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New System.Drawing.Size(213, 171)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "radGroupBox1"
			' 
			' radButtonEditShape
			' 
			Me.radButtonEditShape.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.radButtonEditShape.Location = New System.Drawing.Point(42, 128)
			Me.radButtonEditShape.Name = "radButtonEditShape"
			Me.radButtonEditShape.Size = New System.Drawing.Size(130, 30)
			Me.radButtonEditShape.TabIndex = 1
			Me.radButtonEditShape.Text = "Edit shape"
			' 
			' radDropDownListShapes
			' 
			Me.radDropDownListShapes.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radDropDownListShapes.DropDownAnimationEnabled = True
			Me.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListShapes.Location = New System.Drawing.Point(6, 46)
			Me.radDropDownListShapes.MaxDropDownItems = 0
			Me.radDropDownListShapes.Name = "radDropDownListShapes"
			Me.radDropDownListShapes.ShowImageInEditorArea = True
			Me.radDropDownListShapes.Size = New System.Drawing.Size(202, 20)
			Me.radDropDownListShapes.TabIndex = 0
			Me.radDropDownListShapes.Text = "radDropDownList1"
			' 
			' radDropDownListSeries
			' 
			Me.radDropDownListSeries.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radDropDownListSeries.DropDownAnimationEnabled = True
			Me.radDropDownListSeries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListSeries.Location = New System.Drawing.Point(6, 20)
			Me.radDropDownListSeries.MaxDropDownItems = 0
			Me.radDropDownListSeries.Name = "radDropDownListSeries"
			Me.radDropDownListSeries.ShowImageInEditorArea = True
			Me.radDropDownListSeries.Size = New System.Drawing.Size(202, 20)
			Me.radDropDownListSeries.TabIndex = 0
			Me.radDropDownListSeries.Text = "radDropDownList1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(6, 22)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(37, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Shape"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(6, 0)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(36, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Series"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(7, 72)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(66, 18)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "Point size"
			' 
			' radSpinEditorPointRadius
			' 
			Me.radSpinEditorPointRadius.Location = New System.Drawing.Point(7, 96)
			Me.radSpinEditorPointRadius.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius"
			' 
			' 
			' 
			Me.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorPointRadius.ShowBorder = True
			Me.radSpinEditorPointRadius.Size = New System.Drawing.Size(100, 20)
			Me.radSpinEditorPointRadius.TabIndex = 3
			Me.radSpinEditorPointRadius.TabStop = False
			Me.radSpinEditorPointRadius.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1297, 732)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListSeries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorPointRadius, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radDropDownListShapes As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radButtonEditShape As Telerik.WinControls.UI.RadButton
		Private radDropDownListSeries As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorPointRadius As Telerik.WinControls.UI.RadSpinEditor
	End Class
End Namespace
