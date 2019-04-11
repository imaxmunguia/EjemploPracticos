Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports System.Runtime.CompilerServices

Namespace Telerik.WinControls.UI
	'''<exclude/>
	''' <summary>
	''' The root element of ScrollPanel has 2 scrollbars and handles them.
	''' Its child is a LayoutPanel that handles the arrangement of elements
	''' in the ScrollPanel.
	''' </summary>
#If RIBBONBAR Then
	<ToolboxItem(False), DefaultProperty("Value"), DefaultEvent("Scroll")> _
	Friend Class RadTestScrollView
		Inherits RadControl
#Else
	<ToolboxItem(False), DefaultProperty("Value"), DefaultEvent("Scroll")> _
	Public Class RadTestScrollView
		Inherits RadControl
#End If
		Private scrollView As RadScrollViewer

		Private background As FillPrimitive
		Private arrow As ArrowPrimitive
		Private rectangle As RectanglePrimitive

		#Region "Events"
		Public Shadows Event Scroll As RadScrollPanelHandler
		Public Event ScrollNeedsChanged As ScrollNeedsHandler
		Public Event ScrollParametersChanged As RadPanelScrollParametersHandler
		#End Region

		Public Sub New()
			backgroundAdded = False
			arrowAdded = False
			squareAdded = False
		End Sub

		#Region "Properties"
		Public ReadOnly Property MinValue() As Point
			Get
				Return Me.scrollView.MinValue
			End Get
		End Property

		Public ReadOnly Property MaxValue() As Point
			Get
				Return Me.scrollView.MaxValue
			End Get
		End Property

		Public Property Value() As Point
			Get
				Return Me.scrollView.Value
			End Get
			Set(ByVal value As Point)
				Me.scrollView.Value = value
			End Set
		End Property

		Public Property UsePhysicalScrolling() As Boolean
			Get
				Return Me.scrollView.UsePhysicalScrolling
			End Get

			Set(ByVal value As Boolean)
				Me.scrollView.UsePhysicalScrolling = value
			End Set
		End Property
		#End Region

		#Region "Operations"
		Private backgroundAdded As Boolean
		Public Sub ManageBackground()
			If background Is Nothing Then
				Return
			End If

			If backgroundAdded Then
				scrollView.Children.Remove(background)
			Else
				scrollView.Children.Insert(0, background)
			End If
			backgroundAdded = Not backgroundAdded

			Invalidate()
		End Sub

		Private squareAdded As Boolean
		Public Sub ManageSquare()
			If squareAdded Then
				scrollView.Viewport.Children.Remove(rectangle) '.Items.Remove(rectangle);
			Else
				scrollView.Viewport.Children.Add(rectangle) '.Items.Add(rectangle);
			End If
			squareAdded = Not squareAdded

			Invalidate()
		End Sub

		Private arrowAdded As Boolean
		Public Sub ManageTriangle()
			If arrowAdded Then
				scrollView.Viewport.Children.Remove(arrow) '.Items.Remove(arrow);
			Else
				scrollView.Viewport.Children.Add(arrow) '.Items.Add(arrow);
			End If
			arrowAdded = Not arrowAdded

			Invalidate()
		End Sub

		Public Sub ScrollToTriangle()
			If arrowAdded Then
				scrollView.ScrollElementIntoView(arrow)
			End If
		End Sub

		Public Sub ScrollToSquare()
			If squareAdded Then
				scrollView.ScrollElementIntoView(rectangle)
			End If
		End Sub

		Public Sub SetHorizontalState(ByVal newState As ScrollState)
			If scrollView IsNot Nothing AndAlso scrollView.HorizontalScrollState <> newState Then
				scrollView.HorizontalScrollState = newState
			End If
		End Sub

		Public Sub SetVerticalState(ByVal newState As ScrollState)
			If scrollView IsNot Nothing AndAlso scrollView.VerticalScrollState <> newState Then
				scrollView.VerticalScrollState = newState
			End If
		End Sub
		#End Region

		Protected Overridable Sub OnScroll(ByVal args As ScrollPanelEventArgs)
			RaiseEvent Scroll(Me, args)
		End Sub

		Protected Overridable Sub OnScrollNeedsChanged(ByVal args As ScrollNeedsEventArgs)
			RaiseEvent ScrollNeedsChanged(Me, args)
		End Sub

		Protected Overridable Sub OnScrollParametersChanged(ByVal args As RadPanelScrollParametersEventArgs)
			RaiseEvent ScrollParametersChanged(Me, args)
		End Sub

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Dim viewport As New RadCanvasViewport()

			Me.scrollView = New RadScrollViewer(viewport)
			Me.scrollView.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
			AddHandler Me.scrollView.Scroll, AddressOf AnonymousMethod1
			AddHandler Me.scrollView.ScrollNeedsChanged, AddressOf AnonymousMethod2
			AddHandler Me.scrollView.ScrollParametersChanged, AddressOf AnonymousMethod3

			Me.rectangle = New RectanglePrimitive()
			Me.rectangle.AutoSize = False
			Me.rectangle.SetBounds(10, 10, 190, 190)
			Me.rectangle.ForeColor = Color.Black
			Me.rectangle.BackColor = Color.Aqua

			Me.arrow = New ArrowPrimitive()
			Me.arrow.AutoSize = False
			Me.arrow.SetBounds(210, 210, 190, 190)
			Me.arrow.ForeColor = Color.Black
			Me.arrow.BackColor = Color.Wheat

			Me.RootElement.Children.Add(Me.scrollView)
			For Each child As RadElement In Me.scrollView.Children
				If child.Class = "RadScrollViewFill" AndAlso TypeOf child Is FillPrimitive Then
					background = CType(child, FillPrimitive)
					Exit For
				End If
			Next child

			Me.backgroundAdded = True
			Me.scrollView.Viewport.Children.Add(rectangle)
			Me.squareAdded = True
			Me.scrollView.Viewport.Children.Add(arrow)
			Me.arrowAdded = True


			Me.ThemeName = ""
		End Sub
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal args As ScrollPanelEventArgs)
			OnScroll(args)
		End Sub
		Private Sub AnonymousMethod2(ByVal sender As Object, ByVal args As ScrollNeedsEventArgs)
			OnScrollNeedsChanged(args)
		End Sub
		Private Sub AnonymousMethod3(ByVal sender As Object, ByVal args As RadPanelScrollParametersEventArgs)
			OnScrollParametersChanged(args)
		End Sub
	End Class
End Namespace
