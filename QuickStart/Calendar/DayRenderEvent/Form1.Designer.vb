Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.DayRenderEvent
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.DatesList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.ColorList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupRenderOpts = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DatesList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ColorList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRenderOpts.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRenderOpts)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRenderOpts, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 13, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(364, 287)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.Size = New System.Drawing.Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
'			Me.radCalendar1.ElementRender += New Telerik.WinControls.UI.RenderElementEventHandler(Me.radCalendar1_ElementRender);
			' 
			' DatesList
			' 
			Me.DatesList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.DatesList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.DatesList.Location = New System.Drawing.Point(21, 37)
			Me.DatesList.MaxDropDownItems = 6
			Me.DatesList.Name = "DatesList"
			' 
			' 
			' 
			Me.DatesList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.DatesList.RootElement.ForeColor = System.Drawing.Color.Black
			Me.DatesList.Size = New System.Drawing.Size(139, 20)
			Me.DatesList.TabIndex = 1
			Me.DatesList.TabStop = False
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(21, 17)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(80, 16)
			Me.radLabel2.TabIndex = 6
			Me.radLabel2.Text = "Selected Date:"
			Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radLabel3
			' 
			Me.radLabel3.BackColor = System.Drawing.Color.Transparent
			Me.radLabel3.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Location = New System.Drawing.Point(21, 62)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel3.Size = New System.Drawing.Size(107, 16)
			Me.radLabel3.TabIndex = 7
			Me.radLabel3.Text = "Selected Day Color:"
			Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radLabel4
			' 
			Me.radLabel4.BackColor = System.Drawing.Color.Transparent
			Me.radLabel4.ForeColor = System.Drawing.Color.Black
			Me.radLabel4.Location = New System.Drawing.Point(21, 107)
			Me.radLabel4.Name = "radLabel4"
			' 
			' 
			' 
			Me.radLabel4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel4.Size = New System.Drawing.Size(102, 16)
			Me.radLabel4.TabIndex = 8
			Me.radLabel4.Text = "Selected Day Text:"
			Me.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' ColorList
			' 
			Me.ColorList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.ColorList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.ColorList.Location = New System.Drawing.Point(21, 82)
			Me.ColorList.MaxDropDownItems = 6
			Me.ColorList.Name = "ColorList"
			' 
			' 
			' 
			Me.ColorList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.ColorList.RootElement.ForeColor = System.Drawing.Color.Black
			Me.ColorList.Size = New System.Drawing.Size(139, 20)
			Me.ColorList.TabIndex = 7
			Me.ColorList.TabStop = False
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton1.Location = New System.Drawing.Point(21, 153)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(139, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Apply Changes"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radTextBox1
			' 
			Me.radTextBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radTextBox1.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Location = New System.Drawing.Point(21, 127)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Size = New System.Drawing.Size(139, 20)
			Me.radTextBox1.TabIndex = 7
			Me.radTextBox1.TabStop = False
			Me.radTextBox1.Text = "MyDay"
			' 
			' radGroupRenderOpts
			' 
			Me.radGroupRenderOpts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel2)
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel3)
			Me.radGroupRenderOpts.Controls.Add(Me.DatesList)
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel4)
			Me.radGroupRenderOpts.Controls.Add(Me.radTextBox1)
			Me.radGroupRenderOpts.Controls.Add(Me.ColorList)
			Me.radGroupRenderOpts.Controls.Add(Me.radButton1)
			Me.radGroupRenderOpts.FooterImageIndex = -1
			Me.radGroupRenderOpts.FooterImageKey = ""
			Me.radGroupRenderOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderOpts.HeaderImageIndex = -1
			Me.radGroupRenderOpts.HeaderImageKey = ""
			Me.radGroupRenderOpts.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupRenderOpts.HeaderText = "Rendering Options"
			Me.radGroupRenderOpts.Location = New System.Drawing.Point(10, 6)
			Me.radGroupRenderOpts.Name = "radGroupRenderOpts"
			Me.radGroupRenderOpts.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupRenderOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderOpts.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupRenderOpts.Size = New System.Drawing.Size(180, 192)
			Me.radGroupRenderOpts.TabIndex = 1
			Me.radGroupRenderOpts.Text = "Rendering Options"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 820)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DatesList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ColorList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRenderOpts.ResumeLayout(False)
			Me.radGroupRenderOpts.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private DatesList As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private ColorList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radGroupRenderOpts As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace