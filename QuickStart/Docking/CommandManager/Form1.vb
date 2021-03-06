Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.CommandManager
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.InitCustomCommands()
			Me.BuildCommandList()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub InitCustomCommands()
			Dim command As New CustomCommand(Me.radDock1)
			command.Name = "Custom Command 1"
			Me.radDock1.CommandManager.RegisterCommand(command)
		End Sub

		Private Sub BuildCommandList()
			Me.commandList.BeginUpdate()
			Me.commandList.Items.Clear()

			For Each command As RadDockCommand In Me.radDock1.CommandManager.Commands
				Dim item As New RadListDataItem(command.Name, command)
				Me.commandList.Items.Add(item)
			Next command

			If Me.commandList.Items.Count > 0 Then
				Me.commandList.SelectedIndex = 0
			End If

			Me.commandList.EndUpdate()
		End Sub

		Private Sub enableManager_ToggleStateChanged(ByVal sender As Object, ByVal args As Global.Telerik.WinControls.UI.StateChangedEventArgs) Handles enableManager.ToggleStateChanged
			Me.radDock1.CommandManager.Enabled = args.ToggleState = Global.Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub executeCommand_Click(ByVal sender As Object, ByVal e As EventArgs) Handles executeCommand.Click
			Dim command As RadDockCommand = Me.SelectedCommand
			If command IsNot Nothing Then
				Me.radDock1.CommandManager.ExecuteCommand(command.Name)
			End If
		End Sub

		Private ReadOnly Property SelectedCommand() As RadDockCommand
			Get
				Dim item As RadListDataItem = TryCast(Me.commandList.SelectedItem, RadListDataItem)
				If item IsNot Nothing Then
					Return TryCast(item.Value, RadDockCommand)
				End If

				Return Nothing
			End Get
		End Property

		#Region "Nested Types"

		Private Class CustomCommand
			Inherits RadDockCommand
			Private owner As RadDock
			Public Sub New(ByVal owner As RadDock)
				Me.owner = owner
				Me.Shortcuts.Add(New RadShortcut(Keys.Alt, Keys.R))
			End Sub

			Public Overrides Overloads Function Execute(ParamArray ByVal settings() As Object) As Object
				MessageBox.Show("Displayed custom command.", "RadDock.CommandManager")
				Return Nothing
			End Function
		End Class

		#End Region
	End Class
End Namespace
