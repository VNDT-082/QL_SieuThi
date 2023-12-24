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
    public partial class NhaCungCapFrm : Form
    {
        private NhaCungCapService _NhaCungCapService;
        private NhaCungCap nhaCungCap;
        public NhaCungCapFrm(NhaCungCap nhaCungCap)
        {
            InitializeComponent();
            _NhaCungCapService=new NhaCungCapService();
            this.nhaCungCap = nhaCungCap;
            Load(this.nhaCungCap);
        }
        private void Load(NhaCungCap nhaCungCap)
        {
            MaNhaCungCapTextBox.Text = nhaCungCap.MaNhanCungCap.ToString();
            TenNhaCungCapTextBox.Text = nhaCungCap.TenNhaCungCap;
            DiaChiTextBox.Text= nhaCungCap.DiaChi;
            SoDienThoaiTextBox.Text = nhaCungCap.SoDienThoai.ToString();
            EmailTextBox.Text = nhaCungCap.Email;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCap newNCC=new NhaCungCap();
            newNCC.MaNhanCungCap = 0;
            newNCC.TenNhaCungCap = TenNhaCungCapTextBox.Text ;
            newNCC.DiaChi = DiaChiTextBox.Text ;
            newNCC.SoDienThoai = Decimal.Parse(SoDienThoaiTextBox.Text);
            newNCC.Email = EmailTextBox.Text ;
            bool kq = _NhaCungCapService.Insert(newNCC);
            if (kq==true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhaCungCap newNCC = new NhaCungCap();
            newNCC.MaNhanCungCap = int.Parse(MaNhaCungCapTextBox.Text.Trim());
            newNCC.TenNhaCungCap = TenNhaCungCapTextBox.Text;
            newNCC.DiaChi = DiaChiTextBox.Text;
            newNCC.SoDienThoai = Decimal.Parse(SoDienThoaiTextBox.Text);
            newNCC.Email = EmailTextBox.Text;
            bool kq = _NhaCungCapService.Update(newNCC);
            if (kq == true)
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = _NhaCungCapService.Delete(int.Parse(MaNhaCungCapTextBox.Text.Trim()));
            if (kq == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
