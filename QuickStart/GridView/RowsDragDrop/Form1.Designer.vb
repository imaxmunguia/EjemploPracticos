Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.RowsDragDrop
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.gbProducts = New Telerik.WinControls.UI.RadGroupBox()
			Me.gridViewProducts = New Telerik.WinControls.UI.RadGridView()
			Me.gbBasket = New Telerik.WinControls.UI.RadGroupBox()
			Me.gridBasket = New Telerik.WinControls.UI.RadGridView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.btnCheckoutSelectedProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnCheckoutAllProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnReturnSelectedProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnReturnAllProducts = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.gbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbProducts.SuspendLayout()
			CType(Me.gridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gbBasket, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbBasket.SuspendLayout()
			CType(Me.gridBasket, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridBasket.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnCheckoutSelectedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnCheckoutAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnReturnSelectedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnReturnAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.btnCheckoutSelectedProducts)
			Me.settingsPanel.Controls.Add(Me.btnReturnAllProducts)
			Me.settingsPanel.Controls.Add(Me.btnReturnSelectedProducts)
			Me.settingsPanel.Controls.Add(Me.btnCheckoutAllProducts)
			Me.settingsPanel.Location = New System.Drawing.Point(744, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.btnCheckoutAllProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnReturnSelectedProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnReturnAllProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnCheckoutSelectedProducts, 0)
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.gbProducts)
			Me.radPanel1.Controls.Add(Me.gbBasket)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New System.Windows.Forms.Padding(100)
			' 
			' 
			' 
			Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(100)
			Me.radPanel1.Size = New System.Drawing.Size(945, 725)
			Me.radPanel1.TabIndex = 1
'			Me.radPanel1.SizeChanged += New System.EventHandler(Me.radPanel1_SizeChanged);
			' 
			' gbProducts
			' 
			Me.gbProducts.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.gbProducts.Controls.Add(Me.gridViewProducts)
			Me.gbProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gbProducts.FooterImageIndex = -1
			Me.gbProducts.FooterImageKey = ""
			Me.gbProducts.HeaderImageIndex = -1
			Me.gbProducts.HeaderImageKey = ""
			Me.gbProducts.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.gbProducts.HeaderText = "Products"
			Me.gbProducts.Location = New System.Drawing.Point(103, 97)
			Me.gbProducts.Name = "gbProducts"
			Me.gbProducts.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
			' 
			' 
			' 
			Me.gbProducts.RootElement.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
			Me.gbProducts.Size = New System.Drawing.Size(200, 525)
			Me.gbProducts.TabIndex = 0
			Me.gbProducts.Text = "Products"
			' 
			' gridViewProducts
			' 
			Me.gridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridViewProducts.Location = New System.Drawing.Point(10, 25)
			' 
			' 
			' 
			Me.gridViewProducts.MasterTemplate.AllowAddNewRow = False
			Me.gridViewProducts.MasterTemplate.EnableGrouping = False
			Me.gridViewProducts.Name = "gridViewProducts"
			Me.gridViewProducts.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.gridViewProducts.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.gridViewProducts.ShowGroupPanel = False
			Me.gridViewProducts.Size = New System.Drawing.Size(180, 490)
			Me.gridViewProducts.TabIndex = 0
			Me.gridViewProducts.Text = "radGridView1"
			' 
			' gbBasket
			' 
			Me.gbBasket.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.gbBasket.Controls.Add(Me.gridBasket)
			Me.gbBasket.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gbBasket.FooterImageIndex = -1
			Me.gbBasket.FooterImageKey = ""
			Me.gbBasket.HeaderImageIndex = -1
			Me.gbBasket.HeaderImageKey = ""
			Me.gbBasket.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.gbBasket.HeaderText = "Basket"
			Me.gbBasket.Location = New System.Drawing.Point(330, 97)
			Me.gbBasket.Name = "gbBasket"
			Me.gbBasket.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
			' 
			' 
			' 
			Me.gbBasket.RootElement.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
			Me.gbBasket.Size = New System.Drawing.Size(200, 525)
			Me.gbBasket.TabIndex = 1
			Me.gbBasket.Text = "Basket"
			' 
			' gridBasket
			' 
			Me.gridBasket.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridBasket.Location = New System.Drawing.Point(10, 25)
			' 
			' 
			' 
			Me.gridBasket.MasterTemplate.AllowAddNewRow = False
			Me.gridBasket.MasterTemplate.EnableGrouping = False
			Me.gridBasket.Name = "gridBasket"
			Me.gridBasket.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.gridBasket.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.gridBasket.ShowGroupPanel = False
			Me.gridBasket.Size = New System.Drawing.Size(180, 490)
			Me.gridBasket.TabIndex = 0
			Me.gridBasket.Text = "radGridView2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Banana.png")
			Me.imageList1.Images.SetKeyName(1, "Eggplant.png")
			Me.imageList1.Images.SetKeyName(2, "Mushroom.png")
			Me.imageList1.Images.SetKeyName(3, "Onion.png")
			Me.imageList1.Images.SetKeyName(4, "Pear.png")
			Me.imageList1.Images.SetKeyName(5, "Watermelon.png")
			Me.imageList1.Images.SetKeyName(6, "full-basket-icon.png")
			' 
			' btnCheckoutSelectedProducts
			' 
			Me.btnCheckoutSelectedProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnCheckoutSelectedProducts.Location = New System.Drawing.Point(10, 66)
			Me.btnCheckoutSelectedProducts.Name = "btnCheckoutSelectedProducts"
			Me.btnCheckoutSelectedProducts.Size = New System.Drawing.Size(180, 24)
			Me.btnCheckoutSelectedProducts.TabIndex = 1
			Me.btnCheckoutSelectedProducts.Text = "Checkout Selected Products"
'			Me.btnCheckoutSelectedProducts.Click += New System.EventHandler(Me.btnCheckoutSelectedProducts_Click);
			' 
			' btnCheckoutAllProducts
			' 
			Me.btnCheckoutAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnCheckoutAllProducts.Location = New System.Drawing.Point(10, 96)
			Me.btnCheckoutAllProducts.Name = "btnCheckoutAllProducts"
			Me.btnCheckoutAllProducts.Size = New System.Drawing.Size(180, 24)
			Me.btnCheckoutAllProducts.TabIndex = 2
			Me.btnCheckoutAllProducts.Text = "Checkout All Products"
'			Me.btnCheckoutAllProducts.Click += New System.EventHandler(Me.btnCheckoutAllProducts_Click);
			' 
			' btnReturnSelectedProducts
			' 
			Me.btnReturnSelectedProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnReturnSelectedProducts.Location = New System.Drawing.Point(10, 126)
			Me.btnReturnSelectedProducts.Name = "btnReturnSelectedProducts"
			Me.btnReturnSelectedProducts.Size = New System.Drawing.Size(180, 24)
			Me.btnReturnSelectedProducts.TabIndex = 3
			Me.btnReturnSelectedProducts.Text = "Return Selected Products "
'			Me.btnReturnSelectedProducts.Click += New System.EventHandler(Me.btnReturnSelectedProducts_Click);
			' 
			' btnReturnAllProducts
			' 
			Me.btnReturnAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.btnReturnAllProducts.Location = New System.Drawing.Point(10, 156)
			Me.btnReturnAllProducts.Name = "btnReturnAllProducts"
			Me.btnReturnAllProducts.Size = New System.Drawing.Size(180, 24)
			Me.btnReturnAllProducts.TabIndex = 4
			Me.btnReturnAllProducts.Text = "Return All Products"
'			Me.btnReturnAllProducts.Click += New System.EventHandler(Me.btnReturnAllProducts_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(945, 725)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.gbProducts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbProducts.ResumeLayout(False)
			CType(Me.gridViewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gbBasket, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbBasket.ResumeLayout(False)
			CType(Me.gridBasket.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridBasket, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnCheckoutSelectedProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnCheckoutAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnReturnSelectedProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnReturnAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radPanel1 As Telerik.WinControls.UI.RadPanel
		Private gbProducts As Telerik.WinControls.UI.RadGroupBox
		Private gbBasket As Telerik.WinControls.UI.RadGroupBox
		Private gridViewProducts As Telerik.WinControls.UI.RadGridView
		Private gridBasket As Telerik.WinControls.UI.RadGridView
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents btnReturnSelectedProducts As Telerik.WinControls.UI.RadButton
		Private WithEvents btnCheckoutAllProducts As Telerik.WinControls.UI.RadButton
		Private WithEvents btnCheckoutSelectedProducts As Telerik.WinControls.UI.RadButton
		Private WithEvents btnReturnAllProducts As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
