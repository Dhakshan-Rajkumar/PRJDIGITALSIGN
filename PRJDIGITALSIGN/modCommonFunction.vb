Option Explicit On

#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Imports System.Math
#End Region

Module modCommonFunction

#Region "Global Declaration"
    Public msgboxTitle As String = "LS MILLS"
    Public MessageBoxMessage As String = "Can not leave mandatory field as blank"
#End Region

    Public Sub Show_Message(ByVal MessageBoxMessage As String, Optional ByVal MessageBoxTitle As String = Nothing)
        If MessageBoxTitle = Nothing Then
            MsgBox(MessageBoxMessage, MsgBoxStyle.Information, msgboxTitle)
        Else
            MsgBox(MessageBoxMessage, MsgBoxStyle.Information, MessageBoxTitle)
        End If
    End Sub
End Module



