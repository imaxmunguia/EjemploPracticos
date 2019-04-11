Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.DropDownAnimation
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.dropDownElement1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement10 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupAnimSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinFrames = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckEnableAnim = New Telerik.WinControls.UI.RadCheckBox()
			Me.radComboAnimType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLblFrames = New Telerik.WinControls.UI.RadLabel()
			Me.radLblDropDownAnim = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAnimSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAnimSettings.SuspendLayout()
			CType(Me.radSpinFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckEnableAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboAnimType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 218)
			Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupAnimSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupAnimSettings, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "WizardPicture.bmp")
			Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
			Me.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP")
			Me.imageList1.Images.SetKeyName(3, "test.bmp")
			Me.imageList1.Images.SetKeyName(4, "untitled.bmp")
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.ImageList = Me.imageList1
			Me.radComboDemo.Items.AddRange(New RadListDataItem() { Me.dropDownElement1, Me.dropDownElement2, Me.dropDownElement3, Me.dropDownElement4, Me.dropDownElement5, Me.dropDownElement6, Me.dropDownElement7, Me.dropDownElement8, Me.dropDownElement9, Me.dropDownElement10})
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.Name = "radComboDemo"
			Me.radComboDemo.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			Me.radComboDemo.ThemeName = "ControlDefault"
			' 
			' dropDownElement1
			' 
			Me.dropDownElement1.Text = "Amsterdam"
			' 
			' dropDownElement2
			' 
			Me.dropDownElement2.Text = "Barcelona"
			 ' 
			' dropDownElement3
			' 
			Me.dropDownElement3.Text = "Bonn"
			' 
			' dropDownElement4
			' 
			Me.dropDownElement4.Text = "Brussels"
			 ' 
			' dropDownElement5
			' 
			Me.dropDownElement5.Text = "New York"
			 ' 
			' dropDownElement6
			' 
			Me.dropDownElement6.Text = "London"
			' 
			' dropDownElement7
			' 
			Me.dropDownElement7.Text = "Paris"
			' 
			' dropDownElement8
			' 
			Me.dropDownElement8.Text = "Sofia"
			' 
			' dropDownElement9
			' 
			Me.dropDownElement9.Text = "Prague"
			' 
			' dropDownElement10
			' 
			Me.dropDownElement10.Text = "Hamburg"
			' 
			' radGroupAnimSettings
			' 
			Me.radGroupAnimSettings.Controls.Add(Me.radSpinFrames)
			Me.radGroupAnimSettings.Controls.Add(Me.radCheckEnableAnim)
			Me.radGroupAnimSettings.Controls.Add(Me.radComboAnimType)
			Me.radGroupAnimSettings.Controls.Add(Me.radLblFrames)
			Me.radGroupAnimSettings.Controls.Add(Me.radLblDropDownAnim)
			Me.radGroupAnimSettings.FooterImageIndex = -1
			Me.radGroupAnimSettings.FooterImageKey = ""
			Me.radGroupAnimSettings.FooterText = ""
			Me.radGroupAnimSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupAnimSettings.HeaderImageIndex = -1
			Me.radGroupAnimSettings.HeaderImageKey = ""
			Me.radGroupAnimSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupAnimSettings.HeaderText = " Animation settings "
			Me.radGroupAnimSettings.Location = New System.Drawing.Point(15, 6)
			Me.radGroupAnimSettings.Name = "radGroupAnimSettings"
			' 
			' 
			' 
			Me.radGroupAnimSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupAnimSettings.Size = New System.Drawing.Size(162, 156)
			Me.radGroupAnimSettings.TabIndex = 0
			Me.radGroupAnimSettings.Text = " Animation settings "
			' 
			' radSpinFrames
			' 
			Me.radSpinFrames.BackColor = System.Drawing.Color.White
			Me.radSpinFrames.ForeColor = System.Drawing.Color.Black
			Me.radSpinFrames.Location = New System.Drawing.Point(64, 119)
			Me.radSpinFrames.Name = "radSpinFrames"
			' 
			' 
			' 
			Me.radSpinFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinFrames.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinFrames.ShowBorder = True
			Me.radSpinFrames.Size = New System.Drawing.Size(80, 20)
			Me.radSpinFrames.TabIndex = 3
'			Me.radSpinFrames.ValueChanged += New System.EventHandler(Me.OnRadSpinFrames_ValueChanged);
			' 
			' radCheckEnableAnim
			' 
			Me.radCheckEnableAnim.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckEnableAnim.Location = New System.Drawing.Point(12, 39)
			Me.radCheckEnableAnim.Name = "radCheckEnableAnim"
			Me.radCheckEnableAnim.Size = New System.Drawing.Size(111, 17)
			Me.radCheckEnableAnim.TabIndex = 2
			Me.radCheckEnableAnim.Text = "Enable Animation"
'			Me.radCheckEnableAnim.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnEnableAnimation_ToggleStateChanged);
			' 
			' radComboAnimType
			' 
			Me.radComboAnimType.ForeColor = System.Drawing.Color.Black
			Me.radComboAnimType.Location = New System.Drawing.Point(12, 90)
			Me.radComboAnimType.Name = "radComboAnimType"
			' 
			' 
			' 
			Me.radComboAnimType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboAnimType.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboAnimType.Size = New System.Drawing.Size(132, 20)
			Me.radComboAnimType.TabIndex = 1
'			Me.radComboAnimType.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboAnimType_SelectedIndexChanged);
			' 
			' radLblFrames
			' 
			Me.radLblFrames.ForeColor = System.Drawing.Color.Black
			Me.radLblFrames.Location = New System.Drawing.Point(12, 121)
			Me.radLblFrames.Name = "radLblFrames"
			' 
			' 
			' 
			Me.radLblFrames.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblFrames.Size = New System.Drawing.Size(46, 14)
			Me.radLblFrames.TabIndex = 0
			Me.radLblFrames.Text = "Frames:"
			' 
			' radLblDropDownAnim
			' 
			Me.radLblDropDownAnim.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownAnim.Location = New System.Drawing.Point(12, 66)
			Me.radLblDropDownAnim.Name = "radLblDropDownAnim"
			' 
			' 
			' 
			Me.radLblDropDownAnim.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownAnim.Size = New System.Drawing.Size(82, 14)
			Me.radLblDropDownAnim.TabIndex = 0
			Me.radLblDropDownAnim.Text = "Animation type:"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 536)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAnimSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAnimSettings.ResumeLayout(False)
			Me.radGroupAnimSettings.PerformLayout()
			CType(Me.radSpinFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckEnableAnim, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboAnimType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblFrames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblDropDownAnim, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private dropDownElement1 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement2 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement3 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement4 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement5 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement6 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement7 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement8 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement9 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement10 As Telerik.WinControls.UI.RadListDataItem
		Private radGroupAnimSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblDropDownAnim As Telerik.WinControls.UI.RadLabel
		Private WithEvents radComboAnimType As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radSpinFrames As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radCheckEnableAnim As Telerik.WinControls.UI.RadCheckBox
		Private radLblFrames As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace