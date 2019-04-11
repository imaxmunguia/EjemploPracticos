Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.RadScheduler.Reminder
	Partial Public Class CustomAlarmForm
		Inherits Telerik.WinControls.UI.RadForm
		Implements IAlarmForm
		Private reminderBindableObjects As BindingList(Of RadReminderBindableObject)
		Private startNotification_Renamed As New TimeSpan(0, 15, 0)

		Public Sub New()
			InitializeComponent()
			Me.reminderBindableObjects = New BindingList(Of RadReminderBindableObject)()

			Me.radListBox1.DisplayMember = "Subject"
			Me.radListBox1.ValueMember = "Subject"
			Me.radListBox1.DataSource = Me.reminderBindableObjects
		End Sub

		Private Sub CustomAlarmForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			Me.Owner = Nothing
			If e.CloseReason <> CloseReason.ApplicationExitCall AndAlso e.CloseReason <> CloseReason.FormOwnerClosing AndAlso e.CloseReason <> CloseReason.WindowsShutDown Then
				e.Cancel = True
				Me.Hide()
			End If
		End Sub

		#Region "IAlarmForm Members"
		Public Event ItemOpened As EventHandler(Of RadOpenItemArgs) Implements IAlarmForm.ItemOpened

		''' <summary>
		''' Gets the remind objects count.
		''' </summary>
		''' <value>The reminder bindable objects count.</value>
		Public Overridable ReadOnly Property RemindObjectsCount() As Integer Implements IAlarmForm.RemindObjectsCount
			Get
				Return Me.reminderBindableObjects.Count
			End Get
		End Property

		''' <summary>
		''' Determines whether [contains reminder bindable object] [the specified reminder bindable object].
		''' </summary>
		''' <param name="reminderBindableObject">The remind bindable object.</param>
		''' <returns>
		''' 	<c>true</c> if [contains reminder bindable object] [the specified reminder bindable object]; otherwise, <c>false</c>.
		''' </returns>
		Public Overridable Function ContainsRemindObject(ByVal reminderBindableObject As RadReminderBindableObject) As Boolean Implements IAlarmForm.ContainsRemindObject
			Return Me.reminderBindableObjects.Contains(reminderBindableObject)
		End Function

		''' <summary>
		''' Adds the reminder bindable object.
		''' </summary>
		''' <param name="reminderBindableObject">The reminder bindable object.</param>
		Public Overridable Sub AddRemindObject(ByVal reminderBindableObject As RadReminderBindableObject) Implements IAlarmForm.AddRemindObject
			Me.reminderBindableObjects.Insert(0, reminderBindableObject)
		End Sub

		''' <summary>
		''' Removes the reminder bindable object.
		''' </summary>
		''' <param name="reminderBindableObject">The reminder bindable object.</param>
		''' <returns></returns>
		Public Overridable Function RemoveRemindObject(ByVal reminderBindableObject As RadReminderBindableObject) As Boolean Implements IAlarmForm.RemoveRemindObject
			Dim res As Boolean = Me.reminderBindableObjects.Remove(reminderBindableObject)

			If Me.reminderBindableObjects.Count < 1 Then
				Me.Hide()
			End If

			Return res
		End Function

		''' <summary>
		''' Shows the form.
		''' </summary>
		Public Overridable Sub ShowForm() Implements IAlarmForm.ShowForm
			If (Not Me.Visible) Then
				Me.Show()
			End If
		End Sub

		''' <summary>
		''' Shows the form.
		''' </summary>
		''' <param name="owner">The owner.</param>
		Public Overridable Sub ShowForm(ByVal owner As IWin32Window) Implements IAlarmForm.ShowForm
			If (Not Me.Visible) Then
				Me.Show(owner)
			End If
		End Sub

		''' <summary>
		''' In this override we reset the RootElement's BackColor property
		''' since the DocumentDesigner class sets the BackColor of the
		''' Form to Control when initializing and thus overrides the theme.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.UpdateDialogLocalization()
		End Sub

		''' <summary>
		''' Updates the dialog localization.
		''' </summary>
		Public Sub UpdateDialogLocalization()
			'Apply the current localization provider.
		End Sub

		''' <summary>
		''' Gets or sets the start notification.
		''' </summary>
		''' <value>The start notification.</value>
		Public Property StartNotification() As TimeSpan Implements IAlarmForm.StartNotification
			Get
				Return Me.startNotification_Renamed
			End Get
			Set(ByVal value As TimeSpan)
				Me.startNotification_Renamed = value
			End Set
		End Property

		''' <summary>
		''' Clears the remind objects.
		''' </summary>
		Public Sub ClearRemindObjects() Implements IAlarmForm.ClearRemindObjects
			Me.reminderBindableObjects.Clear()
		End Sub

		''' <summary>
		''' Hides the form.
		''' </summary>
		Public Sub HideForm() Implements IAlarmForm.HideForm
			Me.Hide()
		End Sub

        Public Overloads Property ThemeName() As String Implements IAlarmForm.ThemeName
            Get
                ThemeName = MyBase.ThemeName
            End Get
            Set(ByVal value As String)
                MyBase.ThemeName = value
            End Set
        End Property
		#End Region

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			For Each item As RadListDataItem In Me.radListBox1.SelectedItems
				Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
				Me.OnItemOpened(reminderBindableObject.RemindObject)
			Next item
		End Sub

		Private Sub OnItemOpened(ByVal remidableObject As IRemindObject)
			If Me.ItemOpenedEvent IsNot Nothing Then
				RaiseEvent ItemOpened(Me, New RadOpenItemArgs(remidableObject))
			End If
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Dim selectedIndexes As List(Of Integer) = Me.GetSelectedIndexes()
			For i As Integer = selectedIndexes.Count - 1 To 0 Step -1
				Dim selectedIndex As Integer = selectedIndexes(i)
				Dim item As RadListDataItem = Me.radListBox1.Items(selectedIndex)
				Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
				Dim snooze As TimeSpan = DateTime.Now.Subtract(reminderBindableObject.StartDateTime)
				reminderBindableObject.Snoozed = Me.startNotification_Renamed + snooze + (New TimeSpan(0, 1, 0))
				Me.RemoveRemindObject(reminderBindableObject)
			Next i

			EnableButtons()
		End Sub

		Private Function GetSelectedIndexes() As List(Of Integer)
			Dim resList As List(Of Integer) = New List(Of Integer)()
			For Each item As RadListDataItem In Me.radListBox1.SelectedItems
				resList.Add(Me.radListBox1.Items.IndexOf(item))
			Next item
			resList.Sort()
			Return resList
		End Function

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton3.Click
			Dim selectedIndexes As List(Of Integer) = Me.GetSelectedIndexes()
			For i As Integer = selectedIndexes.Count - 1 To 0 Step -1
				Dim selectedIndex As Integer = selectedIndexes(i)
				Dim item As RadListDataItem = Me.radListBox1.Items(selectedIndex)
				DismissItem(item)
			Next i

			EnableButtons()
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton4.Click
			For i As Integer = Me.radListBox1.Items.Count - 1 To 0 Step -1
				Dim item As RadListDataItem = Me.radListBox1.Items(i)
				DismissItem(item)
			Next i

			EnableButtons()
		End Sub

		Private Sub DismissItem(ByVal item As RadListDataItem)
			Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
			reminderBindableObject.Dismissed = True
			Me.RemoveRemindObject(reminderBindableObject)
		End Sub

		Private Sub EnableButtons()
			Dim enableButtons As Boolean = (Me.radListBox1.SelectedItems.Count > 0)
			Me.radButton3.Enabled = enableButtons
			Me.radButton2.Enabled = enableButtons
			Me.radButton1.Enabled = enableButtons

			Me.radButton4.Enabled = (Me.radListBox1.Items.Count > 0)
		End Sub

		Private Sub radListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radListBox1.SelectedIndexChanged
			EnableButtons()
		End Sub

		Protected Overrides Sub OnThemeChanged()
			MyBase.OnThemeChanged()

			ThemeResolutionService.ApplyThemeToControlTree(Me, Me.ThemeName)
		End Sub
	End Class
End Namespace
