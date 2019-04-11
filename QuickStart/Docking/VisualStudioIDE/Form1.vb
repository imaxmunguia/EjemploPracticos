Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI.Docking
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.VisualStudioIDE
	Partial Public Class Form1
		Inherits Form
		Private Shared ReadOnly RtfFolder As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docking\VisualStudioIDE\Files")
		Private Shared ReadOnly Form1RftFile As String = Path.Combine(RtfFolder, "Form1.rtf")
		Private Shared ReadOnly Form1DesignerRftFile As String = Path.Combine(RtfFolder, "Form1.Designer.rtf")
		Private Shared ReadOnly OutputFile As String = Path.Combine(RtfFolder, "Output.rtf")

		Private Const ErrorGridRow As Integer = 1
		Private Const ErrorGridLine As Integer = 20
		Private Const ErrorGridColumn As Integer = 33
		Private Const ErrorGridFile As String = "Program.cs"
		Private Const ErrorGridProject As String = "ProjectTracker"
		Private Const ErrorGridDescription As String = "The type or namespace name 'Form12' could not be found (are you missing a using directive or an assembly reference?)	C:\ProjectTracker\Program.cs"

		Private Const TaskGridDescription As String = "TO DO: Refactor the whole data access layer to use Open Access"
		Private Const TaskGridFile As String = "DBPool.cs"
		Private Const TaskGridLine As Integer = 501


		Public Sub New()
            InitializeComponent()

            Me.radDock1.DockingGuidesTemplate = PredefinedDockingGuidesTemplate.VS2008
            ThemeResolutionService.LoadPackageResource("VisualStudio2008.tssp")
            Me.radDock1.ThemeName = "VisualStudio2008"
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.SetupAllGrids()
			Me.SetupToolWindowImages()

			Me.richTextBoxForm.Rtf = Me.ReadFile(Form1RftFile)
			Me.richTextBoxDesigner.Rtf = Me.ReadFile(Form1DesignerRftFile)
			Me.richTextBoxOutput.Rtf = Me.ReadFile(OutputFile)
		End Sub

		Private Sub SetupToolWindowImages()
			toolWindow5.Image = ImageList.Images(1)
			toolWindow3.Image = ImageList.Images(5)
			toolWindow4.Image = ImageList.Images(14)
		End Sub

		Private Sub SetupAllGrids()
			Me.radGridViewErrors.Columns("columnImage").HeaderText = String.Empty
			Me.radGridViewErrors.Columns("columnNumber").HeaderText = String.Empty

			Me.radGridViewErrors.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Dim image As Image = ImageList.Images(11)

			Me.radGridViewErrors.Rows.Add(image, ErrorGridRow, ErrorGridDescription, ErrorGridFile, ErrorGridLine, ErrorGridColumn, ErrorGridProject)
			Me.radGridViewErrors.MasterTemplate.ShowRowHeaderColumn = False

			Me.radGridViewTasks.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridViewTasks.Rows.Add(String.Empty, TaskGridDescription, TaskGridFile, TaskGridLine)
			Me.radGridViewTasks.MasterTemplate.ShowRowHeaderColumn = False
		End Sub

		Private Function ReadFile(ByVal filePath As String) As String
			If (Not File.Exists(filePath)) Then
				Throw New FileNotFoundException(filePath)
			End If

			Return File.ReadAllText(filePath)
		End Function

	End Class
End Namespace
