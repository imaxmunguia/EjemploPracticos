Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI.Docking
Imports System.Drawing

Namespace Telerik.Examples.WinControls.Docking
	Friend Class ProgrammableToolWnd
		Inherits DockWindow
		Private groupBox As GroupBox
		Private WithEvents buttonUnpin As Button
		Private WithEvents buttonPin As Button
		Private WithEvents buttonFloat As Button
		Private WithEvents buttonClose As Button
		Private WithEvents buttonDock As Button

		Private actionButtons As Dictionary(Of String, Button) = New Dictionary(Of String, Button)()



		Public Sub New()
			InitializeComponent()
			'this.Activated += new EventHandler(ProgrammableToolWnd_Activated);

			actionButtons.Add("Unpin", buttonUnpin)
			actionButtons.Add("Pin", buttonPin)
			actionButtons.Add("Float", buttonFloat)
			actionButtons.Add("Close", buttonClose)
			actionButtons.Add("Dock", buttonDock)
		End Sub

		Private Sub ProgrammableToolWnd_Activated(ByVal sender As Object, ByVal e As EventArgs)
			'if (this.DockingSite != null && this.DockingSite.DockingSiteType == DockingSiteType.FloatingContainerSite)
			'{
			'    this.buttonFloat.Enabled = false;
			'    this.buttonDock.Enabled = true;
			'    this.buttonPin.Enabled = false;
			'    this.buttonUnpin.Enabled = false;
			'}
		End Sub

		Private Sub InitializeComponent()
			Me.groupBox = New System.Windows.Forms.GroupBox()
			Me.buttonClose = New System.Windows.Forms.Button()
			Me.buttonUnpin = New System.Windows.Forms.Button()
			Me.buttonPin = New System.Windows.Forms.Button()
			Me.buttonFloat = New System.Windows.Forms.Button()
			Me.buttonDock = New System.Windows.Forms.Button()
			Me.groupBox.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox
			' 
			Me.groupBox.Controls.Add(Me.buttonClose)
			Me.groupBox.Controls.Add(Me.buttonUnpin)
			Me.groupBox.Controls.Add(Me.buttonPin)
			Me.groupBox.Controls.Add(Me.buttonFloat)
			Me.groupBox.Controls.Add(Me.buttonDock)
			Me.groupBox.Location = New System.Drawing.Point(18, 16)
			Me.groupBox.Name = "groupBox"
			Me.groupBox.Size = New System.Drawing.Size(140, 170)
			Me.groupBox.TabIndex = 0
			Me.groupBox.TabStop = False
			Me.groupBox.Text = "Select an action:"
			' 
			' buttonClose
			' 
			Me.buttonClose.Location = New System.Drawing.Point(30, 141)
			Me.buttonClose.Name = "buttonClose"
			Me.buttonClose.Size = New System.Drawing.Size(75, 23)
			Me.buttonClose.TabIndex = 4
			Me.buttonClose.Text = "Close"
			Me.buttonClose.UseVisualStyleBackColor = True
'			Me.buttonClose.Click += New System.EventHandler(Me.buttonClose_Click);
			' 
			' buttonUnpin
			' 
			Me.buttonUnpin.Location = New System.Drawing.Point(30, 111)
			Me.buttonUnpin.Name = "buttonUnpin"
			Me.buttonUnpin.Size = New System.Drawing.Size(75, 23)
			Me.buttonUnpin.TabIndex = 3
			Me.buttonUnpin.Text = "Unpin"
			Me.buttonUnpin.UseVisualStyleBackColor = True
'			Me.buttonUnpin.Click += New System.EventHandler(Me.buttonUnpin_Click);
			' 
			' buttonPin
			' 
			Me.buttonPin.Enabled = False
			Me.buttonPin.Location = New System.Drawing.Point(30, 81)
			Me.buttonPin.Name = "buttonPin"
			Me.buttonPin.Size = New System.Drawing.Size(75, 23)
			Me.buttonPin.TabIndex = 2
			Me.buttonPin.Text = "Pin"
			Me.buttonPin.UseVisualStyleBackColor = True
'			Me.buttonPin.Click += New System.EventHandler(Me.buttonPin_Click);
			' 
			' buttonFloat
			' 
			Me.buttonFloat.Location = New System.Drawing.Point(30, 51)
			Me.buttonFloat.Name = "buttonFloat"
			Me.buttonFloat.Size = New System.Drawing.Size(75, 23)
			Me.buttonFloat.TabIndex = 1
			Me.buttonFloat.Text = "Float"
			Me.buttonFloat.UseVisualStyleBackColor = True
'			Me.buttonFloat.Click += New System.EventHandler(Me.buttonFloat_Click);
			' 
			' buttonDock
			' 
			Me.buttonDock.Enabled = False
			Me.buttonDock.Location = New System.Drawing.Point(30, 21)
			Me.buttonDock.Name = "buttonDock"
			Me.buttonDock.Size = New System.Drawing.Size(75, 23)
			Me.buttonDock.TabIndex = 0
			Me.buttonDock.Text = "Dock"
			Me.buttonDock.UseVisualStyleBackColor = True
'			Me.buttonDock.Click += New System.EventHandler(Me.buttonDock_Click);
			' 
			' ProgrammableToolWnd
			' 
			Me.BackColor = System.Drawing.Color.White
			Me.Controls.Add(Me.groupBox)
			Me.Location = New System.Drawing.Point(0, 26)
			Me.Name = "ProgrammableToolWnd"
			Me.Size = New System.Drawing.Size(184, 201)
			Me.groupBox.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private Sub buttonDock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDock.Click
			Me.buttonFloat.Enabled = True
			Me.buttonDock.Enabled = False
			Me.buttonUnpin.Enabled = True

			'this.DockManager.SetDock(this, lastDockPosition);
		End Sub

		Private Sub buttonFloat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFloat.Click
			Me.buttonFloat.Enabled = False
			Me.buttonDock.Enabled = True
			Me.buttonPin.Enabled = False
			Me.buttonUnpin.Enabled = False
			'lastDockPosition = this.DockPosition;

			Dim rect As New Rectangle(Control.MousePosition, Me.Size)
			'(this.DockManager as DockingManager).Float(this, rect);  

		End Sub

		Private Sub buttonPin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPin.Click
			Me.buttonPin.Enabled = False
			Me.buttonUnpin.Enabled = True

			'this.DockManager.Show(this);
		End Sub

		Private Sub buttonUnpin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonUnpin.Click
			Me.buttonPin.Enabled = True
			Me.buttonUnpin.Enabled = False
			Me.buttonFloat.Enabled = False

			'this.DockManager.Hide(this,true);
		End Sub

		Private Sub buttonClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClose.Click
			'this.DockManager.Remove(this);
		End Sub

		Default Public ReadOnly Property Item(ByVal buttonName As String) As Button
			Get
				Return actionButtons(buttonName)
			End Get
		End Property
	End Class
End Namespace
