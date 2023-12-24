using CustomControll;
using Microsoft.SqlServer.Server;
using PTUDTM_Supermarket_Winform.Asset;
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
    public partial class NhapHangFrm : Form
    {
        private string UserName;
        public readonly NhanVien _NhanVien;

        private readonly SanPhamService _SanPhamService;
        private NhaCungCapService _NhaCungCapService;
        private readonly PhieuNhapHangService _PhieuNhapHangService;
        private readonly ChiTietPhieuNhapService _ChiTietPhieuNhapService;
        private readonly NhanVienService _NhanVienService;
        private readonly DataSetTaiKhoan _DataSetTaiKhoan;
        private readonly DataSetNguoiDungNhomNguoiDung _DataSetNguoiDungNhomNguoiDung;
        private readonly DataSetQL_PhanQuyen _DataSetQL_PhanQuyen;
        private CloudinaryService cloudinaryService;

        private List<SanPham> dsSanPham;
        private List<NhaCungCap> dsNhaCungCap;
        private List<PhieuNhapHang> dsPhieuNhap;

        //=======================================
        private List<PhieuNhapHang> dsPhieuNhap_QLPN;

        public NhapHangFrm(string UserName)
        {
            InitializeComponent();
            cloudinaryService = new CloudinaryService();
            _SanPhamService =new SanPhamService();
            _NhaCungCapService=new NhaCungCapService();
            _PhieuNhapHangService=new PhieuNhapHangService();
            _ChiTietPhieuNhapService=new ChiTietPhieuNhapService();
            _NhanVienService=new NhanVienService();
            _DataSetTaiKhoan=new DataSetTaiKhoan();
            _DataSetNguoiDungNhomNguoiDung = new DataSetNguoiDungNhomNguoiDung();
            _DataSetQL_PhanQuyen=new DataSetQL_PhanQuyen();
            this.UserName = UserName;
            _NhanVien = _NhanVienService.getOneByTenDangNhap(this.UserName);
            CheckPhanQuyen();

            dsSanPham = _SanPhamService.getAll();
            dsNhaCungCap=_NhaCungCapService.getAll();
            

            Init();
            LoadTabLapPhieuNhap();

            //=======================
            LoadTabQuanLyPhieuNhap();

        }
        private void CheckPhanQuyen()
        {
            TaiKhoan taiKhoan = _DataSetTaiKhoan.GetOneByTenDangNhap(this.UserName);
            List<QL_NguoiDungNhomNguoiDung> dsNhomQuyenNguoiDung = _DataSetNguoiDungNhomNguoiDung.GetListByTenDangNhap(this.UserName);
            List<QL_PhanQuyen> dsQuyen = new List<QL_PhanQuyen>();
            bool IsQuanLy = false;
            foreach (QL_NguoiDungNhomNguoiDung nhomQuyen in dsNhomQuyenNguoiDung)
            {
                if (nhomQuyen.MaNhomNguoiDung.Equals("MN004"))
                {
                    IsQuanLy = true;
                    
                }
            }
            if (IsQuanLy == true)
            {
                cbQuanLyDaDuyet.Enabled = true;
                dsPhieuNhap = _PhieuNhapHangService.getAll();
                btnCapNhat_QLPN.Visible = true;
                btnXoa_QLPN.Visible = true;
            }
            else
            {
                dsPhieuNhap = _PhieuNhapHangService.getListByIdNhanVien(_NhanVien.MaNhanVien);
                //btnCapNhat_QLPN.Enabled = false;
                //btnXoa_QLPN.Enabled=false;
                btnCapNhat_QLPN.Visible = false;
                btnXoa_QLPN.Visible = false;
            }
        }
        private void LoadTabLapPhieuNhap()
        {
            LoadCbbNhaCungCap();
            LoadCbbPhieuNhapHang();
            InitListView();
            InitListViewChiTietPhieuNhap();
            KhoiTaoImagesList();
            KhoiTaoImagesListChiTietPhieuNhap();
            Load_ListViewDanhSachSanPham();
        }

       
        private void Init()
        {
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnPhieuNhap, 0.4f);
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnSanPham, 0.6f);

            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtLoaiSP, 0.355f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtTenSP, 0.3f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtMaSP, 0.1f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtDVT, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtGiaSP, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtSLN, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtSLT, 0.2f);

            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label8, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label9, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label10, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label11, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label12, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label13, 0.2f);

            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtLoaiSP_QLPN, 0.355f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtTenSP_QLPN, 0.3f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtMaSP_QLPN, 0.1f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtDVT_QLPN, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtGiaSP_QLPN, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtSLN_QLPN, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtSLD_QLPN, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, edtTrangThai_QLPN, 0.1f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, SoLuongDaNhanTextBox, 0.1f);

            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label22, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label23, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label24, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label25, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label26, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label27, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label28, 0.2f);
            WindowsDevice.setWidthOfCerrentPanel(pnSanPham.Size.Width, label29, 0.2f);

            WindowsDevice.setHeightOfCerrentPanel(pnSanPham.Size.Height, pnChiTietSanPhamNhap, 0.32f);
            WindowsDevice.setHeightOfCerrentPanel(pnSanPham.Size.Height, pnDsSanPham, 0.68f);

            pnSanPham.BackColor = AppValues.BACKGROUND_COLOR;

            edtTenNhanVien.Text = _NhanVien.TenNhanVien;
            
        }
        public void InitListViewChiTietPhieuNhap()
        {
            lvChiTietPhieuNhap.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            int width = lvChiTietPhieuNhap.Width;
            header.Text = "Hình ảnh";
            header.Name = "HinhAnh";
            header.Width = (int)Math.Ceiling(width * 0.3);

            header1.Text = "MaSP";
            header1.Name = "MaSP";
            header1.Width = (int)Math.Ceiling(width * 0.1); ;

            header2.Text = "Tên sản phẩm";
            header2.Name = "TenSanPham";
            header2.Width = (int)Math.Ceiling(width * 0.4);

            header3.Text = "Số lượng";
            header3.Name = "SoLuong";
            header3.Width = (int)Math.Ceiling(width * 0.1);

            

            lvChiTietPhieuNhap.Columns.Add(header);
            lvChiTietPhieuNhap.Columns.Add(header1);
            lvChiTietPhieuNhap.Columns.Add(header2);
            lvChiTietPhieuNhap.Columns.Add(header3);
        }
        public void InitListView()
        {
            lvDanhSachSanPham.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            ColumnHeader header5 = new ColumnHeader();
            ColumnHeader header6 = new ColumnHeader();
            ColumnHeader header7 = new ColumnHeader();
            int width = lvDanhSachSanPham.Width;
            header.Text = "Hình ảnh";
            header.Name = "HinhAnh";
            header.Width = (int)Math.Ceiling(width * 0.14);

            header1.Text = "Tên sản phẩm";
            header1.Name = "TenSanPham";
            header1.Width = (int)Math.Ceiling(width * 0.2);

            header2.Text = "Giá";
            header2.Name = "Gia";
            header2.Width = (int)Math.Ceiling(width * 0.1);

            header5.Text = "Đơn vị tính";
            header5.Name = "DonViTinh";
            header5.Width = (int)Math.Ceiling(width * 0.125);

            header6.Text = "Tên loại";
            header6.Name = "TenLoai";
            header6.Width = (int)Math.Ceiling(width * 0.15);

            header3.Text = "Số lượng";
            header3.Name = "SoLuong";
            header3.Width = (int)Math.Ceiling(width * 0.1);

            header4.Text = "Mô tả";
            header4.Name = "MoTa";
            header4.Width = (int)Math.Ceiling(width * 0.175);

            header7.Text = "MaSP";
            header7.Name = "MaSP";
            header7.Width = 0;

            lvDanhSachSanPham.Columns.Add(header);
            lvDanhSachSanPham.Columns.Add(header1);
            lvDanhSachSanPham.Columns.Add(header6);
            lvDanhSachSanPham.Columns.Add(header3);
            lvDanhSachSanPham.Columns.Add(header5);
            lvDanhSachSanPham.Columns.Add(header2);
            lvDanhSachSanPham.Columns.Add(header4);
            lvDanhSachSanPham.Columns.Add(header7);
        }

        private void LoadCbbPhieuNhapHang()
        {
            cbbPhieuNhap.DataSource = dsPhieuNhap;
            cbbPhieuNhap.DisplayMember = "MaPhieuNhap";
            cbbPhieuNhap.ValueMember = "MaPhieuNhap";
        }
        private void LoadCbbNhaCungCap()
        {
            cbbNhaCungCap.DataSource = dsNhaCungCap;
            cbbNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbbNhaCungCap.ValueMember = "MaNhanCungCap";
        }
        public void ListViewSizeChange()
        {
            if (lvDanhSachSanPham.Columns.Count > 0)
            {
                int width = lvDanhSachSanPham.Width;
                lvDanhSachSanPham.Columns["HinhAnh"].Width = (int)Math.Ceiling(width * 0.14);
                lvDanhSachSanPham.Columns["TenSanPham"].Width = (int)Math.Ceiling(width * 0.2);
                lvDanhSachSanPham.Columns["DonViTinh"].Width = (int)Math.Ceiling(width * 0.125);
                lvDanhSachSanPham.Columns["TenLoai"].Width = (int)Math.Ceiling(width * 0.15);
                lvDanhSachSanPham.Columns["SoLuong"].Width = (int)Math.Ceiling(width * 0.1);
                lvDanhSachSanPham.Columns["Gia"].Width = (int)Math.Ceiling(width * 0.1);
                lvDanhSachSanPham.Columns["MoTa"].Width = (int)Math.Ceiling(width * 0.175);
                lvDanhSachSanPham.Columns["MaSP"].Width = 0;

            }

            if (lvDsSanPhamNhap_QLPN.Columns.Count > 0)
            {
                int width = lvDsSanPhamNhap_QLPN.Width;
                lvDsSanPhamNhap_QLPN.Columns["HinhAnh"].Width = (int)Math.Ceiling(width * 0.144);
                lvDsSanPhamNhap_QLPN.Columns["MaSP"].Width = (int)Math.Ceiling(width * 0.12);
                lvDsSanPhamNhap_QLPN.Columns["TenSanPham"].Width = (int)Math.Ceiling(width * 0.2);
                lvDsSanPhamNhap_QLPN.Columns["SoLuong"].Width = (int)Math.Ceiling(width * 0.09);
                lvDsSanPhamNhap_QLPN.Columns["GiaNhap"].Width = (int)Math.Ceiling(width * 0.12);
                lvDsSanPhamNhap_QLPN.Columns["TongCong"].Width = (int)Math.Ceiling(width * 0.125);
                lvDsSanPhamNhap_QLPN.Columns["TrangThai"].Width = (int)Math.Ceiling(width * 0.12);
                lvDsSanPhamNhap_QLPN.Columns["delete"].Width = (int)Math.Ceiling(width * 0.07);
            }

        }
        private void KhoiTaoImagesListChiTietPhieuNhap()
        {
            image_listCTPN.Images.Clear();
            image_listCTPN = new ImageList() { ImageSize = new Size(100, 90) };
        }
        private void KhoiTaoImagesList()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(100, 90) };
        }

        private void Load_ListViewDanhSachSanPham(List<ChiTietPhieuNhap> chiTietPhieuNhaps)
        {
            lvChiTietPhieuNhap.Items.Clear();
            int dem = 0;
            lvChiTietPhieuNhap.SmallImageList = image_listCTPN;
            foreach (ChiTietPhieuNhap t in chiTietPhieuNhaps)
            {
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                string[] fileName_ = sanPham.HinhAnh.Split('/');
                image_listCTPN.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]));
                //image_listCTPN.Images.Add(cloudinaryService.getBitMapImage(sanPham.HinhAnh));
            }


            foreach (ChiTietPhieuNhap t in chiTietPhieuNhaps)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                item.SubItems.Add(sanPham.MaSanPham.ToString());
                item.SubItems.Add(sanPham.TenSanPham);
                item.SubItems.Add(t.SoLuong.ToString());
                lvChiTietPhieuNhap.Items.Add(item);
                dem++;
            }
        }

        private void Load_ListViewDanhSachSanPham()
        {
            lvDanhSachSanPham.Items.Clear();
            int dem = 0;
            lvDanhSachSanPham.SmallImageList = image_list;
            foreach (SanPham t in dsSanPham)
            {
                string[] fileName_ = t.HinhAnh.Split('/');

                string path = Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1];
                if (File.Exists(path))
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]));
                else
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\default.png"));
                //image_list.Images.Add(cloudinaryService.getBitMapImage(t.HinhAnh));
            }

            foreach (SanPham t in dsSanPham)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                item.SubItems.Add(t.TenSanPham);
                item.SubItems.Add(t.LoaiSanPham.TenLoai);
                item.SubItems.Add(t.SoLuongTon.ToString());
                item.SubItems.Add(t.DonViTinh);
                item.SubItems.Add(t.Gia.ToString());
                item.SubItems.Add(t.MoTa);
                item.SubItems.Add(t.MaSanPham.ToString());
                lvDanhSachSanPham.Items.Add(item);
                dem++;
            }
        }

        private void NhapHangFrm_SizeChanged(object sender, EventArgs e)
        {
            if(dsSanPham!= null)
            {
                ListViewSizeChange();
            }
            
        }

        private void lvDanhSachSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachSanPham.SelectedItems[0];
                SanPham sp = _SanPhamService.getOneByID(int.Parse(item.SubItems[7].Text));
                edtMaSP.Text = sp.MaSanPham.ToString();
                edtTenSP.Text = sp.TenSanPham;
                edtLoaiSP.Text = sp.LoaiSanPham.TenLoai;
                edtDVT.Text = sp.DonViTinh;
                edtSLT.Text = sp.SoLuongTon.ToString();
                double gia = (float)float.Parse(sp.Gia.ToString());
                edtGiaSP.Text = gia.ToString("N0");
                edtSLN.Text = "1";
                edtSLN.Focus();
            }
        }

        private void cbbPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (cbbPhieuNhap.SelectedIndex  >= 0)
            {
                PhieuNhapHang phieuNhapHang =(PhieuNhapHang) cbbPhieuNhap.SelectedItem;
                
                if (phieuNhapHang != null)
                {
                    List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(phieuNhapHang.MaPhieuNhap);
                    if (dsChiTietPhieuNhap != null)
                    {
                        cbbNhaCungCap.Text = phieuNhapHang.NhaCungCap.TenNhaCungCap;
                        KhoiTaoImagesListChiTietPhieuNhap();
                        InitListViewChiTietPhieuNhap();
                        Load_ListViewDanhSachSanPham(dsChiTietPhieuNhap);
                        cbDaNhanHang.Checked= (phieuNhapHang.TrangThai == true) ? true : false;
                        cbQuanLyDaDuyet.Checked = (phieuNhapHang.QL_PheDuyet == true) ? true : false;
                        double giaTri=double.Parse(phieuNhapHang.GiaTri.ToString());
                        edtGiaTriPhieuNhap.Text = giaTri.ToString("N0");
                        edtNgayNhap.Format = DateTimePickerFormat.Custom;
                        edtNgayNhap.CustomFormat = "dd/MM/yyyy";
                        edtNgayNhap.Value = (DateTime) phieuNhapHang.NgayNhap;
                    }

                    if (phieuNhapHang.QL_PheDuyet == true)
                    {
                        btnUpdate.Enabled = false;
                        button3.Enabled = false;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                        button3.Enabled = true;
                    }

                    if (phieuNhapHang.TrangThai == true)
                    {
                        btnThemChiTietSanPham.Enabled = false;
                    }
                    else
                    {
                        btnThemChiTietSanPham.Enabled = true;
                    }
                }
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("itemThem"))
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.MaNhanCungCap = 0;
                nhaCungCap.TenNhaCungCap = "";
                nhaCungCap.DiaChi = "";
                nhaCungCap.Email = "";
                nhaCungCap.SoDienThoai = 0;
                NhaCungCapFrm nhaCungCapFrm = new NhaCungCapFrm(nhaCungCap);
                nhaCungCapFrm.ShowDialog();


            }
            else if (e.ClickedItem.Name.Equals("itemXoa"))
            {

            }
            else if (e.ClickedItem.Name.Equals("itemReload"))
            {
                _NhaCungCapService = new NhaCungCapService();
                dsNhaCungCap = _NhaCungCapService.getAll();
                LoadCbbNhaCungCap();
            }
            else
            {
                NhaCungCap ncc = _NhaCungCapService.getOneByID(int.Parse(cbbNhaCungCap.SelectedValue.ToString()));
                if (ncc != null)
                {
                    NhaCungCapFrm nhaCungCapFrm = new NhaCungCapFrm(ncc);
                    nhaCungCapFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhapHang phieuNhapHang = new PhieuNhapHang();
            phieuNhapHang.NgayNhap = DateTime.Now;
            phieuNhapHang.MaNhanVien = _NhanVien.MaNhanVien;
            phieuNhapHang.MaNhaCungCap = (int)cbbNhaCungCap.SelectedValue;
            phieuNhapHang.TrangThai = false;
            phieuNhapHang.GiaTri = 0;
            phieuNhapHang.MaPhieuNhap = 0;
            phieuNhapHang.QL_PheDuyet = false;

            PhieuNhapHang pnNew = _PhieuNhapHangService.Insert(phieuNhapHang);
            if (pnNew != null)
            {
                dsPhieuNhap = _PhieuNhapHangService.getAll();
                LoadCbbPhieuNhapHang();
                LoadCbbPhieuNhapHang_QLPN();

                cbbPhieuNhap.Text = pnNew.MaPhieuNhap.ToString();
                cbbNhaCungCap.Text = pnNew.NhaCungCap.TenNhaCungCap;

                edtNgayNhap.Value = (DateTime)pnNew.NgayNhap;
                edtGiaTriPhieuNhap.Text = pnNew.GiaTri.ToString();
                cbDaNhanHang.Checked = (bool)pnNew.TrangThai;
                cbQuanLyDaDuyet.Checked = (bool)pnNew.QL_PheDuyet;

                List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(pnNew.MaPhieuNhap);
                if (dsChiTietPhieuNhap != null)
                {
                    cbbNhaCungCap.Text = phieuNhapHang.NhaCungCap.TenNhaCungCap;
                    KhoiTaoImagesListChiTietPhieuNhap();
                    InitListViewChiTietPhieuNhap();
                    Load_ListViewDanhSachSanPham(dsChiTietPhieuNhap);
                    cbDaNhanHang.Checked = (phieuNhapHang.TrangThai == true) ? true : false;
                    cbQuanLyDaDuyet.Checked = (phieuNhapHang.QL_PheDuyet == true) ? true : false;
                    double giaTri = double.Parse(phieuNhapHang.GiaTri.ToString());
                    edtGiaTriPhieuNhap.Text = giaTri.ToString("N0");
                    edtNgayNhap.Format = DateTimePickerFormat.Custom;
                    edtNgayNhap.CustomFormat = "dd/MM/yyyy";
                    edtNgayNhap.Value = (DateTime)phieuNhapHang.NgayNhap;
                }
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PhieuNhapHang phieuNhapHang = new PhieuNhapHang();
            phieuNhapHang.NgayNhap = DateTime.Now;
            phieuNhapHang.MaNhanVien = _NhanVien.MaNhanVien;
            phieuNhapHang.MaNhaCungCap = (int)cbbNhaCungCap.SelectedValue;
            phieuNhapHang.TrangThai = false;
            phieuNhapHang.GiaTri = 0;
            phieuNhapHang.MaPhieuNhap = (int)cbbPhieuNhap.SelectedValue;
            phieuNhapHang.QL_PheDuyet = false;

            bool kq = _PhieuNhapHangService.Update(phieuNhapHang);
            if (kq == true)
            {
                PhieuNhapHang pnNew = _PhieuNhapHangService.getOneByID(phieuNhapHang.MaPhieuNhap);
                dsPhieuNhap = _PhieuNhapHangService.getAll();
                LoadCbbPhieuNhapHang();
                cbbPhieuNhap.Text = pnNew.MaPhieuNhap.ToString();
                cbbNhaCungCap.Text = pnNew.NhaCungCap.TenNhaCungCap;
                edtNgayNhap.Value = (DateTime)pnNew.NgayNhap;
                edtGiaTriPhieuNhap.Text = pnNew.GiaTri.ToString();
                cbDaNhanHang.Checked = (bool)pnNew.TrangThai;
                cbQuanLyDaDuyet.Checked = (bool)pnNew.QL_PheDuyet;

                List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(pnNew.MaPhieuNhap);
                if (dsChiTietPhieuNhap != null)
                {
                    cbbNhaCungCap.Text = _NhaCungCapService.getOneByID((int)pnNew.MaNhaCungCap).TenNhaCungCap;
                    KhoiTaoImagesListChiTietPhieuNhap();
                    InitListViewChiTietPhieuNhap();
                    Load_ListViewDanhSachSanPham(dsChiTietPhieuNhap);
                    cbDaNhanHang.Checked = (pnNew.TrangThai == true) ? true : false;
                    cbQuanLyDaDuyet.Checked = (pnNew.QL_PheDuyet == true) ? true : false;
                    double giaTri = double.Parse(pnNew.GiaTri.ToString());
                    edtGiaTriPhieuNhap.Text = giaTri.ToString("N0");
                    edtNgayNhap.Format = DateTimePickerFormat.Custom;
                    edtNgayNhap.CustomFormat = "dd/MM/yyyy";
                    edtNgayNhap.Value = (DateTime)pnNew.NgayNhap;
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MaPhieuNhap = (int)cbbPhieuNhap.SelectedValue;

            bool kq = _PhieuNhapHangService.Delete(MaPhieuNhap);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                dsPhieuNhap = _PhieuNhapHangService.getAll();
                LoadCbbPhieuNhapHang();
                LoadCbbPhieuNhapHang_QLPN();

                KhoiTaoImagesListChiTietPhieuNhap();
                InitListViewChiTietPhieuNhap();

            }
            else
            {

                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }

        private void btnThemChiTietSanPham_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.MaPhieuNhap = int.Parse(cbbPhieuNhap.Text.Trim());
            chiTietPhieuNhap.MaSanPham = int.Parse(edtMaSP.Text.Trim());
            chiTietPhieuNhap.SoLuong = int.Parse(edtSLN.Text.Trim());
            chiTietPhieuNhap.Gia = 0;
            chiTietPhieuNhap.TongCong = 0;
            chiTietPhieuNhap.TrangThai = false;
            ChiTietPhieuNhap kq = _ChiTietPhieuNhapService.Insert(chiTietPhieuNhap);
            if (kq != null)
            {
                List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(kq.MaPhieuNhap);
                if (dsChiTietPhieuNhap != null)
                {
                    KhoiTaoImagesListChiTietPhieuNhap();
                    InitListViewChiTietPhieuNhap();
                    Load_ListViewDanhSachSanPham(dsChiTietPhieuNhap);
                }
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }



        //====================================================Tab quan ly phieu nhap===============================================
        private void LoadTabQuanLyPhieuNhap()
        {
            
            LoadCbbNhaCungCap_QLPN();
            LoadCbbPhieuNhapHang_QLPN();
            KhoiTaoImagesListChiTietPhieuNhap_QLPN();
            InitListViewChiTietPhieuNhap_QLPN();
            edtTenNhanVien_QLPN.Text = _NhanVien.TenNhanVien;

            //Load_ListViewDanhSachSanPhamNhap_QLPN();
        }
        private void KhoiTaoImagesListChiTietPhieuNhap_QLPN()
        {
            image_list__QLPN.Images.Clear();
            image_list__QLPN = new ImageList() { ImageSize = new Size(90, 60) };
        }
        private void LoadCbbPhieuNhapHang_QLPN()
        {
            cbbPhieuNhap_QLPN.DataSource = dsPhieuNhap;
            cbbPhieuNhap_QLPN.DisplayMember = "MaPhieuNhap";
            cbbPhieuNhap_QLPN.ValueMember = "MaPhieuNhap";
        }
        private void LoadCbbNhaCungCap_QLPN()
        {
            cbbNhaCungCap_QLPN.DataSource = dsNhaCungCap;
            cbbNhaCungCap_QLPN.DisplayMember = "TenNhaCungCap";
            cbbNhaCungCap_QLPN.ValueMember = "MaNhanCungCap";
        }
        public void InitListViewChiTietPhieuNhap_QLPN()
        {
            //"Hình ảnh", "Mã sản phẩm" ,"Tên sản phẩm","Số lượng","Giá bán","Tổng cộng","Trạng thái"
            lvDsSanPhamNhap_QLPN.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            ColumnHeader header5 = new ColumnHeader();
            ColumnHeader header6 = new ColumnHeader();
            ColumnHeader header7 = new ColumnHeader();

            int width = lvDsSanPhamNhap_QLPN.Width;
            header.Text = "Hình ảnh";
            header.Name = "HinhAnh";
            header.Width = (int)Math.Ceiling(width * 0.144);

            header1.Text = "Mã sản phẩm";
            header1.Name = "MaSP";
            header1.Width = (int)Math.Ceiling(width * 0.12); ;

            header2.Text = "Tên sản phẩm";
            header2.Name = "TenSanPham";
            header2.Width = (int)Math.Ceiling(width * 0.2);

            header3.Text = "Số lượng";
            header3.Name = "SoLuong";
            header3.Width = (int)Math.Ceiling(width * 0.09);

            header4.Text = "Giá nhập";
            header4.Name = "GiaNhap";
            header4.Width = (int)Math.Ceiling(width * 0.12); ;

            header5.Text = "Tổng cộng";
            header5.Name = "TongCong";
            header5.Width = (int)Math.Ceiling(width * 0.125);

            header6.Text = "Trạng thái";
            header6.Name = "TrangThai";
            header6.Width = (int)Math.Ceiling(width * 0.12);

            header7.Text = "";
            header7.Name = "delete";
            header7.Width = (int)Math.Ceiling(width * 0.07);



            lvDsSanPhamNhap_QLPN.Columns.Add(header);
            lvDsSanPhamNhap_QLPN.Columns.Add(header1);
            lvDsSanPhamNhap_QLPN.Columns.Add(header2);
            lvDsSanPhamNhap_QLPN.Columns.Add(header3);
            lvDsSanPhamNhap_QLPN.Columns.Add(header4);
            lvDsSanPhamNhap_QLPN.Columns.Add(header5);
            lvDsSanPhamNhap_QLPN.Columns.Add(header6);
            lvDsSanPhamNhap_QLPN.Columns.Add(header7);
        }

        private void Load_ListViewDanhSachSanPhamNhap_QLPN(List<ChiTietPhieuNhap> chiTietPhieuNhaps)
        {
            lvDsSanPhamNhap_QLPN.Items.Clear();
            int dem = 0;
            lvDsSanPhamNhap_QLPN.SmallImageList = image_list__QLPN;
            foreach (ChiTietPhieuNhap t in chiTietPhieuNhaps)
            {
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                string[] fileName_ = sanPham.HinhAnh.Split('/');

                string path = Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1];
                if (File.Exists(path))
                    image_list__QLPN.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]));
                else
                    image_list__QLPN.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\default.png"));
                //image_list__QLPN.Images.Add(cloudinaryService.getBitMapImage(sanPham.HinhAnh));
            }


            foreach (ChiTietPhieuNhap t in chiTietPhieuNhaps)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                item.SubItems.Add(sanPham.MaSanPham.ToString());
                item.SubItems.Add(sanPham.TenSanPham);
                item.SubItems.Add(t.SoLuong.ToString());
                item.SubItems.Add((t.Gia == null) ? "0" : t.Gia.ToString());
                item.SubItems.Add((t.TongCong == null) ? "0" : t.TongCong.ToString());
                item.SubItems.Add(t.TrangThai.ToString());
                

                item.SubItems.Add("delete");
                lvDsSanPhamNhap_QLPN.Items.Add(item);
                dem++;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (edtMaSP_QLPN.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn một chi tiết phiếu nhập", "Thông báo");
            }
            else
            {
                int maPhieuNhap = int.Parse(cbbPhieuNhap_QLPN.Text.Trim());
                int maSanPham = int.Parse(edtMaSP_QLPN.Text.Trim());
                bool kq= _ChiTietPhieuNhapService.Delete(maPhieuNhap, maSanPham);
                if (kq == true)
                {
                    KhoiTaoImagesListChiTietPhieuNhap_QLPN();
                    List<ChiTietPhieuNhap> ds=_ChiTietPhieuNhapService.getListByIdPhieuNhap(maPhieuNhap);
                    if (ds != null)
                    { 
                        Load_ListViewDanhSachSanPhamNhap_QLPN(ds);
                    }
                    MessageBox.Show("Đã hủy nhập sản phẩm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Hủy nhập sản phẩm thất bại", "Thông báo");
                }
            }
        }

        private void cbbPhieuNhap_QLPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhieuNhap_QLPN.SelectedIndex >= 0)
            {
                PhieuNhapHang phieuNhapHang = (PhieuNhapHang)cbbPhieuNhap_QLPN.SelectedItem;

                if (phieuNhapHang != null)
                {
                    List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(phieuNhapHang.MaPhieuNhap);
                    if (dsChiTietPhieuNhap != null)
                    {
                        cbbNhaCungCap_QLPN.Text = phieuNhapHang.NhaCungCap.TenNhaCungCap;
                        
                        KhoiTaoImagesListChiTietPhieuNhap_QLPN();
                        InitListViewChiTietPhieuNhap_QLPN();

                        
                        cbDaNhanHang_QLPN.Checked = (phieuNhapHang.TrangThai == true) ? true : false;
                        cbQLDaDuyet_QLPN.Checked = (phieuNhapHang.QL_PheDuyet == true) ? true : false;
                        double giaTri = double.Parse(phieuNhapHang.GiaTri.ToString());
                        edtGiaTriPhieuNhap_QLPN.Text = giaTri.ToString("N0");
                        edtNgayNhap_QLPN.Format = DateTimePickerFormat.Custom;
                        edtNgayNhap_QLPN.CustomFormat = "dd/MM/yyyy";
                        edtNgayNhap.Value = (DateTime)phieuNhapHang.NgayNhap;

                        Load_ListViewDanhSachSanPhamNhap_QLPN(dsChiTietPhieuNhap);
                    }
                    if (phieuNhapHang.QL_PheDuyet != true)
                    {
                        panel7.Enabled = false;
                    }
                    else
                    {
                        cbQLDaDuyet_QLPN.Enabled= false;
                        panel7.Enabled = true;
                    }

                }
            }
        }

        private void lvDsSanPhamNhap_QLPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsSanPhamNhap_QLPN.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDsSanPhamNhap_QLPN.SelectedItems[0];
                SanPham sp = _SanPhamService.getOneByID(int.Parse(item.SubItems[1].Text));
                ChiTietPhieuNhap chiTietPhieuNhap = _ChiTietPhieuNhapService.getOneById(int.Parse(cbbPhieuNhap_QLPN.Text.Trim()), sp.MaSanPham);
                if (chiTietPhieuNhap != null)
                {
                    edtMaSP_QLPN.Text = sp.MaSanPham.ToString();
                    edtTenSP_QLPN.Text = sp.TenSanPham;
                    edtLoaiSP_QLPN.Text = sp.LoaiSanPham.TenLoai;
                    edtDVT_QLPN.Text = sp.DonViTinh;
                    edtSLD_QLPN.Text = chiTietPhieuNhap.SoLuong.ToString();
                    double gia = (float)float.Parse(chiTietPhieuNhap.Gia.ToString());
                    edtGiaSP_QLPN.Text = gia.ToString("N0");
                    if (chiTietPhieuNhap.Gia != 0)
                    {
                        edtGiaSP_QLPN.ReadOnly = true;
                        double soLuongDaNhan = (double)(chiTietPhieuNhap.TongCong / chiTietPhieuNhap.Gia);
                        SoLuongDaNhanTextBox.Text = soLuongDaNhan.ToString();
                    }
                    else 
                    {
                        edtGiaSP_QLPN.ReadOnly = false;
                        SoLuongDaNhanTextBox.Text = "0";
                    }
                    edtSLN_QLPN.Text = "0";//chiTietPhieuNhap.SoLuong.ToString(); ;
                    edtTrangThai_QLPN.Text = (chiTietPhieuNhap.TrangThai == true) ? "Đã giao" : "Chưa giao";
                    edtSLN.Focus();
                }
                
            }
        }

        private void btnDaNhan_QLPN_Click(object sender, EventArgs e)
        {
            if (edtGiaSP_QLPN.Text.Trim().Equals("0"))
            {
                MessageBox.Show("Giá nhập phải lớn hơn 0", "Thông báo");
            }
            else if (int.Parse(edtSLN_QLPN.Text.Trim()) <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo");
            }
            else { 
                int soLuongNhap= int.Parse(edtSLN_QLPN.Text.Trim());
                ChiTietPhieuNhap ct=new ChiTietPhieuNhap();
                ct.MaPhieuNhap = int.Parse(cbbPhieuNhap_QLPN.Text.Trim());
                ct.MaSanPham = int.Parse(edtMaSP_QLPN.Text.Trim());
                ChiTietPhieuNhap ctTest = _ChiTietPhieuNhapService.getOneById(ct.MaPhieuNhap, ct.MaSanPham);
                ct.Gia = double.Parse(edtGiaSP_QLPN.Text.Trim());
                if (ctTest.Gia != 0)
                {
                    double soLuongDaNhan = (double)(ctTest.TongCong / ctTest.Gia);

                    if (int.Parse(edtSLN_QLPN.Text.Trim()) >= int.Parse(edtSLD_QLPN.Text.Trim()) + soLuongDaNhan)
                    {
                        MessageBox.Show("Số lượng nhập lớn hơn số lượng đặt\n Chỉ nhận đủ số lượng đã đặt", "Thông báo"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ct.SoLuong = int.Parse(edtSLD_QLPN.Text.Trim());
                        ct.TongCong = ct.Gia * int.Parse(edtSLD_QLPN.Text.Trim());
                    }
                    else
                    {
                        ct.SoLuong = int.Parse(edtSLD_QLPN.Text.Trim());
                        ct.TongCong = ct.Gia * ((int.Parse(edtSLN_QLPN.Text.Trim())) + soLuongDaNhan);
                    }

                }
                else
                {
                    if (int.Parse(edtSLN_QLPN.Text.Trim()) >= int.Parse(edtSLD_QLPN.Text.Trim()))
                    {
                        MessageBox.Show("Số lượng nhập lớn hơn số lượng đặt\n Chỉ nhận đủ số lượng đã đặt", "Thông báo"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ct.SoLuong = int.Parse(edtSLD_QLPN.Text.Trim());
                        ct.TongCong = ct.SoLuong * ct.Gia;
                    }
                    else
                    {
                        ct.SoLuong = int.Parse(edtSLD_QLPN.Text.Trim());
                        ct.TongCong = ct.Gia * int.Parse(edtSLN_QLPN.Text.Trim());
                    }
                }
               
                
                ct.TrangThai=(ct.TongCong==ct.SoLuong*ct.Gia)?true:false;
                bool kq = _ChiTietPhieuNhapService.Update(ct);
                if (kq == true)
                {
                    SanPham spUpdate = _SanPhamService.getOneByID(ct.MaSanPham);
                    if (spUpdate != null)
                    {
                        spUpdate.SoLuongTon += soLuongNhap;
                        kq = _SanPhamService.update(spUpdate);
                    }

                    List<ChiTietPhieuNhap> dsChiTietPhieuNhap = _ChiTietPhieuNhapService.getListByIdPhieuNhap(ct.MaPhieuNhap);
                    double giaTriPhieuNhap = 0;
                    if (dsChiTietPhieuNhap != null)
                    {
                        KhoiTaoImagesListChiTietPhieuNhap_QLPN();
                        InitListViewChiTietPhieuNhap_QLPN();
                        Load_ListViewDanhSachSanPhamNhap_QLPN(dsChiTietPhieuNhap);

                        foreach (ChiTietPhieuNhap item in dsChiTietPhieuNhap)
                        {
                            giaTriPhieuNhap = giaTriPhieuNhap + (double)(item.Gia * item.SoLuong);
                            if (item.TrangThai == false)
                            {
                                kq = false;

                            }
                        }
                    }
                    if (kq == true)
                    {
                        PhieuNhapHang pn = _PhieuNhapHangService.getOneByID(ct.MaPhieuNhap);
                        pn.TrangThai = true;
                        pn.GiaTri = giaTriPhieuNhap;
                        kq = _PhieuNhapHangService.Update2(pn);
                        if (kq == true)
                        {
                            cbDaNhanHang_QLPN.Checked = true;
                            MessageBox.Show("Phiếu nhập hàng: "+ct.MaPhieuNhap+ "\n Đã nhận hàng đủ", "Thông báo"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnCapNhat_QLPN_Click(object sender, EventArgs e)
        {
            PhieuNhapHang phieuNhapHang = _PhieuNhapHangService.getOneByID(int.Parse(cbbPhieuNhap_QLPN.Text.Trim()));
            if (phieuNhapHang != null)
            { 
                phieuNhapHang.QL_PheDuyet = true;
                bool kq=_PhieuNhapHangService.Update(phieuNhapHang);
                if (kq == true)
                {
                    MessageBox.Show("Đã xác nhận phiếu nhập", "Thông báo"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Xác nhận phiếu nhập thất bại", "Thông báo"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_QLPN_Click(object sender, EventArgs e)
        {
            int MaPhieuNhap = (int)cbbPhieuNhap.SelectedValue;

            bool kq = _PhieuNhapHangService.Delete(MaPhieuNhap);
            if (kq)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                dsPhieuNhap = _PhieuNhapHangService.getAll();
                LoadCbbPhieuNhapHang();
                LoadCbbPhieuNhapHang_QLPN();

                KhoiTaoImagesListChiTietPhieuNhap();
                InitListViewChiTietPhieuNhap();

            }
            else
            {

                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
