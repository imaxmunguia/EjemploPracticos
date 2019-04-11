Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar.FirstLook
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()

			Me.radVerticalTrackbar.Value = (TryCast(Me.radPanelDemoHolder.PanelElement.Shape, RoundRectShape)).Radius
		End Sub

		Private Sub OnVerticalTrackBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles radVerticalTrackbar.Scroll
			TryCast(Me.radPanelDemoHolder.PanelElement.Shape, RoundRectShape).Radius = Me.radVerticalTrackbar.Value
			Me.radPanelDemoHolder.Invalidate()
		End Sub

		Private Sub OnHorizontalTrackBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles radHorizontalTrackBar.Scroll
			Me.radPanelDemoHolder.PanelElement.Margin = New Padding(Me.radHorizontalTrackBar.Value)
		End Sub
	End Class
End Namespace