Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Forms.FirstLook
	Partial Public Class Form1
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
			Me.gridViewImageColumn1 = New Telerik.WinControls.UI.GridViewImageColumn()
			Me.gridViewTextBoxColumn1 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.gridViewTextBoxColumn2 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.gridViewTextBoxColumn3 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.gridViewDateTimeColumn1 = New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Me.gridViewTextBoxColumn4 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.gridViewTextBoxColumn5 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radStatusBar1 = New Telerik.WinControls.UI.RadStatusStrip()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radToolStripSeparatorItem3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radToolStripSeparatorItem4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
			Me.radToolStripSeparatorItem5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
			Me.radToolStripSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radToolStripSeparatorItem2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem26 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radPanelBar1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelBar1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			Me.radPageViewPage2.SuspendLayout()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridViewImageColumn1
			' 
			Me.gridViewImageColumn1.DataType = GetType(Byte())
			Me.gridViewImageColumn1.FieldName = "Photo"
			Me.gridViewImageColumn1.HeaderText = "Photo"
			Me.gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
			Me.gridViewImageColumn1.IsAutoGenerated = True
			Me.gridViewImageColumn1.Name = "Photo"
			Me.gridViewImageColumn1.Width = 80
			' 
			' gridViewTextBoxColumn1
			' 
			Me.gridViewTextBoxColumn1.FieldName = "LastName"
			Me.gridViewTextBoxColumn1.HeaderText = "Last Name"
			Me.gridViewTextBoxColumn1.IsAutoGenerated = True
			Me.gridViewTextBoxColumn1.Name = "LastName"
			Me.gridViewTextBoxColumn1.Width = 80
			' 
			' gridViewTextBoxColumn2
			' 
			Me.gridViewTextBoxColumn2.FieldName = "FirstName"
			Me.gridViewTextBoxColumn2.HeaderText = "First Name"
			Me.gridViewTextBoxColumn2.IsAutoGenerated = True
			Me.gridViewTextBoxColumn2.Name = "FirstName"
			Me.gridViewTextBoxColumn2.Width = 80
			' 
			' gridViewTextBoxColumn3
			' 
			Me.gridViewTextBoxColumn3.FieldName = "Title"
			Me.gridViewTextBoxColumn3.HeaderText = "Title"
			Me.gridViewTextBoxColumn3.IsAutoGenerated = True
			Me.gridViewTextBoxColumn3.Name = "Title"
			Me.gridViewTextBoxColumn3.Width = 60
			' 
			' gridViewDateTimeColumn1
			' 
			Me.gridViewDateTimeColumn1.FieldName = "HireDate"
			Me.gridViewDateTimeColumn1.HeaderText = "Hire Date"
			Me.gridViewDateTimeColumn1.IsAutoGenerated = True
			Me.gridViewDateTimeColumn1.Name = "HireDate"
			Me.gridViewDateTimeColumn1.Width = 60
			' 
			' gridViewTextBoxColumn4
			' 
			Me.gridViewTextBoxColumn4.FieldName = "City"
			Me.gridViewTextBoxColumn4.HeaderText = "City"
			Me.gridViewTextBoxColumn4.IsAutoGenerated = True
			Me.gridViewTextBoxColumn4.Name = "City"
			' 
			' gridViewTextBoxColumn5
			' 
			Me.gridViewTextBoxColumn5.FieldName = "Country"
			Me.gridViewTextBoxColumn5.HeaderText = "Country"
			Me.gridViewTextBoxColumn5.IsAutoGenerated = True
			Me.gridViewTextBoxColumn5.Name = "Country"
			Me.gridViewTextBoxColumn5.Width = 60
			' 
			' radStatusBar1
			' 
			Me.radStatusBar1.AutoSize = True
			Me.radStatusBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radToolStripSeparatorItem3, Me.radLabelElement3, Me.radToolStripSeparatorItem4, Me.radLabelElement2, Me.radProgressBarElement1, Me.radToolStripSeparatorItem5, Me.radCheckBoxElement1, Me.radToolStripSeparatorItem1, Me.radLabelElement1, Me.radToolStripSeparatorItem2})
			Me.radStatusBar1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
			Me.radStatusBar1.Location = New System.Drawing.Point(0, 429)
			Me.radStatusBar1.Margin = New System.Windows.Forms.Padding(5)
			Me.radStatusBar1.Name = "radStatusBar1"
			Me.radStatusBar1.Size = New System.Drawing.Size(676, 26)
			Me.radStatusBar1.TabIndex = 0
			Me.radStatusBar1.Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New System.Windows.Forms.Padding(2)
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New System.Drawing.Size(0, 19)
			CType(Me.radStatusBar1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.StatusBarBoxLayout).Margin = New System.Windows.Forms.Padding(0, 0, 14, 0)
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "Page 1 of 1"
			Me.radButtonElement1.AccessibleName = "Page 1 of 1"
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radStatusBar1.SetSpring(Me.radButtonElement1, False)
			Me.radButtonElement1.Text = "Page 1 of 1"
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radToolStripSeparatorItem3
			' 
			Me.radToolStripSeparatorItem3.AccessibleDescription = "radToolStripSeparatorItem3"
			Me.radToolStripSeparatorItem3.AccessibleName = "radToolStripSeparatorItem3"
			Me.radToolStripSeparatorItem3.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem3.Name = "radToolStripSeparatorItem3"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem3, False)
			Me.radToolStripSeparatorItem3.Text = "radToolStripSeparatorItem3"
			Me.radToolStripSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radLabelElement3
			' 
			Me.radLabelElement3.AccessibleDescription = "Words: 2"
			Me.radLabelElement3.AccessibleName = "Words: 2"
			Me.radLabelElement3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(165))))))
			Me.radLabelElement3.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement3.Name = "radLabelElement3"
			Me.radStatusBar1.SetSpring(Me.radLabelElement3, False)
			Me.radLabelElement3.Text = "Words: 2"
			Me.radLabelElement3.TextWrap = True
			Me.radLabelElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radToolStripSeparatorItem4
			' 
			Me.radToolStripSeparatorItem4.AccessibleDescription = "radToolStripSeparatorItem4"
			Me.radToolStripSeparatorItem4.AccessibleName = "radToolStripSeparatorItem4"
			Me.radToolStripSeparatorItem4.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem4.Name = "radToolStripSeparatorItem4"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem4, False)
			Me.radToolStripSeparatorItem4.Text = "radToolStripSeparatorItem4"
			Me.radToolStripSeparatorItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radLabelElement2
			' 
			Me.radLabelElement2.AccessibleDescription = "Saving..."
			Me.radLabelElement2.AccessibleName = "Saving..."
			Me.radLabelElement2.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement2.Name = "radLabelElement2"
			Me.radStatusBar1.SetSpring(Me.radLabelElement2, False)
			Me.radLabelElement2.Text = "Saving..."
			Me.radLabelElement2.TextWrap = True
			Me.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radProgressBarElement1
			' 
			Me.radProgressBarElement1.AutoSize = False
			Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 80, 20)
			Me.radProgressBarElement1.ClipDrawing = True
			Me.radProgressBarElement1.DefaultSize = New System.Drawing.Size(80, 16)
			Me.radProgressBarElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radProgressBarElement1.Name = "radProgressBarElement1"
			Me.radProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White
			Me.radProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White
			Me.radProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White
			Me.radProgressBarElement1.SeparatorGradientAngle = 0
			Me.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F
			Me.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F
			Me.radProgressBarElement1.SeparatorNumberOfColors = 2
			Me.radStatusBar1.SetSpring(Me.radProgressBarElement1, False)
			Me.radProgressBarElement1.StepWidth = 14
			Me.radProgressBarElement1.SweepAngle = 90
			Me.radProgressBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radToolStripSeparatorItem5
			' 
			Me.radToolStripSeparatorItem5.AccessibleDescription = "radToolStripSeparatorItem5"
			Me.radToolStripSeparatorItem5.AccessibleName = "radToolStripSeparatorItem5"
			Me.radToolStripSeparatorItem5.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem5.Name = "radToolStripSeparatorItem5"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem5, False)
			Me.radToolStripSeparatorItem5.Text = "radToolStripSeparatorItem5"
			Me.radToolStripSeparatorItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radCheckBoxElement1
			' 
			Me.radCheckBoxElement1.AccessibleDescription = "Check for errors"
			Me.radCheckBoxElement1.AccessibleName = "Check for errors"
			Me.radCheckBoxElement1.CanFocus = True
			Me.radCheckBoxElement1.Checked = False
			Me.radCheckBoxElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
			Me.radCheckBoxElement1.ShowBorder = False
			Me.radStatusBar1.SetSpring(Me.radCheckBoxElement1, False)
			Me.radCheckBoxElement1.Text = "Check for errors"
			Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radToolStripSeparatorItem1
			' 
			Me.radToolStripSeparatorItem1.AccessibleDescription = "radToolStripSeparatorItem1"
			Me.radToolStripSeparatorItem1.AccessibleName = "radToolStripSeparatorItem1"
			Me.radToolStripSeparatorItem1.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem1.Name = "radToolStripSeparatorItem1"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem1, False)
			Me.radToolStripSeparatorItem1.Text = "radToolStripSeparatorItem1"
			Me.radToolStripSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.AccessibleDescription = "English (US)"
			Me.radLabelElement1.AccessibleName = "English (US)"
			Me.radLabelElement1.Margin = New System.Windows.Forms.Padding(1)
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radStatusBar1.SetSpring(Me.radLabelElement1, False)
			Me.radLabelElement1.Text = "English (US)"
			Me.radLabelElement1.TextWrap = True
			Me.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radToolStripSeparatorItem2
			' 
			Me.radToolStripSeparatorItem2.AccessibleDescription = "radToolStripSeparatorItem2"
			Me.radToolStripSeparatorItem2.AccessibleName = "radToolStripSeparatorItem2"
			Me.radToolStripSeparatorItem2.Margin = New System.Windows.Forms.Padding(1)
			Me.radToolStripSeparatorItem2.Name = "radToolStripSeparatorItem2"
			Me.radStatusBar1.SetSpring(Me.radToolStripSeparatorItem2, False)
			Me.radToolStripSeparatorItem2.Text = "radToolStripSeparatorItem2"
			Me.radToolStripSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "50%"
			Me.radMenuItem1.AccessibleName = "50%"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "50%"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "75%"
			Me.radMenuItem2.AccessibleName = "75%"
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "75%"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "100%"
			Me.radMenuItem9.AccessibleName = "100%"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "100%"
			Me.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "200%"
			Me.radMenuItem10.AccessibleName = "200%"
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "200%"
			Me.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "radMenuItem3"
			Me.radMenuItem3.AccessibleName = "radMenuItem3"
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "radMenuItem3"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "radMenuItem4"
			Me.radMenuItem4.AccessibleName = "radMenuItem4"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "radMenuItem4"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "radMenuItem5"
			Me.radMenuItem5.AccessibleName = "radMenuItem5"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "radMenuItem5"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "radMenuItem6"
			Me.radMenuItem6.AccessibleName = "radMenuItem6"
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "radMenuItem6"
			Me.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "radMenuItem7"
			Me.radMenuItem7.AccessibleName = "radMenuItem7"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "radMenuItem8"
			Me.radMenuItem8.AccessibleName = "radMenuItem8"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.AccessibleDescription = "Change Theme"
			Me.radMenuItem21.AccessibleName = "Change Theme"
			Me.radMenuItem21.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem22, Me.radMenuItem26, Me.radMenuItem12})
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "Change Theme"
			Me.radMenuItem21.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.AccessibleDescription = "Office2007 Blue"
			Me.radMenuItem22.AccessibleName = "Office2007 Blue"
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Tag = "ControlDefault"
			Me.radMenuItem22.Text = "Office2007 Blue"
			Me.radMenuItem22.Visibility = Telerik.WinControls.ElementVisibility.Visible
'			Me.radMenuItem22.Click += New System.EventHandler(Me.OnRadMenuItemChangeTheme_Click);
			' 
			' radMenuItem26
			' 
			Me.radMenuItem26.AccessibleDescription = "Desert"
			Me.radMenuItem26.AccessibleName = "Desert"
			Me.radMenuItem26.IsChecked = True
			Me.radMenuItem26.Name = "radMenuItem26"
			Me.radMenuItem26.Tag = "Desert"
			Me.radMenuItem26.Text = "Desert"
			Me.radMenuItem26.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radMenuItem26.Visibility = Telerik.WinControls.ElementVisibility.Visible
'			Me.radMenuItem26.Click += New System.EventHandler(Me.OnRadMenuItemChangeTheme_Click);
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.AccessibleDescription = "Vista"
			Me.radMenuItem12.AccessibleName = "Vista"
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Tag = "Vista"
			Me.radMenuItem12.Text = "Vista"
			Me.radMenuItem12.Visibility = Telerik.WinControls.ElementVisibility.Visible
'			Me.radMenuItem12.Click += New System.EventHandler(Me.OnRadMenuItemChangeTheme_Click);
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.AccessibleDescription = "About"
			Me.radMenuItem13.AccessibleName = "About"
			Me.radMenuItem13.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem13.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem17})
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "About"
			Me.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.AccessibleDescription = "RadControls for WinForms"
			Me.radMenuItem17.AccessibleName = "RadControls for WinForms"
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
			Me.radMenuItem17.Text = "RadControls for WinForms"
			Me.radMenuItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem17.Visibility = Telerik.WinControls.ElementVisibility.Visible
'			Me.radMenuItem17.Click += New System.EventHandler(Me.radMenuItem17_Click);
			' 
			' radButton3
			' 
			Me.radButton3.Location = New System.Drawing.Point(2, 59)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New System.Drawing.Size(124, 23)
			Me.radButton3.TabIndex = 0
			Me.radButton3.Text = "RadButton3"
			' 
			' radButton2
			' 
			Me.radButton2.Location = New System.Drawing.Point(2, 30)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(124, 23)
			Me.radButton2.TabIndex = 0
			Me.radButton2.Text = "RadButton2"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(2, 1)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(124, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "RadButton1"
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.Location = New System.Drawing.Point(12, 30)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { Me.gridViewImageColumn1, Me.gridViewTextBoxColumn1, Me.gridViewTextBoxColumn2, Me.gridViewTextBoxColumn3, Me.gridViewDateTimeColumn1, Me.gridViewTextBoxColumn4, Me.gridViewTextBoxColumn5})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(492, 380)
			Me.radGridView1.TabIndex = 5
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' radMenu1
			' 
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = System.Drawing.Color.Transparent
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem21, Me.radMenuItem13})
			Me.radMenu1.Location = New System.Drawing.Point(0, 0)
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.Size = New System.Drawing.Size(676, 20)
			Me.radMenu1.TabIndex = 3
			Me.radMenu1.Text = "radMenu1"
			' 
			' radPanelBar1
			' 
			Me.radPanelBar1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage1)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage2)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage3)
			Me.radPanelBar1.Location = New System.Drawing.Point(515, 30)
			Me.radPanelBar1.Name = "radPanelBar1"
			Me.radPanelBar1.SelectedPage = Me.radPageViewPage3
			Me.radPanelBar1.Size = New System.Drawing.Size(148, 301)
			Me.radPanelBar1.TabIndex = 6
			Me.radPanelBar1.Text = "radPanelBar1"
			Me.radPanelBar1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radButton3)
			Me.radPageViewPage1.Controls.Add(Me.radButton2)
			Me.radPageViewPage1.Controls.Add(Me.radButton1)
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 29)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(138, 92)
			Me.radPageViewPage1.Text = "Buttons"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox3)
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox2)
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox1)
			Me.radPageViewPage2.Location = New System.Drawing.Point(5, 29)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(138, 175)
			Me.radPageViewPage2.Text = "Check Boxes"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton3)
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton2)
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton1)
			Me.radPageViewPage3.Location = New System.Drawing.Point(5, 29)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(138, 175)
			Me.radPageViewPage3.Text = "Radio Buttons"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New System.Drawing.Point(3, 3)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New System.Drawing.Size(91, 18)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "radCheckBox1"
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.Location = New System.Drawing.Point(3, 27)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New System.Drawing.Size(91, 18)
			Me.radCheckBox2.TabIndex = 1
			Me.radCheckBox2.Text = "radCheckBox2"
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.Location = New System.Drawing.Point(3, 51)
			Me.radCheckBox3.Name = "radCheckBox3"
			Me.radCheckBox3.Size = New System.Drawing.Size(91, 18)
			Me.radCheckBox3.TabIndex = 2
			Me.radCheckBox3.Text = "radCheckBox3"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Location = New System.Drawing.Point(4, 4)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "radRadioButton1"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New System.Drawing.Point(4, 29)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "radRadioButton2"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Location = New System.Drawing.Point(4, 53)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.Size = New System.Drawing.Size(110, 18)
			Me.radRadioButton3.TabIndex = 2
			Me.radRadioButton3.Text = "radRadioButton3"
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.AutoScroll = True
			Me.ClientSize = New System.Drawing.Size(676, 455)
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(Me.radMenu1)
			Me.Controls.Add(Me.radStatusBar1)
			Me.Controls.Add(Me.radPanelBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.Text = "RadForm Example"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelBar1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage2.PerformLayout()
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radStatusBar1 As Telerik.WinControls.UI.RadStatusStrip
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
		Private radToolStripSeparatorItem2 As Telerik.WinControls.UI.CommandBarSeparator
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
		Private radToolStripSeparatorItem4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private radToolStripSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radMenuItem21 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem26 As Telerik.WinControls.UI.RadMenuItem
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private WithEvents radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private gridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn
		Private gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private gridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn
		Private gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private gridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private radPanelBar1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace