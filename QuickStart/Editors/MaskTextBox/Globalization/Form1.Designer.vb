Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.Globalization
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
			Me.radMaskedEditDateTime = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.radLblCulture = New Telerik.WinControls.UI.RadLabel()
			Me.radComboCultures = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLblFullDateTime = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblCulture, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboCultures, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblFullDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(665, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 788)
			' 
			' radMaskedEditDateTime
			' 
			Me.radMaskedEditDateTime.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radMaskedEditDateTime.BackColor = System.Drawing.Color.Transparent
			Me.radMaskedEditDateTime.Culture = Nothing
			Me.radMaskedEditDateTime.ForeColor = System.Drawing.Color.Black
			Me.radMaskedEditDateTime.Location = New System.Drawing.Point(374, 410)
			Me.radMaskedEditDateTime.Mask = "F"
			Me.radMaskedEditDateTime.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditDateTime.Name = "radMaskedEditDateTime"
			Me.radMaskedEditDateTime.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			' 
			' 
			' 
			Me.radMaskedEditDateTime.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditDateTime.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMaskedEditDateTime.SelectedText = "November"
			Me.radMaskedEditDateTime.SelectionLength = 8
			Me.radMaskedEditDateTime.SelectionStart = 10
			Me.radMaskedEditDateTime.Size = New System.Drawing.Size(221, 20)
			Me.radMaskedEditDateTime.TabIndex = 0
			Me.radMaskedEditDateTime.Text = "Thursday, November 01, 2007 12:00:00 AM"
			Me.radMaskedEditDateTime.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
			' 
			' radLblCulture
			' 
			Me.radLblCulture.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblCulture.BackColor = System.Drawing.Color.Transparent
			Me.radLblCulture.ForeColor = System.Drawing.Color.Black
			Me.radLblCulture.Location = New System.Drawing.Point(271, 361)
			Me.radLblCulture.Name = "radLblCulture"
			' 
			' 
			' 
			Me.radLblCulture.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblCulture.Size = New System.Drawing.Size(83, 14)
			Me.radLblCulture.TabIndex = 8
			Me.radLblCulture.Text = "Choose culture:"
			' 
			' radComboCultures
			' 
			Me.radComboCultures.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radComboCultures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.radComboCultures.BackColor = System.Drawing.Color.Transparent
			Me.radComboCultures.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboCultures.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboCultures.ForeColor = System.Drawing.Color.Black
			Me.radComboCultures.Location = New System.Drawing.Point(374, 361)
			Me.radComboCultures.MaxDropDownItems = 6
			Me.radComboCultures.Name = "radComboCultures"
			' 
			' 
			' 
			Me.radComboCultures.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboCultures.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboCultures.Size = New System.Drawing.Size(221, 20)
			Me.radComboCultures.TabIndex = 7
			' 
			' radLblFullDateTime
			' 
			Me.radLblFullDateTime.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblFullDateTime.ForeColor = System.Drawing.Color.Black
			Me.radLblFullDateTime.Location = New System.Drawing.Point(273, 410)
			Me.radLblFullDateTime.Name = "radLblFullDateTime"
			' 
			' 
			' 
			Me.radLblFullDateTime.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblFullDateTime.Size = New System.Drawing.Size(81, 14)
			Me.radLblFullDateTime.TabIndex = 9
			Me.radLblFullDateTime.Text = "Full Date Time:"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radMaskedEditDateTime)
			Me.Controls.Add(Me.radLblCulture)
			Me.Controls.Add(Me.radLblFullDateTime)
			Me.Controls.Add(Me.radComboCultures)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(866, 790)
			Me.Controls.SetChildIndex(Me.radComboCultures, 0)
			Me.Controls.SetChildIndex(Me.radLblFullDateTime, 0)
			Me.Controls.SetChildIndex(Me.radLblCulture, 0)
			Me.Controls.SetChildIndex(Me.radMaskedEditDateTime, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditDateTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblCulture, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboCultures, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblFullDateTime, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMaskedEditDateTime As Telerik.WinControls.UI.RadMaskedEditBox
		Private radLblCulture As Telerik.WinControls.UI.RadLabel
		Private radComboCultures As Telerik.WinControls.UI.RadDropDownList
		Private radLblFullDateTime As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace