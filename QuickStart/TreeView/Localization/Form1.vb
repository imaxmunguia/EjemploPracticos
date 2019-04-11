Imports System
Imports System.Drawing
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Localization
	''' <summary>
	''' Form code
	''' </summary>
	Partial Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = My.Resources.TV_email
		Private oldProvider As TreeViewLocalizationProvider

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
			Me.radTreeView1.Nodes.Add(New RadTreeNode("Persönliche Ordner", My.Resources.TV_RootFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Gelöschte Objekte", My.Resources.TV_RecycleBin))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Drafts", My.Resources.TV_DraftFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Posteingang", My.Resources.TV_InboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Junk-E-Mails", My.Resources.TV_JunkFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Postausgang", My.Resources.TV_OutboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Gesendete Objekte", My.Resources.TV_SentFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Suchordner", My.Resources.TV_SearchFolder))

			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Von Follow-up", My.Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Große Nachrichten", My.Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Ungelesene Nachrichten", My.Resources.TV_SearchFolder))
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			LoadData()
			Me.radTreeView1.ExpandAll()
			Me.radTreeView1.SelectedNode = Me.radTreeView1.Nodes(0).Nodes(3)

			oldProvider = TreeViewLocalizationProvider.CurrentProvider
			TreeViewLocalizationProvider.CurrentProvider = New GermanTreeViewLocalizationProvider()
			Me.radTreeView1.AllowDefaultContextMenu = True
		End Sub

		Protected Overrides Sub DestroyHandle()
			MyBase.DestroyHandle()
			TreeViewLocalizationProvider.CurrentProvider = New TreeViewLocalizationProvider()
		End Sub
		
		Private Sub radRadioButtonGerman_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) handles radRadioButtonGerman.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				TreeViewLocalizationProvider.CurrentProvider = New GermanTreeViewLocalizationProvider()
			Else
				TreeViewLocalizationProvider.CurrentProvider = New TreeViewLocalizationProvider()
			End If
		End Sub
	End Class
End Namespace