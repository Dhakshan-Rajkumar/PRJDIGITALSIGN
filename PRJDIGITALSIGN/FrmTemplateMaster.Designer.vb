<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTemplateMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTemplateMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxtemptype = New System.Windows.Forms.ComboBox()
        Me.txtratemts = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtduration = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttempname = New System.Windows.Forms.TextBox()
        Me.Txttempcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Openfile_Browse = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.Btntemplate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cbxtemptype)
        Me.GroupBox1.Controls.Add(Me.btnbrowse)
        Me.GroupBox1.Controls.Add(Me.Btntemplate)
        Me.GroupBox1.Controls.Add(Me.txtratemts)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtduration)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttempname)
        Me.GroupBox1.Controls.Add(Me.Txttempcode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 257)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Template Master"
        '
        'cbxtemptype
        '
        Me.cbxtemptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtemptype.FormattingEnabled = True
        Me.cbxtemptype.Items.AddRange(New Object() {"IMAGES", "VIDEOS", "ANIMATIONS", "BROUCHERS", "VISITING CARDS"})
        Me.cbxtemptype.Location = New System.Drawing.Point(190, 89)
        Me.cbxtemptype.Name = "cbxtemptype"
        Me.cbxtemptype.Size = New System.Drawing.Size(231, 22)
        Me.cbxtemptype.TabIndex = 14
        '
        'txtratemts
        '
        Me.txtratemts.Location = New System.Drawing.Point(190, 188)
        Me.txtratemts.Multiline = True
        Me.txtratemts.Name = "txtratemts"
        Me.txtratemts.Size = New System.Drawing.Size(231, 23)
        Me.txtratemts.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "RATE PER MINs"
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(190, 156)
        Me.txtduration.Multiline = True
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(231, 23)
        Me.txtduration.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DURATION"
        '
        'txtlocation
        '
        Me.txtlocation.Location = New System.Drawing.Point(190, 126)
        Me.txtlocation.Multiline = True
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.ReadOnly = True
        Me.txtlocation.Size = New System.Drawing.Size(231, 23)
        Me.txtlocation.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LOCATION"
        '
        'txttempname
        '
        Me.txttempname.Location = New System.Drawing.Point(190, 59)
        Me.txttempname.Name = "txttempname"
        Me.txttempname.Size = New System.Drawing.Size(231, 22)
        Me.txttempname.TabIndex = 4
        '
        'Txttempcode
        '
        Me.Txttempcode.Location = New System.Drawing.Point(190, 30)
        Me.Txttempcode.Name = "Txttempcode"
        Me.Txttempcode.Size = New System.Drawing.Size(231, 22)
        Me.Txttempcode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TEMPLATE TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TEMPLATE NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEMPLATE CODE"
        '
        'Openfile_Browse
        '
        Me.Openfile_Browse.FileName = "Openfile_Browse"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnDelete)
        Me.GroupBox8.Controls.Add(Me.btnclose)
        Me.GroupBox8.Controls.Add(Me.btnclear)
        Me.GroupBox8.Controls.Add(Me.btnmodify)
        Me.GroupBox8.Controls.Add(Me.btnnew)
        Me.GroupBox8.Location = New System.Drawing.Point(29, 288)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(542, 62)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(327, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 40)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(427, 14)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(94, 40)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(227, 15)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(94, 40)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(115, 15)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(94, 40)
        Me.btnmodify.TabIndex = 2
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(15, 15)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(94, 40)
        Me.btnnew.TabIndex = 1
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(486, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 69)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackgroundImage = Global.PRJDIGITALSIGN.My.Resources.Resources.folder_open
        Me.btnbrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbrowse.Location = New System.Drawing.Point(443, 119)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(32, 32)
        Me.btnbrowse.TabIndex = 13
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'Btntemplate
        '
        Me.Btntemplate.BackgroundImage = Global.PRJDIGITALSIGN.My.Resources.Resources.find
        Me.Btntemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btntemplate.Location = New System.Drawing.Point(443, 30)
        Me.Btntemplate.Name = "Btntemplate"
        Me.Btntemplate.Size = New System.Drawing.Size(32, 32)
        Me.Btntemplate.TabIndex = 12
        Me.Btntemplate.UseVisualStyleBackColor = True
        '
        'FrmTemplateMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(577, 380)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTemplateMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btntemplate As System.Windows.Forms.Button
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents Openfile_Browse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents txttempname As System.Windows.Forms.TextBox
    Public WithEvents Txttempcode As System.Windows.Forms.TextBox
    Public WithEvents txtratemts As System.Windows.Forms.TextBox
    Public WithEvents txtduration As System.Windows.Forms.TextBox
    Public WithEvents txtlocation As System.Windows.Forms.TextBox
    Public WithEvents cbxtemptype As System.Windows.Forms.ComboBox
End Class
