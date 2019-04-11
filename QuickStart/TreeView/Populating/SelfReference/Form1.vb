Imports System
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.QuickStart.WinControls
Imports System.Drawing

Namespace Telerik.Examples.WinControls.TreeView.Populating.SelfReference
	''' <summary>
	''' RadTreeView example
	''' </summary>
	Partial Class Form1
		Inherits TreeExamplesControl
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTreeView1
			me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = true
            me.radTreeView1.DataSource = me.employeeBindingSource
			Me.radTreeView1.DisplayMember = "Title"
			Me.radTreeView1.ParentMember = "ManagerID"
			Me.radTreeView1.ChildMember = "EmployeeID"
			Me.radTreeView1.AllowDragDrop = true
			'Note: The self-reference binding properties can be setup using Visual Studio Properties Window or Smart Tag
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Employees"
			End Get
		End Property

		Private Sub ExpandNodes()
			Dim root As RadTreeNode = Me.radTreeView1.Nodes(0)
			root.Expand()
			Dim index As Integer = 0

			For Each node As RadTreeNode In root.Nodes
				If index Mod 2 = 0 Then
					node.Expand()
				End If

				index += 1
			Next node

			If root.Nodes.Count > 0 Then
				root.Nodes(root.Nodes.Count - 1).ExpandAll()
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) handles me.load 
			' TODO: This line of code loads data into the 'adventureLT2008DataSet.Employee' table. You can move, or remove it, as needed.
			Me.employeeTableAdapter.Fill(Me.adventureLT2008DataSet.Employee)

			ExpandNodes()

			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = True
		End Sub
	End Class
End Namespace
