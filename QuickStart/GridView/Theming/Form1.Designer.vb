Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.GridView.Theming
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
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn12 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn13 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn14 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.aggregatesSampleTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.aggregatesSampleTableTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ForeColor = System.Drawing.Color.White
			Me.radGridView1.Location = New System.Drawing.Point(20, 43)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn8.FieldName = "FirstName"
			gridViewTextBoxColumn8.FormatString = "{0}"
			gridViewTextBoxColumn8.HeaderText = "FirstName"
			gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn8.Name = "FirstName"
			gridViewTextBoxColumn9.FieldName = "LastName"
			gridViewTextBoxColumn9.FormatString = "{0}"
			gridViewTextBoxColumn9.HeaderText = "LastName"
			gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn9.Name = "LastName"
			gridViewTextBoxColumn10.FieldName = "Title"
			gridViewTextBoxColumn10.FormatString = "{0}"
			gridViewTextBoxColumn10.HeaderText = "Title"
			gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn10.Name = "Title"
			gridViewTextBoxColumn11.FieldName = "City"
			gridViewTextBoxColumn11.FormatString = "{0}"
			gridViewTextBoxColumn11.HeaderText = "City"
			gridViewTextBoxColumn11.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn11.Name = "City"
			gridViewTextBoxColumn12.FieldName = "Country"
			gridViewTextBoxColumn12.FormatString = "{0}"
			gridViewTextBoxColumn12.HeaderText = "Country"
			gridViewTextBoxColumn12.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn12.Name = "Country"
			gridViewTextBoxColumn13.FieldName = "ShipName"
			gridViewTextBoxColumn13.FormatString = "{0}"
			gridViewTextBoxColumn13.HeaderText = "ShipName"
			gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn13.Name = "ShipName"
			gridViewDecimalColumn2.DataType = GetType(Decimal)
			gridViewDecimalColumn2.FieldName = "UnitPrice"
			gridViewDecimalColumn2.FormatString = "{0}"
			gridViewDecimalColumn2.HeaderText = "UnitPrice"
			gridViewDecimalColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewDecimalColumn2.Name = "UnitPrice"
			gridViewTextBoxColumn14.DataType = GetType(Short)
			gridViewTextBoxColumn14.FieldName = "Quantity"
			gridViewTextBoxColumn14.FormatString = "{0}"
			gridViewTextBoxColumn14.HeaderText = "Quantity"
			gridViewTextBoxColumn14.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn14.Name = "Quantity"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn11)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn12)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn13)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn14)
			Me.radGridView1.MasterTemplate.DataSource = Me.aggregatesSampleTableBindingSource
			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True

			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.White
			Me.radGridView1.Size = New System.Drawing.Size(994, 676)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "VistaTelerik"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radCheckBox1.ForeColor = System.Drawing.Color.White
			Me.radCheckBox1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radCheckBox1.Location = New System.Drawing.Point(38, 14)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox1.Size = New System.Drawing.Size(121, 17)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Enable HotTracking"
			Me.radCheckBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radCheckBox1.ThemeName = "Office2007Black"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			CType(Me.radCheckBox1.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Enable HotTracking"
			CType(Me.radCheckBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.CheckPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(80))))), (CInt(Fix((CByte(255))))))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))), (CInt(Fix((CByte(50))))))
			Me.Controls.Add(Me.radCheckBox1)
			Me.Controls.Add(Me.radGridView1)
			Me.ForeColor = System.Drawing.Color.White
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1039, 722)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private aggregatesSampleTableBindingSource As BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private aggregatesSampleTableTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
