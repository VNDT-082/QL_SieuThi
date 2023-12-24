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
    public partial class SanPhamFrm : Form
    {
        private SanPhamService _SanPhamService;
        private LoaiSanPhamService _LoaiSanPhamService;

        private List<SanPham> dsSanPham;
        private List<LoaiSanPham> dsLoai;

        private CloudinaryService cloudinaryService;
        public SanPhamFrm()
        {
            InitializeComponent();
            _SanPhamService = new SanPhamService();
            _LoaiSanPhamService=new LoaiSanPhamService();
            cloudinaryService = new CloudinaryService();

            dsSanPham = _SanPhamService.getAll();

            dsLoai=_LoaiSanPhamService.GetAll();
            KhoiTaoImagesList();
            InitListView();
            Load_ListViewDanhSachSanPham();

            if (dsLoai != null)
            {
                edtLoaiSP.DataSource = dsLoai;
                edtLoaiSP.DisplayMember = "TenLoai";
                edtLoaiSP.ValueMember = "MaLoai";    
            }

            edtDVT.Items.Add("Chai");
            edtDVT.Items.Add("Thùng");
            edtDVT.Items.Add("Gói");
            edtDVT.Items.Add("Kg");
        }
        private void KhoiTaoImagesList()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(100, 90) };
        }
        public void InitListView()
        {
            listViewSanPham.Clear();
            ColumnHeader header = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            ColumnHeader header5 = new ColumnHeader();
            ColumnHeader header6 = new ColumnHeader();
            ColumnHeader header7 = new ColumnHeader();
            int width = listViewSanPham.Width;
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

            listViewSanPham.Columns.Add(header);
            listViewSanPham.Columns.Add(header1);
            listViewSanPham.Columns.Add(header6);
            listViewSanPham.Columns.Add(header3);
            listViewSanPham.Columns.Add(header5);
            listViewSanPham.Columns.Add(header2);
            listViewSanPham.Columns.Add(header4);
            listViewSanPham.Columns.Add(header7);
        }

        private void Load_ListViewDanhSachSanPham()
        {
            listViewSanPham.Items.Clear();
            int dem = 0;
            listViewSanPham.SmallImageList = image_list;
            foreach (SanPham t in dsSanPham)
            {
                //image_list.Images.Add(cloudinaryService.getBitMapImage(t.HinhAnh));
                string[] fileName_ = t.HinhAnh.Split('/');
                image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length-1]));
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
                listViewSanPham.Items.Add(item);
                dem++;
            }
        }

        private void listViewSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewSanPham.SelectedItems[0];
                SanPham sp = _SanPhamService.getOneByID(int.Parse(item.SubItems[7].Text));
                edtMaSP.Text = sp.MaSanPham.ToString();
                edtTenSP.Text = sp.TenSanPham;
                edtLoaiSP.Text = sp.LoaiSanPham.TenLoai;
                edtDVT.Text = sp.DonViTinh;
                edtSLT.Text = sp.SoLuongTon.ToString();
                double gia = (float)float.Parse(sp.Gia.ToString());
                edtGiaSP.Text = gia.ToString("N0");
                edtMoTa.Text = sp.MoTa;
                edtMoTa.Focus();

                //pictureBox1.Image = cloudinaryService.getBitMapImage(sp.HinhAnh);
                string[] fileName_ = sp.HinhAnh.Split('/');
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private bool UpLoadFile(OpenFileDialog Upload, String FileName)
        {
            try
            {


                string path = Application.StartupPath + "\\sanpham\\"+FileName;
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

        private void btnChoosenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = @"Desktop";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                string fileName = openFileDialog1.FileName;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SanPham sanPham= new SanPham();
            sanPham.MaSanPham = 0;
            sanPham.TenSanPham = edtTenSP.Text.Trim();
            sanPham.MaLoai =int.Parse(edtLoaiSP.SelectedValue.ToString());
            sanPham.DonViTinh= edtDVT.Text.Trim();
            sanPham.SoLuongTon = 0;
            sanPham.Gia=double.Parse(edtGiaSP.Text.Trim());
            sanPham.MoTa = edtMoTa.Text.Trim();
            sanPham.HinhAnh = "https://res.cloudinary.com/dozsz2dqi/image/upload/v1701287859/QL_SieuThi/opebdjy24xgqhlyfruol.png";
            SanPham sp =_SanPhamService.insertOne(sanPham);

            if (sp != null)
            {
                MessageBox.Show("Thêm sản phẩmt hành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bool kq = UpLoadFile(openFileDialog1);
                //if (kq == true)
                //{
                    
                //}
                dsSanPham = _SanPhamService.getAll();
                KhoiTaoImagesList();
                InitListView();
                Load_ListViewDanhSachSanPham();

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSanPham = int.Parse(edtMaSP.Text.Trim());
            sanPham.TenSanPham = edtTenSP.Text.Trim();
            sanPham.MaLoai = int.Parse(edtLoaiSP.SelectedValue.ToString());
            sanPham.DonViTinh = edtDVT.Text.Trim();
            sanPham.SoLuongTon = int.Parse(edtSLT.Text.Trim());
            sanPham.Gia = double.Parse(edtGiaSP.Text.Trim());
            sanPham.MoTa = edtMoTa.Text.Trim();


            bool kq = _SanPhamService.update(sanPham);

            if (kq == true)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsSanPham = _SanPhamService.getAll();
                KhoiTaoImagesList();
                InitListView();
                Load_ListViewDanhSachSanPham();

            }
            else {
                MessageBox.Show("Cập nhật sản phẩm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("itemThem"))
            {
                LoaiSanPham lsp= new LoaiSanPham();
                lsp.MaLoai = 0;
                lsp.TenLoai= "";
                lsp.MoTa= "";
                NewLoaiSanPhamFrm NewFrm = new NewLoaiSanPhamFrm(lsp);
                NewFrm.ShowDialog();


            }
            else if (e.ClickedItem.Name.Equals("itemXoa"))
            {

            }
            else if (e.ClickedItem.Name.Equals("itemReload"))
            {
                _LoaiSanPhamService = new LoaiSanPhamService();
                dsLoai = _LoaiSanPhamService.GetAll();
                if (dsLoai != null)
                {
                    edtLoaiSP.DataSource = dsLoai;
                    edtLoaiSP.DisplayMember = "TenLoai";
                    edtLoaiSP.ValueMember = "MaLoai";
                }
            }
            else
            {
                LoaiSanPham lsp = _LoaiSanPhamService.GetOneById(int.Parse(edtLoaiSP.SelectedValue.ToString()));
                if (lsp != null)
                {
                    NewLoaiSanPhamFrm NewFrm = new NewLoaiSanPhamFrm(lsp);
                    NewFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUploadHinh_Click(object sender, EventArgs e)
        {
            if (!edtMaSP.Text.Equals(""))
            {
                SanPham sanPham = _SanPhamService.getOneByID(int.Parse(edtMaSP.Text.Trim()));
                if (sanPham != null)
                {
                    if (openFileDialog1 != null)
                    {
                        string filename = cloudinaryService.Upload(openFileDialog1);
                        if (filename != null)
                        {
                            string[] fileName_ = filename.Split('/');

                            UpLoadFile(openFileDialog1, fileName_[fileName_.Length - 1]);
                            sanPham.HinhAnh = filename;
                            MessageBox.Show("Cập nhật hình ảnh sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        bool kq =_SanPhamService.updateHinhAnh(sanPham);
                        if (kq == true)
                        {
                            
                            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dsSanPham = _SanPhamService.getAll();
                            KhoiTaoImagesList();
                            InitListView();
                            Load_ListViewDanhSachSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Phải chọn sản phẩm cần thay đổi ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (edtMaSP.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm", "thông báo");
            }
            else
            {
                SanPham sp = _SanPhamService.getOneByID(int.Parse(edtMaSP.Text.Trim()));
                if (sp != null)
                {
                    bool kq = _SanPhamService.delete(sp.MaSanPham);
                    if (kq == true)
                    {
                        dsSanPham = _SanPhamService.getAll();
                        KhoiTaoImagesList();
                        InitListView();
                        Load_ListViewDanhSachSanPham();
                    }
                }
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SanPham> ds = _SanPhamService.TimKiem(textBox1.Text.Trim());
            if (ds != null)
            {
                if (ds.Count == 1)
                {
                    edtMaSP.Text = ds[0].MaSanPham.ToString();
                    edtTenSP.Text = ds[0].TenSanPham;
                    edtLoaiSP.Text = ds[0].LoaiSanPham.TenLoai;
                    edtDVT.Text = ds[0].DonViTinh;
                    edtSLT.Text = ds[0].SoLuongTon.ToString();
                    double gia = (float)float.Parse(ds[0].Gia.ToString());
                    edtGiaSP.Text = gia.ToString("N0");
                    edtMoTa.Text = ds[0].MoTa;
                    edtMoTa.Focus();

                    //pictureBox1.Image = cloudinaryService.getBitMapImage(sp.HinhAnh);
                    string[] fileName_ = ds[0].HinhAnh.Split('/');
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (ds.Count > 1)
                {
                    dsSanPham = ds;
                    KhoiTaoImagesList();
                    InitListView();
                    Load_ListViewDanhSachSanPham();
                }
            }
        }
    }
}
