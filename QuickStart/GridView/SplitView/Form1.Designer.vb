Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.SplitView
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
			Me.gridView = New Telerik.WinControls.UI.RadGridView()
			Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.order_DetailsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.radRadioButtonNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonVertical = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonHorizontal = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonVertical, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(703, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 745)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			' 
			' gridView
			' 
			Me.gridView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridView.Location = New System.Drawing.Point(0, 0)
			Me.gridView.Name = "gridView"
			Me.gridView.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.gridView.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.gridView.Size = New System.Drawing.Size(904, 747)
			Me.gridView.TabIndex = 0
			Me.gridView.Text = "gridView"
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "Order Details"
			Me.orderDetailsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' order_DetailsTableAdapter
			' 
			Me.order_DetailsTableAdapter.ClearBeforeFill = True
			' 
			' radRadioButtonNone
			' 
			Me.radRadioButtonNone.Location = New System.Drawing.Point(14, 34)
			Me.radRadioButtonNone.Name = "radRadioButtonNone"
			Me.radRadioButtonNone.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonNone.TabIndex = 1
			Me.radRadioButtonNone.Text = "None"
'			Me.radRadioButtonNone.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonNone_ToggleStateChanged);
			' 
			' radRadioButtonVertical
			' 
			Me.radRadioButtonVertical.Location = New System.Drawing.Point(14, 58)
			Me.radRadioButtonVertical.Name = "radRadioButtonVertical"
			Me.radRadioButtonVertical.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonVertical.TabIndex = 2
			Me.radRadioButtonVertical.Text = "Vertical"
'			Me.radRadioButtonVertical.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonVertical_ToggleStateChanged);
			' 
			' radRadioButtonHorizontal
			' 
			Me.radRadioButtonHorizontal.Location = New System.Drawing.Point(14, 82)
			Me.radRadioButtonHorizontal.Name = "radRadioButtonHorizontal"
			Me.radRadioButtonHorizontal.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButtonHorizontal.TabIndex = 3
			Me.radRadioButtonHorizontal.Text = "Horizontal"
'			Me.radRadioButtonHorizontal.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonHorizontal_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonHorizontal)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonVertical)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonNone)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Split Mode"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 112)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Split Mode"
			Me.radGroupBox1.ThemeName = "ControlDefault"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBox1.Location = New System.Drawing.Point(10, 176)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New System.Drawing.Size(146, 18)
			Me.radCheckBox1.TabIndex = 2
			Me.radCheckBox1.Text = "Synchronize Current Row"
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridView)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(904, 747)
'			Me.Load += New System.EventHandler(Me.SplitGridControl_Load);
			Me.Controls.SetChildIndex(Me.gridView, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonVertical, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView As Telerik.WinControls.UI.RadGridView
		Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private order_DetailsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButtonHorizontal As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonVertical As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonNone As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
