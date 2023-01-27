Imports System.Data.OleDb

Public Class FrmTemplateDigitalBoard

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
  
    Private Sub btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnsubmit.Click

        FrmTemplateDigitalBoarddisp.Show()
        If TxtDisplay.Text = "" Then
            mdigital = "Digital Board-" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")
        Else

            With FrmTemplateDigitalBoarddisp
                mdigital = Trim(TxtDisplay.Text)
            End With

        End If
    End Sub
End Class