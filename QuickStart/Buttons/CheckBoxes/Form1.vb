Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.radCheckBox1.Font = New Font(New FontFamily("Arial"), 10.0f, GraphicsUnit.Point)
			Me.radCheckBox2.Font = New Font(New FontFamily("Arial"), 12.0f, GraphicsUnit.Point)
			Me.radCheckBox3.Font = New Font(New FontFamily("Arial"), 14.0f, GraphicsUnit.Point)
			Me.radGroupEvents.ForeColor = Color.Black
		End Sub

		Private Sub SetTheme()
			Me.radGroupEvents.ThemeName = "ControlDefault"
			Me.radTextBoxEvents.ThemeName = "ControlDefault"
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBox3.ToggleStateChanged, radCheckBox2.ToggleStateChanged, radCheckBox1.ToggleStateChanged
			Me.radTextBoxEvents.Text += String.Format("{0} toggled" & Environment.NewLine, (TryCast(sender, RadCheckBox)).Text)
			Me.radTextBoxEvents.SelectionStart = Me.radTextBoxEvents.Text.Length
			Me.radTextBoxEvents.ScrollToCaret()
		End Sub
	End Class
End Namespace