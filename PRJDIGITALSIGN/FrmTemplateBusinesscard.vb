Imports System.Data.OleDb

Imports System.Drawing

Imports Neodynamic.SDK

Public Class FrmTemplateBusinesscard
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set card color
        Me.lblCardColor.BackColor = Color.RoyalBlue
    End Sub


    Private Sub GenerateCard()

        'Get the info to create the business card
        Dim fullname As String = ""
        Dim jobtitle As String = ""
        Dim addressline1 As String = ""
        Dim addressline2 As String = ""
        Dim phone As String = ""
        Dim email As String = ""
        Dim logoFile As String = ""
        Dim layout As String = "Left"
        Dim cardColor As Color = lblCardColor.BackColor

        If Not (String.IsNullOrEmpty(txtFullName.Text)) Then
            fullname = txtFullName.Text
        End If
        If Not (String.IsNullOrEmpty(txtJobTitle.Text)) Then
            jobtitle = txtJobTitle.Text
        End If
        If Not (String.IsNullOrEmpty(txtAddressLine1.Text)) Then
            addressline1 = txtAddressLine1.Text
        End If
        If Not (String.IsNullOrEmpty(txtAddressLine2.Text)) Then
            addressline2 = txtAddressLine2.Text
        End If
        If Not (String.IsNullOrEmpty(txtPhone.Text)) Then
            phone = txtPhone.Text
        End If
        If Not (String.IsNullOrEmpty(txtEmail.Text)) Then
            email = txtEmail.Text
        End If
        If Not (Me.btnLogo.Tag Is Nothing) AndAlso Not (String.IsNullOrEmpty(Me.btnLogo.Tag.ToString())) Then
            logoFile = Me.btnLogo.Tag.ToString()
        End If
        If (rbRight.Checked) Then
            layout = "Right"
        End If


        'Create an instance of ImageDraw
        Dim imgDraw As New ImageDraw()
        'Basic settings for Business Card
        imgDraw.Canvas.AutoSize = False
        imgDraw.ImageFormat = ImageDrawFormat.Png
        'Set business card size
        imgDraw.Canvas.Width = 400
        imgDraw.Canvas.Height = 250

        'Create main decorative shape element
        Dim rect1 As New RectangleShapeElement()
        rect1.X = 10
        rect1.Y = 10
        rect1.Width = 380
        rect1.Height = 230

        rect1.Roundness = 20
        rect1.StrokeWidth = 0
        'Set background
        rect1.Fill.BackgroundColor = cardColor
        'Add element to output image
        imgDraw.Elements.Add(rect1)



        'Create top decorative shape element
        Dim rect2 As New RectangleShapeElement()
        rect2.X = 20
        rect2.Y = 20
        rect2.Width = 360
        rect2.Height = 170
        rect2.Roundness = 10
        rect2.StrokeWidth = 0
        rect2.Fill.BackgroundColor = Color.White
        'Add element to output image
        imgDraw.Elements.Add(rect2)

        'Create bottom decorative shape element
        Dim rect3 As New RectangleShapeElement()
        rect3.X = 30
        rect3.Y = 130
        rect3.Width = 340
        rect3.Height = 100
        rect3.Roundness = 10
        rect3.StrokeWidth = 1
        rect3.StrokeFill.BackgroundColor = cardColor
        rect3.Fill.BackgroundColor = Color.White
        'Add element to output image
        imgDraw.Elements.Add(rect3)


        'Create an ImageElement to wrap the user logo
        If (logoFile.Length > 0 AndAlso System.IO.File.Exists(logoFile)) Then

            Dim imgElemLogo As New ImageElement()
            'Get user logo from disk
            imgElemLogo.Source = ImageSource.File
            imgElemLogo.SourceFile = logoFile
            'Logo Layout
            If (layout = "Right") Then
                imgElemLogo.X = 40
                imgElemLogo.Y = 40

            Else

                imgElemLogo.X = 400 - (50 + 40) 'Canvas Width - (Logo Width + X Margin)
                imgElemLogo.Y = 40
            End If
            'Apply Resize logo
            Dim resizeLogo As New Resize()
            resizeLogo.Width = 50
            resizeLogo.LockAspectRatio = LockAspectRatio.WidthBased
            imgElemLogo.Actions.Clear()
            imgElemLogo.Actions.Add(resizeLogo)
            'Add element to output image
            imgDraw.Elements.Add(imgElemLogo)
        End If


        'Create TextElement objects for each fields

        'Full Name TextElement
        If (fullname.Length > 0) Then

            Dim txtElemName As New TextElement()
            txtElemName.AutoSize = False
            txtElemName.Font.Name = "Arial"
            txtElemName.Font.Size = 14.0F
            txtElemName.Font.Unit = FontUnit.Point
            txtElemName.Font.Bold = True
            txtElemName.ForeColor = System.Drawing.Color.Black
            txtElemName.Text = fullname
            txtElemName.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            txtElemName.X = 40
            txtElemName.Y = 40
            txtElemName.Width = 320
            txtElemName.Height = 20
            If (layout = "Left") Then
                txtElemName.TextAlignment = ContentAlignment.MiddleLeft
            Else
                txtElemName.TextAlignment = ContentAlignment.MiddleRight
            End If
            'Add element to output image
            imgDraw.Elements.Add(txtElemName)
        End If

        'Job Title TextElement
        If (jobtitle.Length > 0) Then

            Dim txtElemJob As New TextElement()
            txtElemJob.AutoSize = False
            txtElemJob.Font.Name = "Arial"
            txtElemJob.Font.Size = 10.0F
            txtElemJob.Font.Unit = FontUnit.Point
            txtElemJob.ForeColor = System.Drawing.Color.Black
            txtElemJob.Text = jobtitle
            txtElemJob.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias
            txtElemJob.X = 40
            txtElemJob.Y = 64
            txtElemJob.Width = 320
            txtElemJob.Height = 14
            If (layout = "Left") Then
                txtElemJob.TextAlignment = ContentAlignment.MiddleLeft
            Else
                txtElemJob.TextAlignment = ContentAlignment.MiddleRight
            End If
            'Add element to output image
            imgDraw.Elements.Add(txtElemJob)
        End If

        'Address Lines TextElement
        If (addressline1.Length > 0) Then

            Dim txtElemAddress As New TextElement()
            txtElemAddress.AutoSize = False
            txtElemAddress.Font.Name = "Times New Roman"
            txtElemAddress.Font.Italic = True
            txtElemAddress.Font.Size = 11.0F
            txtElemAddress.Font.Unit = FontUnit.Point
            txtElemAddress.ForeColor = System.Drawing.Color.Black
            txtElemAddress.Text = addressline1 + vbCrLf + addressline2
            txtElemAddress.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias
            txtElemAddress.X = 40
            txtElemAddress.Y = 130
            txtElemAddress.Width = 160
            txtElemAddress.Height = 50
            If (layout = "Left") Then
                txtElemAddress.TextAlignment = ContentAlignment.MiddleLeft
            Else
                txtElemAddress.TextAlignment = ContentAlignment.MiddleRight
            End If
            'Add element to output image
            imgDraw.Elements.Add(txtElemAddress)
        End If

        'Phone and Email TextElement
        If (phone.Length > 0 OrElse email.Length > 0) Then

            Dim txtElemPhone As New TextElement()
            txtElemPhone.AutoSize = False
            txtElemPhone.Font.Name = "Georgia"
            txtElemPhone.Font.Size = 10.0F
            txtElemPhone.Font.Unit = FontUnit.Point
            txtElemPhone.ForeColor = System.Drawing.Color.Black
            txtElemPhone.Text = "Phone: " + phone + vbCrLf + email
            txtElemPhone.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias
            txtElemPhone.X = 200
            txtElemPhone.Y = 180
            txtElemPhone.Width = 160
            txtElemPhone.Height = 50
            If (layout = "Right") Then
                txtElemPhone.TextAlignment = ContentAlignment.MiddleLeft
            Else
                txtElemPhone.TextAlignment = ContentAlignment.MiddleRight
            End If
            'Add element to output image
            imgDraw.Elements.Add(txtElemPhone)
        End If

        'generate image card and preview it
        picCardPreview.Image = imgDraw.GetOutputImage()

    End Sub

    Private Sub btnLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogo.Click

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"

        If (ofd.ShowDialog() = DialogResult.OK) Then
            btnLogo.Tag = ofd.FileName
            'Update card preview
            GenerateCard()
        End If

    End Sub

    Private Sub DataFields_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFullName.KeyUp, txtJobTitle.KeyUp, txtPhone.KeyUp, txtEmail.KeyUp, txtAddressLine2.KeyUp, txtAddressLine1.KeyUp
        'Update card preview
        GenerateCard()
    End Sub

    Private Sub Layout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLeft.CheckedChanged, rbRight.CheckedChanged
        'Update card preview
        Try
            GenerateCard()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCardColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCardColor.Click

        Dim cd As New ColorDialog()
        cd.Color = lblCardColor.BackColor

        If (cd.ShowDialog() = DialogResult.OK) Then
            lblCardColor.BackColor = cd.Color
            'Update card preview
            GenerateCard()
        End If

    End Sub
End Class