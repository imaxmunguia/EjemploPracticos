Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Globalization

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ItemsFormattinWithHtmlLike
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const NumberOfItems As Integer = 37

		Private bgColors() As String = { "#f3f3f3", "#eff1ea", "#ebefe0", "#e3eccf", "#dce9c0", "#d3e9a3", "#c7e97d" }

		Private textColors() As String = { "#85b949", "#9cb97b", "#a9b997", "#8d9c90", "#757575", "#575757", "#000000" }

		Public Sub New()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme Or QSFButtons.TransparentBackground, False)
			InitializeComponent()
			Me.radListControl1.ListElement.AutoSizeItems = True
			Me.radDropDownList1.ListElement.AutoSizeItems = True
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim list(NumberOfItems - 1) As String
			For i As Integer = 0 To NumberOfItems - 1
				Dim text As String = "<html><color=" & textColors(i Mod 7) & "><size=" & (i + 8).ToString() & ">Item " & (i + 1).ToString()
				list(i) = text
			Next i

			Me.radListControl1.DataSource = list
			Me.radDropDownList1.DataSource = list
		End Sub

		Private Sub radListControl1_VisualItemFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.VisualItemFormattingEventArgs) Handles radListControl1.VisualItemFormatting, radDropDownList1.VisualListItemFormatting
			Dim item As RadListVisualItem = args.VisualItem
			Dim rowIndex As Integer = item.Data.RowIndex
			Dim typeConverter As System.ComponentModel.TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
			item.DrawFill = True
			item.BackColor = CType(typeConverter.ConvertFromString(Nothing, CultureInfo.InvariantCulture, bgColors(rowIndex Mod 7)), Color)
			item.GradientStyle = Telerik.WinControls.GradientStyles.Solid
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
