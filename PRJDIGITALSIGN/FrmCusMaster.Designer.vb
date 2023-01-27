<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCusMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.TXTCUSTOMERCODE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvcustomer = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtcustomername)
        Me.GroupBox1.Controls.Add(Me.TXTCUSTOMERCODE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Master"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.PRJDIGITALSIGN.My.Resources.Resources.find
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.Location = New System.Drawing.Point(438, 30)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(32, 32)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(190, 92)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(231, 83)
        Me.txtaddress.TabIndex = 5
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(190, 59)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(231, 22)
        Me.txtcustomername.TabIndex = 4
        '
        'TXTCUSTOMERCODE
        '
        Me.TXTCUSTOMERCODE.Location = New System.Drawing.Point(190, 30)
        Me.TXTCUSTOMERCODE.Name = "TXTCUSTOMERCODE"
        Me.TXTCUSTOMERCODE.Size = New System.Drawing.Size(231, 22)
        Me.TXTCUSTOMERCODE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER CODE"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnDelete)
        Me.GroupBox8.Controls.Add(Me.btnclose)
        Me.GroupBox8.Controls.Add(Me.btnclear)
        Me.GroupBox8.Controls.Add(Me.btnmodify)
        Me.GroupBox8.Controls.Add(Me.btnnew)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(542, 62)
        Me.GroupBox8.TabIndex = 29
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvcustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 233)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'dgvcustomer
        '
        Me.dgvcustomer.AllowUserToAddRows = False
        Me.dgvcustomer.AllowUserToDeleteRows = False
        Me.dgvcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcustomer.Location = New System.Drawing.Point(3, 18)
        Me.dgvcustomer.MultiSelect = False
        Me.dgvcustomer.Name = "dgvcustomer"
        Me.dgvcustomer.Size = New System.Drawing.Size(530, 212)
        Me.dgvcustomer.TabIndex = 31
        '
        'FrmCusMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(587, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCusMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvcustomer As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Public WithEvents txtaddress As System.Windows.Forms.TextBox
    Public WithEvents txtcustomername As System.Windows.Forms.TextBox
    Public WithEvents TXTCUSTOMERCODE As System.Windows.Forms.TextBox
End Class
