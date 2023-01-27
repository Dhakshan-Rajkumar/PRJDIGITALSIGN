Imports System.IO
Imports System.Data.OleDb

Public Class FrmTemplateMaster



    Private Sub btnbrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnbrowse.Click
        
        Openfile_Browse.Multiselect = False
        If cbxtemptype.Text = "IMAGES " Then
            Openfile_Browse.Filter = "Jpeg|*.jpg|Gif|*.gif|Jpeg|*.jpeg|Bitmap|*.bmp"
        ElseIf cbxtemptype.Text = "VIDEOS" Then
            ''Openfile_Browse.Filter = "IDEOS|All files (*.*)|*.*"
            Openfile_Browse.Filter = ""

        Else
            Openfile_Browse.Filter = ""
        End If
        Openfile_Browse.RestoreDirectory = True
        Openfile_Browse.Title = "Browse"
        If Openfile_Browse.ShowDialog <> DialogResult.Cancel Then
            txtlocation.Text = Openfile_Browse.FileName
            If cbxtemptype.Text = "IMAGES " Then
                PictureBox1.Image = Image.FromFile(Openfile_Browse.FileName)
            End If
            Openfile_Browse.Reset()

        End If
    End Sub

    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click

        Try
            If Txttempcode.Text = "" Then
                Exit Sub
            End If


            ds = New DataSet
            con = New OleDbConnection(GetConnection("Eprojects"))
            com.CommandText = "select [Temp_Code] from Template_Master  where [Temp_Code]='" + Me.Txttempcode.Text + "'"
            com.CommandType = CommandType.Text
            com.Connection = con
            da = New OleDbDataAdapter(com)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count <= 0 Then

                com = New OleDbCommand
                ds = New DataSet
                da = New OleDbDataAdapter
                con = New OleDbConnection(GetConnection("Eprojects"))

                com.CommandText = String.Concat(New Object() {"INSERT INTO [Template_Master]([Temp_Code] ,[Temp_name] ,[Temp_type],[Temp_location],[Duration] ,[ratepermts])values ('", Me.Txttempcode.Text, "','", Me.txttempname.Text, "','", Me.cbxtemptype.Text, "','", Me.txtlocation.Text, "','", Me.txtduration.Text, "','", Me.txtratemts.Text, "')"})
                com.CommandType = CommandType.Text
                com.Connection = con
                con.Open()
                com.ExecuteNonQuery()
                MessageBox.Show("Templater Master Inserted Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Templater Code Already Taken", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch

        End Try
    End Sub

    Private Sub btnmodify_Click(sender As System.Object, e As System.EventArgs) Handles btnmodify.Click
        Try

            If (Txttempcode.Text = "") Then
                MessageBox.Show("Template ID Required")
                Me.Txttempcode.Focus()
            Else


                con = New OleDbConnection(GetConnection("Eprojects"))
                com.CommandText = String.Concat(New Object() {"Update Template_Master set  [Temp_name]='", Me.Txttempcode.Text, "',[Temp_location] ='", Me.txtlocation.Text, "',Temp_type ='", Me.txtlocation.Text, "',[Temp_location] ='", Me.txtlocation.Text, "',Duration ='", Me.txtlocation.Text, "' ,ratepermts ='", Me.txtlocation.Text, "'   where [Temp_Code]='" + Me.Txttempcode.Text + "'"})
                com.CommandType = CommandType.Text
                com.Connection = con
                con.Open()
                com.ExecuteNonQuery()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
                MessageBox.Show("Successfully saved", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
        ClearControl()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try

            Dim text As String = ""
            con = New OleDbConnection(GetConnection("Eprojects"))
            If ((Me.Txttempcode.Text <> "")) Then
                ''MsgBox("Do you want to delete record(s)", MsgBoxStyle.YesNoCancel, "Confirm Delete")
                If MsgBox("Do you want to delete record(s)", MsgBoxStyle.YesNoCancel, "CUSTOMER") = MsgBoxResult.Yes Then
                    ' execute command

                    com.CommandText = String.Concat(New Object() {"DELETE from  [Template_Master]  where [Temp_Code]='" + Me.Txttempcode.Text + "'"})
                    com.CommandType = CommandType.Text
                    com.Connection = con
                    con.Open()
                    com.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted ", " Template", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show(text)
                    Me.ClearControl()
                End If

            Else
                MessageBox.Show("Employee Delete Failed")
            End If



        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.MsgBoxRight, " ")
        End Try
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btntemplate_Click(sender As System.Object, e As System.EventArgs) Handles Btntemplate.Click
        FrmTemplateview.Show()
       
        With FrmTemplateview
            Txttempcode.Text = Convert.ToString(FrmTemplateview.dgv.CurrentRow.Cells(0).Value)
            txttempname.Text = FrmTemplateview.dgv.CurrentRow.Cells(1).Value
            cbxtemptype.Text = Convert.ToString(FrmTemplateview.dgv.CurrentRow.Cells(2).Value)
            txtlocation.Text = Convert.ToString(FrmTemplateview.dgv.CurrentRow.Cells(3).Value)
            txtduration.Text = Convert.ToString(FrmTemplateview.dgv.CurrentRow.Cells(4).Value)
            txtratemts.Text = Convert.ToString(FrmTemplateview.dgv.CurrentRow.Cells(5).Value)

        End With
        ''FrmTemplateview.Hide()
    End Sub
    Private Sub ClearControl()
        txtduration.Text = ""
        txtlocation.Text = ""
        txtratemts.Text = ""
        Txttempcode.Text = ""
        txttempname.Text = ""
        cbxtemptype.Text = ""
    End Sub
End Class