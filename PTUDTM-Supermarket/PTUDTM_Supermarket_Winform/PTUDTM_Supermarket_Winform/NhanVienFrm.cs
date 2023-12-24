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

namespace PTUDTM_Supermarket_Winform
{
    public partial class NhanVienFrm : Form
    {
        private NhanVienService _NhanVienService;
        private DataSetTaiKhoan _DataSetTaiKhoan;

        private const int NONE = 0;
        private const int INSERT = 1;
        private const int UPDATE = 2;
        private const int DELETE = 3;
        private int state;
        
        public NhanVienFrm()
        {
            InitializeComponent();
            _NhanVienService = new NhanVienService();
            _DataSetTaiKhoan=new DataSetTaiKhoan();
            state = NONE;
            Init();
            NgaySinhTextBox.Format = DateTimePickerFormat.Custom;
            NgaySinhTextBox.CustomFormat = "dd/MM/yyyy";

        }

        private void KhoiTaoImagesList()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(70, 70) };
        }
        public void InitListView()
        {
            listViewDsNhanVien.Clear();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();

            int width = listViewDsNhanVien.Width;

            header1.Text = "Hình ảnh";
            header1.Name = "AnhBia";
            header1.Width = (int)Math.Ceiling(width * 0.3);

            header2.Text = "Tên nhân viên";
            header2.Name = "TenNhanVien";
            header2.Width = (int)Math.Ceiling(width * 0.6);

            header3.Text = "Mã nhân viên";
            header3.Name = "MaNhanVien";
            header3.Width = 0;

            
            listViewDsNhanVien.Columns.Add(header1);
            listViewDsNhanVien.Columns.Add(header2);
            listViewDsNhanVien.Columns.Add(header3);
        }

        private void Load_ListViewDanhSachSanPham(List<NhanVien> dsNhanVien)
        {
            listViewDsNhanVien.Items.Clear();
            int dem = 0;
            listViewDsNhanVien.SmallImageList = image_list;
            foreach (NhanVien nv in dsNhanVien)
            {
                string path = Application.StartupPath + "\\sanpham\\"+nv.HinhAnh;
                if (File.Exists(path))
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + nv.HinhAnh));
                else
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\h1.png"));
            }


            foreach (NhanVien nv in dsNhanVien)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                
                item.SubItems.Add(nv.TenNhanVien);
                item.SubItems.Add(nv.MaNhanVien.ToString());
                listViewDsNhanVien.Items.Add(item);
                dem++;
            }
        }

        private void Init()
        {
            KhoiTaoImagesList();
            InitListView();
            DataTable dataTableTaiKhoan = _DataSetTaiKhoan.GetAll();

            List<NhanVien> dsNhanVien = _NhanVienService.GetAll();
            Load_ListViewDanhSachSanPham(dsNhanVien);

            //TaiKhoanCombobox.Enabled = true;
            
            for (int indexTableTaiKhoan = 0; indexTableTaiKhoan < dataTableTaiKhoan.Rows.Count; indexTableTaiKhoan++)
            {
                DataRow row = dataTableTaiKhoan.Rows[indexTableTaiKhoan];
                string tenDangNhap = row["TenDangNhap"].ToString();
                foreach (NhanVien nhanVienItem in _NhanVienService.GetAll())
                {
                    if (nhanVienItem.TenDangNhap != null)
                    {
                        if (nhanVienItem.TenDangNhap.Equals(tenDangNhap))
                        {
                            dataTableTaiKhoan.Rows.Remove(row);
                        }
                    }
                }
            }


            TaiKhoanCombobox.DataSource = dataTableTaiKhoan;
            TaiKhoanCombobox.DisplayMember = "TenDangNhap";
            TaiKhoanCombobox.ValueMember = "TenDangNhap";
            TaiKhoanCombobox.Text = "";
        }

        private void listViewDsNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDsNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = listViewDsNhanVien.SelectedItems[0];
                string maNhanVien = listViewItem.SubItems[2].Text;
                NhanVien nv = _NhanVienService.getOneByID(int.Parse(maNhanVien));
                if (nv != null)
                {
                    //mage image=new Image(new Size(200,200));
                    string path = Application.StartupPath + "\\sanpham\\" + nv.HinhAnh;
                    if (File.Exists(path))
                        pictureBoxNhanVien.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\" + nv.HinhAnh);
                    else
                        pictureBoxNhanVien.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\h1.png");
                    
                    pictureBoxNhanVien.SizeMode=PictureBoxSizeMode.StretchImage;

                    MaNhanVienTextBox.Text = nv.MaNhanVien.ToString();
                    TenNhanVienTextBox.Text = nv.TenNhanVien;

                   
                    NgaySinhTextBox.Value = (DateTime)nv.NgaySinh;

                    if (nv.GioiTinh == true)
                        PhaiNamRadioButton.Checked = true;
                    else
                        PhaiNuRadioButton.Checked = true;

                    SoDienThoaiTextBox.Text = nv.SoDienThoai;
                    EmailTextBox.Text = nv.Email;
                    DiaChiTextBox.Text = nv.DiaChi;
                    LuongCoBanTextBox.Text = nv.LuongCoBan.ToString();
                    TenHinhAnhLable.Text = nv.HinhAnh;

                    if (nv.TenDangNhap != null)
                    {
                        TaiKhoanCombobox.Text = nv.TenDangNhap;
                        TaiKhoan tk = _DataSetTaiKhoan.GetOneByTenDangNhap(nv.TenDangNhap);
                        MatKhauTextBox.Text = tk.MatKhau;
                    }
                    
                }
            }

        }

        private void btnChoosenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1=new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = @"Desktop";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNhanVien.Image = new Bitmap(openFileDialog1.FileName);
                string fileName = openFileDialog1.FileName;
                TenHinhAnhLable.Text = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            state = INSERT;
            btnThemNhanVien.Text = "Thêm mới nhân viên";
            btnThemNhanVien.Enabled = true;
            TaiKhoanCombobox.Enabled = false;
            btnLuuTaiKhoan.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            state = UPDATE;
            btnThemNhanVien.Text = "Cập nhật nhân viên";
            TaiKhoanCombobox.Enabled = true;
            btnThemNhanVien.Enabled = true;
            btnLuuTaiKhoan.Enabled = true;
        }
        private void AddNhanVien()
        {

            NhanVien kq = null;
            NhanVien nv = new NhanVien();

            nv.MaNhanVien = 0; //int.Parse(MaNhanVienTextBox.Text.Trim());
            nv.TenNhanVien = TenNhanVienTextBox.Text;


            nv.NgaySinh = NgaySinhTextBox.Value;

            if (PhaiNamRadioButton.Checked == true)
                nv.GioiTinh = true;
            else
                nv.GioiTinh = false;

            nv.SoDienThoai = SoDienThoaiTextBox.Text;
            nv.Email = EmailTextBox.Text;
            nv.DiaChi = DiaChiTextBox.Text;
            nv.LuongCoBan = double.Parse(LuongCoBanTextBox.Text.Trim());
            nv.HinhAnh = TenHinhAnhLable.Text;

            //nv.TenDangNhap = TaiKhoanCombobox.Text;
            //TaiKhoan tk = _DataSetTaiKhoan.GetOneByTenDangNhap(nv.TenDangNhap);
            //tk.MatKhau = MatKhauTextBox.Text;
            if (nv.TenDangNhap != "" && nv.Email != "" && nv.DiaChi != "" & nv.SoDienThoai != "" && nv.NgaySinh!=DateTime.Now)
            {
                kq = _NhanVienService.Insert(nv);
                if (kq != null)
                {
                    UpLoadFile(openFileDialog1);
                    MessageBox.Show("Thêm nhân viên thành công.\n" +
                        "Tiếp theo hãy cấp tài khoản cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MaNhanVienTextBox.Text = kq.MaNhanVien.ToString();
                    btnThemNhanVien.Enabled = false;

                    btnLuuTaiKhoan.Enabled = true;
                    btnTaoTaiKhoanMoi.Enabled = true;
                    TaiKhoanCombobox.Enabled = true;

                    btnThemNhanVien.Text = "Lưu nhân viên";
                    state = NONE;
                }
                else {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateNhanVien()
        {

            bool kq = false;
            NhanVien nv = _NhanVienService.getOneByID(int.Parse(MaNhanVienTextBox.Text.Trim()));
            if (nv != null)
            {
                //nv.MaNhanVien = int.Parse(MaNhanVienTextBox.Text.Trim());
                string AnhBiaCurrent = nv.HinhAnh;
                nv.TenNhanVien = TenNhanVienTextBox.Text;


                nv.NgaySinh = NgaySinhTextBox.Value;

                if (PhaiNamRadioButton.Checked == true)
                    nv.GioiTinh = true;
                else
                    nv.GioiTinh = false;

                nv.SoDienThoai = SoDienThoaiTextBox.Text;
                nv.Email = EmailTextBox.Text;
                nv.DiaChi = DiaChiTextBox.Text;
                nv.LuongCoBan = double.Parse(LuongCoBanTextBox.Text.Trim());
                nv.HinhAnh = TenHinhAnhLable.Text;

                //nv.TenDangNhap = TaiKhoanCombobox.Text;
                //TaiKhoan tk = _DataSetTaiKhoan.GetOneByTenDangNhap(nv.TenDangNhap);
                //tk.MatKhau = MatKhauTextBox.Text;
                if (nv.TenDangNhap != "" && nv.Email != "" && nv.DiaChi != "" & nv.SoDienThoai != "" && nv.NgaySinh != DateTime.Now)
                {
                    kq = _NhanVienService.Update(nv);
                    if (kq == true)
                    {
                        if (!nv.HinhAnh.Equals(AnhBiaCurrent))
                        {
                            UpLoadFile(openFileDialog1);
                            //DeleteFile(AnhBiaCurrent);
                        }
                        DialogResult result = MessageBox.Show("Cập nhật nhân viên thành công.\n" +
                            "Tiếp theo hãy cấp tài khoản cho nhân viên.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            btnThemNhanVien.Enabled = false;

                            btnLuuTaiKhoan.Enabled = true;
                            btnTaoTaiKhoanMoi.Enabled = false;
                            TaiKhoanCombobox.Enabled = true;

                            btnThemNhanVien.Text = "Lưu nhân viên";
                            state = NONE;
                        }
                        else
                        {
                            btnThemNhanVien.Enabled = false;

                            btnLuuTaiKhoan.Enabled = false;
                            btnTaoTaiKhoanMoi.Enabled = false;
                            TaiKhoanCombobox.Enabled = false;

                            btnThemNhanVien.Text = "Lưu nhân viên";
                            state = NONE;
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (state == INSERT)
            {
                AddNhanVien();
            }
            else if (state == UPDATE)
            {
                UpdateNhanVien();

            }

            KhoiTaoImagesList();
            InitListView();
            List<NhanVien> dsNhanVien = _NhanVienService.GetAll();
            Load_ListViewDanhSachSanPham(dsNhanVien);

        }

        private void UpdateNhanVienTaiKhoan()
        {
            NhanVien nhanVien = _NhanVienService.getOneByID(int.Parse(MaNhanVienTextBox.Text.Trim()));
           
            if (nhanVien != null)
            {
                nhanVien.TenDangNhap = TaiKhoanCombobox.Text.Trim();

                TaiKhoan taiKhoan = _DataSetTaiKhoan.GetOneByTenDangNhap(nhanVien.TenDangNhap);
                if (taiKhoan != null)
                {
                    nhanVien.LoaiNhanVien = taiKhoan.LoaiTaiKhoan;
                }
                bool kq = false;
                kq = _NhanVienService.Update(nhanVien);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnThemNhanVien.Enabled = false;

                    btnLuuTaiKhoan.Enabled = false;
                    btnTaoTaiKhoanMoi.Enabled = false;
                    TaiKhoanCombobox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            UpdateNhanVienTaiKhoan();
        }

        private void TaiKhoanCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaiKhoanCombobox.SelectedIndex >= 0)
            {
                DataRowView row= (DataRowView)TaiKhoanCombobox.SelectedItem;
                MatKhauTextBox.Text = row["MatKhau"].ToString();
            }
                
        }

        private bool UpLoadFile(OpenFileDialog Upload)
        {
            try
            {
                string path = Application.StartupPath + "\\sanpham\\";
                path = path + TenHinhAnhLable.Text;
                if (!File.Exists(path))
                    File.Copy(Upload.FileName, path);
                else
                {
                    MessageBox.Show("Hình ảnh đã có sẵn \n" + path, "Thông báo");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool DeleteFile(string HinhAnh)
        {
            try
            {
                string path = Application.StartupPath + "\\HinhAnh\\";
                path = path + HinhAnh;
                if (!File.Exists(path))
                    File.Delete(path);
                else
                {
                    MessageBox.Show("Không tìm thấy hình ảnh \n" + path, "Thông báo");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = _NhanVienService.getOneByID(int.Parse(MaNhanVienTextBox.Text.Trim()));
            PhieuBanHangService phieuBanHangService = new PhieuBanHangService();
            PhieuNhapHangService phieuNhapHangService=new PhieuNhapHangService();
            if (nhanVien != null)
            {
                List<PhieuBanHang> dsPhieuBan = phieuBanHangService.GetListByNhanVienId(nhanVien.MaNhanVien);
                List<PhieuNhapHang> dsPhieuNhap = phieuNhapHangService.getListByIdNhanVien(nhanVien.MaNhanVien);
                if ((dsPhieuBan == null && dsPhieuNhap == null)|| (dsPhieuBan.Count == 0 && dsPhieuNhap.Count == 0))
                {
                    bool kq = _NhanVienService.Delete(nhanVien);
                    if (kq == true)
                    {
                        KhoiTaoImagesList();
                        InitListView();
                        List<NhanVien> dsNhanVien = _NhanVienService.GetAll();
                        Load_ListViewDanhSachSanPham(dsNhanVien);
                        MessageBox.Show("Xoá tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            }
        }

        private void btnTaoTaiKhoanMoi_Click(object sender, EventArgs e)
        {
            if (MaNhanVienTextBox.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                NewTaiKhoanFrm newTaiKhoanFrm = new NewTaiKhoanFrm(int.Parse(MaNhanVienTextBox.Text.Trim()));
                newTaiKhoanFrm.ShowDialog();
            }
        }
    }
}
