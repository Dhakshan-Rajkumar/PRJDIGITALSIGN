Imports System.Data.OleDb

Public Class FrmTemplatevideosRecords
    Public Sub loaddata()
        ds = New DataSet
        con = New OleDbConnection(GetConnection("Eprojects"))

        com.CommandText = "select Temp_Code, Temp_name, Temp_type, Temp_location, Duration, ratepermts from Template_Master where Temp_type='VIDEOS' "

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
                FrmTemplatevideosDisplay.AxWindowsMediaPlayer1.Visible = False
                Dim cus As FrmTemplateimagedisplay = New FrmTemplateimagedisplay()
                cus.WindowState = FormWindowState.Normal
                cus.Show()
             
                cus.PictureBox1.Visible = True
                cus.lbltime.Visible = False
                cus.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                cus.PictureBox1.Image = Image.FromFile(Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value))
                cus.Show()
               
            ElseIf Me.dgv.CurrentRow.Cells(2).Value = "VIDEOS" Then
                FrmTemplatevideosDisplay.AxWindowsMediaPlayer1.Visible = False
                Dim cus As FrmTemplatevideosDisplay = New FrmTemplatevideosDisplay()
                cus.WindowState = FormWindowState.Normal
                cus.Show()

                cus.lbltime.Visible = False
                cus.AxWindowsMediaPlayer1.URL = Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value)
                cus.AxWindowsMediaPlayer1.Visible = True
                cus.AxWindowsMediaPlayer1.Ctlcontrols.play()
                While cus.AxWindowsMediaPlayer1.playState <> WMPLib.WMPPlayState.wmppsPlaying
                    Application.DoEvents()
                End While

                cus.AxWindowsMediaPlayer1.stretchToFit = True
                cus.AxWindowsMediaPlayer1.Width *= 2
                cus.AxWindowsMediaPlayer1.Height *= 2
                cus.AxWindowsMediaPlayer1.fullScreen = False
                cus.Show()
            End If

        Catch
            MessageBox.Show("Problem in selecting")
        End Try
        
    End Sub

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
  

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    End Sub

    
    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As System.Object, e As AxWMPLib._WMPOCXEvents_ClickEvent)
       
    End Sub
End Class