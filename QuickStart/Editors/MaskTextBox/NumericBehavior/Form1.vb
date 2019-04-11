Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports System.Collections
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.NumericBehavior
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Private Const THEME As String = "ControlDefault"

        Public Sub New()
            InitializeComponent()
            Me.SetTheme()
            Me.LoadCultureInfos()
        End Sub

        Private Sub SetTheme()
            ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
            ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, THEME)
        End Sub

        Private Sub LoadCultureInfos()
            Dim cultures As New SortedList()

            Dim temp As CultureInfo
            For i As Integer = 0 To CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length - 1
                temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)(i)
                cultures.Add(temp.EnglishName, temp)
            Next

            Dim ie As IEnumerator = cultures.Keys.GetEnumerator()
            While ie.MoveNext()
                Dim name As String = DirectCast(ie.Current, String)
                '.ToString()
                Me.radComboCultures.Items.Add(New RadListDataItem(name, cultures(name)))
            End While

            radComboCultures.SelectedItem = radComboCultures.Items(radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName))

        End Sub

        Private Sub radComboCultures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboCultures.SelectedIndexChanged
            For Each control As Control In Me.radPanelDemoHolder.Controls
                If TypeOf control Is RadMaskedEditBox Then
                    Dim maskEdit As RadMaskedEditBox = TryCast(control, RadMaskedEditBox)
                    maskEdit.Culture = TryCast(radComboCultures.SelectedValue, CultureInfo)
                End If
            Next
        End Sub

        Private Sub radTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTextBox1.TextChanged
            Me.radMaskedEditBox19.Mask = radTextBox1.Text
        End Sub
    End Class
End Namespace
