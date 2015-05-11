Public Class PortActions
    'Private 
    ' Handles 
    Private Sub PortActions_Load() Handles MyBase.Load
        timerPortChecker.Start
        
    End Sub
    
    Private Sub timerPortChecker_Tick() Handles timerPortChecker.Tick
        lstCurrentPorts.Items.Clear()
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
        Next
    End Sub
    
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        
    End Sub
    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit
    End Sub
    
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
