Public Class FrmMdiMain

    Private Sub CustomerMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerMasterToolStripMenuItem.Click
        Dim cus As FrmCusMaster = New FrmCusMaster()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub TemplateMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateMasterToolStripMenuItem.Click
        Dim cus As FrmTemplateMaster = New FrmTemplateMaster()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub CustomerRecordsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerRecordsToolStripMenuItem.Click
        Dim cus As FrmCusRecords = New FrmCusRecords()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub TemplateRecordsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateRecordsToolStripMenuItem.Click
        Dim cus As FrmTemplateview = New FrmTemplateview()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub TemplateSelectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateSelectionToolStripMenuItem.Click
        Dim cus As FrmTemplateimageRecords = New FrmTemplateimageRecords()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BillingToolStripMenuItem.Click
        Dim cus As FrmCusMaster = New FrmCusMaster()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub TemplateVideoSelectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateVideoSelectionToolStripMenuItem.Click
        Dim cus As FrmTemplatevideosRecords = New FrmTemplatevideosRecords()
        cus.MdiParent = Me
        cus.WindowState = FormWindowState.Normal
        cus.Show()
    End Sub

    Private Sub FrmMdiMain_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub TemplateDigitalBoardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateDigitalBoardToolStripMenuItem.Click
        Dim temp As FrmTemplateDigitalBoard = New FrmTemplateDigitalBoard()
        temp.MdiParent = Me
        temp.WindowState = FormWindowState.Normal
        temp.Show()
    End Sub

    Private Sub TemplateNewsScrollingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateNewsScrollingToolStripMenuItem.Click
        Dim temp As FrmTemplatenewsscrolling = New FrmTemplatenewsscrolling()
        temp.MdiParent = Me
        temp.WindowState = FormWindowState.Normal
        temp.Show()
    End Sub

    Private Sub TemplateAnimationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateAnimationsToolStripMenuItem.Click
        Dim temp As FrmTemplateAnimationRecords = New FrmTemplateAnimationRecords()
        temp.MdiParent = Me
        temp.WindowState = FormWindowState.Normal
        temp.Show()
    End Sub

  

    Private Sub TemplateBrouchersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateBrouchersToolStripMenuItem.Click
        Dim temp As FrmTemplateBrouchersRecords = New FrmTemplateBrouchersRecords()
        temp.MdiParent = Me
        temp.WindowState = FormWindowState.Normal
        temp.Show()
    End Sub

    Private Sub TemplateVisitingCardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TemplateVisitingCardToolStripMenuItem.Click
        Dim temp As FrmTemplateVisitingcardsRecords = New FrmTemplateVisitingcardsRecords()
        temp.MdiParent = Me
        temp.WindowState = FormWindowState.Normal
        temp.Show()
    End Sub
End Class