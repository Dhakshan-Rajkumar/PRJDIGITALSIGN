Imports System.Data.OleDb

Public Class FrmTemplateimageRecords
    Public Sub loaddata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))

        com.CommandText = "select Temp_Code, Temp_name, Temp_type, Temp_location, Duration, ratepermts from Template_Master where Temp_type='IMAGES'  "


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
            If Me.dgv.CurrentRow.Cells(2).Value = "IMAGES" Then
                Dim cus As FrmTemplateimagedisplay = New FrmTemplateimagedisplay()
                cus.WindowState = FormWindowState.Normal
                cus.Show()

                cus.PictureBox1.Visible = True
                cus.lbltime.Visible = False
                cus.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                cus.PictureBox1.Image = Image.FromFile(Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value))

            ElseIf Me.dgv.CurrentRow.Cells(2).Value = "VIDEOS" Then
            End If

        Catch
            MessageBox.Show("Problem in selecting")
        End Try
    End Sub

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()

        Timer1.Interval = 500
        Timer1.Start()

    End Sub
   
   
End Class