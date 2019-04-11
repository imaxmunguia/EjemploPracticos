Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO
Imports System.Globalization
Imports Microsoft.VisualBasic

Namespace Telerik.Examples.WinControls.ChartView.Scatter
    Friend Class RealEstateViewModel
        Implements INotifyPropertyChanged
        Public Sub New()
            Dim data As List(Of RealEstateData) = ParseData()
            GetDataCompleted(data)
        End Sub

        Private _apartmentData As IEnumerable(Of RealEstateData)
        Private _coOpData As IEnumerable(Of RealEstateData)

        Public Property ApartmentData() As IEnumerable(Of RealEstateData)
            Get
                Return Me._apartmentData
            End Get
            Private Set(ByVal value As IEnumerable(Of RealEstateData))
                If Me._apartmentData Is value Then
                    Return
                End If

                Me._apartmentData = value
                Me.OnPropertyChanged("ApartmentData")
            End Set
        End Property

        Public Property CoOpData() As IEnumerable(Of RealEstateData)
            Get
                Return Me._coOpData
            End Get
            Set(ByVal value As IEnumerable(Of RealEstateData))
                If Me._coOpData Is value Then
                    Return
                End If

                Me._coOpData = value
                Me.OnPropertyChanged("CoOpData")
            End Set
        End Property

        Public Function GetData(ByVal index As Integer) As IEnumerable(Of RealEstateData)
            If index = 0 Then
                Return Me.CoOpData
            End If

            If index = 1 Then
                Return Me.ApartmentData
            End If

            Return Nothing
        End Function

        Protected Sub GetDataCompleted(ByVal data As List(Of RealEstateData))
            Dim coOpData As New List(Of RealEstateData)()
            Dim apartmentData As New List(Of RealEstateData)()

            For Each item As RealEstateData In data
                If item.Type = "co-op" Then
                    coOpData.Add(item)
                Else
                    apartmentData.Add(item)
                End If
            Next item

            Me.CoOpData = coOpData
            Me.ApartmentData = apartmentData
        End Sub

        Private Function ParseData() As List(Of RealEstateData)
            Dim chartData As New List(Of RealEstateData)()
            Dim separator() As Char = {ControlChars.Cr, ControlChars.Lf}
            Dim fileContents As String = My.Resources.RealEstateAgency
            Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            For Each line As String In lines
                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data() As String = line.Split(","c)
                Dim sqFeet As Double = Double.Parse(data(0), CultureInfo.InvariantCulture)
                Dim price As Double = Double.Parse(data(1), CultureInfo.InvariantCulture)
                Dim type As String = data(2)
                Dim realEstateData As New RealEstateData(type, sqFeet, price)
                chartData.Add(realEstateData)
            Next line
            Return chartData
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            If Me.PropertyChangedEvent IsNot Nothing Then
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub

    End Class
End Namespace
