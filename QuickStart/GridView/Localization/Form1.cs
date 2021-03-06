using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Telerik.Examples.WinControls.GridView.Localization
{
    public partial class Form1 : ExamplesForm
    {
        RadGridLocalizationProvider oldProvider;

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radGridView1;

            oldProvider = RadGridLocalizationProvider.CurrentProvider;

            RadGridLocalizationProvider.CurrentProvider = new MyGermanRadGridLocalizationProvider();
            this.radRadioGerman.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }


        protected override void OnLoad(EventArgs e)
        {
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.MasterTemplate.AllowAddNewRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.TableElement.EnableHotTracking = false;
            this.radGridView1.TableElement.TableHeaderHeight = 35;
            this.radGridView1.TableElement.RowHeight = 30;

            this.BindGrid();

            base.OnLoad(e);
        }

        private void BindGrid()
        {
            //populate and bind the datasource
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }

        #region Event handling

        private void Form1_Disposed(object sender, System.EventArgs e)
        {
            RadGridLocalizationProvider.CurrentProvider = oldProvider;
        }



        private void OnRadioLanguages_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioEnglish.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                RadGridLocalizationProvider.CurrentProvider = oldProvider;
                //this.radGridView1.TableElement.Update(GridUINotifyAction.Reset);
                this.radGridView1.TableElement.UpdateView();
            }
            else if (this.radRadioGerman.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                RadGridLocalizationProvider.CurrentProvider = new MyGermanRadGridLocalizationProvider();
                //this.radGridView1.TableElement.Update(GridUINotifyAction.Reset);
                this.radGridView1.TableElement.UpdateView();
            }
        }

        #endregion

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }
    }

    public class MyGermanRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterOperatorBetween: return "Zwischen";
                case RadGridStringId.FilterOperatorContains: return "Beinhaltet";
                case RadGridStringId.FilterOperatorDoesNotContain: return "BeinhaltetNicht";
                case RadGridStringId.FilterOperatorEndsWith: return "EndetMit";
                case RadGridStringId.FilterOperatorEqualTo: return "IstGleich";
                case RadGridStringId.FilterOperatorGreaterThan: return "GrößerAls";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "GrößerAlsOderGleich";
                case RadGridStringId.FilterOperatorIsEmpty: return "IstLeer";
                case RadGridStringId.FilterOperatorIsNull: return "IstNull";
                case RadGridStringId.FilterOperatorLessThan: return "WenigerAls";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "WenigerAlsOderGleich";
                case RadGridStringId.FilterOperatorNoFilter: return "KeinFilter";
                case RadGridStringId.FilterOperatorNotBetween: return "NichtZwischen";
                case RadGridStringId.FilterOperatorNotEqualTo: return "NichtGleich";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "NichtLeer";
                case RadGridStringId.FilterOperatorNotIsNull: return "NichtNull";
                case RadGridStringId.FilterOperatorStartsWith: return "StartetMit";
                case RadGridStringId.FilterOperatorIsLike: return "Wie";
                case RadGridStringId.FilterOperatorNotIsLike: return "NichtWie";
                case RadGridStringId.FilterOperatorIsContainedIn: return "EnthaltenIn";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "NichtBestandteil";
                case RadGridStringId.FilterOperatorCustom: return "MaßgeschneidertFunktion";
                case RadGridStringId.FilterFunctionBetween: return "Zwischen";
                case RadGridStringId.FilterFunctionContains: return "Beinhaltet";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Beinhaltet nicht";
                case RadGridStringId.FilterFunctionEndsWith: return "Endet mit";
                case RadGridStringId.FilterFunctionEqualTo: return "Ist gleich";
                case RadGridStringId.FilterFunctionGreaterThan: return "Größer als";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Größer als oder gleich";
                case RadGridStringId.FilterFunctionIsEmpty: return "Ist leer";
                case RadGridStringId.FilterFunctionIsNull: return "Ist null";
                case RadGridStringId.FilterFunctionLessThan: return "Weniger als";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Weniger als oder gleich";
                case RadGridStringId.FilterFunctionNoFilter: return "Kein Filter";
                case RadGridStringId.FilterFunctionNotBetween: return "Nicht zwischen";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Nicht gleich";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Nicht leer";
                case RadGridStringId.FilterFunctionNotIsNull: return "Nicht null";
                case RadGridStringId.FilterFunctionStartsWith: return "Startet mit";
                case RadGridStringId.FilterFunctionCustom: return "Maßgeschneidert funktion";
                case RadGridStringId.CustomFilterMenuItem: return "Maßgeschneidert Filter Menüpunkt";
                case RadGridStringId.CustomFilterDialogCaption: return "MaЯgeschneidert Filter Dialog";
                case RadGridStringId.CustomFilterDialogLabel: return "Zeig Zeilen die:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "Und";
                case RadGridStringId.CustomFilterDialogRbOr: return "Oder";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Annullieren";
                case RadGridStringId.DeleteRowMenuItem: return "Zeile löschen";
                case RadGridStringId.SortAscendingMenuItem: return "Sortieren in aufsteigende Reihenfolge";
                case RadGridStringId.SortDescendingMenuItem: return "Sortieren in absteigende Reihenfolge";
                case RadGridStringId.ClearSortingMenuItem: return "Sorting löschen";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Bedingungssatzformatierung";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Passen mit dieser Spalte";
                case RadGridStringId.UngroupThisColumn: return "Diese Spalte vom Gruppierung löschen";
                case RadGridStringId.ColumnChooserMenuItem: return "Spaltenwähler";
                case RadGridStringId.HideMenuItem: return "Verstecken";
                case RadGridStringId.UnpinMenuItem: return "Abheften";
                case RadGridStringId.PinMenuItem: return "Festhalten";
                case RadGridStringId.PinAtLeftMenuItem: return "Festhalten auf der Linken Seite";
                case RadGridStringId.PinAtRightMenuItem: return "Festhalten auf der Rechten Seite";
                case RadGridStringId.BestFitMenuItem: return "Beste Passung";
                case RadGridStringId.PasteMenuItem: return "Einfügen";
                case RadGridStringId.EditMenuItem: return "Bearbeiten";
                case RadGridStringId.CopyMenuItem: return "Kopieren";
                case RadGridStringId.ClearValueMenuItem: return "Wert löschen";
                case RadGridStringId.AddNewRowString: return "Klicken Sie hier, um eine neue Zeile einzufügen";
                case RadGridStringId.ConditionalFormattingCaption: return "Maßgeschneidert Formatierung Bedingungssatz Editor";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Spalte:";
                case RadGridStringId.ConditionalFormattingLblName: return "Name:";
                case RadGridStringId.ConditionalFormattingLblType: return "Typ:";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Regel gilt für";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Wert 1:";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Wert 2:";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Auflagen";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Eigenschaften";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Auf Zeile anwenden";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Ansetzen";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Löschen";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Annullieren";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Anlegen";
                case RadGridStringId.ColumnChooserFormCaption: return "Spaltenwähler";
                case RadGridStringId.ColumnChooserFormMessage: return "Um eine Spalte zu verstecken,\nschieben Sie sie vom RadGridView\nauf dieses Fenster";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Nicht";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}