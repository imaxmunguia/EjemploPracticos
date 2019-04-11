Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.GridView.Selection
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
			Me.components = New System.ComponentModel.Container()
			Me.radCheckMulti = New Telerik.WinControls.UI.RadCheckBox()
			Me.radComboSelectionMode = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.aggregatesSampleTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.aggregatesSampleTableTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter()
			Me.radCheckTranslucent = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckHideSel = New Telerik.WinControls.UI.RadCheckBox()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCheckMulti, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboSelectionMode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckTranslucent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckHideSel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButton2)
			Me.settingsPanel.Controls.Add(Me.radButton1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton2, 0)
			' 
			' radCheckMulti
			' 
			Me.radCheckMulti.AutoSize = True
			Me.radCheckMulti.BackColor = System.Drawing.Color.Transparent
			Me.radCheckMulti.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckMulti.Location = New System.Drawing.Point(21, 85)
			Me.radCheckMulti.Name = "radCheckMulti"
			' 
			' 
			' 
			Me.radCheckMulti.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckMulti.Size = New System.Drawing.Size(104, 14)
			Me.radCheckMulti.TabIndex = 0
			Me.radCheckMulti.Text = "Allow MultiSelect"
			Me.radCheckMulti.TextAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.radCheckMulti.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckMulti.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' radComboSelectionMode
			' 
			Me.radComboSelectionMode.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radComboSelectionMode.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboSelectionMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboSelectionMode.ForeColor = System.Drawing.Color.Black
			Me.radComboSelectionMode.FormatString = "{0}"
			Me.radComboSelectionMode.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2}))
			Me.radComboSelectionMode.Location = New System.Drawing.Point(21, 56)
			Me.radComboSelectionMode.MaxDropDownItems = 6
			Me.radComboSelectionMode.Name = "radComboSelectionMode"
			' 
			' 
			' 
			Me.radComboSelectionMode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboSelectionMode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboSelectionMode.Size = New System.Drawing.Size(121, 20)
			Me.radComboSelectionMode.TabIndex = 2
			Me.radComboSelectionMode.TabStop = False
			Me.radComboSelectionMode.ThemeName = "ControlDefault"
'			Me.radComboSelectionMode.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBox1_SelectedIndexChanged);
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "FullRowSelect"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "CellSelect"
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(21, 33)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(87, 16)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Selection Mode:"
			' 
			' aggregatesSampleTableBindingSource
			' 
			Me.aggregatesSampleTableBindingSource.DataMember = "EmployeeOrders"
			Me.aggregatesSampleTableBindingSource.DataSource = Me.nwindRadGridView
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' aggregatesSampleTableTableAdapter
			' 
			Me.aggregatesSampleTableTableAdapter.ClearBeforeFill = True
			' 
			' radCheckTranslucent
			' 
			Me.radCheckTranslucent.AutoSize = True
			Me.radCheckTranslucent.BackColor = System.Drawing.Color.Transparent
			Me.radCheckTranslucent.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckTranslucent.Location = New System.Drawing.Point(21, 111)
			Me.radCheckTranslucent.Name = "radCheckTranslucent"
			' 
			' 
			' 
			Me.radCheckTranslucent.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckTranslucent.Size = New System.Drawing.Size(113, 26)
			Me.radCheckTranslucent.TabIndex = 5
			Me.radCheckTranslucent.Text = "Show translucent" & Constants.vbCrLf & "selection rectangle"
			Me.radCheckTranslucent.TextAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.radCheckTranslucent.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckTranslucent.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox2_ToggleStateChanged);
			' 
			' radCheckHideSel
			' 
			Me.radCheckHideSel.AutoSize = True
			Me.radCheckHideSel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckHideSel.Location = New System.Drawing.Point(21, 149)
			Me.radCheckHideSel.Name = "radCheckHideSel"
			' 
			' 
			' 
			Me.radCheckHideSel.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckHideSel.Size = New System.Drawing.Size(111, 39)
			Me.radCheckHideSel.TabIndex = 6
			Me.radCheckHideSel.Text = "Hide selection of" & Constants.vbCrLf & "current row when" & Constants.vbCrLf & "control is inactive"
			Me.radCheckHideSel.TextAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.toolTip1.SetToolTip(Me.radCheckHideSel, "Hide selection of current row" & Constants.vbCrLf & "when the control loses focus")
'			Me.radCheckHideSel.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox3_ToggleStateChanged);
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(1224, 737)
			Me.radGridView1.TabIndex = 4
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "Vista"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radComboSelectionMode)
			Me.radGroupBox1.Controls.Add(Me.radCheckHideSel)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radCheckMulti)
			Me.radGroupBox1.Controls.Add(Me.radCheckTranslucent)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = " Selection Preferences "
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 207)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = " Selection Preferences "
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton1.Location = New System.Drawing.Point(10, 233)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(180, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Select All"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton2.Location = New System.Drawing.Point(10, 262)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(180, 23)
			Me.radButton2.TabIndex = 9
			Me.radButton2.Text = "Clear Selection"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCheckMulti, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboSelectionMode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckTranslucent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckHideSel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radCheckMulti As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radComboSelectionMode As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private aggregatesSampleTableBindingSource As System.Windows.Forms.BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private aggregatesSampleTableTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter
		Private WithEvents radCheckTranslucent As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckHideSel As Telerik.WinControls.UI.RadCheckBox
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
