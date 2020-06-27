<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvgUnitsShippedByEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblAverageUnitsEmp1 = New System.Windows.Forms.Label()
        Me.txtEmployee1Display = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedByEmployeeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEmployee2Display = New System.Windows.Forms.TextBox()
        Me.txtEmployee3Display = New System.Windows.Forms.TextBox()
        Me.lblAverageUnitsEmp2 = New System.Windows.Forms.Label()
        Me.lblAverageUnitsEmp3 = New System.Windows.Forms.Label()
        Me.lblCompanyAverage = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAverageUnitsEmp1
        '
        Me.lblAverageUnitsEmp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnitsEmp1.Location = New System.Drawing.Point(12, 230)
        Me.lblAverageUnitsEmp1.Name = "lblAverageUnitsEmp1"
        Me.lblAverageUnitsEmp1.Size = New System.Drawing.Size(154, 23)
        Me.lblAverageUnitsEmp1.TabIndex = 9
        Me.lblAverageUnitsEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.lblAverageUnitsEmp1, "Displays the average units shipped for employee 1 once all 7 units have been ente" &
        "red.")
        '
        'txtEmployee1Display
        '
        Me.txtEmployee1Display.Location = New System.Drawing.Point(13, 106)
        Me.txtEmployee1Display.Multiline = True
        Me.txtEmployee1Display.Name = "txtEmployee1Display"
        Me.txtEmployee1Display.ReadOnly = True
        Me.txtEmployee1Display.Size = New System.Drawing.Size(154, 121)
        Me.txtEmployee1Display.TabIndex = 6
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.txtEmployee1Display, "Displays the units shipped for each day for employee 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(12, 9)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(80, 23)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Day 1"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(54, 33)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(56, 20)
        Me.txtInput.TabIndex = 2
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.txtInput, "Type the units shipped for each day")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(12, 36)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(64, 21)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(332, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.btnExit, "Closes the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(175, 308)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.btnReset, "Clears all text boxes and the output label's text.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 308)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(154, 28)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.btnEnter, "Enters the units shipped into the ")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtEmployee2Display
        '
        Me.txtEmployee2Display.Location = New System.Drawing.Point(175, 106)
        Me.txtEmployee2Display.Multiline = True
        Me.txtEmployee2Display.Name = "txtEmployee2Display"
        Me.txtEmployee2Display.ReadOnly = True
        Me.txtEmployee2Display.Size = New System.Drawing.Size(151, 121)
        Me.txtEmployee2Display.TabIndex = 7
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.txtEmployee2Display, "Displays the units shipped for each day for employee 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtEmployee3Display
        '
        Me.txtEmployee3Display.Location = New System.Drawing.Point(332, 106)
        Me.txtEmployee3Display.Multiline = True
        Me.txtEmployee3Display.Name = "txtEmployee3Display"
        Me.txtEmployee3Display.ReadOnly = True
        Me.txtEmployee3Display.Size = New System.Drawing.Size(153, 121)
        Me.txtEmployee3Display.TabIndex = 8
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.txtEmployee3Display, "Displays the units shipped for each day for employee 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblAverageUnitsEmp2
        '
        Me.lblAverageUnitsEmp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnitsEmp2.Location = New System.Drawing.Point(175, 230)
        Me.lblAverageUnitsEmp2.Name = "lblAverageUnitsEmp2"
        Me.lblAverageUnitsEmp2.Size = New System.Drawing.Size(151, 23)
        Me.lblAverageUnitsEmp2.TabIndex = 10
        Me.lblAverageUnitsEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.lblAverageUnitsEmp2, "Displays the average units shipped for employee 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " once all 7 units have been en" &
        "tered.")
        '
        'lblAverageUnitsEmp3
        '
        Me.lblAverageUnitsEmp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnitsEmp3.Location = New System.Drawing.Point(332, 230)
        Me.lblAverageUnitsEmp3.Name = "lblAverageUnitsEmp3"
        Me.lblAverageUnitsEmp3.Size = New System.Drawing.Size(153, 23)
        Me.lblAverageUnitsEmp3.TabIndex = 11
        Me.lblAverageUnitsEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.lblAverageUnitsEmp3, "Displays the average units shipped for employee 3 once all 7 units have been ente" &
        "red.")
        '
        'lblCompanyAverage
        '
        Me.lblCompanyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompanyAverage.Location = New System.Drawing.Point(13, 266)
        Me.lblCompanyAverage.Name = "lblCompanyAverage"
        Me.lblCompanyAverage.Size = New System.Drawing.Size(470, 23)
        Me.lblCompanyAverage.TabIndex = 12
        Me.lblCompanyAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeToolTip.SetToolTip(Me.lblCompanyAverage, "Displays the average across the whole company" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(36, 80)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee2.Location = New System.Drawing.Point(198, 80)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee3.Location = New System.Drawing.Point(358, 80)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAvgUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(495, 380)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblCompanyAverage)
        Me.Controls.Add(Me.lblAverageUnitsEmp3)
        Me.Controls.Add(Me.lblAverageUnitsEmp2)
        Me.Controls.Add(Me.txtEmployee3Display)
        Me.Controls.Add(Me.txtEmployee2Display)
        Me.Controls.Add(Me.lblAverageUnitsEmp1)
        Me.Controls.Add(Me.txtEmployee1Display)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvgUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAverageUnitsEmp1 As Label
    Friend WithEvents txtEmployee1Display As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents AverageUnitsShippedByEmployeeToolTip As ToolTip
    Friend WithEvents txtEmployee2Display As TextBox
    Friend WithEvents txtEmployee3Display As TextBox
    Friend WithEvents lblAverageUnitsEmp2 As Label
    Friend WithEvents lblAverageUnitsEmp3 As Label
    Friend WithEvents lblCompanyAverage As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
