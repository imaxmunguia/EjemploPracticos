Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.StripView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private strip As RadPageViewStripElement

		#End Region

		#Region "Constructor/Initialization"

		Public Sub New()
			InitializeComponent()

			Me.radPageView1.Dock = DockStyle.Fill

			Me.strip = TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement)
			Me.strip.StripButtons = StripViewButtons.None

			Me.PopulateSettingsCombo(Me.alignCombo, GetType(StripViewAlignment), strip.StripAlignment)
			Me.PopulateSettingsCombo(Me.orientationCombo, GetType(PageViewContentOrientation), strip.ItemContentOrientation)
			Me.PopulateSettingsCombo(Me.buttonsCombo, GetType(StripViewButtons), strip.StripButtons)
			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub PopulateSettingsCombo(ByVal combo As RadDropDownList, ByVal enumType As Type, ByVal selected As Object)
			Dim selectedIndex As Integer = -1
			Dim counter As Integer = 0

			For Each value As Object In System.Enum.GetValues(enumType)
				Dim item As New RadListDataItem(value.ToString(), value)
				combo.Items.Add(item)
				If Object.Equals(selected, value) Then
					selectedIndex = counter
				End If

				counter += 1
			Next value

			combo.SelectedIndex = selectedIndex
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub alignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles alignCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.alignCombo.SelectedItem, RadListDataItem)
			Me.strip.StripAlignment = CType(item.Value, StripViewAlignment)
		End Sub

		Private Sub orientationCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles orientationCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.orientationCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemContentOrientation = CType(item.Value, PageViewContentOrientation)
		End Sub

		Private Sub buttonsCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles buttonsCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.buttonsCombo.SelectedItem, RadListDataItem)
			Me.strip.StripButtons = CType(item.Value, StripViewButtons)
		End Sub

		#End Region
	End Class
End Namespace
