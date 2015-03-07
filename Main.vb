Option Explicit On
Public Class frmMain
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENT_LEFTDOWN = &H2
    Public Const MOUSEEVENT_LEFTUP = &H4
    Public Const MOUSEEVENT_MIDDLEDOWN = &H20
    Public Const MOUSEEVENT_MIDDLEUP = &H40
    Public Const MOUSEEVENT_RIGHTDOWN = &H8
    Public Const MOUSEEVENT_RIGHTUP = &H10
    Private Const WM_HOTKEY As Integer = &H312
    Private Declare Function RegisterHotKey Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Declare Function UnregisterHotKey Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal id As Integer) As Boolean
    Private Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Public Shared Countdown As Integer = 5
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterHotKey(Me.Handle, 0, Nothing, Keys.F9)
        ComboBox1.SelectedItem = "Left Mouse Button"
    End Sub
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnregisterHotKey(Me.Handle, 0)
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If (m.Msg = WM_HOTKEY AndAlso m.WParam = CType(0, IntPtr)) Then
            If btnStart.Enabled = True Then
                btnStart.PerformClick()
            Else
                btnStop.PerformClick()
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    Dim MsgBoxShown As Boolean
    Dim origCount As Integer = 5
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        If MsgBoxShown = False Then
            MsgBoxShown = True
            MsgBox("There will be a " & Countdown & " second countdown before the auto clicker activates. Use F9 to stop/start Auto Clicker.", MsgBoxStyle.Information, "Get Ready...")
        End If
        ComboBox1.Enabled = False
        origCount = Countdown
        lblCount.Text = "Countdown: " & Countdown
        hScroll.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ComboBox1.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        btnStart.Enabled = True
        hScroll.Enabled = True
        Countdown = origCount
        lblCount.Text = "Countdown: " & Countdown
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Countdown <> 0 Then
            Countdown -= 1
            lblCount.Text = "Countdown: " & Countdown
        Else
            Timer1.Interval = hScroll.Value
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub hScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hScroll.Scroll, hScroll.Scroll
        lblDelay.Text = FormatNumber(hScroll.Value / 1000, 3)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ComboBox1.SelectedItem = "Left Mouse Button" Then
            mouse_event(MOUSEEVENT_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENT_LEFTUP, 0, 0, 0, 0)
        ElseIf ComboBox1.SelectedItem = "Middle Mouse Button" Then
            mouse_event(MOUSEEVENT_MIDDLEDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENT_MIDDLEUP, 0, 0, 0, 0)
        ElseIf ComboBox1.SelectedItem = "Right Mouse Button" Then
            mouse_event(MOUSEEVENT_RIGHTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENT_RIGHTUP, 0, 0, 0, 0)
        End If
    End Sub
    Private Sub lblDelay_DoubleClick(sender As Object, e As EventArgs) Handles lblDelay.DoubleClick
        frmEdit.Delay = True
        frmEdit.txtEdit.Text = lblDelay.Text
        frmEdit.ShowDialog()
    End Sub
    Private Sub lblCount_DoubleClick(sender As Object, e As EventArgs) Handles lblCount.DoubleClick
        frmEdit.Delay = False
        frmEdit.txtEdit.Text = Countdown.ToString()
        frmEdit.ShowDialog()
    End Sub
End Class
