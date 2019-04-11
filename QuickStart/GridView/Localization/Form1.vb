Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Localization

Namespace Telerik.Examples.WinControls.GridView.Localization
	Partial Public Class Form1
		Inherits ExamplesForm
		Private oldProvider As RadGridLocalizationProvider

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1

			oldProvider = RadGridLocalizationProvider.CurrentProvider

			RadGridLocalizationProvider.CurrentProvider = New MyGermanRadGridLocalizationProvider()
			Me.radRadioGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AllowAddNewRow = True
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.TableElement.EnableHotTracking = False
			Me.radGridView1.TableElement.TableHeaderHeight = 35
			Me.radGridView1.TableElement.RowHeight = 30

			Me.BindGrid()

			MyBase.OnLoad(e)
		End Sub

		Private Sub BindGrid()
			'populate and bind the datasource
			Me.productsTableAdapter.Fill(Me.northwindDataSet.Products)
		End Sub

		#Region "Event handling"

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
			RadGridLocalizationProvider.CurrentProvider = oldProvider
		End Sub



		Private Sub OnRadioLanguages_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioGerman.ToggleStateChanged, radRadioEnglish.ToggleStateChanged
			If Me.radRadioEnglish.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				RadGridLocalizationProvider.CurrentProvider = oldProvider
				'this.radGridView1.TableElement.Update(GridUINotifyAction.Reset);
				Me.radGridView1.TableElement.UpdateView()
			ElseIf Me.radRadioGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				RadGridLocalizationProvider.CurrentProvider = New MyGermanRadGridLocalizationProvider()
				'this.radGridView1.TableElement.Update(GridUINotifyAction.Reset);
				Me.radGridView1.TableElement.UpdateView()
			End If
		End Sub

		#End Region

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class

	Public Class MyGermanRadGridLocalizationProvider
		Inherits RadGridLocalizationProvider
		Public Overrides Function GetLocalizedString(ByVal id As String) As String
			Select Case id
				Case RadGridStringId.FilterOperatorBetween
					Return "Zwischen"
				Case RadGridStringId.FilterOperatorContains
					Return "Beinhaltet"
				Case RadGridStringId.FilterOperatorDoesNotContain
					Return "BeinhaltetNicht"
				Case RadGridStringId.FilterOperatorEndsWith
					Return "EndetMit"
				Case RadGridStringId.FilterOperatorEqualTo
					Return "IstGleich"
				Case RadGridStringId.FilterOperatorGreaterThan
					Return "GrößerAls"
				Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
					Return "GrößerAlsOderGleich"
				Case RadGridStringId.FilterOperatorIsEmpty
					Return "IstLeer"
				Case RadGridStringId.FilterOperatorIsNull
					Return "IstNull"
				Case RadGridStringId.FilterOperatorLessThan
					Return "WenigerAls"
				Case RadGridStringId.FilterOperatorLessThanOrEqualTo
					Return "WenigerAlsOderGleich"
				Case RadGridStringId.FilterOperatorNoFilter
					Return "KeinFilter"
				Case RadGridStringId.FilterOperatorNotBetween
					Return "NichtZwischen"
				Case RadGridStringId.FilterOperatorNotEqualTo
					Return "NichtGleich"
				Case RadGridStringId.FilterOperatorNotIsEmpty
					Return "NichtLeer"
				Case RadGridStringId.FilterOperatorNotIsNull
					Return "NichtNull"
				Case RadGridStringId.FilterOperatorStartsWith
					Return "StartetMit"
				Case RadGridStringId.FilterOperatorIsLike
					Return "Wie"
				Case RadGridStringId.FilterOperatorNotIsLike
					Return "NichtWie"
				Case RadGridStringId.FilterOperatorIsContainedIn
					Return "EnthaltenIn"
				Case RadGridStringId.FilterOperatorNotIsContainedIn
					Return "NichtBestandteil"
				Case RadGridStringId.FilterOperatorCustom
					Return "MaßgeschneidertFunktion"
				Case RadGridStringId.FilterFunctionBetween
					Return "Zwischen"
				Case RadGridStringId.FilterFunctionContains
					Return "Beinhaltet"
				Case RadGridStringId.FilterFunctionDoesNotContain
					Return "Beinhaltet nicht"
				Case RadGridStringId.FilterFunctionEndsWith
					Return "Endet mit"
				Case RadGridStringId.FilterFunctionEqualTo
					Return "Ist gleich"
				Case RadGridStringId.FilterFunctionGreaterThan
					Return "Größer als"
				Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
					Return "Größer als oder gleich"
				Case RadGridStringId.FilterFunctionIsEmpty
					Return "Ist leer"
				Case RadGridStringId.FilterFunctionIsNull
					Return "Ist null"
				Case RadGridStringId.FilterFunctionLessThan
					Return "Weniger als"
				Case RadGridStringId.FilterFunctionLessThanOrEqualTo
					Return "Weniger als oder gleich"
				Case RadGridStringId.FilterFunctionNoFilter
					Return "Kein Filter"
				Case RadGridStringId.FilterFunctionNotBetween
					Return "Nicht zwischen"
				Case RadGridStringId.FilterFunctionNotEqualTo
					Return "Nicht gleich"
				Case RadGridStringId.FilterFunctionNotIsEmpty
					Return "Nicht leer"
				Case RadGridStringId.FilterFunctionNotIsNull
					Return "Nicht null"
				Case RadGridStringId.FilterFunctionStartsWith
					Return "Startet mit"
				Case RadGridStringId.FilterFunctionCustom
					Return "Maßgeschneidert funktion"
				Case RadGridStringId.CustomFilterMenuItem
					Return "Maßgeschneidert Filter Menüpunkt"
				Case RadGridStringId.CustomFilterDialogCaption
					Return "Ma?geschneidert Filter Dialog"
				Case RadGridStringId.CustomFilterDialogLabel
					Return "Zeig Zeilen die:"
				Case RadGridStringId.CustomFilterDialogRbAnd
					Return "Und"
				Case RadGridStringId.CustomFilterDialogRbOr
					Return "Oder"
				Case RadGridStringId.CustomFilterDialogBtnOk
					Return "OK"
				Case RadGridStringId.CustomFilterDialogBtnCancel
					Return "Annullieren"
				Case RadGridStringId.DeleteRowMenuItem
					Return "Zeile löschen"
				Case RadGridStringId.SortAscendingMenuItem
					Return "Sortieren in aufsteigende Reihenfolge"
				Case RadGridStringId.SortDescendingMenuItem
					Return "Sortieren in absteigende Reihenfolge"
				Case RadGridStringId.ClearSortingMenuItem
					Return "Sorting löschen"
				Case RadGridStringId.ConditionalFormattingMenuItem
					Return "Bedingungssatzformatierung"
				Case RadGridStringId.GroupByThisColumnMenuItem
					Return "Passen mit dieser Spalte"
				Case RadGridStringId.UngroupThisColumn
					Return "Diese Spalte vom Gruppierung löschen"
				Case RadGridStringId.ColumnChooserMenuItem
					Return "Spaltenwähler"
				Case RadGridStringId.HideMenuItem
					Return "Verstecken"
				Case RadGridStringId.UnpinMenuItem
					Return "Abheften"
				Case RadGridStringId.PinMenuItem
					Return "Festhalten"
				Case RadGridStringId.PinAtLeftMenuItem
					Return "Festhalten auf der Linken Seite"
				Case RadGridStringId.PinAtRightMenuItem
					Return "Festhalten auf der Rechten Seite"
				Case RadGridStringId.BestFitMenuItem
					Return "Beste Passung"
				Case RadGridStringId.PasteMenuItem
					Return "Einfügen"
				Case RadGridStringId.EditMenuItem
					Return "Bearbeiten"
				Case RadGridStringId.CopyMenuItem
					Return "Kopieren"
				Case RadGridStringId.AddNewRowString
					Return "Klicken Sie hier, um eine neue Zeile einzufügen"
				Case RadGridStringId.ConditionalFormattingCaption
					Return "Maßgeschneidert Formatierung Bedingungssatz Editor"
				Case RadGridStringId.ConditionalFormattingLblColumn
					Return "Spalte:"
				Case RadGridStringId.ConditionalFormattingLblName
					Return "Name:"
				Case RadGridStringId.ConditionalFormattingLblType
					Return "Typ:"
				Case RadGridStringId.ConditionalFormattingRuleAppliesOn
					Return "Regel gilt für"
				Case RadGridStringId.ConditionalFormattingLblValue1
					Return "Wert 1:"
				Case RadGridStringId.ConditionalFormattingLblValue2
					Return "Wert 2:"
				Case RadGridStringId.ConditionalFormattingGrpConditions
					Return "Auflagen"
				Case RadGridStringId.ConditionalFormattingGrpProperties
					Return "Eigenschaften"
				Case RadGridStringId.ConditionalFormattingChkApplyToRow
					Return "Auf Zeile anwenden"
				Case RadGridStringId.ConditionalFormattingBtnAdd
					Return "Ansetzen"
				Case RadGridStringId.ConditionalFormattingBtnRemove
					Return "Löschen"
				Case RadGridStringId.ConditionalFormattingBtnOK
					Return "OK"
				Case RadGridStringId.ConditionalFormattingBtnCancel
					Return "Annullieren"
				Case RadGridStringId.ConditionalFormattingBtnApply
					Return "Anlegen"
				Case RadGridStringId.ColumnChooserFormCaption
					Return "Spaltenwähler"
				Case RadGridStringId.ColumnChooserFormMessage
					Return "Um eine Spalte zu verstecken," & Constants.vbLf & "schieben Sie sie vom RadGridView" & Constants.vbLf & "auf dieses Fenster"
				Case RadGridStringId.CustomFilterDialogCheckBoxNot
					Return "Nicht"
				Case Else
					Return MyBase.GetLocalizedString(id)
			End Select
		End Function
	End Class
End Namespace