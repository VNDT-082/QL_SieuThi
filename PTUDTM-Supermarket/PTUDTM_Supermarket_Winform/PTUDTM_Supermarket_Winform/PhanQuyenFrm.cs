using PTUDTM_Supermarket_Winform.Asset;
using QLSieuThi_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public partial class PhanQuyenFrm : Form
    {
        private DataSetDM_ManHinh _DataSetDM_ManHinh;
        private DataSetNguoiDungNhomNguoiDung _DataSetNguoiDungNhomNguoiDung;
        private DataSetTaiKhoan _DataSetTaiKhoan;
        private DataSetQLNhomNguoiDung _DataSetQLNhomNguoiDung;
        private DataSetQL_PhanQuyen _DataSetQL_PhanQuyen;
        private NhanVienService _NhanVienService;
        public PhanQuyenFrm()
        {
            InitializeComponent();
            _DataSetDM_ManHinh=new DataSetDM_ManHinh();
            _DataSetNguoiDungNhomNguoiDung=new DataSetNguoiDungNhomNguoiDung();
            _DataSetTaiKhoan=new DataSetTaiKhoan();
            _DataSetQLNhomNguoiDung= new DataSetQLNhomNguoiDung();
            _DataSetQL_PhanQuyen=new DataSetQL_PhanQuyen();
            _NhanVienService=new NhanVienService();
            Init();
        }


        private void Init()
        {
            dataGridViewDM_ManHinh.DataSource = _DataSetDM_ManHinh.GetAll();

            dataGridViewTaiKhoan.DataSource= _DataSetTaiKhoan.GetAll();
            dataGridViewTaiKhoan.Columns["MatKhau"].Visible = false;
            dataGridViewTaiKhoan.Columns["TrangThai"].Visible=false;

            dataGridViewNguoiDungNhomNguoiDung.DataSource = _DataSetNguoiDungNhomNguoiDung.GetAll();

            comboBoxNhomQuyen.DataSource = _DataSetQLNhomNguoiDung.GetAll();
            comboBoxNhomQuyen.DisplayMember = "TenNhom";
            comboBoxNhomQuyen.ValueMember = "MaNhom";

            //tabpage nhom nguoi dung
            dataGridViewNhomNguoiDung.DataSource = _DataSetQLNhomNguoiDung.GetAll();


            //tabpageTaiKhoan
            dataGridViewQLTaiKhoan.DataSource = _DataSetTaiKhoan.GetAll();

            //tabpage phan quyen
            dataGridViewQL_PhanQuyen.DataSource = _DataSetQL_PhanQuyen.GetAll();
            dataGridViewDM_ManHinhPhanQuyen.DataSource = _DataSetDM_ManHinh.GetAll();
            KiemTraQuyenCacManHinh();
            LoaiTaiKhoanCombobox.DataSource = _DataSetQLNhomNguoiDung.GetAll();
            LoaiTaiKhoanCombobox.DisplayMember = "TenNhom";
            LoaiTaiKhoanCombobox.ValueMember = "MaNhom";

        }

        private void KiemTraQuyenCacManHinh()
        {
            bool kq = true;
            for (int i = 0; i < _DataSetDM_ManHinh.GetAll().Rows.Count; i++)
            {
                DataRow row_i = _DataSetDM_ManHinh.GetAll().Rows[i];
                for (int j = 0; j < _DataSetQLNhomNguoiDung.GetAll().Rows.Count; j++)
                {
                    DataRow row_j = _DataSetQLNhomNguoiDung.GetAll().Rows[j];
                    DataRow value = _DataSetQL_PhanQuyen.GetOneById(row_i["MaManHinh"].ToString(), row_j["MaNhom"].ToString());
                    if (value == null)
                    {
                        QL_PhanQuyen qL_PhanQuyen = new QL_PhanQuyen();
                        qL_PhanQuyen.MaManHinh = row_i["MaManHinh"].ToString();
                        qL_PhanQuyen.MaNhomNguoiDung = row_j["MaNhom"].ToString();
                        qL_PhanQuyen.CoQuyen = false;

                        kq = _DataSetQL_PhanQuyen.Insert(qL_PhanQuyen);
                        if (kq == false)
                        {
                            MessageBox.Show("Lỗi them nhóm quyền " + row_i["TenManHinh"] + "; " + row_j["TenNhom"], "Thông báo");
                        }
                    }
                }
            }
            MessageBox.Show("Kiểm tra các quyền hợp lệ", "Thông báo");
        }
        private void btnThemDanhMucManHinh_Click(object sender, EventArgs e)
        {
            string maManHinh = maManHinhTextBox.Text.Trim();
            string tenManHinh = tenManHinhTextBox.Text.Trim();
            DM_ManHinh dM_ManHinh = new DM_ManHinh();
            dM_ManHinh.MaManHinh = maManHinh;
            dM_ManHinh.TenManHinh = tenManHinh;
            if (IsEmptyString(dM_ManHinh.TenManHinh) == false)
            {
                bool kq = _DataSetDM_ManHinh.Insert(dM_ManHinh);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    KiemTraQuyenCacManHinh();
                    dataGridViewDM_ManHinh.DataSource = _DataSetDM_ManHinh.GetAll();
                    dataGridViewDM_ManHinhPhanQuyen.DataSource= _DataSetDM_ManHinh.GetAll();
                    dataGridViewQL_PhanQuyen.DataSource = _DataSetQL_PhanQuyen.GetAll();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên màn hình không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDM_ManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DM_ManHinh dM = new DM_ManHinh();
                DataGridViewRow row = dataGridViewDM_ManHinh.Rows[e.RowIndex];
                dM.MaManHinh= row.Cells["MaManHinh"].Value.ToString();
                dM.TenManHinh= row.Cells["TenManHinh"].Value.ToString();
                tenManHinhTextBox.Text = dM.TenManHinh;
                maManHinhTextBox.Text = dM.MaManHinh;
            }
        }

        private void btnUpdateDanhMucManHinh_Click(object sender, EventArgs e)
        {
            DM_ManHinh dM_ManHinh = new DM_ManHinh();
            dM_ManHinh.MaManHinh = maManHinhTextBox.Text.Trim();
            dM_ManHinh.TenManHinh = tenManHinhTextBox.Text.Trim();
            bool kq = _DataSetDM_ManHinh.Update(dM_ManHinh);

            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                dataGridViewDM_ManHinh.DataSource = _DataSetDM_ManHinh.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void btnThemVaoNhomQuyen_Click(object sender, EventArgs e)
        {
            QL_NguoiDungNhomNguoiDung qL_NguoiDungNhomNguoiDung=new QL_NguoiDungNhomNguoiDung();

        }

        private void dataGridViewDM_ManHinhPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDM_ManHinhPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DM_ManHinh dM = new DM_ManHinh();
                DataGridViewRow row = dataGridViewDM_ManHinh.Rows[e.RowIndex];
                dM.MaManHinh = row.Cells["MaManHinh"].Value.ToString();
                dM.TenManHinh = row.Cells["TenManHinh"].Value.ToString();

                dataGridViewQL_PhanQuyen.DataSource = _DataSetQL_PhanQuyen.GetListByIdManHinh(dM.MaManHinh);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool kq = true;
            for(int rowIndex=0;rowIndex< dataGridViewQL_PhanQuyen.Rows.Count-1;rowIndex++)
            {
                DataGridViewRow row = dataGridViewQL_PhanQuyen.Rows[rowIndex];
                QL_PhanQuyen qL_PhanQuyen=new QL_PhanQuyen();
                qL_PhanQuyen.MaManHinh = row.Cells["MaManHinh"].Value.ToString();
                qL_PhanQuyen.CoQuyen =(bool) row.Cells["CoQuyen"].Value;
                qL_PhanQuyen.MaNhomNguoiDung = row.Cells["MaNhomNguoiDung"].Value.ToString() ;
                kq = _DataSetQL_PhanQuyen.Update(qL_PhanQuyen);
                if (kq == false)
                {
                    DataRow row_exception = _DataSetDM_ManHinh.GetOneById(qL_PhanQuyen.MaManHinh);
                    if (row_exception != null)
                    {
                        DM_ManHinh dM_ManHinh = new DM_ManHinh();
                        dM_ManHinh.TenManHinh = row_exception["TenManHinh"].ToString();
                        MessageBox.Show("Lỗi cấp quyền tại: " +dM_ManHinh.TenManHinh +" - "
                            +qL_PhanQuyen.MaNhomNguoiDung, "Thông báo");
                    }
                    MessageBox.Show("Không tìm thấy màn hình", "Thông báo");
                }
            }
            MessageBox.Show("Lưu thành công", "Thông báo");
        }

        private void AddNhomQuyenBtn_Click(object sender, EventArgs e)
        {
            QL_NhomNguoiDung nhomNguoiDung=new QL_NhomNguoiDung();
            //nhomNguoiDung.MaNhom = maNhomQuyenTextBox.Text ;
            nhomNguoiDung.TenNhom = TenNhomQuyenTextBox.Text ;
            nhomNguoiDung.GhiChu = GhiChuNhomQuyenTextBox.Text ;

            if (IsEmptyString(nhomNguoiDung.TenNhom) == false)
            {
                bool kq = _DataSetQLNhomNguoiDung.Insert(nhomNguoiDung);
                if (kq == true)
                {
                    dataGridViewNhomNguoiDung.DataSource = _DataSetQLNhomNguoiDung.GetAll();
                    comboBoxNhomQuyen.DataSource = _DataSetQLNhomNguoiDung.GetAll();
                    for (int i = 0; i < _DataSetDM_ManHinh.GetAll().Rows.Count; i++)
                    {
                        DataRow row_i = _DataSetDM_ManHinh.GetAll().Rows[i];
                        QL_PhanQuyen qL_PhanQuyen = new QL_PhanQuyen();
                        qL_PhanQuyen.MaManHinh = row_i["MaManHinh"].ToString();
                        qL_PhanQuyen.MaNhomNguoiDung = nhomNguoiDung.MaNhom;
                        qL_PhanQuyen.CoQuyen = false;

                        kq = _DataSetQL_PhanQuyen.Insert(qL_PhanQuyen);
                        if (kq == false)
                        {
                            MessageBox.Show("Lỗi them nhóm quyền " + row_i["TenManHinh"] + "; " + nhomNguoiDung.TenNhom, "Thông báo");
                        }
                    }
                    dataGridViewQL_PhanQuyen.DataSource = _DataSetQL_PhanQuyen.GetAll();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên nhóm không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        

        //private void AddTaiKhoanBtn_Click(object sender, EventArgs e)
        //{
        //    TaiKhoan taiKhoan =new TaiKhoan();
        //    taiKhoan.TenDangNhap = TenDangNhapTextBox.Text.Trim();
        //    taiKhoan.MatKhau = MatKhauTextBox.Text;
        //    taiKhoan.LoaiTaiKhoan = LoaiTaiKhoanCombobox.SelectedValue.ToString();
        //    if (TrangThaiTaiKhoanCheckBox.Checked == true)
        //        taiKhoan.TrangThai = true;
        //    else
        //        taiKhoan.TrangThai = false;
           
        //    if (IsEmptyString(taiKhoan.TenDangNhap) == false && IsEmptyString(taiKhoan.MatKhau) == false)
        //    {
        //        bool kq = _DataSetTaiKhoan.Insert(taiKhoan);
        //        if (kq == true)
        //        {
        //            QL_NguoiDungNhomNguoiDung qL_NguoiDungNhomNguoiDung=new QL_NguoiDungNhomNguoiDung();
        //            qL_NguoiDungNhomNguoiDung.MaNhomNguoiDung = taiKhoan.LoaiTaiKhoan;
        //            qL_NguoiDungNhomNguoiDung.TenDangNhap = taiKhoan.TenDangNhap;
        //            qL_NguoiDungNhomNguoiDung.GhiChu = "";
        //            kq = _DataSetNguoiDungNhomNguoiDung.Insert(qL_NguoiDungNhomNguoiDung);
        //            if (kq == true)
        //            {
        //                MessageBox.Show("Thêm thành công", "Thông báo");
        //                dataGridViewQLTaiKhoan.DataSource = _DataSetTaiKhoan.GetAll();
        //                dataGridViewTaiKhoan.DataSource = _DataSetTaiKhoan.GetAll();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Cấp quyền tài khoản thất bại", "Thông báo");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm thất bại", "Thông báo");
        //        }
        //    }
        //    else
        //        MessageBox.Show("Tên đăng nhập và mật khẩu không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        //}

        private void dataGridViewQLTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TaiKhoan tk = new TaiKhoan();
                DataGridViewRow row = dataGridViewQLTaiKhoan.Rows[e.RowIndex];
                tk.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                tk.MatKhau = row.Cells["MatKhau"].Value.ToString();
                tk.LoaiTaiKhoan = row.Cells["LoaiTaiKhoan"].Value.ToString();
                tk.TrangThai =(bool) row.Cells["TrangThai"].Value;

                TenDangNhapTextBox.Text = tk.TenDangNhap;
                MatKhauTextBox.Text=tk.MatKhau;
                LoaiTaiKhoanCombobox.Text = tk.LoaiTaiKhoan;
                if (tk.TrangThai == true)
                    TrangThaiTaiKhoanCheckBox.Checked = true;
                else
                    TrangThaiTaiKhoanCheckBox.Checked = false;
            }
        }

        private void dataGridViewNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                QL_NhomNguoiDung nhomNguoiDung = new QL_NhomNguoiDung();
                DataGridViewRow row = dataGridViewNhomNguoiDung.Rows[e.RowIndex];
                nhomNguoiDung.MaNhom = row.Cells["MaNhom"].Value.ToString();
                nhomNguoiDung.TenNhom = row.Cells["TenNhom"].Value.ToString();
                nhomNguoiDung.GhiChu = row.Cells["GhiChu"].Value.ToString();

                maNhomQuyenTextBox.Text = nhomNguoiDung.MaNhom;
                TenNhomQuyenTextBox.Text = nhomNguoiDung.TenNhom;
                GhiChuNhomQuyenTextBox.Text = nhomNguoiDung.GhiChu;

            }

        }

        private Label HoverLable;
        private void dataGridViewQL_PhanQuyen_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.RowIndex >= 0 && e.RowIndex< dataGridViewQL_PhanQuyen.Rows.Count-1)
                {
                    QL_NhomNguoiDung nhomNguoiDung = new QL_NhomNguoiDung();
                    DataGridViewRow row = dataGridViewQL_PhanQuyen.Rows[e.RowIndex];
                    nhomNguoiDung.MaNhom = row.Cells["MaNhomNguoiDung"].Value.ToString();

                    DataRow rowNhomNguoiDung = _DataSetQLNhomNguoiDung.GetOneById(nhomNguoiDung.MaNhom);
                    if (rowNhomNguoiDung != null)
                    {
                        HoverLable = new Label();

                        HoverLable.Text = rowNhomNguoiDung["TenNhom"].ToString();
                        HoverLable.AutoSize = true;
                        HoverLable.BackColor = Color.White;
                        HoverLable.ForeColor = Color.Red;
                        HoverLable.Visible = true;

                        Rectangle cellRect = dataGridViewQL_PhanQuyen.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                        HoverLable.Location = new Point(750, cellRect.Top + cellRect.Height+25);
                        tabPage5.Controls.Add(HoverLable);
                    }

                    maNhomQuyenTextBox.Text = nhomNguoiDung.MaNhom;
                    TenNhomQuyenTextBox.Text = nhomNguoiDung.TenNhom;
                    GhiChuNhomQuyenTextBox.Text = nhomNguoiDung.GhiChu;

                }
            }
            catch { }
            
        }

        private void dataGridViewQL_PhanQuyen_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            HoverLable?.Dispose();
            HoverLable = null;
        }

        private void CapNhatTextBoxBtn_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = TenDangNhapTextBox.Text.Trim();
            taiKhoan.MatKhau = MatKhauTextBox.Text;
            taiKhoan.LoaiTaiKhoan = LoaiTaiKhoanCombobox.SelectedValue.ToString();
            if (TrangThaiTaiKhoanCheckBox.Checked == true)
                taiKhoan.TrangThai = true;
            else
                taiKhoan.TrangThai = false;
            if (IsEmptyString(taiKhoan.TenDangNhap)==false&&IsEmptyString(taiKhoan.MatKhau)==false)
            {
                bool kq = _DataSetTaiKhoan.Update(taiKhoan);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    dataGridViewQLTaiKhoan.DataSource = _DataSetTaiKhoan.GetAll();
                }
                else
                {
                    MessageBox.Show("Câp nhật thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không đươc để trống", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        private void UpdateNhomQuyenBtn_Click(object sender, EventArgs e)
        {
            QL_NhomNguoiDung nhomNguoiDung = new QL_NhomNguoiDung();
            nhomNguoiDung.MaNhom = maNhomQuyenTextBox.Text ;
            nhomNguoiDung.TenNhom = TenNhomQuyenTextBox.Text;
            nhomNguoiDung.GhiChu = GhiChuNhomQuyenTextBox.Text;

            if (IsEmptyString(nhomNguoiDung.TenNhom) == false)
            {
                bool kq = _DataSetQLNhomNguoiDung.Update(nhomNguoiDung);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    dataGridViewNhomNguoiDung.DataSource = _DataSetQLNhomNguoiDung.GetAll();
                    comboBoxNhomQuyen.DataSource = _DataSetQLNhomNguoiDung.GetAll();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên nhóm không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateDanhMucManHinh_Click_1(object sender, EventArgs e)
        {
            string maManHinh = maManHinhTextBox.Text.Trim();
            string tenManHinh = tenManHinhTextBox.Text.Trim();
            DM_ManHinh dM_ManHinh = new DM_ManHinh();
            dM_ManHinh.MaManHinh = maManHinh;
            dM_ManHinh.TenManHinh = tenManHinh;
            if (IsEmptyString(dM_ManHinh.TenManHinh) == false&& IsEmptyString(dM_ManHinh.MaManHinh)==false)
            {
                bool kq = _DataSetDM_ManHinh.Update(dM_ManHinh);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    dataGridViewDM_ManHinh.DataSource = _DataSetDM_ManHinh.GetAll();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Tên màn hình, mã màn hình không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThemVaoNhomQuyen_Click_1(object sender, EventArgs e)
        {
            try {
                string maNhomQuyen = comboBoxNhomQuyen.SelectedValue.ToString();
                foreach (DataGridViewRow row in dataGridViewTaiKhoan.SelectedRows)
                {
                    string TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                    QL_NguoiDungNhomNguoiDung nhomNguoiDung = new QL_NguoiDungNhomNguoiDung();
                    nhomNguoiDung.MaNhomNguoiDung = maNhomQuyen;
                    nhomNguoiDung.TenDangNhap = TenDangNhap;
                    nhomNguoiDung.GhiChu = "";
                    DataRow row_Check = _DataSetNguoiDungNhomNguoiDung.GetOneById(maNhomQuyen, TenDangNhap);
                    if (row_Check == null)
                    {
                        bool kq = _DataSetNguoiDungNhomNguoiDung.Insert(nhomNguoiDung);
                        if (kq == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            NhanVien nhanVienUpdate = _NhanVienService.getOneByTenDangNhap(TenDangNhap);
                            TaiKhoan tkUpdate = _DataSetTaiKhoan.GetOneByTenDangNhap(TenDangNhap);
                            if (tkUpdate != null)
                            {
                                tkUpdate.LoaiTaiKhoan = maNhomQuyen;
                                kq = _DataSetTaiKhoan.Update(tkUpdate);
                            }
                            if (nhanVienUpdate != null)
                            {
                                nhanVienUpdate.LoaiNhanVien = maNhomQuyen;
                                kq = _NhanVienService.Update(nhanVienUpdate);
                            }
                            dataGridViewNguoiDungNhomNguoiDung.DataSource = _DataSetNguoiDungNhomNguoiDung.GetAll();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã thuộc nhóm quyền", "Thông báo");
                    }
                }
            }
            catch { MessageBox.Show("Lỗi không tìm thấy người dùng", "Thông báo"); return; }
        }

        private void btnRemoveKhoiNhomQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewNguoiDungNhomNguoiDung.SelectedRows)
                {
                    QL_NguoiDungNhomNguoiDung qL_NguoiDungNhomNguoiDung = new QL_NguoiDungNhomNguoiDung();
                    qL_NguoiDungNhomNguoiDung.MaNhomNguoiDung = row.Cells["MaNhomNguoiDung"].Value.ToString();
                    qL_NguoiDungNhomNguoiDung.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                    qL_NguoiDungNhomNguoiDung.GhiChu = row.Cells["GhiChu"].Value.ToString();
                    DataRow row_Check = _DataSetNguoiDungNhomNguoiDung.GetOneById(qL_NguoiDungNhomNguoiDung.MaNhomNguoiDung, qL_NguoiDungNhomNguoiDung.TenDangNhap);
                    if (row_Check != null)
                    {
                        bool kq = _DataSetNguoiDungNhomNguoiDung.Delete(qL_NguoiDungNhomNguoiDung);
                        if (kq == true)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            dataGridViewNguoiDungNhomNguoiDung.DataSource = _DataSetNguoiDungNhomNguoiDung.GetAll();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }
            }
            catch { MessageBox.Show("Lỗi không tìm thấy người dùng nhóm người dùng", "Thông báo"); return; }
        }

        private void dataGridViewDM_ManHinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDM_ManHinh.EnableHeadersVisualStyles = false;
            dataGridViewDM_ManHinh.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewDM_ManHinh.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else {
                dataGridViewDM_ManHinh.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewNhomNguoiDung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewNhomNguoiDung.EnableHeadersVisualStyles = false;
            dataGridViewNhomNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewNhomNguoiDung.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewNhomNguoiDung.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewQLTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewQLTaiKhoan.EnableHeadersVisualStyles = false;
            dataGridViewQLTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewQLTaiKhoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewQLTaiKhoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewTaiKhoan.EnableHeadersVisualStyles = false;
            dataGridViewTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewTaiKhoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewTaiKhoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewNguoiDungNhomNguoiDung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewNguoiDungNhomNguoiDung.EnableHeadersVisualStyles = false;
            dataGridViewNguoiDungNhomNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewNguoiDungNhomNguoiDung.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewNguoiDungNhomNguoiDung.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewDM_ManHinhPhanQuyen_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dataGridViewDM_ManHinhPhanQuyen.EnableHeadersVisualStyles = false;
            dataGridViewDM_ManHinhPhanQuyen.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewDM_ManHinhPhanQuyen.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewDM_ManHinhPhanQuyen.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }

        private void dataGridViewQL_PhanQuyen_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dataGridViewQL_PhanQuyen.EnableHeadersVisualStyles = false;
            dataGridViewQL_PhanQuyen.ColumnHeadersDefaultCellStyle.BackColor = AppValues.HEADERCOLOR;
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewQL_PhanQuyen.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWCHAN;
            }
            else
            {
                dataGridViewQL_PhanQuyen.Rows[e.RowIndex].DefaultCellStyle.BackColor = AppValues.ROWLE;
            }
        }
    }
}
