Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System

Namespace Telerik.Examples.WinControls.Editors.TimePicker
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private timer As New Timer()

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTimePicker1
			SetEnabledQsfbButton(QuickStart.WinControls.QSFButtons.ChangeTheme, True)

			Me.radClock1.ShowSystemTime = False

			AddHandler timer.Tick, New EventHandler(AddressOf timer_Tick)
			timer.Interval = 1000
		End Sub

		Private Sub SynchronizeTime()
			Dim currentTime As DateTime = CType(Me.radClock1.Value, DateTime)
			currentTime = currentTime.AddSeconds(1)
			Me.radLabelDate.Text = currentTime.ToLongDateString()
			Me.radClock1.Value = currentTime
			If Me.radTimePicker1.Value.Value.Minute <> currentTime.Minute OrElse Me.radTimePicker1.Value.Value.Hour <> currentTime.Hour Then
				Me.radTimePicker1.Value = currentTime
			End If
		End Sub

		Private Sub timer_Tick(sender As Object, e As EventArgs)  
			SynchronizeTime()
		End Sub

		Private Sub radPageView1_SelectedPageChanging(sender As Object, e As Telerik.WinControls.UI.RadPageViewCancelEventArgs) handles radPageView1.SelectedPageChanging
			if e.Page isnot radPageViewPage1 then
				e.Cancel = True
			End If

		End Sub

		Private Sub radTimePicker1_ValueChanged(sender As Object, e As EventArgs) handles radTimePicker1.ValueChanged
			Me.radClock1.Value = Me.radTimePicker1.Value
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) handles radCheckBox1.ToggleStateChanged
			Me.radTimePicker1.[ReadOnly] = Me.radCheckBox1.IsChecked
		End Sub

		Private Sub TablesDropDownList_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) handles TablesDropDownList.SelectedIndexChanged
			Me.radTimePicker1.TimeTables = DirectCast(e.Position, TimeTables)
		End Sub

		Private Sub ClockPossitionDropDownList_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) handles ClockPossitionDropDownList.SelectedIndexChanged
			Me.radTimePicker1.ClockPosition = DirectCast(e.Position, ClockPosition)
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs) handles Me.Load
			TablesDropDownList.SelectedIndex = 1
			ClockPossitionDropDownList.SelectedIndex = 0

			Dim currentTime As DateTime = DateTime.Now
			Me.radTimePicker1.Value = currentTime

			SynchronizeTime()
			timer.Start()

			Try
				Dim timeZoneInfoKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\TimeZoneInformation")
				If timeZoneInfoKey IsNot Nothing Then
					Dim timeZoneKeyName As Object = timeZoneInfoKey.GetValue("TimeZoneKeyName")
					If timeZoneKeyName IsNot Nothing Then
						Dim timeZoneNameKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Time Zones\" & Convert.ToString(timeZoneKeyName))
						If timeZoneKeyName IsNot Nothing Then
							Dim displayName As Object = timeZoneNameKey.GetValue("Display")
							If displayName IsNot Nothing Then
								radLabelTimeZone.Text = displayName.ToString()
								Return
							End If
						End If
					End If
				End If
			Catch
			End Try

			Dim localZone As TimeZone = TimeZone.CurrentTimeZone
			Dim hours As Integer = localZone.GetUtcOffset(currentTime).Hours
			radLabelTimeZone.Text = "UTC" & (If(hours > 0, "+", "-")) & Math.Abs(hours).ToString()
		End Sub

        Private Sub Form1_Disposed(sender As Object, e As EventArgs) handles Me.Disposed
            timer.Stop()
            timer.Dispose()
        End Sub
	End Class
End Namespace
