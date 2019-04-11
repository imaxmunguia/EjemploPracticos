Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.CustomRows
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
			Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 784)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "NwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.nwindDataSet
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))))
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(13, 13)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(980, 803)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "VistaOrange"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))))
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(713, 780)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(92, 14)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "RowMouseMove:"
			Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radLabel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))))
			Me.radLabel3.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Location = New System.Drawing.Point(713, 799)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Size = New System.Drawing.Size(89, 14)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "CellMouseMove:"
			Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))))
			Me.Controls.Add(Me.radLabel3)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 786)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel


	End Class
End Namespace