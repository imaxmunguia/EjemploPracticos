Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.Basics
	Partial Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = My.Resources.TV_email

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub LoadData()
			Me.radTreeView1.Nodes.Add(New RadTreeNode("Personal Folders", My.Resources.TV_RootFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Deleted Items", My.Resources.TV_RecycleBin))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Drafts", My.Resources.TV_DraftFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Inbox", My.Resources.TV_InboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Junk E-mails", My.Resources.TV_JunkFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Outbox", My.Resources.TV_OutboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Sent Items", My.Resources.TV_SentFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Search Folder", My.Resources.TV_SearchFolder))

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes.Add(New RadTreeNode("Folders", My.Resources.TV_Folder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("From Follow up", My.Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Large Mail", My.Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Unread Mail", My.Resources.TV_SearchFolder))

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).ItemHeight = 50
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Mail"
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radTreeView1.ItemHeight = 27

			Me.radCheckBoxShowLines.IsChecked = Me.radTreeView1.ShowLines
			Me.radCheckBoxShowRootLines.IsChecked = Me.radTreeView1.ShowRootLines
			Me.radCheckBoxExpandCollapse.IsChecked = Me.radTreeView1.ShowExpandCollapse
			Me.radCheckBoxFullRowSelect.IsChecked = Me.radTreeView1.FullRowSelect
			Me.radCheckBoxAlternatingRowColor.IsChecked = Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor
			Me.radCheckBoxAutoSizeItems.IsChecked = Me.radTreeView1.TreeViewElement.AutoSizeItems
			Me.radSpinEditorItemHeight.Value = Me.radTreeView1.ItemHeight
			Me.radSpinEditorItemSpacing.Value = Me.radTreeView1.SpacingBetweenNodes

			Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = Me.radTreeView1.TreeViewElement.AlternatingRowColor

			Me.radButtonLineColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = Me.radTreeView1.LineColor
			Me.radButtonLineColor.Enabled = False
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.AllowDefaultContextMenu = True

			LoadData()

			Me.radTreeView1.ExpandAll()
			Me.radTreeView1.Nodes(0).Nodes(1).Current = True
			Me.radTreeView1.Nodes(0).Nodes(1).Selected = True
			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True

			Me.radDropDownList1.SelectedIndex = 2
			Me.radDropDownList1.Enabled = False

			Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView1.AllowPlusMinusAnimation = False
			Me.radTreeView1.PlusMinusAnimationStep = 1
		End Sub

		Private Sub radButtonAlternatingRowColor_Click(ByVal sender As Object, ByVal e As EventArgs) handles radButtonAlternatingRowColor.click
			Dim dialog As New RadColorDialog()
			dialog.SelectedColor = Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radTreeView1.TreeViewElement.AlternatingRowColor = dialog.SelectedColor
			End If
		End Sub

		Private Sub radButtonLineColor_Click(ByVal sender As Object, ByVal e As EventArgs)handles radButtonLineColor.click
			Dim dialog As New RadColorDialog()
			dialog.SelectedColor = Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radTreeView1.LineColor = dialog.SelectedColor
			End If
		End Sub

		Private Sub radSpinEditorItemHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) handles radSpinEditorItemHeight.ValueChanged 
			Me.radTreeView1.ItemHeight = CInt(Fix(radSpinEditorItemHeight.Value))
		End Sub

		Private Sub radSpinEditorItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)handles radSpinEditorItemSpacing.ValueChanged 
			Me.radTreeView1.SpacingBetweenNodes = CInt(Fix(radSpinEditorItemSpacing.Value))
		End Sub

		Private Sub radCheckBoxAutoSizeItems_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxAutoSizeItems.ToggleStateChanged
			Me.radTreeView1.TreeViewElement.AutoSizeItems = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radSpinEditorItemHeight.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			If Me.radSpinEditorItemHeight.Enabled Then
				Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).ItemHeight = 50
			End If
		End Sub

		Private Sub radCheckBoxAlternatingRowColor_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxAlternatingRowColor.ToggleStateChanged
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButtonAlternatingRowColor.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxFullRowSelect_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxFullRowSelect.ToggleStateChanged
			Me.radTreeView1.FullRowSelect = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxExpandCollapse_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)handles radCheckBoxExpandCollapse.ToggleStateChanged
			Me.radTreeView1.ShowExpandCollapse = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxShowRootLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)handles radCheckBoxShowRootLines.ToggleStateChanged
			Me.radTreeView1.ShowRootLines = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxShowLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxShowLines.ToggleStateChanged
			Me.radTreeView1.ShowLines = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButtonLineColor.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radDropDownList1.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) handles radDropDownList1.SelectedIndexChanged
			Me.radTreeView1.LineStyle = CType(e.Position, TreeLineStyle)
		End Sub

		Private Sub radCheckBoxAnimations_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxAnimations.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radTreeView1.ExpandAnimation = ExpandAnimation.Opacity
				Me.radTreeView1.AllowPlusMinusAnimation = True
			Else
				Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
				Me.radTreeView1.AllowPlusMinusAnimation = False
			End If
		End Sub
	End Class
End Namespace