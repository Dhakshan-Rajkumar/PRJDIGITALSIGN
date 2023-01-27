Option Explicit On
#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Module modVariables

    Public mvarCompanyCode As String
    Public mvarCompanyName As String
    Public mvarUserID As String
    Public mvarFinYearCode As String
    Public mvarFinYearDate As String
    Public mvarLocationCode As String
    Public mvarLocationName As String
    Public mvarModuleName As String
    Public mvarServerDate As String
    Public mvarLanguageCode As String
    Public mvarLanguageDesc As String
    Public SSQL As String
    Public xyz As String
    Public mvarProdLocation As String
    Public mvarProductCode As String
    Public mvarApplicationType As String
    'Public mvarReportPath As String = Application.StartupPath
    Public mvarIsAdmin As Boolean

    Public mvarFinYearStartDate As Date
    Public mvarFinYearEndDate As Date
    Public getrecordchoice As String
    Public mReturnValue As String

    Public con As New OleDbConnection
    Public da As New OleDbDataAdapter
    Public com As New OleDbCommand
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public dt As New DataTable
    Public cnn As New OleDb.OleDbConnection
    Public dtPickList As New DataTable
    Public thisConnnection As New OleDbConnection
    Public thisDataAdapter As New OleDbDataAdapter
    Public thisCommand As New OleDbCommand
    Public thisTransaction As OleDbTransaction
    Public mDataRow As DataRow
    Public mRowCount As Double
    Public mdigital As String = "Digital Board-" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")
    Public Declare Unicode Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringW" _
        (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, _
         ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32

    'Public mvarReportPath As String = "\\lsmb\clients\TexOne\"
    ''Public mvarReportPath As String = "\\HPML350\softwares\TexOne\"
    Public mvarReportPath As String = Application.StartupPath

End Module

