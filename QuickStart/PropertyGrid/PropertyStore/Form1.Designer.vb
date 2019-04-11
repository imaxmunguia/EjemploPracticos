Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
	Public Partial Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
            Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar2 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar3 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar4 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radProgressBar5 = New Telerik.WinControls.UI.RadProgressBar()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.RadPanelCars = New Telerik.WinControls.UI.RadPanel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.RadPanelCars, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(855, 3)
            Me.settingsPanel.Size = New System.Drawing.Size(147, 216)
            '
            'radPropertyGrid1
            '
            Me.radPropertyGrid1.Location = New System.Drawing.Point(382, 3)
            Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.Size = New System.Drawing.Size(376, 462)
            Me.radPropertyGrid1.TabIndex = 0
            Me.radPropertyGrid1.Text = "radPropertyGrid1"
            '
            'radProgressBar1
            '
            Me.radProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar1.ImageIndex = -1
            Me.radProgressBar1.ImageKey = ""
            Me.radProgressBar1.ImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar1.Location = New System.Drawing.Point(5, 59)
            Me.radProgressBar1.Name = "radProgressBar1"
            Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBar1.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBar1.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBar1.ShowProgressIndicators = True
            Me.radProgressBar1.Size = New System.Drawing.Size(363, 23)
            Me.radProgressBar1.TabIndex = 2
            Me.radProgressBar1.Text = "0 %"
            '
            'radProgressBar2
            '
            Me.radProgressBar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar2.ImageIndex = -1
            Me.radProgressBar2.ImageKey = ""
            Me.radProgressBar2.ImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar2.Location = New System.Drawing.Point(5, 112)
            Me.radProgressBar2.Name = "radProgressBar2"
            Me.radProgressBar2.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBar2.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBar2.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBar2.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBar2.ShowProgressIndicators = True
            Me.radProgressBar2.Size = New System.Drawing.Size(363, 23)
            Me.radProgressBar2.TabIndex = 2
            Me.radProgressBar2.Text = "0 %"
            '
            'radProgressBar3
            '
            Me.radProgressBar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar3.ImageIndex = -1
            Me.radProgressBar3.ImageKey = ""
            Me.radProgressBar3.ImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar3.Location = New System.Drawing.Point(5, 165)
            Me.radProgressBar3.Name = "radProgressBar3"
            Me.radProgressBar3.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBar3.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBar3.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBar3.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBar3.ShowProgressIndicators = True
            Me.radProgressBar3.Size = New System.Drawing.Size(363, 23)
            Me.radProgressBar3.TabIndex = 2
            Me.radProgressBar3.Text = "0 %"
            '
            'radProgressBar4
            '
            Me.radProgressBar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar4.ImageIndex = -1
            Me.radProgressBar4.ImageKey = ""
            Me.radProgressBar4.ImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar4.Location = New System.Drawing.Point(5, 218)
            Me.radProgressBar4.Name = "radProgressBar4"
            Me.radProgressBar4.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBar4.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBar4.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBar4.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBar4.ShowProgressIndicators = True
            Me.radProgressBar4.Size = New System.Drawing.Size(363, 23)
            Me.radProgressBar4.TabIndex = 2
            Me.radProgressBar4.Text = "0 %"
            '
            'radProgressBar5
            '
            Me.radProgressBar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar5.ImageIndex = -1
            Me.radProgressBar5.ImageKey = ""
            Me.radProgressBar5.ImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBar5.Location = New System.Drawing.Point(5, 271)
            Me.radProgressBar5.Name = "radProgressBar5"
            Me.radProgressBar5.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBar5.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBar5.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBar5.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBar5.ShowProgressIndicators = True
            Me.radProgressBar5.Size = New System.Drawing.Size(363, 23)
            Me.radProgressBar5.TabIndex = 2
            Me.radProgressBar5.Text = "0 %"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.BackColor = System.Drawing.Color.White
            Me.radGroupBox1.Controls.Add(Me.RadPanelCars)
            Me.radGroupBox1.Controls.Add(Me.radLabel5)
            Me.radGroupBox1.Controls.Add(Me.radLabel4)
            Me.radGroupBox1.Controls.Add(Me.radLabel3)
            Me.radGroupBox1.Controls.Add(Me.radLabel2)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radProgressBar1)
            Me.radGroupBox1.Controls.Add(Me.radProgressBar5)
            Me.radGroupBox1.Controls.Add(Me.radProgressBar2)
            Me.radGroupBox1.Controls.Add(Me.radProgressBar4)
            Me.radGroupBox1.Controls.Add(Me.radProgressBar3)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Championship requirements met"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            '
            '
            '
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(373, 462)
            Me.radGroupBox1.TabIndex = 3
            Me.radGroupBox1.Text = "Championship requirements met"
            '
            'RadPanelCars
            '
            Me.RadPanelCars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RadPanelCars.BackgroundImage = Global.My.Resources.Resources.propertyStoreCars
            Me.RadPanelCars.Location = New System.Drawing.Point(5, 300)
            Me.RadPanelCars.Name = "RadPanelCars"
            Me.RadPanelCars.Size = New System.Drawing.Size(363, 157)
            Me.RadPanelCars.TabIndex = 4
            '
            'radLabel5
            '
            Me.radLabel5.Location = New System.Drawing.Point(5, 247)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(58, 18)
            Me.radLabel5.TabIndex = 3
            Me.radLabel5.Text = "Superstars"
            '
            'radLabel4
            '
            Me.radLabel4.Location = New System.Drawing.Point(5, 194)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(166, 18)
            Me.radLabel4.TabIndex = 3
            Me.radLabel4.Text = "Deutsche Tourenwagen Masters"
            '
            'radLabel3
            '
            Me.radLabel3.Location = New System.Drawing.Point(5, 141)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(174, 18)
            Me.radLabel3.TabIndex = 3
            Me.radLabel3.Text = "World Touring Car Championship"
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(5, 88)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(56, 18)
            Me.radLabel2.TabIndex = 3
            Me.radLabel2.Text = "Formula 1"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(5, 35)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(138, 18)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Text = "World Rally Championship"
            '
            'radPanel1
            '
            Me.radPanel1.Controls.Add(Me.radGroupBox1)
            Me.radPanel1.Controls.Add(Me.radPropertyGrid1)
            Me.radPanel1.Location = New System.Drawing.Point(31, 27)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(762, 470)
            Me.radPanel1.TabIndex = 4
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1005, 790)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.RadPanelCars, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
        Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar2 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar3 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar4 As Telerik.WinControls.UI.RadProgressBar
        Private radProgressBar5 As Telerik.WinControls.UI.RadProgressBar
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private WithEvents RadPanelCars As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace
