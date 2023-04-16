<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Me.picPhone = New System.Windows.Forms.PictureBox()
        Me.lblSmartHome = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblTotalSavings = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblMonthlyAverage = New System.Windows.Forms.Label()
        Me.lblSignificant = New System.Windows.Forms.Label()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPhone
        '
        Me.picPhone.BackgroundImage = Global.SmartHome.My.Resources.Resources.smarthome
        Me.picPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhone.Location = New System.Drawing.Point(-2, 0)
        Me.picPhone.Name = "picPhone"
        Me.picPhone.Size = New System.Drawing.Size(342, 284)
        Me.picPhone.TabIndex = 0
        Me.picPhone.TabStop = False
        '
        'lblSmartHome
        '
        Me.lblSmartHome.AutoSize = True
        Me.lblSmartHome.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmartHome.Location = New System.Drawing.Point(420, 56)
        Me.lblSmartHome.Name = "lblSmartHome"
        Me.lblSmartHome.Size = New System.Drawing.Size(312, 90)
        Me.lblSmartHome.TabIndex = 1
        Me.lblSmartHome.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblSmartHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(516, 185)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 33)
        Me.cboMonth.TabIndex = 2
        Me.cboMonth.Text = "Month"
        '
        'lblTotalSavings
        '
        Me.lblTotalSavings.AutoSize = True
        Me.lblTotalSavings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSavings.Location = New System.Drawing.Point(225, 307)
        Me.lblTotalSavings.Name = "lblTotalSavings"
        Me.lblTotalSavings.Size = New System.Drawing.Size(351, 19)
        Me.lblTotalSavings.TabIndex = 3
        Me.lblTotalSavings.Text = "The total savings for the month goes here"
        Me.lblTotalSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(300, 342)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(200, 40)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'lblMonthlyAverage
        '
        Me.lblMonthlyAverage.AutoSize = True
        Me.lblMonthlyAverage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAverage.Location = New System.Drawing.Point(232, 395)
        Me.lblMonthlyAverage.Name = "lblMonthlyAverage"
        Me.lblMonthlyAverage.Size = New System.Drawing.Size(337, 19)
        Me.lblMonthlyAverage.TabIndex = 5
        Me.lblMonthlyAverage.Text = "The average montly savings:  Goes Here"
        '
        'lblSignificant
        '
        Me.lblSignificant.AutoSize = True
        Me.lblSignificant.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignificant.Location = New System.Drawing.Point(219, 425)
        Me.lblSignificant.Name = "lblSignificant"
        Me.lblSignificant.Size = New System.Drawing.Size(363, 19)
        Me.lblSignificant.TabIndex = 6
        Me.lblSignificant.Text = "Month that has the most significant savings"
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.lblSignificant)
        Me.Controls.Add(Me.lblMonthlyAverage)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTotalSavings)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblSmartHome)
        Me.Controls.Add(Me.picPhone)
        Me.Name = "frmSmartHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Home Application"
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPhone As PictureBox
    Friend WithEvents lblSmartHome As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblTotalSavings As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblMonthlyAverage As Label
    Friend WithEvents lblSignificant As Label
End Class
