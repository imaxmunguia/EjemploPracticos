Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.GridView.RowColumnOperations
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.chkColAutosize = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkColResize = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkContextMenu = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkColReorder = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkColChooser = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkRowResize = New Telerik.WinControls.UI.RadCheckBox()
			Me.chkFiltering = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkColAutosize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkColResize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkColReorder, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkColChooser, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkRowResize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 810)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.AutoSize = False
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.ShowFilteringRow = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New System.Drawing.Size(980, 812)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.ThemeName = "Vista"
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
			' chkColAutosize
			' 
			Me.chkColAutosize.BackColor = System.Drawing.Color.Transparent
			Me.chkColAutosize.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkColAutosize.Location = New System.Drawing.Point(19, 54)
			Me.chkColAutosize.Name = "chkColAutosize"
			' 
			' 
			' 
			Me.chkColAutosize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkColAutosize.Size = New System.Drawing.Size(88, 17)
			Me.chkColAutosize.TabIndex = 32
			Me.chkColAutosize.Text = "Allow BestFit"
			Me.chkColAutosize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkColAutosize.ThemeName = "GridFeaturesBrowser"
			Me.chkColAutosize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkColAutosize.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkColAutosize_ToggleStateChanged);
			' 
			' chkColResize
			' 
			Me.chkColResize.BackColor = System.Drawing.Color.Transparent
			Me.chkColResize.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkColResize.Location = New System.Drawing.Point(19, 27)
			Me.chkColResize.Name = "chkColResize"
			' 
			' 
			' 
			Me.chkColResize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkColResize.Size = New System.Drawing.Size(96, 17)
			Me.chkColResize.TabIndex = 27
			Me.chkColResize.Text = "Allow Resizing"
			Me.chkColResize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkColResize.ThemeName = "GridFeaturesBrowser"
			Me.chkColResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkColResize.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkColResize_ToggleStateChanged);
			' 
			' chkContextMenu
			' 
			Me.chkContextMenu.BackColor = System.Drawing.Color.Transparent
			Me.chkContextMenu.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkContextMenu.Location = New System.Drawing.Point(19, 107)
			Me.chkContextMenu.Name = "chkContextMenu"
			' 
			' 
			' 
			Me.chkContextMenu.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkContextMenu.Size = New System.Drawing.Size(123, 17)
			Me.chkContextMenu.TabIndex = 25
			Me.chkContextMenu.Text = "Allow Context Menu"
			Me.chkContextMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkContextMenu.ThemeName = "GridFeaturesBrowser"
			Me.chkContextMenu.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkContextMenu.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkContextMenu_ToggleStateChanged);
			' 
			' chkColReorder
			' 
			Me.chkColReorder.BackColor = System.Drawing.Color.Transparent
			Me.chkColReorder.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkColReorder.Location = New System.Drawing.Point(19, 81)
			Me.chkColReorder.Name = "chkColReorder"
			' 
			' 
			' 
			Me.chkColReorder.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkColReorder.Size = New System.Drawing.Size(93, 17)
			Me.chkColReorder.TabIndex = 29
			Me.chkColReorder.Text = "Allow Reorder"
			Me.chkColReorder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkColReorder.ThemeName = "GridFeaturesBrowser"
			Me.chkColReorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkColReorder.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkColReorder_ToggleStateChanged);
			' 
			' chkColChooser
			' 
			Me.chkColChooser.BackColor = System.Drawing.Color.Transparent
			Me.chkColChooser.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkColChooser.Location = New System.Drawing.Point(19, 134)
			Me.chkColChooser.Name = "chkColChooser"
			' 
			' 
			' 
			Me.chkColChooser.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkColChooser.Size = New System.Drawing.Size(137, 17)
			Me.chkColChooser.TabIndex = 28
			Me.chkColChooser.Text = "Allow Column Chooser"
			Me.chkColChooser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkColChooser.ThemeName = "GridFeaturesBrowser"
			Me.chkColChooser.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkColChooser.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkColChooser_ToggleStateChanged);
			' 
			' chkRowResize
			' 
			Me.chkRowResize.BackColor = System.Drawing.Color.Transparent
			Me.chkRowResize.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkRowResize.Location = New System.Drawing.Point(19, 25)
			Me.chkRowResize.Name = "chkRowResize"
			' 
			' 
			' 
			Me.chkRowResize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkRowResize.Size = New System.Drawing.Size(122, 17)
			Me.chkRowResize.TabIndex = 27
			Me.chkRowResize.Text = "Allow Row Resizing"
			Me.chkRowResize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkRowResize.ThemeName = "GridFeaturesBrowser"
			Me.chkRowResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkRowResize.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkRowResize_ToggleStateChanged);
			' 
			' chkFiltering
			' 
			Me.chkFiltering.BackColor = System.Drawing.Color.Transparent
			Me.chkFiltering.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.chkFiltering.Location = New System.Drawing.Point(19, 26)
			Me.chkFiltering.Name = "chkFiltering"
			' 
			' 
			' 
			Me.chkFiltering.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.chkFiltering.Size = New System.Drawing.Size(63, 17)
			Me.chkFiltering.TabIndex = 33
			Me.chkFiltering.Text = "Filtering"
			Me.chkFiltering.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.chkFiltering.ThemeName = "GridFeaturesBrowser"
			Me.chkFiltering.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.chkFiltering.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chkFiltering_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.chkColResize)
			Me.radGroupBox1.Controls.Add(Me.chkContextMenu)
			Me.radGroupBox1.Controls.Add(Me.chkColAutosize)
			Me.radGroupBox1.Controls.Add(Me.chkColChooser)
			Me.radGroupBox1.Controls.Add(Me.chkColReorder)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = " Column Actions "
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 162)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = " Column Actions "
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.chkRowResize)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox2.HeaderText = " Row Actions "
			Me.radGroupBox2.Location = New System.Drawing.Point(15, 176)
			Me.radGroupBox2.Name = "radGroupBox2"
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.Size = New System.Drawing.Size(162, 62)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = " Row Actions "
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Controls.Add(Me.chkFiltering)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox3.HeaderText = "Data"
			Me.radGroupBox3.Location = New System.Drawing.Point(15, 244)
			Me.radGroupBox3.Name = "radGroupBox3"
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.Size = New System.Drawing.Size(162, 56)
			Me.radGroupBox3.TabIndex = 2
			Me.radGroupBox3.Text = "Data"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 812)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkColAutosize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkColResize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkColReorder, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkColChooser, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkRowResize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkFiltering, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private customersBindingSource As BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents chkColAutosize As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkColResize As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkContextMenu As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkColReorder As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkColChooser As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkRowResize As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents chkFiltering As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace
