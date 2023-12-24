namespace PTUDTM_Supermarket_Winform
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnPhanQuyen = new CustomControll.ButtonControllMain();
            this.btnThongKe = new CustomControll.ButtonControllMain();
            this.btnQLKhachHang = new CustomControll.ButtonControllMain();
            this.btnQLNhanVien = new CustomControll.ButtonControllMain();
            this.btnHoaDon = new CustomControll.ButtonControllMain();
            this.btnNhapHang = new CustomControll.ButtonControllMain();
            this.btnAdmin = new CustomControll.ButtonControllMain();
            this.btnTrangCaNhan = new CustomControll.ButtonControllMain();
            this.btnQLKhuyenMai = new CustomControll.ButtonControllMain();
            this.btnQLSanPham = new CustomControll.ButtonControllMain();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Blue;
            this.pnLeft.Controls.Add(this.btnPhanQuyen);
            this.pnLeft.Controls.Add(this.btnThongKe);
            this.pnLeft.Controls.Add(this.btnQLKhachHang);
            this.pnLeft.Controls.Add(this.btnQLNhanVien);
            this.pnLeft.Controls.Add(this.btnHoaDon);
            this.pnLeft.Controls.Add(this.btnNhapHang);
            this.pnLeft.Controls.Add(this.btnAdmin);
            this.pnLeft.Controls.Add(this.btnTrangCaNhan);
            this.pnLeft.Controls.Add(this.btnQLKhuyenMai);
            this.pnLeft.Controls.Add(this.btnQLSanPham);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 743);
            this.pnLeft.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1013, 743);
            this.pnMain.TabIndex = 1;
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.BackColor = System.Drawing.Color.Blue;
            this.btnPhanQuyen.Flag = false;
            this.btnPhanQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanQuyen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanQuyen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPhanQuyen.Location = new System.Drawing.Point(8, 438);
            this.btnPhanQuyen.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(185, 51);
            this.btnPhanQuyen.TabIndex = 0;
            this.btnPhanQuyen.Tag = "PhanQuyenFrm";
            this.btnPhanQuyen.Text = "Phân quyền";
            this.btnPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanQuyen.UseVisualStyleBackColor = false;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Blue;
            this.btnThongKe.Flag = false;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThongKe.Location = new System.Drawing.Point(8, 388);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(185, 51);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Tag = "ThongKeFrm";
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.Blue;
            this.btnQLKhachHang.Flag = false;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKhachHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLKhachHang.Location = new System.Drawing.Point(8, 338);
            this.btnQLKhachHang.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(185, 51);
            this.btnQLKhachHang.TabIndex = 0;
            this.btnQLKhachHang.Tag = "KhachHangFrm";
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.Blue;
            this.btnQLNhanVien.Flag = false;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLNhanVien.Location = new System.Drawing.Point(8, 288);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(185, 51);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Tag = "NhanVienFrm";
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Blue;
            this.btnHoaDon.Flag = false;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHoaDon.Location = new System.Drawing.Point(8, 238);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(185, 51);
            this.btnHoaDon.TabIndex = 0;
            this.btnHoaDon.Text = "Quản lý hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.MediumBlue;
            this.btnNhapHang.Flag = false;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhapHang.Location = new System.Drawing.Point(8, 188);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(185, 51);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Tag = "NhapHangFrm";
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Blue;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Flag = false;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 51);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Tag = "AdminButton";
            this.btnAdmin.Text = "Admintrator";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTrangCaNhan
            // 
            this.btnTrangCaNhan.BackColor = System.Drawing.Color.Blue;
            this.btnTrangCaNhan.Flag = false;
            this.btnTrangCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangCaNhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangCaNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrangCaNhan.Location = new System.Drawing.Point(8, 538);
            this.btnTrangCaNhan.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnTrangCaNhan.Name = "btnTrangCaNhan";
            this.btnTrangCaNhan.Size = new System.Drawing.Size(185, 51);
            this.btnTrangCaNhan.TabIndex = 0;
            this.btnTrangCaNhan.Tag = "TrangCaNhanFrm";
            this.btnTrangCaNhan.Text = "Trang cá nhân";
            this.btnTrangCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangCaNhan.UseVisualStyleBackColor = false;
            this.btnTrangCaNhan.Click += new System.EventHandler(this.btnTrangCaNhan_Click);
            // 
            // btnQLKhuyenMai
            // 
            this.btnQLKhuyenMai.BackColor = System.Drawing.Color.Blue;
            this.btnQLKhuyenMai.Flag = false;
            this.btnQLKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhuyenMai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKhuyenMai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLKhuyenMai.Location = new System.Drawing.Point(8, 488);
            this.btnQLKhuyenMai.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnQLKhuyenMai.Name = "btnQLKhuyenMai";
            this.btnQLKhuyenMai.Size = new System.Drawing.Size(185, 51);
            this.btnQLKhuyenMai.TabIndex = 0;
            this.btnQLKhuyenMai.Text = "Quản lý khuyến mãi";
            this.btnQLKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhuyenMai.UseVisualStyleBackColor = false;
            this.btnQLKhuyenMai.Click += new System.EventHandler(this.btnQLKhuyenMai_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.BackColor = System.Drawing.Color.Blue;
            this.btnQLSanPham.Flag = false;
            this.btnQLSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSanPham.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLSanPham.Location = new System.Drawing.Point(8, 138);
            this.btnQLSanPham.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.Size = new System.Drawing.Size(185, 51);
            this.btnQLSanPham.TabIndex = 0;
            this.btnQLSanPham.Tag = "QLSanPhamFrm";
            this.btnQLSanPham.Text = "Quản lý sản phẩm";
            this.btnQLSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSanPham.UseVisualStyleBackColor = false;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1213, 743);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MinimumSize = new System.Drawing.Size(1231, 650);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnMain;
        private CustomControll.ButtonControllMain btnQLSanPham;
        private CustomControll.ButtonControllMain btnThongKe;
        private CustomControll.ButtonControllMain btnQLNhanVien;
        private CustomControll.ButtonControllMain btnNhapHang;
        private CustomControll.ButtonControllMain btnAdmin;
        private CustomControll.ButtonControllMain btnPhanQuyen;
        private CustomControll.ButtonControllMain btnQLKhachHang;
        private CustomControll.ButtonControllMain btnHoaDon;
        private CustomControll.ButtonControllMain btnTrangCaNhan;
        private CustomControll.ButtonControllMain btnQLKhuyenMai;
    }
}