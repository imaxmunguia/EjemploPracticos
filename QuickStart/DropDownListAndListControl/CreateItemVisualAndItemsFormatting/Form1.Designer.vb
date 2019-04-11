Imports Microsoft.VisualBasic
Imports System

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.CreateItemVisualAndItemsFormatting
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radio_CreateCheckBox = New Telerik.WinControls.UI.RadRadioButton()
			Me.radio_CreateRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radio_CreateCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radio_CreateRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.settingsPanel.AutoScroll = True
			Me.settingsPanel.BackColor = System.Drawing.Color.Transparent
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.btnSpy)
			Me.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.settingsPanel.Location = New System.Drawing.Point(887, 1)
			Me.settingsPanel.Name = "settingsPanel"
			Me.settingsPanel.Size = New System.Drawing.Size(183, 491)
			Me.settingsPanel.TabIndex = 0
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), System.Drawing.Image))
			Me.btnSpy.Location = New System.Drawing.Point(10, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			' 
			' 
			' 
			Me.btnSpy.RootElement.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New System.Drawing.Size(163, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.btnSpy.ThemeName = "ControlDefault"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radListControl1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "ListControl"
			Me.radGroupBox1.Location = New System.Drawing.Point(198, 55)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(270, 438)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = "ListControl"
			' 
			' radListControl1
			'             
			Me.radListControl1.DisplayMember = ""
			Me.radListControl1.Location = New System.Drawing.Point(13, 23)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New System.Drawing.Size(244, 402)
			Me.radListControl1.TabIndex = 1
			Me.radListControl1.Text = "radListControl1"
			Me.radListControl1.ValueMember = ""
            AddHandler Me.radListControl1.CreatingVisualListItem, AddressOf CreatingVisualListItem

			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox4.FooterImageIndex = -1
			Me.radGroupBox4.FooterImageKey = ""
			Me.radGroupBox4.HeaderImageIndex = -1
			Me.radGroupBox4.HeaderImageKey = ""
			Me.radGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox4.HeaderText = "DropDownList"
			Me.radGroupBox4.Location = New System.Drawing.Point(535, 55)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox4.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox4.Size = New System.Drawing.Size(270, 438)
			Me.radGroupBox4.TabIndex = 9
			Me.radGroupBox4.Text = "DropDownList"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.AutoSize = True
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownHeight = 0
			Me.radDropDownList1.Location = New System.Drawing.Point(13, 23)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New System.Drawing.Size(244, 18)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.TabStop = False
            AddHandler Me.radDropDownList1.CreatingVisualListItem, AddressOf Me.CreatingVisualListItem
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radio_CreateCheckBox)
			Me.radGroupBox2.Controls.Add(Me.radio_CreateRadioButton)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Custom object type:"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 54)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(163, 100)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Custom object type:"
			' 
			' radio_CreateCheckBox
			' 
			Me.radio_CreateCheckBox.Location = New System.Drawing.Point(28, 65)
			Me.radio_CreateCheckBox.Name = "radio_CreateCheckBox"
			Me.radio_CreateCheckBox.TabIndex = 0
			Me.radio_CreateCheckBox.Text = "CheckBox"
            'Me.radio_CreateCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(Me.radio_CreateCheckBox_ToggleStateChanged);
			' 
			' radio_CreateRadioButton
			' 
			Me.radio_CreateRadioButton.Location = New System.Drawing.Point(28, 34)
			Me.radio_CreateRadioButton.Name = "radio_CreateRadioButton"
			Me.radio_CreateRadioButton.TabIndex = 0
			Me.radio_CreateRadioButton.Text = "Radio Button"
			Me.radio_CreateRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            'Me.radio_CreateRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(Me.radio_CreateRadioButton_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGroupBox1)
			Me.Controls.Add(Me.radGroupBox4)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1071, 385)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radio_CreateCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radio_CreateRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub


		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radListControl1 As Telerik.WinControls.UI.RadListControl
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radio_CreateRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private radio_CreateCheckBox As Telerik.WinControls.UI.RadRadioButton
		Private Shadows settingsPanel As Telerik.WinControls.UI.RadPanel
		Private btnSpy As Telerik.WinControls.UI.RadButton
	End Class
End Namespace