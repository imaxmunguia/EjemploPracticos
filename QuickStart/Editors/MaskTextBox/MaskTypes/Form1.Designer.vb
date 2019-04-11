Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.MaskTypes
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radMaskedEditBox5 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radMaskedEditBox6 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radMaskedEditBox4 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radMaskedEditBox3 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radMaskedEditBox2 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
            Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.radMaskedEditBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1001, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(895, 1107)
            Me.settingsPanel.ThemeName = "ControlDefault"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.radGroupBox1.Controls.Add(Me.radMaskedEditBox1)
            Me.radGroupBox1.Controls.Add(Me.radLabel6)
            Me.radGroupBox1.Controls.Add(Me.radLabel2)
            Me.radGroupBox1.Controls.Add(Me.radMaskedEditBox5)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Login Information"
            Me.radGroupBox1.Location = New System.Drawing.Point(14, 12)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            '
            '
            '
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(448, 103)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Login Information"
            '
            'radMaskedEditBox1
            '
            Me.radMaskedEditBox1.AllowPromptAsInput = False
            Me.radMaskedEditBox1.AutoSize = True
            Me.radMaskedEditBox1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox1.Location = New System.Drawing.Point(96, 30)
            Me.radMaskedEditBox1.Mask = "<>"
            Me.radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.EMail
            Me.radMaskedEditBox1.Name = "radMaskedEditBox1"
            Me.radMaskedEditBox1.Size = New System.Drawing.Size(331, 20)
            Me.radMaskedEditBox1.TabIndex = 2
            Me.radMaskedEditBox1.TabStop = False
            '
            'radLabel6
            '
            Me.radLabel6.Location = New System.Drawing.Point(7, 66)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(16, 18)
            Me.radLabel6.TabIndex = 3
            Me.radLabel6.Text = "IP"
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(6, 32)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(33, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "EMail"
            '
            'radMaskedEditBox5
            '
            Me.radMaskedEditBox5.AllowPromptAsInput = False
            Me.radMaskedEditBox5.AutoSize = True
            Me.radMaskedEditBox5.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox5.Location = New System.Drawing.Point(97, 67)
            Me.radMaskedEditBox5.Mask = "<>"
            Me.radMaskedEditBox5.MaskType = Telerik.WinControls.UI.MaskType.IP
            Me.radMaskedEditBox5.Name = "radMaskedEditBox5"
            Me.radMaskedEditBox5.Size = New System.Drawing.Size(331, 20)
            Me.radMaskedEditBox5.TabIndex = 4
            Me.radMaskedEditBox5.TabStop = False
            Me.radMaskedEditBox5.Value = "   .   .   ."
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.radGroupBox2.Controls.Add(Me.radMaskedEditBox6)
            Me.radGroupBox2.Controls.Add(Me.radLabel1)
            Me.radGroupBox2.Controls.Add(Me.radLabel5)
            Me.radGroupBox2.Controls.Add(Me.radLabel4)
            Me.radGroupBox2.Controls.Add(Me.radMaskedEditBox4)
            Me.radGroupBox2.Controls.Add(Me.radMaskedEditBox3)
            Me.radGroupBox2.Controls.Add(Me.radMaskedEditBox2)
            Me.radGroupBox2.Controls.Add(Me.radLabel3)
            Me.radGroupBox2.FooterImageIndex = -1
            Me.radGroupBox2.FooterImageKey = ""
            Me.radGroupBox2.HeaderImageIndex = -1
            Me.radGroupBox2.HeaderImageKey = ""
            Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox2.HeaderText = "Personal Information"
            Me.radGroupBox2.Location = New System.Drawing.Point(14, 138)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            '
            '
            '
            Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(448, 181)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "Personal Information"
            '
            'radMaskedEditBox6
            '
            Me.radMaskedEditBox6.AllowPromptAsInput = False
            Me.radMaskedEditBox6.AutoSize = True
            Me.radMaskedEditBox6.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox6.Location = New System.Drawing.Point(96, 140)
            Me.radMaskedEditBox6.Mask = "D"
            Me.radMaskedEditBox6.MaskType = Telerik.WinControls.UI.MaskType.DateTime
            Me.radMaskedEditBox6.Name = "radMaskedEditBox6"
            Me.radMaskedEditBox6.SelectedText = "July"
            Me.radMaskedEditBox6.SelectionLength = 4
            Me.radMaskedEditBox6.SelectionStart = 10
            Me.radMaskedEditBox6.Size = New System.Drawing.Size(330, 20)
            Me.radMaskedEditBox6.TabIndex = 5
            Me.radMaskedEditBox6.TabStop = False
            Me.radMaskedEditBox6.Value = New Date(2011, 7, 7, 16, 4, 0, 402)
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(6, 140)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(51, 18)
            Me.radLabel1.TabIndex = 4
            Me.radLabel1.Text = "Birthday "
            '
            'radLabel5
            '
            Me.radLabel5.Location = New System.Drawing.Point(6, 96)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(85, 18)
            Me.radLabel5.TabIndex = 3
            Me.radLabel5.Text = "Social Security#"
            '
            'radLabel4
            '
            Me.radLabel4.Location = New System.Drawing.Point(6, 58)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(45, 18)
            Me.radLabel4.TabIndex = 2
            Me.radLabel4.Text = "Phone#"
            '
            'radMaskedEditBox4
            '
            Me.radMaskedEditBox4.AllowPromptAsInput = False
            Me.radMaskedEditBox4.AutoSize = True
            Me.radMaskedEditBox4.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox4.Location = New System.Drawing.Point(96, 97)
            Me.radMaskedEditBox4.Mask = "000-00-0000"
            Me.radMaskedEditBox4.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.radMaskedEditBox4.Name = "radMaskedEditBox4"
            Me.radMaskedEditBox4.Size = New System.Drawing.Size(331, 20)
            Me.radMaskedEditBox4.TabIndex = 3
            Me.radMaskedEditBox4.TabStop = False
            Me.radMaskedEditBox4.Value = "___-__-____"
            '
            'radMaskedEditBox3
            '
            Me.radMaskedEditBox3.AllowPromptAsInput = False
            Me.radMaskedEditBox3.AutoSize = True
            Me.radMaskedEditBox3.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox3.Location = New System.Drawing.Point(96, 59)
            Me.radMaskedEditBox3.Mask = "(999) 000-0000"
            Me.radMaskedEditBox3.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.radMaskedEditBox3.Name = "radMaskedEditBox3"
            Me.radMaskedEditBox3.Size = New System.Drawing.Size(331, 20)
            Me.radMaskedEditBox3.TabIndex = 2
            Me.radMaskedEditBox3.TabStop = False
            Me.radMaskedEditBox3.Value = "(___) ___-____"
            '
            'radMaskedEditBox2
            '
            Me.radMaskedEditBox2.AllowPromptAsInput = False
            Me.radMaskedEditBox2.AutoSize = True
            Me.radMaskedEditBox2.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radMaskedEditBox2.Location = New System.Drawing.Point(96, 20)
            Me.radMaskedEditBox2.Mask = "LLLLLLLLLLLLLLLLLLLLLLLL"
            Me.radMaskedEditBox2.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.radMaskedEditBox2.Name = "radMaskedEditBox2"
            Me.radMaskedEditBox2.Size = New System.Drawing.Size(331, 20)
            Me.radMaskedEditBox2.TabIndex = 1
            Me.radMaskedEditBox2.TabStop = False
            Me.radMaskedEditBox2.Value = "________________________"
            '
            'radLabel3
            '
            Me.radLabel3.Location = New System.Drawing.Point(6, 22)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(36, 18)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "Name"
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radGroupBox1)
            Me.radPanelDemoHolder.Controls.Add(Me.radGroupBox2)
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(15, 17)
            Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(492, 372)
            Me.radPanelDemoHolder.TabIndex = 3
            CType(Me.radPanelDemoHolder.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = ""
            CType(Me.radPanelDemoHolder.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3!
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.01!
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(254, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanelDemoHolder)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1202, 749)
            Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.radMaskedEditBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radMaskedEditBox2 As Telerik.WinControls.UI.RadMaskedEditBox
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radMaskedEditBox3 As Telerik.WinControls.UI.RadMaskedEditBox
		Private radMaskedEditBox4 As Telerik.WinControls.UI.RadMaskedEditBox
		Private radMaskedEditBox5 As Telerik.WinControls.UI.RadMaskedEditBox
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radMaskedEditBox6 As Telerik.WinControls.UI.RadMaskedEditBox

	End Class
End Namespace
