Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.MultiColumnComboBox
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
			Me.radMultiColumnComboBox1 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckAutoFilter = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckRotate = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckRTL = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radCheckAutoFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckRotate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radMultiColumnComboBox1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(309, 343)
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
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 784)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' radMultiColumnComboBox1
			' 
			Me.radMultiColumnComboBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			' 
			' radMultiColumnComboBox1.NestedRadGridView
			' 
			Me.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.radMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(4, 1)
			' 
			' 
			' 
			Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
			Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
			Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
			Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
			Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
			Me.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
			Me.radMultiColumnComboBox1.EditorControl.ReadOnly = True
			Me.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
			Me.radMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(282, 104)
			Me.radMultiColumnComboBox1.EditorControl.TabIndex = 0
			Me.radMultiColumnComboBox1.ForeColor = System.Drawing.Color.Black
			Me.radMultiColumnComboBox1.Location = New System.Drawing.Point(28, 40)
			Me.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1"
			' 
			' 
			' 
			Me.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMultiColumnComboBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMultiColumnComboBox1.Size = New System.Drawing.Size(306, 20)
			Me.radMultiColumnComboBox1.TabIndex = 0
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Controls.Add(Me.radCheckAutoFilter)
			Me.radGroupSettings.Controls.Add(Me.radCheckRotate)
			Me.radGroupSettings.Controls.Add(Me.radCheckRTL)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSettings.HeaderText = "Settings"
			Me.radGroupSettings.Location = New System.Drawing.Point(15, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.Size = New System.Drawing.Size(162, 108)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = "Settings"
			' 
			' radCheckAutoFilter
			' 
			Me.radCheckAutoFilter.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckAutoFilter.Location = New System.Drawing.Point(13, 32)
			Me.radCheckAutoFilter.Name = "radCheckAutoFilter"
			' 
			' 
			' 
			Me.radCheckAutoFilter.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckAutoFilter.Size = New System.Drawing.Size(74, 17)
			Me.radCheckAutoFilter.TabIndex = 0
			Me.radCheckAutoFilter.Text = "Auto Filter"
'			Me.radCheckAutoFilter.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnCheckAutoFilter_ToggleStateChanged);
			' 
			' radCheckRotate
			' 
			Me.radCheckRotate.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckRotate.Location = New System.Drawing.Point(13, 55)
			Me.radCheckRotate.Name = "radCheckRotate"
			' 
			' 
			' 
			Me.radCheckRotate.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckRotate.Size = New System.Drawing.Size(141, 17)
			Me.radCheckRotate.TabIndex = 0
			Me.radCheckRotate.Text = "Rotate On Double-Click"
'			Me.radCheckRotate.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnCheckRotate_ToggleStateChanged);
			' 
			' radCheckRTL
			' 
			Me.radCheckRTL.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckRTL.Location = New System.Drawing.Point(13, 78)
			Me.radCheckRTL.Name = "radCheckRTL"
			Me.radCheckRTL.Size = New System.Drawing.Size(87, 17)
			Me.radCheckRTL.TabIndex = 0
			Me.radCheckRTL.Text = "Right To Left"
'			Me.radCheckRTL.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnCheckBoxRTL_ToggleStateChanged);
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
			CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radCheckAutoFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckRotate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMultiColumnComboBox1 As Telerik.WinControls.UI.RadMultiColumnComboBox
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckAutoFilter As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckRotate As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckRTL As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace