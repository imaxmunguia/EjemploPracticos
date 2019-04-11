Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Namespace Telerik.Examples.WinControls.Editors.ComboBox
	Partial Public Class EditorExampleBaseForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			Me.roudRectShape = New Telerik.WinControls.RoundRectShape(Me.components)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(716, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 598)
			Me.settingsPanel.ThemeName = MainForm.DefaultTheme
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(277, 250)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(200, 100)
			Me.radPanelDemoHolder.TabIndex = 1
			CType(Me.radPanelDemoHolder.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roudRectShape
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3F
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.01F
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(162))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(254))))))
			' 
			' roudRectShape
			' 
			Me.roudRectShape.Radius = 10
			' 
			' EditorExampleBaseForm
			' 
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.Name = "EditorExampleBaseForm"
			Me.Size = New System.Drawing.Size(917, 600)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected roudRectShape As Telerik.WinControls.RoundRectShape
		Protected radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace