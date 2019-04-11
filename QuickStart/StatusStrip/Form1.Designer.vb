Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.StatusStrip
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radStatusBar1 = New Telerik.WinControls.UI.RadStatusStrip()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radToolStripSeparatorItem3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radToolStripSeparatorItem4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
			Me.radToolStripSeparatorItem5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radToolStripSeparatorItem2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radSplitButtonElement1 = New Telerik.WinControls.UI.RadSplitButtonElement()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radToolStripSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radStatusBar1
			' 
			Me.radStatusBar1.AutoSize = True
			Me.radStatusBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radToolStripSeparatorItem3, Me.radLabelElement3, Me.radToolStripSeparatorItem4, Me.radLabelElement2, Me.radProgressBarElement1, Me.radToolStripSeparatorItem5, Me.radCheckBoxElement1, Me.radLabelElement1, Me.radToolStripSeparatorItem2, Me.radSplitButtonElement1, Me.radToolStripSeparatorItem1})
			Me.radStatusBar1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
			Me.radStatusBar1.Location = New System.Drawing.Point(0, 218)
			Me.radStatusBar1.Margin = New System.Windows.Forms.Padding(5)
			Me.radStatusBar1.Name = "radStatusBar1"
			Me.radStatusBar1.Size = New System.Drawing.Size(631, 25)
			Me.radStatusBar1.SizingGrip = True
			Me.radStatusBar1.TabIndex = 0
			Me.radStatusBar1.Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New System.Windows.Forms.Padding(2)
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New System.Drawing.Size(0, 19)
			CType(Me.radStatusBar1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.StatusBarBoxLayout).Margin = New System.Windows.Forms.Padding(0, 0, 14, 0)
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radButtonElement1, False)
			Me.radButtonElement1.Text = "Page 1 of 1"
'			Me.radButtonElement1.Click += New System.EventHandler(Me.radButtonElement1_Click);
			' 
			' radToolStripSeparatorItem3
			' 
			Me.radToolStripSeparatorItem3.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem3.MinSize = New System.Drawing.Size(2, 17)
			Me.radToolStripSeparatorItem3.Name = "radToolStripSeparatorItem3"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem3, False)
			Me.radToolStripSeparatorItem3.Text = "radToolStripSeparatorItem3"
			' 
			' radLabelElement3
			' 
			Me.radLabelElement3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(165))))))
			Me.radLabelElement3.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement3.Name = "radLabelElement3"
			Me.radStatusBar1.SetSpring(Me.radLabelElement3, False)
			Me.radLabelElement3.Text = "Words: 2"
			' 
			' radToolStripSeparatorItem4
			' 
			Me.radToolStripSeparatorItem4.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem4.MinSize = New System.Drawing.Size(2, 17)
			Me.radToolStripSeparatorItem4.Name = "radToolStripSeparatorItem4"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem4, False)
			Me.radToolStripSeparatorItem4.Text = "radToolStripSeparatorItem4"
			' 
			' radLabelElement2
			' 
			Me.radLabelElement2.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement2.Name = "radLabelElement2"
			Me.radStatusBar1.SetSpring(Me.radLabelElement2, False)
			Me.radLabelElement2.Text = "Saving..."
			' 
			' radProgressBarElement1
			' 
			Me.radProgressBarElement1.AutoSize = False
			Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 133, 16)
			Me.radProgressBarElement1.ClipDrawing = True
			Me.radProgressBarElement1.DefaultSize = New System.Drawing.Size(130, 16)
			Me.radProgressBarElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radProgressBarElement1.Name = "radProgressBarElement1"
			Me.radStatusBar1.SetSpring(Me.radProgressBarElement1, False)
			Me.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radToolStripSeparatorItem5
			' 
			Me.radToolStripSeparatorItem5.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem5.MinSize = New System.Drawing.Size(2, 17)
			Me.radToolStripSeparatorItem5.Name = "radToolStripSeparatorItem5"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem5, False)
			Me.radToolStripSeparatorItem5.Text = "radToolStripSeparatorItem5"
			' 
			' radCheckBoxElement1
			' 
			Me.radCheckBoxElement1.CanFocus = True
			Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radCheckBoxElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
			Me.radCheckBoxElement1.ShowBorder = False
			Me.radStatusBar1.SetSpring(Me.radCheckBoxElement1, False)
			Me.radCheckBoxElement1.Text = "Check for errors"
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radStatusBar1.SetSpring(Me.radLabelElement1, False)
			Me.radLabelElement1.Text = "English (US)"
			' 
			' radToolStripSeparatorItem2
			' 
			Me.radToolStripSeparatorItem2.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem2.MinSize = New System.Drawing.Size(2, 17)
			Me.radToolStripSeparatorItem2.Name = "radToolStripSeparatorItem2"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem2, False)
			Me.radToolStripSeparatorItem2.Text = "radToolStripSeparatorItem2"
			' 
			' radSplitButtonElement1
			' 
			Me.radSplitButtonElement1.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radSplitButtonElement1.DefaultItem = Nothing
			Me.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radSplitButtonElement1.ExpandArrowButton = False
			Me.radSplitButtonElement1.HasTwoColumnDropDown = False
			Me.radSplitButtonElement1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem9, Me.radMenuItem10})
			Me.radSplitButtonElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radSplitButtonElement1.Name = "radSplitButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radSplitButtonElement1, False)
			Me.radSplitButtonElement1.Text = "Zoom"
			Me.radSplitButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "50%"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "75%"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "100%"
			Me.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "200%"
			Me.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radToolStripSeparatorItem1
			' 
			Me.radToolStripSeparatorItem1.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem1.MinSize = New System.Drawing.Size(2, 17)
			Me.radToolStripSeparatorItem1.Name = "radToolStripSeparatorItem1"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem1, False)
			Me.radToolStripSeparatorItem1.Text = "radToolStripSeparatorItem1"
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "radMenuItem3"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "radMenuItem4"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "radMenuItem5"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "radMenuItem6"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' radTitleBar1
			' 
			Me.radTitleBar1.Text = "RadStatusStrip Example"
			Me.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radTitleBar1.Location = New System.Drawing.Point(0, 0)
			Me.radTitleBar1.Name = "radTitleBar1"
			Me.radTitleBar1.Size = New System.Drawing.Size(631, 23)
			Me.radTitleBar1.TabIndex = 1
			Me.radTitleBar1.TabStop = False
			Me.radTitleBar1.Text = "RadStatusStrip"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Text = "RadStatusStrip Example"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.TopCenter
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radLabel1.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.radLabel1.Location = New System.Drawing.Point(0, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
			' 
			' 
			' 
			Me.radLabel1.RootElement.StretchHorizontally = True
			Me.radLabel1.RootElement.StretchVertically = True
			Me.radLabel1.Size = New System.Drawing.Size(631, 195)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = resources.GetString("radLabel1.Text")
			Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.SystemColors.ButtonShadow
			Me.ClientSize = New System.Drawing.Size(631, 243)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radTitleBar1)
			Me.Controls.Add(Me.radStatusBar1)
			Me.Name = "Form1"
			Me.Shape = Me.roundRectShape1
			Me.Text = "RadStatusStrip Example"
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radStatusBar1 As Telerik.WinControls.UI.RadStatusStrip
		Private WithEvents radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
		Private radToolStripSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radToolStripSeparatorItem2 As Telerik.WinControls.UI.CommandBarSeparator
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private radSplitButtonElement1 As Telerik.WinControls.UI.RadSplitButtonElement
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
	End Class
End Namespace