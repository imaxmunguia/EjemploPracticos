Namespace Telerik.Examples.WinControls.Editors.TextBoxControl
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
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
            Me.radBtnSetBackgroundImage = New Telerik.WinControls.UI.RadButton()
            Me.radTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radButtonSearch = New Telerik.WinControls.UI.RadButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radBtnSetBackgroundImage, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            DirectCast(Me.radButtonSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radBtnSetBackgroundImage)
            Me.settingsPanel.Location = New System.Drawing.Point(1073, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(69, 624)
            Me.settingsPanel.Controls.SetChildIndex(Me.radBtnSetBackgroundImage, 0)
            ' 
            ' radBtnSetBackgroundImage
            ' 
            Me.radBtnSetBackgroundImage.Location = New System.Drawing.Point(16, 20)
            Me.radBtnSetBackgroundImage.Name = "radBtnSetBackgroundImage"
            Me.radBtnSetBackgroundImage.Size = New System.Drawing.Size(155, 24)
            Me.radBtnSetBackgroundImage.TabIndex = 1
            Me.radBtnSetBackgroundImage.Text = "Set Background Image"
            ' 
            ' radTextBoxControl1
            ' 
            Me.radTextBoxControl1.Location = New System.Drawing.Point(103, 137)
            Me.radTextBoxControl1.Name = "radTextBoxControl1"
            Me.radTextBoxControl1.NullText = "Search in Bing"
            Me.radTextBoxControl1.Size = New System.Drawing.Size(372, 28)
            Me.radTextBoxControl1.TabIndex = 2
            DirectCast(Me.radTextBoxControl1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.TextBoxViewElement).BackgroundImage = My.Resources.textbox_bg
            DirectCast(Me.radTextBoxControl1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.TextBoxViewElement).Padding = New System.Windows.Forms.Padding(25, 6, 2, 0)
            DirectCast(Me.radTextBoxControl1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.TextBoxWrapPanel).Padding = New System.Windows.Forms.Padding(25, 6, 2, 0)
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.BackgroundImage = My.Resources.ballons_image
            Me.radPanel1.Controls.Add(Me.radButtonSearch)
            Me.radPanel1.Controls.Add(Me.radTextBoxControl1)
            Me.radPanel1.Location = New System.Drawing.Point(104, 79)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(602, 420)
            Me.radPanel1.TabIndex = 3
            ' 
            ' radButtonSearch
            ' 
            Me.radButtonSearch.Image = My.Resources.search
            Me.radButtonSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonSearch.Location = New System.Drawing.Point(481, 137)
            Me.radButtonSearch.Name = "radButtonSearch"
            Me.radButtonSearch.Size = New System.Drawing.Size(32, 28)
            Me.radButtonSearch.TabIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1039, 624)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radBtnSetBackgroundImage, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            DirectCast(Me.radButtonSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents radBtnSetBackgroundImage As Telerik.WinControls.UI.RadButton
        Private WithEvents radTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private WithEvents radButtonSearch As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
