Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.RadForm
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Dim outlookStyle As RadPageViewOutlookElement = TryCast(Me.radPanelBar1.ViewElement, RadPageViewOutlookElement)
			outlookStyle.HideItems(3)

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
		End Sub

		Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radRibbonBar1.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Hidden

			Dim designerForm As New LayoutProperties()
			designerForm.Owner = Me
			designerForm.Show()

			SetDefaultPanelBorderColors()
		End Sub

		Private Sub SetDefaultPanelBorderColors()
			Me.splitPanel1_Renamed.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel2_Renamed.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel3_Renamed.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel4_Renamed.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			Me.splitPanel5_Renamed.SplitPanelElement.ForeColor = Color.FromArgb(191, 225, 255)
			CType(Me.radPanel1.PanelElement.Children(1), BorderPrimitive).ForeColor = Color.FromArgb(191, 225, 255)
			CType(Me.radPanel2.PanelElement.Children(1), BorderPrimitive).ForeColor = Color.FromArgb(191, 225, 255)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'northwindDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.northwindDataSet.Cars)

		End Sub

		#Region "Split Properties"

		Public ReadOnly Property RadSplitContainer1() As Telerik.WinControls.UI.RadSplitContainer
			Get
				Return Me.radSplitContainer1_Renamed
			End Get
		End Property

		Public ReadOnly Property RadSplitContainer2() As Telerik.WinControls.UI.RadSplitContainer
			Get
				Return Me.radSplitContainer2_Renamed
			End Get
		End Property

		Public ReadOnly Property SplitPanel1() As SplitPanel
			Get
				Return Me.splitPanel1_Renamed
			End Get
		End Property

		Public ReadOnly Property SplitPanel2() As SplitPanel
			Get
				Return Me.splitPanel2_Renamed
			End Get
		End Property

		Public ReadOnly Property SplitPanel3() As SplitPanel
			Get
				Return Me.splitPanel3_Renamed
			End Get
		End Property

		Public ReadOnly Property SplitPanel4() As SplitPanel
			Get
				Return Me.splitPanel4_Renamed
			End Get
		End Property

		Public ReadOnly Property SplitPanel5() As SplitPanel
			Get
				Return Me.splitPanel5_Renamed
			End Get
		End Property

		#End Region

		Private Sub btnOpenDesigner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenDesigner.Click
			For Each OpenForm As Form In Application.OpenForms
				If TypeOf OpenForm Is LayoutProperties Then
					Return
				End If
			Next OpenForm

			Dim designerForm As New LayoutProperties()
			designerForm.Owner = Me
			designerForm.Show()
		End Sub
	End Class
End Namespace