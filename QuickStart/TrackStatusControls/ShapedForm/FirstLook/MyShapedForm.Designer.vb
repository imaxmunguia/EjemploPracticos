Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
	Partial Public Class MyShapedForm
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.ImageList = Nothing
			Me.radButton1.Location = New System.Drawing.Point(109, 219)
			Me.radButton1.Name = "radButton1"
			' 
			' radButton1.RootElement
			' 
			Me.radButton1.RootElement.AccessibleDescription = ""
			Me.radButton1.RootElement.ToolTipText = Nothing
			Me.radButton1.Size = New System.Drawing.Size(75, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Close"
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' MyShapedForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 271)
			Me.Controls.Add(Me.radButton1)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.Name = "MyShapedForm"
			Me.Text = "MyShapedForm"
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace