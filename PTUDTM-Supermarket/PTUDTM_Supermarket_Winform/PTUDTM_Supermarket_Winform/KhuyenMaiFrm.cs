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
    public partial class KhuyenMaiFrm : Form
    {
        private SanPhamService _SanPhamService;
        private KhuyenMaiService _KhuyenMaiService;
        private ChiTietKhuyenMaiService _ChiTietKhuyenMaiService;

        private List<SanPham> Ds_SanPham;
        private List<KhuyenMai> Ds_KhuyenMai;
        private CloudinaryService cloudinaryService;
        public KhuyenMaiFrm()
        {
            InitializeComponent();
            _SanPhamService = new SanPhamService(); 
            _KhuyenMaiService = new KhuyenMaiService();
            _ChiTietKhuyenMaiService = new ChiTietKhuyenMaiService();
            cloudinaryService = new CloudinaryService();

            NgayBatDauTextBox.Format = DateTimePickerFormat.Custom;
            NgayBatDauTextBox.CustomFormat = "dd/MM/yyyy";
            NgayKetThucTextBox.Format = DateTimePickerFormat.Custom;
            NgayKetThucTextBox.CustomFormat = "dd/MM/yyyy";

            Ds_SanPham = _SanPhamService.getAll();
            Ds_KhuyenMai = _KhuyenMaiService.GetAll();

            KhoiTaoImagesListSanPham();
            InitListViewDsSanPham();
            Load_ListViewDanhSachSanPham(Ds_SanPham);

            InitListViewDsKhuyenMai();
            Load_ListViewDanhKhuyenMai(Ds_KhuyenMai);


        }

        public void InitListViewDsSanPham()
        {
            listViewDsSanPham.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            int width = listViewDsSanPham.Width;
            header.Text = "Hình ảnh";
            header.Name = "HinhAnh";
            header.Width = (int)Math.Ceiling(width * 0.3);

            header1.Text = "MaSP";
            header1.Name = "MaSP";
            header1.Width = (int)Math.Ceiling(width * 0.15); ;

            header2.Text = "Tên sản phẩm";
            header2.Name = "TenSanPham";
            header2.Width = (int)Math.Ceiling(width * 0.5);



            listViewDsSanPham.Columns.Add(header);
            listViewDsSanPham.Columns.Add(header1);
            listViewDsSanPham.Columns.Add(header2);
        }

        public void InitListViewDsSanPhamKhuyenMai()
        {
            listViewDsSanPhamKhuyenMai.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            int width = listViewDsSanPhamKhuyenMai.Width;
            header.Text = "Hình ảnh";
            header.Name = "HinhAnh";
            header.Width = (int)Math.Ceiling(width * 0.3);

            header1.Text = "MaSP";
            header1.Name = "MaSP";
            header1.Width = (int)Math.Ceiling(width * 0.15); 

            header2.Text = "Tên sản phẩm";
            header2.Name = "TenSanPham";
            header2.Width = (int)Math.Ceiling(width * 0.4);



            listViewDsSanPhamKhuyenMai.Columns.Add(header);
            listViewDsSanPhamKhuyenMai.Columns.Add(header1);
            listViewDsSanPhamKhuyenMai.Columns.Add(header2);
        }
        public void InitListViewDsKhuyenMai()
        {
            listViewKhuyenMai.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            int width = listViewDsSanPham.Width;
            header.Text = "ID";
            header.Name = "MaKhuyenMai";
            header.Width = (int)Math.Ceiling(width * 0.1);

            header1.Text = "Ngày bắt đầu";
            header1.Name = "NgayBatDau";
            header1.Width = (int)Math.Ceiling(width * 0.19); ;

            header2.Text = "Ngày kết thúc";
            header2.Name = "NgayKetThuc";
            header2.Width = (int)Math.Ceiling(width * 0.19);

            header3.Text = "Nội dung";
            header3.Name = "NoiDung";
            header3.Width = (int)Math.Ceiling(width * 0.3); ;

            header4.Text = "Giá trị";
            header4.Name = "GiaTriKhuyenMai";
            header4.Width = (int)Math.Ceiling(width * 0.2);



            listViewKhuyenMai.Columns.Add(header);
            listViewKhuyenMai.Columns.Add(header3);
            listViewKhuyenMai.Columns.Add(header1);
            listViewKhuyenMai.Columns.Add(header2);
            listViewKhuyenMai.Columns.Add(header4);
        }
        private void KhoiTaoImagesListSanPham()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(100, 90) };
        }

        private void KhoiTaoImagesListSanPhamKhuyenMai()
        {
            image_list_sanphamkhuyenmai.Images.Clear();
            image_list_sanphamkhuyenmai = new ImageList() { ImageSize = new Size(100, 90) };
        }
        private void Load_ListViewDanhSachSanPham(List<SanPham> dsSanPham)
        {
            listViewDsSanPham.Items.Clear();
            int dem = 0;
            listViewDsSanPham.SmallImageList = image_list;
            foreach (SanPham t in dsSanPham)
            {
                //SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                //image_list.Images.Add(cloudinaryService.getBitMapImage(t.HinhAnh));
                string[] fileName_ = t.HinhAnh.Split('/');
                image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]));
            }


            foreach (SanPham t in dsSanPham)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                item.SubItems.Add(sanPham.MaSanPham.ToString());
                item.SubItems.Add(sanPham.TenSanPham);
                listViewDsSanPham.Items.Add(item);
                dem++;
            }
        }

        private void Load_ListViewDanhSachSanPhamKhuyenMai(List<ChiTietKhuyenMai> dsSanPhamKhuyenMai)
        {
            listViewDsSanPhamKhuyenMai.Items.Clear();
            int dem = 0;
            listViewDsSanPhamKhuyenMai.SmallImageList = image_list_sanphamkhuyenmai;
            foreach (ChiTietKhuyenMai t in dsSanPhamKhuyenMai)
            {
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                //image_list_sanphamkhuyenmai.Images.Add(cloudinaryService.getBitMapImage(sanPham.HinhAnh));
                string[] fileName_ = sanPham.HinhAnh.Split('/');
                image_list_sanphamkhuyenmai.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]));
            }


            foreach (ChiTietKhuyenMai t in dsSanPhamKhuyenMai)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                SanPham sanPham = _SanPhamService.getOneByID(t.MaSanPham);
                item.SubItems.Add(sanPham.MaSanPham.ToString());
                item.SubItems.Add(sanPham.TenSanPham);
                listViewDsSanPhamKhuyenMai.Items.Add(item);
                dem++;
            }
        }


        private void Load_ListViewDanhKhuyenMai(List<KhuyenMai> dsKhuyenMai)
        {
            listViewKhuyenMai.Items.Clear();

            foreach (KhuyenMai t in dsKhuyenMai)
            {
                ListViewItem item = new ListViewItem();
                item.Text = t.MaKhuyenMai.ToString();
                item.SubItems.Add(t.NoiDung);
                item.SubItems.Add(t.NgayBatDau.ToString());
                item.SubItems.Add(t.NgayKetThuc.ToString());
                item.SubItems.Add(t.GiaTriKhuyenMai.ToString());
                listViewKhuyenMai.Items.Add(item);
            }
        }


        private void ThemButton_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.NgayBatDau = NgayBatDauTextBox.Value;
            km.NgayKetThuc = NgayKetThucTextBox.Value;
            if (NoiDungTextBox.Text.Equals(""))
            {
                MessageBox.Show("Nội dung không để trống", "Thông báo");
            }
            else if (km.NgayBatDau > km.NgayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo");
            }
            else if (GiaTriKhuyenMaiTextBox.Text.Equals("") ||( int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim()) <= 0
                && (int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim()) > 100)))
            {
                MessageBox.Show("Giá trị khuyến mãi phải lớn hơn 0 và bé hơn bằng 100", "Thông báo");
            }
            else {
                km.NgayBatDau = NgayBatDauTextBox.Value;
                km.NgayKetThuc = NgayKetThucTextBox.Value;
                km.NoiDung = NoiDungTextBox.Text.Trim();
                km.GiaTriKhuyenMai = int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim());
                KhuyenMai khuyenMai=_KhuyenMaiService.Insert(km);
                if(khuyenMai != null)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    Ds_KhuyenMai = _KhuyenMaiService.GetAll();
                    InitListViewDsKhuyenMai();
                    Load_ListViewDanhKhuyenMai(Ds_KhuyenMai);
                }

                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
            }
        }

        private void listViewKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKhuyenMai.SelectedItems.Count > 0)
            {
                groupBox2.Enabled = true;
                btnSuaKhuyenMai.Enabled = true;
                btnXoaKhuyenMai.Enabled=true;

                ListViewItem item = listViewKhuyenMai.SelectedItems[0];
                MaKhuyenMaiTextBox.Text = item.Text;
                NoiDungTextBox.Text = item.SubItems[1].Text;
                NgayBatDauTextBox.Text = item.SubItems[2].Text;
                NgayKetThucTextBox.Text = item.SubItems[3].Text;
                GiaTriKhuyenMaiTextBox.Text = item.SubItems[4].Text;

                List<ChiTietKhuyenMai> chiTietKhuyenMais = _ChiTietKhuyenMaiService.GetListByIdKhuyenMai(int.Parse(item.Text.Trim()));
                if (chiTietKhuyenMais != null)
                {
                    KhoiTaoImagesListSanPhamKhuyenMai();
                    InitListViewDsSanPhamKhuyenMai();
                    Load_ListViewDanhSachSanPhamKhuyenMai(chiTietKhuyenMais);

                
                }
            }
        }

        private void listViewDsSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDsSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewDsSanPham.SelectedItems[0];
                MaSanPhamTimKiem.Text = item.SubItems[1].Text;
                TenSanPhamTimKiem.Text = item.SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MaKhuyenMaiTextBox.Text.Equals("") || int.Parse(MaKhuyenMaiTextBox.Text.Trim()) <= 0)
            {
                MessageBox.Show("Không tìm thấy khuyến mãi để thêm vào", "Thông báo");
            }
            else if (MaSanPhamTimKiem.Text.Equals(""))
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
            }
            else
            {
                ChiTietKhuyenMai ct=new ChiTietKhuyenMai();
                ct.MaSanPham = int.Parse(MaSanPhamTimKiem.Text.Trim());
                ct.MaKhuyenMai = int.Parse(MaKhuyenMaiTextBox.Text.Trim());
                ct.GiaTriKhuyenMai = int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim());
                ChiTietKhuyenMai test=_ChiTietKhuyenMaiService.Insert(ct);
                if (test != null)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    List<ChiTietKhuyenMai> chiTietKhuyenMais = _ChiTietKhuyenMaiService.GetListByIdKhuyenMai(ct.MaKhuyenMai);
                    if (chiTietKhuyenMais != null)
                    {
                        KhoiTaoImagesListSanPhamKhuyenMai();
                        InitListViewDsSanPhamKhuyenMai();
                        Load_ListViewDanhSachSanPhamKhuyenMai(chiTietKhuyenMais);
                    }
                    else {
                        MessageBox.Show("Thêm không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
            }
        }

        private void btnSuaKhuyenMai_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.MaKhuyenMai=int.Parse(MaKhuyenMaiTextBox.Text.Trim());
            km.NgayBatDau = NgayBatDauTextBox.Value;
            km.NgayKetThuc = NgayKetThucTextBox.Value;
            if (NoiDungTextBox.Text.Equals(""))
            {
                MessageBox.Show("Nội dung không để trống", "Thông báo");
            }
            else if (km.NgayBatDau > km.NgayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo");
            }
            else if (GiaTriKhuyenMaiTextBox.Text.Equals("") || (int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim()) <= 0
                && (int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim()) > 100)))
            {
                MessageBox.Show("Giá trị khuyến mãi phải lớn hơn 0 và bé hơn bằng 100", "Thông báo");
            }
            else
            {
                km.NgayBatDau = NgayBatDauTextBox.Value;
                km.NgayKetThuc = NgayKetThucTextBox.Value;
                km.NoiDung = NoiDungTextBox.Text.Trim();
                km.GiaTriKhuyenMai = int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim());
                bool kq= _KhuyenMaiService.Update(km);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    Ds_KhuyenMai = _KhuyenMaiService.GetAll();
                    InitListViewDsKhuyenMai();
                    Load_ListViewDanhKhuyenMai(Ds_KhuyenMai);
                }
                else {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                }
            }
        }

        private void btnXoaKhuyenMai_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.MaKhuyenMai = int.Parse(MaKhuyenMaiTextBox.Text.Trim());

            //km.NgayBatDau = NgayBatDauTextBox.Value;
            //km.NgayKetThuc = NgayKetThucTextBox.Value;
            //km.NoiDung = NoiDungTextBox.Text.Trim();
            //km.GiaTriKhuyenMai = int.Parse(GiaTriKhuyenMaiTextBox.Text.Trim());
            bool kq = _KhuyenMaiService.Delete(km.MaKhuyenMai);
            if (kq == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                Ds_KhuyenMai = _KhuyenMaiService.GetAll();
                InitListViewDsKhuyenMai();
                Load_ListViewDanhKhuyenMai(Ds_KhuyenMai);

                KhoiTaoImagesListSanPhamKhuyenMai();
                InitListViewDsSanPhamKhuyenMai();
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo");
            }
        }

        private void TimSanPhamButton_Click(object sender, EventArgs e)
        {
            List<SanPham> ds = _SanPhamService.TimKiem(MaSanPhamTimKiem.Text.Trim());
            if (ds != null)
            {
                if (ds.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MaSanPhamTimKiem.Text = "";

                }
                else if (ds.Count == 1)
                {
                    SanPham sp = ds[0];
                    MessageBox.Show("Mã: " + sp.MaSanPham + " - " + sp.TenSanPham +
                    "\n Giá: " + sp.Gia +
                    "\n Số lượng tồn:" + sp.SoLuongTon, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TenSanPhamTimKiem.Text = sp.TenSanPham;
                }
                else
                {
                    KhoiTaoImagesListSanPham();
                    InitListViewDsSanPham();
                    Load_ListViewDanhSachSanPham(ds);
                }

            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            KhoiTaoImagesListSanPham();
            InitListViewDsSanPham();
            Load_ListViewDanhSachSanPham(Ds_SanPham);
        }
    }
}
