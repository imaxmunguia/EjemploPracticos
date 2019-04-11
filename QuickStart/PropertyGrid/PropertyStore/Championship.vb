
Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
    Public Class Championship
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(ByVal value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property AllowedEngineLayouts() As EngineLayouts
            Get
                Return m_AllowedEngineLayouts
            End Get
            Set(ByVal value As EngineLayouts)
                m_AllowedEngineLayouts = Value
            End Set
        End Property
        Private m_AllowedEngineLayouts As EngineLayouts
        Public Property MaximumEngineDisplacement() As Integer
            Get
                Return m_MaximumEngineDisplacement
            End Get
            Set(ByVal value As Integer)
                m_MaximumEngineDisplacement = Value
            End Set
        End Property
        Private m_MaximumEngineDisplacement As Integer
        Public Property AllowedFuels() As Fuels
            Get
                Return m_AllowedFuels
            End Get
            Set(ByVal value As Fuels)
                m_AllowedFuels = Value
            End Set
        End Property
        Private m_AllowedFuels As Fuels
        Public Property AllowedEngineSupercharged() As Boolean
            Get
                Return m_AllowedEngineSupercharged
            End Get
            Set(ByVal value As Boolean)
                m_AllowedEngineSupercharged = Value
            End Set
        End Property
        Private m_AllowedEngineSupercharged As Boolean
        Public Property AllowedTransmissions() As Transmissions
            Get
                Return m_AllowedTransmissions
            End Get
            Set(ByVal value As Transmissions)
                m_AllowedTransmissions = Value
            End Set
        End Property
        Private m_AllowedTransmissions As Transmissions
        Public Property AllowedDrives() As Drives
            Get
                Return m_AllowedDrives
            End Get
            Set(ByVal value As Drives)
                m_AllowedDrives = Value
            End Set
        End Property
        Private m_AllowedDrives As Drives
        Public Property MinimumNumberOfSeats() As Integer
            Get
                Return m_MinimumNumberOfSeats
            End Get
            Set(ByVal value As Integer)
                m_MinimumNumberOfSeats = Value
            End Set
        End Property
        Private m_MinimumNumberOfSeats As Integer
        Public Property MinimumVehicleWeight() As Integer
            Get
                Return m_MinimumVehicleWeight
            End Get
            Set(ByVal value As Integer)
                m_MinimumVehicleWeight = Value
            End Set
        End Property
        Private m_MinimumVehicleWeight As Integer

        Public Sub New()
        End Sub

        Public Sub New(ByVal name As String, ByVal allowedLayouts As EngineLayouts, ByVal maxDisplacement As Integer, ByVal allowedFuels As Fuels, ByVal allowSupercharged As Boolean, ByVal allowedTransmissions As Transmissions, _
         ByVal allowedDrives As Drives, ByVal maxNumberOfSeats As Integer, ByVal minWight As Integer)
            Me.Name = name
            Me.AllowedEngineLayouts = allowedLayouts
            Me.MaximumEngineDisplacement = maxDisplacement
            Me.AllowedFuels = allowedFuels
            Me.AllowedEngineSupercharged = allowSupercharged
            Me.AllowedTransmissions = allowedTransmissions
            Me.AllowedDrives = allowedDrives
            Me.MinimumNumberOfSeats = maxNumberOfSeats
            Me.MinimumVehicleWeight = minWight
        End Sub
    End Class
End Namespace