Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports System.Xml
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls.UI
Imports System.Xml.XPath
Imports Telerik.QuickStart.WinControls
Imports System.IO
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ImagesAndMultiline
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private dropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()

			Me.dropDownTimeout = New Timer(Me.components)
			Me.dropDownTimeout.Interval = 1000
			AddHandler dropDownTimeout.Tick, AddressOf OnDropDownTimeout_Tick

			Me.radComboDemo.ListElement.AutoSizeItems = True
			Me.radComboDemo.DropDownMinSize = New Size(0, 200)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)

			RemoveHandler dropDownTimeout.Tick, AddressOf OnDropDownTimeout_Tick
		End Sub

		Private Sub radComboDemo_ItemDataBound(ByVal sender As Object, ByVal e As ListItemDataBoundEventArgs) Handles radComboDemo.ItemDataBound
			Dim item As RadListDataItem = e.NewItem
			item.Text &= " " & (TryCast(item.DataBoundItem, DataRowView))("FirstName")

			Dim row As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow = TryCast((TryCast(item.DataBoundItem, DataRowView)).Row, Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow)
			item.Image = GetImageFromData(row.Photo)

			item.Font = New Font("Arial", 10, FontStyle.Bold)
		End Sub

		Private Function GetImageFromData(ByVal imageData() As Byte) As Image
			Const OleHeaderLength As Integer = 78
			Dim memoryStream As New MemoryStream()
			If HasOleContainerHeader(imageData) Then
				memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength)
			Else
				memoryStream.Write(imageData, 0, imageData.Length)
			End If
			Dim bitmap As New Bitmap(memoryStream)
			Return bitmap.GetThumbnailImage(55, 65, Nothing, New IntPtr())
		End Function

		Private Function HasOleContainerHeader(ByVal imageByteArray() As Byte) As Boolean
			Const OleByte0 As Byte = 21
			Const OleByte1 As Byte = 28
			Return (imageByteArray(0) = OleByte0) AndAlso (imageByteArray(1) = OleByte1)
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.LoadData()
			MyBase.OnLoad(e)
		End Sub

		Private Sub LoadData()
			Try
				Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Catch exception1 As Exception
				Dim message As String = "To run this sample, you must have SQL Server with the Northwind database installed."
				Throw New DataException(message, exception1)
			End Try
		End Sub

		Private Sub LoadAnimationSettings()
			Me.radComboDropDownAnim.DataSource = System.Enum.GetValues(GetType(RadEasingType))
		End Sub

		Private Sub LoadInitialSettings()
			Me.radComboDropDownStyle.SelectedIndex = 0
			Me.radComboDemo.DropDownAnimationFrames = 50
		End Sub

		#Region "Event handling"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Me.SelectedControl = Me.radComboDemo
			Me.LoadAnimationSettings()
			Me.LoadInitialSettings()
			Me.dropDownTimeout.Start()
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboDemo.SelectedIndexChanged
			If radComboDemo.SelectedIndex <> -1 Then
				radTxtIndex.Text = radComboDemo.SelectedIndex.ToString()
				Dim item As RadListDataItem = radComboDemo.SelectedItem
				radTxtText.Text = item.Text
				radComboImageAlignment.SelectedIndex = radComboImageAlignment.ListElement.FindString(item.ImageAlignment.ToString())
				radComboTextAlignment.SelectedIndex = radComboTextAlignment.ListElement.FindString(item.TextAlignment.ToString())
				radComboTextImageRel.SelectedIndex = radComboTextImageRel.ListElement.FindString(item.TextImageRelation.ToString())
			End If
		End Sub

		Private Sub comboDropDownStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboDropDownStyle.SelectedIndexChanged
			radComboDemo.DropDownStyle = CType(Me.radComboDropDownStyle.SelectedIndex + 1, RadDropDownStyle)
		End Sub

		Private Sub comboImageAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboImageAlignment.SelectedIndexChanged
			Dim item As RadListDataItem = radComboDemo.SelectedItem
			If item Is Nothing Then
				Return
			End If
			Select Case Me.radComboImageAlignment.Text
				Case "TopLeft"
					item.ImageAlignment = ContentAlignment.TopLeft
				Case "TopCenter"
					item.ImageAlignment = ContentAlignment.TopCenter
				Case "TopRight"
					item.ImageAlignment = ContentAlignment.TopRight
				Case "MiddleLeft"
					item.ImageAlignment = ContentAlignment.MiddleLeft
				Case "MiddleCenter"
					item.ImageAlignment = ContentAlignment.MiddleCenter
				Case "MiddleRight"
					item.ImageAlignment = ContentAlignment.MiddleRight
				Case "BottomLeft"
					item.ImageAlignment = ContentAlignment.BottomLeft
				Case "BottomCenter"
					item.ImageAlignment = ContentAlignment.BottomCenter
				Case "BottomRight"
					item.ImageAlignment = ContentAlignment.BottomRight
			End Select
		End Sub

		Private Sub comboTextAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboTextAlignment.SelectedIndexChanged
			Dim item As RadListDataItem = radComboDemo.SelectedItem

			If item Is Nothing Then
				Return
			End If

			Select Case Me.radComboTextAlignment.Text
				Case "TopLeft"
					item.TextAlignment = ContentAlignment.TopLeft
				Case "TopCenter"
					item.TextAlignment = ContentAlignment.TopCenter
				Case "TopRight"
					item.TextAlignment = ContentAlignment.TopRight
				Case "MiddleLeft"
					item.TextAlignment = ContentAlignment.MiddleLeft
				Case "MiddleCenter"
					item.TextAlignment = ContentAlignment.MiddleCenter
				Case "MiddleRight"
					item.TextAlignment = ContentAlignment.MiddleRight
				Case "BottomLeft"
					item.TextAlignment = ContentAlignment.BottomLeft
				Case "BottomCenter"
					item.TextAlignment = ContentAlignment.BottomCenter
				Case "BottomRight"
					item.TextAlignment = ContentAlignment.BottomRight
			End Select
		End Sub

		Private Sub comboTextImageRel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboTextImageRel.SelectedIndexChanged
			Dim item As RadListDataItem = radComboDemo.SelectedItem
			If item Is Nothing Then
				Return
			End If
			Select Case Me.radComboTextImageRel.SelectedText
				Case "ImageAboveText"
						item.TextImageRelation = TextImageRelation.ImageAboveText
						Exit Select
				Case "ImageBeforeText"
						item.TextImageRelation = TextImageRelation.ImageBeforeText
						Exit Select
				Case "TextAboveImage"
						item.TextImageRelation = TextImageRelation.TextAboveImage
						Exit Select
				Case "TextBeforeImage"
						item.TextImageRelation = TextImageRelation.TextBeforeImage
						Exit Select
				Case "Overlay"
						item.TextImageRelation = TextImageRelation.Overlay
						Exit Select
			End Select
		End Sub

		Private Sub tBoxText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radComboDemo.SelectedItem
			If (item IsNot Nothing) AndAlso (item.Text <> radTxtText.Text) Then
				radComboDemo.SelectedItem.Text = radTxtText.Text
			End If
		End Sub
		Private Sub OnRadComboAnimType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboDropDownAnim.SelectedIndexChanged
			If (Not Me.radComboDemo.DropDownAnimationEnabled) Then
				Me.radComboDemo.DropDownAnimationEnabled = True
			End If

			If Me.radComboDropDownAnim.SelectedItem IsNot Nothing Then
				Me.radComboDemo.DropDownAnimationEasing = CType(Me.radComboDropDownAnim.SelectedItem.DataBoundItem, RadEasingType)
			End If
		End Sub

		Private Sub OnDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus()
			Me.radComboDemo.ShowDropDown()
			Me.dropDownTimeout.Stop()
		End Sub

		#End Region

		Private Sub OnRadTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTxtText.TextChanged
			Me.radComboDemo.SelectedItem.Text = Me.radTxtText.Text
		End Sub
	End Class
End Namespace
