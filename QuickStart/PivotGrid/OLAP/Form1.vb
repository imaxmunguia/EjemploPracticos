Imports Telerik.Pivot.DataProviders.Adomd
Imports System
Imports System.Drawing
Imports Telerik.Pivot.Adomd

Namespace Telerik.Examples.WinControls.PivotGrid.OLAP
    Partial Public Class Form1

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SetupAdomdProvider()
            Dim provider As New AdomdDataProvider()
            Dim settings As New AdomdConnectionSettings()

            settings.Cube = "Adventure Works"
            settings.Database = "Adventure Works DW 2008R2"
            settings.ConnectionString = "Data Source=http://demos.telerik.com/olap/msmdpump.dll;Catalog=Adventure Works DW 2008R2"

            provider.ConnectionSettings = settings

            provider.RowGroupDescriptions.Add(New AdomdGroupDescription() With { _
             .MemberName = "[Date].[Calendar Year]" _
            })
            provider.RowGroupDescriptions.Add(New AdomdGroupDescription() With { _
             .MemberName = "[Date].[Calendar Quarter of Year]" _
            })

            provider.ColumnGroupDescriptions.Add(New AdomdGroupDescription() With { _
             .MemberName = "[Promotion].[Promotion Category]" _
            })
            provider.ColumnGroupDescriptions.Add(New AdomdGroupDescription() With { _
             .MemberName = "[Product].[Category]" _
            })

            provider.AggregateDescriptions.Add(New AdomdAggregateDescription() With { _
             .MemberName = "[Measures].[Internet Order Quantity]" _
            })

            Me.radPivotGrid1.PivotGridElement.DataProvider = provider
        End Sub

        Private Sub radButton1_Click(sender As Object, e As EventArgs) Handles radButton1.Click
            Me.radButton1.Parent.Controls.Remove(Me.radButton1)
            Me.SetupAdomdProvider()
        End Sub

        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            MyBase.OnSizeChanged(e)
            If Me.radButton1 IsNot Nothing AndAlso Me.radPivotGrid1 IsNot Nothing Then
                Me.radButton1.Location = New Point((Me.radPivotGrid1.Width - Me.radButton1.Width) / 2, (Me.radPivotGrid1.Height - Me.radButton1.Height) / 2)
            End If
        End Sub
    End Class
End Namespace