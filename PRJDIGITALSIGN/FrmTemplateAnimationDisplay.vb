Imports System.Data.OleDb

Public Class FrmTemplateAnimationDisplay
    ''    Private animatedimage As New Bitmap("E:\LSM\2013\OLD\PLANET SOURCE CODE\Resources\vbnet\Animated\GIF Collection\art673.gif")
    Public animatedimage As Bitmap
    Public currentlyanimating As Boolean = True
  

    Private Sub FrmtemplateRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' animatedimage = New Bitmap("E:\LSM\2013\OLD\PLANET SOURCE CODE\Resources\vbnet\Animated\GIF Collection\art673.gif")
        startanimation()
        AnimateImage()


    End Sub

    Private Sub OnFrameChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Invalidate()
    End Sub

    Private Sub AnimateImage()

        If currentlyanimating = True Then
            ImageAnimator.Animate(animatedimage, AddressOf Me.OnFrameChanged)
            currentlyanimating = False
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        AnimateImage()
        ImageAnimator.UpdateFrames(animatedimage)
        '   e.Graphics.DrawImage(animatedimage, New Point((Me.Width / 4) + 40, (Me.Height / 4) + 40))
        e.Graphics.DrawImage(animatedimage, New Point(50, 50))


    End Sub

    Private Sub btnstart_Click(sender As System.Object, e As System.EventArgs) Handles btnstart.Click
        startanimation()

    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click
        currentlyanimating = False
        ImageAnimator.StopAnimate(animatedimage, AddressOf Me.OnFrameChanged)
        btnstart.Enabled = True
        BtnStop.Enabled = False
    End Sub

    Public Sub startanimation()
        currentlyanimating = True
        AnimateImage()
        btnstart.Enabled = False
        BtnStop.Enabled = True
    End Sub
    Public Sub stopanimation()
        currentlyanimating = False
        ImageAnimator.StopAnimate(animatedimage, AddressOf Me.OnFrameChanged)
        btnstart.Enabled = True
        BtnStop.Enabled = False
    End Sub

End Class