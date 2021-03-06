Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.CellStyle
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButtonColorGrid = New Telerik.WinControls.UI.RadButton()
			Me.radButtonRandom = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorRow = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorColumn = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radButtonBackColor = New Telerik.WinControls.UI.RadButton()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonColorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonRandom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorRow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorColumn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButtonColorGrid)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radButtonRandom)
			Me.settingsPanel.Location = New System.Drawing.Point(1052, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonRandom, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonColorGrid, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGridView1.Location = New System.Drawing.Point(384, 183)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
			Me.radGridView1.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New System.Drawing.Size(502, 494)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' radButtonColorGrid
			' 
			Me.radButtonColorGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonColorGrid.Location = New System.Drawing.Point(10, 247)
			Me.radButtonColorGrid.Name = "radButtonColorGrid"
			Me.radButtonColorGrid.Size = New System.Drawing.Size(180, 24)
			Me.radButtonColorGrid.TabIndex = 1
			Me.radButtonColorGrid.Text = "Apply Color Grid"
			Me.radButtonColorGrid.Visible = False
'			Me.radButtonColorGrid.Click += New System.EventHandler(Me.radButtonColorGrid_Click);
			' 
			' radButtonRandom
			' 
			Me.radButtonRandom.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonRandom.Location = New System.Drawing.Point(10, 277)
			Me.radButtonRandom.Name = "radButtonRandom"
			Me.radButtonRandom.Size = New System.Drawing.Size(180, 24)
			Me.radButtonRandom.TabIndex = 2
			Me.radButtonRandom.Text = "Apply Random Colors"
'			Me.radButtonRandom.Click += New System.EventHandler(Me.radButtonRandom_Click);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(13, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(30, 18)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Row:"
			' 
			' radSpinEditorRow
			' 
			Me.radSpinEditorRow.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radSpinEditorRow.Location = New System.Drawing.Point(13, 43)
			Me.radSpinEditorRow.Name = "radSpinEditorRow"
			' 
			' 
			' 
			Me.radSpinEditorRow.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorRow.ShowBorder = True
			Me.radSpinEditorRow.Size = New System.Drawing.Size(154, 21)
			Me.radSpinEditorRow.TabIndex = 4
			Me.radSpinEditorRow.TabStop = False
'			Me.radSpinEditorRow.ValueChanged += New System.EventHandler(Me.radSpinEditorRow_ValueChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(13, 70)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(48, 18)
			Me.radLabel2.TabIndex = 5
			Me.radLabel2.Text = "Column:"
			' 
			' radSpinEditorColumn
			' 
			Me.radSpinEditorColumn.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radSpinEditorColumn.Location = New System.Drawing.Point(13, 91)
			Me.radSpinEditorColumn.Name = "radSpinEditorColumn"
			' 
			' 
			' 
			Me.radSpinEditorColumn.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorColumn.ShowBorder = True
			Me.radSpinEditorColumn.Size = New System.Drawing.Size(154, 21)
			Me.radSpinEditorColumn.TabIndex = 6
			Me.radSpinEditorColumn.TabStop = False
'			Me.radSpinEditorColumn.ValueChanged += New System.EventHandler(Me.radSpinEditorColumn_ValueChanged);
			' 
			' radButtonBackColor
			' 
			Me.radButtonBackColor.Location = New System.Drawing.Point(56, 146)
			Me.radButtonBackColor.Name = "radButtonBackColor"
			Me.radButtonBackColor.Size = New System.Drawing.Size(59, 24)
			Me.radButtonBackColor.TabIndex = 7
'			Me.radButtonBackColor.Click += New System.EventHandler(Me.radButtonBackColor_Click);
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(13, 117)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(80, 18)
			Me.radLabel3.TabIndex = 8
			Me.radLabel3.Text = "Cell BackColor:"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorRow)
			Me.radGroupBox1.Controls.Add(Me.radButtonBackColor)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorColumn)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Customize cell background:"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 53)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 188)
			Me.radGroupBox1.TabIndex = 9
			Me.radGroupBox1.Text = "Customize cell background:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1253, 832)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonColorGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonRandom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorRow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorColumn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radButtonColorGrid As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonRandom As Telerik.WinControls.UI.RadButton
		Private WithEvents radSpinEditorColumn As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorRow As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radButtonBackColor As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
