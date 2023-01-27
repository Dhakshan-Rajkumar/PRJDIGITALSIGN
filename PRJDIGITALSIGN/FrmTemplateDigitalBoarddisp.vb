Imports System.Data.OleDb

Public Class FrmTemplateDigitalBoarddisp
    ' Dim mdigital As String = "Digital Board-" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")



    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''    mdigital = "Digital Board-" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")
        lbltime.Text = mdigital
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub
   
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbltime.Visible = Not lbltime.Visible
        lbltime.Text = mdigital

    End Sub
End Class