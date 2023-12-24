using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public partial class NewTaiKhoanFrm : Form
    {
        private DataSetTaiKhoan _DataSetTaiKhoan;
        private DataSetQLNhomNguoiDung _DataSetQLNhomNguoiDung;
        private DataSetNguoiDungNhomNguoiDung _DataSetNguoiDungNhomNguoiDung;
        private NhanVienService _NhanVienService;
        private int maNhanVien;
        private NhanVien nhanVien;
        public NewTaiKhoanFrm(int maNhanVien)
        {
            InitializeComponent();
            _DataSetTaiKhoan = new DataSetTaiKhoan();
            _DataSetQLNhomNguoiDung = new DataSetQLNhomNguoiDung();
            _DataSetNguoiDungNhomNguoiDung = new DataSetNguoiDungNhomNguoiDung();
            _NhanVienService=new NhanVienService();

            this.maNhanVien = maNhanVien;
            this.nhanVien = _NhanVienService.getOneByID(this.maNhanVien);

            LoaiTaiKhoanCombobox.DataSource = _DataSetQLNhomNguoiDung.GetAll();
            LoaiTaiKhoanCombobox.DisplayMember = "TenNhom";
            LoaiTaiKhoanCombobox.ValueMember = "MaNhom";
        }

        private void AddTaiKhoanBtn_Click(object sender, EventArgs e)
        {

            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = TenDangNhapTextBox.Text.Trim();
            taiKhoan.MatKhau = MatKhauTextBox.Text;
            taiKhoan.LoaiTaiKhoan = LoaiTaiKhoanCombobox.SelectedValue.ToString();
            if (TrangThaiTaiKhoanCheckBox.Checked == true)
                taiKhoan.TrangThai = true;
            else
                taiKhoan.TrangThai = false;

            if (IsEmptyString(taiKhoan.TenDangNhap) == false && IsEmptyString(taiKhoan.MatKhau) == false)
            {
                bool kq = _DataSetTaiKhoan.Insert(taiKhoan);
                if (kq == true)
                {
                    this.nhanVien.TenDangNhap = taiKhoan.TenDangNhap;
                    _NhanVienService.Update(this.nhanVien);
                    QL_NguoiDungNhomNguoiDung qL_NguoiDungNhomNguoiDung = new QL_NguoiDungNhomNguoiDung();
                    qL_NguoiDungNhomNguoiDung.MaNhomNguoiDung = taiKhoan.LoaiTaiKhoan;
                    qL_NguoiDungNhomNguoiDung.TenDangNhap = taiKhoan.TenDangNhap;
                    qL_NguoiDungNhomNguoiDung.GhiChu = "";
                    kq = _DataSetNguoiDungNhomNguoiDung.Insert(qL_NguoiDungNhomNguoiDung);
                    DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private bool IsEmptyString(string str)
        {
            if (str.Length <= 0)
                return true;
            else if (str.Equals(""))
                return true;
            else
                return false;
        }
    }
}
