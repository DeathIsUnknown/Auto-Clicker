<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.hScroll = New System.Windows.Forms.HScrollBar()
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(215, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(99, 24)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start Clicking"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(215, 58)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(99, 24)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "S&top Clicking"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'hScroll
        '
        Me.hScroll.Location = New System.Drawing.Point(9, 9)
        Me.hScroll.Maximum = 1000
        Me.hScroll.Minimum = 1
        Me.hScroll.Name = "hScroll"
        Me.hScroll.Size = New System.Drawing.Size(268, 17)
        Me.hScroll.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.hScroll, "Delay between clicks (lower is faster)...")
        Me.hScroll.Value = 10
        '
        'lblDelay
        '
        Me.lblDelay.Location = New System.Drawing.Point(280, 11)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDelay.Size = New System.Drawing.Size(34, 15)
        Me.lblDelay.TabIndex = 5
        Me.lblDelay.Text = "0.001"
        Me.ToolTip1.SetToolTip(Me.lblDelay, "Double click to edit manually...")
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Left Mouse Button", "Middle Mouse Button", "Right Mouse Button"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(12, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(197, 23)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "Countdown: 5"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCount, "Double click to edit manually...")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 90)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblDelay)
        Me.Controls.Add(Me.hScroll)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Clicker v2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents hScroll As System.Windows.Forms.HScrollBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblDelay As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label

End Class
