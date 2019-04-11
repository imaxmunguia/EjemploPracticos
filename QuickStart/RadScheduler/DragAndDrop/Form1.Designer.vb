Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.DragAndDrop
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
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewCheckBoxColumn1 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
			Dim gridViewComboBoxColumn1 As New Telerik.WinControls.UI.GridViewComboBoxColumn()
			Dim gridViewComboBoxColumn2 As New Telerik.WinControls.UI.GridViewComboBoxColumn()
			Dim gridSortField1 As New Telerik.WinControls.UI.GridSortField()
			Me.appointmentStatusesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.schedulerDragAndDropDataDataSet = New Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSet()
			Me.appointmentBackgroundsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.appointmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.appointmentsTableAdapter = New Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSetTableAdapters.AppointmentsTableAdapter()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonAnywhere = New Telerik.WinControls.UI.RadRadioButton()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel3 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel4 = New Telerik.WinControls.UI.SplitPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.appointmentStatusesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerDragAndDropDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.appointmentBackgroundsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.appointmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonAnywhere, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2.SuspendLayout()
			CType(Me.splitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel3.SuspendLayout()
			CType(Me.splitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 581)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' appointmentStatusesBindingSource
			' 
			Me.appointmentStatusesBindingSource.DataMember = "AppointmentStatuses"
			Me.appointmentStatusesBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
			' 
			' schedulerDragAndDropDataDataSet
			' 
			Me.schedulerDragAndDropDataDataSet.DataSetName = "SchedulerDragAndDropDataDataSet"
			Me.schedulerDragAndDropDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' appointmentBackgroundsBindingSource
			' 
			Me.appointmentBackgroundsBindingSource.DataMember = "AppointmentBackgrounds"
			Me.appointmentBackgroundsBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
			' 
			' radListBox1
			' 
			Me.radListBox1.DataSource = Me.appointmentsBindingSource1
			Me.radListBox1.DisplayMember = "Summary"
			Me.radListBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radListBox1.Location = New System.Drawing.Point(0, 0)
			Me.radListBox1.Name = "radListBox1"
			' 
			' 
			' 
			Me.radListBox1.RootElement.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
			Me.radListBox1.Size = New System.Drawing.Size(394, 149)
			Me.radListBox1.TabIndex = 8
'			Me.radListBox1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.radListBox1_MouseDown);
			' 
			' appointmentsBindingSource1
			' 
			Me.appointmentsBindingSource1.DataMember = "Appointments"
			Me.appointmentsBindingSource1.DataSource = Me.schedulerDragAndDropDataDataSet
			' 
			' radScheduler1
			' 
			Me.radScheduler1.AllowDrop = True
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 79)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New System.Drawing.Size(1257, 352)
			Me.radScheduler1.TabIndex = 6
			Me.radScheduler1.Text = "radScheduler1"
'			Me.radScheduler1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.radScheduler1_DragEnter);
'			Me.radScheduler1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.radScheduler1_DragDrop);
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = System.Drawing.SystemColors.Control
			Me.radGridView1.Cursor = System.Windows.Forms.Cursors.Default
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowDeleteRow = False
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "ID"
			gridViewDecimalColumn1.HeaderText = "ID"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.IsVisible = False
			gridViewDecimalColumn1.Name = "ID"
			gridViewTextBoxColumn1.FieldName = "Summary"
			gridViewTextBoxColumn1.HeaderText = "Summary"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "Summary"
			gridViewDateTimeColumn1.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn1.FieldName = "Start"
			gridViewDateTimeColumn1.HeaderText = "Start"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "Start"
			gridViewDateTimeColumn2.DataType = GetType(System.DateTime)
			gridViewDateTimeColumn2.FieldName = "End"
			gridViewDateTimeColumn2.HeaderText = "End"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.Name = "End"
			gridViewTextBoxColumn2.FieldName = "RecurrenceRule"
			gridViewTextBoxColumn2.HeaderText = "RecurrenceRule"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.IsVisible = False
			gridViewTextBoxColumn2.Name = "RecurrenceRule"
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "MasterEventID"
			gridViewDecimalColumn2.HeaderText = "MasterEventID"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.IsVisible = False
			gridViewDecimalColumn2.Name = "MasterEventID"
			gridViewTextBoxColumn3.FieldName = "Location"
			gridViewTextBoxColumn3.HeaderText = "Location"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "Location"
			gridViewTextBoxColumn4.FieldName = "Description"
			gridViewTextBoxColumn4.HeaderText = "Description"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.MaxWidth = 50
			gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			gridViewTextBoxColumn4.Name = "Description"
			gridViewTextBoxColumn4.Width = 5
			gridViewDecimalColumn3.DataType = GetType(Integer)
			gridViewDecimalColumn3.FieldName = "ParentID"
			gridViewDecimalColumn3.HeaderText = "ParentID"
			gridViewDecimalColumn3.IsAutoGenerated = True
			gridViewDecimalColumn3.IsVisible = False
			gridViewDecimalColumn3.Name = "ParentID"
			gridViewCheckBoxColumn1.DataType = GetType(Boolean)
			gridViewCheckBoxColumn1.FieldName = "Visible"
			gridViewCheckBoxColumn1.HeaderText = "Visible"
			gridViewCheckBoxColumn1.IsAutoGenerated = True
			gridViewCheckBoxColumn1.IsVisible = False
			gridViewCheckBoxColumn1.Name = "Visible"
			gridViewComboBoxColumn1.DataSource = Me.appointmentStatusesBindingSource
			gridViewComboBoxColumn1.DataType = GetType(Integer)
			gridViewComboBoxColumn1.DisplayMember = "Name"
			gridViewComboBoxColumn1.FieldName = "StatusID"
			gridViewComboBoxColumn1.HeaderText = "Status"
			gridViewComboBoxColumn1.Name = "StatusID"
			gridViewComboBoxColumn1.ValueMember = "ID"
			gridViewComboBoxColumn2.DataSource = Me.appointmentBackgroundsBindingSource
			gridViewComboBoxColumn2.DataType = GetType(Integer)
			gridViewComboBoxColumn2.DisplayMember = "Name"
			gridViewComboBoxColumn2.FieldName = "BackgroundID"
			gridViewComboBoxColumn2.HeaderText = "Background"
			gridViewComboBoxColumn2.Name = "BackgroundID"
			gridViewComboBoxColumn2.ValueMember = "ID"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewCheckBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewComboBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewComboBoxColumn2)
			Me.radGridView1.MasterTemplate.DataSource = Me.appointmentsBindingSource
			gridSortField1.FieldName = "Description"
			gridSortField1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			Me.radGridView1.MasterTemplate.SortDescriptors.Add(gridSortField1)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New System.Drawing.Size(860, 149)
			Me.radGridView1.TabIndex = 2
			' 
			' appointmentsBindingSource
			' 
			Me.appointmentsBindingSource.DataMember = "Appointments"
			Me.appointmentsBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
			' 
			' radSchedulerNavigator1
			' 
			
			Me.radSchedulerNavigator1.AutoSize = True
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1257, 79)
			Me.radSchedulerNavigator1.TabIndex = 9
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.ThemeName = "ControlDefault"
			' 
			' appointmentsTableAdapter
			' 
			Me.appointmentsTableAdapter.ClearBeforeFill = True
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonAnywhere)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Drag&Drop"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 78)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Drag&Drop"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New System.Drawing.Point(13, 47)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "At start date/time"
			' 
			' radRadioButtonAnywhere
			' 
			Me.radRadioButtonAnywhere.Location = New System.Drawing.Point(13, 23)
			Me.radRadioButtonAnywhere.Name = "radRadioButtonAnywhere"
			Me.radRadioButtonAnywhere.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonAnywhere.TabIndex = 0
			Me.radRadioButtonAnywhere.Text = "Anywhere"
			Me.radRadioButtonAnywhere.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer1.Size = New System.Drawing.Size(1257, 583)
			Me.radSplitContainer1.TabIndex = 11
			Me.radSplitContainer1.TabStop = False
			Me.radSplitContainer1.Text = "radSplitContainer1"
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.radScheduler1)
			Me.splitPanel1.Controls.Add(Me.radSchedulerNavigator1)
			Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel1.Size = New System.Drawing.Size(1257, 431)
			Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0F, 0.2433628F)
			Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 110)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Controls.Add(Me.radSplitContainer2)
			Me.splitPanel2.Location = New System.Drawing.Point(0, 434)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel2.Size = New System.Drawing.Size(1257, 149)
			Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0F, -0.2433628F)
			Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -110)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.splitPanel3)
			Me.radSplitContainer2.Controls.Add(Me.splitPanel4)
			Me.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSplitContainer2.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer2.Size = New System.Drawing.Size(1257, 149)
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			Me.radSplitContainer2.Text = "radSplitContainer2"
			' 
			' splitPanel3
			' 
			Me.splitPanel3.Controls.Add(Me.radGridView1)
			Me.splitPanel3.Location = New System.Drawing.Point(0, 0)
			Me.splitPanel3.Name = "splitPanel3"
			' 
			' 
			' 
			Me.splitPanel3.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel3.Size = New System.Drawing.Size(860, 149)
			Me.splitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1857708F, 0F)
			Me.splitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(100, 0)
			Me.splitPanel3.TabIndex = 0
			Me.splitPanel3.TabStop = False
			Me.splitPanel3.Text = "splitPanel3"
			' 
			' splitPanel4
			' 
			Me.splitPanel4.Controls.Add(Me.radListBox1)
			Me.splitPanel4.Location = New System.Drawing.Point(863, 0)
			Me.splitPanel4.Name = "splitPanel4"
			' 
			' 
			' 
			Me.splitPanel4.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel4.Size = New System.Drawing.Size(394, 149)
			Me.splitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1857708F, 0F)
			Me.splitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(-100, 0)
			Me.splitPanel4.TabIndex = 1
			Me.splitPanel4.TabStop = False
			Me.splitPanel4.Text = "splitPanel4"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radSplitContainer1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1257, 583)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.appointmentStatusesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerDragAndDropDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.appointmentBackgroundsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.appointmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonAnywhere, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			Me.splitPanel1.PerformLayout()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2.ResumeLayout(False)
			CType(Me.splitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel3.ResumeLayout(False)
			CType(Me.splitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel4.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radListBox1 As Telerik.WinControls.UI.RadListControl
		Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private schedulerDragAndDropDataDataSet As Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSet
		Private appointmentsBindingSource As System.Windows.Forms.BindingSource
		Private appointmentsTableAdapter As Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSetTableAdapters.AppointmentsTableAdapter
		Private appointmentStatusesBindingSource As System.Windows.Forms.BindingSource
		Private appointmentBackgroundsBindingSource As System.Windows.Forms.BindingSource
		Private appointmentsBindingSource1 As System.Windows.Forms.BindingSource
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonAnywhere As Telerik.WinControls.UI.RadRadioButton
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel3 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel4 As Telerik.WinControls.UI.SplitPanel
	End Class
End Namespace
