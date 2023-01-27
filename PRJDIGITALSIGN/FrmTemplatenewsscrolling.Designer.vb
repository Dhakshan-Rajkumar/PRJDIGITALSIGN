<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTemplatenewsscrolling
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTemplatenewsscrolling))
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtnewstext = New System.Windows.Forms.TextBox()
        Me.Btnscroll = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCardColor = New System.Windows.Forms.Button()
        Me.lblCardColor = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.White
        Me.lbltime.Font = New System.Drawing.Font("Budmo Jiggler", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Red
        Me.lbltime.Location = New System.Drawing.Point(26, 34)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(0, 57)
        Me.lbltime.TabIndex = 6
        '
        'Timer1
        '
        '
        'txtnewstext
        '
        Me.txtnewstext.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewstext.Location = New System.Drawing.Point(233, 23)
        Me.txtnewstext.Name = "txtnewstext"
        Me.txtnewstext.Size = New System.Drawing.Size(289, 39)
        Me.txtnewstext.TabIndex = 8
        '
        'Btnscroll
        '
        Me.Btnscroll.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnscroll.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnscroll.Location = New System.Drawing.Point(252, 178)
        Me.Btnscroll.Name = "Btnscroll"
        Me.Btnscroll.Size = New System.Drawing.Size(101, 45)
        Me.Btnscroll.TabIndex = 9
        Me.Btnscroll.Text = "Scroll"
        Me.Btnscroll.UseVisualStyleBackColor = False
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(238, 353)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(164, 35)
        Me.lblDisplay.TabIndex = 10
        Me.lblDisplay.Text = "lblDisplay"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(233, 68)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 38)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCardColor)
        Me.GroupBox1.Controls.Add(Me.lblCardColor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Btnscroll)
        Me.GroupBox1.Controls.Add(Me.txtnewstext)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 267)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Enter The Word"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "News  Speed"
        '
        'btnCardColor
        '
        Me.btnCardColor.Location = New System.Drawing.Point(60, 124)
        Me.btnCardColor.Name = "btnCardColor"
        Me.btnCardColor.Size = New System.Drawing.Size(184, 36)
        Me.btnCardColor.TabIndex = 15
        Me.btnCardColor.Text = "Select Color..."
        Me.btnCardColor.UseVisualStyleBackColor = True
        '
        'lblCardColor
        '
        Me.lblCardColor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCardColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCardColor.Location = New System.Drawing.Point(18, 124)
        Me.lblCardColor.Name = "lblCardColor"
        Me.lblCardColor.Size = New System.Drawing.Size(36, 36)
        Me.lblCardColor.TabIndex = 14
        '
        'FrmTemplatenewsscrolling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 397)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lblDisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTemplatenewsscrolling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template News Scrolling"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtnewstext As System.Windows.Forms.TextBox
    Friend WithEvents Btnscroll As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnCardColor As System.Windows.Forms.Button
    Private WithEvents lblCardColor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
