Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.TreeView.Localization
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
			TreeViewLocalizationProvider.CurrentProvider = oldProvider
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
            Me.radGroupBoxEnglish = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioButtonGerman = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonEnglish = New Telerik.WinControls.UI.RadRadioButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBoxEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxEnglish.SuspendLayout()
            CType(Me.radRadioButtonGerman, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radGroupBoxEnglish)
            Me.settingsPanel.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Location = New System.Drawing.Point(965, 1)
            '
            '
            '
            Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
            Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
            Me.settingsPanel.ThemeName = "ControlDefault"
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxEnglish, 0)
            '
            'radTreeView1
            '
            Me.radTreeView1.ItemHeight = 27
            Me.radTreeView1.Location = New System.Drawing.Point(17, 19)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(246, 441)
            Me.radTreeView1.TabIndex = 0
            Me.radTreeView1.Text = "radTreeView1"
            '
            'radGroupBoxEnglish
            '
            Me.radGroupBoxEnglish.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxEnglish.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxEnglish.Controls.Add(Me.radRadioButtonGerman)
            Me.radGroupBoxEnglish.Controls.Add(Me.radRadioButtonEnglish)
            Me.radGroupBoxEnglish.FooterImageIndex = -1
            Me.radGroupBoxEnglish.FooterImageKey = ""
            Me.radGroupBoxEnglish.HeaderImageIndex = -1
            Me.radGroupBoxEnglish.HeaderImageKey = ""
            Me.radGroupBoxEnglish.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBoxEnglish.HeaderText = "Choose language:"
            Me.radGroupBoxEnglish.Location = New System.Drawing.Point(10, 37)
            Me.radGroupBoxEnglish.Name = "radGroupBoxEnglish"
            Me.radGroupBoxEnglish.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            '
            '
            '
            Me.radGroupBoxEnglish.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBoxEnglish.Size = New System.Drawing.Size(180, 96)
            Me.radGroupBoxEnglish.TabIndex = 1
            Me.radGroupBoxEnglish.Text = "Choose language:"
            '
            'radRadioButtonGerman
            '
            Me.radRadioButtonGerman.Location = New System.Drawing.Point(13, 65)
            Me.radRadioButtonGerman.Name = "radRadioButtonGerman"
            Me.radRadioButtonGerman.Size = New System.Drawing.Size(110, 18)
            Me.radRadioButtonGerman.TabIndex = 1
            Me.radRadioButtonGerman.Text = "German"
            Me.radRadioButtonGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radRadioButtonEnglish
            '
            Me.radRadioButtonEnglish.Location = New System.Drawing.Point(13, 41)
            Me.radRadioButtonEnglish.Name = "radRadioButtonEnglish"
            Me.radRadioButtonEnglish.Size = New System.Drawing.Size(110, 18)
            Me.radRadioButtonEnglish.TabIndex = 0
            Me.radRadioButtonEnglish.Text = "English"
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
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxEnglish, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxEnglish.ResumeLayout(False)
            CType(Me.radRadioButtonGerman, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonEnglish, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radGroupBoxEnglish As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButtonGerman As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonEnglish As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace