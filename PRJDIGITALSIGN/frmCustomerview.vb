Imports System.Data.OleDb

Public Class frmCustomerview

    Private Sub frmview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick

        ' If (e.RowIndex <> -1) AndAlso (e.ColumnIndex <> -1) Then
        With FrmCusMaster
            FrmCusMaster.TXTCUSTOMERCODE.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(0).Value)
            FrmCusMaster.txtcustomername.Text = Me.dgv.CurrentRow.Cells(1).Value
            FrmCusMaster.txtaddress.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(2).Value)



        End With
        Me.Hide()
        '   End If
    End Sub
End Class