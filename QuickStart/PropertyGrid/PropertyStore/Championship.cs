
namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
{
    public class Championship
    {
        public string Name { get; set; }
        public EngineLayouts AllowedEngineLayouts { get; set; }
        public int MaximumEngineDisplacement { get; set; }
        public Fuels AllowedFuels { get; set; }
        public bool AllowedEngineSupercharged { get; set; }
        public Transmissions AllowedTransmissions { get; set; }
        public Drives AllowedDrives { get; set; }
        public int MinimumNumberOfSeats { get; set; }
        public int MinimumVehicleWeight { get; set; }

        public Championship()
        { }

        public Championship(string name, EngineLayouts allowedLayouts, int maxDisplacement, Fuels allowedFuels,
            bool allowSupercharged, Transmissions allowedTransmissions, Drives allowedDrives, int maxNumberOfSeats, int minWight)
        {
            this.Name = name;
            this.AllowedEngineLayouts = allowedLayouts;
            this.MaximumEngineDisplacement = maxDisplacement;
            this.AllowedFuels = allowedFuels;
            this.AllowedEngineSupercharged = allowSupercharged;
            this.AllowedTransmissions = allowedTransmissions;
            this.AllowedDrives = allowedDrives;
            this.MinimumNumberOfSeats = maxNumberOfSeats;
            this.MinimumVehicleWeight = minWight;
        }
    }
}
