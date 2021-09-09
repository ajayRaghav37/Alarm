<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snooze
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
        Me.btnSnooze5Min = New System.Windows.Forms.Button()
        Me.btnSnooze15Min = New System.Windows.Forms.Button()
        Me.btnSnooze30Min = New System.Windows.Forms.Button()
        Me.btnSnooze1Hour = New System.Windows.Forms.Button()
        Me.btnCancelAlarm = New System.Windows.Forms.Button()
        Me.btnDelAlarm = New System.Windows.Forms.Button()
        Me.lblAlarmText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSnooze5Min
        '
        Me.btnSnooze5Min.BackColor = System.Drawing.Color.Maroon
        Me.btnSnooze5Min.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze5Min.ForeColor = System.Drawing.Color.White
        Me.btnSnooze5Min.Location = New System.Drawing.Point(73, 152)
        Me.btnSnooze5Min.Name = "btnSnooze5Min"
        Me.btnSnooze5Min.Size = New System.Drawing.Size(216, 221)
        Me.btnSnooze5Min.TabIndex = 0
        Me.btnSnooze5Min.Text = "Snooze" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 min"
        Me.btnSnooze5Min.UseVisualStyleBackColor = False
        '
        'btnSnooze15Min
        '
        Me.btnSnooze15Min.BackColor = System.Drawing.Color.Green
        Me.btnSnooze15Min.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze15Min.ForeColor = System.Drawing.Color.White
        Me.btnSnooze15Min.Location = New System.Drawing.Point(354, 152)
        Me.btnSnooze15Min.Name = "btnSnooze15Min"
        Me.btnSnooze15Min.Size = New System.Drawing.Size(216, 221)
        Me.btnSnooze15Min.TabIndex = 1
        Me.btnSnooze15Min.Text = "Snooze" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15 min"
        Me.btnSnooze15Min.UseVisualStyleBackColor = False
        '
        'btnSnooze30Min
        '
        Me.btnSnooze30Min.BackColor = System.Drawing.Color.Navy
        Me.btnSnooze30Min.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze30Min.ForeColor = System.Drawing.Color.White
        Me.btnSnooze30Min.Location = New System.Drawing.Point(73, 439)
        Me.btnSnooze30Min.Name = "btnSnooze30Min"
        Me.btnSnooze30Min.Size = New System.Drawing.Size(216, 221)
        Me.btnSnooze30Min.TabIndex = 2
        Me.btnSnooze30Min.Text = "Snooze" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30 min"
        Me.btnSnooze30Min.UseVisualStyleBackColor = False
        '
        'btnSnooze1Hour
        '
        Me.btnSnooze1Hour.BackColor = System.Drawing.Color.Olive
        Me.btnSnooze1Hour.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze1Hour.ForeColor = System.Drawing.Color.White
        Me.btnSnooze1Hour.Location = New System.Drawing.Point(354, 439)
        Me.btnSnooze1Hour.Name = "btnSnooze1Hour"
        Me.btnSnooze1Hour.Size = New System.Drawing.Size(216, 221)
        Me.btnSnooze1Hour.TabIndex = 3
        Me.btnSnooze1Hour.Text = "Snooze" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 hour"
        Me.btnSnooze1Hour.UseVisualStyleBackColor = False
        '
        'btnCancelAlarm
        '
        Me.btnCancelAlarm.BackColor = System.Drawing.Color.Purple
        Me.btnCancelAlarm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAlarm.ForeColor = System.Drawing.Color.White
        Me.btnCancelAlarm.Location = New System.Drawing.Point(1089, 301)
        Me.btnCancelAlarm.Name = "btnCancelAlarm"
        Me.btnCancelAlarm.Size = New System.Drawing.Size(216, 221)
        Me.btnCancelAlarm.TabIndex = 4
        Me.btnCancelAlarm.Text = "Dismiss"
        Me.btnCancelAlarm.UseVisualStyleBackColor = False
        '
        'btnDelAlarm
        '
        Me.btnDelAlarm.BackColor = System.Drawing.Color.Teal
        Me.btnDelAlarm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAlarm.ForeColor = System.Drawing.Color.White
        Me.btnDelAlarm.Location = New System.Drawing.Point(771, 301)
        Me.btnDelAlarm.Name = "btnDelAlarm"
        Me.btnDelAlarm.Size = New System.Drawing.Size(216, 221)
        Me.btnDelAlarm.TabIndex = 5
        Me.btnDelAlarm.Text = "Delete Alarm"
        Me.btnDelAlarm.UseVisualStyleBackColor = False
        '
        'lblAlarmText
        '
        Me.lblAlarmText.AutoSize = True
        Me.lblAlarmText.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmText.ForeColor = System.Drawing.Color.White
        Me.lblAlarmText.Location = New System.Drawing.Point(70, 27)
        Me.lblAlarmText.Name = "lblAlarmText"
        Me.lblAlarmText.Size = New System.Drawing.Size(0, 86)
        Me.lblAlarmText.TabIndex = 6
        '
        'Snooze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1317, 577)
        Me.Controls.Add(Me.lblAlarmText)
        Me.Controls.Add(Me.btnDelAlarm)
        Me.Controls.Add(Me.btnCancelAlarm)
        Me.Controls.Add(Me.btnSnooze1Hour)
        Me.Controls.Add(Me.btnSnooze30Min)
        Me.Controls.Add(Me.btnSnooze15Min)
        Me.Controls.Add(Me.btnSnooze5Min)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Snooze"
        Me.Text = "Snooze"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSnooze5Min As System.Windows.Forms.Button
    Friend WithEvents btnSnooze15Min As System.Windows.Forms.Button
    Friend WithEvents btnSnooze30Min As System.Windows.Forms.Button
    Friend WithEvents btnSnooze1Hour As System.Windows.Forms.Button
    Friend WithEvents btnCancelAlarm As System.Windows.Forms.Button
    Friend WithEvents btnDelAlarm As System.Windows.Forms.Button
    Friend WithEvents lblAlarmText As System.Windows.Forms.Label
End Class
