Imports System.Data.OleDb

Public Class FrmTemplateBrouchersdisplay


    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Visible = False
        Timer1.Interval = 500
        Timer1.Start()
        ''  StartScroll()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' lbltime.Visible = Not lbltime.Visible
        ' PictureBox1.Visible = Not PictureBox1.Visible
    End Sub
End Class