Namespace Telerik.Examples.WinControls.ListView.CustomItems
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
			Me.components = New System.ComponentModel.Container()
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.albumsDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
			Me.albumsDataTableTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.albumsDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1065, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			' 
			' radListView1
			' 
            Me.radListView1.AllowEdit = False
            Me.radListView1.AllowRemove = False
			Me.radListView1.CurrentColumn = Nothing
			Me.radListView1.CurrentItem = Nothing
			Me.radListView1.DataSource = Me.albumsDataTableBindingSource
			Me.radListView1.FullRowSelect = False
			Me.radListView1.GroupItemSize = New System.Drawing.Size(200, 20)
			Me.radListView1.ItemSize = New System.Drawing.Size(64, 64)
			Me.radListView1.Location = New System.Drawing.Point(134, 99)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.SelectedIndex = -1
			Me.radListView1.SelectedItem = Nothing
			Me.radListView1.Size = New System.Drawing.Size(698, 329)
			Me.radListView1.TabIndex = 0
			Me.radListView1.Text = "radListView1"
			Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
			' 
			' albumsDataTableBindingSource
			' 
			Me.albumsDataTableBindingSource.DataMember = "AlbumsDataTable"
			Me.albumsDataTableBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' musicCollectionDataSet
			' 
			Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
			Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' albumsDataTableTableAdapter
			' 
			Me.albumsDataTableTableAdapter.ClearBeforeFill = True
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBox1.Location = New System.Drawing.Point(10, 37)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New System.Drawing.Size(136, 18)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Enable Kinetic Scrolling"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radListView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1266, 749)
			Me.Controls.SetChildIndex(Me.radListView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.albumsDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Friend WithEvents musicCollectionDataSet As DataSources.MusicCollectionDataSet
		Friend WithEvents albumsDataTableBindingSource As System.Windows.Forms.BindingSource
		Friend WithEvents albumsDataTableTableAdapter As DataSources.MusicCollectionDataSetTableAdapters.AlbumsDataTableTableAdapter
		Friend WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace