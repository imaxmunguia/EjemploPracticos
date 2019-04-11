Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.Globalization
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
			Me.radComboCultureList = New Telerik.WinControls.UI.RadDropDownList()
			Me.lbRenderingDirection = New Telerik.WinControls.UI.RadLabel()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.lbTitleFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboCultureList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 18, 0, 0, 0, 0)
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
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.Size = New System.Drawing.Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radComboCultureList
			' 
			Me.radComboCultureList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.radComboCultureList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboCultureList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboCultureList.Location = New System.Drawing.Point(24, 55)
			Me.radComboCultureList.MaxDropDownItems = 6
			Me.radComboCultureList.Name = "radComboCultureList"
			' 
			' 
			' 
			Me.radComboCultureList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboCultureList.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboCultureList.Size = New System.Drawing.Size(132, 20)
			Me.radComboCultureList.TabIndex = 1
			Me.radComboCultureList.TabStop = False
'			Me.radComboCultureList.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboCultureList_SelectedIndexChanged);
			' 
			' lbRenderingDirection
			' 
			Me.lbRenderingDirection.AutoSize = False
			Me.lbRenderingDirection.BackColor = System.Drawing.Color.Transparent
			Me.lbRenderingDirection.ForeColor = System.Drawing.Color.Black
			Me.lbRenderingDirection.Location = New System.Drawing.Point(24, 89)
			Me.lbRenderingDirection.Name = "lbRenderingDirection"
			' 
			' 
			' 
			Me.lbRenderingDirection.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lbRenderingDirection.Size = New System.Drawing.Size(132, 36)
			Me.lbRenderingDirection.TabIndex = 4
			Me.lbRenderingDirection.Text = "Type text to set the " & Constants.vbCrLf & " navigation bar: "
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButton1.Location = New System.Drawing.Point(24, 161)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(132, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Change Texts"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radTextBox1
			' 
			Me.radTextBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radTextBox1.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Location = New System.Drawing.Point(24, 128)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBox1.Size = New System.Drawing.Size(132, 20)
			Me.radTextBox1.TabIndex = 7
			Me.radTextBox1.TabStop = False
			' 
			' lbTitleFormat
			' 
			Me.lbTitleFormat.BackColor = System.Drawing.Color.Transparent
			Me.lbTitleFormat.ForeColor = System.Drawing.Color.Black
			Me.lbTitleFormat.Location = New System.Drawing.Point(24, 28)
			Me.lbTitleFormat.Name = "lbTitleFormat"
			' 
			' 
			' 
			Me.lbTitleFormat.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lbTitleFormat.Size = New System.Drawing.Size(85, 16)
			Me.lbTitleFormat.TabIndex = 6
			Me.lbTitleFormat.Text = "Choose culture:"
			Me.lbTitleFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButton1)
			Me.radGroupBox1.Controls.Add(Me.lbTitleFormat)
			Me.radGroupBox1.Controls.Add(Me.radTextBox1)
			Me.radGroupBox1.Controls.Add(Me.lbRenderingDirection)
			Me.radGroupBox1.Controls.Add(Me.radComboCultureList)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Globalization Options"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 197)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Globalization Options"
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
			CType(Me.radComboCultureList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radComboCultureList As Telerik.WinControls.UI.RadDropDownList
		Private lbRenderingDirection As Telerik.WinControls.UI.RadLabel
		Private lbTitleFormat As Telerik.WinControls.UI.RadLabel
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace