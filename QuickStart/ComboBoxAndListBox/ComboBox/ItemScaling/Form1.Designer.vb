Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
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
			Me.components = New Container()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem10 = New Telerik.WinControls.UI.RadListDataItem()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(240, 272)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(642, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Items.AddRange(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem3, Me.radComboBoxItem4, Me.radComboBoxItem5, Me.radComboBoxItem6, Me.radComboBoxItem7, Me.radComboBoxItem8, Me.radComboBoxItem9, Me.radComboBoxItem10})
			Me.radComboDemo.Location = New System.Drawing.Point(19, 40)
			Me.radComboDemo.Name = "radComboDemo"
			Me.radComboDemo.NullText = "Select Car..."
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(324, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			' 
			' radComboBoxItem1
			' 
			'this.radComboBoxItem1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem1.Image = Me.GetImageFromResource("SSC Ultimate Aero.png")
			Me.radComboBoxItem1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
			'this.radComboBoxItem1.Name = "radComboBoxItem1";
			Me.radComboBoxItem1.Text = "SSC Ultimate Aero"
		   ' this.radComboBoxItem1.DescriptionText = "<html><size=9><font=Arial><b>Maximum Speed: </b>257 <i>mph</i><br><size=9><font=Arial><b>Horse Power:</b>1,187 <i>bhp</i>";
			'this.radComboBoxItem1.DescriptionText = "<html><p><span style=\"font-size: large\">RadLabel</span></p><p><span style=\"font-size: medium\"><strong>Arial, Bold</strong></span></p><p><span style=\"font-size: 18px\"><em><span style=\"font-family: times new roman\">Times, Italic, <u>Underline</u></span></em></span></p><p><em><span style=\"font-family: times new roman; color: #0080ff; font-size: 18px\">Sample Text</span></em></p></html>";
			Me.radComboBoxItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radComboBoxItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage

			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Image = Me.GetImageFromResource("Bugatti Veyron.png")
			Me.radComboBoxItem2.Text = "Bugatti Veyron"
			Me.radComboBoxItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radComboBoxItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage

			' 
			' radComboBoxItem3
			' 
			'this.radComboBoxItem3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem3.Image = Me.GetImageFromResource("Koenigsegg CCX.png")
			'this.radComboBoxItem3.Name = "radComboBoxItem3";
			Me.radComboBoxItem3.Text = "Koenigsegg CCX"
			Me.radComboBoxItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			'this.radComboBoxItem3.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>250 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>806 <i>bhp</i>";
			Me.radComboBoxItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			'this.radComboBoxItem3.ToolTipText = null;
			' 
			' radComboBoxItem4
			' 
			'this.radComboBoxItem4.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem4.Image = Me.GetImageFromResource("Saleen S7 Twin-Turbo.png")
			'this.radComboBoxItem4.Name = "radComboBoxItem4";
			Me.radComboBoxItem4.Text = "Saleen S7 Twin-Turbo"
			Me.radComboBoxItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			'this.radComboBoxItem4.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>248 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>750 <i>bhp</i>";
			Me.radComboBoxItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			'this.radComboBoxItem4.ToolTipText = null;
			' 
			' radComboBoxItem5
			' 
			'this.radComboBoxItem5.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem5.Image = Me.GetImageFromResource("McLaren F1.png")
			'this.radComboBoxItem5.Name = "radComboBoxItem5";
			Me.radComboBoxItem5.Text = "McLaren F1"
			'this.radComboBoxItem5.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>240 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>627 <i>bhp</i>";
			Me.radComboBoxItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			Me.radComboBoxItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			'this.radComboBoxItem5.ToolTipText = null;
			' 
			' radComboBoxItem6
			' 
			'this.radComboBoxItem6.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem6.Image = Me.GetImageFromResource("Ferrari Enzo.png")
			'this.radComboBoxItem6.Name = "radComboBoxItem6";
			Me.radComboBoxItem6.Text = "Ferrari Enzo"
			'this.radComboBoxItem6.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>217 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>660 <i>bhp</i>";
			Me.radComboBoxItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			Me.radComboBoxItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			'this.radComboBoxItem6.ToolTipText = null;
			' 
			' radComboBoxItem7
			' 
			'this.radComboBoxItem7.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem7.Image = Me.GetImageFromResource("Jaguar XJ220.png")
			'this.radComboBoxItem7.Name = "radComboBoxItem7";
			Me.radComboBoxItem7.Text = "Jaguar XJ220"
			'this.radComboBoxItem7.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>217 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>542 <i>bhp</i>";
			Me.radComboBoxItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			Me.radComboBoxItem7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			'this.radComboBoxItem7.ToolTipText = null;
			' 
			' radComboBoxItem8
			'
			'this.radComboBoxItem8.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>219 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>550 <i>bhp</i>";
			'this.radComboBoxItem8.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem8.Image = Me.GetImageFromResource("Lamborghini Murcielago LP640.png")
			'this.radComboBoxItem8.Name = "radComboBoxItem10";
			Me.radComboBoxItem8.Text = "Lamborghini Murcielago"
			Me.radComboBoxItem8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radComboBoxItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			'this.radComboBoxItem8.ToolTipText = null;
			' 
			' radComboBoxItem9
			' 
			'this.radComboBoxItem9.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>215 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>650 <i>bhp</i>";
			'this.radComboBoxItem9.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem9.Image = Me.GetImageFromResource("Pagani Zonda F.png")
			'this.radComboBoxItem9.Name = "radComboBoxItem9";
			Me.radComboBoxItem9.Text = "Pagani Zonda F"
			Me.radComboBoxItem9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radComboBoxItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			'this.radComboBoxItem9.ToolTipText = null;
			' 
			' radComboBoxItem10
			' 
			'this.radComboBoxItem10.DescriptionText = "<html><b><size=9><font=Arial>Maximum Speed: </b>215 <i>mph</i><br><size=9><font=Arial><b>Horse Power:   </b>650 <i>bhp</i>";
			'this.radComboBoxItem10.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
			Me.radComboBoxItem10.Image = Me.GetImageFromResource("Porsche Carrera GT.png")
			'this.radComboBoxItem10.Name = "radComboBoxItem10";
			Me.radComboBoxItem10.Text = "Porsche Carrera GT"
			Me.radComboBoxItem10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radComboBoxItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
			'this.radComboBoxItem10.ToolTipText = null;
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(843, 643)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem6 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem7 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem8 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem9 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem10 As Telerik.WinControls.UI.RadListDataItem
	End Class
End Namespace

