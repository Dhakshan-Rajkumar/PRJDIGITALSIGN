Imports System.Data.OleDb

Public Class FrmTemplateAnimationRecords
    Public Sub loaddata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))
        com.CommandText = "select Temp_Code, Temp_name, Temp_type, Temp_location, Duration, ratepermts from Template_Master where Temp_type='ANIMATIONS'   "
        com.CommandType = CommandType.Text
        com.Connection = con
        da = New OleDbDataAdapter(com)
        ds = New DataSet
        da.Fill(ds)
        Me.dgv.DataSource = (ds.Tables(0))
        com.CommandText = ""

    End Sub

    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try

            If Me.dgv.CurrentRow.Cells(2).Value = "ANIMATIONS" Then
                Dim cus As FrmTemplateAnimationDisplay = New FrmTemplateAnimationDisplay()
                cus.WindowState = FormWindowState.Normal

                cus.animatedimage = New Bitmap((Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value)))
                cus.startanimation()

                cus.Show()
            ElseIf Me.dgv.CurrentRow.Cells(2).Value = "VIDEOS" Then
            End If
        Catch
            MessageBox.Show("Problem in selecting")
        End Try
    End Sub

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
         End Sub
  
    Private Sub OnFrameChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Invalidate()
    End Sub
End Class