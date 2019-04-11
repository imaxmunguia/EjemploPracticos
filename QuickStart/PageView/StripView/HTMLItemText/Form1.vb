Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.HTMLItemText
	''' <summary>
	''' Example beautifying 
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground Or QSFButtons.ChangeTheme, False)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "Office2010"
		End Function
	End Class
End Namespace