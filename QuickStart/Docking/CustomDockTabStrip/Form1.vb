Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.CustomDockTabStrip
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.docTabsVisibleCheck.Checked = Me.radDock1.DocumentTabsVisible
			Me.toolTabsVisibleCheck.Checked = Me.radDock1.ToolTabsVisible

			Me.docCloseButtonCheck.Checked = Me.radDock1.ShowDocumentCloseButton
			Me.toolCloseButtonCheck.Checked = Me.radDock1.ShowToolCloseButton

			Me.FillTabStripAlignment(Me.docTabAlignCombo, Me.radDock1.DocumentTabsAlignment)
			Me.FillTabStripAlignment(Me.toolTabAlignCombo, Me.radDock1.ToolTabsAlignment)

			Me.FillTabStripTextOrientation(Me.docTextOrientationCombo, Me.radDock1.DocumentTabsTextOrientation)
			Me.FillTabStripTextOrientation(Me.toolTextOrientationCombo, Me.radDock1.ToolTabsTextOrientation)
		End Sub

		#End Region

		#Region "Implementation"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub FillTabStripTextOrientation(ByVal combo As RadDropDownList, ByVal selected As TabStripTextOrientation)
			combo.BeginUpdate()
			combo.Items.Clear()

			Dim counter As Integer = 0
			Dim selectedIndex As Integer = -1
			For Each orientation As TabStripTextOrientation In System.Enum.GetValues(GetType(TabStripTextOrientation))
				Dim item As New RadListDataItem(orientation.ToString())
				item.Value = orientation
				combo.Items.Add(item)

				If orientation = selected Then
					selectedIndex = counter
				End If

				counter += 1
			Next orientation

			combo.SelectedIndex = selectedIndex
			combo.EndUpdate()
		End Sub

		Private Sub FillTabStripAlignment(ByVal combo As RadDropDownList, ByVal selected As TabStripAlignment)
			combo.BeginUpdate()
			combo.Items.Clear()

			Dim counter As Integer = 0
			Dim selectedIndex As Integer = -1
			For Each align As TabStripAlignment In System.Enum.GetValues(GetType(TabStripAlignment))
				Dim item As New RadListDataItem(align.ToString())
				item.Value = align
				combo.Items.Add(item)

				If align = selected Then
					selectedIndex = counter
				End If

				counter += 1
			Next align

			combo.SelectedIndex = selectedIndex
			combo.EndUpdate()
		End Sub

		Private Function GetTabStripAlignment(ByVal combo As RadDropDownList) As Nullable(Of TabStripAlignment)
			Dim item As RadListDataItem = TryCast(combo.SelectedItem, RadListDataItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Return CType(item.Value, TabStripAlignment)
		End Function

		Private Function GetTabStripTextOrientation(ByVal combo As RadDropDownList) As Nullable(Of TabStripTextOrientation)
			Dim item As RadListDataItem = TryCast(combo.SelectedItem, RadListDataItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Return CType(item.Value, TabStripTextOrientation)
		End Function

		#End Region

		#Region "Event Handlers"

		Private Sub docTextOrientationCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles docTextOrientationCombo.SelectedIndexChanged
			Dim orientation As Nullable(Of TabStripTextOrientation) = Me.GetTabStripTextOrientation(Me.docTextOrientationCombo)
			If orientation.HasValue Then
				Me.radDock1.DocumentTabsTextOrientation = orientation.Value
			End If
		End Sub

		Private Sub toolTextOrientationCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles toolTextOrientationCombo.SelectedIndexChanged
			Dim orientation As Nullable(Of TabStripTextOrientation) = Me.GetTabStripTextOrientation(Me.toolTextOrientationCombo)
			If orientation.HasValue Then
				Me.radDock1.ToolTabsTextOrientation = orientation.Value
			End If
		End Sub

		Private Sub docCloseButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles docCloseButtonCheck.ToggleStateChanged
			Me.radDock1.ShowDocumentCloseButton = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub toolCloseButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles toolCloseButtonCheck.ToggleStateChanged
			Me.radDock1.ShowToolCloseButton = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub docTabAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles docTabAlignCombo.SelectedIndexChanged
			Dim align As Nullable(Of TabStripAlignment) = Me.GetTabStripAlignment(Me.docTabAlignCombo)
			If align.HasValue Then
				Me.radDock1.DocumentTabsAlignment = align.Value
			End If
		End Sub

		Private Sub toolTabAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles toolTabAlignCombo.SelectedIndexChanged
			Dim align As Nullable(Of TabStripAlignment) = Me.GetTabStripAlignment(Me.toolTabAlignCombo)
			If align.HasValue Then
				Me.radDock1.ToolTabsAlignment = align.Value
			End If
		End Sub

		Private Sub docTabsVisibleCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles docTabsVisibleCheck.ToggleStateChanged
			Me.radDock1.DocumentTabsVisible = Me.docTabsVisibleCheck.Checked
		End Sub

		Private Sub toolTabsVisibleCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles toolTabsVisibleCheck.ToggleStateChanged
			Me.radDock1.ToolTabsVisible = Me.toolTabsVisibleCheck.Checked
		End Sub

		#End Region
	End Class
End Namespace
