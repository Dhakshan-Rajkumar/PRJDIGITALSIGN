Option Explicit On

#Region "Imports"
Imports System
Imports System.Windows.Forms
Imports System.Threading
Imports System.Globalization
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
#End Region
Public Class Frmlogin

    Private Sub Frmlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnok_Click(sender As System.Object, e As System.EventArgs) Handles btnok.Click
        Try

            If txtusername.Text = "" Then
                MsgBox("Enter User Name.")
                txtusername.Focus()
            ElseIf txtpassword.Text = "" Then
                MsgBox("Enter Password.")
                txtpassword.Focus()
            End If
            If txtusername.Text = "ADMIN" And txtpassword.Text = "123" Then
                FrmMdiMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("User name and password does not match.", "Digital Sign", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub
End Class