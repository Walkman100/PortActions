<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortActions
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
        Me.lstCurrentPorts = New System.Windows.Forms.ListBox()
        Me.timerPortChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lblCurrentPorts = New System.Windows.Forms.Label()
        Me.grpPorts = New System.Windows.Forms.GroupBox()
        Me.optPortsAll = New System.Windows.Forms.RadioButton()
        Me.optPortsSome = New System.Windows.Forms.RadioButton()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.grpChanges = New System.Windows.Forms.GroupBox()
        Me.chkChangesRemoved = New System.Windows.Forms.CheckBox()
        Me.chkChangesAdded = New System.Windows.Forms.CheckBox()
        Me.chkChangesForget = New System.Windows.Forms.CheckBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.chkActionsProgram = New System.Windows.Forms.CheckBox()
        Me.grpActionsProgram = New System.Windows.Forms.GroupBox()
        Me.txtActionsProgram = New System.Windows.Forms.TextBox()
        Me.lblActionsProgram = New System.Windows.Forms.Label()
        Me.lblActionsProgramArgs = New System.Windows.Forms.Label()
        Me.txtActionsProgramArgs = New System.Windows.Forms.TextBox()
        Me.chkActionsMsgBox = New System.Windows.Forms.CheckBox()
        Me.grpActionsMsgBox = New System.Windows.Forms.GroupBox()
        Me.lblActionsMsgBoxStyle = New System.Windows.Forms.Label()
        Me.lblActionsMsgBoxText = New System.Windows.Forms.Label()
        Me.txtActionsMsgBoxText = New System.Windows.Forms.TextBox()
        Me.cbxActionsMsgBoxStyle = New System.Windows.Forms.ComboBox()
        Me.chkActionsClose = New System.Windows.Forms.CheckBox()
        Me.grpPorts.SuspendLayout
        Me.grpChanges.SuspendLayout
        Me.grpActions.SuspendLayout
        Me.grpActionsProgram.SuspendLayout
        Me.grpActionsMsgBox.SuspendLayout
        Me.SuspendLayout
        '
        'lstCurrentPorts
        '
        Me.lstCurrentPorts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstCurrentPorts.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstCurrentPorts.FormattingEnabled = true
        Me.lstCurrentPorts.IntegralHeight = false
        Me.lstCurrentPorts.ItemHeight = 16
        Me.lstCurrentPorts.Items.AddRange(New Object() {"Checking..."})
        Me.lstCurrentPorts.Location = New System.Drawing.Point(223, 30)
        Me.lstCurrentPorts.Name = "lstCurrentPorts"
        Me.lstCurrentPorts.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstCurrentPorts.Size = New System.Drawing.Size(242, 355)
        Me.lstCurrentPorts.TabIndex = 16
        '
        'timerPortChecker
        '
        Me.timerPortChecker.Interval = 1000
        '
        'lblCurrentPorts
        '
        Me.lblCurrentPorts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblCurrentPorts.AutoSize = true
        Me.lblCurrentPorts.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCurrentPorts.Location = New System.Drawing.Point(223, 9)
        Me.lblCurrentPorts.Name = "lblCurrentPorts"
        Me.lblCurrentPorts.Size = New System.Drawing.Size(165, 18)
        Me.lblCurrentPorts.TabIndex = 18
        Me.lblCurrentPorts.Text = "Current Serial Port Names:"
        '
        'grpPorts
        '
        Me.grpPorts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpPorts.Controls.Add(Me.textBox1)
        Me.grpPorts.Controls.Add(Me.optPortsSome)
        Me.grpPorts.Controls.Add(Me.optPortsAll)
        Me.grpPorts.Location = New System.Drawing.Point(12, 12)
        Me.grpPorts.Name = "grpPorts"
        Me.grpPorts.Size = New System.Drawing.Size(205, 72)
        Me.grpPorts.TabIndex = 19
        Me.grpPorts.TabStop = false
        Me.grpPorts.Text = "Watch ports:"
        '
        'optPortsAll
        '
        Me.optPortsAll.AutoSize = true
        Me.optPortsAll.Checked = true
        Me.optPortsAll.Location = New System.Drawing.Point(6, 19)
        Me.optPortsAll.Name = "optPortsAll"
        Me.optPortsAll.Size = New System.Drawing.Size(36, 17)
        Me.optPortsAll.TabIndex = 0
        Me.optPortsAll.TabStop = true
        Me.optPortsAll.Text = "All"
        Me.optPortsAll.UseVisualStyleBackColor = true
        '
        'optPortsSome
        '
        Me.optPortsSome.AutoSize = true
        Me.optPortsSome.Location = New System.Drawing.Point(6, 42)
        Me.optPortsSome.Name = "optPortsSome"
        Me.optPortsSome.Size = New System.Drawing.Size(72, 17)
        Me.optPortsSome.TabIndex = 1
        Me.optPortsSome.Text = "Specified:"
        Me.optPortsSome.UseVisualStyleBackColor = true
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.textBox1.Enabled = false
        Me.textBox1.Location = New System.Drawing.Point(84, 41)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(115, 20)
        Me.textBox1.TabIndex = 2
        '
        'grpChanges
        '
        Me.grpChanges.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpChanges.Controls.Add(Me.chkChangesForget)
        Me.grpChanges.Controls.Add(Me.chkChangesAdded)
        Me.grpChanges.Controls.Add(Me.chkChangesRemoved)
        Me.grpChanges.Location = New System.Drawing.Point(12, 90)
        Me.grpChanges.Name = "grpChanges"
        Me.grpChanges.Size = New System.Drawing.Size(205, 100)
        Me.grpChanges.TabIndex = 20
        Me.grpChanges.TabStop = false
        Me.grpChanges.Text = "What to count as changes:"
        '
        'chkChangesRemoved
        '
        Me.chkChangesRemoved.AutoSize = true
        Me.chkChangesRemoved.Location = New System.Drawing.Point(6, 42)
        Me.chkChangesRemoved.Name = "chkChangesRemoved"
        Me.chkChangesRemoved.Size = New System.Drawing.Size(98, 17)
        Me.chkChangesRemoved.TabIndex = 0
        Me.chkChangesRemoved.Text = "Removed ports"
        Me.chkChangesRemoved.UseVisualStyleBackColor = true
        '
        'chkChangesAdded
        '
        Me.chkChangesAdded.AutoSize = true
        Me.chkChangesAdded.Checked = true
        Me.chkChangesAdded.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangesAdded.Location = New System.Drawing.Point(6, 19)
        Me.chkChangesAdded.Name = "chkChangesAdded"
        Me.chkChangesAdded.Size = New System.Drawing.Size(83, 17)
        Me.chkChangesAdded.TabIndex = 1
        Me.chkChangesAdded.Text = "Added ports"
        Me.chkChangesAdded.UseVisualStyleBackColor = true
        '
        'chkChangesForget
        '
        Me.chkChangesForget.AutoSize = true
        Me.chkChangesForget.Location = New System.Drawing.Point(6, 65)
        Me.chkChangesForget.Name = "chkChangesForget"
        Me.chkChangesForget.Size = New System.Drawing.Size(151, 17)
        Me.chkChangesForget.TabIndex = 2
        Me.chkChangesForget.Text = "Don't forget removed ports"
        Me.chkChangesForget.UseVisualStyleBackColor = true
        '
        'grpActions
        '
        Me.grpActions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActions.Controls.Add(Me.chkActionsClose)
        Me.grpActions.Controls.Add(Me.grpActionsMsgBox)
        Me.grpActions.Controls.Add(Me.grpActionsProgram)
        Me.grpActions.Location = New System.Drawing.Point(12, 196)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(205, 189)
        Me.grpActions.TabIndex = 21
        Me.grpActions.TabStop = false
        Me.grpActions.Text = "What to do on change:"
        '
        'chkActionsProgram
        '
        Me.chkActionsProgram.AutoSize = true
        Me.chkActionsProgram.Location = New System.Drawing.Point(6, 0)
        Me.chkActionsProgram.Name = "chkActionsProgram"
        Me.chkActionsProgram.Size = New System.Drawing.Size(93, 17)
        Me.chkActionsProgram.TabIndex = 1
        Me.chkActionsProgram.Text = "Start Program:"
        Me.chkActionsProgram.UseVisualStyleBackColor = true
        '
        'grpActionsProgram
        '
        Me.grpActionsProgram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActionsProgram.Controls.Add(Me.txtActionsProgramArgs)
        Me.grpActionsProgram.Controls.Add(Me.lblActionsProgramArgs)
        Me.grpActionsProgram.Controls.Add(Me.lblActionsProgram)
        Me.grpActionsProgram.Controls.Add(Me.txtActionsProgram)
        Me.grpActionsProgram.Controls.Add(Me.chkActionsProgram)
        Me.grpActionsProgram.Location = New System.Drawing.Point(6, 19)
        Me.grpActionsProgram.Name = "grpActionsProgram"
        Me.grpActionsProgram.Size = New System.Drawing.Size(193, 67)
        Me.grpActionsProgram.TabIndex = 3
        Me.grpActionsProgram.TabStop = false
        '
        'txtActionsProgram
        '
        Me.txtActionsProgram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsProgram.Location = New System.Drawing.Point(61, 17)
        Me.txtActionsProgram.Name = "txtActionsProgram"
        Me.txtActionsProgram.Size = New System.Drawing.Size(126, 20)
        Me.txtActionsProgram.TabIndex = 2
        '
        'lblActionsProgram
        '
        Me.lblActionsProgram.AutoSize = true
        Me.lblActionsProgram.Location = New System.Drawing.Point(6, 20)
        Me.lblActionsProgram.Name = "lblActionsProgram"
        Me.lblActionsProgram.Size = New System.Drawing.Size(49, 13)
        Me.lblActionsProgram.TabIndex = 3
        Me.lblActionsProgram.Text = "Program:"
        '
        'lblActionsProgramArgs
        '
        Me.lblActionsProgramArgs.AutoSize = true
        Me.lblActionsProgramArgs.Location = New System.Drawing.Point(6, 42)
        Me.lblActionsProgramArgs.Name = "lblActionsProgramArgs"
        Me.lblActionsProgramArgs.Size = New System.Drawing.Size(31, 13)
        Me.lblActionsProgramArgs.TabIndex = 4
        Me.lblActionsProgramArgs.Text = "Args:"
        '
        'txtActionsProgramArgs
        '
        Me.txtActionsProgramArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsProgramArgs.Location = New System.Drawing.Point(43, 39)
        Me.txtActionsProgramArgs.Name = "txtActionsProgramArgs"
        Me.txtActionsProgramArgs.Size = New System.Drawing.Size(144, 20)
        Me.txtActionsProgramArgs.TabIndex = 5
        '
        'chkActionsMsgBox
        '
        Me.chkActionsMsgBox.AutoSize = true
        Me.chkActionsMsgBox.Location = New System.Drawing.Point(6, 0)
        Me.chkActionsMsgBox.Name = "chkActionsMsgBox"
        Me.chkActionsMsgBox.Size = New System.Drawing.Size(122, 17)
        Me.chkActionsMsgBox.TabIndex = 1
        Me.chkActionsMsgBox.Text = "Show Message box:"
        Me.chkActionsMsgBox.UseVisualStyleBackColor = true
        '
        'grpActionsMsgBox
        '
        Me.grpActionsMsgBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActionsMsgBox.Controls.Add(Me.cbxActionsMsgBoxStyle)
        Me.grpActionsMsgBox.Controls.Add(Me.lblActionsMsgBoxStyle)
        Me.grpActionsMsgBox.Controls.Add(Me.lblActionsMsgBoxText)
        Me.grpActionsMsgBox.Controls.Add(Me.txtActionsMsgBoxText)
        Me.grpActionsMsgBox.Controls.Add(Me.chkActionsMsgBox)
        Me.grpActionsMsgBox.Location = New System.Drawing.Point(6, 92)
        Me.grpActionsMsgBox.Name = "grpActionsMsgBox"
        Me.grpActionsMsgBox.Size = New System.Drawing.Size(193, 67)
        Me.grpActionsMsgBox.TabIndex = 4
        Me.grpActionsMsgBox.TabStop = false
        '
        'lblActionsMsgBoxStyle
        '
        Me.lblActionsMsgBoxStyle.AutoSize = true
        Me.lblActionsMsgBoxStyle.Location = New System.Drawing.Point(6, 42)
        Me.lblActionsMsgBoxStyle.Name = "lblActionsMsgBoxStyle"
        Me.lblActionsMsgBoxStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblActionsMsgBoxStyle.TabIndex = 4
        Me.lblActionsMsgBoxStyle.Text = "Style:"
        '
        'lblActionsMsgBoxText
        '
        Me.lblActionsMsgBoxText.AutoSize = true
        Me.lblActionsMsgBoxText.Location = New System.Drawing.Point(6, 20)
        Me.lblActionsMsgBoxText.Name = "lblActionsMsgBoxText"
        Me.lblActionsMsgBoxText.Size = New System.Drawing.Size(31, 13)
        Me.lblActionsMsgBoxText.TabIndex = 3
        Me.lblActionsMsgBoxText.Text = "Text:"
        '
        'txtActionsMsgBoxText
        '
        Me.txtActionsMsgBoxText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsMsgBoxText.Location = New System.Drawing.Point(43, 17)
        Me.txtActionsMsgBoxText.Name = "txtActionsMsgBoxText"
        Me.txtActionsMsgBoxText.Size = New System.Drawing.Size(144, 20)
        Me.txtActionsMsgBoxText.TabIndex = 2
        '
        'cbxActionsMsgBoxStyle
        '
        Me.cbxActionsMsgBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActionsMsgBoxStyle.FormattingEnabled = true
        Me.cbxActionsMsgBoxStyle.Location = New System.Drawing.Point(45, 39)
        Me.cbxActionsMsgBoxStyle.Name = "cbxActionsMsgBoxStyle"
        Me.cbxActionsMsgBoxStyle.Size = New System.Drawing.Size(142, 21)
        Me.cbxActionsMsgBoxStyle.TabIndex = 5
        '
        'chkActionsClose
        '
        Me.chkActionsClose.AutoSize = true
        Me.chkActionsClose.Location = New System.Drawing.Point(6, 165)
        Me.chkActionsClose.Name = "chkActionsClose"
        Me.chkActionsClose.Size = New System.Drawing.Size(112, 17)
        Me.chkActionsClose.TabIndex = 5
        Me.chkActionsClose.Text = "Close Port Actions"
        Me.chkActionsClose.UseVisualStyleBackColor = true
        '
        'PortActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 397)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.grpChanges)
        Me.Controls.Add(Me.grpPorts)
        Me.Controls.Add(Me.lblCurrentPorts)
        Me.Controls.Add(Me.lstCurrentPorts)
        Me.Name = "PortActions"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Port Actions"
        Me.grpPorts.ResumeLayout(false)
        Me.grpPorts.PerformLayout
        Me.grpChanges.ResumeLayout(false)
        Me.grpChanges.PerformLayout
        Me.grpActions.ResumeLayout(false)
        Me.grpActions.PerformLayout
        Me.grpActionsProgram.ResumeLayout(false)
        Me.grpActionsProgram.PerformLayout
        Me.grpActionsMsgBox.ResumeLayout(false)
        Me.grpActionsMsgBox.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents chkActionsProgram As System.Windows.Forms.CheckBox
    Friend WithEvents txtActionsProgram As System.Windows.Forms.TextBox
    Friend WithEvents lblActionsProgram As System.Windows.Forms.Label
    Friend WithEvents lblActionsProgramArgs As System.Windows.Forms.Label
    Friend WithEvents txtActionsProgramArgs As System.Windows.Forms.TextBox
    Friend WithEvents grpActionsProgram As System.Windows.Forms.GroupBox
    Friend WithEvents chkActionsMsgBox As System.Windows.Forms.CheckBox
    Friend WithEvents txtActionsMsgBoxText As System.Windows.Forms.TextBox
    Friend WithEvents lblActionsMsgBoxText As System.Windows.Forms.Label
    Friend WithEvents lblActionsMsgBoxStyle As System.Windows.Forms.Label
    Friend WithEvents cbxActionsMsgBoxStyle As System.Windows.Forms.ComboBox
    Friend WithEvents grpActionsMsgBox As System.Windows.Forms.GroupBox
    Friend WithEvents chkActionsClose As System.Windows.Forms.CheckBox
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents chkChangesRemoved As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangesAdded As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangesForget As System.Windows.Forms.CheckBox
    Friend WithEvents grpChanges As System.Windows.Forms.GroupBox
    Friend WithEvents optPortsAll As System.Windows.Forms.RadioButton
    Friend WithEvents optPortsSome As System.Windows.Forms.RadioButton
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grpPorts As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentPorts As System.Windows.Forms.Label
    Friend WithEvents timerPortChecker As System.Windows.Forms.Timer
    Friend WithEvents lstCurrentPorts As System.Windows.Forms.ListBox
End Class
