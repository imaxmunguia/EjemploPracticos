Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.Chart.Functionality.Multilanguage
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
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim corners1 As New Telerik.Charting.Styles.Corners()
			Dim chartAxisItem1 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem2 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem3 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem4 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem5 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem6 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem7 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem8 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem9 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem10 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem11 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem12 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem13 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem14 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem15 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem16 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem17 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem18 As New Telerik.Charting.ChartAxisItem()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeriesItem1 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem2 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem3 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem4 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem5 As New Telerik.Charting.ChartSeriesItem()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			unit1.Value = 384
			Me.radChart1.Appearance.Dimensions.Height = unit1
			unit2.Value = 621
			Me.radChart1.Appearance.Dimensions.Width = unit2
			Me.radChart1.ChartTitle.TextBlock.Text = "Consumption by Month"
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Pie
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.Location = New System.Drawing.Point(12, 50)
			Me.radChart1.Name = "radChart1"
			corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners1.RoundSize = 6
			corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.PlotArea.Appearance.Corners = corners1
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem1.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			chartAxisItem2.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			chartAxisItem3.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			chartAxisItem4.Value = New Decimal(New Integer() { 4, 0, 0, 0})
			chartAxisItem5.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radChart1.PlotArea.XAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem1, chartAxisItem2, chartAxisItem3, chartAxisItem4, chartAxisItem5})
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem7.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			chartAxisItem8.Value = New Decimal(New Integer() { 10, 0, 0, 0})
			chartAxisItem9.Value = New Decimal(New Integer() { 15, 0, 0, 0})
			chartAxisItem10.Value = New Decimal(New Integer() { 20, 0, 0, 0})
			chartAxisItem11.Value = New Decimal(New Integer() { 25, 0, 0, 0})
			chartAxisItem12.Value = New Decimal(New Integer() { 30, 0, 0, 0})
			chartAxisItem13.Value = New Decimal(New Integer() { 35, 0, 0, 0})
			Me.radChart1.PlotArea.YAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem6, chartAxisItem7, chartAxisItem8, chartAxisItem9, chartAxisItem10, chartAxisItem11, chartAxisItem12, chartAxisItem13})
			Me.radChart1.PlotArea.YAxis.MaxValue = 35
			Me.radChart1.PlotArea.YAxis.Step = 5
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem14.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			chartAxisItem15.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			chartAxisItem16.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			chartAxisItem17.Value = New Decimal(New Integer() { 4, 0, 0, 0})
			chartAxisItem18.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radChart1.PlotArea.YAxis2.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem14, chartAxisItem15, chartAxisItem16, chartAxisItem17, chartAxisItem18})
			Me.radChart1.PlotArea.YAxis2.MaxValue = 5
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
			chartSeriesItem1.Label.TextBlock.Text = "English"
			chartSeriesItem1.YValue = 35
			chartSeriesItem2.Label.TextBlock.Text = "Spanish"
			chartSeriesItem2.YValue = 20
			chartSeriesItem3.Label.TextBlock.Text = "French"
			chartSeriesItem3.YValue = 20
			chartSeriesItem4.Label.TextBlock.Text = "German"
			chartSeriesItem4.YValue = 20
			chartSeriesItem5.Label.TextBlock.Text = "Chinese"
			chartSeriesItem5.YValue = 20
			chartSeries1.Items.AddRange(New Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4, chartSeriesItem5})
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Pie
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.TabIndex = 0
			' 
			' radComboBox1
			' 
			Me.radComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
			Me.radComboBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem4, Me.radComboBoxItem3}))
			Me.radComboBox1.Location = New System.Drawing.Point(120, 12)
			Me.radComboBox1.MaxLength = 32767
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.NullText = ""
			' 
			' radComboBox1.RootElement
			' 
			Me.radComboBox1.RootElement.AccessibleDescription = ""
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radComboBox1.Size = New System.Drawing.Size(106, 19)
			Me.radComboBox1.MaxDropDownItems = 6
			Me.radComboBox1.SmallImageList = Nothing
			Me.radComboBox1.TabIndex = 1
			Me.radComboBox1.Text = "radComboBox1"
'			Me.radComboBox1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox1_SelectedIndexChanged);
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "English"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "German"
			' 
			' radComboBoxItem4
			' 
			Me.radComboBoxItem4.Text = "Spanish"
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "French"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 12)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(91, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Select Language:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.radComboBox1)
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(450, 350)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
		Private WithEvents radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private label1 As System.Windows.Forms.Label
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
	End Class
End Namespace