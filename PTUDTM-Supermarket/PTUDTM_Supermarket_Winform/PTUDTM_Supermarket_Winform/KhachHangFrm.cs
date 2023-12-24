using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public partial class KhachHangFrm : Form
    {
        private KhachHangService _KhachHangService;
        private PhieuBanHangService _PhieuBanService;
        public KhachHangFrm()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService(); 
            _PhieuBanService = new PhieuBanHangService();
            Init();
        }

        private void Init()
        {
            dataGridViewKhachHang.DataSource = _KhachHangService.GetAll();
            dataGridViewKhachHang.Columns["MaKhachHang"].Visible = false;
            dataGridViewKhachHang.Columns["GioiTinh"].Visible = false;
            dataGridViewKhachHang.Columns["DiaChi"].Visible = false;
            dataGridViewKhachHang.Columns["MatKhau"].Visible = false;
            int width = dataGridViewKhachHang.Width;
            dataGridViewKhachHang.Columns["TenKhachHang"].Width = (int)Math.Ceiling(width * 0.5); 
            dataGridViewKhachHang.Columns["SoDienThoai"].Width = (int)Math.Ceiling(width * 0.32);

        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex<dataGridViewKhachHang.RowCount)
            {
                DataGridViewRow row = dataGridViewKhachHang.Rows[e.RowIndex]; //.SelectedRows[e.RowIndex];
                KhachHang kh=new KhachHang();
                kh.MaKhachHang =int.Parse(row.Cells["MaKhachHang"].Value.ToString());
                kh.TenKhachHang = row.Cells["TenKhachHang"].Value.ToString();
                kh.GioiTinh = (bool) row.Cells["GioiTinh"].Value;
                kh.DiaChi = row.Cells["DiaChi"].Value.ToString();
                kh.SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                kh.MatKhau = row.Cells["MatKhau"].Value.ToString();

                MaKhachHangTextBox.Text=kh.MaKhachHang.ToString();
                TenKhachHangTextBox.Text = kh.TenKhachHang;
                DiaChiTextBox.Text=kh.DiaChi;
                SoDienThoaiTextBox.Text=kh.SoDienThoai;
                MatKhauTextBox.PasswordChar = '*';
                MatKhauTextBox.Text=kh.MatKhau;

                if(kh.GioiTinh==true)
                    PhaiNamRadioButton.Checked = true;
                else
                    PhaiNuRadioButton.Checked = true;

                dataGridViewPhieuBan.DataSource = _PhieuBanService.GetListByKhachHangId(kh.MaKhachHang);
                int width = dataGridViewPhieuBan.Width;
                dataGridViewPhieuBan.Columns["ID"].Width = (int)Math.Ceiling(width * 0.05);
                dataGridViewPhieuBan.Columns["NgayMua"].Width = (int)Math.Ceiling(width * 0.2);
                dataGridViewPhieuBan.Columns["MaNhanVien"].Width = (int)Math.Ceiling(width * 0.1);
                dataGridViewPhieuBan.Columns["TongTien"].Width = (int)Math.Ceiling(width * 0.2);
                dataGridViewPhieuBan.Columns["GiamGia"].Width = (int)Math.Ceiling(width * 0.1);
                dataGridViewPhieuBan.Columns["TienPhaiTra"].Width = (int)Math.Ceiling(width * 0.185);
                dataGridViewPhieuBan.Columns["TrangThai"].Width = (int)Math.Ceiling(width * 0.1);
                dataGridViewPhieuBan.Columns["MaKhachHang"].Visible = false;
                dataGridViewPhieuBan.Columns["KhachHang"].Visible = false;
                dataGridViewPhieuBan.Columns["NhanVien"].Visible = false;

            }
        }
    }
}
