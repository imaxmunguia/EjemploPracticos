Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.TableElement
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting

			Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)

			Me.radGridView1.TableElement.RowHeight = 50
			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.EnableAlternatingRowColor = True

			Me.radSpinEditorRowHeight.Value = Me.radGridView1.TableElement.RowHeight
			Me.radSpinEditorHeaderHeight.Value = Me.radGridView1.TableElement.TableHeaderHeight
			Me.radSpinEditorGroupRowHeight.Value = Me.radGridView1.TableElement.GroupHeaderHeight
			Me.radSpinEditorCellSpacing.Value = Me.radGridView1.TableElement.CellSpacing
			Me.radSpinEditorRowSpacing.Value = Me.radGridView1.TableElement.RowSpacing
			Me.radCheckBoxGroupPanel.ToggleState = If(Me.radGridView1.ShowGroupPanel, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxColumnHeaders.ToggleState = If(Me.radGridView1.MasterTemplate.ShowColumnHeaders, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxRowHeader.ToggleState = If(Me.radGridView1.MasterTemplate.ShowRowHeaderColumn, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxAutoSize.ToggleState = If(Me.radGridView1.AutoSizeRows, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxAlternate.ToggleState = If(Me.radGridView1.EnableAlternatingRowColor, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxHotTracking.ToggleState = If(Me.radGridView1.EnableHotTracking, ToggleState.On, ToggleState.Off)

			If Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill Then
				Me.radCheckBoxFit.ToggleState = ToggleState.On
			Else
				Me.radCheckBoxFit.ToggleState = ToggleState.Off
			End If

            Me.radSpinEditorHeaderHeight.Value = 30
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
			If TypeOf e.CellElement Is GridImageCellElement Then
				e.CellElement.ImageLayout = ImageLayout.Zoom
			End If
		End Sub

		Private Sub radSpinEditorRowHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorRowHeight.ValueChanged
			Me.radGridView1.TableElement.RowHeight = CInt(Fix(Me.radSpinEditorRowHeight.Value))
		End Sub

		Private Sub radSpinEditorHeaderHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorHeaderHeight.ValueChanged
			Me.radGridView1.TableElement.TableHeaderHeight = CInt(Fix(Me.radSpinEditorHeaderHeight.Value))
		End Sub

		Private Sub radSpinEditorGroupRowHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorGroupRowHeight.ValueChanged
			Me.radGridView1.TableElement.GroupHeaderHeight = CInt(Fix(Me.radSpinEditorGroupRowHeight.Value))
		End Sub

		Private Sub radSpinEditorCellSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorCellSpacing.ValueChanged
			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(Me.radSpinEditorCellSpacing.Value))
		End Sub

		Private Sub radSpinEditorRowSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorRowSpacing.ValueChanged
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(Me.radSpinEditorRowSpacing.Value))
		End Sub

		Private Sub radCheckBoxGroupPanel_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxGroupPanel.ToggleStateChanged
			Me.radGridView1.ShowGroupPanel = If(Me.radCheckBoxGroupPanel.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxColumnHeaders_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxColumnHeaders.ToggleStateChanged
			Me.radGridView1.MasterTemplate.ShowColumnHeaders = If(Me.radCheckBoxColumnHeaders.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxRowHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxRowHeader.ToggleStateChanged
			Me.radGridView1.MasterTemplate.ShowRowHeaderColumn = If(Me.radCheckBoxRowHeader.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxAutoSize_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxAutoSize.ToggleStateChanged
			Me.radGridView1.AutoSizeRows = If(Me.radCheckBoxAutoSize.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxFit_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxFit.ToggleStateChanged
			If radCheckBoxFit.ToggleState = ToggleState.On Then
				Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Else
				Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If
		End Sub

		Private Sub radCheckBoxAlternate_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxAlternate.ToggleStateChanged
			Me.radGridView1.EnableAlternatingRowColor = If(radCheckBoxAlternate.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxHotTracking_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxHotTracking.ToggleStateChanged
			Me.radGridView1.EnableHotTracking = If(Me.radCheckBoxHotTracking.ToggleState = ToggleState.On, True, False)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
