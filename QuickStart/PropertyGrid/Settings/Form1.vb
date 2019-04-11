Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.PropertyGrid.Settings
	Public Partial Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.AutoScroll = False

            Me.radPropertyGrid1.HelpVisible = True
            Me.radPropertyGrid1.ToolbarVisible = True

            Me.radPropertyGrid1.SelectedObject = New RadPropertyGrid()

			Me.radCheckBoxHelpVisible.IsChecked = Me.radPropertyGrid1.HelpVisible
            Me.radCheckBoxSearchVisible.IsChecked = Me.radPropertyGrid1.ToolbarVisible
			Me.radCheckBoxReadOnly.IsChecked = Me.radPropertyGrid1.ReadOnly
			Me.radCheckBoxAutoExpandGroups.IsChecked = Me.radPropertyGrid1.AutoExpandGroups
			Me.radSpinEditorItemHeight.Value = Me.radPropertyGrid1.ItemHeight
			Me.radSpinEditorItemIndent.Value = Me.radPropertyGrid1.ItemIndent
			Me.radSpinEditorItemSpacing.Value = Me.radPropertyGrid1.ItemSpacing
			Me.radDropDownListPropertySort.DataSource = System.Enum.GetValues(GetType(PropertySort))
			Me.radDropDownListPropertySort.SelectedValue = Me.radPropertyGrid1.PropertySort

			AddHandler radPropertyGrid1.PropertyGridElement.PropertyChanged, AddressOf Element_PropertyChanged
			AddHandler radPropertyGrid1.PropertyGridElement.SplitElement.PropertyChanged, AddressOf Element_PropertyChanged
			AddHandler radPropertyGrid1.PropertyGridElement.SplitElement.PropertyTableElement.PropertyChanged, AddressOf Element_PropertyChanged

            Me.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If Me.radPropertyGrid1 IsNot Nothing Then
                Dim width As Integer = Me.ClientSize.Width
                Dim height As Integer = Me.ClientSize.Height
                Me.radPropertyGrid1.Location = New Point((width - radPropertyGrid1.Size.Width) \ 2, (height - radPropertyGrid1.Size.Height) \ 2)
            End If
        End Sub

		Private Sub Element_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "SearchBarVisible" Then
                Me.radCheckBoxSearchVisible.IsChecked = Me.radPropertyGrid1.ToolbarVisible
			ElseIf e.PropertyName = "HelpVisible" Then
				Me.radCheckBoxHelpVisible.IsChecked = Me.radPropertyGrid1.HelpVisible
			ElseIf e.PropertyName = "PropertySort" Then
				Me.radDropDownListPropertySort.SelectedValue = Me.radPropertyGrid1.PropertySort
			End If
		End Sub

		Private Sub radCheckBoxHelpVisible_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxHelpVisible.ToggleStateChanged
			Me.radPropertyGrid1.HelpVisible = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxSearchVisible_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxSearchVisible.ToggleStateChanged
            Me.radPropertyGrid1.ToolbarVisible = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxReadOnly_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxReadOnly.ToggleStateChanged
			Me.radPropertyGrid1.ReadOnly = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxAutoExpandGroups_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxAutoExpandGroups.ToggleStateChanged
			Me.radPropertyGrid1.AutoExpandGroups = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radSpinEditorItemHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorItemHeight.ValueChanged
			Me.radPropertyGrid1.ItemHeight = CInt(Fix(Me.radSpinEditorItemHeight.Value))
		End Sub

		Private Sub radSpinEditorItemIndent_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorItemIndent.ValueChanged
			Me.radPropertyGrid1.ItemIndent = CInt(Fix(Me.radSpinEditorItemIndent.Value))
		End Sub

		Private Sub radSpinEditorItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorItemSpacing.ValueChanged
			Me.radPropertyGrid1.ItemSpacing = CInt(Fix(Me.radSpinEditorItemSpacing.Value))
		End Sub

		Private Sub radDropDownListPropertySort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListPropertySort.SelectedIndexChanged
			Me.radPropertyGrid1.PropertySort = CType(Me.radDropDownListPropertySort.SelectedValue, PropertySort)
		End Sub
	End Class
End Namespace
