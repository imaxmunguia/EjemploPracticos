Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.DataSources
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Data
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Layouts

Namespace Telerik.Examples.WinControls.ListView.FirstLook
    Partial Public Class Form1
        Inherits ListViewExamplesControl
        Public Overrides ReadOnly Property ContentControl() As Control
            Get
                Return Me.radPanel1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            Dim searchIcon As New ImagePrimitive()
            searchIcon.Image = My.Resources.TV_search
            searchIcon.Alignment = ContentAlignment.MiddleRight
            Me.commandBarTextBoxFilter.TextBoxElement.StretchHorizontally = True
            Me.commandBarTextBoxFilter.TextBoxElement.Alignment = ContentAlignment.MiddleRight
            Me.commandBarTextBoxFilter.TextBoxElement.Children.Add(searchIcon)
            Me.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
            AddHandler Me.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged

            AddHandler Me.radListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
            AddHandler Me.radListView1.ViewTypeChanged, AddressOf radListView1_ViewTypeChanged
            AddHandler Me.radListView1.CellFormatting, AddressOf radListView1_CellFormatting
            AddHandler Me.radListView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged

            Me.radListView1.AllowEdit = False
            Me.radListView1.AllowRemove = False

            Me.radListView1_ViewTypeChanged(Me, EventArgs.Empty)
        End Sub

        Private Sub SortDescriptors_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
	        If Me.radListView1.SortDescriptors.Count = 0 Then
		        Me.commandBarDropDownSort.SelectedIndex = 0
		        Return
	        End If

	        Dim columnName As String = Me.radListView1.Columns(Me.radListView1.SortDescriptors(0).PropertyName).HeaderText
	        If columnName = "Manufactured" Then
		        columnName = "Year"
	        End If
	        Dim item As RadListDataItem = Me.commandBarDropDownSort.ListElement.FindItemExact(columnName, False)
	        If item IsNot Nothing Then
		        Me.commandBarDropDownSort.SelectedItem = item
	        End If
        End Sub

        Private Sub radListView1_BindingCompleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles radListView1.BindingCompleted
            Me.radListView1.Columns("ImageFileName").Width = 180
            Me.radListView1.Columns("ImageFileName").MinWidth = 180
            Me.radListView1.Columns("Make").Width = 90
            Me.radListView1.Columns("Make").MinWidth = 90
            Me.radListView1.Columns("Model").Width = 110
            Me.radListView1.Columns("Model").MinWidth = 110
            Me.radListView1.Columns("CarYear").Width = 90
            Me.radListView1.Columns("CarYear").MinWidth = 90
            Me.radListView1.Columns("CategoryName").Width = 90
            Me.radListView1.Columns("CategoryName").MinWidth = 90
            Me.radListView1.Columns("Daily").Width = 80
            Me.radListView1.Columns("Daily").MinWidth = 80
            Me.radListView1.Columns("Weekly").Width = 80
            Me.radListView1.Columns("Weekly").MinWidth = 80
            Me.radListView1.Columns("Monthly").Width = 80
            Me.radListView1.Columns("Monthly").MinWidth = 80

            Dim pictureColumnIndex As Integer = Me.radListView1.Columns.IndexOf("ImageFileName")
            Me.radListView1.Columns.Move(pictureColumnIndex, 0)
        End Sub

        Private Sub radListView1_ColumnCreating(ByVal sender As Object, ByVal e As ListViewColumnCreatingEventArgs) Handles radListView1.ColumnCreating
            If e.Column.FieldName = "CarID" Then
                e.Column.Visible = False
            End If

            If e.Column.FieldName = "ImageFileName" Then
                e.Column.HeaderText = "Picture"
            End If

            If e.Column.FieldName = "CarYear" Then
                e.Column.HeaderText = "Manufactured"
            End If

            If e.Column.FieldName = "CategoryName" Then
                e.Column.HeaderText = "Category"
            End If

            If e.Column.FieldName = "Mp3Player" Then
                e.Column.HeaderText = "MP3"
            End If

            If e.Column.FieldName = "DVDPlayer" Then
                e.Column.HeaderText = "DVD"
            End If

            If e.Column.FieldName = "AirConditioner" Then
                e.Column.HeaderText = "Air Cond."
                e.Column.Width = 90
                e.Column.MinWidth = 90
            End If

            If e.Column.FieldName = "Daily" OrElse e.Column.FieldName = "Weekly" OrElse e.Column.FieldName = "Monthly" OrElse e.Column.FieldName = "Available" Then
                e.Column.Visible = False
            End If

            If features.Contains(e.Column.FieldName) Then
                e.Column.Width = 55
                e.Column.MinWidth = 55
            End If
        End Sub

        Private Sub radListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
            If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
                Return
            End If

            If e.CellElement.Data.HeaderText = "Picture" Then
                DirectCast(e.CellElement, DetailListViewDataCellElement).Image = DirectCast(e.CellElement, DetailListViewDataCellElement).Row.Image
                e.CellElement.Text = ""
                e.CellElement.ImageAlignment = ContentAlignment.MiddleCenter
                e.CellElement.TextImageRelation = TextImageRelation.Overlay
            Else
                e.CellElement.Image = Nothing
            End If

            If e.CellElement.Data.HeaderText = "Make" OrElse e.CellElement.Data.HeaderText = "Model" Then
                e.CellElement.Text = "<html><span style=""color:#161112;font-size:11.5pt;"">" & e.CellElement.Text & "</span>"
            ElseIf Me.features.Contains(e.CellElement.Data.FieldName) Then
                Dim containsFeature As Boolean = Me.ContainsFeature(DirectCast(e.CellElement, DetailListViewDataCellElement).Row, e.CellElement.Data.FieldName)
                Dim color As String = If((containsFeature), "050F70", "B52822")
                Dim text As String = If((containsFeature), "YES", "NO")
                e.CellElement.Text = "<html><span style=""color:#" & color & ";font-size:10pt;"">" & text & "</span>"
            Else
                e.CellElement.Text = "<html><span style=""color:#050F70;font-size:10pt;"">" & e.CellElement.Text & "</span>"
            End If
        End Sub

        Private Sub radListView1_ViewTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case radListView1.ViewType
                Case ListViewType.ListView
                    SetupSimpleListView()
                    Exit Select
                Case ListViewType.IconsView
                    SetupIconsView()
                    Exit Select
                Case ListViewType.DetailsView
                    SetupDetailsView()
                    Exit Select
            End Select
        End Sub

        Private Sub SetupDetailsView()
            Me.radListView1.ItemSize = New Size(0, 110)
        End Sub

        Private Sub SetupIconsView()
            Me.radListView1.ItemSize = New Size(295, 120)
            Me.radListView1.ItemSpacing = 5
            Me.radListView1.GroupIndent = 0
        End Sub

        Private Sub SetupSimpleListView()
            Me.radListView1.AllowArbitraryItemHeight = True

        End Sub

        Private features As New List(Of String)() From {"AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation"}

        Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
            Return item(feature) IsNot Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
        End Function

        Private Function GetFeatures(ByVal item As ListViewDataItem) As String
            Dim featuresString As New StringBuilder()

            For Each feature As String In Me.features
                If ContainsFeature(item, feature) Then
                    featuresString.Append(feature & ", ")
                End If
            Next

            If featuresString.Length > 1 Then
                featuresString.Remove(featuresString.Length - 2, 2)
            End If

            Return featuresString.ToString()
        End Function


        Private Sub radListView1_VisualItemCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs) Handles radListView1.VisualItemCreating
            If Me.radListView1.ViewType = ListViewType.ListView AndAlso Not (TypeOf e.VisualItem Is BaseListViewGroupVisualItem) Then
                e.VisualItem = New CarsListVisualItem()
            End If
        End Sub

        Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemEventArgs)
            If TypeOf e.VisualItem Is BaseListViewGroupVisualItem Then
                Return
            End If

            If Me.radListView1.ViewType = ListViewType.IconsView Then
                e.VisualItem.Text = "<html>" & "<span style=""color:#040203;font-size:12pt;"">" & e.VisualItem.Data("Make") & " " & e.VisualItem.Data("Model") & "</span>" & "<br><span style=""color:#040203;font-size:9pt;"">" & e.VisualItem.Data("CarYear") & ", " & e.VisualItem.Data("CategoryName") & "</span>" & "<br><br><span style=""color:#112164;font-size:9pt;"">" & GetFeatures(e.VisualItem.Data) & "</span>"

                e.VisualItem.ImageLayout = ImageLayout.Center
                e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter
            End If

            If Me.radListView1.ViewType = ListViewType.ListView Then
                e.VisualItem.Padding = New Padding(5, 5, 0, 5)
                e.VisualItem.Layout.LeftPart.Margin = New Padding(0, 0, 5, 0)
            End If
        End Sub

        Private Sub radListView1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles radListView1.ItemDataBound
            e.Item.Image = Image.FromFile(Application.StartupPath & "\Resources\CarRentalImages\" & e.Item("ImageFileName"))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.carsRatesDataTableTableAdapter.Fill(Me.sofiaCarRentalDataSet.CarsRatesDataTable)

            Me.commandBarDropDownGroup.SelectedIndex = 1
        End Sub

        Private updatingToggleState As Boolean = False

        Private Sub ViewToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles commandBarToggleList.ToggleStateChanged, commandBarToggleTiles.ToggleStateChanged, commandBarToggleDetails.ToggleStateChanged
            If updatingToggleState Then
                Return
            End If

            Me.updatingToggleState = True

            If Not Object.Equals(Me.commandBarToggleDetails, sender) Then
                Me.commandBarToggleDetails.ToggleState = ToggleState.Off
            End If

            If Not Object.Equals(Me.commandBarToggleList, sender) Then
                Me.commandBarToggleList.ToggleState = ToggleState.Off
            End If

            If Not Object.Equals(Me.commandBarToggleTiles, sender) Then
                Me.commandBarToggleTiles.ToggleState = ToggleState.Off
            End If

            Me.updatingToggleState = False

            If Me.commandBarToggleDetails.ToggleState = ToggleState.[On] Then
                Me.radListView1.ViewType = ListViewType.DetailsView
            End If

            If Me.commandBarToggleList.ToggleState = ToggleState.[On] Then
                Me.radListView1.ViewType = ListViewType.ListView
            End If

            If Me.commandBarToggleTiles.ToggleState = ToggleState.[On] Then
                Me.radListView1.ViewType = ListViewType.IconsView
            End If

        End Sub

        Private Sub ViewToggleButton_ToggleStateChanging(ByVal sender As Object, ByVal args As StateChangingEventArgs) Handles commandBarToggleList.ToggleStateChanging, commandBarToggleTiles.ToggleStateChanging, commandBarToggleDetails.ToggleStateChanging
            If Not updatingToggleState AndAlso args.OldValue = ToggleState.[On] Then
                args.Cancel = True
            End If
        End Sub

        Private Sub commandBarDropDownSort_SelecedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownSort.SelectedIndexChanged
            RemoveHandler Me.radListView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged

            Me.radListView1.SortDescriptors.Clear()
            Select Case Me.commandBarDropDownSort.Text
                Case "Make"
                    Me.radListView1.SortDescriptors.Add(New SortDescriptor("Make", ListSortDirection.Ascending))
                    Me.radListView1.EnableSorting = True
                    Exit Select
                Case "Model"
                    Me.radListView1.SortDescriptors.Add(New SortDescriptor("Model", ListSortDirection.Ascending))
                    Me.radListView1.EnableSorting = True
                    Exit Select
                Case "Category"
                    Me.radListView1.SortDescriptors.Add(New SortDescriptor("CategoryName", ListSortDirection.Ascending))
                    Me.radListView1.EnableSorting = True
                    Exit Select
                Case "Year"
                    Me.radListView1.SortDescriptors.Add(New SortDescriptor("CarYear", ListSortDirection.Ascending))
                    Me.radListView1.EnableSorting = True
                    Exit Select
            End Select

            AddHandler Me.radListView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged
        End Sub

        Private Sub commandBarDropDownGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownGroup.SelectedIndexChanged
            Me.radListView1.GroupDescriptors.Clear()
            Select Case Me.commandBarDropDownGroup.Text
                Case "None"
                    Me.radListView1.EnableGrouping = False
                    Me.radListView1.ShowGroups = False
                    Exit Select
                Case "Make"
                    Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() {New SortDescriptor("Make", ListSortDirection.Ascending)}))
                    Me.radListView1.EnableGrouping = True
                    Me.radListView1.ShowGroups = True
                    Exit Select
                Case "Category"
                    Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() {New SortDescriptor("CategoryName", ListSortDirection.Ascending)}))
                    Me.radListView1.EnableGrouping = True
                    Me.radListView1.ShowGroups = True
                    Exit Select
                Case "Year"
                    Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() {New SortDescriptor("CarYear", ListSortDirection.Ascending)}))
                    Me.radListView1.EnableGrouping = True
                    Me.radListView1.ShowGroups = True
                    Exit Select
            End Select
        End Sub

        Private Sub commandBarTextBoxFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles commandBarTextBoxFilter.TextChanged
            Me.radListView1.FilterDescriptors.Clear()

            If [String].IsNullOrEmpty(Me.commandBarTextBoxFilter.Text) Then
                Me.radListView1.EnableFiltering = False
            Else
                Me.radListView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.[Or]
                Me.radListView1.FilterDescriptors.Add("Make", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
                Me.radListView1.FilterDescriptors.Add("Model", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
                Me.radListView1.EnableFiltering = True
            End If
        End Sub

        Private Sub TextBoxItem_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            If e.PropertyName = "Bounds" Then
                commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(CInt(commandBarTextBoxFilter.DesiredSize.Width) - 28, 0)
            End If
        End Sub
    End Class

    Public Class CarsListVisualItem
        Inherits SimpleListViewVisualItem
        Private element1 As LightVisualElement
        Private element2 As LightVisualElement
        Private element3 As LightVisualElement
        Private element4 As LightVisualElement
        Private layout As StackLayoutPanel

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.layout = New StackLayoutPanel()
            Me.layout.EqualChildrenWidth = True
            Me.layout.Margin = New Padding(180, 30, 0, 0)

            Me.element1 = New LightVisualElement()
            element1.TextAlignment = ContentAlignment.MiddleLeft
            element1.MinSize = New Size(170, 0)
            element1.NotifyParentOnMouseInput = True
            element1.ShouldHandleMouseInput = False
            Me.layout.Children.Add(Me.element1)

            Me.element2 = New LightVisualElement()
            element2.TextAlignment = ContentAlignment.MiddleLeft
            element2.MinSize = New Size(170, 0)
            element2.NotifyParentOnMouseInput = True
            element2.ShouldHandleMouseInput = False
            Me.layout.Children.Add(Me.element2)

            Me.element3 = New LightVisualElement()
            element3.TextAlignment = ContentAlignment.MiddleLeft
            element3.MinSize = New Size(170, 0)
            element3.NotifyParentOnMouseInput = True
            element3.ShouldHandleMouseInput = False
            Me.layout.Children.Add(Me.element3)

            Me.element4 = New LightVisualElement()
            element4.TextAlignment = ContentAlignment.MiddleLeft
            element4.MinSize = New Size(170, 0)
            element4.NotifyParentOnMouseInput = True
            element4.ShouldHandleMouseInput = False
            Me.layout.Children.Add(Me.element4)

            Me.Children.Add(Me.layout)
        End Sub

        Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
            Return item(feature) IsNot Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
        End Function

        Protected Overrides Sub SynchronizeProperties()
            MyBase.SynchronizeProperties()

            Me.Text = "<html><span style=""color:#141718;font-size:14.5pt;"">" & Me.Data("Make") & " " & Me.Data("Model") & "</span>"

            Me.element1.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Manufactured:<span style=""color:#13224D;font-family:Segoe UI;"">" & Me.Data("CarYear") & "</span>" & "<br>Category:<span style=""color:#13224D;font-family:Segoe UI;"">" & Me.Data("CategoryName") & "</span></span>"

            Me.element2.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "ABS:" & (If(Me.ContainsFeature(Me.Data, "ABS"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "<br>ESR:" & (If(Me.ContainsFeature(Me.Data, "ESR"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "</span>"

            Me.element3.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "MP3 Player:" & (If(Me.ContainsFeature(Me.Data, "Mp3Player"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "<br>DVD Player:" & (If(Me.ContainsFeature(Me.Data, "DVDPlayer"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "</span>"

            Me.element4.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Air Conditioner:" & (If(Me.ContainsFeature(Me.Data, "AirConditioner"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "<br>Navigation:" & (If(Me.ContainsFeature(Me.Data, "Navigation"), "<span style=""color:#13224D;font-family:Segoe UI;"">YES", "<span style=""color:#D71B0E;"">NO")) & "</span>" & "</span>"

            Me.TextAlignment = ContentAlignment.TopLeft
        End Sub

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(SimpleListViewVisualItem)
            End Get
        End Property



    End Class
End Namespace