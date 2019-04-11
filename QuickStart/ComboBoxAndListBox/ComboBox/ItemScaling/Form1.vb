Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Reflection
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ItemScaling
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Private Const THEME As String = "ControlDefault"
        Private showDropDownTimeout As Timer
        Private executingAssembly As Global.System.Reflection.Assembly
        Private arialFont As Font
        Public Sub New()
            InitializeComponent()
            Me.radComboDemo.AutoSizeItems = True
            Me.radComboDemo.DefaultItemsCountInDropDown = 15
            Me.radComboDemo.DropDownAnimationEnabled = False
            AddHandler radComboDemo.VisualListItemFormatting, AddressOf radComboDemo_VisualListItemFormatting
            Me.SelectedControl = Me.radComboDemo
            Me.showDropDownTimeout = New Timer(Me.components)
            AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
            Me.showDropDownTimeout.Interval = 1000
            Me.showDropDownTimeout.Start()
            arialFont = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        End Sub

        Private Sub radComboDemo_VisualListItemFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.VisualItemFormattingEventArgs)
            args.VisualItem.AddBehavior(New ComboBoxMouseOverBehavior())
            args.VisualItem.Font = arialFont
        End Sub

        Private Sub SetTheme()
            Me.radComboDemo.ThemeName = THEME
        End Sub

#Region "Event handling"

        Private Function GetImageFromResource(ByVal imageFileName As String) As Image
            Dim img As Image
            Dim imageStream As Stream

            If executingAssembly Is Nothing Then
                Me.executingAssembly = Global.System.Reflection.Assembly.GetExecutingAssembly()
            End If

            imageStream = Me.executingAssembly.GetManifestResourceStream(String.Format("Telerik.Examples.WinControls.Resources.CarPictures.{0}", imageFileName))
            img = Bitmap.FromStream(imageStream)

            If img Is Nothing Then
                imageStream = Me.executingAssembly.GetManifestResourceStream(String.Format(imageFileName))
                img = Bitmap.FromStream(imageStream)
            End If

            Return img
        End Function

        Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.radComboDemo.Focus()
            Me.radComboDemo.ShowDropDown()
            Me.showDropDownTimeout.Stop()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            Me.SetTheme()

            MyBase.OnLoad(e)
        End Sub

#End Region
    End Class
End Namespace
