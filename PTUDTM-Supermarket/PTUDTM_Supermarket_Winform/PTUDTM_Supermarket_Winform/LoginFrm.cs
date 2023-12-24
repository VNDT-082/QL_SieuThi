using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public partial class LoginFrm : Form
    {
        private DataSetTaiKhoan _DataSetTaiKhoan;
        //private NhanVienService _NhanVienService;
        public LoginFrm()
        {
            InitializeComponent();
            _DataSetTaiKhoan = new DataSetTaiKhoan();
            //_NhanVienService = new NhanVienService();
            edtUsername.Focus();
            Load();
            
        }
        private void Load()
        {
            edtPass.PasswordChar = '*';
            hoverButton1.BackColor = Color.Blue;
        }

        private void showHide_CheckStateChanged(object sender, EventArgs e)
        {
            if (showHide.Checked)
            {
                edtPass.PasswordChar = '\0';
            }
            else
            {
                edtPass.PasswordChar = '*';
            }
        }

        private async void hoverButton1_Click(object sender, EventArgs e)
        {
            TaiKhoan kh=new TaiKhoan();
            kh.TenDangNhap = edtUsername.Text.Trim();
            kh.MatKhau=edtPass.Text;

            TaiKhoan login = _DataSetTaiKhoan.GetOneByTenDangNhap(kh.TenDangNhap);
            if (login != null)
            {
                if (login.MatKhau.Equals(kh.MatKhau))
                {

                    if (login.LoaiTaiKhoan.Equals("MN002"))
                    {
                        LoadingFrm loadingFrm = new LoadingFrm();
                        loadingFrm.Show();
                        this.Hide();
                        await Task.Delay(1500);
                        BanHangFrm banHangFrm=new BanHangFrm(login.TenDangNhap);
                        banHangFrm.Show();
                        this.Hide();
                        loadingFrm.Close();
                        edtUsername.Text = "";
                        edtPass.Text = "";
                    }
                    else {

                        LoadingFrm loadingFrm = new LoadingFrm();
                        loadingFrm.Show();
                        this.Hide();
                        await Task.Delay(1500);
                        MainFrm mainFrm = new MainFrm(login.TenDangNhap);
                        mainFrm.Show();

                        loadingFrm.Close();
                        edtUsername.Text = "";
                        edtPass.Text = "";

                    }

                   
                }
                else { 
                    MessageBox.Show("Mật khẩu không đúng","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void edtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                hoverButton1_Click(sender, e);
            }
        }

    }
}
