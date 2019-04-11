Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.StackView.FirstLook
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
			Me.pageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioContentAfterSelected = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioContentWithSelected = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioStandard = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioPositionRight = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionLeft = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionBottom = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioPositionTop = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.showFooterCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.showHeaderCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.pageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radioContentAfterSelected, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioContentWithSelected, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioStandard, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radioPositionRight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioPositionTop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.showFooterCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showHeaderCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Location = New System.Drawing.Point(705, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 742)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' pageView1
			' 
			Me.pageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.pageView1.Controls.Add(Me.radPageViewPage1)
			Me.pageView1.Controls.Add(Me.radPageViewPage2)
			Me.pageView1.Controls.Add(Me.radPageViewPage3)
			Me.pageView1.Location = New System.Drawing.Point(288, 158)
			Me.pageView1.Name = "pageView1"
			Me.pageView1.SelectedPage = Me.radPageViewPage1
			Me.pageView1.Size = New System.Drawing.Size(331, 429)
			Me.pageView1.TabIndex = 1
			Me.pageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radLabel1)
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 29)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(321, 303)
			Me.radPageViewPage1.Text = "Selection Settings"
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel1.Location = New System.Drawing.Point(0, 0)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel1.Size = New System.Drawing.Size(321, 303)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = resources.GetString("radLabel1.Text")
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radLabel2)
			Me.radPageViewPage2.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(321, 304)
			Me.radPageViewPage2.Text = "Stack Position Settings"
			' 
			' radLabel2
			' 
			Me.radLabel2.AutoSize = False
			Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel2.Location = New System.Drawing.Point(0, 0)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel2.Size = New System.Drawing.Size(321, 304)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = resources.GetString("radLabel2.Text")
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radLabel3)
			Me.radPageViewPage3.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(321, 304)
			Me.radPageViewPage3.Text = "Layout Settings"
			' 
			' radLabel3
			' 
			Me.radLabel3.AutoSize = False
			Me.radLabel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel3.Location = New System.Drawing.Point(0, 0)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(32))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(137))))))
			Me.radLabel3.Size = New System.Drawing.Size(321, 304)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = resources.GetString("radLabel3.Text")
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radioContentAfterSelected)
			Me.radGroupBox1.Controls.Add(Me.radioContentWithSelected)
			Me.radGroupBox1.Controls.Add(Me.radioStandard)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Selection Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 43)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 121)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Selection Settings"
			' 
			' radioContentAfterSelected
			' 
			Me.radioContentAfterSelected.AutoSize = True
			Me.radioContentAfterSelected.Location = New System.Drawing.Point(27, 85)
			Me.radioContentAfterSelected.Name = "radioContentAfterSelected"
			Me.radioContentAfterSelected.Size = New System.Drawing.Size(127, 18)
			Me.radioContentAfterSelected.TabIndex = 0
			Me.radioContentAfterSelected.Text = "ContentAfterSelected"
'			Me.radioContentAfterSelected.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSelectionSetting_ToggleStateChanged);
			' 
			' radioContentWithSelected
			' 
			Me.radioContentWithSelected.AutoSize = True
			Me.radioContentWithSelected.Location = New System.Drawing.Point(27, 61)
			Me.radioContentWithSelected.Name = "radioContentWithSelected"
			Me.radioContentWithSelected.Size = New System.Drawing.Size(126, 18)
			Me.radioContentWithSelected.TabIndex = 0
			Me.radioContentWithSelected.Text = "ContentWithSelected"
'			Me.radioContentWithSelected.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSelectionSetting_ToggleStateChanged);
			' 
			' radioStandard
			' 
			Me.radioStandard.AutoSize = True
			Me.radioStandard.Location = New System.Drawing.Point(27, 37)
			Me.radioStandard.Name = "radioStandard"
			Me.radioStandard.Size = New System.Drawing.Size(65, 18)
			Me.radioStandard.TabIndex = 0
			Me.radioStandard.Text = "Standard"
'			Me.radioStandard.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioSelectionSetting_ToggleStateChanged);
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radioPositionRight)
			Me.radGroupBox2.Controls.Add(Me.radioPositionLeft)
			Me.radGroupBox2.Controls.Add(Me.radioPositionBottom)
			Me.radGroupBox2.Controls.Add(Me.radioPositionTop)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Stack Position"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 170)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 144)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Stack Position"
			' 
			' radioPositionRight
			' 
			Me.radioPositionRight.AutoSize = True
			Me.radioPositionRight.Location = New System.Drawing.Point(27, 106)
			Me.radioPositionRight.Name = "radioPositionRight"
			Me.radioPositionRight.Size = New System.Drawing.Size(47, 18)
			Me.radioPositionRight.TabIndex = 0
			Me.radioPositionRight.Text = "Right"
'			Me.radioPositionRight.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioStackPositionSetting_ToggleStateChanged);
			' 
			' radioPositionLeft
			' 
			Me.radioPositionLeft.AutoSize = True
			Me.radioPositionLeft.Location = New System.Drawing.Point(27, 82)
			Me.radioPositionLeft.Name = "radioPositionLeft"
			Me.radioPositionLeft.Size = New System.Drawing.Size(39, 18)
			Me.radioPositionLeft.TabIndex = 0
			Me.radioPositionLeft.Text = "Left"
'			Me.radioPositionLeft.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioStackPositionSetting_ToggleStateChanged);
			' 
			' radioPositionBottom
			' 
			Me.radioPositionBottom.AutoSize = True
			Me.radioPositionBottom.Location = New System.Drawing.Point(27, 34)
			Me.radioPositionBottom.Name = "radioPositionBottom"
			Me.radioPositionBottom.Size = New System.Drawing.Size(57, 18)
			Me.radioPositionBottom.TabIndex = 0
			Me.radioPositionBottom.Text = "Bottom"
'			Me.radioPositionBottom.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioStackPositionSetting_ToggleStateChanged);
			' 
			' radioPositionTop
			' 
			Me.radioPositionTop.AutoSize = True
			Me.radioPositionTop.Location = New System.Drawing.Point(27, 58)
			Me.radioPositionTop.Name = "radioPositionTop"
			Me.radioPositionTop.Size = New System.Drawing.Size(39, 18)
			Me.radioPositionTop.TabIndex = 0
			Me.radioPositionTop.Text = "Top"
'			Me.radioPositionTop.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioStackPositionSetting_ToggleStateChanged);
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.showFooterCheck)
			Me.radGroupBox3.Controls.Add(Me.showHeaderCheck)
			Me.radGroupBox3.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox3.Controls.Add(Me.radLabel4)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox3.HeaderText = "Layout Settings"
			Me.radGroupBox3.Location = New System.Drawing.Point(10, 320)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New System.Drawing.Size(180, 144)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Layout Settings"
			' 
			' showFooterCheck
			' 
			Me.showFooterCheck.Location = New System.Drawing.Point(27, 103)
			Me.showFooterCheck.Name = "showFooterCheck"
			Me.showFooterCheck.Size = New System.Drawing.Size(83, 18)
			Me.showFooterCheck.TabIndex = 2
			Me.showFooterCheck.Text = "Show Footer"
'			Me.showFooterCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnShowFooter_Checked);
			' 
			' showHeaderCheck
			' 
			Me.showHeaderCheck.Location = New System.Drawing.Point(27, 79)
			Me.showHeaderCheck.Name = "showHeaderCheck"
			Me.showHeaderCheck.Size = New System.Drawing.Size(87, 18)
			Me.showHeaderCheck.TabIndex = 2
			Me.showHeaderCheck.Text = "Show Header"
'			Me.showHeaderCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnShowHeader_Checked);
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New System.Drawing.Point(100, 41)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 10, 0, 0, -2147483648})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.ShowBorder = True
			Me.radSpinEditor1.Size = New System.Drawing.Size(67, 20)
			Me.radSpinEditor1.TabIndex = 1
			Me.radSpinEditor1.TabStop = False
'			Me.radSpinEditor1.ValueChanged += New System.EventHandler(Me.OnItemSpacing_ValueChanged);
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(13, 41)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(73, 18)
			Me.radLabel4.TabIndex = 0
			Me.radLabel4.Text = "Item spacing:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(906, 744)
			Me.Controls.SetChildIndex(Me.pageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.pageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radioContentAfterSelected, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioContentWithSelected, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioStandard, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radioPositionRight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionLeft, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioPositionTop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.showFooterCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showHeaderCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private pageView1 As Telerik.WinControls.UI.RadPageView

		#End Region
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radioContentWithSelected As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radioStandard As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radioPositionRight As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radioPositionLeft As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radioPositionBottom As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radioPositionTop As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents showFooterCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents showHeaderCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radioContentAfterSelected As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
