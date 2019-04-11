Namespace Telerik.Examples.WinControls.RadWizard.Modes
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
            Me.radWizard1 = New Telerik.WinControls.UI.RadWizard()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.radLabelAddDevice = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBoxEnableAeroStyle = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButtonAeroMode = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton97Mode = New Telerik.WinControls.UI.RadRadioButton()
            Me.radLabelMode = New Telerik.WinControls.UI.RadLabel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.pictureBoxDevice = New System.Windows.Forms.PictureBox()
            Me.radWaitingBarSearch = New Telerik.WinControls.UI.RadWaitingBar()
            Me.radLabelDevice = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelDisplayDevice = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelSelectDevice = New Telerik.WinControls.UI.RadLabel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.radProgressBarInstallation = New Telerik.WinControls.UI.RadProgressBar()
            Me.radLabelInstallation = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelDriver = New Telerik.WinControls.UI.RadLabel()
            Me.radRadioButtonDisc = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonAutomatically = New Telerik.WinControls.UI.RadRadioButton()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.radLabelCompleted = New Telerik.WinControls.UI.RadLabel()
            Me.wizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
            Me.wizardPage1 = New Telerik.WinControls.UI.WizardPage()
            Me.wizardPage2 = New Telerik.WinControls.UI.WizardPage()
            Me.wizardPage3 = New Telerik.WinControls.UI.WizardPage()
            CType(Me.radWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radWizard1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.radLabelAddDevice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxEnableAeroStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonAeroMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton97Mode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.pictureBoxDevice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWaitingBarSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelDevice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelDisplayDevice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSelectDevice, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            CType(Me.radProgressBarInstallation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelInstallation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelDriver, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonDisc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonAutomatically, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.radLabelCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radWizard1
            '
            Me.radWizard1.CompletionPage = Nothing
            Me.radWizard1.Controls.Add(Me.panel1)
            Me.radWizard1.Controls.Add(Me.panel2)
            Me.radWizard1.Controls.Add(Me.panel4)
            Me.radWizard1.Controls.Add(Me.panel3)
            Me.radWizard1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radWizard1.Location = New System.Drawing.Point(0, 0)
            Me.radWizard1.Mode = Telerik.WinControls.UI.WizardMode.Wizard97
            Me.radWizard1.Name = "radWizard1"
            Me.radWizard1.PageHeaderIcon = Global.My.Resources.Resources.USB_Drive
            Me.radWizard1.Pages.Add(Me.wizardWelcomePage1)
            Me.radWizard1.Pages.Add(Me.wizardPage1)
            Me.radWizard1.Pages.Add(Me.wizardPage2)
            Me.radWizard1.Pages.Add(Me.wizardPage3)
            Me.radWizard1.Size = New System.Drawing.Size(538, 327)
            Me.radWizard1.TabIndex = 0
            Me.radWizard1.Text = "radWizard1"
            Me.radWizard1.WelcomePage = Me.wizardWelcomePage1
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.radLabelAddDevice)
            Me.panel1.Controls.Add(Me.radCheckBoxEnableAeroStyle)
            Me.panel1.Controls.Add(Me.radRadioButtonAeroMode)
            Me.panel1.Controls.Add(Me.radRadioButton97Mode)
            Me.panel1.Controls.Add(Me.radLabelMode)
            Me.panel1.Location = New System.Drawing.Point(150, 56)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(390, 226)
            Me.panel1.TabIndex = 0
            '
            'radLabelAddDevice
            '
            Me.radLabelAddDevice.Location = New System.Drawing.Point(38, 192)
            Me.radLabelAddDevice.Name = "radLabelAddDevice"
            Me.radLabelAddDevice.Size = New System.Drawing.Size(138, 16)
            Me.radLabelAddDevice.TabIndex = 8
            Me.radLabelAddDevice.Text = "Click next to add a device."
            '
            'radCheckBoxEnableAeroStyle
            '
            Me.radCheckBoxEnableAeroStyle.Enabled = False
            Me.radCheckBoxEnableAeroStyle.Location = New System.Drawing.Point(112, 75)
            Me.radCheckBoxEnableAeroStyle.Name = "radCheckBoxEnableAeroStyle"
            Me.radCheckBoxEnableAeroStyle.Size = New System.Drawing.Size(101, 18)
            Me.radCheckBoxEnableAeroStyle.TabIndex = 10
            Me.radCheckBoxEnableAeroStyle.Text = "EnableAeroStyle"
            Me.radCheckBoxEnableAeroStyle.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radRadioButtonAeroMode
            '
            Me.radRadioButtonAeroMode.Location = New System.Drawing.Point(38, 75)
            Me.radRadioButtonAeroMode.Name = "radRadioButtonAeroMode"
            Me.radRadioButtonAeroMode.Size = New System.Drawing.Size(68, 18)
            Me.radRadioButtonAeroMode.TabIndex = 9
            Me.radRadioButtonAeroMode.Text = "Aero"
            '
            'radRadioButton97Mode
            '
            Me.radRadioButton97Mode.Location = New System.Drawing.Point(38, 51)
            Me.radRadioButton97Mode.Name = "radRadioButton97Mode"
            Me.radRadioButton97Mode.Size = New System.Drawing.Size(68, 18)
            Me.radRadioButton97Mode.TabIndex = 8
            Me.radRadioButton97Mode.Text = "Wizard97"
            Me.radRadioButton97Mode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radLabelMode
            '
            Me.radLabelMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radLabelMode.Location = New System.Drawing.Point(38, 18)
            Me.radLabelMode.Name = "radLabelMode"
            Me.radLabelMode.Size = New System.Drawing.Size(97, 16)
            Me.radLabelMode.TabIndex = 7
            Me.radLabelMode.Text = "RadWizard mode"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.pictureBoxDevice)
            Me.panel2.Controls.Add(Me.radWaitingBarSearch)
            Me.panel2.Controls.Add(Me.radLabelDevice)
            Me.panel2.Controls.Add(Me.radLabelDisplayDevice)
            Me.panel2.Controls.Add(Me.radLabelSelectDevice)
            Me.panel2.Location = New System.Drawing.Point(0, 56)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(538, 223)
            Me.panel2.TabIndex = 1
            '
            'pictureBoxDevice
            '
            Me.pictureBoxDevice.Image = Global.My.Resources.Resources.Digital_Camera
            Me.pictureBoxDevice.Location = New System.Drawing.Point(38, 108)
            Me.pictureBoxDevice.Name = "pictureBoxDevice"
            Me.pictureBoxDevice.Size = New System.Drawing.Size(72, 72)
            Me.pictureBoxDevice.TabIndex = 12
            Me.pictureBoxDevice.TabStop = False
            Me.pictureBoxDevice.Visible = False
            '
            'radWaitingBarSearch
            '
            Me.radWaitingBarSearch.Location = New System.Drawing.Point(38, 108)
            Me.radWaitingBarSearch.Name = "radWaitingBarSearch"
            Me.radWaitingBarSearch.Size = New System.Drawing.Size(478, 17)
            Me.radWaitingBarSearch.TabIndex = 11
            Me.radWaitingBarSearch.Text = "radWaitingBar1"
            Me.radWaitingBarSearch.WaitingSpeed = 100
            Me.radWaitingBarSearch.WaitingStep = 3
            '
            'radLabelDevice
            '
            Me.radLabelDevice.Location = New System.Drawing.Point(38, 82)
            Me.radLabelDevice.Name = "radLabelDevice"
            Me.radLabelDevice.Size = New System.Drawing.Size(124, 16)
            Me.radLabelDevice.TabIndex = 10
            Me.radLabelDevice.Text = "Searching for devices..."
            '
            'radLabelDisplayDevice
            '
            Me.radLabelDisplayDevice.Location = New System.Drawing.Point(38, 40)
            Me.radLabelDisplayDevice.Name = "radLabelDisplayDevice"
            Me.radLabelDisplayDevice.Size = New System.Drawing.Size(352, 16)
            Me.radLabelDisplayDevice.TabIndex = 9
            Me.radLabelDisplayDevice.Text = "Windows will continue to look for new devices and display them here."
            '
            'radLabelSelectDevice
            '
            Me.radLabelSelectDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radLabelSelectDevice.ForeColor = System.Drawing.Color.Black
            Me.radLabelSelectDevice.Location = New System.Drawing.Point(38, 18)
            Me.radLabelSelectDevice.Name = "radLabelSelectDevice"
            '
            '
            '
            Me.radLabelSelectDevice.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radLabelSelectDevice.Size = New System.Drawing.Size(209, 16)
            Me.radLabelSelectDevice.TabIndex = 8
            Me.radLabelSelectDevice.Text = "Select a device to add to this computer"
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.White
            Me.panel4.Controls.Add(Me.radProgressBarInstallation)
            Me.panel4.Controls.Add(Me.radLabelInstallation)
            Me.panel4.Controls.Add(Me.radLabelDriver)
            Me.panel4.Controls.Add(Me.radRadioButtonDisc)
            Me.panel4.Controls.Add(Me.radRadioButtonAutomatically)
            Me.panel4.Location = New System.Drawing.Point(0, 56)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(540, 226)
            Me.panel4.TabIndex = 3
            '
            'radProgressBarInstallation
            '
            Me.radProgressBarInstallation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radProgressBarInstallation.ImageIndex = -1
            Me.radProgressBarInstallation.ImageKey = ""
            Me.radProgressBarInstallation.Location = New System.Drawing.Point(38, 139)
            Me.radProgressBarInstallation.Name = "radProgressBarInstallation"
            Me.radProgressBarInstallation.SeparatorColor1 = System.Drawing.Color.White
            Me.radProgressBarInstallation.SeparatorColor2 = System.Drawing.Color.White
            Me.radProgressBarInstallation.SeparatorColor3 = System.Drawing.Color.White
            Me.radProgressBarInstallation.SeparatorColor4 = System.Drawing.Color.White
            Me.radProgressBarInstallation.Size = New System.Drawing.Size(478, 17)
            Me.radProgressBarInstallation.TabIndex = 14
            Me.radProgressBarInstallation.Visible = False
            '
            'radLabelInstallation
            '
            Me.radLabelInstallation.Location = New System.Drawing.Point(38, 117)
            Me.radLabelInstallation.Name = "radLabelInstallation"
            Me.radLabelInstallation.Size = New System.Drawing.Size(129, 16)
            Me.radLabelInstallation.TabIndex = 13
            Me.radLabelInstallation.Text = "Installation in progress..."
            Me.radLabelInstallation.Visible = False
            '
            'radLabelDriver
            '
            Me.radLabelDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radLabelDriver.Location = New System.Drawing.Point(38, 18)
            Me.radLabelDriver.Name = "radLabelDriver"
            Me.radLabelDriver.Size = New System.Drawing.Size(252, 16)
            Me.radLabelDriver.TabIndex = 12
            Me.radLabelDriver.Text = "How do you want to search for driver software?"
            '
            'radRadioButtonDisc
            '
            Me.radRadioButtonDisc.Location = New System.Drawing.Point(38, 78)
            Me.radRadioButtonDisc.Name = "radRadioButtonDisc"
            Me.radRadioButtonDisc.Size = New System.Drawing.Size(68, 18)
            Me.radRadioButtonDisc.TabIndex = 11
            Me.radRadioButtonDisc.Text = "Use disk"
            '
            'radRadioButtonAutomatically
            '
            Me.radRadioButtonAutomatically.Location = New System.Drawing.Point(38, 54)
            Me.radRadioButtonAutomatically.Name = "radRadioButtonAutomatically"
            Me.radRadioButtonAutomatically.Size = New System.Drawing.Size(268, 18)
            Me.radRadioButtonAutomatically.TabIndex = 10
            Me.radRadioButtonAutomatically.Text = "Search automatically for updated driver software"
            Me.radRadioButtonAutomatically.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.White
            Me.panel3.Controls.Add(Me.radLabelCompleted)
            Me.panel3.Location = New System.Drawing.Point(0, 56)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(540, 226)
            Me.panel3.TabIndex = 4
            '
            'radLabelCompleted
            '
            Me.radLabelCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radLabelCompleted.Location = New System.Drawing.Point(38, 18)
            Me.radLabelCompleted.Name = "radLabelCompleted"
            Me.radLabelCompleted.Size = New System.Drawing.Size(345, 16)
            Me.radLabelCompleted.TabIndex = 13
            Me.radLabelCompleted.Text = "You have completed the installation of your camera successfully."
            '
            'wizardWelcomePage1
            '
            Me.wizardWelcomePage1.ContentArea = Me.panel1
            Me.wizardWelcomePage1.CustomizePageHeader = True
            Me.wizardWelcomePage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.wizardWelcomePage1.Name = "wizardWelcomePage1"
            Me.wizardWelcomePage1.Title = "Installation wizard"
            Me.wizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'wizardPage1
            '
            Me.wizardPage1.ContentArea = Me.panel2
            Me.wizardPage1.CustomizePageHeader = True
            Me.wizardPage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.wizardPage1.Name = "wizardPage1"
            Me.wizardPage1.Title = "Add a device"
            Me.wizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'wizardPage2
            '
            Me.wizardPage2.ContentArea = Me.panel4
            Me.wizardPage2.CustomizePageHeader = True
            Me.wizardPage2.HeaderVisibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.wizardPage2.Name = "wizardPage2"
            Me.wizardPage2.Title = "Update driver software"
            Me.wizardPage2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'wizardPage3
            '
            Me.wizardPage3.ContentArea = Me.panel3
            Me.wizardPage3.CustomizePageHeader = True
            Me.wizardPage3.HeaderVisibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.wizardPage3.Name = "wizardPage3"
            Me.wizardPage3.Title = "Installation completed"
            Me.wizardPage3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(538, 327)
            Me.Controls.Add(Me.radWizard1)
            Me.Name = "Form1"
            Me.Text = "RadWizard"
            CType(Me.radWizard1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radWizard1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.radLabelAddDevice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxEnableAeroStyle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonAeroMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton97Mode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.pictureBoxDevice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radWaitingBarSearch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelDevice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelDisplayDevice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSelectDevice, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            CType(Me.radProgressBarInstallation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelInstallation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelDriver, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonDisc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonAutomatically, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.radLabelCompleted, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radWizard1 As Telerik.WinControls.UI.RadWizard
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private wizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
		Private wizardPage1 As Telerik.WinControls.UI.WizardPage
		Private radCheckBoxEnableAeroStyle As Telerik.WinControls.UI.RadCheckBox
		Private radRadioButtonAeroMode As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton97Mode As Telerik.WinControls.UI.RadRadioButton
		Private radLabelMode As Telerik.WinControls.UI.RadLabel
		Private radLabelAddDevice As Telerik.WinControls.UI.RadLabel
		Private radLabelDisplayDevice As Telerik.WinControls.UI.RadLabel
		Private radLabelSelectDevice As Telerik.WinControls.UI.RadLabel
		Private radLabelDevice As Telerik.WinControls.UI.RadLabel
		Private radWaitingBarSearch As Telerik.WinControls.UI.RadWaitingBar
		Private pictureBoxDevice As System.Windows.Forms.PictureBox
		Private panel4 As System.Windows.Forms.Panel
		Private wizardPage2 As Telerik.WinControls.UI.WizardPage
		Private radLabelDriver As Telerik.WinControls.UI.RadLabel
		Private radRadioButtonDisc As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonAutomatically As Telerik.WinControls.UI.RadRadioButton
		Private panel3 As System.Windows.Forms.Panel
		Private radLabelCompleted As Telerik.WinControls.UI.RadLabel
		Private wizardPage3 As Telerik.WinControls.UI.WizardPage
		Private radProgressBarInstallation As Telerik.WinControls.UI.RadProgressBar
		Private radLabelInstallation As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace