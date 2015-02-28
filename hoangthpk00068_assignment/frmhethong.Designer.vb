<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hethong
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuanLyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DangNhapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoaiSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThanhToanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTietHoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanLyToolStripMenuItem, Me.KhachHangToolStripMenuItem, Me.SanPhamToolStripMenuItem, Me.LoaiSanPhamToolStripMenuItem, Me.ThanhToanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuanLyToolStripMenuItem
        '
        Me.QuanLyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangNhapToolStripMenuItem, Me.ThoatToolStripMenuItem})
        Me.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        Me.QuanLyToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.QuanLyToolStripMenuItem.Text = "quan ly"
        '
        'DangNhapToolStripMenuItem
        '
        Me.DangNhapToolStripMenuItem.Name = "DangNhapToolStripMenuItem"
        Me.DangNhapToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DangNhapToolStripMenuItem.Text = "Dang nhap"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.KhachHangToolStripMenuItem.Text = "khach hang"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SanPhamToolStripMenuItem.Text = "San Pham"
        '
        'LoaiSanPhamToolStripMenuItem
        '
        Me.LoaiSanPhamToolStripMenuItem.Name = "LoaiSanPhamToolStripMenuItem"
        Me.LoaiSanPhamToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.LoaiSanPhamToolStripMenuItem.Text = "loai san pham"
        '
        'ThanhToanToolStripMenuItem
        '
        Me.ThanhToanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoaDonToolStripMenuItem, Me.ChiTietHoaDonToolStripMenuItem})
        Me.ThanhToanToolStripMenuItem.Name = "ThanhToanToolStripMenuItem"
        Me.ThanhToanToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ThanhToanToolStripMenuItem.Text = "Thanh Toan"
        '
        'HoaDonToolStripMenuItem
        '
        Me.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem"
        Me.HoaDonToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HoaDonToolStripMenuItem.Text = "Hoa Don"
        '
        'ChiTietHoaDonToolStripMenuItem
        '
        Me.ChiTietHoaDonToolStripMenuItem.Name = "ChiTietHoaDonToolStripMenuItem"
        Me.ChiTietHoaDonToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ChiTietHoaDonToolStripMenuItem.Text = "Chi Tiet Hoa Don"
        '
        'frm_hethong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 300)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_hethong"
        Me.Text = "Hệ Thống"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DangNhapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoaiSanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThanhToanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoaDonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiTietHoaDonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuanLyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
