Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
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
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radButton2
			' 
			Me.radButton2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton2.ImageList = Nothing
			Me.radButton2.Location = New System.Drawing.Point(155, 306)
			Me.radButton2.Name = "radButton2"
			' 
			' radButton2.RootElement
			' 
			Me.radButton2.RootElement.AccessibleDescription = ""
			Me.radButton2.RootElement.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton2.RootElement.KeyTip = ""
			Me.radButton2.RootElement.ToolTipText = Nothing
			Me.radButton2.Size = New System.Drawing.Size(122, 23)
			Me.radButton2.SmallImageList = Nothing
			Me.radButton2.TabIndex = 1
			Me.radButton2.Text = "Show Form"
			Me.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radComboBox1
			' 
			Me.radComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
			Me.radComboBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.ImageList = Nothing
			Me.radComboBox1.Location = New System.Drawing.Point(238, 27)
			Me.radComboBox1.MaxLength = 32767
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.NullText = ""
			' 
			' radComboBox1.RootElement
			' 
			Me.radComboBox1.RootElement.AccessibleDescription = ""
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radComboBox1.RootElement.KeyTip = ""
			Me.radComboBox1.RootElement.ToolTipText = Nothing
			Me.radComboBox1.Size = New System.Drawing.Size(177, 15)
			Me.radComboBox1.MaxDropDownItems = 6
			Me.radComboBox1.SmallImageList = Nothing
			Me.radComboBox1.TabIndex = 4
			Me.radComboBox1.TabStop = False
'			Me.radComboBox1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox1_SelectedIndexChanged);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.radButton1)
			Me.groupBox1.Location = New System.Drawing.Point(27, 99)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(388, 188)
			Me.groupBox1.TabIndex = 14
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Shape Preview"
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.ImageList = Nothing
			Me.radButton1.Location = New System.Drawing.Point(114, 55)
			Me.radButton1.Name = "radButton1"
			' 
			' radButton1.RootElement
			' 
			Me.radButton1.RootElement.AccessibleDescription = ""
			Me.radButton1.RootElement.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton1.RootElement.KeyTip = ""
			Me.radButton1.RootElement.ToolTipText = Nothing
			Me.radButton1.Size = New System.Drawing.Size(160, 78)
			Me.radButton1.SmallImageList = Nothing
			Me.radButton1.TabIndex = 0
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radButton1.ThemeName = "Sample"
			' 
			' radButton3
			' 
			Me.radButton3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton3.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton3.ImageList = Nothing
			Me.radButton3.Location = New System.Drawing.Point(237, 53)
			Me.radButton3.Name = "radButton3"
			' 
			' radButton3.RootElement
			' 
			Me.radButton3.RootElement.AccessibleDescription = ""
			Me.radButton3.RootElement.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton3.RootElement.KeyTip = ""
			Me.radButton3.RootElement.ToolTipText = Nothing
			Me.radButton3.Size = New System.Drawing.Size(177, 23)
			Me.radButton3.SmallImageList = Nothing
			Me.radButton3.TabIndex = 18
			Me.radButton3.Text = "Edit Custom Shape"
			Me.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.radButton3.Click += New System.EventHandler(Me.radButton3_Click);
			' 
			' radioButton2
			' 
			Me.radioButton2.AutoSize = True
			Me.radioButton2.Location = New System.Drawing.Point(26, 59)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(113, 17)
			Me.radioButton2.TabIndex = 17
			Me.radioButton2.Text = "Use custom shape"
			Me.radioButton2.UseVisualStyleBackColor = True
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.radioButton2_CheckedChanged);
			' 
			' radioButton1
			' 
			Me.radioButton1.AutoSize = True
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(26, 27)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(129, 17)
			Me.radioButton1.TabIndex = 16
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Use predefined shape"
			Me.radioButton1.UseVisualStyleBackColor = True
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radButton3)
			Me.Controls.Add(Me.radioButton2)
			Me.Controls.Add(Me.radioButton1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.radComboBox1)
			Me.Controls.Add(Me.radButton2)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(901, 811)
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
	End Class
End Namespace