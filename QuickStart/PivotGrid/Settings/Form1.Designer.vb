Namespace Telerik.Examples.WinControls.PivotGrid.Settings
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
        Inherits Telerik.QuickStart.WinControls.ExamplesForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.rowGrandTotalNone = New Telerik.WinControls.UI.RadRadioButton()
            Me.rowGrandTotalLast = New Telerik.WinControls.UI.RadRadioButton()
            Me.rowGrandTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.rowSubTotalNone = New Telerik.WinControls.UI.RadRadioButton()
            Me.rowSubTotalLast = New Telerik.WinControls.UI.RadRadioButton()
            Me.rowSubTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.columnGrandTotalNone = New Telerik.WinControls.UI.RadRadioButton()
            Me.columnGrandTotalLast = New Telerik.WinControls.UI.RadRadioButton()
            Me.columnGrandTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
            Me.columnSubTotalNone = New Telerik.WinControls.UI.RadRadioButton()
            Me.columnSubTotalLast = New Telerik.WinControls.UI.RadRadioButton()
            Me.columnSubTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.aggregatePositionColumns = New Telerik.WinControls.UI.RadRadioButton()
            Me.aggregatePositionRows = New Telerik.WinControls.UI.RadRadioButton()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.rowGrandTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rowGrandTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rowGrandTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.rowSubTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rowSubTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rowSubTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            DirectCast(Me.columnGrandTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.columnGrandTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.columnGrandTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox4.SuspendLayout()
            DirectCast(Me.columnSubTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.columnSubTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.columnSubTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox5.SuspendLayout()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.aggregatePositionColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.aggregatePositionRows, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.settingsPanel.Controls.Add(Me.radGroupBox5)
            Me.settingsPanel.Controls.Add(Me.radGroupBox4)
            Me.settingsPanel.Controls.Add(Me.radGroupBox3)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(972, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(286, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox4, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox5, 0)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.rowGrandTotalNone)
            Me.radGroupBox1.Controls.Add(Me.rowGrandTotalLast)
            Me.radGroupBox1.Controls.Add(Me.rowGrandTotalFirst)
            Me.radGroupBox1.FooterImageIndex = -1
            Me.radGroupBox1.FooterImageKey = ""
            Me.radGroupBox1.HeaderImageIndex = -1
            Me.radGroupBox1.HeaderImageKey = ""
            Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox1.HeaderText = "Rows GrandTotals Position"
            Me.radGroupBox1.Location = New System.Drawing.Point(89, 7)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(183, 94)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Rows GrandTotals Position"
            ' 
            ' rowGrandTotalNone
            ' 
            Me.rowGrandTotalNone.Location = New System.Drawing.Point(6, 70)
            Me.rowGrandTotalNone.Name = "rowGrandTotalNone"
            Me.rowGrandTotalNone.Size = New System.Drawing.Size(110, 18)
            Me.rowGrandTotalNone.TabIndex = 2
            Me.rowGrandTotalNone.Text = "None"
            ' 
            ' rowGrandTotalLast
            ' 
            Me.rowGrandTotalLast.Location = New System.Drawing.Point(6, 46)
            Me.rowGrandTotalLast.Name = "rowGrandTotalLast"
            Me.rowGrandTotalLast.Size = New System.Drawing.Size(110, 18)
            Me.rowGrandTotalLast.TabIndex = 1
            Me.rowGrandTotalLast.Text = "Last"
            ' 
            ' rowGrandTotalFirst
            ' 
            Me.rowGrandTotalFirst.Location = New System.Drawing.Point(6, 22)
            Me.rowGrandTotalFirst.Name = "rowGrandTotalFirst"
            Me.rowGrandTotalFirst.Size = New System.Drawing.Size(110, 18)
            Me.rowGrandTotalFirst.TabIndex = 0
            Me.rowGrandTotalFirst.Text = "First"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.rowSubTotalNone)
            Me.radGroupBox2.Controls.Add(Me.rowSubTotalLast)
            Me.radGroupBox2.Controls.Add(Me.rowSubTotalFirst)
            Me.radGroupBox2.FooterImageIndex = -1
            Me.radGroupBox2.FooterImageKey = ""
            Me.radGroupBox2.HeaderImageIndex = -1
            Me.radGroupBox2.HeaderImageKey = ""
            Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox2.HeaderText = "Rows SubTotals Position"
            Me.radGroupBox2.Location = New System.Drawing.Point(89, 107)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(183, 93)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "Rows SubTotals Position"
            ' 
            ' rowSubTotalNone
            ' 
            Me.rowSubTotalNone.Location = New System.Drawing.Point(6, 69)
            Me.rowSubTotalNone.Name = "rowSubTotalNone"
            Me.rowSubTotalNone.Size = New System.Drawing.Size(110, 18)
            Me.rowSubTotalNone.TabIndex = 5
            Me.rowSubTotalNone.Text = "None"
            ' 
            ' rowSubTotalLast
            ' 
            Me.rowSubTotalLast.Location = New System.Drawing.Point(6, 45)
            Me.rowSubTotalLast.Name = "rowSubTotalLast"
            Me.rowSubTotalLast.Size = New System.Drawing.Size(110, 18)
            Me.rowSubTotalLast.TabIndex = 4
            Me.rowSubTotalLast.Text = "Last"
            ' 
            ' rowSubTotalFirst
            ' 
            Me.rowSubTotalFirst.Location = New System.Drawing.Point(6, 21)
            Me.rowSubTotalFirst.Name = "rowSubTotalFirst"
            Me.rowSubTotalFirst.Size = New System.Drawing.Size(110, 18)
            Me.rowSubTotalFirst.TabIndex = 3
            Me.rowSubTotalFirst.Text = "First"
            ' 
            ' radGroupBox3
            ' 
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Controls.Add(Me.columnGrandTotalNone)
            Me.radGroupBox3.Controls.Add(Me.columnGrandTotalLast)
            Me.radGroupBox3.Controls.Add(Me.columnGrandTotalFirst)
            Me.radGroupBox3.FooterImageIndex = -1
            Me.radGroupBox3.FooterImageKey = ""
            Me.radGroupBox3.HeaderImageIndex = -1
            Me.radGroupBox3.HeaderImageKey = ""
            Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox3.HeaderText = "Columns GrandTotals Position"
            Me.radGroupBox3.Location = New System.Drawing.Point(89, 206)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox3.Size = New System.Drawing.Size(183, 97)
            Me.radGroupBox3.TabIndex = 3
            Me.radGroupBox3.Text = "Columns GrandTotals Position"
            ' 
            ' columnGrandTotalNone
            ' 
            Me.columnGrandTotalNone.Location = New System.Drawing.Point(6, 69)
            Me.columnGrandTotalNone.Name = "columnGrandTotalNone"
            Me.columnGrandTotalNone.Size = New System.Drawing.Size(110, 18)
            Me.columnGrandTotalNone.TabIndex = 5
            Me.columnGrandTotalNone.Text = "None"
            ' 
            ' columnGrandTotalLast
            ' 
            Me.columnGrandTotalLast.Location = New System.Drawing.Point(6, 45)
            Me.columnGrandTotalLast.Name = "columnGrandTotalLast"
            Me.columnGrandTotalLast.Size = New System.Drawing.Size(110, 18)
            Me.columnGrandTotalLast.TabIndex = 4
            Me.columnGrandTotalLast.Text = "Last"
            ' 
            ' columnGrandTotalFirst
            ' 
            Me.columnGrandTotalFirst.Location = New System.Drawing.Point(6, 21)
            Me.columnGrandTotalFirst.Name = "columnGrandTotalFirst"
            Me.columnGrandTotalFirst.Size = New System.Drawing.Size(110, 18)
            Me.columnGrandTotalFirst.TabIndex = 3
            Me.columnGrandTotalFirst.Text = "First"
            ' 
            ' radGroupBox4
            ' 
            Me.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox4.Controls.Add(Me.columnSubTotalNone)
            Me.radGroupBox4.Controls.Add(Me.columnSubTotalLast)
            Me.radGroupBox4.Controls.Add(Me.columnSubTotalFirst)
            Me.radGroupBox4.FooterImageIndex = -1
            Me.radGroupBox4.FooterImageKey = ""
            Me.radGroupBox4.HeaderImageIndex = -1
            Me.radGroupBox4.HeaderImageKey = ""
            Me.radGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox4.HeaderText = "Columns SubTotals Position"
            Me.radGroupBox4.Location = New System.Drawing.Point(89, 309)
            Me.radGroupBox4.Name = "radGroupBox4"
            Me.radGroupBox4.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox4.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox4.Size = New System.Drawing.Size(183, 99)
            Me.radGroupBox4.TabIndex = 4
            Me.radGroupBox4.Text = "Columns SubTotals Position"
            ' 
            ' columnSubTotalNone
            ' 
            Me.columnSubTotalNone.Location = New System.Drawing.Point(6, 69)
            Me.columnSubTotalNone.Name = "columnSubTotalNone"
            Me.columnSubTotalNone.Size = New System.Drawing.Size(110, 18)
            Me.columnSubTotalNone.TabIndex = 5
            Me.columnSubTotalNone.Text = "None"
            ' 
            ' columnSubTotalLast
            ' 
            Me.columnSubTotalLast.Location = New System.Drawing.Point(6, 45)
            Me.columnSubTotalLast.Name = "columnSubTotalLast"
            Me.columnSubTotalLast.Size = New System.Drawing.Size(110, 18)
            Me.columnSubTotalLast.TabIndex = 4
            Me.columnSubTotalLast.Text = "Last"
            ' 
            ' columnSubTotalFirst
            ' 
            Me.columnSubTotalFirst.Location = New System.Drawing.Point(6, 21)
            Me.columnSubTotalFirst.Name = "columnSubTotalFirst"
            Me.columnSubTotalFirst.Size = New System.Drawing.Size(110, 18)
            Me.columnSubTotalFirst.TabIndex = 3
            Me.columnSubTotalFirst.Text = "First"
            ' 
            ' radGroupBox5
            ' 
            Me.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox5.Controls.Add(Me.radLabel1)
            Me.radGroupBox5.Controls.Add(Me.radSpinEditor1)
            Me.radGroupBox5.Controls.Add(Me.aggregatePositionColumns)
            Me.radGroupBox5.Controls.Add(Me.aggregatePositionRows)
            Me.radGroupBox5.FooterImageIndex = -1
            Me.radGroupBox5.FooterImageKey = ""
            Me.radGroupBox5.HeaderImageIndex = -1
            Me.radGroupBox5.HeaderImageKey = ""
            Me.radGroupBox5.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.radGroupBox5.HeaderText = "Aggregates Position"
            Me.radGroupBox5.Location = New System.Drawing.Point(89, 414)
            Me.radGroupBox5.Name = "radGroupBox5"
            Me.radGroupBox5.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            ' 
            ' 
            ' 
            Me.radGroupBox5.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
            Me.radGroupBox5.Size = New System.Drawing.Size(183, 98)
            Me.radGroupBox5.TabIndex = 5
            Me.radGroupBox5.Text = "Aggregates Position"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New System.Drawing.Point(6, 70)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(92, 18)
            Me.radLabel1.TabIndex = 6
            Me.radLabel1.Text = "Aggregates level:"
            ' 
            ' radSpinEditor1
            ' 
            Me.radSpinEditor1.Location = New System.Drawing.Point(121, 69)
            Me.radSpinEditor1.Name = "radSpinEditor1"
            ' 
            ' 
            ' 
            Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditor1.ShowBorder = True
            Me.radSpinEditor1.Size = New System.Drawing.Size(50, 20)
            Me.radSpinEditor1.TabIndex = 5
            Me.radSpinEditor1.TabStop = False
            ' 
            ' aggregatePositionColumns
            ' 
            Me.aggregatePositionColumns.Location = New System.Drawing.Point(6, 45)
            Me.aggregatePositionColumns.Name = "aggregatePositionColumns"
            Me.aggregatePositionColumns.Size = New System.Drawing.Size(110, 18)
            Me.aggregatePositionColumns.TabIndex = 4
            Me.aggregatePositionColumns.Text = "Columns"
            ' 
            ' aggregatePositionRows
            ' 
            Me.aggregatePositionRows.Location = New System.Drawing.Point(6, 21)
            Me.aggregatePositionRows.Name = "aggregatePositionRows"
            Me.aggregatePositionRows.Size = New System.Drawing.Size(110, 18)
            Me.aggregatePositionRows.TabIndex = 3
            Me.aggregatePositionRows.Text = "Rows"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1258, 832)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            DirectCast(Me.rowGrandTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rowGrandTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rowGrandTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            DirectCast(Me.rowSubTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rowSubTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rowSubTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            DirectCast(Me.columnGrandTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.columnGrandTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.columnGrandTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox4.ResumeLayout(False)
            DirectCast(Me.columnSubTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.columnSubTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.columnSubTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox5.ResumeLayout(False)
            Me.radGroupBox5.PerformLayout()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.aggregatePositionColumns, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.aggregatePositionRows, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents rowGrandTotalFirst As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents rowGrandTotalLast As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents rowGrandTotalNone As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents rowSubTotalNone As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents rowSubTotalLast As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents rowSubTotalFirst As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnGrandTotalNone As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnGrandTotalLast As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnGrandTotalFirst As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnSubTotalNone As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnSubTotalLast As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents columnSubTotalFirst As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents aggregatePositionColumns As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents aggregatePositionRows As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel

#End Region

    End Class
End Namespace