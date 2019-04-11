Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.CreateRowInfo
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

#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.settingsPanel.AutoScroll = True
			Me.settingsPanel.BackColor = System.Drawing.Color.Transparent
			Me.settingsPanel.Controls.Add(Me.btnSpy)
			Me.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.settingsPanel.Location = New System.Drawing.Point(1103, 1)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.TabIndex = 0
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
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1304, 749)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1304, 749)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

#End Region

		Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
		Private Shadows settingsPanel As Telerik.WinControls.UI.RadPanel
		Private btnSpy As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
