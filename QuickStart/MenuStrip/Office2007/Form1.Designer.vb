Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.Office2007
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.menuImages = New System.Windows.Forms.ImageList(Me.components)
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem30 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem31 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem32 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem25 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem26 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem27 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem28 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem29 = New Telerik.WinControls.UI.RadMenuItem()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(803, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 641)
			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radMenuDemo.BackColor = System.Drawing.Color.Transparent
			Me.radMenuDemo.Dock = System.Windows.Forms.DockStyle.None
			Me.radMenuDemo.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.ImageList = Me.menuImages
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem6, Me.radMenuItem7, Me.radMenuItem8})
			Me.radMenuDemo.Location = New System.Drawing.Point(342, 134)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.RootElement.ToolTipText = Nothing
			Me.radMenuDemo.Size = New System.Drawing.Size(94, 374)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"
			CType(Me.radMenuDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Layout.WrapLayoutPanel).ItemWidth = 94F
			' 
			' menuImages
			' 
			Me.menuImages.ImageStream = (CType(resources.GetObject("menuImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.menuImages.TransparentColor = System.Drawing.Color.Lime
			Me.menuImages.Images.SetKeyName(0, "1_New.gif")
			Me.menuImages.Images.SetKeyName(1, "2_Open.gif")
			Me.menuImages.Images.SetKeyName(2, "3_Save.gif")
			Me.menuImages.Images.SetKeyName(3, "4_Save_As.gif")
			Me.menuImages.Images.SetKeyName(4, "5_Print.gif")
			Me.menuImages.Images.SetKeyName(5, "6_Prepare.gif")
			Me.menuImages.Images.SetKeyName(6, "7_Send.gif")
			Me.menuImages.Images.SetKeyName(7, "8_Publish.gif")
			Me.menuImages.Images.SetKeyName(8, "9_Close.gif")
			Me.menuImages.Images.SetKeyName(9, "1_Word_Document.gif")
			Me.menuImages.Images.SetKeyName(10, "2_Word_Template.gif")
			Me.menuImages.Images.SetKeyName(11, "3_Word_97.gif")
			Me.menuImages.Images.SetKeyName(12, "4_Find_Addins.gif")
			Me.menuImages.Images.SetKeyName(13, "5_Other_Formats.gif")
			Me.menuImages.Images.SetKeyName(14, "1_Print.gif")
			Me.menuImages.Images.SetKeyName(15, "2_Quick_Print.gif")
			Me.menuImages.Images.SetKeyName(16, "3_Print_Preview.gif")
			Me.menuImages.Images.SetKeyName(17, "1_Properties.gif")
			Me.menuImages.Images.SetKeyName(18, "2_Inspect-Document.gif")
			Me.menuImages.Images.SetKeyName(19, "3_Encrypt_Document.gif")
			Me.menuImages.Images.SetKeyName(20, "4_Restrict_Permission.gif")
			Me.menuImages.Images.SetKeyName(21, "5_Add_a_digital_signature.gif")
			Me.menuImages.Images.SetKeyName(22, "6_Mark_As_Final.gif")
			Me.menuImages.Images.SetKeyName(23, "7_Run_Compatibility_Checker.gif")
			Me.menuImages.Images.SetKeyName(24, "1_E-mail.gif")
			Me.menuImages.Images.SetKeyName(25, "2_Internet_Fax.gif")
			Me.menuImages.Images.SetKeyName(26, "1_Blog.gif")
			Me.menuImages.Images.SetKeyName(27, "2-Document_Management.gif")
			Me.menuImages.Images.SetKeyName(28, "3_Create_Document_Workspace.gif")
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Image = (CType(resources.GetObject("radMenuItem1.Image"), System.Drawing.Image))
			Me.radMenuItem1.ImageIndex = 0
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem1.Text = "New"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Image = (CType(resources.GetObject("radMenuItem2.Image"), System.Drawing.Image))
			Me.radMenuItem2.ImageIndex = 1
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem2.Text = "Open"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Image = (CType(resources.GetObject("radMenuItem3.Image"), System.Drawing.Image))
			Me.radMenuItem3.ImageIndex = 2
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem3.Text = "Save"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem4.Image = (CType(resources.GetObject("radMenuItem4.Image"), System.Drawing.Image))
			Me.radMenuItem4.ImageIndex = 3
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem10, Me.radMenuItem11, Me.radMenuItem12, Me.radMenuItem13, Me.radMenuItem14})
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem4.Text = "Save As"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToolTipText = Nothing
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.DescriptionText = "Save the document in the default file format."
			Me.radMenuItem10.Image = (CType(resources.GetObject("radMenuItem10.Image"), System.Drawing.Image))
			Me.radMenuItem10.ImageIndex = 9
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Word Document"
			Me.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem10.ToolTipText = Nothing
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.DescriptionText = "Save the document as a template that can be used to format future documents."
			Me.radMenuItem11.Image = (CType(resources.GetObject("radMenuItem11.Image"), System.Drawing.Image))
			Me.radMenuItem11.ImageIndex = 10
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Word Template"
			Me.radMenuItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem11.ToolTipText = Nothing
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.DescriptionText = "Save a copy of the document that is fully compatible with Word 97-2003."
			Me.radMenuItem12.Image = (CType(resources.GetObject("radMenuItem12.Image"), System.Drawing.Image))
			Me.radMenuItem12.ImageIndex = 11
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Word 97-2003 Document"
			Me.radMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem12.ToolTipText = Nothing
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.DescriptionText = "Learn about add-ins to save to other formats such as PDF or XPS."
			Me.radMenuItem13.Image = (CType(resources.GetObject("radMenuItem13.Image"), System.Drawing.Image))
			Me.radMenuItem13.ImageIndex = 12
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Find add-ins for other file formats"
			Me.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem13.ToolTipText = Nothing
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.DescriptionText = "Open the Save As dialog box to select from all possible file types."
			Me.radMenuItem14.Image = (CType(resources.GetObject("radMenuItem14.Image"), System.Drawing.Image))
			Me.radMenuItem14.ImageIndex = 13
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Other Formats"
			Me.radMenuItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem14.ToolTipText = Nothing
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem5.Image = (CType(resources.GetObject("radMenuItem5.Image"), System.Drawing.Image))
			Me.radMenuItem5.ImageIndex = 4
			Me.radMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem15, Me.radMenuItem16, Me.radMenuItem17})
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem5.Text = "Print"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.ToolTipText = Nothing
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.DescriptionText = "Select a printer, number of copies, and other printing options before printing."
			Me.radMenuItem15.Image = (CType(resources.GetObject("radMenuItem15.Image"), System.Drawing.Image))
			Me.radMenuItem15.ImageIndex = 14
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Print"
			Me.radMenuItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem15.ToolTipText = Nothing
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.DescriptionText = "Send the document directly to the default printer without making changes."
			Me.radMenuItem16.Image = (CType(resources.GetObject("radMenuItem16.Image"), System.Drawing.Image))
			Me.radMenuItem16.ImageIndex = 15
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Quick Print"
			Me.radMenuItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem16.ToolTipText = Nothing
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.DescriptionText = "Preview and make changes to pages before printing."
			Me.radMenuItem17.Image = (CType(resources.GetObject("radMenuItem17.Image"), System.Drawing.Image))
			Me.radMenuItem17.ImageIndex = 16
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Print Preview"
			Me.radMenuItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem17.ToolTipText = Nothing
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem6.Image = (CType(resources.GetObject("radMenuItem6.Image"), System.Drawing.Image))
			Me.radMenuItem6.ImageIndex = 5
			Me.radMenuItem6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem18, Me.radMenuItem19, Me.radMenuItem20, Me.radMenuItem21, Me.radMenuItem22, Me.radMenuItem23, Me.radMenuItem24})
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem6.Text = "Prepare"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.ToolTipText = Nothing
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.DescriptionText = "View and edit document properties, such as Title, Author, and Keywords."
			Me.radMenuItem18.Image = (CType(resources.GetObject("radMenuItem18.Image"), System.Drawing.Image))
			Me.radMenuItem18.ImageIndex = 17
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Properties"
			Me.radMenuItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem18.ToolTipText = Nothing
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.DescriptionText = "Check the document for hidden metadata or personal information."
			Me.radMenuItem19.Image = (CType(resources.GetObject("radMenuItem19.Image"), System.Drawing.Image))
			Me.radMenuItem19.ImageIndex = 18
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Inspect Document"
			Me.radMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem19.ToolTipText = Nothing
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.DescriptionText = "Increase the security of the document by adding encryption."
			Me.radMenuItem20.Image = (CType(resources.GetObject("radMenuItem20.Image"), System.Drawing.Image))
			Me.radMenuItem20.ImageIndex = 19
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Encrypt Document"
			Me.radMenuItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem20.ToolTipText = Nothing
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.DescriptionText = "Grant people access while restricting their ability to edit, copy, and print."
			Me.radMenuItem21.Image = (CType(resources.GetObject("radMenuItem21.Image"), System.Drawing.Image))
			Me.radMenuItem21.ImageIndex = 20
			Me.radMenuItem21.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem30, Me.radMenuItem31, Me.radMenuItem32})
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "Restrict Permission"
			Me.radMenuItem21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem21.ToolTipText = Nothing
			' 
			' radMenuItem30
			' 
			Me.radMenuItem30.CheckOnClick = True
			Me.radMenuItem30.Name = "radMenuItem30"
			Me.radMenuItem30.Text = "Unrestricted Access"
			Me.radMenuItem30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem30.ToolTipText = Nothing
			' 
			' radMenuItem31
			' 
			Me.radMenuItem31.CheckOnClick = True
			Me.radMenuItem31.Name = "radMenuItem31"
			Me.radMenuItem31.Text = "Restricted Access"
			Me.radMenuItem31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem31.ToolTipText = Nothing
			' 
			' radMenuItem32
			' 
			Me.radMenuItem32.CheckOnClick = True
			Me.radMenuItem32.Name = "radMenuItem32"
			Me.radMenuItem32.Text = "Manage Credentials"
			Me.radMenuItem32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem32.ToolTipText = Nothing
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.DescriptionText = "Ensure the integrity of the document by adding an invisible digital signature."
			Me.radMenuItem22.Image = (CType(resources.GetObject("radMenuItem22.Image"), System.Drawing.Image))
			Me.radMenuItem22.ImageIndex = 21
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Text = "Add a Digital Signature"
			Me.radMenuItem22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem22.ToolTipText = Nothing
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.DescriptionText = "Let readers know the document is final and make it read-only."
			Me.radMenuItem23.Image = (CType(resources.GetObject("radMenuItem23.Image"), System.Drawing.Image))
			Me.radMenuItem23.ImageIndex = 22
			Me.radMenuItem23.Name = "radMenuItem23"
			Me.radMenuItem23.Text = "Mark as Final"
			Me.radMenuItem23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem23.ToolTipText = Nothing
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.DescriptionText = "Check for features not supported by earlier versions of Word."
			Me.radMenuItem24.Image = (CType(resources.GetObject("radMenuItem24.Image"), System.Drawing.Image))
			Me.radMenuItem24.ImageIndex = 23
			Me.radMenuItem24.Name = "radMenuItem24"
			Me.radMenuItem24.Text = "Run Compatibility Checker"
			Me.radMenuItem24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem24.ToolTipText = Nothing
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem7.Image = (CType(resources.GetObject("radMenuItem7.Image"), System.Drawing.Image))
			Me.radMenuItem7.ImageIndex = 6
			Me.radMenuItem7.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem25, Me.radMenuItem26})
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem7.Text = "Send"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.ToolTipText = Nothing
			' 
			' radMenuItem25
			' 
			Me.radMenuItem25.DescriptionText = "Send a copy of the document in an e-mail message as an attachment."
			Me.radMenuItem25.Image = (CType(resources.GetObject("radMenuItem25.Image"), System.Drawing.Image))
			Me.radMenuItem25.ImageIndex = 24
			Me.radMenuItem25.Name = "radMenuItem25"
			Me.radMenuItem25.Text = "E-mail"
			Me.radMenuItem25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem25.ToolTipText = Nothing
			' 
			' radMenuItem26
			' 
			Me.radMenuItem26.DescriptionText = "Use an Internet fax service to fax the document."
			Me.radMenuItem26.Image = (CType(resources.GetObject("radMenuItem26.Image"), System.Drawing.Image))
			Me.radMenuItem26.ImageIndex = 25
			Me.radMenuItem26.Name = "radMenuItem26"
			Me.radMenuItem26.Text = "Internet Fax"
			Me.radMenuItem26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem26.ToolTipText = Nothing
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem8.Image = (CType(resources.GetObject("radMenuItem8.Image"), System.Drawing.Image))
			Me.radMenuItem8.ImageIndex = 7
			Me.radMenuItem8.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem27, Me.radMenuItem28, Me.radMenuItem29})
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem8.Text = "Publish"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.ToolTipText = Nothing
			' 
			' radMenuItem27
			' 
			Me.radMenuItem27.DescriptionText = "Create a new blog post with the content of the document."
			Me.radMenuItem27.Image = (CType(resources.GetObject("radMenuItem27.Image"), System.Drawing.Image))
			Me.radMenuItem27.ImageIndex = 26
			Me.radMenuItem27.Name = "radMenuItem27"
			Me.radMenuItem27.Text = "Blog"
			Me.radMenuItem27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem27.ToolTipText = Nothing
			' 
			' radMenuItem28
			' 
			Me.radMenuItem28.DescriptionText = "Share the document by saving it to a document management server."
			Me.radMenuItem28.Image = (CType(resources.GetObject("radMenuItem28.Image"), System.Drawing.Image))
			Me.radMenuItem28.ImageIndex = 27
			Me.radMenuItem28.Name = "radMenuItem28"
			Me.radMenuItem28.Text = "Document Management Server"
			Me.radMenuItem28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem28.ToolTipText = Nothing
			' 
			' radMenuItem29
			' 
			Me.radMenuItem29.DescriptionText = "Create a new site for the document and keep the local copy synchronized."
			Me.radMenuItem29.Image = (CType(resources.GetObject("radMenuItem29.Image"), System.Drawing.Image))
			Me.radMenuItem29.ImageIndex = 28
			Me.radMenuItem29.Name = "radMenuItem29"
			Me.radMenuItem29.Text = "Create Document Workspace"
			Me.radMenuItem29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem29.ToolTipText = Nothing
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radMenuDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1004, 643)
			Me.Controls.SetChildIndex(Me.radMenuDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private menuImages As System.Windows.Forms.ImageList
		Private radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem21 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem23 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem24 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem25 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem26 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem27 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem28 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem29 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem30 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem31 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem32 As Telerik.WinControls.UI.RadMenuItem
	End Class
End Namespace