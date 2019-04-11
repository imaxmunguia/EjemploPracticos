Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.ViewSwitch
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor/Initialization"

		Public Sub New()
			InitializeComponent()

			Me.radPageView1.Anchor = AnchorStyles.None
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme Or QSFButtons.TransparentBackground, False)

			ExamplesForm.FillComboFromEnum(Me.viewModeCombo, GetType(PageViewMode), Me.radPageView1.ViewMode)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.AddSamplePages()
			MyBase.OnLoad(e)

			ExamplesForm.CenterControlOnParent(Me.radPageView1)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub AddSamplePages()
			PageViewLabels.currIndex = 0

			For i As Integer = 0 To 4
				Dim page As New RadPageViewPage()
				page.Text = PageViewImages.Names(i)
				page.Image = PageViewImages.Images(i)
				page.Title = page.Text & " - [Title]"
				page.Description = page.Text & " - [Description]"

				page.Controls.Add(PageViewLabels.CreateLabel())

				Me.radPageView1.Pages.Add(page)
			Next i
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub viewModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles viewModeCombo.SelectedIndexChanged
			Dim item As RadListDataItem = TryCast(Me.viewModeCombo.SelectedItem, RadListDataItem)
			Me.radPageView1.ViewMode = CType(item.Value, PageViewMode)
			If Me.radPageView1.ViewMode = PageViewMode.Stack Then
				Dim stack As RadPageViewStackElement = TryCast(Me.radPageView1.ViewElement, RadPageViewStackElement)
				stack.ItemSelectionMode = StackViewItemSelectionMode.ContentWithSelected
			End If
		End Sub

		#End Region
	End Class
End Namespace
