Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ThemingExample
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
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
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
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(775, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 641)
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
			' radComboBox1
			' 
			Me.radComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.ForeColor = System.Drawing.Color.Black
			Me.radComboBox1.ImageList = Me.imageList1
			Me.radComboBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.dropDownElement1, Me.dropDownElement2, Me.dropDownElement3, Me.dropDownElement4, Me.dropDownElement5, Me.dropDownElement6, Me.dropDownElement7, Me.dropDownElement8, Me.dropDownElement9, Me.dropDownElement10}))
			Me.radComboBox1.Location = New System.Drawing.Point(51, 22)
			Me.radComboBox1.MaxDropDownItems = 6
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBox1.RootElement.ToolTipText = Nothing
			Me.radComboBox1.Size = New System.Drawing.Size(188, 20)
			Me.radComboBox1.TabIndex = 0
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.ThemeName = "ControlDefault"
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
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = (CType(resources.GetObject("radPanel1.BackgroundImage"), System.Drawing.Image))
			Me.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.radPanel1.Controls.Add(Me.radComboBox1)
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(16, 19)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(300, 350)
			Me.radPanel1.TabIndex = 4
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(976, 643)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
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
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace