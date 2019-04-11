﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.NodeFormatting
	Partial Class Form1
		Inherits TreeExamplesControl
		Private boldFont As Font
		Private bottomRightBitmap As Bitmap = My.Resources.TV_email

		Public Sub New()
			InitializeComponent()
			AddHandler radTreeView1.TreeViewElement.NodeFormatting, AddressOf TreeViewElement_NodeFormatting
		End Sub

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Mail"
			End Get
		End Property

		Private Sub LoadData()
			Dim table As New DataTable()

			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("ParentID", GetType(Integer))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Title", GetType(String))
			table.Columns.Add("Icon", GetType(Image))
			table.Columns.Add("IsNew", GetType(Boolean))
			table.Columns.Add("NewItemCount", GetType(Integer))
			table.Columns.Add("IsImportant", GetType(Boolean))
			table.Columns.Add("HasFlag", GetType(Boolean))

			table.Rows.Add(0, Nothing, "Personal Folders", Nothing, My.Resources.TV_RootFolder)
			table.Rows.Add(1, 0, "Deleted Items", Nothing, My.Resources.TV_RecycleBin, False, 1)
			table.Rows.Add(2, 0, "Drafts", Nothing, My.Resources.TV_DraftFolder)
			table.Rows.Add(3, 0, "Inbox", Nothing, My.Resources.TV_DraftFolder, False, 3)
			table.Rows.Add(4, 0, "Junk E-mails", Nothing, My.Resources.TV_DraftFolder)
			table.Rows.Add(5, 0, "Outbox", Nothing, My.Resources.TV_DraftFolder)
			table.Rows.Add(6, 0, "Send Items", Nothing, My.Resources.TV_DraftFolder)
			table.Rows.Add(7, 0, "Search Folder", Nothing, My.Resources.TV_DraftFolder)

			table.Rows.Add(8, 1, "Adam Smith", "You`ve got to see this!", My.Resources.TV_MailNew, True)
			table.Rows.Add(9, 3, "Lewis Clark", "This is extremely urgent", My.Resources.TV_MailNew, True, Nothing, True)
			table.Rows.Add(10, 3, "Tomas Brown", "Need your help with this article", My.Resources.TV_MailOpened, False, Nothing, False, True)
			table.Rows.Add(11, 3, "Jeff Patel", "Please, check this our and report by Tomorow!", My.Resources.TV_MailNew, True)
			table.Rows.Add(12, 3, "Smith Jones", "Seend this yet?", My.Resources.TV_MailNew, True)
			table.Rows.Add(13, 3, "Denis Cooper", "Great new tool", My.Resources.TV_MailOpened, False)
			table.Rows.Add(14, 3, "Jackie Turner", "Team Building Session - All Hands", My.Resources.TV_MailOpened, False, Nothing, True)

			Me.radTreeView1.DataSource = table
			Me.radTreeView1.DisplayMember = "Name"
			Me.radTreeView1.ChildMember = "ID"
			Me.radTreeView1.ParentMember = "ParentID"
			Me.radTreeView1.ExpandAll()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			LoadData()
			Me.radTreeView1.AllowEdit = False
		End Sub

		Protected Overrides Function CalculateTreeWidth(ByVal clientWidth As Integer) As Integer
			Return 420
		End Function

		Private Sub TreeViewElement_NodeFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.TreeNodeFormattingEventArgs)
			If (Not radCheckBoxFormatting.IsChecked) Then
				args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
				args.NodeElement.ContentElement.DisableHTMLRendering = True
				CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
				Return
			End If

			Dim rowView As DataRowView = CType(args.Node.DataBoundItem, DataRowView)
			args.NodeElement.ImageElement.Image = CType(rowView("Icon"), Image)

			args.NodeElement.ClipDrawing = False

			Dim element As RadElement = args.NodeElement.Children(0)

			Dim imageElement As LightVisualElement = Nothing
			If element.Name <> "StateImage" Then
				imageElement = New LightVisualElement()
				imageElement.Name = "StateImage"
				imageElement.StretchHorizontally = False
				imageElement.ImageLayout = ImageLayout.Center
				imageElement.MinSize = New System.Drawing.Size(20, 20)
				imageElement.DrawBorder = True
				imageElement.DrawFill = True
				imageElement.GradientStyle = GradientStyles.Linear
				imageElement.GradientAngle = 0
				imageElement.NumberOfColors = 2
				imageElement.BorderBoxStyle = BorderBoxStyle.FourBorders

				imageElement.BorderRightWidth = 1
				imageElement.FitToSizeMode = RadFitToSizeMode.FitToParentBounds
				args.NodeElement.Children.Insert(0, imageElement)

				imageElement.BackColor = Color.FromArgb(255, 255, 255)
				imageElement.BackColor2 = Color.FromArgb(226, 226, 226)
				imageElement.BorderRightColor = Color.FromArgb(180, 184, 191)
				imageElement.BorderRightShadowColor = Color.FromArgb(241, 241, 241)
				imageElement.BorderLeftWidth = 0
				imageElement.BorderTopWidth = 0
				imageElement.BorderBottomWidth = 0
			Else
				imageElement = CType(args.NodeElement.Children(0), LightVisualElement)
			End If


			If rowView("Title") IsNot DBNull.Value Then
				args.NodeElement.ContentElement.Text = CStr(rowView("Name")) & " - " & CStr(rowView("Title"))
				If CBool(rowView("IsNew")) Then
					If boldFont Is Nothing Then
						boldFont = New Font(Me.Font, FontStyle.Bold)
					End If
					args.NodeElement.ContentElement.Font = boldFont
				Else
					args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
				End If

				If rowView("IsImportant") IsNot DBNull.Value Then
					If CBool(rowView("IsImportant")) Then
						CType(args.NodeElement.Children(0), LightVisualElement).Image = My.Resources.TV_Exclamation
					Else
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
					End If
				End If

				If rowView("HasFlag") IsNot DBNull.Value Then
					If CBool(rowView("HasFlag")) Then
						CType(args.NodeElement.Children(0), LightVisualElement).Image = My.Resources.TV_RedFlag
					Else
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
					End If
				End If
			ElseIf rowView("NewItemCount") IsNot DBNull.Value Then
				Dim newItemCount As Integer = CInt(Fix(rowView("NewItemCount")))
				args.NodeElement.ContentElement.DisableHTMLRendering = False
				args.NodeElement.ContentElement.Text = "<html> " & args.Node.Text & "<color=blue>(" & newItemCount & ")"
			End If
		End Sub

		Private Sub radCheckBoxFormatting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) handles radCheckBoxFormatting.ToggleStateChanged
			Me.radTreeView1.TreeViewElement.Update(RadTreeViewElement.UpdateActions.StateChanged)
		End Sub
	End Class
End Namespace