Imports System.Text.RegularExpressions
Public Class frmEdit
    Public Shared Delay As Boolean = True
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If Delay = True Then
            If Not txtEdit.Text > 1 Then
                frmMain.lblDelay.Text = FormatNumber(txtEdit.Text, 3)
                frmMain.hScroll.Value = FormatNumber(txtEdit.Text * 1000, 3)
            Else
                MsgBox("Please enter a number no greater than 1 (up to 3 decimals).", MsgBoxStyle.Exclamation, "Number Too Large")
                Return
            End If
        Else
            If Not txtEdit.Text > 10 Then
                frmMain.Countdown = FormatNumber(txtEdit.Text, 3)
                frmMain.lblCount.Text = "Countdown:  " & frmMain.Countdown
            Else
                MsgBox("Please enter a number no greater than 10 (no decimals).", MsgBoxStyle.Exclamation, "Number Too Large")
                Return
            End If
        End If
        Close()
    End Sub
    Private Sub txtEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdit.KeyPress
        If Delay = True Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        Else
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnAccept.PerformClick()
        End If
    End Sub
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Delay = True Then txtEdit.MaxLength = 5 Else txtEdit.MaxLength = 2
    End Sub
End Class