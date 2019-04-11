Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.FirstLook
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
			Me.radTxtDemo1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radTxtDemo2 = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupNull = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblNulltext = New Telerik.WinControls.UI.RadLabel()
			Me.radTxtNullText = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupMulti = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckCancel = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLblNewValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLblOldValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTxtDemo1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtDemo2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupNull, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupNull.SuspendLayout()
			CType(Me.radLblNulltext, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtNullText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupMulti, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupMulti.SuspendLayout()
			CType(Me.radCheckCancel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblNewValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblOldValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel2)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radTxtDemo2)
			Me.radPanelDemoHolder.Controls.Add(Me.radTxtDemo1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(269, 182)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(261, 208)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupMulti)
			Me.settingsPanel.Controls.Add(Me.radGroupNull)
			Me.settingsPanel.Location = New System.Drawing.Point(598, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 569)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupNull, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupMulti, 0)
			' 
			' radTxtDemo1
			' 
			Me.radTxtDemo1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radTxtDemo1.ForeColor = System.Drawing.Color.Black
			Me.radTxtDemo1.Location = New System.Drawing.Point(54, 39)
			Me.radTxtDemo1.Name = "radTxtDemo1"
			Me.radTxtDemo1.NullText = "Type here..."
			' 
			' 
			' 
			Me.radTxtDemo1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTxtDemo1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtDemo1.RootElement.ToolTipText = Nothing
			Me.radTxtDemo1.Size = New System.Drawing.Size(153, 20)
			Me.radTxtDemo1.TabIndex = 0
			' 
			' radTxtDemo2
			' 
			Me.radTxtDemo2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radTxtDemo2.ForeColor = System.Drawing.Color.Black
			Me.radTxtDemo2.Location = New System.Drawing.Point(54, 92)
			Me.radTxtDemo2.Multiline = True
			Me.radTxtDemo2.Name = "radTxtDemo2"
			Me.radTxtDemo2.NullText = "Type here..."
			' 
			' 
			' 
			Me.radTxtDemo2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtDemo2.RootElement.StretchVertically = True
			Me.radTxtDemo2.RootElement.ToolTipText = Nothing
			Me.radTxtDemo2.Size = New System.Drawing.Size(153, 94)
			Me.radTxtDemo2.TabIndex = 0
'			Me.radTxtDemo2.TextChanging += New Telerik.WinControls.TextChangingEventHandler(Me.radTextBox2_TextChanging);
			' 
			' radGroupNull
			' 
			Me.radGroupNull.Controls.Add(Me.radLblNulltext)
			Me.radGroupNull.Controls.Add(Me.radTxtNullText)
			Me.radGroupNull.FooterImageIndex = -1
			Me.radGroupNull.FooterImageKey = ""
			Me.radGroupNull.FooterText = ""
			Me.radGroupNull.ForeColor = System.Drawing.Color.Black
			Me.radGroupNull.HeaderImageIndex = -1
			Me.radGroupNull.HeaderImageKey = ""
			Me.radGroupNull.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupNull.HeaderText = " Null Text "
			Me.radGroupNull.Location = New System.Drawing.Point(15, 6)
			Me.radGroupNull.Name = "radGroupNull"
			' 
			' 
			' 
			Me.radGroupNull.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupNull.Size = New System.Drawing.Size(162, 82)
			Me.radGroupNull.TabIndex = 0
			Me.radGroupNull.Text = " Null Text "
			' 
			' radLblNulltext
			' 
			Me.radLblNulltext.AutoSize = False
			Me.radLblNulltext.ForeColor = System.Drawing.Color.Black
			Me.radLblNulltext.Location = New System.Drawing.Point(7, 24)
			Me.radLblNulltext.Name = "radLblNulltext"
			' 
			' 
			' 
			Me.radLblNulltext.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblNulltext.RootElement.StretchHorizontally = True
			Me.radLblNulltext.RootElement.StretchVertically = True
			Me.radLblNulltext.Size = New System.Drawing.Size(141, 16)
			Me.radLblNulltext.TabIndex = 1
			Me.radLblNulltext.Text = "Enter new Null Text:"
			' 
			' radTxtNullText
			' 
			Me.radTxtNullText.ForeColor = System.Drawing.Color.Black
			Me.radTxtNullText.Location = New System.Drawing.Point(7, 46)
			Me.radTxtNullText.Name = "radTxtNullText"
			' 
			' 
			' 
			Me.radTxtNullText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTxtNullText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtNullText.RootElement.ToolTipText = Nothing
			Me.radTxtNullText.Size = New System.Drawing.Size(148, 20)
			Me.radTxtNullText.TabIndex = 0
'			Me.radTxtNullText.TextChanged += New System.EventHandler(Me.radTxtNullText_TextChanged);
			' 
			' radGroupMulti
			' 
			Me.radGroupMulti.Controls.Add(Me.radCheckCancel)
			Me.radGroupMulti.Controls.Add(Me.radLblNewValue)
			Me.radGroupMulti.Controls.Add(Me.radLblOldValue)
			Me.radGroupMulti.FooterImageIndex = -1
			Me.radGroupMulti.FooterImageKey = ""
			Me.radGroupMulti.FooterText = ""
			Me.radGroupMulti.ForeColor = System.Drawing.Color.Black
			Me.radGroupMulti.HeaderImageIndex = -1
			Me.radGroupMulti.HeaderImageKey = ""
			Me.radGroupMulti.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupMulti.HeaderText = " Multiline TextBox settings"
			Me.radGroupMulti.Location = New System.Drawing.Point(15, 103)
			Me.radGroupMulti.Name = "radGroupMulti"
			' 
			' 
			' 
			Me.radGroupMulti.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupMulti.Size = New System.Drawing.Size(166, 194)
			Me.radGroupMulti.TabIndex = 1
			Me.radGroupMulti.Text = " Multiline TextBox settings"
			' 
			' radCheckCancel
			' 
			Me.radCheckCancel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckCancel.Location = New System.Drawing.Point(7, 164)
			Me.radCheckCancel.Name = "radCheckCancel"
			Me.radCheckCancel.Size = New System.Drawing.Size(108, 17)
			Me.radCheckCancel.TabIndex = 2
			Me.radCheckCancel.Text = "Cancel On Event"
			' 
			' radLblNewValue
			' 
			Me.radLblNewValue.ForeColor = System.Drawing.Color.Black
			Me.radLblNewValue.Location = New System.Drawing.Point(7, 90)
			Me.radLblNewValue.MaximumSize = New System.Drawing.Size(155, 67)
			Me.radLblNewValue.Name = "radLblNewValue"
			' 
			' 
			' 
			Me.radLblNewValue.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblNewValue.RootElement.MaxSize = New System.Drawing.Size(155, 67)
			Me.radLblNewValue.Size = New System.Drawing.Size(60, 14)
			Me.radLblNewValue.TabIndex = 1
			Me.radLblNewValue.Text = "New value:"
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "New value:"
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
			CType(Me.radLblNewValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchVertically = True
			' 
			' radLblOldValue
			' 
			Me.radLblOldValue.ForeColor = System.Drawing.Color.Black
			Me.radLblOldValue.Location = New System.Drawing.Point(7, 25)
			Me.radLblOldValue.MaximumSize = New System.Drawing.Size(155, 67)
			Me.radLblOldValue.Name = "radLblOldValue"
			' 
			' 
			' 
			Me.radLblOldValue.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblOldValue.RootElement.MaxSize = New System.Drawing.Size(155, 67)
			Me.radLblOldValue.Size = New System.Drawing.Size(55, 14)
			Me.radLblOldValue.TabIndex = 1
			Me.radLblOldValue.Text = "Old value:"
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Old value:"
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
			CType(Me.radLblOldValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchVertically = True
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(54, 17)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.RootElement.StretchHorizontally = True
			Me.radLabel1.RootElement.StretchVertically = True
			Me.radLabel1.Size = New System.Drawing.Size(153, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Single-line text box:"
			' 
			' radLabel2
			' 
			Me.radLabel2.AutoSize = False
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(54, 70)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.RootElement.StretchHorizontally = True
			Me.radLabel2.RootElement.StretchVertically = True
			Me.radLabel2.Size = New System.Drawing.Size(153, 16)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Multi-line text box:"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(799, 571)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTxtDemo1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtDemo2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupNull, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupNull.ResumeLayout(False)
			Me.radGroupNull.PerformLayout()
			CType(Me.radLblNulltext, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtNullText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupMulti, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupMulti.ResumeLayout(False)
			Me.radGroupMulti.PerformLayout()
			CType(Me.radCheckCancel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblNewValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblOldValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTxtDemo1 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radTxtDemo2 As Telerik.WinControls.UI.RadTextBox
		Private radGroupNull As Telerik.WinControls.UI.RadGroupBox
		Private radGroupMulti As Telerik.WinControls.UI.RadGroupBox
		Private radLblNewValue As Telerik.WinControls.UI.RadLabel
		Private radLblOldValue As Telerik.WinControls.UI.RadLabel
		Private radLblNulltext As Telerik.WinControls.UI.RadLabel
		Private WithEvents radTxtNullText As Telerik.WinControls.UI.RadTextBox
		Private radCheckCancel As Telerik.WinControls.UI.RadCheckBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace