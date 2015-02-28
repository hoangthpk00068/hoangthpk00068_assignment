Public Class frm_login



    Private Sub bnt_ok_Click(sender As Object, e As EventArgs) Handles bnt_ok.Click
        If txt_pass.Text = "123456789" And txt_user.Text = "admin" Then
            frm_hethong.Show()
            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
        Else
            MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
    End Sub
    Private Sub Frmdangnhap_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frm_hethong.Show()
        Me.Hide()
    End Sub
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
