<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethd
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
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_tensp = New System.Windows.Forms.TextBox()
        Me.txt_ngayxuat = New System.Windows.Forms.TextBox()
        Me.txt_idcthd = New System.Windows.Forms.TextBox()
        Me.lstcthd = New System.Windows.Forms.ListView()
        Me.idcthd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.soluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(198, 147)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(37, 13)
        Me.lbl_sdt.TabIndex = 29
        Me.lbl_sdt.Text = "ID HĐ"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(198, 86)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 30
        Me.lbl_email.Text = "Mo Ta"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(12, 147)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(53, 13)
        Me.lbl_gioitinh.TabIndex = 31
        Me.lbl_gioitinh.Text = "Số Lượng"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(14, 83)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(43, 13)
        Me.lbl_tenkh.TabIndex = 32
        Me.lbl_tenkh.Text = "Tên SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(198, 29)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(57, 13)
        Me.lbl_diachi.TabIndex = 33
        Me.lbl_diachi.Text = "Ngày Xuất"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(15, 29)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idkh.TabIndex = 34
        Me.lbl_idkh.Text = "ID CTHD"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(247, 215)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 26
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(141, 215)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 27
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(36, 215)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 28
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(261, 140)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idhd.TabIndex = 20
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(261, 83)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(100, 20)
        Me.txt_mota.TabIndex = 21
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(66, 140)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(100, 20)
        Me.txt_soluong.TabIndex = 22
        '
        'txt_tensp
        '
        Me.txt_tensp.Location = New System.Drawing.Point(66, 83)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(100, 20)
        Me.txt_tensp.TabIndex = 23
        '
        'txt_ngayxuat
        '
        Me.txt_ngayxuat.Location = New System.Drawing.Point(261, 29)
        Me.txt_ngayxuat.Name = "txt_ngayxuat"
        Me.txt_ngayxuat.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngayxuat.TabIndex = 24
        '
        'txt_idcthd
        '
        Me.txt_idcthd.Location = New System.Drawing.Point(66, 29)
        Me.txt_idcthd.Name = "txt_idcthd"
        Me.txt_idcthd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idcthd.TabIndex = 25
        '
        'lstcthd
        '
        Me.lstcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idcthd, Me.tensp, Me.soluong, Me.ngayxuat, Me.mota, Me.idhd})
        Me.lstcthd.FullRowSelect = True
        Me.lstcthd.GridLines = True
        Me.lstcthd.Location = New System.Drawing.Point(426, 29)
        Me.lstcthd.Name = "lstcthd"
        Me.lstcthd.Size = New System.Drawing.Size(408, 182)
        Me.lstcthd.TabIndex = 19
        Me.lstcthd.UseCompatibleStateImageBehavior = False
        Me.lstcthd.View = System.Windows.Forms.View.Details
        '
        'idcthd
        '
        Me.idcthd.Text = "ID CTHD"
        '
        'tensp
        '
        Me.tensp.Text = "Tên SP"
        '
        'soluong
        '
        Me.soluong.Text = "Số Lượng"
        '
        'ngayxuat
        '
        Me.ngayxuat.Text = "Ngày Xuất"
        Me.ngayxuat.Width = 75
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        Me.idhd.Width = 67
        '
        'frmchitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 336)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_idhd)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.txt_tensp)
        Me.Controls.Add(Me.txt_ngayxuat)
        Me.Controls.Add(Me.txt_idcthd)
        Me.Controls.Add(Me.lstcthd)
        Me.Name = "frmchitiethd"
        Me.Text = "Chi Tiết Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_idhd As System.Windows.Forms.TextBox
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents txt_soluong As System.Windows.Forms.TextBox
    Friend WithEvents txt_tensp As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngayxuat As System.Windows.Forms.TextBox
    Friend WithEvents txt_idcthd As System.Windows.Forms.TextBox
    Friend WithEvents lstcthd As System.Windows.Forms.ListView
    Friend WithEvents idcthd As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents soluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents idhd As System.Windows.Forms.ColumnHeader
End Class
