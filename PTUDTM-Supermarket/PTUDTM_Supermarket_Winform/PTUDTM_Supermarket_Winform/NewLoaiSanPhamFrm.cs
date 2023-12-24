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
    public partial class NewLoaiSanPhamFrm : Form
    {
        private LoaiSanPhamService LoaiSanPhamService;
        private LoaiSanPham lsp;
        public NewLoaiSanPhamFrm(LoaiSanPham loaiSanPham)
        {
            InitializeComponent();
            LoaiSanPhamService=new LoaiSanPhamService();

            this.lsp=loaiSanPham;
            maLoaiTB.Text = this.lsp.MaLoai.ToString();
            TenLoaiTB.Text = this.lsp.TenLoai;
            MoTaTB.Text = this.lsp.MoTa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            loaiSanPham.MaLoai = 0;
            loaiSanPham.TenLoai=TenLoaiTB.Text.Trim();
            loaiSanPham.MoTa= MoTaTB.Text.Trim();   
            LoaiSanPham kq=LoaiSanPhamService.Insert(loaiSanPham);
            if (kq != null)
            {
                MessageBox.Show("Them thanh cong", "Thong bao");
                this.Close();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong", "Thong bao");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            loaiSanPham.MaLoai = int.Parse(maLoaiTB.Text.Trim());
            loaiSanPham.TenLoai = TenLoaiTB.Text.Trim();
            loaiSanPham.MoTa = MoTaTB.Text.Trim();
            bool kq = LoaiSanPhamService.Update(loaiSanPham);
            if (kq != null)
            {
                MessageBox.Show("Sua thanh cong", "Thong bao");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sua khong thanh cong", "Thong bao");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kq = LoaiSanPhamService.Delete(int.Parse(maLoaiTB.Text.Trim()));
            if (kq != null)
            {
                MessageBox.Show("Xoa thanh cong", "Thong bao");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong", "Thong bao");
            }
        }
    }
}
