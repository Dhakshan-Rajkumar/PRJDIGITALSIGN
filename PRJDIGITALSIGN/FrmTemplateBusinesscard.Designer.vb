<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTemplateBusinesscard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTemplateBusinesscard))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.btnCardColor = New System.Windows.Forms.Button()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbRight = New System.Windows.Forms.RadioButton()
        Me.rbLeft = New System.Windows.Forms.RadioButton()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblCardColor = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.picCardPreview = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox3.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.picCardPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(118, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(240, 23)
        Me.txtEmail.TabIndex = 14
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(118, 185)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(240, 23)
        Me.txtPhone.TabIndex = 13
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.Location = New System.Drawing.Point(118, 156)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(240, 23)
        Me.txtAddressLine2.TabIndex = 12
        '
        'btnCardColor
        '
        Me.btnCardColor.Location = New System.Drawing.Point(102, 25)
        Me.btnCardColor.Name = "btnCardColor"
        Me.btnCardColor.Size = New System.Drawing.Size(184, 36)
        Me.btnCardColor.TabIndex = 1
        Me.btnCardColor.Text = "Select Color..."
        Me.btnCardColor.UseVisualStyleBackColor = True
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.Location = New System.Drawing.Point(118, 127)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(240, 23)
        Me.txtAddressLine1.TabIndex = 11
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(118, 98)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(240, 23)
        Me.txtJobTitle.TabIndex = 10
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(118, 69)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(240, 23)
        Me.txtFullName.TabIndex = 9
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.rbRight)
        Me.groupBox3.Controls.Add(Me.rbLeft)
        Me.groupBox3.Location = New System.Drawing.Point(18, 252)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(340, 63)
        Me.groupBox3.TabIndex = 8
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Card Layout"
        '
        'rbRight
        '
        Me.rbRight.AutoSize = True
        Me.rbRight.Location = New System.Drawing.Point(220, 30)
        Me.rbRight.Name = "rbRight"
        Me.rbRight.Size = New System.Drawing.Size(55, 20)
        Me.rbRight.TabIndex = 1
        Me.rbRight.Text = "Right"
        Me.rbRight.UseVisualStyleBackColor = True
        '
        'rbLeft
        '
        Me.rbLeft.AutoSize = True
        Me.rbLeft.Checked = True
        Me.rbLeft.Location = New System.Drawing.Point(81, 30)
        Me.rbLeft.Name = "rbLeft"
        Me.rbLeft.Size = New System.Drawing.Size(47, 20)
        Me.rbLeft.TabIndex = 0
        Me.rbLeft.TabStop = True
        Me.rbLeft.Text = "Left"
        Me.rbLeft.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 159)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(97, 16)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Address Line 2:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Full Name:"
        '
        'btnLogo
        '
        Me.btnLogo.Location = New System.Drawing.Point(118, 37)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(240, 23)
        Me.btnLogo.TabIndex = 1
        Me.btnLogo.Text = "..."
        Me.btnLogo.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Company Logo:"
        '
        'lblCardColor
        '
        Me.lblCardColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCardColor.Location = New System.Drawing.Point(60, 25)
        Me.lblCardColor.Name = "lblCardColor"
        Me.lblCardColor.Size = New System.Drawing.Size(36, 36)
        Me.lblCardColor.TabIndex = 0
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(15, 217)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(44, 16)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Email:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(15, 188)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 16)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Phone:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 130)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Address Line 1:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 101)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Job Title:"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 102)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
        Me.splitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(6)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.groupBox2)
        Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(6)
        Me.splitContainer1.Size = New System.Drawing.Size(807, 547)
        Me.splitContainer1.SplitterDistance = 349
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 7
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.groupBox4)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.txtPhone)
        Me.groupBox1.Controls.Add(Me.txtAddressLine2)
        Me.groupBox1.Controls.Add(Me.txtAddressLine1)
        Me.groupBox1.Controls.Add(Me.txtJobTitle)
        Me.groupBox1.Controls.Add(Me.txtFullName)
        Me.groupBox1.Controls.Add(Me.groupBox3)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btnLogo)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(6, 6)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.groupBox1.Size = New System.Drawing.Size(337, 535)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Business Card Design"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.btnCardColor)
        Me.groupBox4.Controls.Add(Me.lblCardColor)
        Me.groupBox4.Location = New System.Drawing.Point(18, 321)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(340, 72)
        Me.groupBox4.TabIndex = 15
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Card Color"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.picCardPreview)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(6, 6)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.groupBox2.Size = New System.Drawing.Size(441, 535)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Business Card Preview"
        '
        'picCardPreview
        '
        Me.picCardPreview.BackColor = System.Drawing.Color.White
        Me.picCardPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCardPreview.Location = New System.Drawing.Point(12, 28)
        Me.picCardPreview.Name = "picCardPreview"
        Me.picCardPreview.Size = New System.Drawing.Size(417, 495)
        Me.picCardPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCardPreview.TabIndex = 0
        Me.picCardPreview.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(807, 102)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'FrmTemplateBusinesscard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 649)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTemplateBusinesscard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template Business Cards"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.picCardPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Private WithEvents btnCardColor As System.Windows.Forms.Button
    Private WithEvents txtAddressLine1 As System.Windows.Forms.TextBox
    Private WithEvents txtJobTitle As System.Windows.Forms.TextBox
    Private WithEvents txtFullName As System.Windows.Forms.TextBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents rbRight As System.Windows.Forms.RadioButton
    Private WithEvents rbLeft As System.Windows.Forms.RadioButton
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnLogo As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblCardColor As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents picCardPreview As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
End Class
