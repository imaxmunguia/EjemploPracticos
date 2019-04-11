Namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
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
            Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
            Me.radButtonSend = New Telerik.WinControls.UI.RadButton()
            Me.radButtonTo = New Telerik.WinControls.UI.RadButton()
            Me.radButtonCc = New Telerik.WinControls.UI.RadButton()
            Me.radLabelSubject = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxControlSubject = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radAutoCompleteBox1 = New Telerik.WinControls.UI.RadAutoCompleteBox()
            Me.radAutoCompleteBox2 = New Telerik.WinControls.UI.RadAutoCompleteBox()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.radListControlRecipients = New Telerik.WinControls.UI.RadListControl()
            Me.radLabel1Recipients = New Telerik.WinControls.UI.RadLabel()
            Me.radListControlCarbonCopy = New Telerik.WinControls.UI.RadListControl()
            Me.radLabelCarbonCopy = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListAutoCompleteMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabelAutoComplete = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radButtonSend, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonTo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonCc, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabelSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBoxControlSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radAutoCompleteBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radAutoCompleteBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            DirectCast(Me.radListControlRecipients, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel1Recipients, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radListControlCarbonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabelCarbonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownListAutoCompleteMode, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabelAutoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radLabelAutoComplete)
            Me.settingsPanel.Controls.Add(Me.radDropDownListAutoCompleteMode)
            Me.settingsPanel.Controls.Add(Me.radLabelCarbonCopy)
            Me.settingsPanel.Controls.Add(Me.radLabel1Recipients)
            Me.settingsPanel.Controls.Add(Me.radListControlCarbonCopy)
            Me.settingsPanel.Controls.Add(Me.radListControlRecipients)
            Me.settingsPanel.Location = New System.Drawing.Point(1085, 19)
            Me.settingsPanel.Size = New System.Drawing.Size(0, 624)
            Me.settingsPanel.Controls.SetChildIndex(Me.radListControlRecipients, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radListControlCarbonCopy, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1Recipients, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabelCarbonCopy, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownListAutoCompleteMode, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabelAutoComplete, 0)
            ' 
            ' radButtonSend
            ' 
            Me.radButtonSend.Image = My.Resources.Resources.send_email()
            Me.radButtonSend.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radButtonSend.Location = New System.Drawing.Point(3, 3)
            Me.radButtonSend.Name = "radButtonSend"
            Me.tableLayoutPanel1.SetRowSpan(Me.radButtonSend, 3)
            Me.radButtonSend.Size = New System.Drawing.Size(59, 85)
            Me.radButtonSend.TabIndex = 1
            Me.radButtonSend.Text = "Send"
            Me.radButtonSend.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.radButtonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            ' 
            ' radButtonTo
            ' 
            Me.radButtonTo.Location = New System.Drawing.Point(68, 3)
            Me.radButtonTo.Name = "radButtonTo"
            Me.radButtonTo.Size = New System.Drawing.Size(43, 24)
            Me.radButtonTo.TabIndex = 2
            Me.radButtonTo.Text = "To..."
            ' 
            ' radButtonCc
            ' 
            Me.radButtonCc.Location = New System.Drawing.Point(68, 35)
            Me.radButtonCc.Name = "radButtonCc"
            Me.radButtonCc.Size = New System.Drawing.Size(43, 24)
            Me.radButtonCc.TabIndex = 3
            Me.radButtonCc.Text = "Cc..."
            ' 
            ' radLabelSubject
            ' 
            Me.radLabelSubject.Location = New System.Drawing.Point(68, 69)
            Me.radLabelSubject.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.radLabelSubject.Name = "radLabelSubject"
            Me.radLabelSubject.Size = New System.Drawing.Size(45, 18)
            Me.radLabelSubject.TabIndex = 4
            Me.radLabelSubject.Text = "Subject:"
            ' 
            ' radTextBoxControlSubject
            ' 
            Me.radTextBoxControlSubject.Location = New System.Drawing.Point(119, 67)
            Me.radTextBoxControlSubject.Name = "radTextBoxControlSubject"
            Me.radTextBoxControlSubject.Size = New System.Drawing.Size(563, 26)
            Me.radTextBoxControlSubject.TabIndex = 5
            Me.radTextBoxControlSubject.Text = "Re: Feedback"
            DirectCast(Me.radTextBoxControlSubject.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.TextBoxViewElement).Padding = New System.Windows.Forms.Padding(2, 5, 2, 0)
            ' 
            ' radAutoCompleteBox1
            ' 
            Me.radAutoCompleteBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radAutoCompleteBox1.AutoSize = True
            Me.radAutoCompleteBox1.Location = New System.Drawing.Point(119, 35)
            Me.radAutoCompleteBox1.MaximumSize = New System.Drawing.Size(563, 0)
            Me.radAutoCompleteBox1.MinimumSize = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox1.Multiline = True
            Me.radAutoCompleteBox1.Name = "radAutoCompleteBox1"
            ' 
            ' 
            ' 
            Me.radAutoCompleteBox1.RootElement.MaxSize = New System.Drawing.Size(563, 0)
            Me.radAutoCompleteBox1.RootElement.MinSize = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox1.RootElement.StretchHorizontally = False
            Me.radAutoCompleteBox1.RootElement.StretchVertically = False
            Me.radAutoCompleteBox1.Size = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox1.TabIndex = 6
            Me.radAutoCompleteBox1.Text = "Samuel Jackson;"
            ' 
            ' radAutoCompleteBox2
            ' 
            Me.radAutoCompleteBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radAutoCompleteBox2.AutoSize = True
            Me.radAutoCompleteBox2.Location = New System.Drawing.Point(119, 3)
            Me.radAutoCompleteBox2.MaximumSize = New System.Drawing.Size(563, 0)
            Me.radAutoCompleteBox2.MinimumSize = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox2.Multiline = True
            Me.radAutoCompleteBox2.Name = "radAutoCompleteBox2"
            ' 
            ' 
            ' 
            Me.radAutoCompleteBox2.RootElement.MaxSize = New System.Drawing.Size(563, 0)
            Me.radAutoCompleteBox2.RootElement.MinSize = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox2.RootElement.StretchHorizontally = False
            Me.radAutoCompleteBox2.RootElement.StretchVertically = False
            Me.radAutoCompleteBox2.Size = New System.Drawing.Size(563, 26)
            Me.radAutoCompleteBox2.TabIndex = 7
            Me.radAutoCompleteBox2.Text = "Joe Smith;"
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.BackColor = System.Drawing.Color.White
            Me.radPanel1.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanel1.Location = New System.Drawing.Point(14, 13)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(685, 450)
            Me.radPanel1.TabIndex = 8
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.Controls.Add(Me.radAutoCompleteBox2, 2, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonSend, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonTo, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxControlSubject, 2, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radAutoCompleteBox1, 2, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonCc, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel2, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelSubject, 1, 2)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 4
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(685, 450)
            Me.tableLayoutPanel1.TabIndex = 8
            ' 
            ' radListControlRecipients
            ' 
            Me.radListControlRecipients.CaseSensitiveSort = True
            Me.radListControlRecipients.ItemHeight = 18
            Me.radListControlRecipients.Location = New System.Drawing.Point(29, 76)
            Me.radListControlRecipients.Name = "radListControlRecipients"
            Me.radListControlRecipients.Size = New System.Drawing.Size(14, 119)
            Me.radListControlRecipients.TabIndex = 1
            Me.radListControlRecipients.Text = "Recipients List"
            ' 
            ' radLabel1Recipients
            ' 
            Me.radLabel1Recipients.Location = New System.Drawing.Point(29, 52)
            Me.radLabel1Recipients.Name = "radLabel1Recipients"
            Me.radLabel1Recipients.Size = New System.Drawing.Size(77, 18)
            Me.radLabel1Recipients.TabIndex = 2
            Me.radLabel1Recipients.Text = "Recipients List"
            ' 
            ' radListControlCarbonCopy
            ' 
            Me.radListControlCarbonCopy.CaseSensitiveSort = True
            Me.radListControlCarbonCopy.ItemHeight = 18
            Me.radListControlCarbonCopy.Location = New System.Drawing.Point(29, 225)
            Me.radListControlCarbonCopy.Name = "radListControlCarbonCopy"
            Me.radListControlCarbonCopy.Size = New System.Drawing.Size(14, 129)
            Me.radListControlCarbonCopy.TabIndex = 3
            Me.radListControlCarbonCopy.Text = "radListControl2"
            ' 
            ' radLabelCarbonCopy
            ' 
            Me.radLabelCarbonCopy.Location = New System.Drawing.Point(29, 201)
            Me.radLabelCarbonCopy.Name = "radLabelCarbonCopy"
            Me.radLabelCarbonCopy.Size = New System.Drawing.Size(91, 18)
            Me.radLabelCarbonCopy.TabIndex = 4
            Me.radLabelCarbonCopy.Text = "Carbon Copy List"
            ' 
            ' radDropDownListAutoCompleteMode
            ' 
            Me.radDropDownListAutoCompleteMode.DropDownAnimationEnabled = True
            radListDataItem4.Text = "Suggest"
            radListDataItem4.TextWrap = True
            radListDataItem5.Text = "Append"
            radListDataItem5.TextWrap = True
            radListDataItem6.Text = "SuggestAppend"
            radListDataItem6.TextWrap = True
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem4)
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem5)
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem6)
            Me.radDropDownListAutoCompleteMode.Location = New System.Drawing.Point(29, 400)
            Me.radDropDownListAutoCompleteMode.MaxDropDownItems = 0
            Me.radDropDownListAutoCompleteMode.Name = "radDropDownListAutoCompleteMode"
            Me.radDropDownListAutoCompleteMode.ShowImageInEditorArea = True
            Me.radDropDownListAutoCompleteMode.Size = New System.Drawing.Size(126, 20)
            Me.radDropDownListAutoCompleteMode.TabIndex = 5
            ' 
            ' radLabelAutoComplete
            ' 
            Me.radLabelAutoComplete.Location = New System.Drawing.Point(29, 373)
            Me.radLabelAutoComplete.Name = "radLabelAutoComplete"
            Me.radLabelAutoComplete.Size = New System.Drawing.Size(111, 18)
            Me.radLabelAutoComplete.TabIndex = 6
            Me.radLabelAutoComplete.Text = "AutoComplete Mode"
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.AutoScroll = True
            Me.radPanel2.BackgroundImage = My.Resources.email
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel2, 3)
            Me.radPanel2.Location = New System.Drawing.Point(3, 99)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Size = New System.Drawing.Size(679, 348)
            Me.radPanel2.TabIndex = 8
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1039, 624)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radButtonSend, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonTo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonCc, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabelSubject, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBoxControlSubject, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radAutoCompleteBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radAutoCompleteBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            DirectCast(Me.radListControlRecipients, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1Recipients, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radListControlCarbonCopy, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabelCarbonCopy, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownListAutoCompleteMode, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabelAutoComplete, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radButtonSend As Telerik.WinControls.UI.RadButton
        Private radButtonTo As Telerik.WinControls.UI.RadButton
        Private radButtonCc As Telerik.WinControls.UI.RadButton
        Private radLabelSubject As Telerik.WinControls.UI.RadLabel
        Private radTextBoxControlSubject As Telerik.WinControls.UI.RadTextBoxControl
        Private radAutoCompleteBox1 As Telerik.WinControls.UI.RadAutoCompleteBox
        Private radAutoCompleteBox2 As Telerik.WinControls.UI.RadAutoCompleteBox
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radLabelCarbonCopy As Telerik.WinControls.UI.RadLabel
        Private radListControlCarbonCopy As Telerik.WinControls.UI.RadListControl
        Private radLabel1Recipients As Telerik.WinControls.UI.RadLabel
        Private radListControlRecipients As Telerik.WinControls.UI.RadListControl
        Private radLabelAutoComplete As Telerik.WinControls.UI.RadLabel
        Private radDropDownListAutoCompleteMode As Telerik.WinControls.UI.RadDropDownList
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace
