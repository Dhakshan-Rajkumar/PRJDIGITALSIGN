<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTemplateAnimationDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTemplateAnimationDisplay))
        Me.btnstart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(214, 254)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(75, 51)
        Me.btnstart.TabIndex = 5
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'BtnStop
        '
        Me.BtnStop.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Location = New System.Drawing.Point(305, 254)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 51)
        Me.BtnStop.TabIndex = 6
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = False
        '
        'FrmTemplateAnimationDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 317)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.btnstart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTemplateAnimationDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template Images Records"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
End Class
