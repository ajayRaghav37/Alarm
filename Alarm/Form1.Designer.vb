<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.aTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.aWavPicker = New System.Windows.Forms.TextBox()
        Me.lblJunk1 = New System.Windows.Forms.Label()
        Me.bSet = New System.Windows.Forms.Button()
        Me.rWeekdays = New System.Windows.Forms.RadioButton()
        Me.rOnce = New System.Windows.Forms.RadioButton()
        Me.pOnce = New System.Windows.Forms.Panel()
        Me.aDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.rOther = New System.Windows.Forms.RadioButton()
        Me.rTomorrow = New System.Windows.Forms.RadioButton()
        Me.rToday = New System.Windows.Forms.RadioButton()
        Me.aTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblJunk3 = New System.Windows.Forms.Label()
        Me.aText = New System.Windows.Forms.TextBox()
        Me.pOnce.SuspendLayout()
        Me.SuspendLayout()
        '
        'aTimePicker
        '
        Me.aTimePicker.Font = New System.Drawing.Font("Segoe UI Light", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.aTimePicker.Location = New System.Drawing.Point(12, 12)
        Me.aTimePicker.Name = "aTimePicker"
        Me.aTimePicker.ShowUpDown = True
        Me.aTimePicker.Size = New System.Drawing.Size(272, 96)
        Me.aTimePicker.TabIndex = 0
        '
        'aWavPicker
        '
        Me.aWavPicker.Location = New System.Drawing.Point(75, 124)
        Me.aWavPicker.Name = "aWavPicker"
        Me.aWavPicker.Size = New System.Drawing.Size(209, 20)
        Me.aWavPicker.TabIndex = 1
        Me.aWavPicker.Text = "D:\Corporate\ANIco.in\VB.NET Projects\Alarm\David Guetta - Titanium.wav"
        '
        'lblJunk1
        '
        Me.lblJunk1.AutoSize = True
        Me.lblJunk1.Location = New System.Drawing.Point(12, 127)
        Me.lblJunk1.Name = "lblJunk1"
        Me.lblJunk1.Size = New System.Drawing.Size(57, 13)
        Me.lblJunk1.TabIndex = 2
        Me.lblJunk1.Text = "Alarm tone"
        '
        'bSet
        '
        Me.bSet.Location = New System.Drawing.Point(290, 124)
        Me.bSet.Name = "bSet"
        Me.bSet.Size = New System.Drawing.Size(187, 47)
        Me.bSet.TabIndex = 7
        Me.bSet.Text = "Set (or overwrite)"
        Me.bSet.UseVisualStyleBackColor = True
        '
        'rWeekdays
        '
        Me.rWeekdays.AutoSize = True
        Me.rWeekdays.Checked = True
        Me.rWeekdays.Location = New System.Drawing.Point(290, 12)
        Me.rWeekdays.Name = "rWeekdays"
        Me.rWeekdays.Size = New System.Drawing.Size(76, 17)
        Me.rWeekdays.TabIndex = 10
        Me.rWeekdays.TabStop = True
        Me.rWeekdays.Text = "Weekdays"
        Me.rWeekdays.UseVisualStyleBackColor = True
        '
        'rOnce
        '
        Me.rOnce.AutoSize = True
        Me.rOnce.Location = New System.Drawing.Point(290, 35)
        Me.rOnce.Name = "rOnce"
        Me.rOnce.Size = New System.Drawing.Size(51, 17)
        Me.rOnce.TabIndex = 11
        Me.rOnce.Text = "Once"
        Me.rOnce.UseVisualStyleBackColor = True
        '
        'pOnce
        '
        Me.pOnce.Controls.Add(Me.aDatePicker)
        Me.pOnce.Controls.Add(Me.rOther)
        Me.pOnce.Controls.Add(Me.rTomorrow)
        Me.pOnce.Controls.Add(Me.rToday)
        Me.pOnce.Enabled = False
        Me.pOnce.Location = New System.Drawing.Point(361, 35)
        Me.pOnce.Name = "pOnce"
        Me.pOnce.Size = New System.Drawing.Size(116, 73)
        Me.pOnce.TabIndex = 12
        '
        'aDatePicker
        '
        Me.aDatePicker.Enabled = False
        Me.aDatePicker.Location = New System.Drawing.Point(27, 50)
        Me.aDatePicker.Name = "aDatePicker"
        Me.aDatePicker.Size = New System.Drawing.Size(89, 20)
        Me.aDatePicker.TabIndex = 10
        '
        'rOther
        '
        Me.rOther.AutoSize = True
        Me.rOther.Location = New System.Drawing.Point(7, 52)
        Me.rOther.Name = "rOther"
        Me.rOther.Size = New System.Drawing.Size(14, 13)
        Me.rOther.TabIndex = 9
        Me.rOther.UseVisualStyleBackColor = True
        '
        'rTomorrow
        '
        Me.rTomorrow.AutoSize = True
        Me.rTomorrow.Checked = True
        Me.rTomorrow.Location = New System.Drawing.Point(7, 27)
        Me.rTomorrow.Name = "rTomorrow"
        Me.rTomorrow.Size = New System.Drawing.Size(72, 17)
        Me.rTomorrow.TabIndex = 8
        Me.rTomorrow.TabStop = True
        Me.rTomorrow.Text = "Tomorrow"
        Me.rTomorrow.UseVisualStyleBackColor = True
        '
        'rToday
        '
        Me.rToday.AutoSize = True
        Me.rToday.Location = New System.Drawing.Point(7, 4)
        Me.rToday.Name = "rToday"
        Me.rToday.Size = New System.Drawing.Size(55, 17)
        Me.rToday.TabIndex = 7
        Me.rToday.Text = "Today"
        Me.rToday.UseVisualStyleBackColor = True
        '
        'aTimer
        '
        Me.aTimer.Enabled = True
        Me.aTimer.Interval = 1000
        '
        'lblJunk3
        '
        Me.lblJunk3.AutoSize = True
        Me.lblJunk3.Location = New System.Drawing.Point(12, 154)
        Me.lblJunk3.Name = "lblJunk3"
        Me.lblJunk3.Size = New System.Drawing.Size(53, 13)
        Me.lblJunk3.TabIndex = 14
        Me.lblJunk3.Text = "Alarm text"
        '
        'aText
        '
        Me.aText.Location = New System.Drawing.Point(75, 151)
        Me.aText.Name = "aText"
        Me.aText.Size = New System.Drawing.Size(209, 20)
        Me.aText.TabIndex = 13
        Me.aText.Text = "Good morning!!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 183)
        Me.Controls.Add(Me.lblJunk3)
        Me.Controls.Add(Me.aText)
        Me.Controls.Add(Me.pOnce)
        Me.Controls.Add(Me.rOnce)
        Me.Controls.Add(Me.rWeekdays)
        Me.Controls.Add(Me.bSet)
        Me.Controls.Add(Me.lblJunk1)
        Me.Controls.Add(Me.aWavPicker)
        Me.Controls.Add(Me.aTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "My fucking not annoying ever existed Alarm"
        Me.pOnce.ResumeLayout(False)
        Me.pOnce.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents aWavPicker As System.Windows.Forms.TextBox
    Friend WithEvents lblJunk1 As System.Windows.Forms.Label
    Friend WithEvents bSet As System.Windows.Forms.Button
    Friend WithEvents rWeekdays As System.Windows.Forms.RadioButton
    Friend WithEvents rOnce As System.Windows.Forms.RadioButton
    Friend WithEvents pOnce As System.Windows.Forms.Panel
    Friend WithEvents aDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents rOther As System.Windows.Forms.RadioButton
    Friend WithEvents rTomorrow As System.Windows.Forms.RadioButton
    Friend WithEvents rToday As System.Windows.Forms.RadioButton
    Friend WithEvents aTimer As System.Windows.Forms.Timer
    Friend WithEvents lblJunk3 As System.Windows.Forms.Label
    Friend WithEvents aText As System.Windows.Forms.TextBox

End Class
