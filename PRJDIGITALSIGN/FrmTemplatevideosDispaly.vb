Imports System.Data.OleDb

Public Class FrmTemplatevideosDisplay
   

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
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