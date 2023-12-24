using CustomControll;
using PTUDTM_Supermarket_Winform.Asset;
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
    public partial class MainFrm : Form
    {
        public string UserName { get; set; }
        private NhanVien NHANVIEN;
        private NhanVienService _NhanVienService;
        private DataSetTaiKhoan _DataSetTaiKhoan;
        private DataSetNguoiDungNhomNguoiDung _DataSetNguoiDungNhomNguoiDung;
        private DataSetQL_PhanQuyen _DataSetQL_PhanQuyen;
        private DataSetDM_ManHinh _DataSetDM_ManHinh;
        
        public MainFrm(string UserName)
        {
            InitializeComponent();
            _NhanVienService = new NhanVienService();
            _DataSetTaiKhoan = new DataSetTaiKhoan();
            _DataSetNguoiDungNhomNguoiDung= new DataSetNguoiDungNhomNguoiDung();
            _DataSetQL_PhanQuyen=new DataSetQL_PhanQuyen();
            _DataSetDM_ManHinh=new DataSetDM_ManHinh();
            this.UserName = UserName;
            Init(0.2f,0.8f);
            SetFlagBeforeClick();
            btnTrangCaNhan.Flag = true;
            SetColorBeforeClick();
            //openForm(new LoadingFrm(this.UserName));
            //LoadingFrm loadingFrm = new LoadingFrm();
            //loadingFrm.Show();
            //Thread.Sleep(5000);
            openForm(new TrangCaNhanFrm(this.UserName));
            CheckPhanQuyen();

        }
        private void CheckPhanQuyen()
        {
            TaiKhoan taiKhoan = _DataSetTaiKhoan.GetOneByTenDangNhap(this.UserName);
            List<QL_NguoiDungNhomNguoiDung> dsNhomQuyenNguoiDung = _DataSetNguoiDungNhomNguoiDung.GetListByTenDangNhap(this.UserName);
            List<QL_PhanQuyen> dsQuyen = new List<QL_PhanQuyen>();
            foreach (QL_NguoiDungNhomNguoiDung nhomQuyen in dsNhomQuyenNguoiDung)
            {
                dsQuyen.AddRange(_DataSetQL_PhanQuyen.GetListByMaNhomNguoiDung(nhomQuyen.MaNhomNguoiDung));
            }
            foreach (Control control in pnLeft.Controls)
            {
                if (control.Tag != null)
                {
                    foreach (QL_PhanQuyen quyen in dsQuyen)
                    {
                        DM_ManHinh dM_ManHinh = _DataSetDM_ManHinh.GetOneById_m(quyen.MaManHinh);
                        if (control.Tag.Equals(dM_ManHinh.TenManHinh))
                        {
                            control.Enabled = (quyen.CoQuyen == true) ? true : false;
                        }
                    }
                }
               
            }

        }
        public void Init(float leftwidth,float mainwidth)
        {
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnLeft, leftwidth);
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnMain, mainwidth);

            btnNhapHang.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnQLNhanVien.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnQLSanPham.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnThongKe.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnPhanQuyen.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnQLNhanVien.Width=(int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnQLKhachHang.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnHoaDon.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnTrangCaNhan.Width = (int)(pnLeft.Width -Math.Ceiling(pnLeft.Width*0.07));
            btnQLKhuyenMai.Width = (int)(pnLeft.Width - Math.Ceiling(pnLeft.Width * 0.07));
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (btnAdmin.Flag == false)
            {
                //float widthLeft = 0.2f, widthMain = 0.8f;
                //for (int i = 0; i <= 15;i++ )
                //{
                    
                //    widthLeft -= 0.01f;
                //    widthMain+= 0.01f;
                //    Init(widthLeft, widthMain);
                //    Thread.Sleep(5);
                //}

                Init(0.05f, 0.95f);
                btnAdmin.Flag = true;
            }
            else
            {
                //float widthLeft = 0.05f, widthMain = 0.95f;
                //for (int i = 0; i <= 10; i++)
                //{

                //    widthLeft += 0.01f;
                //    widthMain -= 0.01f;
                //    Init(widthLeft, widthMain);
                //    Thread.Sleep(5);
                //}
                Init(0.15f, 0.85f);
                btnAdmin.Flag = false;
            }
        }
        private Form FormOpsion;
        private void openForm(Form f_Opsion)
        {
            if (FormOpsion != null)
            {
                FormOpsion.Close();
            }
            FormOpsion = f_Opsion;
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;
            pnMain.Controls.Add(f_Opsion);
            pnMain.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnNhapHang.Flag = true;
            
            SetColorBeforeClick();
            openForm(new NhapHangFrm(this.UserName));
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnPhanQuyen.Flag = true;
            SetColorBeforeClick();
            openForm(new PhanQuyenFrm());
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnQLNhanVien.Flag = true;
            SetColorBeforeClick();
            openForm(new NhanVienFrm());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnHoaDon.Flag = true;
            SetColorBeforeClick();
            openForm(new HoaDonFrm());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnQLKhachHang.Flag = true;
            SetColorBeforeClick();
            openForm(new KhachHangFrm());
        }

        private void btnTrangCaNhan_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnTrangCaNhan.Flag = true;
            SetColorBeforeClick();
            openForm(new TrangCaNhanFrm(this.UserName));
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnQLSanPham.Flag = true;
            SetColorBeforeClick();
            openForm(new SanPhamFrm());
        }

        private void SetFlagBeforeClick()
        {
            foreach (ButtonControllMain btn in pnLeft.Controls)
            {
                btn.Flag = false;
            }
        }
        private void SetColorBeforeClick()
        { 
            foreach(ButtonControllMain btn in pnLeft.Controls)
            {
                if (btn.Flag == true)
                {
                    btn.BackColor = Color.MediumBlue;
                }
                else {
                    btn.BackColor =Color.Blue;
                }
            }
        }



        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (!form.Visible)
                {
                    form.Show();
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnThongKe.Flag = true;
            SetColorBeforeClick();
            openForm(new ThongKeFrm());
        }

        private void btnQLKhuyenMai_Click(object sender, EventArgs e)
        {
            SetFlagBeforeClick();
            btnQLKhuyenMai.Flag = true;
            SetColorBeforeClick();
            openForm(new KhuyenMaiFrm());
        }
    }
}
