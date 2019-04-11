Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
    Public Class TwoLabelOhlcSeries
        Inherits OhlcSeries
        Protected Overrides Function CreatePointElement(point As DataPoint) As DataPointElement
            Return New TwoLabelOhlcPointElement(point)
        End Function
    End Class

    Public Class TwoLabelOhlcPointElement
        Inherits OhlcPointElement
        Private m_secondLabel As LabelElement

        Public Sub New(point As DataPoint)
            MyBase.New(point)
            m_secondLabel = CreateLabelElement(Me)
            Me.Children.Add(m_secondLabel)
        End Sub

        Public ReadOnly Property SecondLabel() As LabelElement
            Get
                Return Me.m_secondLabel
            End Get
        End Property

        Public Overrides Function GetThemeEffectiveType() As Type
            Return GetType(OhlcPointElement)
        End Function
    End Class
End Namespace