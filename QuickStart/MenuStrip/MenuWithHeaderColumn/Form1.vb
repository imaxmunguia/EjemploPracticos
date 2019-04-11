Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Properties
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"
		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radMenuItem1.DropDown.HeaderText = "RadMenuStrip Header"
			Me.radMenuItem1.DropDown.HeaderImage = My.Resources.telerikLogo1
			Dim popupElement As RadDropDownMenuElement = TryCast(Me.radMenuItem1.DropDown.PopupElement, RadDropDownMenuElement)
			If popupElement IsNot Nothing Then
				popupElement.HeaderColumn.TextImageRelation = TextImageRelation.ImageBeforeText
				popupElement.HeaderColumnBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
				popupElement.HeaderColumnFill.BackColor = Color.FromArgb(238, 238, 213)
				popupElement.HeaderColumnFill.BackColor2 = Color.FromArgb(153, 208, 221)
				popupElement.HeaderColumnFill.NumberOfColors = 2
				popupElement.HeaderColumnText.ForeColor = Color.White
				popupElement.HeaderColumn.TextAlignment = ContentAlignment.MiddleLeft
				popupElement.HeaderColumnText.Font = New Font("Comic Sans", 16f, FontStyle.Bold)
			End If
		End Sub
	End Class
End Namespace
