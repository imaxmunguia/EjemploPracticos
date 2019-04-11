Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ChartView.Legend
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
            Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxFlipText = New Telerik.WinControls.UI.RadCheckBox()
            Me.radTextBoxControlTitle = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radLabelTitle = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListTitlePosition = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabelTitleOrientation = New Telerik.WinControls.UI.RadLabel()
            Me.radRadioButtonHorizontalTitle = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonVerticalTitle = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radButtonEditShape = New Telerik.WinControls.UI.RadButton()
            Me.radDropDownListShapes = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabelMarkerShape = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListLegendPosition = New Telerik.WinControls.UI.RadDropDownList()
            Me.radSpinEditorLegendX = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radRadioButtonVerticalLegend = New Telerik.WinControls.UI.RadRadioButton()
            Me.radSpinEditorLegendY = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radRadioButtonHorizontalLegend = New Telerik.WinControls.UI.RadRadioButton()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radCheckBoxFlipText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxControlTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListTitlePosition, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTitleOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHorizontalTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonVerticalTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMarkerShape, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListLegendPosition, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorLegendX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonVerticalLegend, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorLegendY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHorizontalLegend, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(835, 45)
            Me.settingsPanel.Size = New System.Drawing.Size(194, 690)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxFlipText)
            Me.radGroupBox1.Controls.Add(Me.radTextBoxControlTitle)
            Me.radGroupBox1.Controls.Add(Me.radLabelTitle)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radDropDownListTitlePosition)
            Me.radGroupBox1.Controls.Add(Me.radLabelTitleOrientation)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonHorizontalTitle)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonVerticalTitle)
            Me.radGroupBox1.HeaderText = "Title"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.radGroupBox1.Name = "radGroupBox1"
            '
            '
            '
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(205, 194)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Title"
            '
            'radCheckBoxFlipText
            '
            Me.radCheckBoxFlipText.AutoSize = True
            Me.radCheckBoxFlipText.Location = New System.Drawing.Point(115, 144)
            Me.radCheckBoxFlipText.Name = "radCheckBoxFlipText"
            Me.radCheckBoxFlipText.Size = New System.Drawing.Size(60, 18)
            Me.radCheckBoxFlipText.TabIndex = 13
            Me.radCheckBoxFlipText.Text = "Flip text"
            '
            'radTextBoxControlTitle
            '
            Me.radTextBoxControlTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radTextBoxControlTitle.Location = New System.Drawing.Point(9, 44)
            Me.radTextBoxControlTitle.Name = "radTextBoxControlTitle"
            Me.radTextBoxControlTitle.NullText = "Chart title"
            Me.radTextBoxControlTitle.Size = New System.Drawing.Size(185, 20)
            Me.radTextBoxControlTitle.TabIndex = 12
            '
            'radLabelTitle
            '
            Me.radLabelTitle.AutoSize = True
            Me.radLabelTitle.Location = New System.Drawing.Point(9, 20)
            Me.radLabelTitle.Name = "radLabelTitle"
            Me.radLabelTitle.Size = New System.Drawing.Size(27, 18)
            Me.radLabelTitle.TabIndex = 8
            Me.radLabelTitle.Text = "Title"
            '
            'radLabel1
            '
            Me.radLabel1.AutoSize = True
            Me.radLabel1.Location = New System.Drawing.Point(9, 70)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(46, 18)
            Me.radLabel1.TabIndex = 8
            Me.radLabel1.Text = "Position"
            '
            'radDropDownListTitlePosition
            '
            Me.radDropDownListTitlePosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radDropDownListTitlePosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListTitlePosition.Location = New System.Drawing.Point(9, 94)
            Me.radDropDownListTitlePosition.Name = "radDropDownListTitlePosition"
            Me.radDropDownListTitlePosition.Size = New System.Drawing.Size(185, 20)
            Me.radDropDownListTitlePosition.TabIndex = 7
            Me.radDropDownListTitlePosition.Text = "Title position"
            '
            'radLabelTitleOrientation
            '
            Me.radLabelTitleOrientation.AutoSize = True
            Me.radLabelTitleOrientation.Location = New System.Drawing.Point(9, 120)
            Me.radLabelTitleOrientation.Name = "radLabelTitleOrientation"
            Me.radLabelTitleOrientation.Size = New System.Drawing.Size(85, 18)
            Me.radLabelTitleOrientation.TabIndex = 9
            Me.radLabelTitleOrientation.Text = "Title orientation"
            '
            'radRadioButtonHorizontalTitle
            '
            Me.radRadioButtonHorizontalTitle.AutoSize = True
            Me.radRadioButtonHorizontalTitle.Location = New System.Drawing.Point(9, 144)
            Me.radRadioButtonHorizontalTitle.Name = "radRadioButtonHorizontalTitle"
            Me.radRadioButtonHorizontalTitle.Size = New System.Drawing.Size(72, 18)
            Me.radRadioButtonHorizontalTitle.TabIndex = 10
            Me.radRadioButtonHorizontalTitle.TabStop = True
            Me.radRadioButtonHorizontalTitle.Text = "Horizontal"
            Me.radRadioButtonHorizontalTitle.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radRadioButtonVerticalTitle
            '
            Me.radRadioButtonVerticalTitle.AutoSize = True
            Me.radRadioButtonVerticalTitle.Location = New System.Drawing.Point(9, 168)
            Me.radRadioButtonVerticalTitle.Name = "radRadioButtonVerticalTitle"
            Me.radRadioButtonVerticalTitle.Size = New System.Drawing.Size(57, 18)
            Me.radRadioButtonVerticalTitle.TabIndex = 11
            Me.radRadioButtonVerticalTitle.Text = "Vertical"
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radGroupBox2.Controls.Add(Me.radButtonEditShape)
            Me.radGroupBox2.Controls.Add(Me.radDropDownListShapes)
            Me.radGroupBox2.Controls.Add(Me.radLabelMarkerShape)
            Me.radGroupBox2.Controls.Add(Me.radLabel4)
            Me.radGroupBox2.Controls.Add(Me.radLabel3)
            Me.radGroupBox2.Controls.Add(Me.radLabel5)
            Me.radGroupBox2.Controls.Add(Me.radLabel2)
            Me.radGroupBox2.Controls.Add(Me.radDropDownListLegendPosition)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorLegendX)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonVerticalLegend)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorLegendY)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonHorizontalLegend)
            Me.radGroupBox2.HeaderText = "Legend"
            Me.radGroupBox2.Location = New System.Drawing.Point(3, 203)
            Me.radGroupBox2.Name = "radGroupBox2"
            '
            '
            '
            Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(205, 265)
            Me.radGroupBox2.TabIndex = 8
            Me.radGroupBox2.Text = "Legend"
            '
            'radButtonEditShape
            '
            Me.radButtonEditShape.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
            Me.radButtonEditShape.Location = New System.Drawing.Point(41, 229)
            Me.radButtonEditShape.Name = "radButtonEditShape"
            Me.radButtonEditShape.Size = New System.Drawing.Size(130, 24)
            Me.radButtonEditShape.TabIndex = 10
            Me.radButtonEditShape.Text = "Edit shape"
            '
            'radDropDownListShapes
            '
            Me.radDropDownListShapes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListShapes.Location = New System.Drawing.Point(9, 203)
            Me.radDropDownListShapes.Name = "radDropDownListShapes"
            Me.radDropDownListShapes.Size = New System.Drawing.Size(185, 20)
            Me.radDropDownListShapes.TabIndex = 9
            '
            'radLabelMarkerShape
            '
            Me.radLabelMarkerShape.AutoSize = True
            Me.radLabelMarkerShape.Location = New System.Drawing.Point(9, 179)
            Me.radLabelMarkerShape.Name = "radLabelMarkerShape"
            Me.radLabelMarkerShape.Size = New System.Drawing.Size(79, 18)
            Me.radLabelMarkerShape.TabIndex = 8
            Me.radLabelMarkerShape.Text = "Markers shape"
            '
            'radLabel4
            '
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel4.AutoSize = True
            Me.radLabel4.Location = New System.Drawing.Point(107, 73)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(12, 18)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Text = "Y"
            '
            'radLabel3
            '
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel3.AutoSize = True
            Me.radLabel3.Location = New System.Drawing.Point(22, 73)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(13, 18)
            Me.radLabel3.TabIndex = 7
            Me.radLabel3.Text = "X"
            '
            'radLabel5
            '
            Me.radLabel5.AutoSize = True
            Me.radLabel5.Location = New System.Drawing.Point(9, 107)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(92, 18)
            Me.radLabel5.TabIndex = 1
            Me.radLabel5.Text = "Items orientation"
            '
            'radLabel2
            '
            Me.radLabel2.AutoSize = True
            Me.radLabel2.Location = New System.Drawing.Point(9, 21)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(46, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Position"
            '
            'radDropDownListLegendPosition
            '
            Me.radDropDownListLegendPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radDropDownListLegendPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListLegendPosition.Location = New System.Drawing.Point(9, 45)
            Me.radDropDownListLegendPosition.Name = "radDropDownListLegendPosition"
            Me.radDropDownListLegendPosition.Size = New System.Drawing.Size(185, 20)
            Me.radDropDownListLegendPosition.TabIndex = 1
            Me.radDropDownListLegendPosition.Text = "Legend position"
            '
            'radSpinEditorLegendX
            '
            Me.radSpinEditorLegendX.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorLegendX.Location = New System.Drawing.Point(41, 71)
            Me.radSpinEditorLegendX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorLegendX.Name = "radSpinEditorLegendX"
            Me.radSpinEditorLegendX.Size = New System.Drawing.Size(57, 20)
            Me.radSpinEditorLegendX.TabIndex = 2
            Me.radSpinEditorLegendX.TabStop = False
            '
            'radRadioButtonVerticalLegend
            '
            Me.radRadioButtonVerticalLegend.AutoSize = True
            Me.radRadioButtonVerticalLegend.Location = New System.Drawing.Point(9, 155)
            Me.radRadioButtonVerticalLegend.Name = "radRadioButtonVerticalLegend"
            Me.radRadioButtonVerticalLegend.Size = New System.Drawing.Size(57, 18)
            Me.radRadioButtonVerticalLegend.TabIndex = 6
            Me.radRadioButtonVerticalLegend.TabStop = True
            Me.radRadioButtonVerticalLegend.Text = "Vertical"
            Me.radRadioButtonVerticalLegend.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radSpinEditorLegendY
            '
            Me.radSpinEditorLegendY.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorLegendY.Location = New System.Drawing.Point(125, 71)
            Me.radSpinEditorLegendY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorLegendY.Name = "radSpinEditorLegendY"
            Me.radSpinEditorLegendY.Size = New System.Drawing.Size(57, 20)
            Me.radSpinEditorLegendY.TabIndex = 2
            Me.radSpinEditorLegendY.TabStop = False
            '
            'radRadioButtonHorizontalLegend
            '
            Me.radRadioButtonHorizontalLegend.AutoSize = True
            Me.radRadioButtonHorizontalLegend.Location = New System.Drawing.Point(9, 131)
            Me.radRadioButtonHorizontalLegend.Name = "radRadioButtonHorizontalLegend"
            Me.radRadioButtonHorizontalLegend.Size = New System.Drawing.Size(72, 18)
            Me.radRadioButtonHorizontalLegend.TabIndex = 6
            Me.radRadioButtonHorizontalLegend.Text = "Horizontal"
            '
            'radChartView1
            '
            Me.radChartView1.AreaDesign = CartesianArea1
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New System.Drawing.Size(1224, 850)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.Title = "Chart title"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1224, 850)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radCheckBoxFlipText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxControlTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListTitlePosition, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTitleOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHorizontalTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonVerticalTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMarkerShape, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListLegendPosition, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorLegendX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonVerticalLegend, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorLegendY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHorizontalLegend, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend WithEvents radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radLabel4 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radLabel5 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radDropDownListLegendPosition As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radSpinEditorLegendX As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents radRadioButtonVerticalLegend As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radSpinEditorLegendY As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents radRadioButtonHorizontalLegend As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radDropDownListTitlePosition As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLabelTitleOrientation As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radRadioButtonHorizontalTitle As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radRadioButtonVerticalTitle As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radChartView1 As Telerik.WinControls.UI.RadChartView
        Friend WithEvents radDropDownListShapes As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents radLabelMarkerShape As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radCheckBoxFlipText As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents radTextBoxControlTitle As Telerik.WinControls.UI.RadTextBoxControl
        Friend WithEvents radLabelTitle As Telerik.WinControls.UI.RadLabel
        Friend WithEvents radButtonEditShape As Telerik.WinControls.UI.RadButton
    End Class
End Namespace