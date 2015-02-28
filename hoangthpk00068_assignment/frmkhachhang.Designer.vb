<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.lstkh = New System.Windows.Forms.ListView()
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_tenkh = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_gioitinh = New System.Windows.Forms.TextBox()
        Me.txt_sdt = New System.Windows.Forms.TextBox()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ngaysinh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstkh
        '
        Me.lstkh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idkh, Me.tenkh, Me.gioitinh, Me.ngaysinh, Me.email, Me.diachi, Me.sdt})
        Me.lstkh.FullRowSelect = True
        Me.lstkh.GridLines = True
        Me.lstkh.Location = New System.Drawing.Point(406, 38)
        Me.lstkh.Name = "lstkh"
        Me.lstkh.Size = New System.Drawing.Size(469, 253)
        Me.lstkh.TabIndex = 0
        Me.lstkh.UseCompatibleStateImageBehavior = False
        Me.lstkh.View = System.Windows.Forms.View.Details
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'tenkh
        '
        Me.tenkh.Text = "Tên KH"
        '
        'gioitinh
        '
        Me.gioitinh.Text = "Giới Tinh"
        '
        'ngaysinh
        '
        Me.ngaysinh.Text = "Ngay Sinh"
        Me.ngaysinh.Width = 82
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 64
        '
        'diachi
        '
        Me.diachi.DisplayIndex = 6
        Me.diachi.Text = "Dia Chi"
        '
        'sdt
        '
        Me.sdt.DisplayIndex = 5
        Me.sdt.Text = "SDT"
        Me.sdt.Width = 62
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(64, 42)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 1
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(259, 42)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(100, 20)
        Me.txt_diachi.TabIndex = 1
        '
        'txt_tenkh
        '
        Me.txt_tenkh.Location = New System.Drawing.Point(64, 96)
        Me.txt_tenkh.Name = "txt_tenkh"
        Me.txt_tenkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_tenkh.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(259, 96)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 1
        '
        'txt_gioitinh
        '
        Me.txt_gioitinh.Location = New System.Drawing.Point(64, 153)
        Me.txt_gioitinh.Name = "txt_gioitinh"
        Me.txt_gioitinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_gioitinh.TabIndex = 1
        '
        'txt_sdt
        '
        Me.txt_sdt.Location = New System.Drawing.Point(259, 153)
        Me.txt_sdt.Name = "txt_sdt"
        Me.txt_sdt.Size = New System.Drawing.Size(100, 20)
        Me.txt_sdt.TabIndex = 1
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(37, 238)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 2
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(142, 238)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 2
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(248, 238)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 2
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(13, 42)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_idkh.TabIndex = 3
        Me.lbl_idkh.Text = "ID KH"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(12, 96)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(44, 13)
        Me.lbl_tenkh.TabIndex = 3
        Me.lbl_tenkh.Text = "Tên KH"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(12, 160)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gioitinh.TabIndex = 3
        Me.lbl_gioitinh.Text = "Giới Tính"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(196, 99)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 3
        Me.lbl_email.Text = "Email"
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(196, 160)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(29, 13)
        Me.lbl_sdt.TabIndex = 3
        Me.lbl_sdt.Text = "SDT"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(196, 42)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(41, 13)
        Me.lbl_diachi.TabIndex = 3
        Me.lbl_diachi.Text = "Địa Chỉ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ngay Sinh"
        '
        'txt_ngaysinh
        '
        Me.txt_ngaysinh.Location = New System.Drawing.Point(64, 205)
        Me.txt_ngaysinh.Name = "txt_ngaysinh"
        Me.txt_ngaysinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngaysinh.TabIndex = 4
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 322)
        Me.Controls.Add(Me.txt_ngaysinh)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_sdt)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_gioitinh)
        Me.Controls.Add(Me.txt_tenkh)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_idkh)
        Me.Controls.Add(Me.lstkh)
        Me.Name = "frmkhachhang"
        Me.Text = "Khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstkh As System.Windows.Forms.ListView
    Friend WithEvents idkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents gioitinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents sdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_idkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents txt_tenkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_gioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txt_sdt As System.Windows.Forms.TextBox
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents diachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_ngaysinh As System.Windows.Forms.TextBox
End Class
