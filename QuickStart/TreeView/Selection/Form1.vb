Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.TreeView.Selection
	''' <summary>
	''' Form code
	''' </summary>
	Partial Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = My.Resources.TV_email

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTreeView1
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
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			LoadData()
			Me.radTreeView1.ExpandAll()
			Me.radTreeView1.MultiSelect = True
			Me.radTreeView1.AllowEdit = False
		End Sub

		Private Sub radCheckBoxAllowMultiSelect_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radCheckBoxAllowMultiSelect.ToggleStateChanged
			Me.radTreeView1.MultiSelect = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radButtonSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) handles radButtonSelectAll.Click
			Me.radTreeView1.SelectAll()
		End Sub

		Private Sub radButtonClearSelection_Click(ByVal sender As Object, ByVal e As EventArgs) handles radButtonClearSelection.Click
			Me.radTreeView1.ClearSelection()
		End Sub

		Private Sub radButtonToggleSelection_Click(ByVal sender As Object, ByVal e As EventArgs) handles radButtonToggleSelection.Click 
			If Me.radTreeView1.SelectedNode IsNot Nothing Then
				Me.radTreeView1.SelectedNode.Selected = Not Me.radTreeView1.SelectedNode.Selected
			End If
		End Sub
	End Class
End Namespace