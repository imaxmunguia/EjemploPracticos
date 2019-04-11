Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.Pie
	Partial Public Class Form1
		Inherits ExamplesForm
		Private pieSeries As PieSeries

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radChartView1

			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radChartView1.Controllers.Add(New ChartSelectionController())
            AddHandler radChartView1.SelectedPointChanged, AddressOf radChartView1_SelectedPointChanged

            AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
            AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
            AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged

			BindSelectionModeCombo()
			AddHandler radDropDownList1.SelectedValueChanged, AddressOf radDropDownList1_SelectedValueChanged
			Me.radDropDownList1.SelectedValue = ChartSelectionMode.SingleDataPoint

            pieSeries = New PieSeries()
            PopulatePieSeries()
            Me.radChartView1.Series.Clear()
            Me.radChartView1.Series.Add(pieSeries)

            Me.RadLabel4.Visible = False
            Me.RadSpinDonutRadius.Visible = False

            Dim theme As Theme = theme.ReadCSSText("theme{name: ControlDefault;elementType: Telerik.WinControls.UI.RadChartElement; controlType: Telerik.WinControls.UI.RadChartView; }PieSegment{RadiusAspectRatio{Value: 0.1;EndValue: 1;MaxValue: 1;Frames: 20;Interval: 10;EasingType: OutCircular;RandomDelay: 200;RemoveAfterApply: true; }}")
            ThemeRepository.Add(theme, False)

		End Sub

		Private Sub radDropDownList1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radChartView1.SelectionMode = CType(Me.radDropDownList1.SelectedValue, ChartSelectionMode)
		End Sub

        Private Sub radChartView1_SelectedPointChanged(ByVal sender As Object, ByVal args As ChartViewSelectedPointChangedEventArgs)
            UpdadateOffsetFromCenter(TryCast(args.OldSelectedPoint, PieDataPoint))
            UpdadateOffsetFromCenter(TryCast(args.NewSelectedPoint, PieDataPoint))
        End Sub

		Private Sub UpdadateOffsetFromCenter(ByVal point As PieDataPoint)
			If point IsNot Nothing Then
				point.OffsetFromCenter = If(point.IsSelected, 0.1, 0)
			End If
		End Sub

        Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim range As AngleRange = pieSeries.Range
            range.StartAngle = Decimal.ToDouble(Me.radSpinEditor1.Value)
            pieSeries.Range = range
        End Sub

        Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim range As AngleRange = pieSeries.Range
            range.SweepAngle = Decimal.ToDouble(Me.radSpinEditor2.Value)
            pieSeries.Range = range
        End Sub

        Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            pieSeries.ShowLabels = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
        End Sub

		Private Sub PopulatePieSeries()
			pieSeries.ShowLabels = True
            pieSeries.LabelFormat = "{0:P2}"
			pieSeries.RadiusFactor = 0.9f
			pieSeries.Range = New AngleRange(270, 360)

			pieSeries.DataPoints.Add(New PieDataPoint(40, "Apple"))
			pieSeries.DataPoints.Add(New PieDataPoint(45, "Microsoft"))
			pieSeries.DataPoints.Add(New PieDataPoint(40, "Google"))
			pieSeries.DataPoints.Add(New PieDataPoint(25, "Android"))
			pieSeries.DataPoints.Add(New PieDataPoint(15, "HTC"))
			pieSeries.DataPoints.Add(New PieDataPoint(15, "Samsung"))
			pieSeries.DataPoints.Add(New PieDataPoint(15, "Bada"))
			pieSeries.DataPoints.Add(New PieDataPoint(30, "Others"))

		End Sub

		Private Sub BindSelectionModeCombo()
			Dim selectionModeBindingSource As New BindingSource()
			selectionModeBindingSource.Add(ChartSelectionMode.None)
			selectionModeBindingSource.Add(ChartSelectionMode.SingleDataPoint)
			selectionModeBindingSource.Add(ChartSelectionMode.MultipleDataPoints)

			Me.radDropDownList1.DataSource = selectionModeBindingSource
		End Sub

        Private Sub RadRadioButtonPie_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButtonPie.ToggleStateChanged
            If args.ToggleState = Enumerations.ToggleState.On Then
                Me.radChartView1.Series.Clear()
                pieSeries = New PieSeries()
                PopulatePieSeries()
                Me.radChartView1.Series.Add(pieSeries)
                Me.RadLabel4.Visible = False
                Me.RadSpinDonutRadius.Visible = False
                Me.pieSeries.ShowLabels = Me.radCheckBox1.Checked
            End If
        End Sub

        Private Sub RadRadioButtonDonut_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButtonDonut.ToggleStateChanged
            If args.ToggleState = Enumerations.ToggleState.On Then
                Me.radChartView1.Series.Clear()
                pieSeries = New DonutSeries()
                PopulatePieSeries()
                Me.radChartView1.Series.Add(pieSeries)
                Me.RadLabel4.Visible = True
                Me.RadSpinDonutRadius.Visible = True
                Me.pieSeries.ShowLabels = Me.radCheckBox1.Checked
                Me.RadSpinDonutRadius.Value = CType(CType(pieSeries, Telerik.WinControls.UI.DonutSeries).InnerRadiusFactor * 100, Integer)
            End If
        End Sub

        Private Sub RadSpinDonutRadius_ValueChanged(sender As System.Object, e As System.EventArgs) Handles RadSpinDonutRadius.ValueChanged
            CType(pieSeries, Telerik.WinControls.UI.DonutSeries).InnerRadiusFactor = CType(Me.RadSpinDonutRadius.Value, Single) / 100
        End Sub
    End Class
End Namespace
