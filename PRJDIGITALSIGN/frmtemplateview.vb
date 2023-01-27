Imports System.Data.OleDb

Public Class FrmTemplateview

    Private Sub frmview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))

        com.CommandText = "select Temp_Code, Temp_name, Temp_type, Temp_location, Duration, ratepermts from Template_Master   "


        com.CommandType = CommandType.Text
        com.Connection = con
        da = New OleDbDataAdapter(com)
        ds = New DataSet
        da.Fill(ds)
        Me.dgv.DataSource = (ds.Tables(0))

        com.CommandText = ""
       

    End Sub

    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        
        With FrmTemplateMaster
          
            FrmTemplateMaster.Txttempcode.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(0).Value)
            FrmTemplateMaster.txttempname.Text = Me.dgv.CurrentRow.Cells(1).Value
            FrmTemplateMaster.cbxtemptype.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(2).Value)
            FrmTemplateMaster.txtlocation.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value)
            FrmTemplateMaster.txtduration.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(4).Value)
            FrmTemplateMaster.txtratemts.Text = Convert.ToString(Me.dgv.CurrentRow.Cells(5).Value)

        End With
        Me.Hide()
    End Sub
End Class