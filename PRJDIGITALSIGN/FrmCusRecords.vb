Imports System.Data.OleDb

Public Class FrmCusRecords

    Private Sub FrmCusRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))
        com.CommandText = "select [CustCode],[Custname],[Address] from CustomerMaster   "
        com.CommandType = CommandType.Text
        com.Connection = con
        da = New OleDbDataAdapter(com)
        ds = New DataSet
        da.Fill(ds)
        Me.dgv.DataSource = (ds.Tables(0))
        com.CommandText = ""

    End Sub
End Class