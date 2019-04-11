Imports System.IO
Imports System.Xml.Serialization

Module Module1

    Sub Main()
        Dim str As String = "<Interfaces>
                                 <Interface>
                                     <InterfaceCode>987</InterfaceCode>
                                     <AccessID>asdf</AccessID>
                                     <Password>654321</Password>
                                 </Interface>
                                 <Interface>
                                     <InterfaceCode>789</InterfaceCode>
                                     <AccessID>      </AccessID>
                                     <Password>      </Password>
                                 </Interface>
                             </Interfaces>"
        Dim interfaces As InterfacesModel

        Dim serializer As New XmlSerializer(GetType(InterfacesModel))
        Using reader As TextReader = New StringReader(str)
            interfaces = serializer.Deserialize(reader)
        End Using
    End Sub

End Module
<Serializable(), XmlRoot("Interfaces")>
Public Class InterfacesModel
    <XmlElement("Interface")> Property Interfaces As New List(Of InterfaceModel)
End Class

<Serializable()>
Public Class InterfaceModel
    Property InterfaceCode As String
    Property AccessID As String
    Property Password As String
End Class