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
            ' If (e.RowIndex <> -1) AndAlso (e.ColumnIndex <> -1) Then
            If Me.dgv.CurrentRow.Cells(2).Value = "Images" Then
                ''  Timer1.Stop()
                AxWindowsMediaPlayer1.Visible = True
                lbltime.Visible = False
            ElseIf Me.dgv.CurrentRow.Cells(2).Value = "VIDEOS" Then
                lbltime.Visible = False
                AxWindowsMediaPlayer1.URL = Convert.ToString(Me.dgv.CurrentRow.Cells(3).Value)
                AxWindowsMediaPlayer1.Visible = True
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                While AxWindowsMediaPlayer1.playState <> WMPLib.WMPPlayState.wmppsPlaying
                    Application.DoEvents()
                End While

                AxWindowsMediaPlayer1.stretchToFit = True
                AxWindowsMediaPlayer1.Width *= 2
                AxWindowsMediaPlayer1.Height *= 2
                AxWindowsMediaPlayer1.fullScreen = False
            End If

            '  End If
        Catch
            MessageBox.Show("Problem in selecting")
        End Try
    End Sub

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
        ''   lbltime.Text = ""
        lbltime.Text = "Digital Board-" + TimeOfDay.ToString("hh:mm:ss tt")
        AxWindowsMediaPlayer1.Visible = False
        Timer1.Interval = 500
        Timer1.Start()
    End Sub
  

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '  lbltime.Visible = Not lbltime.Visible
    End Sub

    
    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As System.Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            AxWindowsMediaPlayer1.settings.setMode("Loop", True)
            AxWindowsMediaPlayer1.URL = "wait2.JPG"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub
End Class