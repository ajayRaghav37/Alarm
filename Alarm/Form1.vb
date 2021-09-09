'AlarmDay contains the value of checkbox - It can be either of the following
'   w   -   Weekdays
'   t   -   Today
'   m   -   Tomorrow
'   o   -   Other

'AlarmTime contains the time of alarm. It is represented as date.
'AlarmOn gives us the status whether the alarm is on or off. It is boolean.

Public Class Form1
    Dim AlarmUpdated As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aDatePicker.MinDate = Date.Today.AddDays(2)
        Select Case My.Settings.AlarmDay
            Case "w"
                rWeekdays.Checked = True
            Case "t"
                rOnce.Checked = True
                rToday.Checked = True
            Case "m"
                rOnce.Checked = True
                rTomorrow.Checked = True
            Case "o"
                rOnce.Checked = True
                rOther.Checked = True
        End Select
        'If My.Settings.AlarmTime = Date.MinValue Then
        '    Alarm Never Set
        '    ElseIf My.Settings.AlarmOn Then
        '        If My.Settings.AlarmTime = Now Then

        '            'Play Alarm
        '        End If
        'End If
    End Sub

    Private Sub rOnce_CheckedChanged(sender As Object, e As EventArgs) Handles rOnce.CheckedChanged
        If rOnce.Checked Then
            pOnce.Enabled = True
        End If
    End Sub

    Private Sub rWeekdays_CheckedChanged(sender As Object, e As EventArgs) Handles rWeekdays.CheckedChanged
        If rWeekdays.Checked Then
            pOnce.Enabled = False
        End If
    End Sub

    Private Sub rOther_CheckedChanged(sender As Object, e As EventArgs) Handles rOther.CheckedChanged
        If rOther.Checked Then
            aDatePicker.Enabled = True
        End If
    End Sub

    Private Sub rToday_CheckedChanged(sender As Object, e As EventArgs) Handles rToday.CheckedChanged
        If rToday.Checked Then
            aDatePicker.Enabled = False
            If aTimePicker.Value.TimeOfDay < Date.Now.TimeOfDay Then
                aTimePicker.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub rTomorrow_CheckedChanged(sender As Object, e As EventArgs) Handles rTomorrow.CheckedChanged
        If rTomorrow.Checked Then
            aDatePicker.Enabled = False
        End If
    End Sub

    Private Sub aTimer_Tick(sender As Object, e As EventArgs) Handles aTimer.Tick
        'Given conditions are only for alarm to be played RIGHT NOW!!
        If My.Settings.AlarmOn Then
            Select Case My.Settings.AlarmDay
                Case "w"
                    If Date.Today.DayOfWeek <> DayOfWeek.Saturday And Date.Today.DayOfWeek <> DayOfWeek.Sunday Then
                        If My.Settings.AlarmTime.Hour = Now.Hour And My.Settings.AlarmTime.Minute = Now.Minute And My.Settings.AlarmTime.Second = Now.Second Then
                            Snooze.Show()
                        End If
                        'If Date.Now.TimeOfDay.Hours = aTimePicker.Value.TimeOfDay.Hours And Date.Now.TimeOfDay.Minutes = aTimePicker.Value.TimeOfDay.Minutes And Date.Now.TimeOfDay.Seconds = aTimePicker.Value.TimeOfDay.Seconds Then
                        '    Snooze.Show()
                        'My.Computer.Audio.Play(aWavPicker.Text)
                        'Me.Text = "PLAYING!!"
                        'End If
                    End If
                Case "t"
                    If My.Settings.AlarmTime.Hour = Now.Hour And My.Settings.AlarmTime.Minute = Now.Minute And My.Settings.AlarmTime.Second = Now.Second Then
                        Snooze.Show()
                    End If
                    'If Date.Now.TimeOfDay.Hours = aTimePicker.Value.TimeOfDay.Hours And Date.Now.TimeOfDay.Minutes = aTimePicker.Value.TimeOfDay.Minutes And Date.Now.TimeOfDay.Seconds = aTimePicker.Value.TimeOfDay.Seconds Then
                    '    Snooze.Show()
                    '    My.Computer.Audio.Play(aWavPicker.Text)
                    '    Me.Text = "PLAYING!!"
                    'End If
                Case "m"
                    If My.Settings.AlarmTime.Hour = Now.Hour And My.Settings.AlarmTime.Minute = Now.Minute And My.Settings.AlarmTime.Second = Now.Second Then
                        If My.Settings.DateSet = Date.Today.AddDays(-1) Then
                            Snooze.Show()
                        End If
                    End If
                Case "o"
                    If My.Settings.AlarmTime.Hour = Now.Hour And My.Settings.AlarmTime.Minute = Now.Minute And My.Settings.AlarmTime.Second = Now.Second And My.Settings.AlarmTime.Year = Today.Year And My.Settings.AlarmTime.Month = Today.Month And My.Settings.AlarmTime.Day = Today.Day Then
                        'If My.Settings.AlarmTime.Day = Today.Day Then
                        '    MsgBox("SUCCESS")
                        'Else
                        '    MsgBox(My.Settings.AlarmTime.Day & " " & Today.Day)
                        'End If
                        Snooze.Show()
                    End If
            End Select
        End If
    End Sub

    Private Sub bSet_Click(sender As Object, e As EventArgs) Handles bSet.Click
        AlarmUpdated = True
        If rWeekdays.Checked Then
            My.Settings.AlarmDay = "w"
            My.Settings.AlarmTime = New Date(Today.Year, Today.Month, Today.Day, aTimePicker.Value.Hour, aTimePicker.Value.Minute, aTimePicker.Value.Second)
        ElseIf rToday.Checked Then
            My.Settings.AlarmDay = "t"
            My.Settings.AlarmTime = New Date(Today.Year, Today.Month, Today.Day, aTimePicker.Value.Hour, aTimePicker.Value.Minute, aTimePicker.Value.Second)
        ElseIf rTomorrow.Checked Then
            My.Settings.AlarmDay = "m"
            My.Settings.AlarmTime = New Date(Today.AddDays(1).Year, Today.AddDays(1).Month, Today.AddDays(1).Day, aTimePicker.Value.Hour, aTimePicker.Value.Minute, aTimePicker.Value.Second)
        ElseIf rOther.Checked Then
            My.Settings.AlarmDay = "o"
            My.Settings.AlarmTime = New Date(aDatePicker.Value.Year, aDatePicker.Value.Month, aDatePicker.Value.Day, aTimePicker.Value.Hour, aTimePicker.Value.Minute, aTimePicker.Value.Second)
            MsgBox(My.Settings.AlarmTime.ToString)
        End If
        My.Settings.AlarmOn = True
        My.Settings.DateSet = Today
        My.Settings.Save()
    End Sub
End Class
