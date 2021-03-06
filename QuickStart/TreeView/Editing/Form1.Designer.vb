Namespace Telerik.Examples.WinControls.TreeView.Editing
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
            Me.components = New System.ComponentModel.Container()
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            Me.radCheckBoxAllowEdit = New Telerik.WinControls.UI.RadCheckBox()
            Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
            Me.radPanel3 = New Telerik.Examples.TreeExampleHeaderPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel4.SuspendLayout()
            CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radCheckBoxAllowEdit)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(965, 1)
            '
            '
            '
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(710, 970)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxAllowEdit, 0)
            '
            'radTreeView1
            '
            Me.radTreeView1.AllowEdit = True
            Me.radTreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(246, 470)
            Me.radTreeView1.TabIndex = 0
            Me.radTreeView1.Text = "radTreeView1"
            '
            'radPanel1
            '
            Me.radPanel1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radPanel1.Location = New System.Drawing.Point(300, 155)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(280, 115)
            Me.radPanel1.TabIndex = 1
            Me.radPanel1.Text = "Hello world!"
            Me.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Hello world!"
            CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).ForeColor = System.Drawing.Color.White
            CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Black
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 5.0!
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Black
            '
            'roundRectShape1
            '
            Me.roundRectShape1.Radius = 3
            '
            'radCheckBoxAllowEdit
            '
            Me.radCheckBoxAllowEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxAllowEdit.Location = New System.Drawing.Point(10, 37)
            Me.radCheckBoxAllowEdit.Name = "radCheckBoxAllowEdit"
            Me.radCheckBoxAllowEdit.Size = New System.Drawing.Size(70, 18)
            Me.radCheckBoxAllowEdit.TabIndex = 1
            Me.radCheckBoxAllowEdit.Text = "Allow Edit"
            Me.radCheckBoxAllowEdit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radPanel4
            '
            Me.radPanel4.Controls.Add(Me.radTreeView1)
            Me.radPanel4.Controls.Add(Me.radPanel1)
            Me.radPanel4.Location = New System.Drawing.Point(17, 56)
            Me.radPanel4.Name = "radPanel4"
            Me.radPanel4.Size = New System.Drawing.Size(639, 470)
            Me.radPanel4.TabIndex = 3
            CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
            CType(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radPanel3
            '
            Me.radPanel3.Location = New System.Drawing.Point(17, 20)
            Me.radPanel3.Name = "radPanel3"
            Me.radPanel3.Size = New System.Drawing.Size(639, 36)
            Me.radPanel3.TabIndex = 2
            Me.radPanel3.Text = "Property manager"
            '
            'Form1
            '
            Me.Controls.Add(Me.radPanel3)
            Me.Controls.Add(Me.radPanel4)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1166, 749)
            Me.Controls.SetChildIndex(Me.radPanel4, 0)
            Me.Controls.SetChildIndex(Me.radPanel3, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel4.ResumeLayout(False)
            CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private WithEvents radCheckBoxAllowEdit As Telerik.WinControls.UI.RadCheckBox
		Private radPanel4 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.Examples.TreeExampleHeaderPanel
	End Class
End Namespace