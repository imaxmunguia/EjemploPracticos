﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
{
    public partial class Form1 : ExamplesForm
    {
        private RadPropertyStore store;
        private List<Championship> championships;
        private List<RadProgressBar> progressBars;

        public Form1()
        {
            InitializeComponent();

            this.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden;
            this.radPanelCars.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden;

            this.store = this.CreatePropertyStore();
            this.championships = this.CreateChampionships();
            this.progressBars = new List<RadProgressBar>() { this.radProgressBar1, this.radProgressBar2, this.radProgressBar3, this.radProgressBar4, this.radProgressBar5, };
            this.radPropertyGrid1.SelectedObject = store;
            this.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical;

            this.ProcessProgressBarValues();

            this.radPropertyGrid1.EditorInitialized += new PropertyGridItemEditorInitializedEventHandler(radPropertyGrid1_EditorInitialized);
            this.radPropertyGrid1.PropertyValueChanged += new PropertyGridItemValueChangedEventHandler(radPropertyGrid1_PropertyValueChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ThemeResolutionService.ApplyThemeToControlTree(this, "TelerikMetro");
        }

        private void radPropertyGrid1_PropertyValueChanged(object sender, PropertyGridItemValueChangedEventArgs e)
        {
            this.ProcessProgressBarValues();
        }

        private void radPropertyGrid1_EditorInitialized(object sender, PropertyGridItemEditorInitializedEventArgs e)
        {

            PropertyGridSpinEditor editor = e.Editor as PropertyGridSpinEditor;
            if (editor == null)
            {
                return;
            }

            BaseSpinEditorElement element = editor.EditorElement as BaseSpinEditorElement;

            switch (e.Item.Name)
            {
                case "Displacement":
                    element.MinValue = 1;
                    element.MaxValue = 10000;
                    break;
                case "Number of seats":
                    element.MinValue = 1;
                    element.MaxValue = 60;
                    break;
                case "Weight":
                    element.MinValue = 1;
                    element.MaxValue = 10000;
                    break;
            }
        }

        private RadPropertyStore CreatePropertyStore()
        {
            RadPropertyStore vehicleStore = new RadPropertyStore();

            PropertyStoreItem engineLayout = new PropertyStoreItem(typeof(EngineLayouts), "Layout", EngineLayouts.I4,
                "Engine layout is determined by the configuration of the engine pistons.", "Engine");

            PropertyStoreItem engineDisplacement = new PropertyStoreItem(typeof(int), "Displacement", 1600,
                "Engine displacement is determined from the bore and stroke of the engine's cylinders.", "Engine");

            PropertyStoreItem engineFuel = new PropertyStoreItem(typeof(Fuels), "Fuel", Fuels.Petrol,
                "The type of fuel providing the energy source for the engine.", "Engine");

            PropertyStoreItem engineSupercharged = new PropertyStoreItem(typeof(bool), "Turbocharged/Supercharged", true,
                "Turbocharging/Supercharging is the process of compressing air on the intake of an engine(technical term - Forced induction).", "Engine");

            PropertyStoreItem transmission = new PropertyStoreItem(typeof(Transmissions), "Transmission", Transmissions.SemiAutomatic,
                "The type of transmission thet would convert the engine power/torque.", "Drivetrain");

            PropertyStoreItem drive = new PropertyStoreItem(typeof(Drives), "Drive", Drives.AllWheelDrive,
                "The configuration of the driving wheels.", "Drivetrain");

            PropertyStoreItem vehicleSeats = new PropertyStoreItem(typeof(int), "Number of seats", 2,
                "The number of seats in the vehicle.", "Other");

            PropertyStoreItem vehicleWeight = new PropertyStoreItem(typeof(int), "Weight", 1250,
                "The minimum wight of the car.", "Other");

            vehicleStore.Add(engineLayout);
            vehicleStore.Add(engineDisplacement);
            vehicleStore.Add(engineFuel);
            vehicleStore.Add(engineSupercharged);
            vehicleStore.Add(transmission);
            vehicleStore.Add(drive);
            vehicleStore.Add(vehicleSeats);
            vehicleStore.Add(vehicleWeight);

            return vehicleStore;
        }

        private List<Championship> CreateChampionships()
        {
            Championship wrc = new Championship("WRC", EngineLayouts.I4, 1600, Fuels.Petrol, true, Transmissions.Manual | Transmissions.SemiAutomatic, 
                Drives.FrontWheelDrive | Drives.RearWheelDrive | Drives.AllWheelDrive, 2, 1200);
            Championship formula1 = new Championship("Formula 1", EngineLayouts.V8 , 2400, Fuels.Petrol, true, Transmissions.SemiAutomatic,
                Drives.RearWheelDrive, 1, 580);
            Championship wtcc = new Championship("WTCC", EngineLayouts.I4, 2000, Fuels.Petrol | Fuels.Diesel, false, 
                Transmissions.Manual | Transmissions.SemiAutomatic, Drives.FrontWheelDrive | Drives.RearWheelDrive, 1, 1200);
            Championship dtm = new Championship("DTM", EngineLayouts.V8, 4000, Fuels.Petrol, false, Transmissions.SemiAutomatic, 
                Drives.RearWheelDrive, 1, 1050);
            Championship superstars = new Championship("Superstars", EngineLayouts.V8, 7000, Fuels.Petrol | Fuels.Ethanol, false,
                Transmissions.Manual | Transmissions.SemiAutomatic, Drives.RearWheelDrive, 4, 1350);

            return (new List<Championship>() { wrc, formula1, wtcc, dtm, superstars });
        }

        private int ChampionshipRequirementsMet(Championship championship)
        {
            int totalNumberOfRegulations = this.store.Count;
            int numberOfRegulationsMet = 0;

            Championship vehicleSettings = new Championship();
            vehicleSettings.AllowedEngineLayouts = (EngineLayouts)this.store["Layout"].Value;
            vehicleSettings.MaximumEngineDisplacement = (int)this.store["Displacement"].Value;
            vehicleSettings.AllowedFuels = (Fuels)this.store["Fuel"].Value;
            vehicleSettings.AllowedEngineSupercharged = (bool)this.store["Turbocharged/Supercharged"].Value;
            vehicleSettings.AllowedTransmissions = (Transmissions)this.store["Transmission"].Value;
            vehicleSettings.AllowedDrives = (Drives)this.store["Drive"].Value;
            vehicleSettings.MinimumNumberOfSeats = (int)this.store["Number of seats"].Value;
            vehicleSettings.MinimumVehicleWeight = (int)this.store["Weight"].Value;

            if ((championship.AllowedEngineLayouts & vehicleSettings.AllowedEngineLayouts) == vehicleSettings.AllowedEngineLayouts)
            {
                numberOfRegulationsMet++;
            }

            if (championship.MaximumEngineDisplacement >= vehicleSettings.MaximumEngineDisplacement)
            {
                numberOfRegulationsMet++;
            }

            if ((championship.AllowedFuels & vehicleSettings.AllowedFuels) == vehicleSettings.AllowedFuels)
            {
                numberOfRegulationsMet++;
            }

            if (championship.AllowedEngineSupercharged || championship.AllowedEngineSupercharged == vehicleSettings.AllowedEngineSupercharged)
            {
                numberOfRegulationsMet++;
            }

            if ((championship.AllowedTransmissions & vehicleSettings.AllowedTransmissions) == vehicleSettings.AllowedTransmissions)
            {
                numberOfRegulationsMet++;
            }

            if ((championship.AllowedDrives & vehicleSettings.AllowedDrives) == vehicleSettings.AllowedDrives)
            {
                numberOfRegulationsMet++;
            }

            if (championship.MinimumNumberOfSeats <= vehicleSettings.MinimumNumberOfSeats)
            {
                numberOfRegulationsMet++;
            }

            if (championship.MinimumVehicleWeight <= vehicleSettings.MinimumVehicleWeight)
            {
                numberOfRegulationsMet++;
            }

            return ((numberOfRegulationsMet * 100) / totalNumberOfRegulations);
        }

        private void ProcessProgressBarValues()
        {
            for (int i = 0; i < this.championships.Count; i++)
            {
                int requirementsMet = this.ChampionshipRequirementsMet(championships[i]);
                this.progressBars[i].Value1 = requirementsMet;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.radPanel1 != null)
            {
                this.radPanel1.Location = new Point((this.ClientSize.Width - radPanel1.Size.Width) / 2, this.radPanel1.Location.Y);
            }
        }

        protected override string GetExampleDefaultTheme()
        {
            return "TelerikMetro";
        }
    }
}
