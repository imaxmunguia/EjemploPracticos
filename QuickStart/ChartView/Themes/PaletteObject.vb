﻿Imports System
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.Themes
	Public Class PaletteObject
		Implements INotifyPropertyChanged
		#Region "Fields"

		Private name_Renamed As String
		Private palette_Renamed As ChartPalette

		#End Region

		#Region "Constructor"
		Public Sub New(ByVal name As String, ByVal palette As ChartPalette)
			Me.name_Renamed = name
			Me.palette_Renamed = palette
		End Sub
		#End Region

		#Region "Properties"

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				If Me.name_Renamed = value Then
					Return
				End If

				Me.name_Renamed = value
				Me.OnNotifyPropertyChanged("Name")
			End Set
		End Property

		Public Property Palette() As ChartPalette
			Get
				Return Me.palette_Renamed
			End Get
			Set(ByVal value As ChartPalette)
				If Me.palette_Renamed Is value Then
					Return
				End If

				Me.palette_Renamed = value
				Me.OnNotifyPropertyChanged("Palette")
			End Set
		End Property

		#End Region

		#Region "INotifyPropertyChanged Implementation"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub OnNotifyPropertyChanged(ByVal [property] As String)
			If Me.PropertyChangedEvent IsNot Nothing Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
			End If
		End Sub

		#End Region
	End Class
End Namespace
