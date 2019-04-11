Imports System.Collections.Generic
Imports System.Text
Imports Telerik.Data.Expressions
Imports System

Namespace Telerik.Examples.WinControls.GridView.Expressions
    Public Class CustomExpressionContext
        Inherits ExpressionContext
        ''' <summary>
        ''' Custom function, which returns Pi.
        ''' </summary>
        ''' <returns></returns>
        Public Function Pi() As Double
            Return Math.PI
        End Function
    End Class
End Namespace