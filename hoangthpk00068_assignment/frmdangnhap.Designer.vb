<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.bnt_ok = New System.Windows.Forms.Button()
        Me.bnt_exit = New System.Windows.Forms.Button()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bnt_ok
        '
        Me.bnt_ok.Location = New System.Drawing.Point(251, 167)
        Me.bnt_ok.Name = "bnt_ok"
        Me.bnt_ok.Size = New System.Drawing.Size(94, 44)
        Me.bnt_ok.TabIndex = 0
        Me.bnt_ok.Text = "OK"
        Me.bnt_ok.UseVisualStyleBackColor = True
        '
        'bnt_exit
        '
        Me.bnt_exit.Location = New System.Drawing.Point(371, 167)
        Me.bnt_exit.Name = "bnt_exit"
        Me.bnt_exit.Size = New System.Drawing.Size(94, 44)
        Me.bnt_exit.TabIndex = 0
        Me.bnt_exit.Text = "Exit"
        Me.bnt_exit.UseVisualStyleBackColor = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(267, 55)
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(169, 29)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(267, 101)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(169, 29)
        Me.txt_pass.TabIndex = 1
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(195, 70)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(29, 13)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "User"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(195, 117)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(53, 13)
        Me.lbl_pass.TabIndex = 2
        Me.lbl_pass.Text = "Password"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 242)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.bnt_exit)
        Me.Controls.Add(Me.bnt_ok)
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_ok As System.Windows.Forms.Button
    Friend WithEvents bnt_exit As System.Windows.Forms.Button
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label

End Class
