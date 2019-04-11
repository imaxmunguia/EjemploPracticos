Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Forms.MDI
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
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMenu1
			' 
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
			Me.radMenu1.Location = New System.Drawing.Point(0, 0)
			Me.radMenu1.Name = "radMenu1"
			Me.radMenu1.Size = New System.Drawing.Size(730, 27)
			Me.radMenu1.TabIndex = 0
			Me.radMenu1.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4, Me.radMenuItem5, Me.radMenuSeparatorItem1, Me.radMenuItem7})
			Me.radMenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "File"
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "New"
'			Me.radMenuItem4.Click += New System.EventHandler(Me.radMenuItem4_Click);
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Close"
'			Me.radMenuItem5.Click += New System.EventHandler(Me.radMenuItem5_Click);
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.MergeOrder = 10
			Me.radMenuItem7.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Exit"
'			Me.radMenuItem7.Click += New System.EventHandler(Me.radMenuItem7_Click);
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem8})
			Me.radMenuItem2.MdiList = True
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Window"
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Close all windows"
'			Me.radMenuItem8.Click += New System.EventHandler(Me.radMenuItem8_Click);
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem6})
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Help"
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "About"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(255))))))
			Me.ClientSize = New System.Drawing.Size(730, 285)
			Me.Controls.Add(Me.radMenu1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New System.Drawing.Size(150, 36)
			Me.Text = "RadForm MDI Example"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private WithEvents radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem8 As Telerik.WinControls.UI.RadMenuItem

	End Class
End Namespace