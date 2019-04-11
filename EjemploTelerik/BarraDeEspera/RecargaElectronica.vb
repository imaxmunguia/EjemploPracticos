Imports System.Xml.Serialization

<Serializable(), XmlRoot("RecargasElectronicasConfig")>
Public Class RecargaElectronica
    <XmlElement("RecargaElectronicaConfig")> Property Configuraciones As New List(Of RecargaElectronicaConfig)
End Class
