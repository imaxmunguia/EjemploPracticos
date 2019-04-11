Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Drawing

Namespace Telerik.Examples.WinControls.GridView.CustomViews
	Public Class ColumnChooserGridViewElement
		Inherits GridVisualElement
		Implements IGridView
		#Region "Fields"

		Private titleBar As RadTitleBarElement
		Private columnChooser As ColumnChooserElement
		Private stackLayout As StackLayoutElement

		#End Region

		#Region "Initialization"

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.StretchVertically = True
			Me.MinSize = New Size(200, 0)
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.stackLayout = New StackLayoutElement()
			Me.stackLayout.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.stackLayout.StretchVertically = True
			Me.stackLayout.StretchHorizontally = True
			Me.Children.Add(Me.stackLayout)

			Me.titleBar = New RadTitleBarElement()
			Me.titleBar.Text = "Column Chooser"
			Me.titleBar.StretchVertically = False
			Me.titleBar.AllowResize = False
			Me.titleBar.CloseButton.Visibility = ElementVisibility.Collapsed
			Me.titleBar.MinimizeButton.Visibility = ElementVisibility.Collapsed
			AddHandler titleBar.MaximizeRestore, AddressOf TitleBar_MaximizeRestore
			Me.stackLayout.Children.Add(Me.titleBar)

			Me.columnChooser = New ColumnChooserElement()
			Me.columnChooser.StretchVertically = True
			Me.stackLayout.Children.Add(Me.columnChooser)
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub TitleBar_MaximizeRestore(ByVal sender As Object, ByVal args As EventArgs)
			Me.Visibility = ElementVisibility.Collapsed
			Me.GridViewElement.GridControl.ShowColumnChooser(Me.columnChooser.ViewTemplate)

			RemoveHandler GridViewElement.ColumnChooser.FormClosed, AddressOf ColumnChooser_FormClosed
			AddHandler GridViewElement.ColumnChooser.FormClosed, AddressOf ColumnChooser_FormClosed
		End Sub

		Private Sub ColumnChooser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
			Me.Visibility = ElementVisibility.Visible
		End Sub

		#End Region

		#Region "IGridView Members"

		Public Sub Initialize(ByVal gridElement As RadGridViewElement, ByVal viewInfo As GridViewInfo) Implements IGridView.Initialize
			columnChooser.Initialize(gridElement, viewInfo)
		End Sub

		Public Sub Detach() Implements IGridView.Detach
			columnChooser.Detach()
		End Sub

		Public Sub UpdateView() Implements IGridView.UpdateView
			columnChooser.UpdateView()
		End Sub

		Public ReadOnly Property GridViewElement() As RadGridViewElement Implements IGridView.GridViewElement
			Get
				Return columnChooser.GridViewElement
			End Get
		End Property

		Public ReadOnly Property ViewInfo() As GridViewInfo Implements IGridView.ViewInfo
			Get
				Return columnChooser.ViewInfo
			End Get
		End Property

		#End Region
	End Class
End Namespace
