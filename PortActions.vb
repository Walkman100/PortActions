Public Class PortActions
    'Private 
    ' Handles 
    Private Sub PortActions_Load() Handles MyBase.Load
        cbxActionsMsgBoxButtons.SelectedIndex = 0
        cbxActionsMsgBoxStyle.SelectedIndex = 0
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
        Next
    End Sub
    
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            btnStart.Text = "Started!"
            timerPortChecker.Start
        ElseIf btnStart.Text = "Stop"
            btnStart.Text = "Stopped!"
        End If
        lstCurrentPorts.Items.Clear()
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
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
        If chkChangesForget.Checked = True Then
            lblCurrentPorts.Text = "Remembered Serial Ports:"
            For Each PortName In My.Computer.Ports.SerialPortNames
                If Not lstCurrentPorts.Items.Contains(PortName) Then
                    lstCurrentPorts.Items.Add(PortName)
                End If
            Next
        Else
            lstCurrentPorts.Items.Clear()
            For Each PortName In My.Computer.Ports.SerialPortNames
                lstCurrentPorts.Items.Add(PortName)
            Next
        End If
    End Sub
    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit
    End Sub
    
    Private buttons As Integer
    Private style As Integer
    Private Function ShowMessage() As MsgBoxResult
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
        Return MsgBox(txtActionsMsgBoxText.Text, buttons + style)
    End Function
    
    ' GUI stuff
    
    Private Sub optPortsSome_CheckedChanged() Handles optPortsSome.CheckedChanged
        txtPorts.Enabled = optPortsSome.Checked
    End Sub
    
    Private Sub chkChangesRemoved_CheckedChanged() Handles chkChangesRemoved.CheckedChanged
        chkChangesForget.Enabled = Not chkChangesRemoved.Checked
    End Sub
    
    Private Sub chkChangesForget_CheckedChanged() Handles chkChangesForget.CheckedChanged
        chkChangesRemoved.Enabled = Not chkChangesForget.Checked
    End Sub
    
    Private Sub chkActionsProgram_CheckedChanged() Handles chkActionsProgram.CheckedChanged
        grpActionsProgram.Enabled = chkActionsProgram.Checked
    End Sub
    
    Private Sub chkActionsMsgBox_CheckedChanged() Handles chkActionsMsgBox.CheckedChanged
        grpActionsMsgBox.Enabled = chkActionsMsgBox.Checked
    End Sub
End Class
