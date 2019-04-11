Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.SplitContainer.Layouts
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
			Me.absVerticalButton = New Telerik.WinControls.UI.RadButton()
			Me.absHorizontalButton = New Telerik.WinControls.UI.RadButton()
			Me.grixX25FillButton = New Telerik.WinControls.UI.RadButton()
			Me.rowX9 = New Telerik.WinControls.UI.RadButton()
			Me.colX9Button = New Telerik.WinControls.UI.RadButton()
			Me.gridX25Button = New Telerik.WinControls.UI.RadButton()
			Me.gridX9Button = New Telerik.WinControls.UI.RadButton()
			Me.rootContainer = New Telerik.WinControls.UI.RadSplitContainer()
			Me.minMaxButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.absVerticalButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.absHorizontalButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grixX25FillButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowX9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colX9Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridX25Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridX9Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rootContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.minMaxButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.minMaxButton)
			Me.radGroupBox1.Controls.Add(Me.absVerticalButton)
			Me.radGroupBox1.Controls.Add(Me.absHorizontalButton)
			Me.radGroupBox1.Controls.Add(Me.grixX25FillButton)
			Me.radGroupBox1.Controls.Add(Me.rowX9)
			Me.radGroupBox1.Controls.Add(Me.colX9Button)
			Me.radGroupBox1.Controls.Add(Me.gridX25Button)
			Me.radGroupBox1.Controls.Add(Me.gridX9Button)
			Me.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Layout Scenarios"
			Me.radGroupBox1.Location = New System.Drawing.Point(0, 0)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(150, 350)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Layout Scenarios"
			' 
			' absVerticalButton
			' 
			Me.absVerticalButton.AllowShowFocusCues = True
			Me.absVerticalButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.absVerticalButton.Location = New System.Drawing.Point(3, 198)
			Me.absVerticalButton.Name = "absVerticalButton"
			Me.absVerticalButton.Size = New System.Drawing.Size(144, 23)
			Me.absVerticalButton.TabIndex = 6
			Me.absVerticalButton.Text = "Absolute Size (Vertical)"
'			Me.absVerticalButton.Click += New System.EventHandler(Me.absVerticalButton_Click);
			' 
			' absHorizontalButton
			' 
			Me.absHorizontalButton.AllowShowFocusCues = True
			Me.absHorizontalButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.absHorizontalButton.Location = New System.Drawing.Point(3, 169)
			Me.absHorizontalButton.Name = "absHorizontalButton"
			Me.absHorizontalButton.Size = New System.Drawing.Size(144, 23)
			Me.absHorizontalButton.TabIndex = 5
			Me.absHorizontalButton.Text = "Absolute Size (Horizontal)"
'			Me.absHorizontalButton.Click += New System.EventHandler(Me.absHorizontalButton_Click);
			' 
			' grixX25FillButton
			' 
			Me.grixX25FillButton.AllowShowFocusCues = True
			Me.grixX25FillButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.grixX25FillButton.Location = New System.Drawing.Point(3, 140)
			Me.grixX25FillButton.Name = "grixX25FillButton"
			Me.grixX25FillButton.Size = New System.Drawing.Size(144, 23)
			Me.grixX25FillButton.TabIndex = 4
			Me.grixX25FillButton.Text = "Grid 5 * 5 Center Panel Fill"
'			Me.grixX25FillButton.Click += New System.EventHandler(Me.grixX25FillButton_Click);
			' 
			' rowX9
			' 
			Me.rowX9.AllowShowFocusCues = True
			Me.rowX9.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.rowX9.Location = New System.Drawing.Point(3, 53)
			Me.rowX9.Name = "rowX9"
			Me.rowX9.Size = New System.Drawing.Size(144, 23)
			Me.rowX9.TabIndex = 3
			Me.rowX9.Text = "9 Vertical"
'			Me.rowX9.Click += New System.EventHandler(Me.rowX9_Click);
			' 
			' colX9Button
			' 
			Me.colX9Button.AllowShowFocusCues = True
			Me.colX9Button.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.colX9Button.Location = New System.Drawing.Point(3, 24)
			Me.colX9Button.Name = "colX9Button"
			Me.colX9Button.Size = New System.Drawing.Size(144, 23)
			Me.colX9Button.TabIndex = 2
			Me.colX9Button.Text = "9 Horizontal"
'			Me.colX9Button.Click += New System.EventHandler(Me.colX9Button_Click);
			' 
			' gridX25Button
			' 
			Me.gridX25Button.AllowShowFocusCues = True
			Me.gridX25Button.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridX25Button.Location = New System.Drawing.Point(3, 111)
			Me.gridX25Button.Name = "gridX25Button"
			Me.gridX25Button.Size = New System.Drawing.Size(144, 23)
			Me.gridX25Button.TabIndex = 1
			Me.gridX25Button.Text = "Grid 5 * 5"
'			Me.gridX25Button.Click += New System.EventHandler(Me.gridX25Button_Click);
			' 
			' gridX9Button
			' 
			Me.gridX9Button.AllowShowFocusCues = True
			Me.gridX9Button.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridX9Button.Location = New System.Drawing.Point(3, 82)
			Me.gridX9Button.Name = "gridX9Button"
			Me.gridX9Button.Size = New System.Drawing.Size(144, 23)
			Me.gridX9Button.TabIndex = 0
			Me.gridX9Button.Text = "Grid 3 * 3"
'			Me.gridX9Button.Click += New System.EventHandler(Me.gridX9Button_Click);
			' 
			' rootContainer
			' 
			Me.rootContainer.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.rootContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rootContainer.Location = New System.Drawing.Point(150, 0)
			Me.rootContainer.Name = "rootContainer"
			' 
			' 
			' 
			Me.rootContainer.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.rootContainer.Size = New System.Drawing.Size(583, 350)
			Me.rootContainer.TabIndex = 1
			Me.rootContainer.TabStop = False
			Me.rootContainer.Text = "radSplitContainer1"
			' 
			' minMaxButton
			' 
			Me.minMaxButton.AllowShowFocusCues = True
			Me.minMaxButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.minMaxButton.Location = New System.Drawing.Point(3, 227)
			Me.minMaxButton.Name = "minMaxButton"
			Me.minMaxButton.Size = New System.Drawing.Size(144, 23)
			Me.minMaxButton.TabIndex = 7
			Me.minMaxButton.Text = "Minimum/Maximum Size"
'			Me.minMaxButton.Click += New System.EventHandler(Me.minMaxButton_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(733, 350)
			Me.Controls.Add(Me.rootContainer)
			Me.Controls.Add(Me.radGroupBox1)
			Me.Name = "Form1"
			Me.Text = "RadSplitContainer Layouts"
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.absVerticalButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.absHorizontalButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grixX25FillButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowX9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colX9Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridX25Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridX9Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rootContainer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.minMaxButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents rowX9 As Telerik.WinControls.UI.RadButton
		Private WithEvents colX9Button As Telerik.WinControls.UI.RadButton
		Private WithEvents gridX25Button As Telerik.WinControls.UI.RadButton
		Private WithEvents gridX9Button As Telerik.WinControls.UI.RadButton
		Private rootContainer As Telerik.WinControls.UI.RadSplitContainer
		Private WithEvents grixX25FillButton As Telerik.WinControls.UI.RadButton
		Private WithEvents absVerticalButton As Telerik.WinControls.UI.RadButton
		Private WithEvents absHorizontalButton As Telerik.WinControls.UI.RadButton
		Private WithEvents minMaxButton As Telerik.WinControls.UI.RadButton
	End Class
End Namespace