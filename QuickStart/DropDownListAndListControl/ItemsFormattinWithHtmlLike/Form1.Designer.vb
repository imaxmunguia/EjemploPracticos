Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ItemsFormattinWithHtmlLike
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1183, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 694)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radListControl1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "ListControl"
			Me.radGroupBox1.Location = New System.Drawing.Point(217, 50)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(270, 438)
			Me.radGroupBox1.TabIndex = 10
			Me.radGroupBox1.Text = "ListControl"
			' 
			' radListControl1
			' 
			Me.radListControl1.DisplayMember = ""
			Me.radListControl1.Location = New System.Drawing.Point(13, 23)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New System.Drawing.Size(244, 402)
			Me.radListControl1.TabIndex = 1
			Me.radListControl1.Text = "radListControl1"
			Me.radListControl1.ValueMember = ""
'			Me.radListControl1.VisualItemFormatting += New Telerik.WinControls.UI.VisualListItemFormattingEventHandler(Me.radListControl1_VisualItemFormatting);
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox4.FooterImageIndex = -1
			Me.radGroupBox4.FooterImageKey = ""
			Me.radGroupBox4.HeaderImageIndex = -1
			Me.radGroupBox4.HeaderImageKey = ""
			Me.radGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox4.HeaderText = "DropDownList"
			Me.radGroupBox4.Location = New System.Drawing.Point(554, 50)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox4.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox4.Size = New System.Drawing.Size(270, 438)
			Me.radGroupBox4.TabIndex = 11
			Me.radGroupBox4.Text = "DropDownList"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.AutoSize = True
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownHeight = 0
			Me.radDropDownList1.Location = New System.Drawing.Point(13, 23)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New System.Drawing.Size(244, 20)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.TabStop = False
			Me.radDropDownList1.Text = "ListItem 3"
'			Me.radDropDownList1.VisualListItemFormatting += New Telerik.WinControls.UI.VisualListItemFormattingEventHandler(Me.radListControl1_VisualItemFormatting);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGroupBox1)
			Me.Controls.Add(Me.radGroupBox4)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1384, 696)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox4, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radListControl1 As Telerik.WinControls.UI.RadListControl
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace