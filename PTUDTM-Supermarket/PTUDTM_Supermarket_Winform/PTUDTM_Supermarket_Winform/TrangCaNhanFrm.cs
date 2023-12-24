using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PTUDTM_Supermarket_Winform.MainFrm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTUDTM_Supermarket_Winform
{
    public partial class TrangCaNhanFrm : Form
    {
        private NhanVien NHANVIEN;
        private NhanVienService _NhanVienService;
        private DataSetTaiKhoan _DataSetTaiKhoan;
        public TrangCaNhanFrm(string UserName)
        {
            InitializeComponent();
            _NhanVienService = new NhanVienService();
            _DataSetTaiKhoan = new DataSetTaiKhoan();
            NHANVIEN = _NhanVienService.getOneByTenDangNhap(UserName);
            if (NHANVIEN != null)
            {
                //mage image=new Image(new Size(200,200));
                string path = Application.StartupPath + "\\sanpham\\" + NHANVIEN.HinhAnh;
                if (File.Exists(path))
                    pictureBoxNhanVien.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\" + NHANVIEN.HinhAnh);
                else
                    pictureBoxNhanVien.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\h1.png");
                
                pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                MaNhanVienTextBox.Text = NHANVIEN.MaNhanVien.ToString();
                TenNhanVienTextBox.Text = NHANVIEN.TenNhanVien;


                NgaySinhTextBox.Value = (DateTime)NHANVIEN.NgaySinh;

                if (NHANVIEN.GioiTinh == true)
                    PhaiNamRadioButton.Checked = true;
                else
                    PhaiNuRadioButton.Checked = true;

                SoDienThoaiTextBox.Text = NHANVIEN.SoDienThoai;
                EmailTextBox.Text = NHANVIEN.Email;
                DiaChiTextBox.Text = NHANVIEN.DiaChi;
                LuongCoBanTextBox.Text = NHANVIEN.LuongCoBan.ToString();

                if (NHANVIEN.TenDangNhap != null)
                {
                    TenDangNhapTextBox.Text = NHANVIEN.TenDangNhap;
                    TaiKhoan tk = _DataSetTaiKhoan.GetOneByTenDangNhap(NHANVIEN.TenDangNhap);
                    MatKhauTextBox.PasswordChar = '*';
                    MatKhauTextBox.Text = tk.MatKhau;
                }
            }

        }

    }
}
