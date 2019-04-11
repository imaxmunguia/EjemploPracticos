Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.DragAndDrop
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
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radListBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBox2 = New Telerik.WinControls.UI.RadListControl()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radButton7 = New Telerik.WinControls.UI.RadButton()
			Me.radButton8 = New Telerik.WinControls.UI.RadButton()
			Me.radButton5 = New Telerik.WinControls.UI.RadButton()
			Me.radButton6 = New Telerik.WinControls.UI.RadButton()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radListBox1
			' 
			Me.radListBox1.FormatString = "{0}"
			Me.radListBox1.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radListBoxItem1, Me.radListBoxItem2, Me.radListBoxItem3, Me.radListBoxItem5})
			Me.radListBox1.Location = New System.Drawing.Point(45, 176)
			Me.radListBox1.Name = "radListBox1"
			' 
			' 
			' 
			Me.radListBox1.Size = New System.Drawing.Size(255, 255)
			Me.radListBox1.TabIndex = 1
			CType(Me.radListBox1.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Font = New System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			CType(Me.radListBox1.GetChildAt(0), Telerik.WinControls.UI.RadListElement).BackColor = System.Drawing.Color.White
			CType(Me.radListBox1.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Opacity = 0.8
			' 
			' radListBoxItem1
			' 
			Me.radListBoxItem1.Image = My.Resources.lb_m4
			Me.radListBoxItem1.Text = "Tuna Salad"
			Me.radListBoxItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem2
			' 
			Me.radListBoxItem2.Image = My.Resources.lb_m3
			Me.radListBoxItem2.Text = "Grilled Salmon "
			Me.radListBoxItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem3
			' 
			Me.radListBoxItem3.Image = My.Resources.lb_m2
			Me.radListBoxItem3.Text = "Sashimi Salad"
			Me.radListBoxItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem5
			' 
			Me.radListBoxItem5.Image = My.Resources.lb_m1
			Me.radListBoxItem5.Text = "Fresh Mussels"
			Me.radListBoxItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBox2
			' 
			Me.radListBox2.FormatString = "{0}"
			Me.radListBox2.Location = New System.Drawing.Point(462, 176)
			Me.radListBox2.Name = "radListBox2"
			' 
			' 
			' 
			Me.radListBox2.Size = New System.Drawing.Size(255, 255)
			Me.radListBox2.TabIndex = 2
			CType(Me.radListBox2.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Font = New System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			CType(Me.radListBox2.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Opacity = 0.8
			' 
			' radButton1
			' 
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Location = New System.Drawing.Point(327, 298)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Size = New System.Drawing.Size(99, 22)
			Me.radButton1.TabIndex = 5
			Me.radButton1.Text = "Include Selected"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.ForeColor = System.Drawing.Color.Black
			Me.radButton2.Location = New System.Drawing.Point(327, 327)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton2.Size = New System.Drawing.Size(99, 22)
			Me.radButton2.TabIndex = 6
			Me.radButton2.Text = "Exclude Selected"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radButton3
			' 
			Me.radButton3.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Location = New System.Drawing.Point(327, 356)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Size = New System.Drawing.Size(99, 22)
			Me.radButton3.TabIndex = 7
			Me.radButton3.Text = "Include All"
'			Me.radButton3.Click += New System.EventHandler(Me.radButton3_Click);
			' 
			' radButton4
			' 
			Me.radButton4.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Location = New System.Drawing.Point(327, 385)
			Me.radButton4.Name = "radButton4"
			' 
			' 
			' 
			Me.radButton4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Size = New System.Drawing.Size(99, 22)
			Me.radButton4.TabIndex = 8
			Me.radButton4.Text = "Exclude All"
'			Me.radButton4.Click += New System.EventHandler(Me.radButton4_Click);
			' 
			' radButton7
			' 
			Me.radButton7.ForeColor = System.Drawing.Color.Black
			Me.radButton7.Image = My.Resources.lb_arr_up
			Me.radButton7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton7.Location = New System.Drawing.Point(327, 191)
			Me.radButton7.Name = "radButton7"
			' 
			' 
			' 
			Me.radButton7.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton7.Size = New System.Drawing.Size(26, 25)
			Me.radButton7.TabIndex = 11
'			Me.radButton7.Click += New System.EventHandler(Me.radButton7_Click);
			' 
			' radButton8
			' 
			Me.radButton8.ForeColor = System.Drawing.Color.Black
			Me.radButton8.Image = My.Resources.lb_arr_down
			Me.radButton8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton8.Location = New System.Drawing.Point(327, 222)
			Me.radButton8.Name = "radButton8"
			' 
			' 
			' 
			Me.radButton8.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton8.Size = New System.Drawing.Size(26, 25)
			Me.radButton8.TabIndex = 12
'			Me.radButton8.Click += New System.EventHandler(Me.radButton8_Click);
			' 
			' radButton5
			' 
			Me.radButton5.ForeColor = System.Drawing.Color.Black
			Me.radButton5.Image = My.Resources.lb_arr_up
			Me.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton5.Location = New System.Drawing.Point(738, 191)
			Me.radButton5.Name = "radButton5"
			' 
			' 
			' 
			Me.radButton5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton5.Size = New System.Drawing.Size(26, 25)
			Me.radButton5.TabIndex = 13
'			Me.radButton5.Click += New System.EventHandler(Me.radButton5_Click);
			' 
			' radButton6
			' 
			Me.radButton6.ForeColor = System.Drawing.Color.Black
			Me.radButton6.Image = My.Resources.lb_arr_down
			Me.radButton6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton6.Location = New System.Drawing.Point(738, 222)
			Me.radButton6.Name = "radButton6"
			' 
			' 
			' 
			Me.radButton6.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton6.Size = New System.Drawing.Size(26, 25)
			Me.radButton6.TabIndex = 14
'			Me.radButton6.Click += New System.EventHandler(Me.radButton6_Click);
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(208, 169)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(811, 485)
			Me.radPanelDemoHolder.TabIndex = 15
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = My.Resources.lb_bg
			Me.radPanel1.Controls.Add(Me.radButton5)
			Me.radPanel1.Controls.Add(Me.radButton6)
			Me.radPanel1.Controls.Add(Me.radListBox1)
			Me.radPanel1.Controls.Add(Me.radListBox2)
			Me.radPanel1.Controls.Add(Me.radButton3)
			Me.radPanel1.Controls.Add(Me.radButton7)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.Controls.Add(Me.radButton8)
			Me.radPanel1.Controls.Add(Me.radButton4)
			Me.radPanel1.Controls.Add(Me.radButton2)
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(811, 485)
			Me.radPanel1.TabIndex = 15
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 820)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListBox1 As Telerik.WinControls.UI.RadListControl

		Private radListBox2 As Telerik.WinControls.UI.RadListControl
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton4 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton7 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton8 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton5 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton6 As Telerik.WinControls.UI.RadButton
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radListBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem2 As Telerik.WinControls.UI.RadListDataItem

	End Class
End Namespace
