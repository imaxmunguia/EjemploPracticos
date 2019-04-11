using System;

namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
{
    [Flags]
    public enum EngineLayouts
    {
        I4 = 1,
        I6 = 2, 
        V6 = 4, 
        V8 = 8, 
        V10 = 16, 
        V12 = 32
    }

    [Flags]
    public enum Fuels
    {
        Petrol = 1, 
        Diesel = 2, 
        Ethanol = 4, 
        Electric = 8
    }

    [Flags]
    public enum Transmissions
    {
        Manual = 1, 
        SemiAutomatic = 2, 
        Automatic = 4
    }

    [Flags]
    public enum Drives
    {
        FrontWheelDrive = 1, 
        RearWheelDrive = 2, 
        AllWheelDrive = 4
    }
}
