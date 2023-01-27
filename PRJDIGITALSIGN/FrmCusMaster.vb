Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class FrmCusMaster

   

    Private Sub FrmCusMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        btnmodify.Enabled = True
        loadcustomerdata()

    End Sub

    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click

        Try
            If TXTCUSTOMERCODE.Text = "" Then
                Exit Sub
            End If
            ds = New DataSet
            con = New OleDbConnection(GetConnection("Eprojects"))
            com.CommandText = "select [CustCode],[Custname],[Address] from CustomerMaster  where CustCode='" + Me.TXTCUSTOMERCODE.Text + "'"
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
                com.CommandText = String.Concat(New Object() {"INSERT INTO CustomerMaster([CustCode],[Custname],[Address])values ('", Me.TXTCUSTOMERCODE.Text, "','", Me.txtcustomername.Text, "','", Me.txtaddress.Text, "')"})
                com.CommandType = CommandType.Text
                com.Connection = con
                con.Open()
                com.ExecuteNonQuery()
                ClearControl()
                loadcustomerdata()
            Else
                MessageBox.Show("Customer Code Already taken", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
        End Try

    End Sub
    Public Sub loadcustomerdata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))
        com.CommandText = "select [CustCode],[Custname],[Address] from CustomerMaster   "
        com.CommandType = CommandType.Text
        com.Connection = con
        da = New OleDbDataAdapter(com)
        ds = New DataSet
        da.Fill(ds)
        Me.dgvcustomer.DataSource = (ds.Tables(0))
        com.CommandText = ""
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnmodify.Click
        Try

            If (TXTCUSTOMERCODE.Text = "") Then
                MessageBox.Show("Customer ID Required")
                Me.TXTCUSTOMERCODE.Focus()
            Else


                con = New OleDbConnection(GetConnection("Eprojects"))
                com.CommandText = String.Concat(New Object() {"Update CustomerMaster set  Custname='", Me.txtcustomername.Text, "',Address ='", Me.txtaddress.Text, "'  where CustCode='" + Me.TXTCUSTOMERCODE.Text + "'"})
                com.CommandType = CommandType.Text
                com.Connection = con
                con.Open()
                com.ExecuteNonQuery()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
                MessageBox.Show("Successfully saved", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.loadcustomerdata()
            End If
        Catch ex As Exception

        End Try

        
    End Sub


    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click
        ClearControl()
        frmCustomerview.Show()

        With frmCustomerview

            TXTCUSTOMERCODE.Text = Convert.ToString(frmCustomerview.dgv.CurrentRow.Cells(0).Value)
            txtcustomername.Text = Convert.ToString(frmCustomerview.dgv.CurrentRow.Cells(1).Value)
            txtaddress.Text = Convert.ToString(frmCustomerview.dgv.CurrentRow.Cells(2).Value)
        End With

    End Sub

    Private Sub dgvcustomer_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcustomer.CellClick
        Me.ClearControl()
        Try
            If (e.RowIndex <> -1) AndAlso (e.ColumnIndex <> -1) Then
                Me.TXTCUSTOMERCODE.Text = Convert.ToString(Me.dgvcustomer.CurrentRow.Cells(0).Value)
                Me.txtcustomername.Text = Convert.ToString(Me.dgvcustomer.CurrentRow.Cells(1).Value)
                Me.txtaddress.Text = Convert.ToString(Me.dgvcustomer.CurrentRow.Cells(2).Value)

                Me.btnmodify.Text = "Update"
                Me.btnDelete.Enabled = True


            End If
        Catch
            MessageBox.Show("Problem in selecting")
        End Try
    End Sub

    Private Sub ClearControl()
        txtaddress.Text = ""
        TXTCUSTOMERCODE.Text = ""
        txtcustomername.Text = ""
    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try

            Dim text As String = ""
            con = New OleDbConnection(GetConnection("Eprojects"))
            If ((Me.TXTCUSTOMERCODE.Text <> "")) Then
                ''MsgBox("Do you want to delete record(s)", MsgBoxStyle.YesNoCancel, "Confirm Delete")
                If MsgBox("Do you want to delete record(s)", MsgBoxStyle.YesNoCancel, "CUSTOMER") = MsgBoxResult.Yes Then
                    ' execute command


                    com.CommandText = String.Concat(New Object() {"DELETE from  CustomerMaster  where CustCode='" + Me.TXTCUSTOMERCODE.Text + "'"})


                    com.CommandType = CommandType.Text
                    com.Connection = con
                    con.Open()
                    com.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted ", " Profile", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MessageBox.Show(text)
                    Me.loadcustomerdata()
                    Me.ClearControl()
                End If

            Else
                MessageBox.Show("Employee Delete Failed")
            End If



        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.MsgBoxRight, " ")
        End Try
    End Sub

    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
        txtaddress.Text = ""
        TXTCUSTOMERCODE.Text = ""
        txtcustomername.Text = ""
    End Sub
End Class