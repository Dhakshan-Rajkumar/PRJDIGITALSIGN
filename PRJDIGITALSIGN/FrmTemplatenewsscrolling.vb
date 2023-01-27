Imports System.Data.OleDb

Public Class FrmTemplatenewsscrolling
    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Btnscroll.Enabled = False
    End Sub
    

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
       
        Dim cardColor As Color = lblCardColor.BackColor

        Timer1.Interval = NumericUpDown1.Value
        lblDisplay.Text = txtnewstext.Text
        lblDisplay.ForeColor = cardColor
       
        lblDisplay.Left = lblDisplay.Left - 10
        If lblDisplay.Left < 0 - lblDisplay.Width Then
            lblDisplay.Left = Me.Width
        End If
    End Sub

    Private Sub txtnewstext_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnewstext.TextChanged
        If txtnewstext.Text.Trim() = "" Then
            Btnscroll.Enabled = False
        Else
            Btnscroll.Enabled = True
        End If
    End Sub

    Private Sub Btnscroll_Click(sender As System.Object, e As System.EventArgs) Handles Btnscroll.Click
        '   Btnscroll.Enabled = False
        Timer1.Enabled = True
        '  StartScroll()
    End Sub

    Private Sub StartScroll()
        Dim cardColor As Color = lblCardColor.BackColor
        Dim sb As New System.Text.StringBuilder(txtnewstext.Text & " ")
        Do
            Dim ch As Char = sb(sb.Length - 1)
            sb.Remove(sb.Length - 1, 1)
            sb.Insert(0, ch)
            lblDisplay.Text = sb.ToString()
            lblDisplay.ForeColor = cardColor
            lblDisplay.Refresh()
            System.Threading.Thread.Sleep(100)
        Loop
    End Sub

    Private Sub btnCardColor_Click(sender As System.Object, e As System.EventArgs) Handles btnCardColor.Click
        Dim cd As New ColorDialog()
        cd.Color = lblCardColor.BackColor
        ' cd.Color = Color.White


        If (cd.ShowDialog() = DialogResult.OK) Then
            lblCardColor.BackColor = cd.Color
            'Update card preview
            Timer1.Enabled = True
            '   StartScroll()
        End If
    End Sub
End Class