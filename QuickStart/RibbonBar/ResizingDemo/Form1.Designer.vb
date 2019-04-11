Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports System.Drawing

Namespace Telerik.Examples.WinControls.RibbonBar.ResizingDemo
	Partial Friend Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
			Me.radRibbonBarBackstageView1 = New Telerik.WinControls.UI.RadRibbonBarBackstageView()
			Me.backstageViewPage3 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.radSeparator2 = New Telerik.WinControls.UI.RadSeparator()
			Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.backstageViewPage5 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.flowLayoutPanel1 = New MyFlowLayoutPanel()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radButton5 = New Telerik.WinControls.UI.RadButton()
			Me.radButton6 = New Telerik.WinControls.UI.RadButton()
			Me.radButton7 = New Telerik.WinControls.UI.RadButton()
			Me.radButton8 = New Telerik.WinControls.UI.RadButton()
			Me.radButton9 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator3 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.backstageViewPage2 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewItemPage1 = New Telerik.WinControls.UI.RadPageViewItemPage()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton13 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator8 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton12 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator7 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton11 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator6 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel13 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton14 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator9 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radButton15 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel14 = New Telerik.WinControls.UI.RadLabel()
			Me.radSeparator10 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel15 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewItemPage2 = New Telerik.WinControls.UI.RadPageViewItemPage()
			Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radButton24 = New Telerik.WinControls.UI.RadButton()
			Me.flowLayoutPanel2 = New MyFlowLayoutPanel()
			Me.radLabel17 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton16 = New Telerik.WinControls.UI.RadButton()
			Me.radButton17 = New Telerik.WinControls.UI.RadButton()
			Me.radButton18 = New Telerik.WinControls.UI.RadButton()
			Me.radButton19 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel18 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton20 = New Telerik.WinControls.UI.RadButton()
			Me.radButton21 = New Telerik.WinControls.UI.RadButton()
			Me.radButton22 = New Telerik.WinControls.UI.RadButton()
			Me.radButton23 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator11 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel16 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage6 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radButton25 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel19 = New Telerik.WinControls.UI.RadLabel()
			Me.radSeparator12 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel20 = New Telerik.WinControls.UI.RadLabel()
			Me.backstageViewPage1 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.radLabel24 = New Telerik.WinControls.UI.RadLabel()
			Me.radSeparator16 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel23 = New Telerik.WinControls.UI.RadLabel()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.radButton29 = New Telerik.WinControls.UI.RadButton()
			Me.radButton30 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator14 = New Telerik.WinControls.UI.RadSeparator()
			Me.radSeparator15 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel22 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton28 = New Telerik.WinControls.UI.RadButton()
			Me.radButton27 = New Telerik.WinControls.UI.RadButton()
			Me.radButton26 = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator13 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel21 = New Telerik.WinControls.UI.RadLabel()
			Me.backstageViewPage4 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.radSeparator19 = New Telerik.WinControls.UI.RadSeparator()
			Me.recentPlacesListControl = New Telerik.WinControls.UI.RadListControl()
			Me.recentDocumentsListControl = New Telerik.WinControls.UI.RadListControl()
			Me.radSeparator18 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel26 = New Telerik.WinControls.UI.RadLabel()
			Me.radSeparator17 = New Telerik.WinControls.UI.RadSeparator()
			Me.radLabel25 = New Telerik.WinControls.UI.RadLabel()
			Me.backstageViewPage6 = New Telerik.WinControls.UI.BackstageViewPage()
			Me.radSeparator5 = New Telerik.WinControls.UI.RadSeparator()
			Me.radSeparator4 = New Telerik.WinControls.UI.RadSeparator()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton10 = New Telerik.WinControls.UI.RadButton()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.backstageButtonItem1 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.backstageButtonItem2 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.backstageButtonItem3 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.backstageButtonItem4 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.backstageTabItem1 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageTabItem2 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageTabItem3 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageTabItem4 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageTabItem5 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageTabItem6 = New Telerik.WinControls.UI.BackstageTabItem()
			Me.backstageButtonItem5 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.backstageButtonItem6 = New Telerik.WinControls.UI.BackstageButtonItem()
			Me.radRibbonBarCommandTabHome = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarGroup4 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radDropDownButtonElement2 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radRibbonBarButtonGroup3 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement22 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement23 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement24 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup5 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radRibbonBarButtonGroup4 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radDropDownListElement1 = New Telerik.WinControls.UI.RadDropDownListElement()
			Me.radDropDownListElement2 = New Telerik.WinControls.UI.RadDropDownListElement()
			Me.radRibbonBarButtonGroup6 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement27 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup7 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radRibbonBarButtonGroup8 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement28 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement31 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement32 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement33 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement34 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement35 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup5 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement25 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement26 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup6 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radRibbonBarButtonGroup9 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radRibbonBarButtonGroup14 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement53 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement54 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement55 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup15 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement56 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup16 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement51 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement52 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup17 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement50 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup10 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radRibbonBarButtonGroup11 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement43 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement44 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement45 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement46 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup13 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement47 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup12 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement48 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement49 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup7 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radGalleryElement1 = New Telerik.WinControls.UI.RadGalleryElement()
			Me.radGalleryItem1 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem2 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem3 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem4 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem5 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem6 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radButtonElement57 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup8 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radDropDownButtonElement3 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButtonElement58 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement4 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radRibbonBarCommandTab1 = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarChunk2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement30 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement29 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarChunk5 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement11 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarChunk6 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement10 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement8 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement12 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement13 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement14 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement15 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement16 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement1 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radRibbonBarChunk1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup2 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement17 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement18 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarButtonGroup1 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radButtonElement19 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup3 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement20 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement21 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarCommandTab2 = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarChunk7 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement36 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarChunk8 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement37 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement38 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement39 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement40 = New Telerik.WinControls.UI.RadButtonElement()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radButtonElement41 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement42 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement60 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement59 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem2 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem29 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem30 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem31 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem1 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem32 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem33 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem34 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem35 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem36 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem37 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem25 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuHeaderItem3 = New Telerik.WinControls.UI.RadMenuHeaderItem()
			Me.radMenuItem38 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem39 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem40 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem26 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem27 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem28 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radOffice2007ScreenTip1 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip2 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip3 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip4 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.resizingDemoPictureBox1 = New System.Windows.Forms.PictureBox()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRibbonBarBackstageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radRibbonBarBackstageView1.SuspendLayout()
			Me.backstageViewPage3.SuspendLayout()
			CType(Me.radSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewPage5.SuspendLayout()
			Me.flowLayoutPanel1.SuspendLayout()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewPage2.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage4.SuspendLayout()
			CType(Me.radButton15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage5.SuspendLayout()
			CType(Me.radButton24, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.flowLayoutPanel2.SuspendLayout()
			CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton22, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton23, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage6.SuspendLayout()
			CType(Me.radButton25, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewPage1.SuspendLayout()
			CType(Me.radLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton29, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton30, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton28, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton27, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton26, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewPage4.SuspendLayout()
			CType(Me.radSeparator19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.recentPlacesListControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.recentDocumentsListControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewPage6.SuspendLayout()
			CType(Me.radSeparator5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListElement1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListElement2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel1.PanelContainer.SuspendLayout()
			Me.radScrollablePanel1.SuspendLayout()
			CType(Me.resizingDemoPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radRibbonBar1
			' 
			Me.radRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
			Me.radRibbonBar1.AutoSize = True
			Me.radRibbonBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.radRibbonBar1.BackstageControl = Me.radRibbonBarBackstageView1
			Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarCommandTabHome, Me.radRibbonBarCommandTab1, Me.radRibbonBarCommandTab2})
			Me.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radRibbonBar1.EnableKeyMap = True
			' 
			' 
			' 
			Me.radRibbonBar1.ExitButton.AccessibleDescription = "Exit"
			Me.radRibbonBar1.ExitButton.AccessibleName = "Exit"
			Me.radRibbonBar1.ExitButton.Alignment = System.Drawing.ContentAlignment.TopRight
			' 
			' 
			' 
			Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit"
			Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit"
			Me.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.ExitButton.CanFocus = True
			Me.radRibbonBar1.ExitButton.Image = My.Resources.exitButton
			Me.radRibbonBar1.ExitButton.Text = "Exit"
			Me.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.ExitButton.ZIndex = 2
			Me.radRibbonBar1.ImageList = Me.imageList1
			Me.radRibbonBar1.Location = New System.Drawing.Point(0, 0)
			Me.radRibbonBar1.Name = "radRibbonBar1"
			' 
			' 
			' 
			Me.radRibbonBar1.OptionsButton.AccessibleDescription = "Options"
			Me.radRibbonBar1.OptionsButton.AccessibleName = "Options"
			Me.radRibbonBar1.OptionsButton.Alignment = System.Drawing.ContentAlignment.TopRight
			' 
			' 
			' 
			Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options"
			Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options"
			Me.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.OptionsButton.CanFocus = True
			Me.radRibbonBar1.OptionsButton.Image = My.Resources.optionsButton
			Me.radRibbonBar1.OptionsButton.Text = "Options"
			Me.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.OptionsButton.ZIndex = 2
			Me.radRibbonBar1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.radRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement41, Me.radButtonElement42, Me.radButtonElement60, Me.radButtonElement59})
			' 
			' 
			' 
			Me.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radRibbonBar1.RootElement.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.radRibbonBar1.Size = New System.Drawing.Size(988, 159)
			Me.radRibbonBar1.StartButtonImage = (CType(resources.GetObject("radRibbonBar1.StartButtonImage"), System.Drawing.Image))
			Me.radRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem21, Me.radMenuSeparatorItem2, Me.radMenuItem22, Me.radMenuItem23, Me.radMenuItem24, Me.radMenuItem25, Me.radMenuSeparatorItem3, Me.radMenuItem26})
			Me.radRibbonBar1.StartMenuRightColumnItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem6, Me.radMenuItem7, Me.radMenuItem8, Me.radMenuItem27, Me.radMenuItem28})
			Me.radRibbonBar1.StartMenuWidth = 450
			Me.radRibbonBar1.TabIndex = 0
			Me.radRibbonBar1.Text = "Office"
			CType(Me.radRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "Office"
			CType(Me.radRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
			' 
			' radRibbonBarBackstageView1
			' 
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage3)
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage5)
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage2)
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage1)
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage4)
			Me.radRibbonBarBackstageView1.Controls.Add(Me.backstageViewPage6)
			Me.radRibbonBarBackstageView1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.backstageButtonItem1, Me.backstageButtonItem2, Me.backstageButtonItem3, Me.backstageButtonItem4, Me.backstageTabItem1, Me.backstageTabItem2, Me.backstageTabItem3, Me.backstageTabItem4, Me.backstageTabItem5, Me.backstageTabItem6, Me.backstageButtonItem5, Me.backstageButtonItem6})
			Me.radRibbonBarBackstageView1.Location = New System.Drawing.Point(0, 53)
			Me.radRibbonBarBackstageView1.Name = "radRibbonBarBackstageView1"
			Me.radRibbonBarBackstageView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radRibbonBarBackstageView1.SelectedItem = Me.backstageTabItem5
			Me.radRibbonBarBackstageView1.Size = New System.Drawing.Size(988, 520)
			Me.radRibbonBarBackstageView1.TabIndex = 1
'			Me.radRibbonBarBackstageView1.ItemClicked += New System.EventHandler(Of Telerik.WinControls.UI.BackstageItemEventArgs)(Me.radRibbonBarBackstageView1_ItemClicked);
			' 
			' backstageViewPage3
			' 
			Me.backstageViewPage3.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage3.Controls.Add(Me.radSeparator2)
			Me.backstageViewPage3.Controls.Add(Me.radSeparator1)
			Me.backstageViewPage3.Controls.Add(Me.radLabel4)
			Me.backstageViewPage3.Controls.Add(Me.radLabel3)
			Me.backstageViewPage3.Controls.Add(Me.radLabel2)
			Me.backstageViewPage3.Controls.Add(Me.radLabel1)
			Me.backstageViewPage3.Controls.Add(Me.radButton3)
			Me.backstageViewPage3.Controls.Add(Me.radButton2)
			Me.backstageViewPage3.Controls.Add(Me.radButton1)
			Me.backstageViewPage3.Location = New System.Drawing.Point(132, 1)
			Me.backstageViewPage3.Name = "backstageViewPage3"
			Me.backstageViewPage3.Size = New System.Drawing.Size(856, 519)
			Me.backstageViewPage3.TabIndex = 2
			' 
			' radSeparator2
			' 
			Me.radSeparator2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.radSeparator2.Location = New System.Drawing.Point(561, 3)
			Me.radSeparator2.Name = "radSeparator2"
			Me.radSeparator2.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radSeparator2.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator2.Size = New System.Drawing.Size(25, 519)
			Me.radSeparator2.TabIndex = 8
			Me.radSeparator2.Text = "radSeparator2"
			' 
			' radSeparator1
			' 
			Me.radSeparator1.Location = New System.Drawing.Point(17, 45)
			Me.radSeparator1.Name = "radSeparator1"
			Me.radSeparator1.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator1.Size = New System.Drawing.Size(516, 10)
			Me.radSeparator1.TabIndex = 7
			Me.radSeparator1.Text = "radSeparator1"
			' 
			' radLabel4
			' 
			Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel4.Location = New System.Drawing.Point(139, 347)
			Me.radLabel4.Name = "radLabel4"
			' 
			' 
			' 
			Me.radLabel4.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel4.Size = New System.Drawing.Size(209, 32)
			Me.radLabel4.TabIndex = 6
			Me.radLabel4.Text = "<html><b>Versions</b><br>There are no previous versions of this file"
			' 
			' radLabel3
			' 
			Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel3.Location = New System.Drawing.Point(139, 209)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel3.Size = New System.Drawing.Size(346, 32)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "<html><b>Prepare for Sharing</b><br>Before sharing this document, be aware that i" & "t contains author name"
			' 
			' radLabel2
			' 
			Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel2.Location = New System.Drawing.Point(139, 75)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))), (CInt(Fix((CByte(63))))))
			Me.radLabel2.Size = New System.Drawing.Size(315, 32)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "<html><b>Permissions</b><br>Anyone can open, copy and change any part of this doc" & "ument"
			' 
			' radLabel1
			' 
			Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 15F)
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(96))))))
			Me.radLabel1.Location = New System.Drawing.Point(17, 14)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(96))))))
			Me.radLabel1.Size = New System.Drawing.Size(286, 31)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Information about Document1"
			' 
			' radButton3
			' 
			Me.radButton3.Image = My.Resources.versions
			Me.radButton3.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButton3.Location = New System.Drawing.Point(31, 347)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New System.Drawing.Size(84, 84)
			Me.radButton3.TabIndex = 2
			Me.radButton3.Text = "<html>Manage<br>Versions"
			Me.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton2
			' 
			Me.radButton2.Image = My.Resources.issues
			Me.radButton2.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButton2.Location = New System.Drawing.Point(31, 209)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(84, 84)
			Me.radButton2.TabIndex = 1
			Me.radButton2.Text = "<html>Check for<br>Issues"
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton1
			' 
			Me.radButton1.Image = My.Resources.msoffice_menu_encryptdocument
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButton1.Location = New System.Drawing.Point(31, 75)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(84, 84)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "<html>Protect<br>Document"
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' backstageViewPage5
			' 
			Me.backstageViewPage5.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage5.Controls.Add(Me.flowLayoutPanel1)
			Me.backstageViewPage5.Controls.Add(Me.radSeparator3)
			Me.backstageViewPage5.Controls.Add(Me.radLabel5)
			Me.backstageViewPage5.Location = New System.Drawing.Point(132, 1)
			Me.backstageViewPage5.Name = "backstageViewPage5"
			Me.backstageViewPage5.Size = New System.Drawing.Size(856, 519)
			Me.backstageViewPage5.TabIndex = 4
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.Controls.Add(Me.radButton4)
			Me.flowLayoutPanel1.Controls.Add(Me.radButton5)
			Me.flowLayoutPanel1.Controls.Add(Me.radButton6)
			Me.flowLayoutPanel1.Controls.Add(Me.radButton7)
			Me.flowLayoutPanel1.Controls.Add(Me.radButton8)
			Me.flowLayoutPanel1.Controls.Add(Me.radButton9)
			Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 19)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
			Me.flowLayoutPanel1.Size = New System.Drawing.Size(856, 500)
			Me.flowLayoutPanel1.TabIndex = 0
			' 
			' radButton4
			' 
			Me.radButton4.Image = My.Resources.backstage_new
			Me.radButton4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton4.ImageKey = "backstage_new.png"
			Me.radButton4.Location = New System.Drawing.Point(13, 3)
			Me.radButton4.Name = "radButton4"
			Me.radButton4.Size = New System.Drawing.Size(87, 108)
			Me.radButton4.TabIndex = 0
			Me.radButton4.Text = "<html>Blank<br>Document"
			Me.radButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton5
			' 
			Me.radButton5.Image = My.Resources.backstage_blogpost
			Me.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton5.ImageKey = "backstage_blogpost.png"
			Me.radButton5.Location = New System.Drawing.Point(106, 3)
			Me.radButton5.Name = "radButton5"
			Me.radButton5.Size = New System.Drawing.Size(87, 108)
			Me.radButton5.TabIndex = 1
			Me.radButton5.Text = "Blog Post"
			Me.radButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton6
			' 
			Me.radButton6.Image = My.Resources.backstage_recent
			Me.radButton6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton6.Location = New System.Drawing.Point(199, 3)
			Me.radButton6.Name = "radButton6"
			Me.radButton6.Size = New System.Drawing.Size(87, 108)
			Me.radButton6.TabIndex = 2
			Me.radButton6.Text = "<html>Recent<br>Templates"
			Me.radButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton7
			' 
			Me.radButton7.Image = My.Resources.backstage_sample_templates
			Me.radButton7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton7.Location = New System.Drawing.Point(292, 3)
			Me.radButton7.Name = "radButton7"
			Me.radButton7.Size = New System.Drawing.Size(87, 108)
			Me.radButton7.TabIndex = 3
			Me.radButton7.Text = "<html>Sample<br>Templates"
			Me.radButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton8
			' 
			Me.radButton8.Image = My.Resources.backstage_my_templates
			Me.radButton8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton8.Location = New System.Drawing.Point(385, 3)
			Me.radButton8.Name = "radButton8"
			Me.radButton8.Size = New System.Drawing.Size(87, 108)
			Me.radButton8.TabIndex = 4
			Me.radButton8.Text = "My Templates"
			Me.radButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radButton9
			' 
			Me.radButton9.Image = My.Resources.backstage_existing_template
			Me.radButton9.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton9.Location = New System.Drawing.Point(478, 3)
			Me.radButton9.Name = "radButton9"
			Me.radButton9.Size = New System.Drawing.Size(87, 108)
			Me.radButton9.TabIndex = 5
			Me.radButton9.Text = "<html>New From<br>Existing"
			Me.radButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radSeparator3
			' 
			Me.radSeparator3.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSeparator3.Location = New System.Drawing.Point(0, 1)
			Me.radSeparator3.Name = "radSeparator3"
			Me.radSeparator3.Padding = New System.Windows.Forms.Padding(10)
			' 
			' 
			' 
			Me.radSeparator3.RootElement.Padding = New System.Windows.Forms.Padding(10)
			Me.radSeparator3.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator3.Size = New System.Drawing.Size(856, 18)
			Me.radSeparator3.TabIndex = 2
			Me.radSeparator3.Text = "radSeparator3"
			' 
			' radLabel5
			' 
			Me.radLabel5.Dock = System.Windows.Forms.DockStyle.Top
			Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel5.Location = New System.Drawing.Point(0, 0)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Padding = New System.Windows.Forms.Padding(10, 15, 15, 0)
			' 
			' 
			' 
			Me.radLabel5.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel5.RootElement.Padding = New System.Windows.Forms.Padding(10, 15, 15, 0)
			Me.radLabel5.Size = New System.Drawing.Size(856, 1)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "Available Templates"
			' 
			' backstageViewPage2
			' 
			Me.backstageViewPage2.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage2.Controls.Add(Me.radPageView1)
			Me.backstageViewPage2.Location = New System.Drawing.Point(132, 1)
			Me.backstageViewPage2.Name = "backstageViewPage2"
			Me.backstageViewPage2.Size = New System.Drawing.Size(856, 519)
			Me.backstageViewPage2.TabIndex = 1
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewItemPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage4)
			Me.radPageView1.Controls.Add(Me.radPageViewItemPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage5)
			Me.radPageView1.Controls.Add(Me.radPageViewPage6)
			Me.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPageView1.Location = New System.Drawing.Point(0, 0)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New System.Drawing.Size(856, 519)
			Me.radPageView1.TabIndex = 0
			Me.radPageView1.Text = "radPageView1"
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
			' 
			' radPageViewItemPage1
			' 
			Me.radPageViewItemPage1.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem
			Me.radPageViewItemPage1.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewItemPage1.Name = "radPageViewItemPage1"
			Me.radPageViewItemPage1.Size = New System.Drawing.Size(0, 0)
			Me.radPageViewItemPage1.Text = "Save & Send"
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radLabel11)
			Me.radPageViewPage1.Controls.Add(Me.radButton13)
			Me.radPageViewPage1.Controls.Add(Me.radSeparator8)
			Me.radPageViewPage1.Controls.Add(Me.radLabel10)
			Me.radPageViewPage1.Controls.Add(Me.radButton12)
			Me.radPageViewPage1.Controls.Add(Me.radSeparator7)
			Me.radPageViewPage1.Controls.Add(Me.radLabel9)
			Me.radPageViewPage1.Controls.Add(Me.radButton11)
			Me.radPageViewPage1.Controls.Add(Me.radSeparator6)
			Me.radPageViewPage1.Controls.Add(Me.radLabel8)
			Me.radPageViewPage1.Image = My.Resources.send_email
			Me.radPageViewPage1.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(547, 511)
			Me.radPageViewPage1.Text = "Send Using E-mail"
			' 
			' radLabel11
			' 
			Me.radLabel11.Location = New System.Drawing.Point(106, 284)
			Me.radLabel11.Name = "radLabel11"
			Me.radLabel11.Size = New System.Drawing.Size(275, 76)
			Me.radLabel11.TabIndex = 11
			Me.radLabel11.Text = resources.GetString("radLabel11.Text")
			' 
			' radButton13
			' 
			Me.radButton13.Image = My.Resources.xps_doc_icon
			Me.radButton13.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton13.Location = New System.Drawing.Point(3, 284)
			Me.radButton13.Name = "radButton13"
			Me.radButton13.Size = New System.Drawing.Size(82, 82)
			Me.radButton13.TabIndex = 10
			Me.radButton13.Text = "<html>Send as<br>XPS"
			Me.radButton13.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radSeparator8
			' 
			Me.radSeparator8.Location = New System.Drawing.Point(3, 268)
			Me.radSeparator8.Name = "radSeparator8"
			Me.radSeparator8.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator8.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator8.TabIndex = 9
			Me.radSeparator8.Text = "radSeparator8"
			' 
			' radLabel10
			' 
			Me.radLabel10.Location = New System.Drawing.Point(106, 170)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New System.Drawing.Size(275, 76)
			Me.radLabel10.TabIndex = 8
			Me.radLabel10.Text = resources.GetString("radLabel10.Text")
			' 
			' radButton12
			' 
			Me.radButton12.Image = My.Resources.pdf_doc_icon
			Me.radButton12.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton12.Location = New System.Drawing.Point(3, 170)
			Me.radButton12.Name = "radButton12"
			Me.radButton12.Size = New System.Drawing.Size(82, 82)
			Me.radButton12.TabIndex = 7
			Me.radButton12.Text = "<html>Send as<br>PDF"
			Me.radButton12.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radSeparator7
			' 
			Me.radSeparator7.Location = New System.Drawing.Point(3, 154)
			Me.radSeparator7.Name = "radSeparator7"
			Me.radSeparator7.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator7.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator7.TabIndex = 6
			Me.radSeparator7.Text = "radSeparator7"
			' 
			' radLabel9
			' 
			Me.radLabel9.Location = New System.Drawing.Point(106, 57)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New System.Drawing.Size(329, 61)
			Me.radLabel9.TabIndex = 5
			Me.radLabel9.Text = "<html>Attach a copy of this document to an e-mail<br><ul><li>Everyone receives a " & "separate copies of this document</li><li>Changes and feedback need to be incorpo" & "rated manually</li></ul>"
			' 
			' radButton11
			' 
			Me.radButton11.Image = My.Resources.send_email
			Me.radButton11.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton11.Location = New System.Drawing.Point(3, 57)
			Me.radButton11.Name = "radButton11"
			Me.radButton11.Size = New System.Drawing.Size(82, 82)
			Me.radButton11.TabIndex = 4
			Me.radButton11.Text = "<html>Send as<br>Attachment"
			Me.radButton11.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radSeparator6
			' 
			Me.radSeparator6.Location = New System.Drawing.Point(3, 41)
			Me.radSeparator6.Name = "radSeparator6"
			Me.radSeparator6.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator6.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator6.TabIndex = 3
			Me.radSeparator6.Text = "radSeparator6"
			' 
			' radLabel8
			' 
			Me.radLabel8.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel8.Location = New System.Drawing.Point(3, 15)
			Me.radLabel8.Name = "radLabel8"
			' 
			' 
			' 
			Me.radLabel8.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel8.Size = New System.Drawing.Size(148, 25)
			Me.radLabel8.TabIndex = 2
			Me.radLabel8.Text = "Send Using E-mail"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radLabel13)
			Me.radPageViewPage2.Controls.Add(Me.radButton14)
			Me.radPageViewPage2.Controls.Add(Me.radSeparator9)
			Me.radPageViewPage2.Controls.Add(Me.radLabel12)
			Me.radPageViewPage2.Image = My.Resources.Globe2
			Me.radPageViewPage2.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(547, 511)
			Me.radPageViewPage2.Text = "Save to Web"
			' 
			' radLabel13
			' 
			Me.radLabel13.Location = New System.Drawing.Point(3, 56)
			Me.radLabel13.Name = "radLabel13"
			Me.radLabel13.Size = New System.Drawing.Size(451, 18)
			Me.radLabel13.TabIndex = 8
			Me.radLabel13.Text = "Save to web to access this document from any computer or to share it with other p" & "eople."
			' 
			' radButton14
			' 
			Me.radButton14.Image = My.Resources.sign_in
			Me.radButton14.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton14.Location = New System.Drawing.Point(3, 92)
			Me.radButton14.Name = "radButton14"
			Me.radButton14.Size = New System.Drawing.Size(82, 82)
			Me.radButton14.TabIndex = 7
			Me.radButton14.Text = "Sign In"
			Me.radButton14.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radSeparator9
			' 
			Me.radSeparator9.Location = New System.Drawing.Point(3, 41)
			Me.radSeparator9.Name = "radSeparator9"
			Me.radSeparator9.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator9.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator9.TabIndex = 6
			Me.radSeparator9.Text = "radSeparator9"
			' 
			' radLabel12
			' 
			Me.radLabel12.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel12.Location = New System.Drawing.Point(3, 15)
			Me.radLabel12.Name = "radLabel12"
			' 
			' 
			' 
			Me.radLabel12.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel12.Size = New System.Drawing.Size(105, 25)
			Me.radLabel12.TabIndex = 5
			Me.radLabel12.Text = "Save to Web"
			' 
			' radPageViewPage4
			' 
			Me.radPageViewPage4.Controls.Add(Me.radButton15)
			Me.radPageViewPage4.Controls.Add(Me.radLabel14)
			Me.radPageViewPage4.Controls.Add(Me.radSeparator10)
			Me.radPageViewPage4.Controls.Add(Me.radLabel15)
			Me.radPageViewPage4.Image = My.Resources.msoffice_menu_blog
			Me.radPageViewPage4.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New System.Drawing.Size(547, 511)
			Me.radPageViewPage4.Text = "Publish as Blog Post"
			' 
			' radButton15
			' 
			Me.radButton15.Image = My.Resources.msoffice_menu_blog
			Me.radButton15.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton15.Location = New System.Drawing.Point(0, 269)
			Me.radButton15.Name = "radButton15"
			Me.radButton15.Size = New System.Drawing.Size(82, 82)
			Me.radButton15.TabIndex = 12
			Me.radButton15.Text = "<html>Publish as<br>Blog Post"
			Me.radButton15.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radLabel14
			' 
			Me.radLabel14.Location = New System.Drawing.Point(3, 56)
			Me.radLabel14.Name = "radLabel14"
			Me.radLabel14.Size = New System.Drawing.Size(2, 2)
			Me.radLabel14.TabIndex = 11
			Me.radLabel14.Text = resources.GetString("radLabel14.Text")
			' 
			' radSeparator10
			' 
			Me.radSeparator10.Location = New System.Drawing.Point(3, 41)
			Me.radSeparator10.Name = "radSeparator10"
			Me.radSeparator10.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator10.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator10.TabIndex = 10
			Me.radSeparator10.Text = "radSeparator10"
			' 
			' radLabel15
			' 
			Me.radLabel15.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel15.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel15.Location = New System.Drawing.Point(3, 15)
			Me.radLabel15.Name = "radLabel15"
			' 
			' 
			' 
			Me.radLabel15.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel15.Size = New System.Drawing.Size(164, 25)
			Me.radLabel15.TabIndex = 9
			Me.radLabel15.Text = "Publish as Blog Post"
			' 
			' radPageViewItemPage2
			' 
			Me.radPageViewItemPage2.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem
			Me.radPageViewItemPage2.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewItemPage2.Name = "radPageViewItemPage2"
			Me.radPageViewItemPage2.Size = New System.Drawing.Size(0, 0)
			Me.radPageViewItemPage2.Text = "File Types"
			' 
			' radPageViewPage5
			' 
			Me.radPageViewPage5.Controls.Add(Me.radButton24)
			Me.radPageViewPage5.Controls.Add(Me.flowLayoutPanel2)
			Me.radPageViewPage5.Controls.Add(Me.radSeparator11)
			Me.radPageViewPage5.Controls.Add(Me.radLabel16)
			Me.radPageViewPage5.Image = My.Resources.save_as
			Me.radPageViewPage5.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage5.Name = "radPageViewPage5"
			Me.radPageViewPage5.Size = New System.Drawing.Size(547, 511)
			Me.radPageViewPage5.Text = "Change File Type"
			' 
			' radButton24
			' 
			Me.radButton24.Image = My.Resources.save_as
			Me.radButton24.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton24.Location = New System.Drawing.Point(0, 344)
			Me.radButton24.Name = "radButton24"
			Me.radButton24.Size = New System.Drawing.Size(82, 82)
			Me.radButton24.TabIndex = 14
			Me.radButton24.Text = "Save As"
			Me.radButton24.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' flowLayoutPanel2
			' 
			Me.flowLayoutPanel2.Controls.Add(Me.radLabel17)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton16)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton17)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton18)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton19)
			Me.flowLayoutPanel2.Controls.Add(Me.radLabel18)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton20)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton21)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton22)
			Me.flowLayoutPanel2.Controls.Add(Me.radButton23)
			Me.flowLayoutPanel2.Location = New System.Drawing.Point(3, 56)
			Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
			Me.flowLayoutPanel2.Size = New System.Drawing.Size(500, 280)
			Me.flowLayoutPanel2.TabIndex = 13
'			Me.flowLayoutPanel2.Paint += New System.Windows.Forms.PaintEventHandler(Me.flowLayoutPanel2_Paint);
			' 
			' radLabel17
			' 
			Me.radLabel17.BackColor = System.Drawing.Color.LightGray
			Me.radLabel17.Location = New System.Drawing.Point(0, 0)
			Me.radLabel17.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
			Me.radLabel17.MinimumSize = New System.Drawing.Size(500, 0)
			Me.radLabel17.Name = "radLabel17"
			' 
			' 
			' 
			Me.radLabel17.RootElement.MinSize = New System.Drawing.Size(500, 0)
			Me.radLabel17.Size = New System.Drawing.Size(500, 277)
			Me.radLabel17.TabIndex = 0
			Me.radLabel17.Text = "Document File Types"
			' 
			' radButton16
			' 
			Me.radButton16.Image = My.Resources.plain_text
			Me.radButton16.Location = New System.Drawing.Point(3, 283)
			Me.radButton16.Name = "radButton16"
			Me.radButton16.Size = New System.Drawing.Size(243, 50)
			Me.radButton16.TabIndex = 1
			Me.radButton16.Text = "<html>Document (*.docx)<br><span style=""color:#5e5e5e"">Uses the Word document for" & "mat.</span>"
			Me.radButton16.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton17
			' 
			Me.radButton17.Image = My.Resources.plain_text
			Me.radButton17.Location = New System.Drawing.Point(252, 283)
			Me.radButton17.Name = "radButton17"
			Me.radButton17.Size = New System.Drawing.Size(243, 50)
			Me.radButton17.TabIndex = 2
			Me.radButton17.Text = "<html>Word 97-2003 Document (*.doc)<br><span style=""color:#5e5e5e"">Uses the Word " & "97-2003 document format.</span>"
			Me.radButton17.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton18
			' 
			Me.radButton18.Image = My.Resources.plain_text
			Me.radButton18.Location = New System.Drawing.Point(3, 339)
			Me.radButton18.Name = "radButton18"
			Me.radButton18.Size = New System.Drawing.Size(243, 50)
			Me.radButton18.TabIndex = 3
			Me.radButton18.Text = "<html>OpenDocument Text(*.odt)<br><span style=""color:#5e5e5e"">Uses the OpenDocume" & "nt Text format.</span>"
			Me.radButton18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton19
			' 
			Me.radButton19.Image = My.Resources.plain_text
			Me.radButton19.Location = New System.Drawing.Point(252, 339)
			Me.radButton19.Name = "radButton19"
			Me.radButton19.Size = New System.Drawing.Size(243, 50)
			Me.radButton19.TabIndex = 4
			Me.radButton19.Text = "<html>Template (*.dotx)<br><span style=""color:#5e5e5e"">Starting point for new doc" & "uments.</span>"
			Me.radButton19.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radLabel18
			' 
			Me.radLabel18.BackColor = System.Drawing.Color.LightGray
			Me.radLabel18.Location = New System.Drawing.Point(0, 395)
			Me.radLabel18.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
			Me.radLabel18.MinimumSize = New System.Drawing.Size(500, 0)
			Me.radLabel18.Name = "radLabel18"
			' 
			' 
			' 
			Me.radLabel18.RootElement.MinSize = New System.Drawing.Size(500, 0)
			Me.radLabel18.Size = New System.Drawing.Size(500, 1)
			Me.radLabel18.TabIndex = 5
			Me.radLabel18.Text = "Other File Types"
			' 
			' radButton20
			' 
			Me.radButton20.Image = My.Resources.plain_text
			Me.radButton20.Location = New System.Drawing.Point(3, 402)
			Me.radButton20.Name = "radButton20"
			Me.radButton20.Size = New System.Drawing.Size(243, 50)
			Me.radButton20.TabIndex = 6
			Me.radButton20.Text = "<html>Plain Text (*.txt)<br><span style=""color:#5e5e5e"">Contains only the text in" & " your document.</span>"
			Me.radButton20.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton21
			' 
			Me.radButton21.Image = My.Resources.plain_text
			Me.radButton21.Location = New System.Drawing.Point(252, 402)
			Me.radButton21.Name = "radButton21"
			Me.radButton21.Size = New System.Drawing.Size(243, 50)
			Me.radButton21.TabIndex = 7
			Me.radButton21.Text = "<html>Rich Text Format (*.rtf)<br><span style=""color:#5e5e5e"">Preserves the text " & "formatting information.</span>"
			Me.radButton21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton22
			' 
			Me.radButton22.Image = My.Resources.Globe2
			Me.radButton22.Location = New System.Drawing.Point(3, 458)
			Me.radButton22.Name = "radButton22"
			Me.radButton22.Size = New System.Drawing.Size(243, 50)
			Me.radButton22.TabIndex = 8
			Me.radButton22.Text = "<html>Single File Web Page (*mht, *.mhtml)<br><span style=""color:#5e5e5e"">Web pag" & "e is stored as a single file.</span>"
			Me.radButton22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton23
			' 
			Me.radButton23.Image = My.Resources.save_as
			Me.radButton23.Location = New System.Drawing.Point(252, 458)
			Me.radButton23.Name = "radButton23"
			Me.radButton23.Size = New System.Drawing.Size(243, 50)
			Me.radButton23.TabIndex = 9
			Me.radButton23.Text = "<html>Save as Another File Type<br>"
			Me.radButton23.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radSeparator11
			' 
			Me.radSeparator11.Location = New System.Drawing.Point(3, 41)
			Me.radSeparator11.Name = "radSeparator11"
			Me.radSeparator11.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator11.Size = New System.Drawing.Size(500, 10)
			Me.radSeparator11.TabIndex = 12
			Me.radSeparator11.Text = "radSeparator11"
			' 
			' radLabel16
			' 
			Me.radLabel16.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel16.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel16.Location = New System.Drawing.Point(3, 15)
			Me.radLabel16.Name = "radLabel16"
			' 
			' 
			' 
			Me.radLabel16.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel16.Size = New System.Drawing.Size(147, 25)
			Me.radLabel16.TabIndex = 11
			Me.radLabel16.Text = "Change File Types"
			' 
			' radPageViewPage6
			' 
			Me.radPageViewPage6.Controls.Add(Me.radButton25)
			Me.radPageViewPage6.Controls.Add(Me.radLabel19)
			Me.radPageViewPage6.Controls.Add(Me.radSeparator12)
			Me.radPageViewPage6.Controls.Add(Me.radLabel20)
			Me.radPageViewPage6.Image = My.Resources.pdf_xps_doc
			Me.radPageViewPage6.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage6.Name = "radPageViewPage6"
			Me.radPageViewPage6.Size = New System.Drawing.Size(547, 511)
			Me.radPageViewPage6.Text = "Create PDF/XPS Document"
			' 
			' radButton25
			' 
			Me.radButton25.Image = My.Resources.pdf_xps_doc
			Me.radButton25.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton25.Location = New System.Drawing.Point(3, 152)
			Me.radButton25.Name = "radButton25"
			Me.radButton25.Size = New System.Drawing.Size(82, 82)
			Me.radButton25.TabIndex = 16
			Me.radButton25.Text = "<html>Create <br>PDF/XPS"
			Me.radButton25.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButton25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' radLabel19
			' 
			Me.radLabel19.Location = New System.Drawing.Point(3, 56)
			Me.radLabel19.Name = "radLabel19"
			Me.radLabel19.Size = New System.Drawing.Size(275, 90)
			Me.radLabel19.TabIndex = 15
			Me.radLabel19.Text = resources.GetString("radLabel19.Text")
			' 
			' radSeparator12
			' 
			Me.radSeparator12.Location = New System.Drawing.Point(3, 41)
			Me.radSeparator12.Name = "radSeparator12"
			Me.radSeparator12.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator12.Size = New System.Drawing.Size(497, 10)
			Me.radSeparator12.TabIndex = 14
			Me.radSeparator12.Text = "radSeparator12"
			' 
			' radLabel20
			' 
			Me.radLabel20.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel20.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel20.Location = New System.Drawing.Point(3, 15)
			Me.radLabel20.Name = "radLabel20"
			' 
			' 
			' 
			Me.radLabel20.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel20.Size = New System.Drawing.Size(227, 25)
			Me.radLabel20.TabIndex = 13
			Me.radLabel20.Text = "Create a PDF/XPS document"
			' 
			' backstageViewPage1
			' 
			Me.backstageViewPage1.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage1.Controls.Add(Me.radLabel24)
			Me.backstageViewPage1.Controls.Add(Me.radSeparator16)
			Me.backstageViewPage1.Controls.Add(Me.radLabel23)
			Me.backstageViewPage1.Controls.Add(Me.pictureBox2)
			Me.backstageViewPage1.Controls.Add(Me.radButton29)
			Me.backstageViewPage1.Controls.Add(Me.radButton30)
			Me.backstageViewPage1.Controls.Add(Me.radSeparator14)
			Me.backstageViewPage1.Controls.Add(Me.radSeparator15)
			Me.backstageViewPage1.Controls.Add(Me.radLabel22)
			Me.backstageViewPage1.Controls.Add(Me.radButton28)
			Me.backstageViewPage1.Controls.Add(Me.radButton27)
			Me.backstageViewPage1.Controls.Add(Me.radButton26)
			Me.backstageViewPage1.Controls.Add(Me.radSeparator13)
			Me.backstageViewPage1.Controls.Add(Me.radLabel21)
			Me.backstageViewPage1.Location = New System.Drawing.Point(0, 0)
			Me.backstageViewPage1.Name = "backstageViewPage1"
			Me.backstageViewPage1.Size = New System.Drawing.Size(0, 0)
			Me.backstageViewPage1.TabIndex = 0
			' 
			' radLabel24
			' 
			Me.radLabel24.AutoSize = False
			Me.radLabel24.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radLabel24.Location = New System.Drawing.Point(429, 144)
			Me.radLabel24.Name = "radLabel24"
			Me.radLabel24.Size = New System.Drawing.Size(415, 362)
			Me.radLabel24.TabIndex = 19
			Me.radLabel24.Text = resources.GetString("radLabel24.Text")
			' 
			' radSeparator16
			' 
			Me.radSeparator16.Location = New System.Drawing.Point(429, 129)
			Me.radSeparator16.Name = "radSeparator16"
			Me.radSeparator16.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator16.Size = New System.Drawing.Size(424, 10)
			Me.radSeparator16.TabIndex = 18
			Me.radSeparator16.Text = "radSeparator16"
			' 
			' radLabel23
			' 
			Me.radLabel23.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel23.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel23.Location = New System.Drawing.Point(426, 102)
			Me.radLabel23.Name = "radLabel23"
			' 
			' 
			' 
			Me.radLabel23.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel23.Size = New System.Drawing.Size(186, 25)
			Me.radLabel23.TabIndex = 17
			Me.radLabel23.Text = "What's new in Q1 2001"
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Image = My.Resources.ControlsLogoWF
			Me.pictureBox2.Location = New System.Drawing.Point(429, 13)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(216, 70)
			Me.pictureBox2.TabIndex = 16
			Me.pictureBox2.TabStop = False
			' 
			' radButton29
			' 
			Me.radButton29.Image = My.Resources.win
			Me.radButton29.Location = New System.Drawing.Point(18, 430)
			Me.radButton29.Name = "radButton29"
			Me.radButton29.Size = New System.Drawing.Size(360, 76)
			Me.radButton29.TabIndex = 15
			Me.radButton29.Text = "<html>Theme Viewer<br><span style=""color:#5e5e5e"">Pick a theme to preview how the" & " RadControls<br>look at runtime.</span>"
			Me.radButton29.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton30
			' 
			Me.radButton30.Image = My.Resources.vsb_big
			Me.radButton30.Location = New System.Drawing.Point(18, 348)
			Me.radButton30.Name = "radButton30"
			Me.radButton30.Size = New System.Drawing.Size(360, 76)
			Me.radButton30.TabIndex = 14
			Me.radButton30.Text = "<html>Visual Style Builder<br><span style=""color:#5e5e5e"">Create your own style o" & "f the controls or edit<br>an existing one.</span>"
			Me.radButton30.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radSeparator14
			' 
			Me.radSeparator14.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.radSeparator14.Location = New System.Drawing.Point(410, 1)
			Me.radSeparator14.Name = "radSeparator14"
			Me.radSeparator14.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radSeparator14.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator14.Size = New System.Drawing.Size(13, 0)
			Me.radSeparator14.TabIndex = 13
			Me.radSeparator14.Text = "radSeparator14"
			' 
			' radSeparator15
			' 
			Me.radSeparator15.Location = New System.Drawing.Point(5, 332)
			Me.radSeparator15.Name = "radSeparator15"
			Me.radSeparator15.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator15.Size = New System.Drawing.Size(387, 10)
			Me.radSeparator15.TabIndex = 12
			Me.radSeparator15.Text = "radSeparator15"
			' 
			' radLabel22
			' 
			Me.radLabel22.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel22.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel22.Location = New System.Drawing.Point(5, 305)
			Me.radLabel22.Name = "radLabel22"
			' 
			' 
			' 
			Me.radLabel22.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel22.Size = New System.Drawing.Size(395, 25)
			Me.radLabel22.TabIndex = 11
			Me.radLabel22.Text = "Tools for working with RadControls for WinForms"
			' 
			' radButton28
			' 
			Me.radButton28.Image = My.Resources.ribbon_contactus_big
			Me.radButton28.Location = New System.Drawing.Point(18, 214)
			Me.radButton28.Name = "radButton28"
			Me.radButton28.Size = New System.Drawing.Size(360, 76)
			Me.radButton28.TabIndex = 9
			Me.radButton28.Text = "<html>Contact Us<br><span style=""color:#5e5e5e"">Let us know if you need help or h" & "ow we can make<br>RadControls better.</span>"
			Me.radButton28.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton27
			' 
			Me.radButton27.Image = My.Resources.ribbon_getting_started_big
			Me.radButton27.Location = New System.Drawing.Point(18, 132)
			Me.radButton27.Name = "radButton27"
			Me.radButton27.Size = New System.Drawing.Size(360, 76)
			Me.radButton27.TabIndex = 8
			Me.radButton27.Text = "<html>Getting Started with RadControls for WinForms<br><span style=""color:#5e5e5e" & """>See what's new and find resources to help you<br>learn the basics quickly.</sp" & "an>"
			Me.radButton27.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton26
			' 
			Me.radButton26.Image = My.Resources.ribbon_help_big
			Me.radButton26.Location = New System.Drawing.Point(18, 50)
			Me.radButton26.Name = "radButton26"
			Me.radButton26.Size = New System.Drawing.Size(360, 76)
			Me.radButton26.TabIndex = 7
			Me.radButton26.Text = "<html>RadControls for WinForms Help<br><span style=""color:#5e5e5e"">Get help using" & " RadControls for WinForms.</span>"
			Me.radButton26.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radSeparator13
			' 
			Me.radSeparator13.Location = New System.Drawing.Point(5, 36)
			Me.radSeparator13.Name = "radSeparator13"
			Me.radSeparator13.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator13.Size = New System.Drawing.Size(387, 10)
			Me.radSeparator13.TabIndex = 6
			Me.radSeparator13.Text = "radSeparator13"
			' 
			' radLabel21
			' 
			Me.radLabel21.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel21.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel21.Location = New System.Drawing.Point(5, 9)
			Me.radLabel21.Name = "radLabel21"
			' 
			' 
			' 
			Me.radLabel21.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel21.Size = New System.Drawing.Size(71, 25)
			Me.radLabel21.TabIndex = 5
			Me.radLabel21.Text = "Support"
			' 
			' backstageViewPage4
			' 
			Me.backstageViewPage4.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage4.Controls.Add(Me.radSeparator19)
			Me.backstageViewPage4.Controls.Add(Me.recentPlacesListControl)
			Me.backstageViewPage4.Controls.Add(Me.recentDocumentsListControl)
			Me.backstageViewPage4.Controls.Add(Me.radSeparator18)
			Me.backstageViewPage4.Controls.Add(Me.radLabel26)
			Me.backstageViewPage4.Controls.Add(Me.radSeparator17)
			Me.backstageViewPage4.Controls.Add(Me.radLabel25)
			Me.backstageViewPage4.Location = New System.Drawing.Point(132, 1)
			Me.backstageViewPage4.Name = "backstageViewPage4"
			Me.backstageViewPage4.Size = New System.Drawing.Size(856, 519)
			Me.backstageViewPage4.TabIndex = 3
			' 
			' radSeparator19
			' 
			Me.radSeparator19.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.radSeparator19.Location = New System.Drawing.Point(372, -1)
			Me.radSeparator19.Name = "radSeparator19"
			Me.radSeparator19.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radSeparator19.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator19.Size = New System.Drawing.Size(18, 520)
			Me.radSeparator19.TabIndex = 13
			Me.radSeparator19.Text = "radSeparator19"
			' 
			' recentPlacesListControl
			' 
			Me.recentPlacesListControl.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.recentPlacesListControl.CaseSensitiveSort = True
			Me.recentPlacesListControl.ItemHeight = 36
			Me.recentPlacesListControl.Location = New System.Drawing.Point(411, 49)
			Me.recentPlacesListControl.Name = "recentPlacesListControl"
			Me.recentPlacesListControl.Size = New System.Drawing.Size(343, 458)
			Me.recentPlacesListControl.TabIndex = 12
			Me.recentPlacesListControl.Text = "radListControl2"
			CType(Me.recentPlacesListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).CaseSensitiveSort = True
			CType(Me.recentPlacesListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).DrawFill = False
			CType(Me.recentPlacesListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).DrawBorder = False
			' 
			' recentDocumentsListControl
			' 
			Me.recentDocumentsListControl.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.recentDocumentsListControl.CaseSensitiveSort = True
			Me.recentDocumentsListControl.ItemHeight = 36
			Me.recentDocumentsListControl.Location = New System.Drawing.Point(10, 49)
			Me.recentDocumentsListControl.Name = "recentDocumentsListControl"
			Me.recentDocumentsListControl.Size = New System.Drawing.Size(343, 458)
			Me.recentDocumentsListControl.TabIndex = 11
			Me.recentDocumentsListControl.Text = "radListControl1"
			CType(Me.recentDocumentsListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).CaseSensitiveSort = True
			CType(Me.recentDocumentsListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).DrawFill = False
			CType(Me.recentDocumentsListControl.GetChildAt(0), Telerik.WinControls.UI.RadListElement).DrawBorder = False
			' 
			' radSeparator18
			' 
			Me.radSeparator18.Location = New System.Drawing.Point(408, 35)
			Me.radSeparator18.Name = "radSeparator18"
			Me.radSeparator18.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator18.Size = New System.Drawing.Size(346, 10)
			Me.radSeparator18.TabIndex = 10
			Me.radSeparator18.Text = "radSeparator18"
			' 
			' radLabel26
			' 
			Me.radLabel26.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel26.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel26.Location = New System.Drawing.Point(408, 8)
			Me.radLabel26.Name = "radLabel26"
			' 
			' 
			' 
			Me.radLabel26.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel26.Size = New System.Drawing.Size(113, 25)
			Me.radLabel26.TabIndex = 9
			Me.radLabel26.Text = "Recent Places"
			' 
			' radSeparator17
			' 
			Me.radSeparator17.Location = New System.Drawing.Point(7, 35)
			Me.radSeparator17.Name = "radSeparator17"
			Me.radSeparator17.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator17.Size = New System.Drawing.Size(346, 10)
			Me.radSeparator17.TabIndex = 8
			Me.radSeparator17.Text = "radSeparator17"
			' 
			' radLabel25
			' 
			Me.radLabel25.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel25.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel25.Location = New System.Drawing.Point(7, 8)
			Me.radLabel25.Name = "radLabel25"
			' 
			' 
			' 
			Me.radLabel25.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel25.Size = New System.Drawing.Size(153, 25)
			Me.radLabel25.TabIndex = 7
			Me.radLabel25.Text = "Recent Documents"
			' 
			' backstageViewPage6
			' 
			Me.backstageViewPage6.BackColor = System.Drawing.Color.Transparent
			Me.backstageViewPage6.Controls.Add(Me.radSeparator5)
			Me.backstageViewPage6.Controls.Add(Me.radSeparator4)
			Me.backstageViewPage6.Controls.Add(Me.radSpinEditor1)
			Me.backstageViewPage6.Controls.Add(Me.radLabel7)
			Me.backstageViewPage6.Controls.Add(Me.radLabel6)
			Me.backstageViewPage6.Controls.Add(Me.radButton10)
			Me.backstageViewPage6.Controls.Add(Me.pictureBox1)
			Me.backstageViewPage6.Location = New System.Drawing.Point(132, 1)
			Me.backstageViewPage6.Name = "backstageViewPage6"
			Me.backstageViewPage6.Size = New System.Drawing.Size(856, 519)
			Me.backstageViewPage6.TabIndex = 5
			' 
			' radSeparator5
			' 
			Me.radSeparator5.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.radSeparator5.Location = New System.Drawing.Point(245, 0)
			Me.radSeparator5.Name = "radSeparator5"
			Me.radSeparator5.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radSeparator5.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator5.Size = New System.Drawing.Size(14, 519)
			Me.radSeparator5.TabIndex = 5
			Me.radSeparator5.Text = "radSeparator5"
			' 
			' radSeparator4
			' 
			Me.radSeparator4.Location = New System.Drawing.Point(108, 41)
			Me.radSeparator4.Name = "radSeparator4"
			Me.radSeparator4.ShadowOffset = New System.Drawing.Point(0, 0)
			Me.radSeparator4.Size = New System.Drawing.Size(131, 10)
			Me.radSeparator4.TabIndex = 4
			Me.radSeparator4.Text = "radSeparator4"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New System.Drawing.Point(173, 53)
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.ShowBorder = True
			Me.radSpinEditor1.Size = New System.Drawing.Size(66, 21)
			Me.radSpinEditor1.TabIndex = 3
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New System.Drawing.Point(108, 56)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(42, 18)
			Me.radLabel7.TabIndex = 2
			Me.radLabel7.Text = "Copies:"
			' 
			' radLabel6
			' 
			Me.radLabel6.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel6.Location = New System.Drawing.Point(108, 16)
			Me.radLabel6.Name = "radLabel6"
			' 
			' 
			' 
			Me.radLabel6.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.radLabel6.Size = New System.Drawing.Size(46, 25)
			Me.radLabel6.TabIndex = 1
			Me.radLabel6.Text = "Print"
			' 
			' radButton10
			' 
			Me.radButton10.Image = My.Resources.ribbon_print
			Me.radButton10.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton10.Location = New System.Drawing.Point(19, 16)
			Me.radButton10.Name = "radButton10"
			Me.radButton10.Size = New System.Drawing.Size(82, 82)
			Me.radButton10.TabIndex = 0
			Me.radButton10.Text = "Print"
			Me.radButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pictureBox1.Image = My.Resources.msoffice_doc
			Me.pictureBox1.Location = New System.Drawing.Point(265, 16)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(579, 491)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox1.TabIndex = 6
			Me.pictureBox1.TabStop = False
			' 
			' backstageButtonItem1
			' 
			Me.backstageButtonItem1.AccessibleDescription = "Save"
			Me.backstageButtonItem1.AccessibleName = "Save"
			Me.backstageButtonItem1.Image = My.Resources.save
			Me.backstageButtonItem1.Name = "backstageButtonItem1"
			Me.backstageButtonItem1.Text = "Save"
			Me.backstageButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageButtonItem2
			' 
			Me.backstageButtonItem2.AccessibleDescription = "Save As"
			Me.backstageButtonItem2.AccessibleName = "Save As"
			Me.backstageButtonItem2.Image = My.Resources.save_as1
			Me.backstageButtonItem2.Name = "backstageButtonItem2"
			Me.backstageButtonItem2.Text = "Save As"
			Me.backstageButtonItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageButtonItem3
			' 
			Me.backstageButtonItem3.AccessibleDescription = "Open"
			Me.backstageButtonItem3.AccessibleName = "Open"
			Me.backstageButtonItem3.Image = My.Resources.open
			Me.backstageButtonItem3.Name = "backstageButtonItem3"
			Me.backstageButtonItem3.Text = "Open"
			Me.backstageButtonItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageButtonItem4
			' 
			Me.backstageButtonItem4.AccessibleDescription = "Close"
			Me.backstageButtonItem4.AccessibleName = "Close"
			Me.backstageButtonItem4.Image = My.Resources.close1
			Me.backstageButtonItem4.Name = "backstageButtonItem4"
			Me.backstageButtonItem4.Text = "Close"
			Me.backstageButtonItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem1
			' 
			Me.backstageTabItem1.AccessibleDescription = "Info"
			Me.backstageTabItem1.AccessibleName = "Info"
			Me.backstageTabItem1.Name = "backstageTabItem1"
			Me.backstageTabItem1.Page = Me.backstageViewPage3
			Me.backstageTabItem1.Text = "Info"
			Me.backstageTabItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem2
			' 
			Me.backstageTabItem2.AccessibleDescription = "Recent"
			Me.backstageTabItem2.AccessibleName = "Recent"
			Me.backstageTabItem2.Name = "backstageTabItem2"
			Me.backstageTabItem2.Page = Me.backstageViewPage4
			Me.backstageTabItem2.Text = "Recent"
			Me.backstageTabItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem3
			' 
			Me.backstageTabItem3.AccessibleDescription = "New"
			Me.backstageTabItem3.AccessibleName = "New"
			Me.backstageTabItem3.Name = "backstageTabItem3"
			Me.backstageTabItem3.Page = Me.backstageViewPage5
			Me.backstageTabItem3.Text = "New"
			Me.backstageTabItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem4
			' 
			Me.backstageTabItem4.AccessibleDescription = "Print"
			Me.backstageTabItem4.AccessibleName = "Print"
			Me.backstageTabItem4.Name = "backstageTabItem4"
			Me.backstageTabItem4.Page = Me.backstageViewPage6
			Me.backstageTabItem4.Text = "Print"
			Me.backstageTabItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem5
			' 
			Me.backstageTabItem5.AccessibleDescription = "Save & Send"
			Me.backstageTabItem5.AccessibleName = "Save & Send"
			Me.backstageTabItem5.Name = "backstageTabItem5"
			Me.backstageTabItem5.Page = Me.backstageViewPage2
			Me.backstageTabItem5.Text = "Save & Send"
			Me.backstageTabItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageTabItem6
			' 
			Me.backstageTabItem6.AccessibleDescription = "Help"
			Me.backstageTabItem6.AccessibleName = "Help"
			Me.backstageTabItem6.Name = "backstageTabItem6"
			Me.backstageTabItem6.Page = Me.backstageViewPage1
			Me.backstageTabItem6.Text = "Help"
			Me.backstageTabItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageButtonItem5
			' 
			Me.backstageButtonItem5.AccessibleDescription = "Options"
			Me.backstageButtonItem5.AccessibleName = "Options"
			Me.backstageButtonItem5.Image = My.Resources.optionsButton
			Me.backstageButtonItem5.Name = "backstageButtonItem5"
			Me.backstageButtonItem5.Text = "Options"
			Me.backstageButtonItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' backstageButtonItem6
			' 
			Me.backstageButtonItem6.AccessibleDescription = "Exit"
			Me.backstageButtonItem6.AccessibleName = "Exit"
			Me.backstageButtonItem6.Image = My.Resources.exit2
			Me.backstageButtonItem6.Name = "backstageButtonItem6"
			Me.backstageButtonItem6.Text = "Exit"
			Me.backstageButtonItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarCommandTabHome
			' 
			Me.radRibbonBarCommandTabHome.AccessibleDescription = "Home"
			Me.radRibbonBarCommandTabHome.AccessibleName = "Home"
			Me.radRibbonBarCommandTabHome.Alignment = System.Drawing.ContentAlignment.BottomLeft
			' 
			' radRibbonBarCommandTabHome.ContentPanel
			' 
			Me.radRibbonBarCommandTabHome.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.radRibbonBarCommandTabHome.ContentPanel.CausesValidation = True
			Me.radRibbonBarCommandTabHome.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radRibbonBarCommandTabHome.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radRibbonBarCommandTabHome.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.radRibbonBarCommandTabHome.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.radRibbonBarCommandTabHome.IsSelected = True
			Me.radRibbonBarCommandTabHome.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarGroup4, Me.radRibbonBarGroup5, Me.radRibbonBarGroup6, Me.radRibbonBarGroup7, Me.radRibbonBarGroup8})
			Me.radRibbonBarCommandTabHome.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.radRibbonBarCommandTabHome.Name = "radRibbonBarCommandTabHome"
			Me.radRibbonBarCommandTabHome.StretchHorizontally = False
			Me.radRibbonBarCommandTabHome.Text = "Home"
			Me.radRibbonBarCommandTabHome.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup4
			' 
			Me.radRibbonBarGroup4.AccessibleDescription = "Clipboard"
			Me.radRibbonBarGroup4.AccessibleName = "Clipboard"
			Me.radRibbonBarGroup4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radDropDownButtonElement2, Me.radRibbonBarButtonGroup3})
			Me.radRibbonBarGroup4.Name = "radRibbonBarGroup4"
			Me.radRibbonBarGroup4.Text = "Clipboard"
			Me.radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement2
			' 
			Me.radDropDownButtonElement2.AccessibleDescription = "Paste"
			Me.radDropDownButtonElement2.AccessibleName = "Paste"
			Me.radDropDownButtonElement2.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement2.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement2.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement2.ExpandArrowButton = False
			Me.radDropDownButtonElement2.Image = My.Resources.new_paste_32
			Me.radDropDownButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radDropDownButtonElement2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem13, Me.radMenuItem14, Me.radMenuItem15})
			Me.radDropDownButtonElement2.Name = "radDropDownButtonElement2"
			Me.radDropDownButtonElement2.Text = "Paste"
			Me.radDropDownButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radDropDownButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.AccessibleDescription = "Paste"
			Me.radMenuItem13.AccessibleName = "Paste"
			Me.radMenuItem13.Image = My.Resources.new_paste_16
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Paste"
			Me.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.AccessibleDescription = "radMenuItem14"
			Me.radMenuItem14.AccessibleName = "radMenuItem14"
			Me.radMenuItem14.Image = My.Resources.paste_form
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "radMenuItem14"
			Me.radMenuItem14.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.AccessibleDescription = "Paste as hyperlink"
			Me.radMenuItem15.AccessibleName = "Paste as hyperlink"
			Me.radMenuItem15.Enabled = False
			Me.radMenuItem15.Image = My.Resources.msoffice_pastehyperlink
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Paste as hyperlink"
			Me.radMenuItem15.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup3
			' 
			Me.radRibbonBarButtonGroup3.AccessibleDescription = "radRibbonBarButtonGroup3"
			Me.radRibbonBarButtonGroup3.AccessibleName = "radRibbonBarButtonGroup3"
			Me.radRibbonBarButtonGroup3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement22, Me.radButtonElement23, Me.radButtonElement24})
			Me.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3"
			Me.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3"
			Me.radRibbonBarButtonGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement22
			' 
			Me.radButtonElement22.Class = "ButtonElement"
			Me.radButtonElement22.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement22.Image = My.Resources.cut
			Me.radButtonElement22.Name = "radButtonElement22"
			Me.radButtonElement22.ShowBorder = False
			Me.radButtonElement22.Text = ""
			Me.radButtonElement22.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement23
			' 
			Me.radButtonElement23.AccessibleDescription = "radButtonElement23"
			Me.radButtonElement23.AccessibleName = "radButtonElement23"
			Me.radButtonElement23.Class = "ButtonElement"
			Me.radButtonElement23.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement23.Image = My.Resources.copy
			Me.radButtonElement23.Name = "radButtonElement23"
			Me.radButtonElement23.ShowBorder = False
			Me.radButtonElement23.Text = "radButtonElement23"
			Me.radButtonElement23.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement24
			' 
			Me.radButtonElement24.AccessibleDescription = "radButtonElement24"
			Me.radButtonElement24.AccessibleName = "radButtonElement24"
			Me.radButtonElement24.Class = "ButtonElement"
			Me.radButtonElement24.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement24.Image = (CType(resources.GetObject("radButtonElement24.Image"), System.Drawing.Image))
			Me.radButtonElement24.ImageIndex = 9
			Me.radButtonElement24.Name = "radButtonElement24"
			Me.radButtonElement24.ShowBorder = False
			Me.radButtonElement24.Text = "radButtonElement24"
			Me.radButtonElement24.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup5
			' 
			Me.radRibbonBarGroup5.AccessibleDescription = "Font"
			Me.radRibbonBarGroup5.AccessibleName = "Font"
			Me.radRibbonBarGroup5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup4, Me.radRibbonBarButtonGroup7})
			Me.radRibbonBarGroup5.Name = "radRibbonBarGroup5"
			Me.radRibbonBarGroup5.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup5.Text = "Font"
			Me.radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup4
			' 
			Me.radRibbonBarButtonGroup4.AccessibleDescription = "radRibbonBarButtonGroup4"
			Me.radRibbonBarButtonGroup4.AccessibleName = "radRibbonBarButtonGroup4"
			Me.radRibbonBarButtonGroup4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radDropDownListElement1, Me.radDropDownListElement2, Me.radRibbonBarButtonGroup6})
			Me.radRibbonBarButtonGroup4.Margin = New System.Windows.Forms.Padding(2)
			Me.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4"
			Me.radRibbonBarButtonGroup4.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup4.ShowBackColor = False
			Me.radRibbonBarButtonGroup4.ShowBorder = False
			Me.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4"
			Me.radRibbonBarButtonGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownListElement1
			' 
			Me.radDropDownListElement1.AccessibleDescription = "Calibri (Body)"
			Me.radDropDownListElement1.AccessibleName = "Calibri (Body)"
			Me.radDropDownListElement1.AutoCompleteAppend = Nothing
			Me.radDropDownListElement1.AutoCompleteDataSource = Nothing
			Me.radDropDownListElement1.AutoCompleteDisplayMember = Nothing
			Me.radDropDownListElement1.AutoCompleteSuggest = Nothing
			Me.radDropDownListElement1.AutoCompleteValueMember = Nothing
			Me.radDropDownListElement1.DataSource = Nothing
			Me.radDropDownListElement1.DefaultItemsCountInDropDown = 6
			Me.radDropDownListElement1.DefaultValue = Nothing
			Me.radDropDownListElement1.DisplayMember = ""
			Me.radDropDownListElement1.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
			Me.radDropDownListElement1.EditableElementText = ""
			Me.radDropDownListElement1.EditorElement = Me.radDropDownListElement1
			Me.radDropDownListElement1.EditorManager = Nothing
			Me.radDropDownListElement1.Filter = Nothing
			Me.radDropDownListElement1.FilterExpression = ""
			Me.radDropDownListElement1.Focusable = True
			Me.radDropDownListElement1.FormatInfo = New System.Globalization.CultureInfo("en-US")
			Me.radDropDownListElement1.FormatString = "{0}"
			Me.radDropDownListElement1.FormattingEnabled = True
			Me.radDropDownListElement1.ItemHeight = 18
			radListDataItem1.Text = "ListItem 1"
			radListDataItem1.TextWrap = True
			Me.radDropDownListElement1.Items.Add(radListDataItem1)
			Me.radDropDownListElement1.MaxLength = 32767
			Me.radDropDownListElement1.MaxValue = Nothing
			Me.radDropDownListElement1.MinSize = New System.Drawing.Size(140, 0)
			Me.radDropDownListElement1.MinValue = Nothing
			Me.radDropDownListElement1.Name = "radDropDownListElement1"
			Me.radDropDownListElement1.NullValue = Nothing
			Me.radDropDownListElement1.OwnerOffset = 0
			Me.radDropDownListElement1.ShowImageInEditorArea = True
			Me.radDropDownListElement1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
			Me.radDropDownListElement1.Value = Nothing
			Me.radDropDownListElement1.ValueMember = ""
			Me.radDropDownListElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownListElement2
			' 
			Me.radDropDownListElement2.AccessibleDescription = "8"
			Me.radDropDownListElement2.AccessibleName = "8"
			Me.radDropDownListElement2.AutoCompleteAppend = Nothing
			Me.radDropDownListElement2.AutoCompleteDataSource = Nothing
			Me.radDropDownListElement2.AutoCompleteDisplayMember = Nothing
			Me.radDropDownListElement2.AutoCompleteSuggest = Nothing
			Me.radDropDownListElement2.AutoCompleteValueMember = Nothing
			Me.radDropDownListElement2.DataSource = Nothing
			Me.radDropDownListElement2.DefaultItemsCountInDropDown = 6
			Me.radDropDownListElement2.DefaultValue = Nothing
			Me.radDropDownListElement2.DisplayMember = ""
			Me.radDropDownListElement2.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
			Me.radDropDownListElement2.EditableElementText = "8"
			Me.radDropDownListElement2.EditorElement = Me.radDropDownListElement2
			Me.radDropDownListElement2.EditorManager = Nothing
			Me.radDropDownListElement2.Filter = Nothing
			Me.radDropDownListElement2.FilterExpression = ""
			Me.radDropDownListElement2.Focusable = True
			Me.radDropDownListElement2.FormatInfo = New System.Globalization.CultureInfo("en-US")
			Me.radDropDownListElement2.FormatString = "{0}"
			Me.radDropDownListElement2.FormattingEnabled = True
			Me.radDropDownListElement2.ItemHeight = 18
			radListDataItem2.Text = "8"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "9"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "10"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "11"
			radListDataItem5.TextWrap = True
			radListDataItem6.Text = "12"
			radListDataItem6.TextWrap = True
			radListDataItem7.Text = "14"
			radListDataItem7.TextWrap = True
			radListDataItem8.Text = "16"
			radListDataItem8.TextWrap = True
			radListDataItem9.Text = "18"
			radListDataItem9.TextWrap = True
			Me.radDropDownListElement2.Items.Add(radListDataItem2)
			Me.radDropDownListElement2.Items.Add(radListDataItem3)
			Me.radDropDownListElement2.Items.Add(radListDataItem4)
			Me.radDropDownListElement2.Items.Add(radListDataItem5)
			Me.radDropDownListElement2.Items.Add(radListDataItem6)
			Me.radDropDownListElement2.Items.Add(radListDataItem7)
			Me.radDropDownListElement2.Items.Add(radListDataItem8)
			Me.radDropDownListElement2.Items.Add(radListDataItem9)
			Me.radDropDownListElement2.MaxLength = 32767
			Me.radDropDownListElement2.MaxSize = New System.Drawing.Size(35, 0)
			Me.radDropDownListElement2.MaxValue = Nothing
			Me.radDropDownListElement2.MinSize = New System.Drawing.Size(140, 0)
			Me.radDropDownListElement2.MinValue = Nothing
			Me.radDropDownListElement2.Name = "radDropDownListElement2"
			Me.radDropDownListElement2.NullValue = Nothing
			Me.radDropDownListElement2.OwnerOffset = 0
			Me.radDropDownListElement2.ShowImageInEditorArea = True
			Me.radDropDownListElement2.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
			Me.radDropDownListElement2.Value = Nothing
			Me.radDropDownListElement2.ValueMember = ""
			Me.radDropDownListElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup6
			' 
			Me.radRibbonBarButtonGroup6.AccessibleDescription = "radRibbonBarButtonGroup6"
			Me.radRibbonBarButtonGroup6.AccessibleName = "radRibbonBarButtonGroup6"
			Me.radRibbonBarButtonGroup6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement27})
			Me.radRibbonBarButtonGroup6.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
			Me.radRibbonBarButtonGroup6.Name = "radRibbonBarButtonGroup6"
			Me.radRibbonBarButtonGroup6.Text = "radRibbonBarButtonGroup6"
			Me.radRibbonBarButtonGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement27
			' 
			Me.radButtonElement27.AccessibleDescription = "radButtonElement27"
			Me.radButtonElement27.AccessibleName = "radButtonElement27"
			Me.radButtonElement27.Class = "ButtonElement"
			Me.radButtonElement27.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement27.Image = (CType(resources.GetObject("radButtonElement27.Image"), System.Drawing.Image))
			Me.radButtonElement27.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement27.ImageIndex = 41
			Me.radButtonElement27.Name = "radButtonElement27"
			Me.radButtonElement27.ShowBorder = False
			Me.radButtonElement27.Text = "radButtonElement27"
			Me.radButtonElement27.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup7
			' 
			Me.radRibbonBarButtonGroup7.AccessibleDescription = "radRibbonBarButtonGroup7"
			Me.radRibbonBarButtonGroup7.AccessibleName = "radRibbonBarButtonGroup7"
			Me.radRibbonBarButtonGroup7.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup8, Me.radRibbonBarButtonGroup5})
			Me.radRibbonBarButtonGroup7.Margin = New System.Windows.Forms.Padding(2)
			Me.radRibbonBarButtonGroup7.Name = "radRibbonBarButtonGroup7"
			Me.radRibbonBarButtonGroup7.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup7.ShowBackColor = False
			Me.radRibbonBarButtonGroup7.ShowBorder = False
			Me.radRibbonBarButtonGroup7.Text = "radRibbonBarButtonGroup7"
			Me.radRibbonBarButtonGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup8
			' 
			Me.radRibbonBarButtonGroup8.AccessibleDescription = "radRibbonBarButtonGroup8"
			Me.radRibbonBarButtonGroup8.AccessibleName = "radRibbonBarButtonGroup8"
			Me.radRibbonBarButtonGroup8.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement28, Me.radButtonElement31, Me.radButtonElement32, Me.radButtonElement33, Me.radButtonElement34, Me.radButtonElement35})
			Me.radRibbonBarButtonGroup8.Name = "radRibbonBarButtonGroup8"
			Me.radRibbonBarButtonGroup8.Text = "radRibbonBarButtonGroup8"
			Me.radRibbonBarButtonGroup8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement28
			' 
			Me.radButtonElement28.AccessibleDescription = "radButtonElement28"
			Me.radButtonElement28.AccessibleName = "radButtonElement28"
			Me.radButtonElement28.Class = "ButtonElement"
			Me.radButtonElement28.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement28.Image = (CType(resources.GetObject("radButtonElement28.Image"), System.Drawing.Image))
			Me.radButtonElement28.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement28.ImageIndex = 1
			Me.radButtonElement28.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement28.Name = "radButtonElement28"
			Me.radButtonElement28.Text = "radButtonElement28"
			Me.radButtonElement28.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement31
			' 
			Me.radButtonElement31.AccessibleDescription = "radButtonElement31"
			Me.radButtonElement31.AccessibleName = "radButtonElement31"
			Me.radButtonElement31.Class = "ButtonElement"
			Me.radButtonElement31.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement31.Image = (CType(resources.GetObject("radButtonElement31.Image"), System.Drawing.Image))
			Me.radButtonElement31.ImageIndex = 16
			Me.radButtonElement31.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement31.Name = "radButtonElement31"
			Me.radButtonElement31.Text = "radButtonElement31"
			Me.radButtonElement31.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement32
			' 
			Me.radButtonElement32.AccessibleDescription = "radButtonElement32"
			Me.radButtonElement32.AccessibleName = "radButtonElement32"
			Me.radButtonElement32.Class = "ButtonElement"
			Me.radButtonElement32.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement32.Image = (CType(resources.GetObject("radButtonElement32.Image"), System.Drawing.Image))
			Me.radButtonElement32.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement32.ImageIndex = 26
			Me.radButtonElement32.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement32.Name = "radButtonElement32"
			Me.radButtonElement32.Text = "radButtonElement32"
			Me.radButtonElement32.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement33
			' 
			Me.radButtonElement33.AccessibleDescription = "radButtonElement33"
			Me.radButtonElement33.AccessibleName = "radButtonElement33"
			Me.radButtonElement33.Class = "ButtonElement"
			Me.radButtonElement33.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement33.Image = My.Resources.msoffice_Strikethrough16
			Me.radButtonElement33.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement33.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement33.Name = "radButtonElement33"
			Me.radButtonElement33.Text = "radButtonElement33"
			Me.radButtonElement33.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement34
			' 
			Me.radButtonElement34.AccessibleDescription = "radButtonElement34"
			Me.radButtonElement34.AccessibleName = "radButtonElement34"
			Me.radButtonElement34.Class = "ButtonElement"
			Me.radButtonElement34.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement34.Image = (CType(resources.GetObject("radButtonElement34.Image"), System.Drawing.Image))
			Me.radButtonElement34.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement34.ImageIndex = 23
			Me.radButtonElement34.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement34.Name = "radButtonElement34"
			Me.radButtonElement34.Text = "radButtonElement34"
			Me.radButtonElement34.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement35
			' 
			Me.radButtonElement35.AccessibleDescription = "radButtonElement35"
			Me.radButtonElement35.AccessibleName = "radButtonElement35"
			Me.radButtonElement35.Class = "ButtonElement"
			Me.radButtonElement35.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement35.Image = (CType(resources.GetObject("radButtonElement35.Image"), System.Drawing.Image))
			Me.radButtonElement35.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement35.ImageIndex = 24
			Me.radButtonElement35.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement35.Name = "radButtonElement35"
			Me.radButtonElement35.ShowBorder = False
			Me.radButtonElement35.Text = "radButtonElement35"
			Me.radButtonElement35.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup5
			' 
			Me.radRibbonBarButtonGroup5.AccessibleDescription = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.AccessibleName = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement25, Me.radButtonElement26})
			Me.radRibbonBarButtonGroup5.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Text = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement25
			' 
			Me.radButtonElement25.AccessibleDescription = "radButtonElement25"
			Me.radButtonElement25.AccessibleName = "radButtonElement25"
			Me.radButtonElement25.Class = "ButtonElement"
			Me.radButtonElement25.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement25.Image = (CType(resources.GetObject("radButtonElement25.Image"), System.Drawing.Image))
			Me.radButtonElement25.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement25.ImageIndex = 43
			Me.radButtonElement25.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement25.Name = "radButtonElement25"
			Me.radButtonElement25.Text = "radButtonElement25"
			Me.radButtonElement25.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement26
			' 
			Me.radButtonElement26.AccessibleDescription = "radButtonElement26"
			Me.radButtonElement26.AccessibleName = "radButtonElement26"
			Me.radButtonElement26.Class = "ButtonElement"
			Me.radButtonElement26.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement26.Image = (CType(resources.GetObject("radButtonElement26.Image"), System.Drawing.Image))
			Me.radButtonElement26.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement26.ImageIndex = 42
			Me.radButtonElement26.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement26.Name = "radButtonElement26"
			Me.radButtonElement26.ShowBorder = False
			Me.radButtonElement26.Text = "radButtonElement26"
			Me.radButtonElement26.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup6
			' 
			Me.radRibbonBarGroup6.AccessibleDescription = "Paragraph"
			Me.radRibbonBarGroup6.AccessibleName = "Paragraph"
			Me.radRibbonBarGroup6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup9, Me.radRibbonBarButtonGroup10})
			Me.radRibbonBarGroup6.Name = "radRibbonBarGroup6"
			Me.radRibbonBarGroup6.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup6.Text = "Paragraph"
			Me.radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup9
			' 
			Me.radRibbonBarButtonGroup9.AccessibleDescription = "radRibbonBarButtonGroup9"
			Me.radRibbonBarButtonGroup9.AccessibleName = "radRibbonBarButtonGroup9"
			Me.radRibbonBarButtonGroup9.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup14, Me.radRibbonBarButtonGroup15, Me.radRibbonBarButtonGroup16, Me.radRibbonBarButtonGroup17})
			Me.radRibbonBarButtonGroup9.Margin = New System.Windows.Forms.Padding(2)
			Me.radRibbonBarButtonGroup9.Name = "radRibbonBarButtonGroup9"
			Me.radRibbonBarButtonGroup9.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup9.ShowBackColor = False
			Me.radRibbonBarButtonGroup9.ShowBorder = False
			Me.radRibbonBarButtonGroup9.Text = "radRibbonBarButtonGroup9"
			Me.radRibbonBarButtonGroup9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup14
			' 
			Me.radRibbonBarButtonGroup14.AccessibleDescription = "radRibbonBarButtonGroup14"
			Me.radRibbonBarButtonGroup14.AccessibleName = "radRibbonBarButtonGroup14"
			Me.radRibbonBarButtonGroup14.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement53, Me.radButtonElement54, Me.radButtonElement55})
			Me.radRibbonBarButtonGroup14.Name = "radRibbonBarButtonGroup14"
			Me.radRibbonBarButtonGroup14.Text = "radRibbonBarButtonGroup14"
			Me.radRibbonBarButtonGroup14.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement53
			' 
			Me.radButtonElement53.AccessibleDescription = "radButtonElement53"
			Me.radButtonElement53.AccessibleName = "radButtonElement53"
			Me.radButtonElement53.Class = "ButtonElement"
			Me.radButtonElement53.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement53.Image = (CType(resources.GetObject("radButtonElement53.Image"), System.Drawing.Image))
			Me.radButtonElement53.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement53.ImageIndex = 15
			Me.radButtonElement53.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement53.Name = "radButtonElement53"
			Me.radButtonElement53.Text = "radButtonElement53"
			Me.radButtonElement53.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement54
			' 
			Me.radButtonElement54.AccessibleDescription = "radButtonElement54"
			Me.radButtonElement54.AccessibleName = "radButtonElement54"
			Me.radButtonElement54.Class = "ButtonElement"
			Me.radButtonElement54.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement54.Image = (CType(resources.GetObject("radButtonElement54.Image"), System.Drawing.Image))
			Me.radButtonElement54.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement54.ImageIndex = 12
			Me.radButtonElement54.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement54.Name = "radButtonElement54"
			Me.radButtonElement54.Text = "radButtonElement54"
			Me.radButtonElement54.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement55
			' 
			Me.radButtonElement55.AccessibleDescription = "radButtonElement55"
			Me.radButtonElement55.AccessibleName = "radButtonElement55"
			Me.radButtonElement55.Class = "ButtonElement"
			Me.radButtonElement55.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement55.Image = My.Resources.msoffice_list_numbered_tb
			Me.radButtonElement55.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement55.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement55.Name = "radButtonElement55"
			Me.radButtonElement55.ShowBorder = False
			Me.radButtonElement55.Text = "radButtonElement55"
			Me.radButtonElement55.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup15
			' 
			Me.radRibbonBarButtonGroup15.AccessibleDescription = "radRibbonBarButtonGroup15"
			Me.radRibbonBarButtonGroup15.AccessibleName = "radRibbonBarButtonGroup15"
			Me.radRibbonBarButtonGroup15.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement56})
			Me.radRibbonBarButtonGroup15.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup15.Name = "radRibbonBarButtonGroup15"
			Me.radRibbonBarButtonGroup15.Text = "radRibbonBarButtonGroup15"
			Me.radRibbonBarButtonGroup15.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement56
			' 
			Me.radButtonElement56.AccessibleDescription = "radButtonElement56"
			Me.radButtonElement56.AccessibleName = "radButtonElement56"
			Me.radButtonElement56.Class = "ButtonElement"
			Me.radButtonElement56.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement56.Image = My.Resources.msoffice_sortasc
			Me.radButtonElement56.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement56.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement56.Name = "radButtonElement56"
			Me.radButtonElement56.ShowBorder = False
			Me.radButtonElement56.Text = "radButtonElement56"
			Me.radButtonElement56.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup16
			' 
			Me.radRibbonBarButtonGroup16.AccessibleDescription = "radRibbonBarButtonGroup16"
			Me.radRibbonBarButtonGroup16.AccessibleName = "radRibbonBarButtonGroup16"
			Me.radRibbonBarButtonGroup16.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement51, Me.radButtonElement52})
			Me.radRibbonBarButtonGroup16.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup16.Name = "radRibbonBarButtonGroup16"
			Me.radRibbonBarButtonGroup16.Text = "radRibbonBarButtonGroup16"
			Me.radRibbonBarButtonGroup16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement51
			' 
			Me.radButtonElement51.AccessibleDescription = "radButtonElement51"
			Me.radButtonElement51.AccessibleName = "radButtonElement51"
			Me.radButtonElement51.Class = "ButtonElement"
			Me.radButtonElement51.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement51.Image = (CType(resources.GetObject("radButtonElement51.Image"), System.Drawing.Image))
			Me.radButtonElement51.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement51.ImageIndex = 21
			Me.radButtonElement51.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement51.Name = "radButtonElement51"
			Me.radButtonElement51.Text = "radButtonElement51"
			Me.radButtonElement51.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement52
			' 
			Me.radButtonElement52.AccessibleDescription = "radButtonElement52"
			Me.radButtonElement52.AccessibleName = "radButtonElement52"
			Me.radButtonElement52.Class = "ButtonElement"
			Me.radButtonElement52.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement52.Image = (CType(resources.GetObject("radButtonElement52.Image"), System.Drawing.Image))
			Me.radButtonElement52.ImageIndex = 11
			Me.radButtonElement52.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement52.Name = "radButtonElement52"
			Me.radButtonElement52.ShowBorder = False
			Me.radButtonElement52.Text = "radButtonElement52"
			Me.radButtonElement52.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup17
			' 
			Me.radRibbonBarButtonGroup17.AccessibleDescription = "radRibbonBarButtonGroup17"
			Me.radRibbonBarButtonGroup17.AccessibleName = "radRibbonBarButtonGroup17"
			Me.radRibbonBarButtonGroup17.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement50})
			Me.radRibbonBarButtonGroup17.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup17.MaxSize = New System.Drawing.Size(24, 22)
			Me.radRibbonBarButtonGroup17.Name = "radRibbonBarButtonGroup17"
			Me.radRibbonBarButtonGroup17.Text = "radRibbonBarButtonGroup17"
			Me.radRibbonBarButtonGroup17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement50
			' 
			Me.radButtonElement50.AccessibleDescription = "radButtonElement50"
			Me.radButtonElement50.AccessibleName = "radButtonElement50"
			Me.radButtonElement50.Class = "ButtonElement"
			Me.radButtonElement50.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement50.Image = My.Resources.mscoffice_zoom
			Me.radButtonElement50.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement50.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement50.Name = "radButtonElement50"
			Me.radButtonElement50.ShowBorder = False
			Me.radButtonElement50.Text = "radButtonElement50"
			Me.radButtonElement50.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup10
			' 
			Me.radRibbonBarButtonGroup10.AccessibleDescription = "radRibbonBarButtonGroup10"
			Me.radRibbonBarButtonGroup10.AccessibleName = "radRibbonBarButtonGroup10"
			Me.radRibbonBarButtonGroup10.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup11, Me.radRibbonBarButtonGroup13, Me.radRibbonBarButtonGroup12})
			Me.radRibbonBarButtonGroup10.Margin = New System.Windows.Forms.Padding(2)
			Me.radRibbonBarButtonGroup10.Name = "radRibbonBarButtonGroup10"
			Me.radRibbonBarButtonGroup10.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup10.ShowBackColor = False
			Me.radRibbonBarButtonGroup10.ShowBorder = False
			Me.radRibbonBarButtonGroup10.Text = "radRibbonBarButtonGroup10"
			Me.radRibbonBarButtonGroup10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup11
			' 
			Me.radRibbonBarButtonGroup11.AccessibleDescription = "radRibbonBarButtonGroup11"
			Me.radRibbonBarButtonGroup11.AccessibleName = "radRibbonBarButtonGroup11"
			Me.radRibbonBarButtonGroup11.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement43, Me.radButtonElement44, Me.radButtonElement45, Me.radButtonElement46})
			Me.radRibbonBarButtonGroup11.Name = "radRibbonBarButtonGroup11"
			Me.radRibbonBarButtonGroup11.Text = "radRibbonBarButtonGroup11"
			Me.radRibbonBarButtonGroup11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement43
			' 
			Me.radButtonElement43.AccessibleDescription = "radButtonElement43"
			Me.radButtonElement43.AccessibleName = "radButtonElement43"
			Me.radButtonElement43.Class = "ButtonElement"
			Me.radButtonElement43.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement43.Image = (CType(resources.GetObject("radButtonElement43.Image"), System.Drawing.Image))
			Me.radButtonElement43.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement43.ImageIndex = 19
			Me.radButtonElement43.Name = "radButtonElement43"
			Me.radButtonElement43.Text = "radButtonElement43"
			Me.radButtonElement43.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement44
			' 
			Me.radButtonElement44.AccessibleDescription = "radButtonElement44"
			Me.radButtonElement44.AccessibleName = "radButtonElement44"
			Me.radButtonElement44.Class = "ButtonElement"
			Me.radButtonElement44.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement44.Image = (CType(resources.GetObject("radButtonElement44.Image"), System.Drawing.Image))
			Me.radButtonElement44.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement44.ImageIndex = 17
			Me.radButtonElement44.Name = "radButtonElement44"
			Me.radButtonElement44.Text = "radButtonElement44"
			Me.radButtonElement44.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement45
			' 
			Me.radButtonElement45.AccessibleDescription = "radButtonElement45"
			Me.radButtonElement45.AccessibleName = "radButtonElement45"
			Me.radButtonElement45.Class = "ButtonElement"
			Me.radButtonElement45.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement45.Image = (CType(resources.GetObject("radButtonElement45.Image"), System.Drawing.Image))
			Me.radButtonElement45.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement45.ImageIndex = 20
			Me.radButtonElement45.Name = "radButtonElement45"
			Me.radButtonElement45.Text = "radButtonElement45"
			Me.radButtonElement45.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement46
			' 
			Me.radButtonElement46.AccessibleDescription = "radButtonElement46"
			Me.radButtonElement46.AccessibleName = "radButtonElement46"
			Me.radButtonElement46.Class = "ButtonElement"
			Me.radButtonElement46.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement46.Image = (CType(resources.GetObject("radButtonElement46.Image"), System.Drawing.Image))
			Me.radButtonElement46.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement46.ImageIndex = 18
			Me.radButtonElement46.Name = "radButtonElement46"
			Me.radButtonElement46.ShowBorder = False
			Me.radButtonElement46.Text = "radButtonElement46"
			Me.radButtonElement46.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup13
			' 
			Me.radRibbonBarButtonGroup13.AccessibleDescription = "radRibbonBarButtonGroup13"
			Me.radRibbonBarButtonGroup13.AccessibleName = "radRibbonBarButtonGroup13"
			Me.radRibbonBarButtonGroup13.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement47})
			Me.radRibbonBarButtonGroup13.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup13.Name = "radRibbonBarButtonGroup13"
			Me.radRibbonBarButtonGroup13.Text = "radRibbonBarButtonGroup13"
			Me.radRibbonBarButtonGroup13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement47
			' 
			Me.radButtonElement47.AccessibleDescription = "radButtonElement47"
			Me.radButtonElement47.AccessibleName = "radButtonElement47"
			Me.radButtonElement47.Class = "ButtonElement"
			Me.radButtonElement47.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement47.Image = My.Resources.msoffice_expandspace
			Me.radButtonElement47.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement47.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement47.Name = "radButtonElement47"
			Me.radButtonElement47.ShowBorder = False
			Me.radButtonElement47.Text = "radButtonElement47"
			Me.radButtonElement47.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup12
			' 
			Me.radRibbonBarButtonGroup12.AccessibleDescription = "radRibbonBarButtonGroup12"
			Me.radRibbonBarButtonGroup12.AccessibleName = "radRibbonBarButtonGroup12"
			Me.radRibbonBarButtonGroup12.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement48, Me.radButtonElement49})
			Me.radRibbonBarButtonGroup12.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radRibbonBarButtonGroup12.Name = "radRibbonBarButtonGroup12"
			Me.radRibbonBarButtonGroup12.Text = "radRibbonBarButtonGroup12"
			Me.radRibbonBarButtonGroup12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement48
			' 
			Me.radButtonElement48.AccessibleDescription = "radButtonElement48"
			Me.radButtonElement48.AccessibleName = "radButtonElement48"
			Me.radButtonElement48.Class = "ButtonElement"
			Me.radButtonElement48.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement48.Image = My.Resources.msoffice_linecolor
			Me.radButtonElement48.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement48.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement48.Name = "radButtonElement48"
			Me.radButtonElement48.Text = "radButtonElement48"
			Me.radButtonElement48.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement49
			' 
			Me.radButtonElement49.AccessibleDescription = "radButtonElement49"
			Me.radButtonElement49.AccessibleName = "radButtonElement49"
			Me.radButtonElement49.Class = "ButtonElement"
			Me.radButtonElement49.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement49.Image = My.Resources.msoffice_ruler
			Me.radButtonElement49.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement49.MinSize = New System.Drawing.Size(24, 22)
			Me.radButtonElement49.Name = "radButtonElement49"
			Me.radButtonElement49.ShowBorder = False
			Me.radButtonElement49.Text = "radButtonElement49"
			Me.radButtonElement49.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup7
			' 
			Me.radRibbonBarGroup7.AccessibleDescription = "Styles"
			Me.radRibbonBarGroup7.AccessibleName = "Styles"
			Me.radRibbonBarGroup7.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryElement1, Me.radButtonElement57})
			Me.radRibbonBarGroup7.Name = "radRibbonBarGroup7"
			Me.radRibbonBarGroup7.Text = "Styles"
			Me.radRibbonBarGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryElement1
			' 
			Me.radGalleryElement1.AccessibleDescription = "radGalleryElement1"
			Me.radGalleryElement1.AccessibleName = "radGalleryElement1"
			Me.radGalleryElement1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryItem1, Me.radGalleryItem2, Me.radGalleryItem3, Me.radGalleryItem4, Me.radGalleryItem5, Me.radGalleryItem6})
			Me.radGalleryElement1.Margin = New System.Windows.Forms.Padding(2)
			Me.radGalleryElement1.MaxColumns = 3
			Me.radGalleryElement1.Name = "radGalleryElement1"
			Me.radGalleryElement1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
			Me.radGalleryElement1.StretchVertically = False
			Me.radGalleryElement1.Text = "radGalleryElement1"
			Me.radGalleryElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem1
			' 
			Me.radGalleryItem1.AccessibleDescription = "radGalleryItem1"
			Me.radGalleryItem1.AccessibleName = "radGalleryItem1"
			Me.radGalleryItem1.DescriptionText = ""
			Me.radGalleryItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem1.Image = My.Resources.Style1
			Me.radGalleryItem1.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem1.Name = "radGalleryItem1"
			Me.radGalleryItem1.Padding = New System.Windows.Forms.Padding(2)
			Me.radGalleryItem1.StretchHorizontally = False
			Me.radGalleryItem1.StretchVertically = False
			Me.radGalleryItem1.Text = "radGalleryItem1"
			Me.radGalleryItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem2
			' 
			Me.radGalleryItem2.AccessibleDescription = "radGalleryItem2"
			Me.radGalleryItem2.AccessibleName = "radGalleryItem2"
			Me.radGalleryItem2.DescriptionText = ""
			Me.radGalleryItem2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem2.Image = My.Resources.Style2
			Me.radGalleryItem2.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem2.Name = "radGalleryItem2"
			Me.radGalleryItem2.StretchHorizontally = False
			Me.radGalleryItem2.StretchVertically = False
			Me.radGalleryItem2.Text = "radGalleryItem2"
			Me.radGalleryItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem3
			' 
			Me.radGalleryItem3.AccessibleDescription = "radGalleryItem3"
			Me.radGalleryItem3.AccessibleName = "radGalleryItem3"
			Me.radGalleryItem3.DescriptionText = ""
			Me.radGalleryItem3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem3.Image = My.Resources.Style3
			Me.radGalleryItem3.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem3.Name = "radGalleryItem3"
			Me.radGalleryItem3.StretchHorizontally = False
			Me.radGalleryItem3.StretchVertically = False
			Me.radGalleryItem3.Text = "radGalleryItem3"
			Me.radGalleryItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem4
			' 
			Me.radGalleryItem4.AccessibleDescription = "radGalleryItem4"
			Me.radGalleryItem4.AccessibleName = "radGalleryItem4"
			Me.radGalleryItem4.DescriptionText = ""
			Me.radGalleryItem4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem4.Image = My.Resources.Style4
			Me.radGalleryItem4.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem4.Name = "radGalleryItem4"
			Me.radGalleryItem4.StretchHorizontally = False
			Me.radGalleryItem4.StretchVertically = False
			Me.radGalleryItem4.Text = "radGalleryItem4"
			Me.radGalleryItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem5
			' 
			Me.radGalleryItem5.AccessibleDescription = "radGalleryItem5"
			Me.radGalleryItem5.AccessibleName = "radGalleryItem5"
			Me.radGalleryItem5.DescriptionText = ""
			Me.radGalleryItem5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem5.Image = My.Resources.Style5
			Me.radGalleryItem5.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem5.Name = "radGalleryItem5"
			Me.radGalleryItem5.StretchHorizontally = False
			Me.radGalleryItem5.StretchVertically = False
			Me.radGalleryItem5.Text = "radGalleryItem5"
			Me.radGalleryItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem6
			' 
			Me.radGalleryItem6.AccessibleDescription = "radGalleryItem6"
			Me.radGalleryItem6.AccessibleName = "radGalleryItem6"
			Me.radGalleryItem6.DescriptionText = ""
			Me.radGalleryItem6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radGalleryItem6.Image = My.Resources.Style6
			Me.radGalleryItem6.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
			Me.radGalleryItem6.Name = "radGalleryItem6"
			Me.radGalleryItem6.StretchHorizontally = False
			Me.radGalleryItem6.StretchVertically = False
			Me.radGalleryItem6.Text = "radGalleryItem6"
			Me.radGalleryItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement57
			' 
			Me.radButtonElement57.AccessibleDescription = "<html>Change <br>Style"
			Me.radButtonElement57.AccessibleName = "<html>Change <br>Style"
			Me.radButtonElement57.Class = "RibbonBarButtonElement"
			Me.radButtonElement57.Image = My.Resources.msoffice_ChangeStyles32
			Me.radButtonElement57.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement57.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement57.Name = "radButtonElement57"
			Me.radButtonElement57.Text = "<html>Change <br>Style"
			Me.radButtonElement57.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement57.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup8
			' 
			Me.radRibbonBarGroup8.AccessibleDescription = "Editing"
			Me.radRibbonBarGroup8.AccessibleName = "Editing"
			Me.radRibbonBarGroup8.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radDropDownButtonElement3, Me.radButtonElement58, Me.radDropDownButtonElement4})
			Me.radRibbonBarGroup8.Name = "radRibbonBarGroup8"
			Me.radRibbonBarGroup8.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup8.Text = "Editing"
			Me.radRibbonBarGroup8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement3
			' 
			Me.radDropDownButtonElement3.AccessibleDescription = "Find"
			Me.radDropDownButtonElement3.AccessibleName = "Find"
			Me.radDropDownButtonElement3.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement3.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement3.ExpandArrowButton = False
			Me.radDropDownButtonElement3.Image = My.Resources.msoffice_symbols
			Me.radDropDownButtonElement3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem16, Me.radMenuItem17})
			Me.radDropDownButtonElement3.Margin = New System.Windows.Forms.Padding(2)
			Me.radDropDownButtonElement3.Name = "radDropDownButtonElement3"
			Me.radDropDownButtonElement3.Text = "Find"
			Me.radDropDownButtonElement3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.AccessibleDescription = "Find"
			Me.radMenuItem16.AccessibleName = "Find"
			Me.radMenuItem16.Image = My.Resources.msoffice_symbols
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Find"
			Me.radMenuItem16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.AccessibleDescription = "Go to..."
			Me.radMenuItem17.AccessibleName = "Go to..."
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Go to..."
			Me.radMenuItem17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement58
			' 
			Me.radButtonElement58.AccessibleDescription = "Replace"
			Me.radButtonElement58.AccessibleName = "Replace"
			Me.radButtonElement58.Class = "RibbonBarButtonElement"
			Me.radButtonElement58.Image = My.Resources.msoffice_findnext
			Me.radButtonElement58.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement58.Name = "radButtonElement58"
			Me.radButtonElement58.Text = "Replace"
			Me.radButtonElement58.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement58.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement58.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement4
			' 
			Me.radDropDownButtonElement4.AccessibleDescription = "Select"
			Me.radDropDownButtonElement4.AccessibleName = "Select"
			Me.radDropDownButtonElement4.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement4.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement4.ExpandArrowButton = False
			Me.radDropDownButtonElement4.Image = My.Resources.msoffice_pointer
			Me.radDropDownButtonElement4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem18, Me.radMenuItem19, Me.radMenuItem20})
			Me.radDropDownButtonElement4.Margin = New System.Windows.Forms.Padding(2)
			Me.radDropDownButtonElement4.Name = "radDropDownButtonElement4"
			Me.radDropDownButtonElement4.Text = "Select"
			Me.radDropDownButtonElement4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.AccessibleDescription = "Select All"
			Me.radMenuItem18.AccessibleName = "Select All"
			Me.radMenuItem18.Image = My.Resources.msoffice_pointer
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Select All"
			Me.radMenuItem18.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.AccessibleDescription = "Select Objects"
			Me.radMenuItem19.AccessibleName = "Select Objects"
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Select Objects"
			Me.radMenuItem19.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.AccessibleDescription = "Select Text with Similar Formatting"
			Me.radMenuItem20.AccessibleName = "Select Text with Similar Formatting"
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Select Text with Similar Formatting"
			Me.radMenuItem20.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarCommandTab1
			' 
			Me.radRibbonBarCommandTab1.AccessibleDescription = "Insert"
			Me.radRibbonBarCommandTab1.AccessibleName = "Insert"
			Me.radRibbonBarCommandTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft
			Me.radRibbonBarCommandTab1.CanFocus = True
			Me.radRibbonBarCommandTab1.Class = "TabItem"
			' 
			' radRibbonBarCommandTab1.ContentPanel
			' 
			Me.radRibbonBarCommandTab1.ContentPanel.BackColor = System.Drawing.Color.Transparent
			Me.radRibbonBarCommandTab1.ContentPanel.CausesValidation = True
			Me.radRibbonBarCommandTab1.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radRibbonBarCommandTab1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radRibbonBarCommandTab1.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.radRibbonBarCommandTab1.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.radRibbonBarCommandTab1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarChunk2, Me.radRibbonBarChunk5, Me.radRibbonBarChunk6, Me.radRibbonBarGroup1, Me.radRibbonBarGroup2, Me.radRibbonBarChunk1, Me.radRibbonBarGroup3})
			Me.radRibbonBarCommandTab1.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.radRibbonBarCommandTab1.Name = "radRibbonBarCommandTab1"
			Me.radRibbonBarCommandTab1.StretchHorizontally = False
			Me.radRibbonBarCommandTab1.Text = "Insert"
			Me.radRibbonBarCommandTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk2
			' 
			Me.radRibbonBarChunk2.AccessibleDescription = "Pages"
			Me.radRibbonBarChunk2.AccessibleName = "Pages"
			Me.radRibbonBarChunk2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement5, Me.radButtonElement30, Me.radButtonElement29})
			Me.radRibbonBarChunk2.Name = "radRibbonBarChunk2"
			Me.radRibbonBarChunk2.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarChunk2.Text = "Pages"
			Me.radRibbonBarChunk2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement5
			' 
			Me.radButtonElement5.AccessibleDescription = "Blank Page"
			Me.radButtonElement5.AccessibleName = "Blank Page"
			Me.radButtonElement5.CanFocus = True
			Me.radButtonElement5.Class = "RibbonBarButtonElement"
			Me.radButtonElement5.Image = My.Resources.insert2
			Me.radButtonElement5.Margin = New System.Windows.Forms.Padding(4, 2, 4, 0)
			Me.radButtonElement5.Name = "radButtonElement5"
			Me.radButtonElement5.Padding = New System.Windows.Forms.Padding(2)
			Me.radButtonElement5.StretchVertically = False
			Me.radButtonElement5.Text = "Blank Page"
			Me.radButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement30
			' 
			Me.radButtonElement30.AccessibleDescription = "Page Break"
			Me.radButtonElement30.AccessibleName = "Page Break"
			Me.radButtonElement30.CanFocus = True
			Me.radButtonElement30.Class = "RibbonBarButtonElement"
			Me.radButtonElement30.Image = My.Resources.insert3
			Me.radButtonElement30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.radButtonElement30.Name = "radButtonElement30"
			Me.radButtonElement30.Padding = New System.Windows.Forms.Padding(2)
			Me.radButtonElement30.StretchVertically = False
			Me.radButtonElement30.Text = "Page Break"
			Me.radButtonElement30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement30.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement29
			' 
			Me.radButtonElement29.AccessibleDescription = "Cover Page"
			Me.radButtonElement29.AccessibleName = "Cover Page"
			Me.radButtonElement29.CanFocus = True
			Me.radButtonElement29.Class = "RibbonBarButtonElement"
			Me.radButtonElement29.Image = My.Resources.insert1
			Me.radButtonElement29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.radButtonElement29.Name = "radButtonElement29"
			Me.radButtonElement29.Padding = New System.Windows.Forms.Padding(2)
			Me.radButtonElement29.StretchVertically = False
			Me.radButtonElement29.Text = "Cover Page"
			Me.radButtonElement29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement29.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk5
			' 
			Me.radRibbonBarChunk5.AccessibleDescription = "Tables"
			Me.radRibbonBarChunk5.AccessibleName = "Tables"
			Me.radRibbonBarChunk5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement11})
			Me.radRibbonBarChunk5.Name = "radRibbonBarChunk5"
			Me.radRibbonBarChunk5.Text = "Tables"
			Me.radRibbonBarChunk5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement11
			' 
			Me.radButtonElement11.AccessibleDescription = "Table"
			Me.radButtonElement11.AccessibleName = "Table"
			Me.radButtonElement11.Class = "RibbonBarButtonElement"
			Me.radButtonElement11.Image = My.Resources.insert4
			Me.radButtonElement11.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement11.Name = "radButtonElement11"
			Me.radButtonElement11.Text = "Table"
			Me.radButtonElement11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk6
			' 
			Me.radRibbonBarChunk6.AccessibleDescription = "Illustrations"
			Me.radRibbonBarChunk6.AccessibleName = "Illustrations"
			Me.radRibbonBarChunk6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement9, Me.radButtonElement10, Me.radButtonElement6, Me.radButtonElement8, Me.radButtonElement7})
			Me.radRibbonBarChunk6.Name = "radRibbonBarChunk6"
			Me.radRibbonBarChunk6.Text = "Illustrations"
			Me.radRibbonBarChunk6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement9
			' 
			Me.radButtonElement9.AccessibleDescription = "Picture"
			Me.radButtonElement9.AccessibleName = "Picture"
			Me.radButtonElement9.Class = "RibbonBarButtonElement"
			Me.radButtonElement9.Image = My.Resources.insert5
			Me.radButtonElement9.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement9.Name = "radButtonElement9"
			Me.radButtonElement9.Text = "Picture"
			Me.radButtonElement9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement10
			' 
			Me.radButtonElement10.AccessibleDescription = "Clip Art"
			Me.radButtonElement10.AccessibleName = "Clip Art"
			Me.radButtonElement10.Class = "RibbonBarButtonElement"
			Me.radButtonElement10.Image = My.Resources.mscoffice_ClipArt
			Me.radButtonElement10.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement10.Name = "radButtonElement10"
			Me.radButtonElement10.Text = "Clip Art"
			Me.radButtonElement10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement6
			' 
			Me.radButtonElement6.AccessibleDescription = "Shapes"
			Me.radButtonElement6.AccessibleName = "Shapes"
			Me.radButtonElement6.Class = "RibbonBarButtonElement"
			Me.radButtonElement6.Image = My.Resources.Shapes
			Me.radButtonElement6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement6.Name = "radButtonElement6"
			Me.radButtonElement6.Text = "Shapes"
			Me.radButtonElement6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement8
			' 
			Me.radButtonElement8.AccessibleDescription = "Smart Art"
			Me.radButtonElement8.AccessibleName = "Smart Art"
			Me.radButtonElement8.Class = "RibbonBarButtonElement"
			Me.radButtonElement8.Image = My.Resources.msoffice_SmartArt
			Me.radButtonElement8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement8.Name = "radButtonElement8"
			Me.radButtonElement8.Text = "Smart Art"
			Me.radButtonElement8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement7
			' 
			Me.radButtonElement7.AccessibleDescription = "Chart"
			Me.radButtonElement7.AccessibleName = "Chart"
			Me.radButtonElement7.Class = "RibbonBarButtonElement"
			Me.radButtonElement7.Image = My.Resources.msoffice_chart
			Me.radButtonElement7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement7.Name = "radButtonElement7"
			Me.radButtonElement7.Text = "Chart"
			Me.radButtonElement7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup1
			' 
			Me.radRibbonBarGroup1.AccessibleDescription = "Links"
			Me.radRibbonBarGroup1.AccessibleName = "Links"
			Me.radRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement12, Me.radButtonElement13, Me.radButtonElement14})
			Me.radRibbonBarGroup1.Name = "radRibbonBarGroup1"
			Me.radRibbonBarGroup1.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup1.Text = "Links"
			Me.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement12
			' 
			Me.radButtonElement12.AccessibleDescription = "Hyperlink"
			Me.radButtonElement12.AccessibleName = "Hyperlink"
			Me.radButtonElement12.Class = "RibbonBarButtonElement"
			Me.radButtonElement12.Image = My.Resources.msoffice_inserthyperlink
			Me.radButtonElement12.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement12.Name = "radButtonElement12"
			Me.radButtonElement12.Text = "Hyperlink"
			Me.radButtonElement12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement13
			' 
			Me.radButtonElement13.AccessibleDescription = "Bookmark"
			Me.radButtonElement13.AccessibleName = "Bookmark"
			Me.radButtonElement13.Class = "RibbonBarButtonElement"
			Me.radButtonElement13.Image = My.Resources.msoffice_Bookmark_16
			Me.radButtonElement13.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement13.Name = "radButtonElement13"
			Me.radButtonElement13.Text = "Bookmark"
			Me.radButtonElement13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement14
			' 
			Me.radButtonElement14.AccessibleDescription = "Cross-reference"
			Me.radButtonElement14.AccessibleName = "Cross-reference"
			Me.radButtonElement14.Class = "RibbonBarButtonElement"
			Me.radButtonElement14.Image = My.Resources.msoffice_CrossReference
			Me.radButtonElement14.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement14.Name = "radButtonElement14"
			Me.radButtonElement14.Text = "Cross-reference"
			Me.radButtonElement14.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement14.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup2
			' 
			Me.radRibbonBarGroup2.AccessibleDescription = "Header & Footer"
			Me.radRibbonBarGroup2.AccessibleName = "Header & Footer"
			Me.radRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement15, Me.radButtonElement16, Me.radDropDownButtonElement1})
			Me.radRibbonBarGroup2.Name = "radRibbonBarGroup2"
			Me.radRibbonBarGroup2.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup2.Text = "Header & Footer"
			Me.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement15
			' 
			Me.radButtonElement15.AccessibleDescription = "Header"
			Me.radButtonElement15.AccessibleName = "Header"
			Me.radButtonElement15.Class = "RibbonBarButtonElement"
			Me.radButtonElement15.Image = My.Resources.msoffice_Header
			Me.radButtonElement15.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement15.Name = "radButtonElement15"
			Me.radButtonElement15.Text = "Header"
			Me.radButtonElement15.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement15.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement16
			' 
			Me.radButtonElement16.AccessibleDescription = "Footer"
			Me.radButtonElement16.AccessibleName = "Footer"
			Me.radButtonElement16.Class = "RibbonBarButtonElement"
			Me.radButtonElement16.Image = My.Resources.msoffice_Footer1
			Me.radButtonElement16.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement16.Name = "radButtonElement16"
			Me.radButtonElement16.Text = "Footer"
			Me.radButtonElement16.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement1
			' 
			Me.radDropDownButtonElement1.AccessibleDescription = "Page Number"
			Me.radDropDownButtonElement1.AccessibleName = "Page Number"
			Me.radDropDownButtonElement1.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement1.ExpandArrowButton = False
			Me.radDropDownButtonElement1.Image = My.Resources.msoffice_Footer2
			Me.radDropDownButtonElement1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem9, Me.radMenuItem10, Me.radMenuSeparatorItem1, Me.radMenuItem11, Me.radMenuItem12})
			Me.radDropDownButtonElement1.Margin = New System.Windows.Forms.Padding(2)
			Me.radDropDownButtonElement1.Name = "radDropDownButtonElement1"
			Me.radDropDownButtonElement1.Text = "Page Number"
			Me.radDropDownButtonElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Top of Page"
			Me.radMenuItem4.AccessibleName = "Top of Page"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Top of Page"
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "Bottom of Page"
			Me.radMenuItem5.AccessibleName = "Bottom of Page"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Bottom of Page"
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "Page Margins"
			Me.radMenuItem9.AccessibleName = "Page Margins"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Page Margins"
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "Current Position"
			Me.radMenuItem10.AccessibleName = "Current Position"
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Current Position"
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.AccessibleDescription = "Format Page Numbers..."
			Me.radMenuItem11.AccessibleName = "Format Page Numbers..."
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Format Page Numbers..."
			Me.radMenuItem11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.AccessibleDescription = "Remove Page Numbers"
			Me.radMenuItem12.AccessibleName = "Remove Page Numbers"
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Remove Page Numbers"
			Me.radMenuItem12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk1
			' 
			Me.radRibbonBarChunk1.AccessibleDescription = "Text"
			Me.radRibbonBarChunk1.AccessibleName = "Text"
			Me.radRibbonBarChunk1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radRibbonBarButtonGroup2, Me.radRibbonBarButtonGroup1})
			Me.radRibbonBarChunk1.Name = "radRibbonBarChunk1"
			Me.radRibbonBarChunk1.Text = "Text"
			Me.radRibbonBarChunk1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "Text Box"
			Me.radButtonElement1.AccessibleName = "Text Box"
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Class = "RibbonBarButtonElement"
			Me.radButtonElement1.Image = (CType(resources.GetObject("radButtonElement1.Image"), System.Drawing.Image))
			Me.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.StretchVertically = False
			Me.radButtonElement1.Text = "Text Box"
			Me.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup2
			' 
			Me.radRibbonBarButtonGroup2.AccessibleDescription = "radRibbonBarButtonGroup2"
			Me.radRibbonBarButtonGroup2.AccessibleName = "radRibbonBarButtonGroup2"
			Me.radRibbonBarButtonGroup2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement2, Me.radButtonElement17, Me.radButtonElement18})
			Me.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2"
			Me.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarButtonGroup2.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2"
			Me.radRibbonBarButtonGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.AccessibleDescription = "Quck Parts"
			Me.radButtonElement2.AccessibleName = "Quck Parts"
			Me.radButtonElement2.Class = "ButtonElement"
			Me.radButtonElement2.Image = My.Resources.msoffice_QuickParts
			Me.radButtonElement2.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.ShowBorder = False
			Me.radButtonElement2.Text = "Quck Parts"
			Me.radButtonElement2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement17
			' 
			Me.radButtonElement17.AccessibleDescription = "WordArt"
			Me.radButtonElement17.AccessibleName = "WordArt"
			Me.radButtonElement17.Class = "ButtonElement"
			Me.radButtonElement17.Image = My.Resources.msoffice_highlight1
			Me.radButtonElement17.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement17.Name = "radButtonElement17"
			Me.radButtonElement17.ShowBorder = False
			Me.radButtonElement17.Text = "WordArt"
			Me.radButtonElement17.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement18
			' 
			Me.radButtonElement18.AccessibleDescription = "Drop Crap"
			Me.radButtonElement18.AccessibleName = "Drop Crap"
			Me.radButtonElement18.Class = "ButtonElement"
			Me.radButtonElement18.Image = My.Resources.msoffice_DropCap
			Me.radButtonElement18.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement18.Name = "radButtonElement18"
			Me.radButtonElement18.ShowBorder = False
			Me.radButtonElement18.Text = "Drop Crap"
			Me.radButtonElement18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement18.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup1
			' 
			Me.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1"
			Me.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1"
			Me.radRibbonBarButtonGroup1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement19, Me.radButtonElement4, Me.radButtonElement3})
			Me.radRibbonBarButtonGroup1.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1"
			Me.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarButtonGroup1.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup1.StretchVertically = False
			Me.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1"
			Me.radRibbonBarButtonGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement19
			' 
			Me.radButtonElement19.AccessibleDescription = "Signature Line"
			Me.radButtonElement19.AccessibleName = "Signature Line"
			Me.radButtonElement19.Class = "ButtonElement"
			Me.radButtonElement19.Image = My.Resources.msoffice_SignatureLine
			Me.radButtonElement19.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement19.Name = "radButtonElement19"
			Me.radButtonElement19.ShowBorder = False
			Me.radButtonElement19.Text = "Signature Line"
			Me.radButtonElement19.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement19.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement4
			' 
			Me.radButtonElement4.AccessibleDescription = "Date && Time"
			Me.radButtonElement4.AccessibleName = "Date && Time"
			Me.radButtonElement4.Class = "ButtonElement"
			Me.radButtonElement4.Image = My.Resources.msoffice_DateTime
			Me.radButtonElement4.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement4.Name = "radButtonElement4"
			Me.radButtonElement4.ShowBorder = False
			Me.radButtonElement4.Text = "Date && Time"
			Me.radButtonElement4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.AccessibleDescription = "Object"
			Me.radButtonElement3.AccessibleName = "Object"
			Me.radButtonElement3.Class = "ButtonElement"
			Me.radButtonElement3.Image = My.Resources.msoffice_Object
			Me.radButtonElement3.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.ShowBorder = False
			Me.radButtonElement3.Text = "Object"
			Me.radButtonElement3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup3
			' 
			Me.radRibbonBarGroup3.AccessibleDescription = "Symbols"
			Me.radRibbonBarGroup3.AccessibleName = "Symbols"
			Me.radRibbonBarGroup3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement20, Me.radButtonElement21})
			Me.radRibbonBarGroup3.Name = "radRibbonBarGroup3"
			Me.radRibbonBarGroup3.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup3.Text = "Symbols"
			Me.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement20
			' 
			Me.radButtonElement20.AccessibleDescription = "Equation"
			Me.radButtonElement20.AccessibleName = "Equation"
			Me.radButtonElement20.Class = "RibbonBarButtonElement"
			Me.radButtonElement20.Image = My.Resources.msoffice_equation
			Me.radButtonElement20.Margin = New System.Windows.Forms.Padding(2, 5, 2, 2)
			Me.radButtonElement20.Name = "radButtonElement20"
			Me.radButtonElement20.Text = "Equation"
			Me.radButtonElement20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement20.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement21
			' 
			Me.radButtonElement21.AccessibleDescription = "Symbol"
			Me.radButtonElement21.AccessibleName = "Symbol"
			Me.radButtonElement21.Class = "RibbonBarButtonElement"
			Me.radButtonElement21.Image = My.Resources.msoffice_symbols
			Me.radButtonElement21.Margin = New System.Windows.Forms.Padding(2)
			Me.radButtonElement21.Name = "radButtonElement21"
			Me.radButtonElement21.Text = "Symbol"
			Me.radButtonElement21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement21.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarCommandTab2
			' 
			Me.radRibbonBarCommandTab2.AccessibleDescription = "Page Layout"
			Me.radRibbonBarCommandTab2.AccessibleName = "Page Layout"
			Me.radRibbonBarCommandTab2.Alignment = System.Drawing.ContentAlignment.BottomLeft
			Me.radRibbonBarCommandTab2.CanFocus = True
			Me.radRibbonBarCommandTab2.Class = "TabItem"
			' 
			' radRibbonBarCommandTab2.ContentPanel
			' 
			Me.radRibbonBarCommandTab2.ContentPanel.BackColor = System.Drawing.Color.Transparent
			Me.radRibbonBarCommandTab2.ContentPanel.CausesValidation = True
			Me.radRibbonBarCommandTab2.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radRibbonBarCommandTab2.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radRibbonBarCommandTab2.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.radRibbonBarCommandTab2.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.radRibbonBarCommandTab2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarChunk7, Me.radRibbonBarChunk8})
			Me.radRibbonBarCommandTab2.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.radRibbonBarCommandTab2.Name = "radRibbonBarCommandTab2"
			Me.radRibbonBarCommandTab2.StretchHorizontally = False
			Me.radRibbonBarCommandTab2.Text = "Page Layout"
			Me.radRibbonBarCommandTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk7
			' 
			Me.radRibbonBarChunk7.AccessibleDescription = "Themes"
			Me.radRibbonBarChunk7.AccessibleName = "Themes"
			Me.radRibbonBarChunk7.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement36})
			Me.radRibbonBarChunk7.Name = "radRibbonBarChunk7"
			Me.radRibbonBarChunk7.Text = "Themes"
			Me.radRibbonBarChunk7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement36
			' 
			Me.radButtonElement36.AccessibleDescription = "Themes"
			Me.radButtonElement36.AccessibleName = "Themes"
			Me.radButtonElement36.CanFocus = True
			Me.radButtonElement36.Class = "RibbonBarButtonElement"
			Me.radButtonElement36.Image = My.Resources.pageLayout1
			Me.radButtonElement36.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButtonElement36.Name = "radButtonElement36"
			Me.radButtonElement36.Padding = New System.Windows.Forms.Padding(2, 12, 2, 5)
			Me.radButtonElement36.StretchVertically = False
			Me.radButtonElement36.Text = "Themes"
			Me.radButtonElement36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement36.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarChunk8
			' 
			Me.radRibbonBarChunk8.AccessibleDescription = "Page Setup"
			Me.radRibbonBarChunk8.AccessibleName = "Page Setup"
			Me.radRibbonBarChunk8.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement37, Me.radButtonElement38, Me.radButtonElement39, Me.radButtonElement40})
			Me.radRibbonBarChunk8.Name = "radRibbonBarChunk8"
			Me.radRibbonBarChunk8.Text = "Page Setup"
			Me.radRibbonBarChunk8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement37
			' 
			Me.radButtonElement37.AccessibleDescription = "Margins"
			Me.radButtonElement37.AccessibleName = "Margins"
			Me.radButtonElement37.CanFocus = True
			Me.radButtonElement37.Class = "RibbonBarButtonElement"
			Me.radButtonElement37.Image = My.Resources.pageLayout2
			Me.radButtonElement37.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement37.Name = "radButtonElement37"
			Me.radButtonElement37.Padding = New System.Windows.Forms.Padding(2, 12, 2, 5)
			Me.radButtonElement37.StretchVertically = False
			Me.radButtonElement37.Text = "Margins"
			Me.radButtonElement37.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement37.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement38
			' 
			Me.radButtonElement38.AccessibleDescription = "Orientation"
			Me.radButtonElement38.AccessibleName = "Orientation"
			Me.radButtonElement38.CanFocus = True
			Me.radButtonElement38.Class = "RibbonBarButtonElement"
			Me.radButtonElement38.Image = My.Resources.pageLayout3
			Me.radButtonElement38.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement38.Name = "radButtonElement38"
			Me.radButtonElement38.Padding = New System.Windows.Forms.Padding(2, 12, 2, 5)
			Me.radButtonElement38.StretchVertically = False
			Me.radButtonElement38.Text = "Orientation"
			Me.radButtonElement38.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement38.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement39
			' 
			Me.radButtonElement39.AccessibleDescription = "Columns"
			Me.radButtonElement39.AccessibleName = "Columns"
			Me.radButtonElement39.CanFocus = True
			Me.radButtonElement39.Class = "RibbonBarButtonElement"
			Me.radButtonElement39.Image = My.Resources.pageLayout4
			Me.radButtonElement39.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement39.Name = "radButtonElement39"
			Me.radButtonElement39.Padding = New System.Windows.Forms.Padding(2, 12, 2, 5)
			Me.radButtonElement39.StretchVertically = False
			Me.radButtonElement39.Text = "Columns"
			Me.radButtonElement39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement39.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement40
			' 
			Me.radButtonElement40.AccessibleDescription = "Size"
			Me.radButtonElement40.AccessibleName = "Size"
			Me.radButtonElement40.CanFocus = True
			Me.radButtonElement40.Class = "RibbonBarButtonElement"
			Me.radButtonElement40.Image = My.Resources.pageLayout5
			Me.radButtonElement40.Name = "radButtonElement40"
			Me.radButtonElement40.Padding = New System.Windows.Forms.Padding(2, 12, 2, 5)
			Me.radButtonElement40.StretchVertically = False
			Me.radButtonElement40.Text = "Size"
			Me.radButtonElement40.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement40.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			Me.imageList1.Images.SetKeyName(8, "")
			Me.imageList1.Images.SetKeyName(9, "")
			Me.imageList1.Images.SetKeyName(10, "")
			Me.imageList1.Images.SetKeyName(11, "")
			Me.imageList1.Images.SetKeyName(12, "")
			Me.imageList1.Images.SetKeyName(13, "")
			Me.imageList1.Images.SetKeyName(14, "")
			Me.imageList1.Images.SetKeyName(15, "")
			Me.imageList1.Images.SetKeyName(16, "")
			Me.imageList1.Images.SetKeyName(17, "")
			Me.imageList1.Images.SetKeyName(18, "")
			Me.imageList1.Images.SetKeyName(19, "")
			Me.imageList1.Images.SetKeyName(20, "")
			Me.imageList1.Images.SetKeyName(21, "")
			Me.imageList1.Images.SetKeyName(22, "")
			Me.imageList1.Images.SetKeyName(23, "")
			Me.imageList1.Images.SetKeyName(24, "")
			Me.imageList1.Images.SetKeyName(25, "")
			Me.imageList1.Images.SetKeyName(26, "")
			Me.imageList1.Images.SetKeyName(27, "")
			Me.imageList1.Images.SetKeyName(28, "")
			Me.imageList1.Images.SetKeyName(29, "")
			Me.imageList1.Images.SetKeyName(30, "")
			Me.imageList1.Images.SetKeyName(31, "")
			Me.imageList1.Images.SetKeyName(32, "")
			Me.imageList1.Images.SetKeyName(33, "pageLayout.gif")
			Me.imageList1.Images.SetKeyName(34, "insert5.gif")
			Me.imageList1.Images.SetKeyName(35, "insert6.gif")
			Me.imageList1.Images.SetKeyName(36, "insert.gif")
			Me.imageList1.Images.SetKeyName(37, "pageLayout1.gif")
			Me.imageList1.Images.SetKeyName(38, "pageLayout2.gif")
			Me.imageList1.Images.SetKeyName(39, "pageLayout3.gif")
			Me.imageList1.Images.SetKeyName(40, "pageLayout4.gif")
			Me.imageList1.Images.SetKeyName(41, "Eraser.gif")
			Me.imageList1.Images.SetKeyName(42, "Letter_down.gif")
			Me.imageList1.Images.SetKeyName(43, "Letter_up.gif")
			' 
			' radButtonElement41
			' 
			Me.radButtonElement41.AccessibleDescription = "New"
			Me.radButtonElement41.AccessibleName = "New"
			Me.radButtonElement41.CanFocus = True
			Me.radButtonElement41.Class = "RibbonBarButtonElement"
			Me.radButtonElement41.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement41.Image = My.Resources.msIcon1
			Me.radButtonElement41.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement41.Name = "radButtonElement41"
			Me.radButtonElement41.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement41.Text = "New"
			Me.radButtonElement41.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement41.ZIndex = 4
			' 
			' radButtonElement42
			' 
			Me.radButtonElement42.AccessibleDescription = "Save"
			Me.radButtonElement42.AccessibleName = "Save"
			Me.radButtonElement42.CanFocus = True
			Me.radButtonElement42.Class = "RibbonBarButtonElement"
			Me.radButtonElement42.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement42.Image = My.Resources.msIcon3
			Me.radButtonElement42.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement42.Name = "radButtonElement42"
			Me.radButtonElement42.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement42.Text = "Save"
			Me.radButtonElement42.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement42.ZIndex = 3
			' 
			' radButtonElement60
			' 
			Me.radButtonElement60.AccessibleDescription = "Undo"
			Me.radButtonElement60.AccessibleName = "Undo"
			Me.radButtonElement60.Class = "RibbonBarButtonElement"
			Me.radButtonElement60.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement60.Image = My.Resources.undo
			Me.radButtonElement60.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement60.Name = "radButtonElement60"
			Me.radButtonElement60.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement60.Text = "Undo"
			Me.radButtonElement60.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement60.ZIndex = 2
			' 
			' radButtonElement59
			' 
			Me.radButtonElement59.AccessibleDescription = "Print"
			Me.radButtonElement59.AccessibleName = "Print"
			Me.radButtonElement59.Class = "RibbonBarButtonElement"
			Me.radButtonElement59.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement59.Image = My.Resources.print1
			Me.radButtonElement59.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement59.Name = "radButtonElement59"
			Me.radButtonElement59.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement59.Text = "Print"
			Me.radButtonElement59.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement59.ZIndex = 1
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "New"
			Me.radMenuItem1.AccessibleName = "New"
			Me.radMenuItem1.Image = My.Resources.RibbonMenuNewMagenta
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "New"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Open"
			Me.radMenuItem2.AccessibleName = "Open"
			Me.radMenuItem2.Image = My.Resources.RibbonMenuOpenMagenta
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Open"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Save As"
			Me.radMenuItem3.AccessibleName = "Save As"
			Me.radMenuItem3.Image = My.Resources.RibbonMenuSaveAsMagenta
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Save As"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.AccessibleDescription = "Save"
			Me.radMenuItem21.AccessibleName = "Save"
			Me.radMenuItem21.Image = My.Resources.save2
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "Save"
			Me.radMenuItem21.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AccessibleDescription = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.AccessibleName = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.AccessibleDescription = "Print"
			Me.radMenuItem22.AccessibleName = "Print"
			Me.radMenuItem22.Image = My.Resources.ribbon_print
			Me.radMenuItem22.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem2, Me.radMenuItem29, Me.radMenuItem30, Me.radMenuItem31})
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Text = "Print"
			Me.radMenuItem22.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem2
			' 
			Me.radMenuHeaderItem2.AccessibleDescription = "Print"
			Me.radMenuHeaderItem2.AccessibleName = "Print"
			Me.radMenuHeaderItem2.Name = "radMenuHeaderItem2"
			Me.radMenuHeaderItem2.Text = "Print"
			Me.radMenuHeaderItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem29
			' 
			Me.radMenuItem29.AccessibleDescription = "Print"
			Me.radMenuItem29.AccessibleName = "Print"
			Me.radMenuItem29.DescriptionText = "Select a printer, number of copies before printing."
			Me.radMenuItem29.Image = My.Resources.ribbon_print
			Me.radMenuItem29.Name = "radMenuItem29"
			Me.radMenuItem29.Text = "Print"
			Me.radMenuItem29.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem30
			' 
			Me.radMenuItem30.AccessibleDescription = "Quick Print"
			Me.radMenuItem30.AccessibleName = "Quick Print"
			Me.radMenuItem30.DescriptionText = "Send the document directly to the default printer without making changes."
			Me.radMenuItem30.Image = My.Resources.ribbon_pagesetup
			Me.radMenuItem30.Name = "radMenuItem30"
			Me.radMenuItem30.Text = "Quick Print"
			Me.radMenuItem30.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem31
			' 
			Me.radMenuItem31.AccessibleDescription = "Print Preview"
			Me.radMenuItem31.AccessibleName = "Print Preview"
			Me.radMenuItem31.DescriptionText = "Preview and make changes to the pages before printing."
			Me.radMenuItem31.Image = My.Resources.ribbon_print_preview
			Me.radMenuItem31.Name = "radMenuItem31"
			Me.radMenuItem31.Text = "Print Preview"
			Me.radMenuItem31.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.AccessibleDescription = "Prepare"
			Me.radMenuItem23.AccessibleName = "Prepare"
			Me.radMenuItem23.Image = My.Resources._6RibbonMenuPrepareMagenta
			Me.radMenuItem23.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem1, Me.radMenuItem32, Me.radMenuItem33, Me.radMenuItem34, Me.radMenuItem35, Me.radMenuItem36, Me.radMenuItem37})
			Me.radMenuItem23.Name = "radMenuItem23"
			Me.radMenuItem23.Text = "Prepare"
			Me.radMenuItem23.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem1
			' 
			Me.radMenuHeaderItem1.AccessibleDescription = "Prepare"
			Me.radMenuHeaderItem1.AccessibleName = "Prepare"
			Me.radMenuHeaderItem1.Name = "radMenuHeaderItem1"
			Me.radMenuHeaderItem1.Text = "Prepare"
			Me.radMenuHeaderItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem32
			' 
			Me.radMenuItem32.AccessibleDescription = "Properties"
			Me.radMenuItem32.AccessibleName = "Properties"
			Me.radMenuItem32.DescriptionText = "View and edit the document properties."
			Me.radMenuItem32.Image = My.Resources.ribbon_print
			Me.radMenuItem32.Name = "radMenuItem32"
			Me.radMenuItem32.Text = "Properties"
			Me.radMenuItem32.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem33
			' 
			Me.radMenuItem33.AccessibleDescription = "Inspect Document"
			Me.radMenuItem33.AccessibleName = "Inspect Document"
			Me.radMenuItem33.DescriptionText = "Check the document for hidden metadata  or personal information. "
			Me.radMenuItem33.Image = My.Resources.ribbon_pagesetup
			Me.radMenuItem33.Name = "radMenuItem33"
			Me.radMenuItem33.Text = "Inspect Document"
			Me.radMenuItem33.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem34
			' 
			Me.radMenuItem34.AccessibleDescription = "Encrypt Document"
			Me.radMenuItem34.AccessibleName = "Encrypt Document"
			Me.radMenuItem34.DescriptionText = "Increase the security of the document by adding encryption."
			Me.radMenuItem34.Image = My.Resources.msoffice_menu_encryptdocument
			Me.radMenuItem34.Name = "radMenuItem34"
			Me.radMenuItem34.Text = "Encrypt Document"
			Me.radMenuItem34.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem35
			' 
			Me.radMenuItem35.AccessibleDescription = "Restrict Permission"
			Me.radMenuItem35.AccessibleName = "Restrict Permission"
			Me.radMenuItem35.DescriptionText = "Grant people access  while restricting their ability to edint, copy and paste."
			Me.radMenuItem35.Image = My.Resources.msoffice_menu_restrictpermisions
			Me.radMenuItem35.Name = "radMenuItem35"
			Me.radMenuItem35.Text = "Restrict Permission"
			Me.radMenuItem35.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem36
			' 
			Me.radMenuItem36.AccessibleDescription = "Add a Digital Signature"
			Me.radMenuItem36.AccessibleName = "Add a Digital Signature"
			Me.radMenuItem36.DescriptionText = "Ensure the integrity of the document by adding invisible signature."
			Me.radMenuItem36.Image = My.Resources.msoffice_menu_digitalsignature
			Me.radMenuItem36.Name = "radMenuItem36"
			Me.radMenuItem36.Text = "Add a Digital Signature"
			Me.radMenuItem36.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem37
			' 
			Me.radMenuItem37.AccessibleDescription = "Mark as Final"
			Me.radMenuItem37.AccessibleName = "Mark as Final"
			Me.radMenuItem37.DescriptionText = "Let the readers know the document  is final and make it read-only."
			Me.radMenuItem37.Image = My.Resources.msoffice_menu_markasfinal
			Me.radMenuItem37.Name = "radMenuItem37"
			Me.radMenuItem37.Text = "Mark as Final"
			Me.radMenuItem37.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.AccessibleDescription = "Send"
			Me.radMenuItem24.AccessibleName = "Send"
			Me.radMenuItem24.Enabled = False
			Me.radMenuItem24.Image = My.Resources._7RibbonMenuSendMagenta
			Me.radMenuItem24.Name = "radMenuItem24"
			Me.radMenuItem24.Text = "Send"
			Me.radMenuItem24.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem25
			' 
			Me.radMenuItem25.AccessibleDescription = "Publish"
			Me.radMenuItem25.AccessibleName = "Publish"
			Me.radMenuItem25.Image = My.Resources._8RibbonMenuPublishMagenta
			Me.radMenuItem25.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuHeaderItem3, Me.radMenuItem38, Me.radMenuItem39, Me.radMenuItem40})
			Me.radMenuItem25.Name = "radMenuItem25"
			Me.radMenuItem25.Text = "Publish"
			Me.radMenuItem25.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuHeaderItem3
			' 
			Me.radMenuHeaderItem3.AccessibleDescription = "Publish"
			Me.radMenuHeaderItem3.AccessibleName = "Publish"
			Me.radMenuHeaderItem3.Name = "radMenuHeaderItem3"
			Me.radMenuHeaderItem3.Text = "Publish"
			Me.radMenuHeaderItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem38
			' 
			Me.radMenuItem38.AccessibleDescription = "Blog"
			Me.radMenuItem38.AccessibleName = "Blog"
			Me.radMenuItem38.DescriptionText = "Create a new blog post with content of the document."
			Me.radMenuItem38.Image = My.Resources.msoffice_menu_blog
			Me.radMenuItem38.Name = "radMenuItem38"
			Me.radMenuItem38.Text = "Blog"
			Me.radMenuItem38.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem39
			' 
			Me.radMenuItem39.AccessibleDescription = "Document Management Server"
			Me.radMenuItem39.AccessibleName = "Document Management Server"
			Me.radMenuItem39.DescriptionText = "Share the document by saving it to a document management server."
			Me.radMenuItem39.Image = My.Resources.msoffice_menu_documentserver
			Me.radMenuItem39.Name = "radMenuItem39"
			Me.radMenuItem39.Text = "Document Management Server"
			Me.radMenuItem39.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem40
			' 
			Me.radMenuItem40.AccessibleDescription = "Create Document Workspace"
			Me.radMenuItem40.AccessibleName = "Create Document Workspace"
			Me.radMenuItem40.DescriptionText = "Create a new site for the document and keep the local copy synchronized."
			Me.radMenuItem40.Image = My.Resources.msoffice_menu_documentworkspace
			Me.radMenuItem40.Name = "radMenuItem40"
			Me.radMenuItem40.Text = "Create Document Workspace"
			Me.radMenuItem40.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.AccessibleDescription = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.AccessibleName = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem26
			' 
			Me.radMenuItem26.AccessibleDescription = "Close"
			Me.radMenuItem26.AccessibleName = "Close"
			Me.radMenuItem26.Image = My.Resources._9RibbonMenuCloseMagenta
			Me.radMenuItem26.Name = "radMenuItem26"
			Me.radMenuItem26.Text = "Close"
			Me.radMenuItem26.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "Recent Documents"
			Me.radMenuItem6.AccessibleName = "Recent Documents"
			Me.radMenuItem6.Enabled = False
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Recent Documents"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "RIAServices.docx"
			Me.radMenuItem7.AccessibleName = "RIAServices.docx"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "RIAServices.docx"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "Winforms Features.docx"
			Me.radMenuItem8.AccessibleName = "Winforms Features.docx"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Winforms Features.docx"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem27
			' 
			Me.radMenuItem27.AccessibleDescription = "Winforms Backlog.docx"
			Me.radMenuItem27.AccessibleName = "Winforms Backlog.docx"
			Me.radMenuItem27.Name = "radMenuItem27"
			Me.radMenuItem27.Text = "Winforms Backlog.docx"
			Me.radMenuItem27.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem28
			' 
			Me.radMenuItem28.AccessibleDescription = "RadGridView Tasks.doxs"
			Me.radMenuItem28.AccessibleName = "RadGridView Tasks.doxs"
			Me.radMenuItem28.Name = "radMenuItem28"
			Me.radMenuItem28.Text = "RadGridView Tasks.doxs"
			Me.radMenuItem28.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radOffice2007ScreenTip1
			' 
			Me.radOffice2007ScreenTip1.CaptionVisible = True
			Me.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.FooterVisible = False
			Me.radOffice2007ScreenTip1.Location = New System.Drawing.Point(0, 0)
			Me.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip1.ScreenTipElement.TipSize = New System.Drawing.Size(210, 50)
			Me.radOffice2007ScreenTip1.Size = New System.Drawing.Size(184, 71)
			Me.radOffice2007ScreenTip1.TabIndex = 0
			Me.radOffice2007ScreenTip1.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Paste"
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Paste the contents of the clipboard"
			' 
			' radOffice2007ScreenTip2
			' 
			Me.radOffice2007ScreenTip2.CaptionVisible = True
			Me.radOffice2007ScreenTip2.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip2.FooterVisible = False
			Me.radOffice2007ScreenTip2.Location = New System.Drawing.Point(0, 0)
			Me.radOffice2007ScreenTip2.Name = "radOffice2007ScreenTip2"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip2.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip2.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip2.ScreenTipElement.TipSize = New System.Drawing.Size(210, 50)
			Me.radOffice2007ScreenTip2.Size = New System.Drawing.Size(324, 71)
			Me.radOffice2007ScreenTip2.TabIndex = 0
			Me.radOffice2007ScreenTip2.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Cut"
			CType(Me.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Cut the selection from the document and put it on the clipboard"
			' 
			' radOffice2007ScreenTip3
			' 
			Me.radOffice2007ScreenTip3.CaptionVisible = True
			Me.radOffice2007ScreenTip3.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip3.FooterVisible = False
			Me.radOffice2007ScreenTip3.Location = New System.Drawing.Point(0, 0)
			Me.radOffice2007ScreenTip3.Name = "radOffice2007ScreenTip3"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip3.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip3.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip3.ScreenTipElement.TipSize = New System.Drawing.Size(210, 50)
			Me.radOffice2007ScreenTip3.Size = New System.Drawing.Size(236, 71)
			Me.radOffice2007ScreenTip3.TabIndex = 0
			Me.radOffice2007ScreenTip3.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Copy"
			CType(Me.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Copy the selection and put it on the clipboard"
			' 
			' radOffice2007ScreenTip4
			' 
			Me.radOffice2007ScreenTip4.CaptionVisible = True
			Me.radOffice2007ScreenTip4.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip4.FooterVisible = False
			Me.radOffice2007ScreenTip4.Location = New System.Drawing.Point(0, 0)
			Me.radOffice2007ScreenTip4.Name = "radOffice2007ScreenTip4"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip4.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip4.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip4.ScreenTipElement.TipSize = New System.Drawing.Size(210, 50)
			Me.radOffice2007ScreenTip4.Size = New System.Drawing.Size(282, 71)
			Me.radOffice2007ScreenTip4.TabIndex = 0
			Me.radOffice2007ScreenTip4.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Format Painter"
			CType(Me.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Copy formatting from one place and apply it to another"
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radScrollablePanel1)
			Me.radPanel1.Controls.Add(Me.radPanel4)
			Me.radPanel1.Controls.Add(Me.radPanel3)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel1.Location = New System.Drawing.Point(0, 159)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(988, 414)
			Me.radPanel1.TabIndex = 2
			Me.radPanel1.Text = "radPanel1"
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "radPanel1"
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 0F
			' 
			' radScrollablePanel1
			' 
			Me.radScrollablePanel1.AutoScroll = True
			Me.radScrollablePanel1.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel1.Location = New System.Drawing.Point(25, 25)
			Me.radScrollablePanel1.Name = "radScrollablePanel1"
			' 
			' radScrollablePanel1.PanelContainer
			' 
			Me.radScrollablePanel1.PanelContainer.AutoScroll = True
			Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.resizingDemoPictureBox1)
			Me.radScrollablePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel1.PanelContainer.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel1.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(946, 389)
			Me.radScrollablePanel1.PanelContainer.TabIndex = 0
			Me.radScrollablePanel1.Size = New System.Drawing.Size(963, 389)
			Me.radScrollablePanel1.TabIndex = 3
			Me.radScrollablePanel1.Text = "radScrollablePanel1"
			CType(Me.radScrollablePanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 0F
			' 
			' resizingDemoPictureBox1
			' 
			Me.resizingDemoPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.resizingDemoPictureBox1.Image = My.Resources.msoffice_doc
			Me.resizingDemoPictureBox1.Location = New System.Drawing.Point(71, 13)
			Me.resizingDemoPictureBox1.Name = "resizingDemoPictureBox1"
			Me.resizingDemoPictureBox1.Size = New System.Drawing.Size(836, 887)
			Me.resizingDemoPictureBox1.TabIndex = 0
			Me.resizingDemoPictureBox1.TabStop = False
			' 
			' radPanel4
			' 
			Me.radPanel4.BackgroundImage = My.Resources.msoffice_rulers_HorizontalRuler
			Me.radPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.radPanel4.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel4.Location = New System.Drawing.Point(25, 0)
			Me.radPanel4.MaximumSize = New System.Drawing.Size(0, 25)
			Me.radPanel4.MinimumSize = New System.Drawing.Size(0, 25)
			Me.radPanel4.Name = "radPanel4"
			' 
			' 
			' 
			Me.radPanel4.RootElement.MaxSize = New System.Drawing.Size(0, 25)
			Me.radPanel4.RootElement.MinSize = New System.Drawing.Size(0, 25)
			Me.radPanel4.Size = New System.Drawing.Size(963, 25)
			Me.radPanel4.TabIndex = 2
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 0F
			' 
			' radPanel3
			' 
			Me.radPanel3.BackgroundImage = My.Resources.msoffice_rulers_VerticalRuler
			Me.radPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Left
			Me.radPanel3.Location = New System.Drawing.Point(0, 0)
			Me.radPanel3.MaximumSize = New System.Drawing.Size(25, 0)
			Me.radPanel3.MinimumSize = New System.Drawing.Size(25, 0)
			Me.radPanel3.Name = "radPanel3"
			' 
			' 
			' 
			Me.radPanel3.RootElement.MaxSize = New System.Drawing.Size(25, 0)
			Me.radPanel3.RootElement.MinSize = New System.Drawing.Size(25, 0)
			Me.radPanel3.Size = New System.Drawing.Size(25, 414)
			Me.radPanel3.TabIndex = 1
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 0F
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(988, 573)
			Me.Controls.Add(Me.radRibbonBarBackstageView1)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radRibbonBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Office"
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRibbonBarBackstageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radRibbonBarBackstageView1.ResumeLayout(False)
			Me.backstageViewPage3.ResumeLayout(False)
			Me.backstageViewPage3.PerformLayout()
			CType(Me.radSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewPage5.ResumeLayout(False)
			Me.backstageViewPage5.PerformLayout()
			Me.flowLayoutPanel1.ResumeLayout(False)
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewPage2.ResumeLayout(False)
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage1.PerformLayout()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage2.PerformLayout()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage4.ResumeLayout(False)
			Me.radPageViewPage4.PerformLayout()
			CType(Me.radButton15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage5.ResumeLayout(False)
			Me.radPageViewPage5.PerformLayout()
			CType(Me.radButton24, System.ComponentModel.ISupportInitialize).EndInit()
			Me.flowLayoutPanel2.ResumeLayout(False)
			Me.flowLayoutPanel2.PerformLayout()
			CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton22, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton23, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage6.ResumeLayout(False)
			Me.radPageViewPage6.PerformLayout()
			CType(Me.radButton25, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewPage1.ResumeLayout(False)
			Me.backstageViewPage1.PerformLayout()
			CType(Me.radLabel24, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel23, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton29, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton30, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel22, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton28, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton27, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton26, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel21, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewPage4.ResumeLayout(False)
			Me.backstageViewPage4.PerformLayout()
			CType(Me.radSeparator19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.recentPlacesListControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.recentDocumentsListControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel26, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel25, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewPage6.ResumeLayout(False)
			Me.backstageViewPage6.PerformLayout()
			CType(Me.radSeparator5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListElement1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListElement2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel1.ResumeLayout(False)
			Me.radScrollablePanel1.PerformLayout()
			CType(Me.resizingDemoPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
		Private WithEvents radRibbonBarBackstageView1 As Telerik.WinControls.UI.RadRibbonBarBackstageView
		Private backstageButtonItem1 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageButtonItem2 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageButtonItem3 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageButtonItem4 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageTabItem1 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageTabItem2 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageTabItem3 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageTabItem4 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageTabItem5 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageTabItem6 As Telerik.WinControls.UI.BackstageTabItem
		Private backstageButtonItem5 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageButtonItem6 As Telerik.WinControls.UI.BackstageButtonItem
		Private backstageViewPage1 As Telerik.WinControls.UI.BackstageViewPage
		Private backstageViewPage2 As Telerik.WinControls.UI.BackstageViewPage
		Private backstageViewPage3 As Telerik.WinControls.UI.BackstageViewPage
		Private backstageViewPage4 As Telerik.WinControls.UI.BackstageViewPage
		Private backstageViewPage5 As Telerik.WinControls.UI.BackstageViewPage
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewItemPage1 As Telerik.WinControls.UI.RadPageViewItemPage
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewItemPage2 As Telerik.WinControls.UI.RadPageViewItemPage
		Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage6 As Telerik.WinControls.UI.RadPageViewPage
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
		Private radSeparator2 As Telerik.WinControls.UI.RadSeparator
		Private backstageViewPage6 As Telerik.WinControls.UI.BackstageViewPage
		Private flowLayoutPanel1 As MyFlowLayoutPanel
		Private radButton4 As Telerik.WinControls.UI.RadButton
		Private radButton5 As Telerik.WinControls.UI.RadButton
		Private radButton6 As Telerik.WinControls.UI.RadButton
		Private radButton7 As Telerik.WinControls.UI.RadButton
		Private radButton8 As Telerik.WinControls.UI.RadButton
		Private radButton9 As Telerik.WinControls.UI.RadButton
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radSeparator3 As Telerik.WinControls.UI.RadSeparator
		Private radButton10 As Telerik.WinControls.UI.RadButton
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radSeparator4 As Telerik.WinControls.UI.RadSeparator
		Private radSeparator5 As Telerik.WinControls.UI.RadSeparator
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private radSeparator6 As Telerik.WinControls.UI.RadSeparator
		Private radButton11 As Telerik.WinControls.UI.RadButton
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private radSeparator7 As Telerik.WinControls.UI.RadSeparator
		Private radButton12 As Telerik.WinControls.UI.RadButton
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private radButton13 As Telerik.WinControls.UI.RadButton
		Private radSeparator8 As Telerik.WinControls.UI.RadSeparator
		Private radButton14 As Telerik.WinControls.UI.RadButton
		Private radSeparator9 As Telerik.WinControls.UI.RadSeparator
		Private radLabel12 As Telerik.WinControls.UI.RadLabel
		Private radLabel13 As Telerik.WinControls.UI.RadLabel
		Private radLabel14 As Telerik.WinControls.UI.RadLabel
		Private radSeparator10 As Telerik.WinControls.UI.RadSeparator
		Private radLabel15 As Telerik.WinControls.UI.RadLabel
		Private radButton15 As Telerik.WinControls.UI.RadButton
		Private radSeparator11 As Telerik.WinControls.UI.RadSeparator
		Private radLabel16 As Telerik.WinControls.UI.RadLabel
		Private WithEvents flowLayoutPanel2 As MyFlowLayoutPanel
		Private radLabel17 As Telerik.WinControls.UI.RadLabel
		Private radButton16 As Telerik.WinControls.UI.RadButton
		Private radButton17 As Telerik.WinControls.UI.RadButton
		Private radButton18 As Telerik.WinControls.UI.RadButton
		Private radButton19 As Telerik.WinControls.UI.RadButton
		Private radLabel18 As Telerik.WinControls.UI.RadLabel
		Private radButton20 As Telerik.WinControls.UI.RadButton
		Private radButton21 As Telerik.WinControls.UI.RadButton
		Private radButton22 As Telerik.WinControls.UI.RadButton
		Private radButton23 As Telerik.WinControls.UI.RadButton
		Private radButton24 As Telerik.WinControls.UI.RadButton
		Private radButton25 As Telerik.WinControls.UI.RadButton
		Private radLabel19 As Telerik.WinControls.UI.RadLabel
		Private radSeparator12 As Telerik.WinControls.UI.RadSeparator
		Private radLabel20 As Telerik.WinControls.UI.RadLabel
		Private radSeparator13 As Telerik.WinControls.UI.RadSeparator
		Private radLabel21 As Telerik.WinControls.UI.RadLabel
		Private radButton26 As Telerik.WinControls.UI.RadButton
		Private radButton27 As Telerik.WinControls.UI.RadButton
		Private radButton28 As Telerik.WinControls.UI.RadButton
		Private radSeparator15 As Telerik.WinControls.UI.RadSeparator
		Private radLabel22 As Telerik.WinControls.UI.RadLabel
		Private radSeparator14 As Telerik.WinControls.UI.RadSeparator
		Private radButton29 As Telerik.WinControls.UI.RadButton
		Private radButton30 As Telerik.WinControls.UI.RadButton
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private radSeparator16 As Telerik.WinControls.UI.RadSeparator
		Private radLabel23 As Telerik.WinControls.UI.RadLabel
		Private radLabel24 As Telerik.WinControls.UI.RadLabel
		Private radSeparator17 As Telerik.WinControls.UI.RadSeparator
		Private radLabel25 As Telerik.WinControls.UI.RadLabel
		Private radSeparator18 As Telerik.WinControls.UI.RadSeparator
		Private radLabel26 As Telerik.WinControls.UI.RadLabel
		Private recentDocumentsListControl As Telerik.WinControls.UI.RadListControl
		Private recentPlacesListControl As Telerik.WinControls.UI.RadListControl
		Private radSeparator19 As Telerik.WinControls.UI.RadSeparator
		'Copied
		Private radRibbonBarChunk2 As RadRibbonBarGroup
		Private imageList1 As System.Windows.Forms.ImageList
		Private radMenuItem1 As RadMenuItem
		Private radMenuItem2 As RadMenuItem
		Private radMenuItem3 As RadMenuItem
		Private radComboBoxItem1 As RadListDataItem
		Private radComboBoxItem2 As RadListDataItem
		Private radComboBoxItem3 As RadListDataItem
		Private radMenuItem6 As RadMenuItem
		Private radMenuItem7 As RadMenuItem
		Private radMenuItem8 As RadMenuItem
		Private radRibbonBarChunk5 As RadRibbonBarGroup
		Private radButtonElement29 As RadButtonElement
		Private radButtonElement5 As RadButtonElement
		Private radButtonElement30 As RadButtonElement
		Private radRibbonBarChunk6 As RadRibbonBarGroup
		Private radRibbonBarChunk7 As RadRibbonBarGroup
		Private radButtonElement36 As RadButtonElement
		Private radRibbonBarChunk8 As RadRibbonBarGroup
		Private radButtonElement37 As RadButtonElement
		Private radButtonElement38 As RadButtonElement
		Private radButtonElement39 As RadButtonElement
		Private radButtonElement40 As RadButtonElement
		Private radButtonElement41 As RadButtonElement
		Private radButtonElement42 As RadButtonElement
		Private radOffice2007ScreenTip1 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip2 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip3 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip4 As RadOffice2007ScreenTip
		Private radRibbonBarChunk1 As RadRibbonBarGroup
		Private radButtonElement1 As RadButtonElement
		Private radRibbonBarButtonGroup1 As RadRibbonBarButtonGroup
		Private radRibbonBarCommandTab1 As RibbonTab
		Private radRibbonBarCommandTab2 As RibbonTab
		Private radRibbonBarGroup1 As RadRibbonBarGroup
		Private radRibbonBarCommandTabHome As RibbonTab
		Private radButtonElement6 As RadButtonElement
		Private radButtonElement7 As RadButtonElement
		Private radButtonElement8 As RadButtonElement
		Private radButtonElement9 As RadButtonElement
		Private radButtonElement10 As RadButtonElement
		Private radButtonElement11 As RadButtonElement
		Private radButtonElement12 As RadButtonElement
		Private radButtonElement13 As RadButtonElement
		Private radButtonElement14 As RadButtonElement
		Private radRibbonBarGroup2 As RadRibbonBarGroup
		Private radButtonElement15 As RadButtonElement
		Private radButtonElement16 As RadButtonElement
		Private radDropDownButtonElement1 As RadDropDownButtonElement
		Private radMenuItem4 As RadMenuItem
		Private radMenuItem5 As RadMenuItem
		Private radMenuItem9 As RadMenuItem
		Private radMenuItem10 As RadMenuItem
		Private radMenuSeparatorItem1 As RadMenuSeparatorItem
		Private radMenuItem11 As RadMenuItem
		Private radMenuItem12 As RadMenuItem
		Private radRibbonBarButtonGroup2 As RadRibbonBarButtonGroup
		Private radButtonElement17 As RadButtonElement
		Private radButtonElement2 As RadButtonElement
		Private radButtonElement18 As RadButtonElement
		Private radButtonElement19 As RadButtonElement
		Private radButtonElement4 As RadButtonElement
		Private radButtonElement3 As RadButtonElement
		Private radRibbonBarGroup3 As RadRibbonBarGroup
		Private radButtonElement20 As RadButtonElement
		Private radButtonElement21 As RadButtonElement
		Private radRibbonBarGroup4 As RadRibbonBarGroup
		Private radDropDownButtonElement2 As RadDropDownButtonElement
		Private radMenuItem13 As RadMenuItem
		Private radMenuItem14 As RadMenuItem
		Private radMenuItem15 As RadMenuItem
		Private radRibbonBarButtonGroup3 As RadRibbonBarButtonGroup
		Private radButtonElement22 As RadButtonElement
		Private radButtonElement23 As RadButtonElement
		Private radButtonElement24 As RadButtonElement
		Private radRibbonBarGroup5 As RadRibbonBarGroup
		Private radRibbonBarButtonGroup4 As RadRibbonBarButtonGroup
		Private radRibbonBarGroup6 As RadRibbonBarGroup
		Private radRibbonBarGroup7 As RadRibbonBarGroup
		Private radDropDownListElement1 As RadDropDownListElement
		Private radDropDownListElement2 As RadDropDownListElement
		Private radComboBoxItem4 As RadListDataItem
		Private radComboBoxItem5 As RadListDataItem
		Private radComboBoxItem6 As RadListDataItem
		Private radComboBoxItem7 As RadListDataItem
		Private radComboBoxItem8 As RadListDataItem
		Private radComboBoxItem9 As RadListDataItem
		Private radComboBoxItem10 As RadListDataItem
		Private radComboBoxItem11 As RadListDataItem
		Private radButtonElement25 As RadButtonElement
		Private radButtonElement26 As RadButtonElement
		Private radRibbonBarButtonGroup5 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup6 As RadRibbonBarButtonGroup
		Private radButtonElement27 As RadButtonElement
		Private radRibbonBarButtonGroup7 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup8 As RadRibbonBarButtonGroup
		Private radButtonElement32 As RadButtonElement
		Private radButtonElement33 As RadButtonElement
		Private radButtonElement34 As RadButtonElement
		Private radButtonElement35 As RadButtonElement
		Public radButtonElement28 As RadButtonElement
		Public radButtonElement31 As RadButtonElement
		Private radRibbonBarButtonGroup9 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup10 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup11 As RadRibbonBarButtonGroup
		Private radButtonElement43 As RadButtonElement
		Private radButtonElement44 As RadButtonElement
		Private radButtonElement45 As RadButtonElement
		Private radButtonElement46 As RadButtonElement
		Private radButtonElement47 As RadButtonElement
		Private radRibbonBarButtonGroup12 As RadRibbonBarButtonGroup
		Private radButtonElement48 As RadButtonElement
		Private radButtonElement49 As RadButtonElement
		Private radRibbonBarButtonGroup13 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup14 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup15 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup16 As RadRibbonBarButtonGroup
		Private radRibbonBarButtonGroup17 As RadRibbonBarButtonGroup
		Private radButtonElement50 As RadButtonElement
		Private radButtonElement51 As RadButtonElement
		Private radButtonElement52 As RadButtonElement
		Private radButtonElement53 As RadButtonElement
		Private radButtonElement54 As RadButtonElement
		Private radButtonElement55 As RadButtonElement
		Private radButtonElement56 As RadButtonElement
		Private radButtonElement57 As RadButtonElement
		Private radGalleryElement1 As RadGalleryElement
		Private radGalleryItem1 As RadGalleryItem
		Private radGalleryItem2 As RadGalleryItem
		Private radGalleryItem3 As RadGalleryItem
		Private radGalleryItem4 As RadGalleryItem
		Private radGalleryItem5 As RadGalleryItem
		Private radGalleryItem6 As RadGalleryItem
		Private radRibbonBarGroup8 As RadRibbonBarGroup
		Private radDropDownButtonElement3 As RadDropDownButtonElement
		Private radButtonElement58 As RadButtonElement
		Private radDropDownButtonElement4 As RadDropDownButtonElement
		Private radMenuItem16 As RadMenuItem
		Private radMenuItem17 As RadMenuItem
		Private radMenuItem18 As RadMenuItem
		Private radMenuItem19 As RadMenuItem
		Private radMenuItem20 As RadMenuItem
		Private radButtonElement59 As RadButtonElement
		Private radButtonElement60 As RadButtonElement
		Private radMenuItem21 As RadMenuItem
		Private radMenuSeparatorItem2 As RadMenuSeparatorItem
		Private radMenuItem22 As RadMenuItem
		Private radMenuItem23 As RadMenuItem
		Private radMenuItem24 As RadMenuItem
		Private radMenuItem25 As RadMenuItem
		Private radMenuSeparatorItem3 As RadMenuSeparatorItem
		Private radMenuItem26 As RadMenuItem
		Private radMenuItem29 As RadMenuItem
		Private radMenuItem30 As RadMenuItem
		Private radMenuItem31 As RadMenuItem
		Private radMenuItem27 As RadMenuItem
		Private radMenuItem28 As RadMenuItem
		Private radMenuItem32 As RadMenuItem
		Private radMenuItem33 As RadMenuItem
		Private radMenuItem34 As RadMenuItem
		Private radMenuItem35 As RadMenuItem
		Private radMenuItem36 As RadMenuItem
		Private radMenuItem37 As RadMenuItem
		Private radMenuHeaderItem1 As RadMenuHeaderItem
		Private radMenuItem38 As RadMenuItem
		Private radMenuItem39 As RadMenuItem
		Private radMenuItem40 As RadMenuItem
		Private radMenuHeaderItem2 As RadMenuHeaderItem
		Private radMenuHeaderItem3 As RadMenuHeaderItem
		Private radPanel1 As RadPanel
		Private radPanel4 As RadPanel
		Private radPanel3 As RadPanel
		Private radScrollablePanel1 As RadScrollablePanel
		Private resizingDemoPictureBox1 As PictureBox
	End Class
End Namespace