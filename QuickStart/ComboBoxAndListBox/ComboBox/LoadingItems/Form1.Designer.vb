Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.LoadingItems
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
			Me.radLabelElapsed = New Telerik.WinControls.UI.RadLabel()
			Me.radProgressBar = New Telerik.WinControls.UI.RadProgressBar()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radBtnLoad = New Telerik.WinControls.UI.RadButton()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupItems = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadio5000 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio2000 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio1000 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio500 = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radLabelElapsed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radGroupItems, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupItems.SuspendLayout()
			CType(Me.radRadio5000, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio2000, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio1000, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio500, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radProgressBar)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabelElapsed)
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Controls.Add(Me.radBtnLoad)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(309, 298)
			Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 190)
			Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 190)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 190)
			Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 190)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 190)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 784)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' radLabelElapsed
			' 
			Me.radLabelElapsed.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radLabelElapsed.BackColor = System.Drawing.Color.Transparent
			Me.radLabelElapsed.ForeColor = System.Drawing.Color.Black
			Me.radLabelElapsed.Location = New System.Drawing.Point(127, 84)
			Me.radLabelElapsed.Name = "radLabelElapsed"
			' 
			' 
			' 
			Me.radLabelElapsed.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabelElapsed.Size = New System.Drawing.Size(78, 14)
			Me.radLabelElapsed.TabIndex = 3
			Me.radLabelElapsed.Text = "Time elapsed: "
			' 
			' radProgressBar
			' 
			Me.radProgressBar.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radProgressBar.BackColor = System.Drawing.Color.Transparent
			Me.radProgressBar.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar.Location = New System.Drawing.Point(28, 67)
			Me.radProgressBar.Maximum = 1000
			Me.radProgressBar.Name = "radProgressBar"
			' 
			' 
			' 
			Me.radProgressBar.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar.Size = New System.Drawing.Size(306, 11)
			Me.radProgressBar.StepWidth = 20
			Me.radProgressBar.SweepAngle = 120
			Me.radProgressBar.TabIndex = 2
			Me.radProgressBar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radProgressBar.ThemeName = "Vista"
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Location = New System.Drawing.Point(28, 112)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 1
			Me.radComboDemo.ThemeName = "ControlDefault"
			' 
			' radBtnLoad
			' 
			Me.radBtnLoad.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radBtnLoad.BackColor = System.Drawing.Color.Transparent
			Me.radBtnLoad.Location = New System.Drawing.Point(105, 11)
			Me.radBtnLoad.Name = "radBtnLoad"
			' 
			' 
			' 
			Me.radBtnLoad.Size = New System.Drawing.Size(153, 38)
			Me.radBtnLoad.TabIndex = 0
			Me.radBtnLoad.Text = "Click here to load items"
'			Me.radBtnLoad.Click += New System.EventHandler(Me.radBtnLoad_Click);
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radGroupItems)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupSettings.HeaderText = " Settings "
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 175)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " Settings "
			' 
			' radGroupItems
			' 
			Me.radGroupItems.Controls.Add(Me.radRadio5000)
			Me.radGroupItems.Controls.Add(Me.radRadio2000)
			Me.radGroupItems.Controls.Add(Me.radRadio1000)
			Me.radGroupItems.Controls.Add(Me.radRadio500)
			Me.radGroupItems.FooterImageIndex = -1
			Me.radGroupItems.FooterImageKey = ""
			Me.radGroupItems.FooterText = ""
			Me.radGroupItems.ForeColor = System.Drawing.Color.Black
			Me.radGroupItems.HeaderImageIndex = -1
			Me.radGroupItems.HeaderImageKey = ""
			Me.radGroupItems.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupItems.HeaderText = " Items to add "
			Me.radGroupItems.Location = New System.Drawing.Point(24, 59)
			Me.radGroupItems.Name = "radGroupItems"
			' 
			' 
			' 
			Me.radGroupItems.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupItems.Size = New System.Drawing.Size(132, 100)
			Me.radGroupItems.TabIndex = 2
			Me.radGroupItems.Text = " Items to add "
			' 
			' radRadio5000
			' 
			Me.radRadio5000.ForeColor = System.Drawing.Color.Black
			Me.radRadio5000.Location = New System.Drawing.Point(70, 59)
			Me.radRadio5000.Name = "radRadio5000"
			Me.radRadio5000.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio5000.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio5000.Size = New System.Drawing.Size(45, 16)
			Me.radRadio5000.TabIndex = 7
			Me.radRadio5000.Text = "5000"
			' 
			' radRadio2000
			' 
			Me.radRadio2000.ForeColor = System.Drawing.Color.Black
			Me.radRadio2000.Location = New System.Drawing.Point(70, 25)
			Me.radRadio2000.Name = "radRadio2000"
			Me.radRadio2000.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio2000.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio2000.Size = New System.Drawing.Size(45, 16)
			Me.radRadio2000.TabIndex = 6
			Me.radRadio2000.Text = "2000"
			' 
			' radRadio1000
			' 
			Me.radRadio1000.ForeColor = System.Drawing.Color.Black
			Me.radRadio1000.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadio1000.Location = New System.Drawing.Point(15, 59)
			Me.radRadio1000.Name = "radRadio1000"
			Me.radRadio1000.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio1000.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio1000.Size = New System.Drawing.Size(45, 16)
			Me.radRadio1000.TabIndex = 5
			Me.radRadio1000.Text = "1000"
			Me.radRadio1000.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radRadio500
			' 
			Me.radRadio500.ForeColor = System.Drawing.Color.Black
			Me.radRadio500.Location = New System.Drawing.Point(15, 25)
			Me.radRadio500.Name = "radRadio500"
			Me.radRadio500.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio500.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio500.Size = New System.Drawing.Size(39, 16)
			Me.radRadio500.TabIndex = 4
			Me.radRadio500.Text = "500"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 786)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radLabelElapsed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radGroupItems, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupItems.ResumeLayout(False)
			Me.radGroupItems.PerformLayout()
			CType(Me.radRadio5000, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio2000, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio1000, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio500, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radBtnLoad As Telerik.WinControls.UI.RadButton
		Private radLabelElapsed As Telerik.WinControls.UI.RadLabel
		Private radProgressBar As Telerik.WinControls.UI.RadProgressBar
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radGroupItems As Telerik.WinControls.UI.RadGroupBox
		Private radRadio5000 As Telerik.WinControls.UI.RadRadioButton
		Private radRadio2000 As Telerik.WinControls.UI.RadRadioButton
		Private radRadio1000 As Telerik.WinControls.UI.RadRadioButton
		Private radRadio500 As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace