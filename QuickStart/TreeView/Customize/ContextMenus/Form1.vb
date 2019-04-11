Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
	''' <summary>
	''' Form code
	''' </summary>
	Partial Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = My.Resources.TV_email
		Private clickedNode As String

		Public Sub New()
			InitializeComponent()
			Me.radLblSelectedNode.Text = ""
			Me.radLblSelectedItem.Text = ""
			AddHandler Load, AddressOf Form1_Load

			Me.SelectedControl = Me.radTreeViewDemo
			Me.radTreeViewDemo.AllowEdit = True

			AddHandler radContextMenu1.DropDownOpening, AddressOf radContextMenu1_DropDownOpening
		End Sub


		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeViewDemo
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			AddHandler radMenuItem1.Click, AddressOf radMenuItem1_Click
			AddHandler radMenuItem2.Click, AddressOf radMenuItem2_Click
			AddHandler radMenuItem4.Click, AddressOf radMenuItem4_Click
			AddHandler radMenuItem5.Click, AddressOf radMenuItem5_Click

			AddHandler radTreeViewDemo.NodeMouseDown, AddressOf node_MouseDown
		End Sub

		Private Sub node_MouseDown(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			If Control.MouseButtons = MouseButtons.Right Then
				clickedNode = e.Node.Text
			End If
		End Sub

		Private Sub SetLabel(ByVal sender As Object)
			Dim item As RadMenuItem = TryCast(sender, RadMenuItem)

			If item IsNot Nothing Then
				radLblSelectedNode.Text = Me.clickedNode
				radLblSelectedItem.Text = item.Text
			End If
		End Sub

		Private Sub radContextMenu1_DropDownOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Dim node As RadTreeNode = Me.radTreeViewDemo.SelectedNode
			If node IsNot Nothing Then
				Me.radMenuItem1.Enabled = node.Enabled
				Me.radMenuItem4.Enabled = node.Enabled
				Me.radMenuItem5.Enabled = node.Enabled
				If node.Enabled Then
					Me.radMenuItem2.Text = "Disable"
				Else
					Me.radMenuItem2.Text = "Enable"
				End If
			End If
		End Sub

		Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetLabel(sender)
			If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
				Me.radTreeViewDemo.BeginEdit()
			End If
		End Sub

		Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetLabel(sender)
			If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
				Me.radTreeViewDemo.SelectedNode.Enabled = Not Me.radTreeViewDemo.SelectedNode.Enabled
			End If
		End Sub

		Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetLabel(sender)

			If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
				Me.radTreeViewDemo.SelectedNode.Remove()
			End If
		End Sub

		Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetLabel(sender)
			If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
				Me.radTreeViewDemo.SelectedNode.Expand()
				Dim newNode As RadTreeNode = Me.radTreeViewDemo.SelectedNode.Nodes.Add("New Folder")
				If newNode IsNot Nothing Then
					Me.radTreeViewDemo.SelectedNode = newNode
					Me.radTreeViewDemo.BeginEdit()
				End If
			End If
		End Sub
	End Class
End Namespace