Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.CustomFiltering
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
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radGridView = New Telerik.WinControls.UI.RadGridView()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.commandPanel = New Telerik.WinControls.UI.RadPanel()
			Me.filterTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.commandPanel.SuspendLayout()
			CType(Me.filterTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1121, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radGridView
			' 
			Me.radGridView.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView.ForeColor = System.Drawing.Color.Black
			Me.radGridView.Location = New System.Drawing.Point(12, 49)
			' 
			' radGridView
			' 
			Me.radGridView.MasterTemplate.AllowAddNewRow = False
			Me.radGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn1.FieldName = "CompanyName"
			gridViewTextBoxColumn1.HeaderText = "CompanyName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "CompanyName"
			gridViewTextBoxColumn1.Width = 161
			gridViewTextBoxColumn2.FieldName = "ContactName"
			gridViewTextBoxColumn2.HeaderText = "ContactName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "ContactName"
			gridViewTextBoxColumn2.Width = 161
			gridViewTextBoxColumn3.FieldName = "ContactTitle"
			gridViewTextBoxColumn3.HeaderText = "ContactTitle"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "ContactTitle"
			gridViewTextBoxColumn3.Width = 161
			gridViewTextBoxColumn4.FieldName = "Country"
			gridViewTextBoxColumn4.HeaderText = "Country"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Country"
			gridViewTextBoxColumn4.Width = 161
			gridViewTextBoxColumn5.FieldName = "City"
			gridViewTextBoxColumn5.HeaderText = "City"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "City"
			gridViewTextBoxColumn5.Width = 161
			gridViewTextBoxColumn6.FieldName = "Address"
			gridViewTextBoxColumn6.HeaderText = "Address"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "Address"
			gridViewTextBoxColumn6.Width = 161
			gridViewTextBoxColumn7.FieldName = "Phone"
			gridViewTextBoxColumn7.HeaderText = "Phone"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.Name = "Phone"
			gridViewTextBoxColumn7.Width = 164
			Me.radGridView.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7})
			Me.radGridView.MasterTemplate.DataSource = Me.customersBindingSource
			Me.radGridView.Name = "radGridView"
			' 
			' 
			' 
			Me.radGridView.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView.Size = New System.Drawing.Size(1310, 700)
			Me.radGridView.TabIndex = 0
			Me.radGridView.Text = "radGridView1"
			Me.radGridView.ThemeName = "Telerik"
'			Me.radGridView.CustomFiltering += New Telerik.WinControls.UI.GridViewCustomFilteringEventHandler(Me.radGridView1_CustomFiltering);
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' commandPanel
			' 
			Me.commandPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.commandPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.commandPanel.Controls.Add(Me.filterTextBox)
			Me.commandPanel.Controls.Add(Me.radLabel1)
			Me.commandPanel.ForeColor = System.Drawing.Color.Black
			Me.commandPanel.Location = New System.Drawing.Point(12, 6)
			Me.commandPanel.Name = "commandPanel"
			' 
			' 
			' 
			Me.commandPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.commandPanel.Size = New System.Drawing.Size(1310, 37)
			Me.commandPanel.TabIndex = 18
			' 
			' filterTextBox
			' 
			Me.filterTextBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.filterTextBox.Location = New System.Drawing.Point(63, 9)
			Me.filterTextBox.Name = "filterTextBox"
			Me.filterTextBox.Size = New System.Drawing.Size(1235, 21)
			Me.filterTextBox.TabIndex = 0
			Me.filterTextBox.TabStop = False
'			Me.filterTextBox.TextChanged += New System.EventHandler(Me.filterTextBox_TextChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(12, 10)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(45, 19)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Filter:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView)
			Me.Controls.Add(Me.commandPanel)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1322, 749)
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			Me.Controls.SetChildIndex(Me.commandPanel, 0)
			Me.Controls.SetChildIndex(Me.radGridView, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.commandPanel.ResumeLayout(False)
			Me.commandPanel.PerformLayout()
			CType(Me.filterTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radGridView As Telerik.WinControls.UI.RadGridView
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private commandPanel As Telerik.WinControls.UI.RadPanel
		Private WithEvents filterTextBox As Telerik.WinControls.UI.RadTextBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace