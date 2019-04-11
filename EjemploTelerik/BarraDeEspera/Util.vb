Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Friend NotInheritable Class Util
    Public Shared Function ConvertNode(Of T As Class)(ByVal node As XmlNode) As T
        Dim stm As MemoryStream = New MemoryStream()

        Dim stw As StreamWriter = New StreamWriter(stm)
        stw.Write(node.OuterXml)
        stw.Flush()

        stm.Position = 0

        Dim ser As XmlSerializer = New XmlSerializer(GetType(T))
        Dim result As T = CType(ser.Deserialize(stm), T)

        Return result
    End Function
End Class
