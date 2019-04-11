Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.CreateItemVisualAndItemsFormatting
	Public Partial Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private Const NumberOfObjects As Integer = 5
		Private list As BussinessObject() = New BussinessObject(NumberOfObjects - 1){}

		#End Region

		#Region "Initialization"

		Public Sub New()
			InitializeComponent()
			AddHandler Me.radListControl1.ItemDataBinding, AddressOf ItemDataBinding
			AddHandler Me.radListControl1.ItemDataBound, AddressOf ItemDataBound

			AddHandler Me.radDropDownList1.ItemDataBinding, AddressOf ItemDataBinding
			AddHandler Me.radDropDownList1.ItemDataBound, AddressOf ItemDataBound


			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme Or QSFButtons.TransparentBackground, False)
			Me.CreateObjects()
			Me.PrepareDataSourceAndShowDropDown()
		End Sub

		Private Sub CreateObjects()
			For i As Integer = 0 To NumberOfObjects - 1
				Dim businessObject As BussinessObject = New BussinessObject()
				businessObject.Available = (i Mod 2) = 0
				businessObject.Name = " Item " & (i + 1)
				list(i) = businessObject
				AddHandler businessObject.PropertyChanged, AddressOf businessObject_PropertyChanged
			Next i
		End Sub

		Private Sub businessObject_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			Me.radDropDownList1.Update()
			Me.radListControl1.Update()
		End Sub

		Private Sub PrepareDataSourceAndShowDropDown()
			Me.radDropDownList1.DataSource = Nothing
			Me.radDropDownList1.DisplayMember = "Name"
			Me.radDropDownList1.ValueMember = "Available"
			Me.radDropDownList1.DataSource = list

			Me.radListControl1.DataSource = Nothing
			Me.radListControl1.DisplayMember = "Name"
			Me.radListControl1.ValueMember = "Available"
			Me.radListControl1.DataSource = list

			Me.radDropDownList1.DropDownSizingMode = SizingMode.UpDownAndRightBottom
			Me.radDropDownList1.ShowDropDown()
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs)
			Dim listDataItem As CustomListDataItem = CType(args.NewItem, CustomListDataItem)
			Dim dataObject As BussinessObject = CType(listDataItem.DataBoundItem, BussinessObject)

			listDataItem.Name = dataObject.Name
			listDataItem.Available = dataObject.Available
		End Sub

		Private Sub ItemDataBinding(ByVal sender As Object, ByVal args As ListItemDataBindingEventArgs)
			args.NewItem = New CustomListDataItem()
		End Sub

		Private Sub CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New CustomListVisualItem()
		End Sub

		#End Region

		#Region "Overrides"

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		#End Region
	End Class

	Public Class BussinessObject
		Implements INotifyPropertyChanged
		#Region "Fields"

		Private name_Renamed As String
		Private available_Renamed As Boolean

		#End Region

		#Region "Properties"

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set
				If Me.name_Renamed = Value Then
					Return
				End If

				Me.name_Renamed = Value
				Me.OnNotifyPropertyChanged("Name")
			End Set
		End Property

		Public Property Available() As Boolean
			Get
				Return Me.available_Renamed
			End Get
			Set
				If Me.available_Renamed = Value Then
					Return
				End If

				Me.available_Renamed = Value
				Me.OnNotifyPropertyChanged("Available")
			End Set
		End Property

		#End Region

		#Region "INotifyPropertyChanged Implementation"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub OnNotifyPropertyChanged(ByVal [property] As String)
			If Not Me.PropertyChangedEvent Is Nothing Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
			End If
		End Sub

		#End Region
	End Class

	Public Class CustomListDataItem
		Inherits RadListDataItem
		#Region "RadProperties"

		Public Shared ReadOnly AvailableProperty As RadProperty = RadProperty.Register("Available", GetType(Boolean), GetType(CustomListDataItem), New RadElementPropertyMetadata(False))
		Public Shared ReadOnly NameProperty As RadProperty = RadProperty.Register("Name", GetType(String), GetType(CustomListDataItem), New RadElementPropertyMetadata(""))

		#End Region

		#Region "Properties"

		Public Property Available() As Boolean
			Get
				Return CBool(Me.GetValue(CustomListDataItem.AvailableProperty))
			End Get
			Set
				Me.SetValue(CustomListDataItem.AvailableProperty, Value)
			End Set
		End Property

		Public Property Name() As String
			Get
				Return CStr(Me.GetValue(CustomListDataItem.NameProperty))
			End Get
			Set
				Me.SetValue(CustomListDataItem.NameProperty, Value)
			End Set
		End Property

		#End Region

		#Region "Overrides"

		Protected Overrides Sub SetDataBoundItem(ByVal dataBinding As Boolean, ByVal value As Object)
			MyBase.SetDataBoundItem(dataBinding, value)
			If TypeOf value Is INotifyPropertyChanged Then
				Dim item As INotifyPropertyChanged = TryCast(value, INotifyPropertyChanged)
				AddHandler item.PropertyChanged, AddressOf item_PropertyChanged
			End If
		End Sub

		#End Region

		#Region "Private Methods"

		Private Sub item_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Available" Then
				Me.Available = (TryCast(Me.DataBoundItem, BussinessObject)).Available
			End If

			If e.PropertyName = "Name" Then
				Me.Name = (TryCast(Me.DataBoundItem, BussinessObject)).Name
			End If
		End Sub

		#End Region
	End Class

    Public Class CustomListVisualItem
        Inherits RadListVisualItem

#Region "Fields"

        Private label As RadLabelElement
        Private checkBox As RadCheckBoxElement

#End Region

#Region "Initialization"

        Shared Sub New()
            RadListVisualItem.SynchronizationProperties.Add(CustomListDataItem.AvailableProperty)
            RadListVisualItem.SynchronizationProperties.Add(CustomListDataItem.NameProperty)
        End Sub

#End Region

#Region "Overrides"

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(RadListVisualItem)
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.label = New RadLabelElement()
            Me.checkBox = New RadCheckBoxElement()

            AddHandler Me.checkBox.ToggleStateChanged, AddressOf ToggleStateChanged
            Me.label.StretchHorizontally = True
            Dim stack As StackLayoutPanel = New StackLayoutPanel()
            stack.Orientation = Orientation.Horizontal
            stack.Children.Add(checkBox)
            stack.Children.Add(label)
            Me.Children.Add(stack)
        End Sub

        Protected Overrides Sub PropertySynchronized(ByVal [property] As RadProperty)
            Dim dataItem As CustomListDataItem = CType(Me.Data, CustomListDataItem)

            If [property] Is CustomListDataItem.AvailableProperty Then
                Dim newValue As Boolean = dataItem.Available

                Me.checkBox.Checked = newValue

                Dim itemName As String = dataItem.Name
                Me.label.Text = Me.GetAvailabilityText(itemName, newValue)
            End If

            If [property] Is CustomListDataItem.NameProperty Then
                Dim itemName As String = dataItem.Name
                Dim available As Boolean = dataItem.Available
                Me.label.Text = Me.GetAvailabilityText(itemName, available)
            End If

            Me.Text = ""
        End Sub

#End Region

#Region "Private Methods"

        Private Function GetAvailabilityText(ByVal itemName As String, ByVal available As Boolean) As String
            Dim yesno As String
            If available Then
                yesno = " "
            Else
                yesno = " not "
            End If
            Return itemName & " is" & yesno & "available"
        End Function

        Private Sub ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            CType(Me.Data.DataBoundItem, BussinessObject).Available = Me.checkBox.Checked
        End Sub

#End Region
    End Class
End Namespace
