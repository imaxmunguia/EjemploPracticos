Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.BasicStates
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
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.BackColor = System.Drawing.Color.Transparent
			Me.radMenuDemo.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
			Me.radMenuDemo.Location = New System.Drawing.Point(1, 1)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.RootElement.ToolTipText = Nothing
			Me.radMenuDemo.Size = New System.Drawing.Size(499, 27)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem6, Me.radMenuItem7, Me.radMenuSeparatorItem1})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "Add items at runtime"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Add a new Text file"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToolTipText = Nothing
'			Me.radMenuItem4.Click += New System.EventHandler(Me.addItem_Click);
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Add a new XML file"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.ToolTipText = Nothing
'			Me.radMenuItem5.Click += New System.EventHandler(Me.addItem_Click);
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Add a new Project"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.ToolTipText = Nothing
'			Me.radMenuItem6.Click += New System.EventHandler(Me.addItem_Click);
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Add a new Solution"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.ToolTipText = Nothing
'			Me.radMenuItem7.Click += New System.EventHandler(Me.addItem_Click);
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem8, Me.radMenuItem9, Me.radMenuItem10, Me.radMenuItem11})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "Remove items at runtime"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Remove this Text file"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.ToolTipText = Nothing
'			Me.radMenuItem8.Click += New System.EventHandler(Me.removeItem_Click);
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Remove this XML file"
			Me.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem9.ToolTipText = Nothing
'			Me.radMenuItem9.Click += New System.EventHandler(Me.removeItem_Click);
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Remove this Project"
			Me.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem10.ToolTipText = Nothing
'			Me.radMenuItem10.Click += New System.EventHandler(Me.removeItem_Click);
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Remove this Solution"
			Me.radMenuItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem11.ToolTipText = Nothing
'			Me.radMenuItem11.Click += New System.EventHandler(Me.removeItem_Click);
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem12, Me.radMenuItem13, Me.radMenuItem14, Me.radMenuItem15})
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.ShowArrow = False
			Me.radMenuItem3.Text = "Disable items at runtime"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Disable this Text file"
			Me.radMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem12.ToolTipText = Nothing
'			Me.radMenuItem12.Click += New System.EventHandler(Me.disableItem_Click);
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Disable this XML file"
			Me.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem13.ToolTipText = Nothing
'			Me.radMenuItem13.Click += New System.EventHandler(Me.disableItem_Click);
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Disable this Project"
			Me.radMenuItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem14.ToolTipText = Nothing
'			Me.radMenuItem14.Click += New System.EventHandler(Me.disableItem_Click);
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Disable this Solution"
			Me.radMenuItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem15.ToolTipText = Nothing
'			Me.radMenuItem15.Click += New System.EventHandler(Me.disableItem_Click);
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.BackColor = System.Drawing.Color.White
			Me.radPanel1.Controls.Add(Me.radMenuDemo)
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(370, 236)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radPanel1.Size = New System.Drawing.Size(500, 350)
			Me.radPanel1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoSize = True
			Me.Controls.Add(Me.radPanel1)
			Me.MaximumSize = New System.Drawing.Size(1280, 994)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 820)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace