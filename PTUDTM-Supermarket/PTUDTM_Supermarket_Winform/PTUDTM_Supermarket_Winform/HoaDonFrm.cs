using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public partial class HoaDonFrm : Form
    {
        private PhieuBanHangService _PhieuBanHangService;
        private ChiTietHoaDonService _ChiTietHoaDonService;
        private KhachHangService _KhachHangService;
        private NhanVienService _NhanVienService;
        private SanPhamService _SanPhamService;
        public HoaDonFrm()
        {
            InitializeComponent();
            _PhieuBanHangService = new PhieuBanHangService();
            _ChiTietHoaDonService=new ChiTietHoaDonService();
            _KhachHangService=new KhachHangService();   
            _NhanVienService=new NhanVienService();
            _SanPhamService=new SanPhamService();
            Init();
        }
        private void Init()
        {
            dataGridViewDsHoaDon.DataSource = _PhieuBanHangService.GetAll();
            dataGridViewDsHoaDon.RowHeadersVisible = false;
            dataGridViewDsHoaDon.Columns["MaNhanVien"].Visible = false;
            dataGridViewDsHoaDon.Columns["GiamGia"].Visible = false;
            dataGridViewDsHoaDon.Columns["TongTien"].Visible = false;
            dataGridViewDsHoaDon.Columns["TienPhaiTra"].Visible = false;
            dataGridViewDsHoaDon.Columns["KhachHang"].Visible = false;
            dataGridViewDsHoaDon.Columns["NhanVien"].Visible = false;

            int width = dataGridViewDsHoaDon.Width;
            dataGridViewDsHoaDon.Columns["ID"].Width = (int)Math.Ceiling(width * 0.1);
            dataGridViewDsHoaDon.Columns["MaKhachHang"].Width= (int)Math.Ceiling(width * 0.25);
            dataGridViewDsHoaDon.Columns["NgayMua"].Width = (int)Math.Ceiling(width * 0.387);
            dataGridViewDsHoaDon.Columns["TrangThai"].Width = (int)Math.Ceiling(width * 0.25);
        }


        private void dataGridViewDsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex<dataGridViewDsHoaDon.RowCount)
            { 
                DataGridViewRow row = dataGridViewDsHoaDon.Rows[e.RowIndex];
                PhieuBanHang phieuBanHang = _PhieuBanHangService.GetOneById(int.Parse(row.Cells["ID"].Value.ToString()));
                if (phieuBanHang != null)
                {
                    KhachHang khachHang = _KhachHangService.getOneByID(int.Parse(row.Cells["MaKhachHang"].Value.ToString()));
                    NhanVien nhanVien = _NhanVienService.getOneByID(int.Parse(row.Cells["MaNhanVien"].Value.ToString()));

                    IdTextBox.Text = phieuBanHang.ID.ToString();
                    if (khachHang != null)
                    {
                        MaKhachHangTextBox.Text = khachHang.TenKhachHang + " (" + phieuBanHang.MaKhachHang.ToString() + ")";
                    }
                    if (nhanVien != null)
                    {
                        MaNhanVienTextBox.Text = nhanVien.TenNhanVien + " (" + nhanVien.MaNhanVien + ")";
                    }
                    NgayMuaTextBox.Text = phieuBanHang.NgayMua.ToString();
                    TongTienTextBox.Text = phieuBanHang.TongTien.ToString();
                    GiamGiaTextBox.Text = phieuBanHang.GiamGia.ToString();
                    TienPhaiTraTextBox.Text = phieuBanHang.TienPhaiTra.ToString();
                    if (phieuBanHang.TrangThai == true)
                    {
                        TrangThaiCheckBox.Checked = true;
                        TrangThaiCheckBox.Enabled = false;
                    }
                    else
                    {
                        TrangThaiCheckBox.Checked = false;
                        TrangThaiCheckBox.Enabled = true;
                    }

                    List<ChiTietHoaDon> chiTietHoaDons = _ChiTietHoaDonService.GetListByHoaDonId(phieuBanHang.ID);
                    if (chiTietHoaDons != null)
                    {
                        dataGridViewChiTieHoaDon.DataSource = chiTietHoaDons;
                        dataGridViewChiTieHoaDon.RowHeadersVisible = false;
                        dataGridViewChiTieHoaDon.Columns["PhieuBanHang"].Visible = false;
                        dataGridViewChiTieHoaDon.Columns["ID_PhieuBan"].Visible = false;

                        int width = dataGridViewChiTieHoaDon.Width;
                        dataGridViewChiTieHoaDon.Columns["ID"].Width = (int)Math.Ceiling(width * 0.09);
                        dataGridViewChiTieHoaDon.Columns["MaSanPham"].Width = (int)Math.Ceiling(width * 0.1);
                        dataGridViewChiTieHoaDon.Columns["Gia"].Width = (int)Math.Ceiling(width * 0.15);
                        dataGridViewChiTieHoaDon.Columns["SoLuong"].Width = (int)Math.Ceiling(width * 0.1);
                        dataGridViewChiTieHoaDon.Columns["GiaTriKhuyenMai"].Width = (int)Math.Ceiling(width * 0.15);
                        dataGridViewChiTieHoaDon.Columns["TongCong"].Width = (int)Math.Ceiling(width * 0.2);
                        dataGridViewChiTieHoaDon.Columns["SanPham"].Width = (int)Math.Ceiling(width * 0.2);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuBanHang phieuBanHang = _PhieuBanHangService.GetOneById(int.Parse(IdTextBox.Text.Trim()));
            if (phieuBanHang != null)
            {
                phieuBanHang.TrangThai = true;
                bool kq = _PhieuBanHangService.Update(phieuBanHang);
                if (kq == true)
                {
                    List<ChiTietHoaDon> ds = _ChiTietHoaDonService.GetListByHoaDonId(phieuBanHang.ID);
                    CapNhatSoLuongSanPham(ds);
                    MessageBox.Show("Đã xác nhận hóa đơn", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi xác nhận hóa đơn", "Thông báo");
                }
            }
        }

        private void CapNhatSoLuongSanPham(List<ChiTietHoaDon> ds)
        {
            if (ds != null)
            {
                bool kq = false;
                foreach (ChiTietHoaDon ct in ds)
                {
                    SanPham sp = _SanPhamService.getOneByID((int)ct.MaSanPham);
                    if (sp != null)
                    {
                        sp.SoLuongTon = sp.SoLuongTon - ct.SoLuong;
                        kq = _SanPhamService.update(sp);
                    }
                }
            }

        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            PhieuBanHang phieuBanHang = _PhieuBanHangService.GetOneById(int.Parse(TimKiemTextBox.Text.Trim()));
            if (phieuBanHang != null)
            {
                KhachHang khachHang = _KhachHangService.getOneByID((int)phieuBanHang.MaKhachHang);
                NhanVien nhanVien = _NhanVienService.getOneByID((int)phieuBanHang.MaNhanVien);

                IdTextBox.Text = phieuBanHang.ID.ToString();
                if (khachHang != null)
                {
                    MaKhachHangTextBox.Text = khachHang.TenKhachHang + " (" + phieuBanHang.MaKhachHang.ToString() + ")";
                }
                if (nhanVien != null)
                {
                    MaNhanVienTextBox.Text = nhanVien.TenNhanVien + " (" + nhanVien.MaNhanVien + ")";
                }
                NgayMuaTextBox.Text = phieuBanHang.NgayMua.ToString();
                TongTienTextBox.Text = phieuBanHang.TongTien.ToString();
                GiamGiaTextBox.Text = phieuBanHang.GiamGia.ToString();
                TienPhaiTraTextBox.Text = phieuBanHang.TienPhaiTra.ToString();
                if (phieuBanHang.TrangThai == true)
                {
                    TrangThaiCheckBox.Checked = true;
                    TrangThaiCheckBox.Enabled = false;
                }
                else
                {
                    TrangThaiCheckBox.Checked = false;
                    TrangThaiCheckBox.Enabled = true;
                }

                List<ChiTietHoaDon> chiTietHoaDons = _ChiTietHoaDonService.GetListByHoaDonId(phieuBanHang.ID);
                if (chiTietHoaDons != null)
                {
                    dataGridViewChiTieHoaDon.DataSource = chiTietHoaDons;
                    dataGridViewChiTieHoaDon.RowHeadersVisible = false;
                    dataGridViewChiTieHoaDon.Columns["PhieuBanHang"].Visible = false;
                    dataGridViewChiTieHoaDon.Columns["ID_PhieuBan"].Visible = false;

                    int width = dataGridViewChiTieHoaDon.Width;
                    dataGridViewChiTieHoaDon.Columns["ID"].Width = (int)Math.Ceiling(width * 0.09);
                    dataGridViewChiTieHoaDon.Columns["MaSanPham"].Width = (int)Math.Ceiling(width * 0.1);
                    dataGridViewChiTieHoaDon.Columns["Gia"].Width = (int)Math.Ceiling(width * 0.15);
                    dataGridViewChiTieHoaDon.Columns["SoLuong"].Width = (int)Math.Ceiling(width * 0.1);
                    dataGridViewChiTieHoaDon.Columns["GiaTriKhuyenMai"].Width = (int)Math.Ceiling(width * 0.15);
                    dataGridViewChiTieHoaDon.Columns["TongCong"].Width = (int)Math.Ceiling(width * 0.2);
                    dataGridViewChiTieHoaDon.Columns["SanPham"].Width = (int)Math.Ceiling(width * 0.2);
                }
            }
        }

        private void xuatHoaDonButton_Click(object sender, EventArgs e)
        {
            if (TrangThaiCheckBox.Checked == false)
            {
                PhieuBanHang phieuBanHang = _PhieuBanHangService.GetOneById(int.Parse(IdTextBox.Text.Trim()));
                if (phieuBanHang != null)
                {
                    bool kq = _PhieuBanHangService.Delete(phieuBanHang.ID);
                    if (kq == true)
                    {
                        MessageBox.Show("Đã xóa đơn đặt", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Lỗi xóa đơn đặt", "Thông báo");
                    }
                }
            }
        }
    }
}
