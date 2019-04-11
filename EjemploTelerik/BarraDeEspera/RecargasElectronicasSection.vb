Imports System.Configuration
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class RecargasElectronicasSection
    Implements IConfigurationSectionHandler
    Private Function IConfigurationSectionHandler_Create(parent As Object, configContext As Object, section As XmlNode) As Object Implements IConfigurationSectionHandler.Create
        Dim _recargasElectronicas As RecargaElectronica

        Dim serializer As New XmlSerializer(GetType(RecargaElectronica))
        Using reader As TextReader = New StringReader(section.OuterXml)
            _recargasElectronicas = serializer.Deserialize(reader)
        End Using
        Return _recargasElectronicas.Configuraciones
    End Function
End Class