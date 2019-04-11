Namespace Telerik.Examples.WinControls.PivotGrid.BindingWithChart

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits Telerik.QuickStart.WinControls.ExamplesForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.checkBoxDelayUpdates = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxSelectionOnly = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxColumnSubTotals = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxRowSubTotals = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxColumnGrandTotals = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxRowGrandTotals = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radioRows = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioColumns = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioBarSeries = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioLineSeries = New Telerik.WinControls.UI.RadRadioButton()
            Me.radioAreaSeries = New Telerik.WinControls.UI.RadRadioButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.checkBoxDelayUpdates, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxSelectionOnly, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxColumnSubTotals, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxRowSubTotals, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxColumnGrandTotals, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxRowGrandTotals, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            DirectCast(Me.radioRows, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioBarSeries, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioLineSeries, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radioAreaSeries, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.radGroupBox3)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(795, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(286, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            ' 
            ' pivot
            ' 
            Me.radPivotGrid1.AllowFieldsDragDrop = False
            Me.radPivotGrid1.AllowGroupFiltering = False
            Me.radPivotGrid1.AllowHorizontalResize = False
            Me.radPivotGrid1.AllowContextMenu = False
            Me.radPivotGrid1.AllowVerticalResize = False
            Me.radPivotGrid1.ColumnHeaderHeight = 30
            Me.radPivotGrid1.ColumnWidth = 100
            Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals = True
            Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals = True
            Me.radPivotGrid1.DataMember = Nothing
            Me.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.radPivotGrid1.FilterAreaHeight = 30
            Me.radPivotGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPivotGrid1.Name = "pivot"
            Me.radPivotGrid1.RowHeight = 25
            Me.radPivotGrid1.Size = New System.Drawing.Size(795, 225)
            Me.radPivotGrid1.TabIndex = 1
            Me.radPivotGrid1.Text = "radPivotGrid1"
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.LegendTitle = "Legend"
            Me.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radChartView1.Location = New System.Drawing.Point(0, 366)
            Me.radChartView1.Name = "radChartView1"
            Me.radChartView1.Size = New System.Drawing.Size(795, 466)
            Me.radChartView1.ShowTitle = True
            Me.radChartView1.Title = "Pivot Data Visualization"
            Me.radChartView1.ShowLegend = True
            Me.radChartView1.TabIndex = 2
            Me.radChartView1.Text = "radChartView1"
            Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.checkBoxRowGrandTotals)
            Me.radGroupBox1.Controls.Add(Me.checkBoxColumnGrandTotals)
            Me.radGroupBox1.Controls.Add(Me.checkBoxRowSubTotals)
            Me.radGroupBox1.Controls.Add(Me.checkBoxColumnSubTotals)
            Me.radGroupBox1.Controls.Add(Me.checkBoxSelectionOnly)
            Me.radGroupBox1.Controls.Add(Me.checkBoxDelayUpdates)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Binding options"
            Me.radGroupBox1.Location = New System.Drawing.Point(78, 2)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(185, 175)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Binding options"
            ' 
            ' checkBoxDelayUpdates
            ' 
            Me.checkBoxDelayUpdates.Location = New System.Drawing.Point(11, 22)
            Me.checkBoxDelayUpdates.Name = "checkBoxDelayUpdates"
            Me.checkBoxDelayUpdates.Size = New System.Drawing.Size(86, 18)
            Me.checkBoxDelayUpdates.TabIndex = 0
            Me.checkBoxDelayUpdates.Text = "Delay update"
            ' 
            ' checkBoxSelectionOnly
            ' 
            Me.checkBoxSelectionOnly.Location = New System.Drawing.Point(11, 46)
            Me.checkBoxSelectionOnly.Name = "checkBoxSelectionOnly"
            Me.checkBoxSelectionOnly.Size = New System.Drawing.Size(90, 18)
            Me.checkBoxSelectionOnly.TabIndex = 0
            Me.checkBoxSelectionOnly.Text = "Selection only"
            ' 
            ' checkBoxColumnSubTotals
            ' 
            Me.checkBoxColumnSubTotals.Location = New System.Drawing.Point(11, 70)
            Me.checkBoxColumnSubTotals.Name = "checkBoxColumnSubTotals"
            Me.checkBoxColumnSubTotals.Size = New System.Drawing.Size(150, 18)
            Me.checkBoxColumnSubTotals.TabIndex = 0
            Me.checkBoxColumnSubTotals.Text = "Include column sub-totals"
            ' 
            ' checkBoxRowSubTotals
            ' 
            Me.checkBoxRowSubTotals.Location = New System.Drawing.Point(11, 94)
            Me.checkBoxRowSubTotals.Name = "checkBoxRowSubTotals"
            Me.checkBoxRowSubTotals.Size = New System.Drawing.Size(132, 18)
            Me.checkBoxRowSubTotals.TabIndex = 0
            Me.checkBoxRowSubTotals.Text = "Include row sub-totals"
            ' 
            ' checkBoxColumnGrandTotals
            ' 
            Me.checkBoxColumnGrandTotals.Location = New System.Drawing.Point(11, 118)
            Me.checkBoxColumnGrandTotals.Name = "checkBoxColumnGrandTotals"
            Me.checkBoxColumnGrandTotals.Size = New System.Drawing.Size(160, 18)
            Me.checkBoxColumnGrandTotals.TabIndex = 0
            Me.checkBoxColumnGrandTotals.Text = "Include column grand totals"
            ' 
            ' checkBoxRowGrandTotals
            ' 
            Me.checkBoxRowGrandTotals.Location = New System.Drawing.Point(11, 142)
            Me.checkBoxRowGrandTotals.Name = "checkBoxRowGrandTotals"
            Me.checkBoxRowGrandTotals.Size = New System.Drawing.Size(142, 18)
            Me.checkBoxRowGrandTotals.TabIndex = 0
            Me.checkBoxRowGrandTotals.Text = "Include row grand totals"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.radioColumns)
            Me.radGroupBox2.Controls.Add(Me.radioRows)
            Me.radGroupBox2.FooterImageIndex = -1
            Me.radGroupBox2.FooterImageKey = ""
            Me.radGroupBox2.HeaderImageIndex = -1
            Me.radGroupBox2.HeaderImageKey = ""
            Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox2.HeaderText = "Generate series from"
            Me.radGroupBox2.Location = New System.Drawing.Point(78, 184)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(185, 76)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "Generate series from"
            ' 
            ' radGroupBox3
            ' 
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Controls.Add(Me.radioAreaSeries)
            Me.radGroupBox3.Controls.Add(Me.radioLineSeries)
            Me.radGroupBox3.Controls.Add(Me.radioBarSeries)
            Me.radGroupBox3.FooterImageIndex = -1
            Me.radGroupBox3.FooterImageKey = ""
            Me.radGroupBox3.HeaderImageIndex = -1
            Me.radGroupBox3.HeaderImageKey = ""
            Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox3.HeaderText = "Generated series type"
            Me.radGroupBox3.Location = New System.Drawing.Point(78, 266)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox3.Size = New System.Drawing.Size(185, 96)
            Me.radGroupBox3.TabIndex = 2
            Me.radGroupBox3.Text = "Generated series type"
            ' 
            ' radioRows
            ' 
            Me.radioRows.Location = New System.Drawing.Point(11, 22)
            Me.radioRows.Name = "radioRows"
            Me.radioRows.Size = New System.Drawing.Size(110, 18)
            Me.radioRows.TabIndex = 0
            Me.radioRows.Text = "Rows"
            ' 
            ' radioColumns
            ' 
            Me.radioColumns.Location = New System.Drawing.Point(11, 46)
            Me.radioColumns.Name = "radioColumns"
            Me.radioColumns.Size = New System.Drawing.Size(110, 18)
            Me.radioColumns.TabIndex = 0
            Me.radioColumns.Text = "Columns"
            ' 
            ' radioBarSeries
            ' 
            Me.radioBarSeries.Location = New System.Drawing.Point(11, 21)
            Me.radioBarSeries.Name = "radioBarSeries"
            Me.radioBarSeries.Size = New System.Drawing.Size(110, 18)
            Me.radioBarSeries.TabIndex = 0
            Me.radioBarSeries.Text = "Bar"
            ' 
            ' radioLineSeries
            ' 
            Me.radioLineSeries.Location = New System.Drawing.Point(11, 45)
            Me.radioLineSeries.Name = "radioLineSeries"
            Me.radioLineSeries.Size = New System.Drawing.Size(110, 18)
            Me.radioLineSeries.TabIndex = 0
            Me.radioLineSeries.Text = "Line"
            ' 
            ' radioAreaSeries
            ' 
            Me.radioAreaSeries.Location = New System.Drawing.Point(11, 69)
            Me.radioAreaSeries.Name = "radioAreaSeries"
            Me.radioAreaSeries.Size = New System.Drawing.Size(110, 18)
            Me.radioAreaSeries.TabIndex = 0
            Me.radioAreaSeries.Text = "Area"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radChartView1)
            Me.Controls.Add(Me.radPivotGrid1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1081, 832)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radPivotGrid1, 0)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            DirectCast(Me.checkBoxDelayUpdates, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxSelectionOnly, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxColumnSubTotals, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxRowSubTotals, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxColumnGrandTotals, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxRowGrandTotals, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            DirectCast(Me.radioRows, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioColumns, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioBarSeries, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioLineSeries, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radioAreaSeries, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
        Private radChartView1 As Telerik.WinControls.UI.RadChartView
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private checkBoxSelectionOnly As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxDelayUpdates As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxRowSubTotals As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxColumnSubTotals As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxColumnGrandTotals As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxRowGrandTotals As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private radioRows As Telerik.WinControls.UI.RadRadioButton
        Private radioColumns As Telerik.WinControls.UI.RadRadioButton
        Private radioLineSeries As Telerik.WinControls.UI.RadRadioButton
        Private radioBarSeries As Telerik.WinControls.UI.RadRadioButton
        Private radioAreaSeries As Telerik.WinControls.UI.RadRadioButton

    End Class
End Namespace