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
    public partial class NewKhachHangFrm : Form
    {
        private KhachHangService _KhachHangService;
        public NewKhachHangFrm()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService();
            radioButtonNam.Checked=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SDTTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không bõ trống", "Thông báo");
            }
            else if(HoTenTextBox.Text.Trim().Equals("")) {
                MessageBox.Show("Họ và tên không bõ trống", "Thông báo");
            }
            else
            {
                KhachHang khachHang = new KhachHang();
                khachHang.SoDienThoai = SDTTextBox.Text.Trim();
                khachHang.TenKhachHang = HoTenTextBox.Text.Trim().ToUpper();
                khachHang.DiaChi = DiaChiTextBox.Text.Trim();
                khachHang.GioiTinh = (radioButtonNam.Checked == true) ? true : false;
                khachHang.MatKhau = khachHang.SoDienThoai;


                bool kq = _KhachHangService.Insert(khachHang);

                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                    NewKhachHangFrm newKhachHangFrm = new NewKhachHangFrm();
                    newKhachHangFrm.ShowDialog();
                    this.Close();
                }
            }
           
        }
    }
}
