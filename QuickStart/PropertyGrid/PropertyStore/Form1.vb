Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
	Public Partial Class Form1
		Inherits ExamplesForm
		Private store As RadPropertyStore
		Private championships As List(Of Championship)
		Private progressBars As List(Of RadProgressBar)

		Public Sub New()
			InitializeComponent()

            Me.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden
            Me.RadPanelCars.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden

			Me.store = Me.CreatePropertyStore()
			Me.championships = Me.CreateChampionships()
            Me.progressBars = New List(Of RadProgressBar)()
            Me.progressBars.Add(Me.radProgressBar1)
            Me.progressBars.Add(Me.radProgressBar2)
            Me.progressBars.Add(Me.radProgressBar3)
            Me.progressBars.Add(Me.radProgressBar4)
            Me.progressBars.Add(Me.radProgressBar5)

			Me.radPropertyGrid1.SelectedObject = store
            Me.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical

			Me.ProcessProgressBarValues()

			AddHandler radPropertyGrid1.EditorInitialized, AddressOf radPropertyGrid1_EditorInitialized
			AddHandler radPropertyGrid1.PropertyValueChanged, AddressOf radPropertyGrid1_PropertyValueChanged
        End Sub

        Protected Overrides Sub OnLoad(e As System.EventArgs)
            MyBase.OnLoad(e)
            ThemeResolutionService.ApplyThemeToControlTree(Me, "TelerikMetro")
        End Sub

		Private Sub radPropertyGrid1_PropertyValueChanged(ByVal sender As Object, ByVal e As PropertyGridItemValueChangedEventArgs)
			Me.ProcessProgressBarValues()
		End Sub

		Private Sub radPropertyGrid1_EditorInitialized(ByVal sender As Object, ByVal e As PropertyGridItemEditorInitializedEventArgs)

			Dim editor As PropertyGridSpinEditor = TryCast(e.Editor, PropertyGridSpinEditor)
			If editor Is Nothing Then
				Return
			End If

			Dim element As BaseSpinEditorElement = TryCast(editor.EditorElement, BaseSpinEditorElement)

			Select Case e.Item.Name
				Case "Displacement"
					element.MinValue = 1
					element.MaxValue = 10000
				Case "Number of seats"
					element.MinValue = 1
					element.MaxValue = 60
				Case "Weight"
					element.MinValue = 1
					element.MaxValue = 10000
			End Select
		End Sub

		Private Function CreatePropertyStore() As RadPropertyStore
			Dim vehicleStore As RadPropertyStore = New RadPropertyStore()

			Dim engineLayout As PropertyStoreItem = New PropertyStoreItem(GetType(EngineLayouts), "Layout", EngineLayouts.I4, "Engine layout is determined by the configuration of the engine pistons.", "Engine")

            Dim engineDisplacement As PropertyStoreItem = New PropertyStoreItem(GetType(Integer), "Displacement", 1600, "Engine displacement is determined from the bore and stroke of the engine's cylinders.", "Engine")

            Dim engineFuel As PropertyStoreItem = New PropertyStoreItem(GetType(Fuels), "Fuel", Fuels.Petrol, "The type of fuel providing the energy source for the engine.", "Engine")

            Dim engineSupercharged As PropertyStoreItem = New PropertyStoreItem(GetType(Boolean), "Turbocharged/Supercharged", True, "Turbocharging/Supercharging is the process of compressing air on the intake of an engine(technical term - Forced induction).", "Engine")

            Dim transmission As PropertyStoreItem = New PropertyStoreItem(GetType(Transmissions), "Transmission", Transmissions.SemiAutomatic, "The type of transmission thet would convert the engine power/torque.", "Drivetrain")

            Dim drive As PropertyStoreItem = New PropertyStoreItem(GetType(Drives), "Drive", Drives.AllWheelDrive, "The configuration of the driving wheels.", "Drivetrain")

            Dim vehicleSeats As PropertyStoreItem = New PropertyStoreItem(GetType(Integer), "Number of seats", 2, "The number of seats in the vehicle.", "Other")

            Dim vehicleWeight As PropertyStoreItem = New PropertyStoreItem(GetType(Integer), "Weight", 1250, "The minimum wight of the car.", "Other")

			vehicleStore.Add(engineLayout)
			vehicleStore.Add(engineDisplacement)
			vehicleStore.Add(engineFuel)
			vehicleStore.Add(engineSupercharged)
			vehicleStore.Add(transmission)
			vehicleStore.Add(drive)
			vehicleStore.Add(vehicleSeats)
			vehicleStore.Add(vehicleWeight)

			Return vehicleStore
		End Function

		Private Function CreateChampionships() As List(Of Championship)
			Dim wrc As Championship = New Championship("WRC", EngineLayouts.I4, 1600, Fuels.Petrol, True, Transmissions.Manual Or Transmissions.SemiAutomatic, Drives.FrontWheelDrive Or Drives.RearWheelDrive Or Drives.AllWheelDrive, 2, 1200)
			Dim formula1 As Championship = New Championship("Formula 1", EngineLayouts.V8, 2400, Fuels.Petrol, True, Transmissions.SemiAutomatic, Drives.RearWheelDrive, 1, 580)
			Dim wtcc As Championship = New Championship("WTCC", EngineLayouts.I4, 2000, Fuels.Petrol Or Fuels.Diesel, False, Transmissions.Manual Or Transmissions.SemiAutomatic, Drives.FrontWheelDrive Or Drives.RearWheelDrive, 1, 1200)
			Dim dtm As Championship = New Championship("DTM", EngineLayouts.V8, 4000, Fuels.Petrol, False, Transmissions.SemiAutomatic, Drives.RearWheelDrive, 1, 1050)
			Dim superstars As Championship = New Championship("Superstars", EngineLayouts.V8, 7000, Fuels.Petrol Or Fuels.Ethanol, False, Transmissions.Manual Or Transmissions.SemiAutomatic, Drives.RearWheelDrive, 4, 1350)

            Dim champs As New List(Of Championship)()
            champs.Add(wrc)
            champs.Add(formula1)
            champs.Add(wtcc)
            champs.Add(dtm)
            champs.Add(superstars)

            Return champs
        End Function

		Private Function ChampionshipRequirementsMet(ByVal championship As Championship) As Integer
			Dim totalNumberOfRegulations As Integer = Me.store.Count
			Dim numberOfRegulationsMet As Integer = 0

			Dim vehicleSettings As Championship = New Championship()
			vehicleSettings.AllowedEngineLayouts = CType(Me.store("Layout").Value, EngineLayouts)
			vehicleSettings.MaximumEngineDisplacement = CInt(Fix(Me.store("Displacement").Value))
			vehicleSettings.AllowedFuels = CType(Me.store("Fuel").Value, Fuels)
			vehicleSettings.AllowedEngineSupercharged = CBool(Me.store("Turbocharged/Supercharged").Value)
			vehicleSettings.AllowedTransmissions = CType(Me.store("Transmission").Value, Transmissions)
			vehicleSettings.AllowedDrives = CType(Me.store("Drive").Value, Drives)
			vehicleSettings.MinimumNumberOfSeats = CInt(Fix(Me.store("Number of seats").Value))
			vehicleSettings.MinimumVehicleWeight = CInt(Fix(Me.store("Weight").Value))

			If (championship.AllowedEngineLayouts And vehicleSettings.AllowedEngineLayouts) = vehicleSettings.AllowedEngineLayouts Then
				numberOfRegulationsMet += 1
			End If

			If championship.MaximumEngineDisplacement >= vehicleSettings.MaximumEngineDisplacement Then
				numberOfRegulationsMet += 1
			End If

			If (championship.AllowedFuels And vehicleSettings.AllowedFuels) = vehicleSettings.AllowedFuels Then
				numberOfRegulationsMet += 1
			End If

			If championship.AllowedEngineSupercharged OrElse championship.AllowedEngineSupercharged = vehicleSettings.AllowedEngineSupercharged Then
				numberOfRegulationsMet += 1
			End If

			If (championship.AllowedTransmissions And vehicleSettings.AllowedTransmissions) = vehicleSettings.AllowedTransmissions Then
				numberOfRegulationsMet += 1
			End If

			If (championship.AllowedDrives And vehicleSettings.AllowedDrives) = vehicleSettings.AllowedDrives Then
				numberOfRegulationsMet += 1
			End If

			If championship.MinimumNumberOfSeats <= vehicleSettings.MinimumNumberOfSeats Then
				numberOfRegulationsMet += 1
			End If

			If championship.MinimumVehicleWeight <= vehicleSettings.MinimumVehicleWeight Then
				numberOfRegulationsMet += 1
			End If

			Return ((numberOfRegulationsMet * 100) / totalNumberOfRegulations)
		End Function

		Private Sub ProcessProgressBarValues()
			Dim i As Integer = 0
			Do While i < Me.championships.Count
				Dim requirementsMet As Integer = Me.ChampionshipRequirementsMet(championships(i))
				Me.progressBars(i).Value1 = requirementsMet
				i += 1
			Loop
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)

			If Not Me.radPanel1 Is Nothing Then
				Me.radPanel1.Location = New Point((Me.ClientSize.Width - radPanel1.Size.Width) / 2, Me.radPanel1.Location.Y)
			End If
        End Sub

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "TelerikMetro"
        End Function

	End Class
End Namespace
