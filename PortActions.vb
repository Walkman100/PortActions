Public Class PortActions
    'Private 
    ' Handles 
    Private Sub PortActions_Load() Handles MyBase.Load
        cbxActionsMsgBoxButtons.SelectedIndex = 0
        cbxActionsMsgBoxStyle.SelectedIndex = 0
        cbxActionsSoundSystem.SelectedIndex = 0
        selectProgramDialog.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
        Next
    End Sub
    
    Dim WatchPorts(0) As String
    Dim WatchPortsTmp As String
    Private Sub btnStart_Click() Handles btnStart.Click
        If btnStart.Text = "Start" Then
            btnStart.Text = "Started!"
            txtPorts.Enabled = False
            If optPortsSome.Checked Then IteratePorts
            timerPortChecker.Start
        ElseIf btnStart.Text = "Stop"
            btnStart.Text = "Stopped!"
            txtPorts.Enabled = optPortsSome.Checked
            Array.Resize(WatchPorts,1)
            WatchPorts(0) = ""
        End If
        lstCurrentPorts.Items.Clear()
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
        Next
    End Sub
    
    Private Sub IteratePorts
        WatchPortsTmp = txtPorts.Text
        If WatchPortsTmp.Contains(",") Then
            WatchPorts(0) = WatchPortsTmp.Remove(WatchPortsTmp.IndexOf(","))
            Do Until Not WatchPortsTmp.Contains(",")
                WatchPortsTmp = WatchPortsTmp.Substring(WatchPortsTmp.IndexOf(",")+1)
                Array.Resize(WatchPorts, WatchPorts.Length+1)
                If WatchPortsTmp.Contains(",") Then
                    WatchPorts(WatchPorts.Length-1) = WatchPortsTmp.remove(WatchPortsTmp.IndexOf(","))
                Else
                    WatchPorts(WatchPorts.Length-1) = WatchPortsTmp
                End If
            Loop
        Else
            WatchPorts(0) = WatchPortsTmp
        End If
        txtPorts.Text = ""
        For Each port In WatchPorts
            If txtPorts.Text = "" Then
                txtPorts.Text &= port
            Else
                txtPorts.Text &= "," & port
            End If
        Next
    End Sub
    
    Private Sub timerPortChecker_Tick() Handles timerPortChecker.Tick
        If btnStart.Text = "Started!" Then
            btnStart.Text = "Stop"
        ElseIf btnStart.Text = "Stopped!"
            timerPortChecker.Stop
            btnStart.Text = "Start"
            lblCurrentPorts.Text = "Available Ports:"
            Exit Sub
        End If
        
        For Each PortName In My.Computer.Ports.SerialPortNames
            If Not lstCurrentPorts.Items.Contains(PortName) Then
                If chkChangesAdded.Checked Then DoActions(PortName)
            End If
        Next
        For Each PortInList In lstCurrentPorts.Items
            If Not My.Computer.Ports.SerialPortNames.Contains(PortInList) Then
                If chkChangesRemoved.Checked Then DoActions(PortInList)
            End If
        Next
        
        If chkChangesRemember.Checked = True Then
            lblCurrentPorts.Text = "Remembered Serial Ports:"
        Else
            lstCurrentPorts.Items.Clear()
        End If
        For Each PortName In My.Computer.Ports.SerialPortNames
            If Not lstCurrentPorts.Items.Contains(PortName) Then
                lstCurrentPorts.Items.Add(PortName)
            End If
        Next
    End Sub
    
    Private buttons As Integer
    Private style As Integer
    Private Sub DoActions(optional port As String = "")
        If chkActionsProgram.Checked Then
            If System.IO.File.Exists(String.Format(txtActionsProgram.Text, port)) Then
                Process.Start(String.Format(txtActionsProgram.Text, port), String.Format(txtActionsProgramArgs.Text, port))
            Else
                MsgBox("Program " & String.Format(txtActionsProgram.Text, port) & " not found!", MsgBoxStyle.Exclamation)
            End If
        End If
        If chkActionsMsgBox.Checked Then
            Select Case cbxActionsMsgBoxButtons.SelectedIndex
                Case 0 'OK button only (default)
                    buttons = MsgBoxStyle.OkOnly
                Case 1 'OK and Cancel buttons
                    buttons = MsgBoxStyle.OkCancel
                Case 2 'Yes and No buttons
                    buttons = MsgBoxStyle.YesNo
                Case 3 'Yes, No, and Cancel buttons
                    buttons = MsgBoxStyle.YesNoCancel
                Case 4 'Retry and Cancel buttons
                    buttons = MsgBoxStyle.RetryCancel
                Case 5 'Abort, Retry, and Ignore buttons
                    buttons = MsgBoxStyle.AbortRetryIgnore
            End Select
            Select Case cbxActionsMsgBoxStyle.SelectedIndex
                Case 0 'None
                    style = 0
                Case 1 'Error
                    style = MsgBoxStyle.Critical
                Case 2 'Warning
                    style = MsgBoxStyle.Exclamation
                Case 3 'Information
                    style = MsgBoxStyle.Information
                Case 4 'Question
                    style = MsgBoxStyle.Question
            End Select
            MsgBox(String.Format(txtActionsMsgBoxText.Text, port), buttons + style)
        End If
        If chkActionsSound.Checked Then
            If optActionsSoundFile.Checked Then
                If System.IO.File.Exists(String.Format(txtActionsSoundFile.Text, port)) Then
                    My.Computer.Audio.Play(String.Format(txtActionsSoundFile.Text, port))
                Else
                    MsgBox("Audio file " & String.Format(txtActionsSoundFile.Text, port) & "not found!", MsgBoxStyle.Exclamation)
                End If
            Else
                Select Case cbxActionsSoundSystem.SelectedIndex
                    Case 0 'Question
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Question)
                    Case 1 'Hand
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
                    Case 2 'Exclamation
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                    Case 3 'Beep
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                    Case 4 'Asterisk
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                End Select
            End If
        End If
        If chkActionsStop.Checked Then
            btnStart_Click
        End If
        If chkActionsClose.Checked Then
            Application.Exit
        End If
    End Sub
    
    Private Sub btnClose_Click() Handles btnClose.Click
        Application.Exit
    End Sub
    
    ' GUI stuff
    
    Private Sub optPortsSome_CheckedChanged() Handles optPortsSome.CheckedChanged
        If timerPortChecker.Enabled = False Then txtPorts.Enabled = optPortsSome.Checked
    End Sub
    
    Private Sub chkChangesRemoved_CheckedChanged() Handles chkChangesRemoved.CheckedChanged
        chkChangesRemember.Enabled = Not chkChangesRemoved.Checked
    End Sub
    
    Private Sub chkChangesRemember_CheckedChanged() Handles chkChangesRemember.CheckedChanged
        chkChangesRemoved.Enabled = Not chkChangesRemember.Checked
    End Sub
    
    Private Sub chkActionsProgram_CheckedChanged() Handles chkActionsProgram.CheckedChanged
        grpActionsProgram.Enabled = chkActionsProgram.Checked
    End Sub
    
    Private Sub btnActionsProgramBrowse_Click() Handles btnActionsProgramBrowse.Click
        If selectProgramDialog.ShowDialog = DialogResult.OK Then
            txtActionsProgram.Text = selectProgramDialog.FileName
        End If
    End Sub
    
    Dim PuTTYprofile As String
    Private Sub btnActionsProgramPuTTY_Click() Handles btnActionsProgramPuTTY.Click
        PuTTYprofile = InputBox("Enter PuTTY profile name:", "PuTTY Profile")
        If PuTTYprofile <> "" Then
            txtActionsProgramArgs.Text = "@" & PuTTYprofile
        End If
    End Sub
    
    Private Sub btnActionsProgramPuTTY_MouseUp(sender As Object, e As MouseEventArgs) Handles btnActionsProgramPuTTY.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            txtActionsProgram.Text = Environment.GetEnvironmentVariable("ProgramFiles") & "\PuTTY\putty.exe"
        End If
    End Sub
    
    Private Sub chkActionsMsgBox_CheckedChanged() Handles chkActionsMsgBox.CheckedChanged
        grpActionsMsgBox.Enabled = chkActionsMsgBox.Checked
    End Sub
    
    Private Sub chkActionsSound_CheckedChanged() Handles chkActionsSound.CheckedChanged
        grpActionsSound.Enabled = chkActionsSound.Checked
    End Sub
    
    Private Sub SoundSourceChanged() Handles optActionsSoundFile.CheckedChanged, optActionsSoundSystem.CheckedChanged
        txtActionsSoundFile.Enabled = optActionsSoundFile.Checked
        btnActionsSoundFile.Enabled = optActionsSoundFile.Checked
        cbxActionsSoundSystem.Enabled = optActionsSoundSystem.Checked
    End Sub
    
    Private Sub btnActionsSoundFile_Click() Handles btnActionsSoundFile.Click
        If selectSoundDialog.ShowDialog = DialogResult.OK Then
            txtActionsSoundFile.Text = selectSoundDialog.FileName
        End If
    End Sub
End Class
