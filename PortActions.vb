Public Class PortActions
    Private Sub PortActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerPortChecker.Start
        
    End Sub
    
    Private Sub timerPortChecker_Tick() Handles timerPortChecker.Tick
        lstCurrentPorts.Items.Clear()
        For Each PortName In My.Computer.Ports.SerialPortNames
            lstCurrentPorts.Items.Add(PortName)
        Next
    End Sub
End Class
