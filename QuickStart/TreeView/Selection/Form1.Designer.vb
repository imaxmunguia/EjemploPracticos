﻿Namespace Telerik.Examples.WinControls.TreeView.Selection
	Partial Friend Class Form1
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
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.radCheckBoxAllowMultiSelect = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonSelectAll = New Telerik.WinControls.UI.RadButton()
            Me.radButtonClearSelection = New Telerik.WinControls.UI.RadButton()
            Me.radButtonToggleSelection = New Telerik.WinControls.UI.RadButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxAllowMultiSelect, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonClearSelection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonToggleSelection, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radButtonToggleSelection)
            Me.settingsPanel.Controls.Add(Me.radButtonClearSelection)
            Me.settingsPanel.Controls.Add(Me.radButtonSelectAll)
            Me.settingsPanel.Controls.Add(Me.radCheckBoxAllowMultiSelect)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(965, 1)
            '
            '
            '
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxAllowMultiSelect, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonSelectAll, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonClearSelection, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonToggleSelection, 0)
            '
            'radTreeView1
            '
            Me.radTreeView1.AccessibleName = "RadTreeView"
            Me.radTreeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.List
            Me.radTreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
            Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
            Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
            Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radTreeView1.ItemHeight = 27
            Me.radTreeView1.Location = New System.Drawing.Point(7, 18)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(246, 441)
            Me.radTreeView1.TabIndex = 0
            Me.radTreeView1.Text = "radTreeView1"
            '
            'radCheckBoxAllowMultiSelect
            '
            Me.radCheckBoxAllowMultiSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxAllowMultiSelect.Location = New System.Drawing.Point(10, 38)
            Me.radCheckBoxAllowMultiSelect.Name = "radCheckBoxAllowMultiSelect"
            Me.radCheckBoxAllowMultiSelect.Size = New System.Drawing.Size(139, 18)
            Me.radCheckBoxAllowMultiSelect.TabIndex = 1
            Me.radCheckBoxAllowMultiSelect.Text = "Allow multiple selection"
            Me.radCheckBoxAllowMultiSelect.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radButtonSelectAll
            '
            Me.radButtonSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonSelectAll.Location = New System.Drawing.Point(10, 63)
            Me.radButtonSelectAll.Name = "radButtonSelectAll"
            Me.radButtonSelectAll.Size = New System.Drawing.Size(180, 24)
            Me.radButtonSelectAll.TabIndex = 2
            Me.radButtonSelectAll.Text = "Select All"
            '
            'radButtonClearSelection
            '
            Me.radButtonClearSelection.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonClearSelection.Location = New System.Drawing.Point(10, 94)
            Me.radButtonClearSelection.Name = "radButtonClearSelection"
            Me.radButtonClearSelection.Size = New System.Drawing.Size(180, 24)
            Me.radButtonClearSelection.TabIndex = 3
            Me.radButtonClearSelection.Text = "Clear Selection"
            '
            'radButtonToggleSelection
            '
            Me.radButtonToggleSelection.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonToggleSelection.Location = New System.Drawing.Point(10, 125)
            Me.radButtonToggleSelection.Name = "radButtonToggleSelection"
            Me.radButtonToggleSelection.Size = New System.Drawing.Size(180, 24)
            Me.radButtonToggleSelection.TabIndex = 4
            Me.radButtonToggleSelection.Text = "Toggle Selection"
            '
            'Form1
            '
            Me.Controls.Add(Me.radTreeView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1166, 832)
            Me.Controls.SetChildIndex(Me.radTreeView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAllowMultiSelect, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonClearSelection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonToggleSelection, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private WithEvents radButtonToggleSelection As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonClearSelection As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonSelectAll As Telerik.WinControls.UI.RadButton
		Private WithEvents radCheckBoxAllowMultiSelect As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace