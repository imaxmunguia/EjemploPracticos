Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuItemWithCustomElement
    Partial Public Class Form1
        Inherits ExamplesForm
        Private sizeDropDownList As RadDropDownList
        Private fontDropDownList As RadDropDownList
        Private PageView As RadPageView
        Private Const THEME As String = "ControlDefault"

        Public Sub New()
            InitializeComponent()
            ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
            Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
        End Sub

        Private Sub AddToolStrip()
            Dim toolStrip As New RadCommandBar()
            toolStrip.ImageList = Me.imageList1

            Dim element As New CommandBarRowElement()
            element.AllowDrag = False
            toolStrip.Rows.Add(element)

            Dim toolStripItem As New CommandBarStripElement()
            toolStripItem.AllowDrag = False
            toolStripItem.OverflowButton.Visibility = ElementVisibility.Collapsed
            toolStripItem.StretchHorizontally = True
            element.Strips.Add(toolStripItem)

            Dim button1 As New CommandBarButton()
            button1.ImageIndex = 0
            toolStripItem.Items.Add(button1)

            Dim button2 As New CommandBarButton()
            button2.ImageIndex = 1
            toolStripItem.Items.Add(button2)

            Dim button3 As New CommandBarButton()
            button3.ImageIndex = 2
            toolStripItem.Items.Add(button3)

            Dim button4 As New CommandBarButton()
            button4.ImageIndex = 3
            toolStripItem.Items.Add(button4)

            Dim button5 As New CommandBarButton()
            button5.ImageIndex = 4
            toolStripItem.Items.Add(button5)

            toolStrip.EndInit()

            Dim item As New RadMenuContentItem()
            item.ContentElement = New RadHostItem(toolStrip)
            item.MinSize = New Size(120, 31)

            Me.radMenuItem1.Items.Add(item)
        End Sub

        Private Sub AddTabStrip()
            fontDropDownList = New RadDropDownList()
            fontDropDownList.Margin = New Padding(25, 5, 5, 5)
            fontDropDownList.Text = "Select Font"
            fontDropDownList.Items.Add(New RadListDataItem("Arial"))
            fontDropDownList.Items.Add(New RadListDataItem("Tahoma"))
            fontDropDownList.Items.Add(New RadListDataItem("Times New Roman"))
            fontDropDownList.Items.Add(New RadListDataItem("Verdana"))

            sizeDropDownList = New RadDropDownList()
            sizeDropDownList.Margin = New Padding(25, 5, 5, 5)
            sizeDropDownList.Text = "8"
            sizeDropDownList.Items.Add(New RadListDataItem("7"))
            sizeDropDownList.Items.Add(New RadListDataItem("8"))
            sizeDropDownList.Items.Add(New RadListDataItem("9"))
            sizeDropDownList.Items.Add(New RadListDataItem("10"))
            sizeDropDownList.Items.Add(New RadListDataItem("11"))
            sizeDropDownList.Items.Add(New RadListDataItem("12"))

            PageView = New RadPageView()
            Dim fontPage As New RadPageViewPage()
            fontPage.Text = "Font"
            fontPage.Controls.Add(fontDropDownList)
            PageView.Pages.Add(fontPage)
            Dim sizePage As New RadPageViewPage()
            sizePage.Text = "Size"
            sizePage.Controls.Add(sizeDropDownList)
            PageView.Pages.Add(sizePage)

            Dim contentItem As New RadMenuContentItem()
            contentItem.ContentElement = New RadHostItem(PageView)
            contentItem.MinSize = New Size(120, 100)

            Me.radMenuItem2.Items.Insert(6, contentItem)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddToolStrip()
            AddTabStrip()
        End Sub

    End Class
End Namespace