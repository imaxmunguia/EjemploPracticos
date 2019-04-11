Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.StripView.Settings
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
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.stripAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.itemAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.fitModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.sizeModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.orientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.spacingSpin = New Telerik.WinControls.UI.RadSpinEditor()
			Me.addPageButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.itemAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			Me.radPageViewPage2.SuspendLayout()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.fitModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sizeModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spacingSpin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addPageButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.addPageButton)
			Me.settingsPanel.Controls.Add(Me.spacingSpin)
			Me.settingsPanel.Controls.Add(Me.radLabel6)
			Me.settingsPanel.Controls.Add(Me.orientationCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel5)
			Me.settingsPanel.Controls.Add(Me.sizeModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel4)
			Me.settingsPanel.Controls.Add(Me.fitModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.itemAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.stripAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New System.Drawing.Point(1002, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 524)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.stripAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.itemAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.fitModeCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel4, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.sizeModeCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel5, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.orientationCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel6, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.spacingSpin, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.addPageButton, 0)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(86, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Strip Alignment:"
			' 
			' stripAlignCombo
			' 
			Me.stripAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.stripAlignCombo.Location = New System.Drawing.Point(10, 59)
			Me.stripAlignCombo.Name = "stripAlignCombo"
			' 
			' 
			' 
			Me.stripAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.stripAlignCombo.Size = New System.Drawing.Size(180, 20)
			Me.stripAlignCombo.TabIndex = 2
			Me.stripAlignCombo.TabStop = False
'			Me.stripAlignCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.stripAlignCombo_SelectedIndexChanged);
			' 
			' itemAlignCombo
			' 
			Me.itemAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.itemAlignCombo.Location = New System.Drawing.Point(10, 107)
			Me.itemAlignCombo.Name = "itemAlignCombo"
			' 
			' 
			' 
			Me.itemAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.itemAlignCombo.Size = New System.Drawing.Size(180, 20)
			Me.itemAlignCombo.TabIndex = 4
			Me.itemAlignCombo.TabStop = False
'			Me.itemAlignCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.itemAlignCombo_SelectedIndexChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 85)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(85, 16)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Item Alignment:"
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Location = New System.Drawing.Point(290, 108)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New System.Drawing.Size(593, 328)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Location = New System.Drawing.Point(9, 33)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(574, 285)
			Me.radPageViewPage1.Text = "radPageViewPage1"
			Me.radPageViewPage1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Location = New System.Drawing.Point(9, 33)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(574, 285)
			Me.radPageViewPage2.Text = "radPageViewPage2"
			Me.radPageViewPage2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Location = New System.Drawing.Point(9, 33)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(574, 285)
			Me.radPageViewPage3.Text = "radPageViewPage3"
			Me.radPageViewPage3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' fitModeCombo
			' 
			Me.fitModeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.fitModeCombo.Location = New System.Drawing.Point(10, 155)
			Me.fitModeCombo.Name = "fitModeCombo"
			' 
			' 
			' 
			Me.fitModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.fitModeCombo.Size = New System.Drawing.Size(180, 20)
			Me.fitModeCombo.TabIndex = 6
			Me.fitModeCombo.TabStop = False
'			Me.fitModeCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.fitModeCombo_SelectedIndexChanged);
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(10, 133)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(78, 16)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "Item Fit Mode:"
			' 
			' sizeModeCombo
			' 
			Me.sizeModeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.sizeModeCombo.Location = New System.Drawing.Point(10, 203)
			Me.sizeModeCombo.Name = "sizeModeCombo"
			' 
			' 
			' 
			Me.sizeModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.sizeModeCombo.Size = New System.Drawing.Size(180, 20)
			Me.sizeModeCombo.TabIndex = 8
			Me.sizeModeCombo.TabStop = False
'			Me.sizeModeCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.sizeModeCombo_SelectedIndexChanged);
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel4.Location = New System.Drawing.Point(10, 181)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(88, 16)
			Me.radLabel4.TabIndex = 7
			Me.radLabel4.Text = "Item Size Mode:"
			' 
			' orientationCombo
			' 
			Me.orientationCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.orientationCombo.Location = New System.Drawing.Point(10, 251)
			Me.orientationCombo.Name = "orientationCombo"
			' 
			' 
			' 
			Me.orientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.orientationCombo.Size = New System.Drawing.Size(180, 20)
			Me.orientationCombo.TabIndex = 10
			Me.orientationCombo.TabStop = False
'			Me.orientationCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.orientationCombo_SelectedIndexChanged);
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel5.Location = New System.Drawing.Point(10, 229)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(133, 16)
			Me.radLabel5.TabIndex = 9
			Me.radLabel5.Text = "Item Content Orientation:"
			' 
			' radLabel6
			' 
			Me.radLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel6.Location = New System.Drawing.Point(10, 277)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(75, 16)
			Me.radLabel6.TabIndex = 11
			Me.radLabel6.Text = "Item Spacing:"
			' 
			' spacingSpin
			' 
			Me.spacingSpin.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.spacingSpin.Location = New System.Drawing.Point(10, 299)
			Me.spacingSpin.Name = "spacingSpin"
			' 
			' 
			' 
			Me.spacingSpin.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spacingSpin.ShowBorder = True
			Me.spacingSpin.Size = New System.Drawing.Size(180, 20)
			Me.spacingSpin.TabIndex = 12
			Me.spacingSpin.TabStop = False
'			Me.spacingSpin.ValueChanged += New System.EventHandler(Me.spacingSpin_ValueChanged);
			' 
			' addPageButton
			' 
			Me.addPageButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.addPageButton.Location = New System.Drawing.Point(10, 373)
			Me.addPageButton.Name = "addPageButton"
			Me.addPageButton.Size = New System.Drawing.Size(180, 24)
			Me.addPageButton.TabIndex = 13
			Me.addPageButton.Text = "Add Page"
'			Me.addPageButton.Click += New System.EventHandler(Me.addPageButton_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1203, 526)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.itemAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.fitModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sizeModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spacingSpin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addPageButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents itemAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents stripAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private WithEvents fitModeCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spacingSpin As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private WithEvents orientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private WithEvents sizeModeCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents addPageButton As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
