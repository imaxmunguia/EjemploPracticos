Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Namespace Telerik.Examples.WinControls.CommandBar.FirstLook
	Public Partial Class Form1
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()

			Dim icon As ImagePrimitive = New ImagePrimitive()
			icon.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.telerik_icon
			icon.Padding = New Padding(0, 4, 0, 0)

			Dim addressBox As RadTextBoxElement = radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox
			radCommandBarDropDownListItem1.DropDownListElement.EditableElement.DrawText = False
			Me.AddIconToTextBoxElement(addressBox, icon)

			Dim searchIcon As ImagePrimitive = New ImagePrimitive()
			searchIcon.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.search3
			searchIcon.Alignment = ContentAlignment.MiddleRight
			AddHandler searchIcon.MouseDown, AddressOf searchIcon_MouseDown
			radCommandBarTextBoxItem1.TextBoxElement.Children.Add(searchIcon)
			radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
			AddHandler radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.KeyDown, AddressOf radCommandBarTextBoxItem1_KeyDown

			AddHandler radCommandBarDropDownListItem1.PropertyChanged, AddressOf radCommandBarDropDownListItem1_PropertyChanged
			AddHandler radCommandBarTextBoxItem1.PropertyChanged, AddressOf radCommandBarTextBoxItem1_PropertyChanged
			AddHandler radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.TextBoxItem.KeyDown, AddressOf radCommandBarDropDownListItem1_KeyDown

            TryCast(radPageView1.ViewElement, RadPageViewStripElement).NewItemVisibility = StripViewNewItemVisibility.End
			AddHandler radPageView1.NewPageRequested, AddressOf radPageView1_NewPageRequested
            AddHandler radPageView1.PageAdded, AddressOf radPageView1_PageAdded

			webBrowser1.ScriptErrorsSuppressed = True
			webBrowser1.Navigate("www.telerik.com")


		End Sub

		Private Sub AddIconToTextBoxElement(ByVal textElement As RadTextBoxElement, ByVal icon As ImagePrimitive)
			Dim item As RadTextBoxItem = textElement.TextBoxItem

			textElement.Children.Remove(item)

			icon.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Left)

			Dim dockPanel As DockLayoutPanel = New DockLayoutPanel()
			dockPanel.LastChildFill = True

			dockPanel.Children.Add(icon)
			dockPanel.Children.Add(item)

			textElement.Children.Add(dockPanel)
		End Sub

		Private Sub radPageView1_PageAdded(ByVal sender As Object, ByVal e As RadPageViewEventArgs)
			e.Page.Item.MaxSize = New Size(200, 40)
		End Sub

		Private Sub radPageView1_NewPageRequested(ByVal sender As Object, ByVal e As EventArgs)
			Dim browser As WebBrowser = New WebBrowser()
			browser.Dock = DockStyle.Fill
			AddHandler browser.Navigating, AddressOf browser_Navigating
			AddHandler browser.Navigated, AddressOf browser_Navigated
			browser.Navigate("www.telerik.com")
			Dim page As RadPageViewPage = New RadPageViewPage()
			page.Controls.Add(browser)
			page.Text = "New Tab"

			radPageView1.Pages.Add(page)
			radPageView1.SelectedPage = page
		End Sub

		Private Sub radCommandBarTextBoxItem1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				Me.OpenSearch(radCommandBarTextBoxItem1.Text)
			End If
		End Sub

		Private Sub searchIcon_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.OpenSearch(radCommandBarTextBoxItem1.Text)
		End Sub

		Private Sub OpenSearch(ByVal searchString As String)
			Dim browser As WebBrowser = New WebBrowser()
			browser.Dock = DockStyle.Fill
			AddHandler browser.Navigating, AddressOf browser_Navigating
			AddHandler browser.Navigated, AddressOf browser_Navigated
			browser.Navigate("http://www.bing.com/search?q=" & searchString)
			Dim page As RadPageViewPage = New RadPageViewPage()
			page.Controls.Add(browser)
			page.Text = "Search"
			radPageView1.Pages.Add(page)
			radPageView1.SelectedPage = page
		End Sub

		Private Sub radCommandBarTextBoxItem1_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(radCommandBarTextBoxItem1.Size.Width - 28, 0)
			End If
		End Sub

		Private Sub radCommandBarDropDownListItem1_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.TextBoxItem.HostedControl.MaximumSize = New Size(radCommandBarDropDownListItem1.Size.Width - 40, 0)
			End If
		End Sub

		Private Sub radCommandBarButtonItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.NavigateTo(radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.Text)
		End Sub

		Private Sub radCommandBarDropDownListItem1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				Me.NavigateTo(radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.Text)
			End If
		End Sub

		Private Sub NavigateTo(ByVal address As String)
			If Not radPageView1.SelectedPage Is Nothing Then
				Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
				browser.Navigate(address)
			End If
		End Sub

		Private Sub browser_Navigating(ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs)
			Dim parentControl As Control = (TryCast(sender, WebBrowser)).Parent
			If parentControl Is Nothing Then
				Return
			End If

            TryCast(sender, WebBrowser).Parent.Text = "Loading..."
		End Sub

		Private Sub browser_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
			Dim senderBrowser As WebBrowser = TryCast(sender, WebBrowser)
			If (String.IsNullOrEmpty(senderBrowser.DocumentTitle)) Then
				senderBrowser.Parent.Text = "New Tab"
			Else
				senderBrowser.Parent.Text = senderBrowser.DocumentTitle
			End If

			Dim pageText As String = senderBrowser.Parent.Text
			If pageText.Length > 20 Then
				senderBrowser.Parent.Text = pageText.Substring(0, 20) & "..."
			End If

			If radCommandBarDropDownListItem1.Items.Count > 50 Then
				radCommandBarDropDownListItem1.Items.RemoveAt(radCommandBarDropDownListItem1.Items.Count - 1)
			End If

			radCommandBarDropDownListItem1.Items.Insert(0, New RadListDataItem(senderBrowser.Url.AbsoluteUri))

			radCommandBarDropDownListItem1.Text = senderBrowser.Url.AbsoluteUri
		End Sub

		Private Sub radCommandBarButtonItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not radPageView1.SelectedPage Is Nothing Then
				Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
				browser.GoBack()
			End If
		End Sub

		Private Sub radCommandBarButtonItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not radPageView1.SelectedPage Is Nothing Then
				Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
				browser.GoForward()
			End If
		End Sub

		Private Sub radCommandBarButtonItem3_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not radPageView1.SelectedPage Is Nothing Then
				Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
				browser.Refresh()
			End If
		End Sub

		Private Sub radCommandBarButtonItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not radPageView1.SelectedPage Is Nothing Then
				Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
				browser.Stop()
				browser.Parent.Text = "Stopped"
			End If
		End Sub

		Private Sub radPageView1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
			If radPageView1.SelectedPage Is Nothing Then
				radCommandBarDropDownListItem1.Text = ""
				Return
			End If

			Dim browser As WebBrowser = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser))
			If Not browser Is Nothing AndAlso Not browser.Url Is Nothing Then
				radCommandBarDropDownListItem1.Text = (TryCast(radPageView1.SelectedPage.Controls(0), WebBrowser)).Url.AbsoluteUri
			End If
		End Sub

		Private Sub radMenuItem14_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub radMenuItem30_Click(ByVal sender As Object, ByVal e As EventArgs)
			'Telerik
			Me.NavigateTo("http://www.telerik.com/products/winforms.aspx")
		End Sub

		Private Sub radMenuItem31_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.NavigateTo("http://www.telerik.com/help")
		End Sub

		Private Sub radMenuItem32_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.NavigateTo("http://www.telerik.com/community.aspx")
		End Sub

		Private Sub radCommandBarButtonItem1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			radCommandBarButtonItem1.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_pressed
		End Sub

		Private Sub radCommandBarButtonItem1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			radCommandBarButtonItem1.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_hover
		End Sub

		Private Sub radCommandBarButtonItem1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			radCommandBarButtonItem1.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_hover
		End Sub

		Private Sub radCommandBarButtonItem1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			radCommandBarButtonItem1.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left
		End Sub


		Private Sub radCommandBarButtonItem2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			radCommandBarButtonItem2.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_pressed
		End Sub

		Private Sub radCommandBarButtonItem2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			radCommandBarButtonItem2.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_hover
		End Sub

		Private Sub radCommandBarButtonItem2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			radCommandBarButtonItem2.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_hover
		End Sub

		Private Sub radCommandBarButtonItem2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			radCommandBarButtonItem2.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right
		End Sub



	End Class
End Namespace
