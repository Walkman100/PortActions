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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PortActions))
        Me.lstCurrentPorts = New System.Windows.Forms.ListBox()
        Me.timerPortChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lblCurrentPorts = New System.Windows.Forms.Label()
        Me.grpPorts = New System.Windows.Forms.GroupBox()
        Me.txtPorts = New System.Windows.Forms.TextBox()
        Me.optPortsSome = New System.Windows.Forms.RadioButton()
        Me.optPortsAll = New System.Windows.Forms.RadioButton()
        Me.grpChanges = New System.Windows.Forms.GroupBox()
        Me.chkChangesRemember = New System.Windows.Forms.CheckBox()
        Me.chkChangesAdded = New System.Windows.Forms.CheckBox()
        Me.chkChangesRemoved = New System.Windows.Forms.CheckBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.chkActionsSound = New System.Windows.Forms.CheckBox()
        Me.grpActionsSound = New System.Windows.Forms.GroupBox()
        Me.btnActionsSoundFile = New System.Windows.Forms.Button()
        Me.cbxActionsSoundSystem = New System.Windows.Forms.ComboBox()
        Me.txtActionsSoundFile = New System.Windows.Forms.TextBox()
        Me.optActionsSoundSystem = New System.Windows.Forms.RadioButton()
        Me.optActionsSoundFile = New System.Windows.Forms.RadioButton()
        Me.chkActionsStop = New System.Windows.Forms.CheckBox()
        Me.chkActionsMsgBox = New System.Windows.Forms.CheckBox()
        Me.chkActionsProgram = New System.Windows.Forms.CheckBox()
        Me.chkActionsClose = New System.Windows.Forms.CheckBox()
        Me.grpActionsMsgBox = New System.Windows.Forms.GroupBox()
        Me.cbxActionsMsgBoxButtons = New System.Windows.Forms.ComboBox()
        Me.lblActionsMsgBoxButtons = New System.Windows.Forms.Label()
        Me.cbxActionsMsgBoxStyle = New System.Windows.Forms.ComboBox()
        Me.lblActionsMsgBoxStyle = New System.Windows.Forms.Label()
        Me.lblActionsMsgBoxText = New System.Windows.Forms.Label()
        Me.txtActionsMsgBoxText = New System.Windows.Forms.TextBox()
        Me.grpActionsProgram = New System.Windows.Forms.GroupBox()
        Me.btnActionsProgramPuTTY = New System.Windows.Forms.Button()
        Me.btnActionsProgramBrowse = New System.Windows.Forms.Button()
        Me.txtActionsProgramArgs = New System.Windows.Forms.TextBox()
        Me.lblActionsProgramArgs = New System.Windows.Forms.Label()
        Me.lblActionsProgram = New System.Windows.Forms.Label()
        Me.txtActionsProgram = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.selectProgramDialog = New System.Windows.Forms.OpenFileDialog()
        Me.selectSoundDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpPorts.SuspendLayout
        Me.grpChanges.SuspendLayout
        Me.grpActions.SuspendLayout
        Me.grpActionsSound.SuspendLayout
        Me.grpActionsMsgBox.SuspendLayout
        Me.grpActionsProgram.SuspendLayout
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
        Me.lstCurrentPorts.Location = New System.Drawing.Point(223, 30)
        Me.lstCurrentPorts.Name = "lstCurrentPorts"
        Me.lstCurrentPorts.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstCurrentPorts.Size = New System.Drawing.Size(242, 536)
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
        Me.lblCurrentPorts.Size = New System.Drawing.Size(100, 18)
        Me.lblCurrentPorts.TabIndex = 18
        Me.lblCurrentPorts.Text = "Available Ports:"
        '
        'grpPorts
        '
        Me.grpPorts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpPorts.Controls.Add(Me.txtPorts)
        Me.grpPorts.Controls.Add(Me.optPortsSome)
        Me.grpPorts.Controls.Add(Me.optPortsAll)
        Me.grpPorts.Location = New System.Drawing.Point(12, 12)
        Me.grpPorts.Name = "grpPorts"
        Me.grpPorts.Size = New System.Drawing.Size(205, 72)
        Me.grpPorts.TabIndex = 19
        Me.grpPorts.TabStop = false
        Me.grpPorts.Text = "Watch ports:"
        '
        'txtPorts
        '
        Me.txtPorts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPorts.Location = New System.Drawing.Point(73, 41)
        Me.txtPorts.Name = "txtPorts"
        Me.txtPorts.ReadOnly = true
        Me.txtPorts.Size = New System.Drawing.Size(128, 20)
        Me.txtPorts.TabIndex = 2
        Me.txtPorts.Text = "COM2,COM4"
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
        'grpChanges
        '
        Me.grpChanges.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpChanges.Controls.Add(Me.chkChangesRemember)
        Me.grpChanges.Controls.Add(Me.chkChangesAdded)
        Me.grpChanges.Controls.Add(Me.chkChangesRemoved)
        Me.grpChanges.Location = New System.Drawing.Point(12, 90)
        Me.grpChanges.Name = "grpChanges"
        Me.grpChanges.Size = New System.Drawing.Size(205, 88)
        Me.grpChanges.TabIndex = 20
        Me.grpChanges.TabStop = false
        Me.grpChanges.Text = "What to count as changes:"
        '
        'chkChangesRemember
        '
        Me.chkChangesRemember.AutoSize = true
        Me.chkChangesRemember.Location = New System.Drawing.Point(6, 65)
        Me.chkChangesRemember.Name = "chkChangesRemember"
        Me.chkChangesRemember.Size = New System.Drawing.Size(151, 17)
        Me.chkChangesRemember.TabIndex = 2
        Me.chkChangesRemember.Text = "Don't forget removed ports"
        Me.chkChangesRemember.UseVisualStyleBackColor = true
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
        'grpActions
        '
        Me.grpActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActions.Controls.Add(Me.chkActionsSound)
        Me.grpActions.Controls.Add(Me.grpActionsSound)
        Me.grpActions.Controls.Add(Me.chkActionsStop)
        Me.grpActions.Controls.Add(Me.chkActionsMsgBox)
        Me.grpActions.Controls.Add(Me.chkActionsProgram)
        Me.grpActions.Controls.Add(Me.chkActionsClose)
        Me.grpActions.Controls.Add(Me.grpActionsMsgBox)
        Me.grpActions.Controls.Add(Me.grpActionsProgram)
        Me.grpActions.Location = New System.Drawing.Point(12, 184)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(205, 314)
        Me.grpActions.TabIndex = 21
        Me.grpActions.TabStop = false
        Me.grpActions.Text = "What to do on change:"
        '
        'chkActionsSound
        '
        Me.chkActionsSound.AutoSize = true
        Me.chkActionsSound.Location = New System.Drawing.Point(12, 235)
        Me.chkActionsSound.Name = "chkActionsSound"
        Me.chkActionsSound.Size = New System.Drawing.Size(83, 17)
        Me.chkActionsSound.TabIndex = 21
        Me.chkActionsSound.Text = "Play Sound:"
        Me.chkActionsSound.UseVisualStyleBackColor = true
        '
        'grpActionsSound
        '
        Me.grpActionsSound.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActionsSound.Controls.Add(Me.btnActionsSoundFile)
        Me.grpActionsSound.Controls.Add(Me.cbxActionsSoundSystem)
        Me.grpActionsSound.Controls.Add(Me.txtActionsSoundFile)
        Me.grpActionsSound.Controls.Add(Me.optActionsSoundSystem)
        Me.grpActionsSound.Controls.Add(Me.optActionsSoundFile)
        Me.grpActionsSound.Enabled = false
        Me.grpActionsSound.Location = New System.Drawing.Point(6, 235)
        Me.grpActionsSound.Name = "grpActionsSound"
        Me.grpActionsSound.Size = New System.Drawing.Size(193, 72)
        Me.grpActionsSound.TabIndex = 20
        Me.grpActionsSound.TabStop = false
        '
        'btnActionsSoundFile
        '
        Me.btnActionsSoundFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnActionsSoundFile.Image = CType(resources.GetObject("btnActionsSoundFile.Image"),System.Drawing.Image)
        Me.btnActionsSoundFile.Location = New System.Drawing.Point(164, 16)
        Me.btnActionsSoundFile.Name = "btnActionsSoundFile"
        Me.btnActionsSoundFile.Size = New System.Drawing.Size(23, 23)
        Me.btnActionsSoundFile.TabIndex = 9
        Me.btnActionsSoundFile.UseVisualStyleBackColor = true
        '
        'cbxActionsSoundSystem
        '
        Me.cbxActionsSoundSystem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxActionsSoundSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActionsSoundSystem.FormattingEnabled = true
        Me.cbxActionsSoundSystem.Items.AddRange(New Object() {"Question", "Hand (Error)", "Exclamation (Warning)", "Beep", "Asterisk (Information)"})
        Me.cbxActionsSoundSystem.Location = New System.Drawing.Point(95, 41)
        Me.cbxActionsSoundSystem.Name = "cbxActionsSoundSystem"
        Me.cbxActionsSoundSystem.Size = New System.Drawing.Size(92, 21)
        Me.cbxActionsSoundSystem.TabIndex = 8
        '
        'txtActionsSoundFile
        '
        Me.txtActionsSoundFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsSoundFile.Location = New System.Drawing.Point(105, 18)
        Me.txtActionsSoundFile.Name = "txtActionsSoundFile"
        Me.txtActionsSoundFile.ReadOnly = true
        Me.txtActionsSoundFile.Size = New System.Drawing.Size(59, 20)
        Me.txtActionsSoundFile.TabIndex = 2
        '
        'optActionsSoundSystem
        '
        Me.optActionsSoundSystem.AutoSize = true
        Me.optActionsSoundSystem.Location = New System.Drawing.Point(6, 42)
        Me.optActionsSoundSystem.Name = "optActionsSoundSystem"
        Me.optActionsSoundSystem.Size = New System.Drawing.Size(94, 17)
        Me.optActionsSoundSystem.TabIndex = 1
        Me.optActionsSoundSystem.Text = "System sound:"
        Me.optActionsSoundSystem.UseVisualStyleBackColor = true
        '
        'optActionsSoundFile
        '
        Me.optActionsSoundFile.AutoSize = true
        Me.optActionsSoundFile.Checked = true
        Me.optActionsSoundFile.Location = New System.Drawing.Point(6, 19)
        Me.optActionsSoundFile.Name = "optActionsSoundFile"
        Me.optActionsSoundFile.Size = New System.Drawing.Size(104, 17)
        Me.optActionsSoundFile.TabIndex = 0
        Me.optActionsSoundFile.TabStop = true
        Me.optActionsSoundFile.Text = "Specified sound:"
        Me.optActionsSoundFile.UseVisualStyleBackColor = true
        '
        'chkActionsStop
        '
        Me.chkActionsStop.AutoSize = true
        Me.chkActionsStop.Location = New System.Drawing.Point(6, 189)
        Me.chkActionsStop.Name = "chkActionsStop"
        Me.chkActionsStop.Size = New System.Drawing.Size(95, 17)
        Me.chkActionsStop.TabIndex = 6
        Me.chkActionsStop.Text = "Stop checking"
        Me.chkActionsStop.UseVisualStyleBackColor = true
        '
        'chkActionsMsgBox
        '
        Me.chkActionsMsgBox.AutoSize = true
        Me.chkActionsMsgBox.Location = New System.Drawing.Point(12, 92)
        Me.chkActionsMsgBox.Name = "chkActionsMsgBox"
        Me.chkActionsMsgBox.Size = New System.Drawing.Size(122, 17)
        Me.chkActionsMsgBox.TabIndex = 1
        Me.chkActionsMsgBox.Text = "Show Message box:"
        Me.chkActionsMsgBox.UseVisualStyleBackColor = true
        '
        'chkActionsProgram
        '
        Me.chkActionsProgram.AutoSize = true
        Me.chkActionsProgram.Location = New System.Drawing.Point(12, 19)
        Me.chkActionsProgram.Name = "chkActionsProgram"
        Me.chkActionsProgram.Size = New System.Drawing.Size(93, 17)
        Me.chkActionsProgram.TabIndex = 1
        Me.chkActionsProgram.Text = "Start Program:"
        Me.chkActionsProgram.UseVisualStyleBackColor = true
        '
        'chkActionsClose
        '
        Me.chkActionsClose.AutoSize = true
        Me.chkActionsClose.Location = New System.Drawing.Point(6, 212)
        Me.chkActionsClose.Name = "chkActionsClose"
        Me.chkActionsClose.Size = New System.Drawing.Size(112, 17)
        Me.chkActionsClose.TabIndex = 5
        Me.chkActionsClose.Text = "Close Port Actions"
        Me.chkActionsClose.UseVisualStyleBackColor = true
        '
        'grpActionsMsgBox
        '
        Me.grpActionsMsgBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActionsMsgBox.Controls.Add(Me.cbxActionsMsgBoxButtons)
        Me.grpActionsMsgBox.Controls.Add(Me.lblActionsMsgBoxButtons)
        Me.grpActionsMsgBox.Controls.Add(Me.cbxActionsMsgBoxStyle)
        Me.grpActionsMsgBox.Controls.Add(Me.lblActionsMsgBoxStyle)
        Me.grpActionsMsgBox.Controls.Add(Me.lblActionsMsgBoxText)
        Me.grpActionsMsgBox.Controls.Add(Me.txtActionsMsgBoxText)
        Me.grpActionsMsgBox.Enabled = false
        Me.grpActionsMsgBox.Location = New System.Drawing.Point(6, 92)
        Me.grpActionsMsgBox.Name = "grpActionsMsgBox"
        Me.grpActionsMsgBox.Size = New System.Drawing.Size(193, 91)
        Me.grpActionsMsgBox.TabIndex = 4
        Me.grpActionsMsgBox.TabStop = false
        '
        'cbxActionsMsgBoxButtons
        '
        Me.cbxActionsMsgBoxButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxActionsMsgBoxButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActionsMsgBoxButtons.FormattingEnabled = true
        Me.cbxActionsMsgBoxButtons.Items.AddRange(New Object() {"OK button only (default)", "OK and Cancel buttons", "Yes and No buttons", "Yes, No, and Cancel buttons", "Retry and Cancel buttons", "Abort, Retry, and Ignore buttons"})
        Me.cbxActionsMsgBoxButtons.Location = New System.Drawing.Point(50, 39)
        Me.cbxActionsMsgBoxButtons.Name = "cbxActionsMsgBoxButtons"
        Me.cbxActionsMsgBoxButtons.Size = New System.Drawing.Size(137, 21)
        Me.cbxActionsMsgBoxButtons.TabIndex = 7
        '
        'lblActionsMsgBoxButtons
        '
        Me.lblActionsMsgBoxButtons.AutoSize = true
        Me.lblActionsMsgBoxButtons.Location = New System.Drawing.Point(6, 42)
        Me.lblActionsMsgBoxButtons.Name = "lblActionsMsgBoxButtons"
        Me.lblActionsMsgBoxButtons.Size = New System.Drawing.Size(46, 13)
        Me.lblActionsMsgBoxButtons.TabIndex = 6
        Me.lblActionsMsgBoxButtons.Text = "Buttons:"
        '
        'cbxActionsMsgBoxStyle
        '
        Me.cbxActionsMsgBoxStyle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxActionsMsgBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActionsMsgBoxStyle.FormattingEnabled = true
        Me.cbxActionsMsgBoxStyle.Items.AddRange(New Object() {"None", "Error", "Warning", "Information", "Question"})
        Me.cbxActionsMsgBoxStyle.Location = New System.Drawing.Point(37, 62)
        Me.cbxActionsMsgBoxStyle.Name = "cbxActionsMsgBoxStyle"
        Me.cbxActionsMsgBoxStyle.Size = New System.Drawing.Size(150, 21)
        Me.cbxActionsMsgBoxStyle.TabIndex = 5
        '
        'lblActionsMsgBoxStyle
        '
        Me.lblActionsMsgBoxStyle.AutoSize = true
        Me.lblActionsMsgBoxStyle.Location = New System.Drawing.Point(6, 65)
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
        Me.txtActionsMsgBoxText.Location = New System.Drawing.Point(37, 17)
        Me.txtActionsMsgBoxText.Name = "txtActionsMsgBoxText"
        Me.txtActionsMsgBoxText.Size = New System.Drawing.Size(150, 20)
        Me.txtActionsMsgBoxText.TabIndex = 2
        '
        'grpActionsProgram
        '
        Me.grpActionsProgram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpActionsProgram.Controls.Add(Me.btnActionsProgramPuTTY)
        Me.grpActionsProgram.Controls.Add(Me.btnActionsProgramBrowse)
        Me.grpActionsProgram.Controls.Add(Me.txtActionsProgramArgs)
        Me.grpActionsProgram.Controls.Add(Me.lblActionsProgramArgs)
        Me.grpActionsProgram.Controls.Add(Me.lblActionsProgram)
        Me.grpActionsProgram.Controls.Add(Me.txtActionsProgram)
        Me.grpActionsProgram.Enabled = false
        Me.grpActionsProgram.Location = New System.Drawing.Point(6, 19)
        Me.grpActionsProgram.Name = "grpActionsProgram"
        Me.grpActionsProgram.Size = New System.Drawing.Size(193, 67)
        Me.grpActionsProgram.TabIndex = 3
        Me.grpActionsProgram.TabStop = false
        '
        'btnActionsProgramPuTTY
        '
        Me.btnActionsProgramPuTTY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnActionsProgramPuTTY.Image = CType(resources.GetObject("btnActionsProgramPuTTY.Image"),System.Drawing.Image)
        Me.btnActionsProgramPuTTY.Location = New System.Drawing.Point(164, 37)
        Me.btnActionsProgramPuTTY.Name = "btnActionsProgramPuTTY"
        Me.btnActionsProgramPuTTY.Size = New System.Drawing.Size(23, 23)
        Me.btnActionsProgramPuTTY.TabIndex = 7
        Me.btnActionsProgramPuTTY.UseVisualStyleBackColor = true
        '
        'btnActionsProgramBrowse
        '
        Me.btnActionsProgramBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnActionsProgramBrowse.Image = CType(resources.GetObject("btnActionsProgramBrowse.Image"),System.Drawing.Image)
        Me.btnActionsProgramBrowse.Location = New System.Drawing.Point(164, 15)
        Me.btnActionsProgramBrowse.Name = "btnActionsProgramBrowse"
        Me.btnActionsProgramBrowse.Size = New System.Drawing.Size(23, 23)
        Me.btnActionsProgramBrowse.TabIndex = 6
        Me.btnActionsProgramBrowse.UseVisualStyleBackColor = true
        '
        'txtActionsProgramArgs
        '
        Me.txtActionsProgramArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsProgramArgs.Location = New System.Drawing.Point(36, 39)
        Me.txtActionsProgramArgs.Name = "txtActionsProgramArgs"
        Me.txtActionsProgramArgs.Size = New System.Drawing.Size(128, 20)
        Me.txtActionsProgramArgs.TabIndex = 5
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
        'lblActionsProgram
        '
        Me.lblActionsProgram.AutoSize = true
        Me.lblActionsProgram.Location = New System.Drawing.Point(6, 20)
        Me.lblActionsProgram.Name = "lblActionsProgram"
        Me.lblActionsProgram.Size = New System.Drawing.Size(49, 13)
        Me.lblActionsProgram.TabIndex = 3
        Me.lblActionsProgram.Text = "Program:"
        '
        'txtActionsProgram
        '
        Me.txtActionsProgram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtActionsProgram.Location = New System.Drawing.Point(55, 17)
        Me.txtActionsProgram.Name = "txtActionsProgram"
        Me.txtActionsProgram.ReadOnly = true
        Me.txtActionsProgram.Size = New System.Drawing.Size(109, 20)
        Me.txtActionsProgram.TabIndex = 2
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStart.Location = New System.Drawing.Point(12, 504)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(59, 23)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = true
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(158, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(59, 23)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'selectProgramDialog
        '
        Me.selectProgramDialog.DefaultExt = "exe"
        Me.selectProgramDialog.Filter = "Executable files|*.exe; *.bat; *.com; *.vbs; *.mmc; *.js; *.cpl|All files|*.*"
        Me.selectProgramDialog.ReadOnlyChecked = true
        Me.selectProgramDialog.Title = "Select a program to start:"
        '
        'selectSoundDialog
        '
        Me.selectSoundDialog.DefaultExt = "wav"
        Me.selectSoundDialog.Filter = "WAVE Sound files|*.wav"
        Me.selectSoundDialog.ReadOnlyChecked = true
        '
        'btnExpand
        '
        Me.btnExpand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExpand.Location = New System.Drawing.Point(77, 504)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(75, 23)
        Me.btnExpand.TabIndex = 24
        Me.btnExpand.Text = "More Info..."
        Me.btnExpand.UseVisualStyleBackColor = true
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo.AutoEllipsis = true
        Me.lblInfo.Location = New System.Drawing.Point(12, 530)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(205, 39)
        Me.lblInfo.TabIndex = 25
        Me.lblInfo.Text = "Use {0} in any field and it will be replaced with the port that has had its statu"& _ 
        "s changed."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(444, 568)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(21, 9)
        Me.lblVersion.TabIndex = 26
        Me.lblVersion.Text = "1.0.0"
        '
        'PortActions
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(477, 578)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnExpand)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.grpChanges)
        Me.Controls.Add(Me.grpPorts)
        Me.Controls.Add(Me.lblCurrentPorts)
        Me.Controls.Add(Me.lstCurrentPorts)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "PortActions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Port Actions"
        Me.grpPorts.ResumeLayout(false)
        Me.grpPorts.PerformLayout
        Me.grpChanges.ResumeLayout(false)
        Me.grpChanges.PerformLayout
        Me.grpActions.ResumeLayout(false)
        Me.grpActions.PerformLayout
        Me.grpActionsSound.ResumeLayout(false)
        Me.grpActionsSound.PerformLayout
        Me.grpActionsMsgBox.ResumeLayout(false)
        Me.grpActionsMsgBox.PerformLayout
        Me.grpActionsProgram.ResumeLayout(false)
        Me.grpActionsProgram.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnExpand As System.Windows.Forms.Button
    Friend WithEvents selectSoundDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkActionsSound As System.Windows.Forms.CheckBox
    Friend WithEvents optActionsSoundFile As System.Windows.Forms.RadioButton
    Friend WithEvents optActionsSoundSystem As System.Windows.Forms.RadioButton
    Friend WithEvents txtActionsSoundFile As System.Windows.Forms.TextBox
    Friend WithEvents cbxActionsSoundSystem As System.Windows.Forms.ComboBox
    Friend WithEvents btnActionsSoundFile As System.Windows.Forms.Button
    Friend WithEvents grpActionsSound As System.Windows.Forms.GroupBox
    Friend WithEvents chkActionsStop As System.Windows.Forms.CheckBox
    Friend WithEvents selectProgramDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnActionsProgramBrowse As System.Windows.Forms.Button
    Friend WithEvents btnActionsProgramPuTTY As System.Windows.Forms.Button
    Friend WithEvents lblActionsMsgBoxButtons As System.Windows.Forms.Label
    Friend WithEvents cbxActionsMsgBoxButtons As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
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
    Friend WithEvents chkChangesRemember As System.Windows.Forms.CheckBox
    Friend WithEvents grpChanges As System.Windows.Forms.GroupBox
    Friend WithEvents optPortsAll As System.Windows.Forms.RadioButton
    Friend WithEvents optPortsSome As System.Windows.Forms.RadioButton
    Friend WithEvents txtPorts As System.Windows.Forms.TextBox
    Friend WithEvents grpPorts As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentPorts As System.Windows.Forms.Label
    Friend WithEvents timerPortChecker As System.Windows.Forms.Timer
    Friend WithEvents lstCurrentPorts As System.Windows.Forms.ListBox
End Class
