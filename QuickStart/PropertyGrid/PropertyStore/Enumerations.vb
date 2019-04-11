
Imports System

Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
    <Flags()> _
    Public Enum EngineLayouts
        I4 = 1
        I6 = 2
        V6 = 4
        V8 = 8
        V10 = 16
        V12 = 32
    End Enum

    <Flags()> _
    Public Enum Fuels
        Petrol = 1
        Diesel = 2
        Ethanol = 4
        Electric = 8
    End Enum

    <Flags()> _
    Public Enum Transmissions
        Manual = 1
        SemiAutomatic = 2
        Automatic = 4
    End Enum

    <Flags()> _
    Public Enum Drives
        FrontWheelDrive = 1
        RearWheelDrive = 2
        AllWheelDrive = 4
    End Enum
End Namespace