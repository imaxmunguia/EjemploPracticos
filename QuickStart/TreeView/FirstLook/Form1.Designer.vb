Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.FirstLook
	Partial Class Form1
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
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radPanel1 = New Telerik.Examples.TreeExampleHeaderPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(982, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), System.Drawing.Image))
			Me.btnSpy.Location = New System.Drawing.Point(10, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			' 
			' 
			' 
			Me.btnSpy.RootElement.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New System.Drawing.Size(180, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.btnSpy.ThemeName = "ControlDefault"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "folder_feed.png")
			Me.imageList1.Images.SetKeyName(1, "feed.png")
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel1.Location = New System.Drawing.Point(7, 51)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(619, 30)
			Me.radPanel1.TabIndex = 1
			' 
			' radPanel2
			' 
			Me.radPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom
			Me.radPanel2.BackColor = System.Drawing.Color.Transparent
			Me.radPanel2.Controls.Add(Me.radTreeView1)
			Me.radPanel2.Controls.Add(Me.radPanel3)
			Me.radPanel2.Controls.Add(Me.radPanel1)
			Me.radPanel2.Location = New System.Drawing.Point(31, 50)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New System.Drawing.Size(633, 427)
			Me.radPanel2.TabIndex = 2
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(195))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))))
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(176))))), (CInt(Fix((CByte(233))))))
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radTreeView1.ImageIndex = 0
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New System.Drawing.Point(7, 81)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New System.Drawing.Size(619, 339)
			Me.radTreeView1.TabIndex = 3
			Me.radTreeView1.Text = "radTreeView1"
'			Me.radTreeView1.NodeFormatting += New Telerik.WinControls.UI.TreeNodeFormattingEventHandler(Me.radTreeView1_NodeFormatting);
			' 
			' radPanel3
			' 
			Me.radPanel3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanel3.BackColor = System.Drawing.Color.Transparent
			Me.radPanel3.Controls.Add(Me.radDropDownButton1)
			Me.radPanel3.Controls.Add(Me.radLabel1)
			Me.radPanel3.Controls.Add(Me.radTextBox1)
			Me.radPanel3.Location = New System.Drawing.Point(7, 7)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New System.Drawing.Size(619, 40)
			Me.radPanel3.TabIndex = 2
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 0
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))))
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(176))))), (CInt(Fix((CByte(233))))))
			' 
			' radDropDownButton1
			' 
			Me.radDropDownButton1.Location = New System.Drawing.Point(288, 8)
			Me.radDropDownButton1.Name = "radDropDownButton1"
			Me.radDropDownButton1.Size = New System.Drawing.Size(140, 24)
			Me.radDropDownButton1.TabIndex = 4
			Me.radDropDownButton1.Text = "None"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(253, 10)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(29, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Sort:"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New System.Drawing.Point(6, 10)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.NullText = "Type here to filter"
			Me.radTextBox1.Size = New System.Drawing.Size(241, 20)
			Me.radTextBox1.TabIndex = 0
			Me.radTextBox1.TabStop = False
'			Me.radTextBox1.TextChanged += New System.EventHandler(Me.radTextBox1_TextChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1183, 749)
			Me.Controls.SetChildIndex(Me.radPanel2, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			Me.radPanel3.PerformLayout()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private btnSpy As RadButton
		Private radPanel1 As TreeExampleHeaderPanel
		Private radPanel2 As RadPanel
		Private WithEvents radTreeView1 As RadTreeView
		Private radPanel3 As RadPanel
		Private radLabel1 As RadLabel
		Private WithEvents radTextBox1 As RadTextBox
		Private radDropDownButton1 As RadDropDownButton
	End Class
End Namespace