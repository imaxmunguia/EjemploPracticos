Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.TreeView.FirstLook
	''' <summary>
	''' Example beautifying
	''' </summary>
	Public Partial Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			LoadData()
			Me.radTreeView1.ExpandAll()

			Dim item As New RadMenuItem("None")
			addhandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			item = New RadMenuItem("Ascending")
			addhandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			item = New RadMenuItem("Descending")
			addhandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			Dim searchIcon As New ImagePrimitive()
			searchIcon.Image = my.Resources.TV_search
			searchIcon.Alignment = ContentAlignment.MiddleRight
			Me.radTextBox1.TextBoxElement.Children.Add(searchIcon)
            Me.radTextBox1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
            Me.radTextBox1.TextBoxElement.TextBoxItem.StretchHorizontally = False
            Me.radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MinimumSize = New Size(210, 0)
			addhandler Me.radTextBox1.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = True
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True
			Me.radTreeView1.ItemHeight = 27
			Me.radTreeView1.AllowDefaultContextMenu = True
			Me.AutoScroll = False
			Me.radPanel1.Text = "Subscriptions"
		End Sub

		Private Sub LoadData()
			Dim root As RadTreeNode = Me.radTreeView1.Nodes.Add("Programming")
			root.Nodes.Add("Microsoft Research News and Highlights", 1)

			root.Nodes.Add("Joel on Software", 1)
			root.Nodes.Add("Miguel de Icaza", 1)
			root.Nodes.Add("channel 9", 1)

			root = Me.radTreeView1.Nodes.Add("News (1)")
			root.Nodes.Add("cnn.com (1)", 1)
			root.Nodes.Add("msnbc.com", 1)
			root.Nodes.Add("reuters.com", 1)
			root.Nodes.Add("bbc.co.uk", 1)

			root = Me.radTreeView1.Nodes.Add("Personal (19)")
			root.Nodes.Add("sports (2)", 1)
			Dim folder As RadTreeNode = root.Nodes.Add("fun (17)")
			folder.Nodes.Add("Lolcats (2)", 1)
			folder.Nodes.Add("FFFOUND (15)", 1)

			Me.radTreeView1.Nodes.Add("Telerik blogs", 1)
			Me.radTreeView1.Nodes.Add("Techcrunch", 1)
			Me.radTreeView1.Nodes.Add("Engadget", 1)
		End Sub

		Protected Overrides Sub OnSizeChanged(e As EventArgs)
			MyBase.OnSizeChanged(e)
			If Me.radPanel2 IsNot Nothing Then
				Dim width As Integer = Me.ClientSize.Width
				Dim height As Integer = Me.ClientSize.Height
				Me.radPanel2.Size = New System.Drawing.Size(633, 427)
				Me.radPanel2.Location = New Point((width - radPanel2.Size.Width) \ 2, Me.radPanel2.Location.Y)
			End If
		End Sub

		Private Sub item_Click(sender As Object, e As EventArgs)
			Dim item As RadMenuItem = DirectCast(sender, RadMenuItem)
			Me.radDropDownButton1.Text = item.Text
			If item.Text = "None" Then
				radTreeView1.SortOrder = SortOrder.None
			ElseIf item.Text = "Ascending" Then
				radTreeView1.SortOrder = SortOrder.Ascending
			Else
				radTreeView1.SortOrder = SortOrder.Descending
			End If
		End Sub

		Private Sub radTextBox1_TextChanged(sender As Object, e As EventArgs) handles radTextBox1.TextChanged
			Me.radTreeView1.Filter = Me.radTextBox1.Text
		End Sub

		Private Sub radTreeView1_NodeFormatting(sender As Object, args As TreeNodeFormattingEventArgs) handles radTreeView1.NodeFormatting
			If args.Node.Text.Contains("(") Then
				args.NodeElement.ContentElement.Text = "<html><b>" & args.Node.Text
			End If
		End Sub

		Private Sub TextBoxItem_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) handles radTextBox1.PropertyChanged
			If e.PropertyName = "Bounds" Then
				radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(radTextBox1.Size.Width - 28, 0)
			End If
		End Sub
	End Class
End Namespace
