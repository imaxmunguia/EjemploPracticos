Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Globalization


Namespace Telerik.Examples.WinControls.GridView.TypeConverters
	Public Class DateTimeConverter
		Inherits TypeConverter
		#Region "Fields"

		Private timeZoneInfo_Renamed As Telerik.WinControls.UI.TimeZoneInfo = Telerik.WinControls.UI.TimeZoneInfo.Local

		#End Region

		#Region "Properties"

		Public Property TimeZoneInfo() As Telerik.WinControls.UI.TimeZoneInfo
			Get
				Return Me.timeZoneInfo_Renamed
			End Get
			Set(ByVal value As Telerik.WinControls.UI.TimeZoneInfo)
				If value Is Nothing Then
					Me.timeZoneInfo_Renamed = Telerik.WinControls.UI.TimeZoneInfo.Local
					Return
				End If

				Me.timeZoneInfo_Renamed = value
			End Set
		End Property

		#End Region

		#Region "Convert To Methods"

		Public Overrides Overloads Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
			Return destinationType Is GetType(DateTime) OrElse destinationType Is GetType(String)
		End Function

		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
			If value Is Nothing Then
				If destinationType Is GetType(DateTime) Then
					Return System.DateTime.MinValue
				End If

				Return String.Empty
			End If

			Dim doubleValue As Double = CDbl(value)
			Dim dateTime As DateTime = DateTime.FromOADate(doubleValue)
			dateTime = Telerik.WinControls.UI.TimeZoneInfo.ConvertTimeFromUtc(dateTime, Me.timeZoneInfo_Renamed)

			If destinationType Is GetType(String) Then
				Return Convert.ToString(dateTime)
			End If

			Return dateTime
		End Function

		#End Region

		#Region "Convert From Methods"

		Public Overrides Overloads Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
			Return sourceType Is GetType(DateTime)
		End Function

		Public Overrides Overloads Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
			If value Is Nothing Then
				Return 0
			End If

			Dim dateTimeValue As DateTime = CDate(value)
			dateTimeValue = Telerik.WinControls.UI.TimeZoneInfo.ConvertTimeToUtc(dateTimeValue, Me.timeZoneInfo_Renamed)
			Return dateTimeValue.ToOADate()
		End Function

		#End Region
	End Class
End Namespace
