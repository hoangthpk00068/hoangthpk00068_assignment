<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_ngayxuat = New System.Windows.Forms.TextBox()
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.txt_idsp = New System.Windows.Forms.TextBox()
        Me.txt_tongtien = New System.Windows.Forms.TextBox()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.lsthd = New System.Windows.Forms.ListView()
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tongtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(197, 111)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 20
        Me.lbl_email.Text = "Mô Tả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ngày Xuất"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(13, 172)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_gioitinh.TabIndex = 18
        Me.lbl_gioitinh.Text = "ID KH"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(13, 108)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(35, 13)
        Me.lbl_tenkh.TabIndex = 17
        Me.lbl_tenkh.Text = "ID SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(197, 54)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(56, 13)
        Me.lbl_diachi.TabIndex = 16
        Me.lbl_diachi.Text = "Tổng Tiền"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(14, 54)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(37, 13)
        Me.lbl_idkh.TabIndex = 15
        Me.lbl_idkh.Text = "ID HĐ"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(249, 250)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 14
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(143, 250)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 13
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(38, 250)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 12
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(260, 108)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(100, 20)
        Me.txt_mota.TabIndex = 9
        '
        'txt_ngayxuat
        '
        Me.txt_ngayxuat.Location = New System.Drawing.Point(65, 214)
        Me.txt_ngayxuat.Name = "txt_ngayxuat"
        Me.txt_ngayxuat.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngayxuat.TabIndex = 8
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(65, 165)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 7
        '
        'txt_idsp
        '
        Me.txt_idsp.Location = New System.Drawing.Point(65, 108)
        Me.txt_idsp.Name = "txt_idsp"
        Me.txt_idsp.Size = New System.Drawing.Size(100, 20)
        Me.txt_idsp.TabIndex = 6
        '
        'txt_tongtien
        '
        Me.txt_tongtien.Location = New System.Drawing.Point(260, 54)
        Me.txt_tongtien.Name = "txt_tongtien"
        Me.txt_tongtien.Size = New System.Drawing.Size(100, 20)
        Me.txt_tongtien.TabIndex = 5
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(65, 54)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idhd.TabIndex = 11
        '
        'lsthd
        '
        Me.lsthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idhd, Me.idsp, Me.idkh, Me.ngayxuat, Me.tongtien, Me.mota})
        Me.lsthd.FullRowSelect = True
        Me.lsthd.GridLines = True
        Me.lsthd.Location = New System.Drawing.Point(407, 50)
        Me.lsthd.Name = "lsthd"
        Me.lsthd.Size = New System.Drawing.Size(469, 253)
        Me.lsthd.TabIndex = 4
        Me.lsthd.UseCompatibleStateImageBehavior = False
        Me.lsthd.View = System.Windows.Forms.View.Details
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        '
        'idsp
        '
        Me.idsp.Text = "ID SP"
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'ngayxuat
        '
        Me.ngayxuat.Text = "Ngày Xuất"
        Me.ngayxuat.Width = 82
        '
        'tongtien
        '
        Me.tongtien.Text = "Tổng Tiền"
        Me.tongtien.Width = 64
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 437)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_ngayxuat)
        Me.Controls.Add(Me.txt_idkh)
        Me.Controls.Add(Me.txt_idsp)
        Me.Controls.Add(Me.txt_tongtien)
        Me.Controls.Add(Me.txt_idhd)
        Me.Controls.Add(Me.lsthd)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngayxuat As System.Windows.Forms.TextBox
    Friend WithEvents txt_idkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_idsp As System.Windows.Forms.TextBox
    Friend WithEvents txt_tongtien As System.Windows.Forms.TextBox
    Friend WithEvents txt_idhd As System.Windows.Forms.TextBox
    Friend WithEvents lsthd As System.Windows.Forms.ListView
    Friend WithEvents idhd As System.Windows.Forms.ColumnHeader
    Friend WithEvents idsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents idkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents tongtien As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
End Class
