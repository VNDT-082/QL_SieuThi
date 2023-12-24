using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTUDTM_Supermarket_Winform.Asset;
using CustomControll;

using QLSieuThi_DAO;
using System.Diagnostics.Eventing.Reader;

namespace PTUDTM_Supermarket_Winform
{
    public partial class BanHangFrm : Form
    {
        private string UserName;
        public readonly SanPhamService _SanPhamService;
        public readonly NhanVienService _NhanVienService;
        public KhachHangService _KhachHangService;
        public PhieuBanHangService _PhieuBanHangService;
        public ChiTietHoaDonService _ChiTietHoaDonService;
        public NhanVien nhanVien;
        public KhachHang khachHang;
        public PhieuBanHang phieuBan;
        public double TongTien;

        List<ChiTietHoaDon> dsChiTietHD;
        //BindingSource bindingSource;
        public BanHangFrm(string UserName)
        {
            
            InitializeComponent();
            this.UserName= UserName;
            _SanPhamService = new SanPhamService();
            _KhachHangService=new KhachHangService();
            _NhanVienService=new NhanVienService();
            _PhieuBanHangService=new PhieuBanHangService();
            _ChiTietHoaDonService=new ChiTietHoaDonService();


            khachHang = _KhachHangService.getOneBySDT("0912345654");
            nhanVien = _NhanVienService.getOneByTenDangNhap(this.UserName);
            phieuBan = new PhieuBanHang();
            TongTien = 0;
            Init();
            InitListView();
            InitNewForm();
        }
        public void InitListView()
        {
            ListViewOrder.Clear();
            ColumnHeader header=new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            ColumnHeader header5 = new ColumnHeader();  
            int width = ListViewOrder.Width;
            header.Text = "Mã sản phẩm";
            header.Name = "MaSanPham";
            header.Width = (int)Math.Ceiling(width* 0.12);

            header1.Text = "Tên sản phẩm";
            header1.Name = "TenSanPham";
            header1.Width = (int)Math.Ceiling(width * 0.3);

            header2.Text = "Giá";
            header2.Name = "Gia";
            header2.Width = (int)Math.Ceiling(width * 0.15);

            header5.Text = "Khuyến mãi";
            header5.Name = "KhuyenMai";
            header5.Width = (int)Math.Ceiling(width * 0.15);

            header3.Text = "Số lượng";
            header3.Name = "SoLuong";
            header3.Width = (int)Math.Ceiling(width * 0.1);

            header4.Text = "Tổng cộng";
            header4.Name = "TongCong";
            header4.Width = (int)Math.Ceiling(width * 0.175);

            ListViewOrder.Columns.Add(header);
            ListViewOrder.Columns.Add(header1);
            ListViewOrder.Columns.Add(header2);
            ListViewOrder.Columns.Add(header5);
            ListViewOrder.Columns.Add(header3);
            ListViewOrder.Columns.Add(header4);
        }
        public void ListViewSizeChange()
        {
            if (ListViewOrder.Columns.Count > 0)
            {
                int width = ListViewOrder.Width;
                ListViewOrder.Columns["MaSanPham"].Width = (int)Math.Ceiling(width * 0.12);
                ListViewOrder.Columns["TenSanPham"].Width = (int)Math.Ceiling(width * 0.3);
                ListViewOrder.Columns["Gia"].Width = (int)Math.Ceiling(width * 0.15);
                ListViewOrder.Columns["KhuyenMai"].Width = (int)Math.Ceiling(width * 0.15);
                ListViewOrder.Columns["SoLuong"].Width = (int)Math.Ceiling(width * 0.1);
                ListViewOrder.Columns["TongCong"].Width = (int)Math.Ceiling(width * 0.175);
            }

        }
        public void InitNewForm()
        {
            edtMaNV.Text = nhanVien.TenNhanVien;
            edtMaKH.Text = khachHang.TenKhachHang;
            phieuBan = new PhieuBanHang();
            phieuBan.MaKhachHang = khachHang.MaKhachHang;
            phieuBan.MaNhanVien = nhanVien.MaNhanVien;
            phieuBan.TongTien = 0;
            phieuBan.GiamGia = 0;
            phieuBan.TienPhaiTra = 0;
            phieuBan.TrangThai = false;
            dsChiTietHD = new List<ChiTietHoaDon>();
            //bindingSource = new BindingSource();
            //bindingSource.DataSource = dsChiTietHD;
            //dgvHoaDon.DataSource = dsChiTietHD;
            //InitListView();
            
        }
        public void Init()
        {
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnLeft, (float)0.7);
            WindowsDevice.setWidthOfCerrentPanel(this.Size.Width, pnRight, (float)0.3);

            WindowsDevice.setHeightOfCerrentPanel(pnLeft.Height, pnHoaDon,(float)0.5);
            WindowsDevice.setHeightOfCerrentPanel(pnLeft.Height, pnSanPham, (float)0.5);

            WindowsDevice.setWidthOfCerrentPanel(pnHoaDon.Width, pnTableHoaDon, (float)0.65);
            WindowsDevice.setHeightOfCerrentPanel(pnHoaDon.Height, pnTableHoaDon, (float)1);

            WindowsDevice.setWidthOfCerrentPanel(pnHoaDon.Width, pnHoaDonDetail, (float)0.35);
            WindowsDevice.setHeightOfCerrentPanel(pnHoaDon.Height, pnHoaDonDetail, (float)1);
            pnHoaDonDetail.BackColor = AppValues.BACKGROUND_COLOR;

            
            if (this.WindowState == FormWindowState.Maximized)
            {
                WindowsDevice.setHeightOfCerrentPanel(pnRight.Height, pnSearch, (float)0.29);
                WindowsDevice.setHeightOfCerrentPanel(pnRight.Height, pnKhachHang, (float)0.22);
                pnSearch.Visible = true;
            }
            else
            {
                WindowsDevice.setHeightOfCerrentPanel(pnRight.Height, pnSearch, (float)0.24);
                WindowsDevice.setHeightOfCerrentPanel(pnRight.Height, pnKhachHang, (float)0.24);
                pnSearch.Visible = false;
            }
            
            
            WindowsDevice.setHeightOfCerrentPanel(pnSanPham.Size.Height, pnBottom,(float) 0.15);
            WindowsDevice.setHeightOfCerrentTableLayoutPanel(pnSanPham.Size.Height, tbpnListSanPham,(float) 0.85);
            pnSanPham.BackColor = AppValues.BACKGROUND_COLOR;
            pnBottom.BackColor = AppValues.FORE_COLOR;
            //--------------------------------------------------------------------------------------------------------
            panelPageNum.Height = tbpnListSanPham.Size.Height;

            cardView2.Height = tbpnListSanPham.Size.Height;
            cardView3.Height = tbpnListSanPham.Size.Height;
            cardView1.Height = tbpnListSanPham.Size.Height;
            pnRight.BackColor = AppValues.BACKGROUND_COLOR;

            cardView1.Visible = false;
            cardView2.Visible = false;
            cardView3.Visible = false;

            cardView1.ButtonClick += cardView1_ButtonClick;
            cardView2.ButtonClick += cardView2_ButtonClick;
            cardView3.ButtonClick += cardView3_ButtonClick;
            //cardView1.ButtonClick += cardView1_ButtonClick;
        }

        void cardView3_ButtonClick(object sender, EventArgs e)
        {
            ClearControl();
            edtMaSP.Text = cardView3.MaSanPham.ToString();
            edtTenSP.Text = cardView3.TenSanPham.ToString();
            edtGia.Text = cardView3.GiaSanPham.ToString("N0");
            edtKhuyenMai.Text = cardView3.GiaTriKhuyenMai.ToString();
            float giaGiamCon = (float)cardView3.GiaSanPham - (float)cardView3.GiaSanPham * cardView3.GiaTriKhuyenMai / 100;
            edtGiamGiaCon.Text = giaGiamCon.ToString("N0");
            edtSoLuong.Text = "1";
        }

        void cardView2_ButtonClick(object sender, EventArgs e)
        {
            ClearControl();
            edtMaSP.Text = cardView2.MaSanPham.ToString();
            edtTenSP.Text = cardView2.TenSanPham.ToString();
            edtGia.Text = cardView2.GiaSanPham.ToString("N0");
            edtKhuyenMai.Text = cardView2.GiaTriKhuyenMai.ToString();
            float giaGiamCon = (float)cardView2.GiaSanPham - (float)cardView2.GiaSanPham * cardView2.GiaTriKhuyenMai / 100;
            edtGiamGiaCon.Text = giaGiamCon.ToString("N0");
            edtSoLuong.Text = "1";
        }

        void cardView1_ButtonClick(object sender, EventArgs e)
        {
            ClearControl();
            edtMaSP.Text = cardView1.MaSanPham.ToString();
            edtTenSP.Text = cardView1.TenSanPham.ToString();
            edtGia.Text = cardView1.GiaSanPham.ToString("N0");
            edtKhuyenMai.Text = cardView1.GiaTriKhuyenMai.ToString();
            float giaGiamCon =(float) cardView1.GiaSanPham - (float)cardView1.GiaSanPham * cardView1.GiaTriKhuyenMai / 100;
            edtGiamGiaCon.Text = giaGiamCon.ToString("N0");
            edtSoLuong.Text = "1";
        }





        private void BanHangFrm_SizeChanged(object sender, EventArgs e)
        {
            Init();
            ListViewSizeChange();
        }

        private void edtSearch_Enter(object sender, EventArgs e)
        {
            if (edtSearch.Text == "Tìm sản phẩm...")
            {
                edtSearch.Font = AppValues.FONT_14_REGULAR;
                edtSearch.ForeColor = AppValues.LABEL_COLOR;
                edtSearch.Text = "";
            }
        }

        private void edtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edtSearch.Text))
            {
                edtSearch.Font = AppValues.FONT_14_BOLD;
                edtSearch.ForeColor = AppValues.BLUE_COLOR;
                edtSearch.Text = "Tìm sản phẩm...";
            }
        }

        private void edtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cardView1.Visible = false;
            cardView2.Visible = false;
            cardView3.Visible = false;
            panelPageNum.RowCount = 0;
            panelPageNum.RowStyles.Clear();
            panelPageNum.Controls.Clear();
            string value = edtSearch.Text.Trim();
            int numID = 0;
            if (int.TryParse(value, out numID))
            {
                cardView1.Visible = true;
                SanPham sanPham = _SanPhamService.getOneByID(numID);
                if (sanPham != null)
                {
                    cardView1.SetTenSanPham(sanPham.TenSanPham);
                    cardView1.SetImg(sanPham.HinhAnh);
                    cardView1.SetGia(float.Parse(sanPham.Gia.ToString()));
                    cardView1.SetMaSanPham(sanPham.MaSanPham);

                    if (sanPham.ChiTietKhuyenMais != null)
                    {
                        if (sanPham.ChiTietKhuyenMais.Count > 0)
                        {
                            var giaTriKhuyenMai = sanPham.ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                            if (giaTriKhuyenMai != null)
                            {
                                cardView1.SetKhuyenMai((int)giaTriKhuyenMai);
                            }
                        }
                        else
                        {
                            cardView1.SetKhuyenMai(0);
                        }
                    }
                    
                }

            }
            else {
                int soLuong = _SanPhamService.Count(value);
                if (soLuong > 3)
                {
                    Button btnUp = addButtonVector(true);
                    //btnUp.Click += btnUp_Click;
                    Button btnDown = addButtonVector(false);
                    //btnDown.Click += btnDown_Click;
                    double pageCount = Math.Floor((float)soLuong / 3);
                    
                    panelPageNum.RowCount = 0;
                    panelPageNum.RowStyles.Clear();
                    panelPageNum.Controls.Add(btnUp);
                    panelPageNum.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    panelPageNum.RowCount++;
                    panelPageNum.AutoScroll = true;
                    double soLuongPageShow=( pageCount>4)?4:pageCount;
                    for (int i = 0; i < soLuongPageShow; i++)
                    {
                        ButtonPageNum btn = addButtonPageNum(i + 1);
                        btn.isCurrentPage = (i == 0) ? true : false;
                        panelPageNum.Controls.Add(btn);
                        panelPageNum.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                        panelPageNum.RowCount++;
                        panelPageNum.AutoScroll = true;
                        btn.Click += btn_Click;
                    }
                    panelPageNum.Controls.Add(btnDown);
                    panelPageNum.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    panelPageNum.RowCount++;
                    panelPageNum.AutoScroll = false;
                }
                List<SanPham> dsSanPham = _SanPhamService.getTop3ConcatName(value,1);
                if (dsSanPham != null)
                {
                    cardView1.Visible = true;
                    if (dsSanPham.Count == 1)
                    {
                        cardView1.SetTenSanPham(dsSanPham[0].TenSanPham);
                        cardView1.SetImg(dsSanPham[0].HinhAnh);
                        cardView1.SetGia(float.Parse(dsSanPham[0].Gia.ToString()));
                        cardView1.SetMaSanPham(dsSanPham[0].MaSanPham);

                        if (dsSanPham[0].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[0].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[0].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView1.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView1.SetKhuyenMai(0);
                            }
                        }
                        
                    }
                    else if (dsSanPham.Count == 2)
                    {
                        cardView1.Visible = true;
                        cardView2.Visible = true;

                        cardView1.SetTenSanPham(dsSanPham[0].TenSanPham);
                        cardView1.SetImg(dsSanPham[0].HinhAnh);
                        cardView1.SetGia(float.Parse(dsSanPham[0].Gia.ToString()));
                        cardView1.SetMaSanPham(dsSanPham[0].MaSanPham);

                        if (dsSanPham[0].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[0].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[0].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView1.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView1.SetKhuyenMai(0);
                            }
                        }
                       

                        cardView2.SetTenSanPham(dsSanPham[1].TenSanPham);
                        cardView2.SetImg(dsSanPham[1].HinhAnh);
                        cardView2.SetGia(float.Parse(dsSanPham[1].Gia.ToString()));
                        cardView2.SetMaSanPham(dsSanPham[1].MaSanPham);

                        if (dsSanPham[1].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[1].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[1].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView2.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView2.SetKhuyenMai(0);
                            }
                        }
                        
                    }
                    else if (dsSanPham.Count == 3)
                    {
                        cardView1.Visible = true;
                        cardView2.Visible = true;
                        cardView3.Visible = true;

                        cardView1.SetTenSanPham(dsSanPham[0].TenSanPham);
                        cardView1.SetImg(dsSanPham[0].HinhAnh);
                        cardView1.SetGia(float.Parse(dsSanPham[0].Gia.ToString()));
                        cardView1.SetMaSanPham(dsSanPham[0].MaSanPham);

                        if (dsSanPham[0].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[0].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[0].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView1.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView1.SetKhuyenMai(0);
                            }

                        }
                        

                        cardView2.SetTenSanPham(dsSanPham[1].TenSanPham);
                        cardView2.SetImg(dsSanPham[1].HinhAnh);
                        cardView2.SetGia(float.Parse(dsSanPham[1].Gia.ToString()));
                        cardView2.SetMaSanPham(dsSanPham[1].MaSanPham);

                        if (dsSanPham[1].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[1].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[1].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView2.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView2.SetKhuyenMai(0);
                            }
                        }
                        

                        cardView3.SetTenSanPham(dsSanPham[2].TenSanPham);
                        cardView3.SetImg(dsSanPham[2].HinhAnh);
                        cardView3.SetGia(float.Parse(dsSanPham[2].Gia.ToString()));
                        cardView3.SetMaSanPham(dsSanPham[2].MaSanPham);

                        if (dsSanPham[2].ChiTietKhuyenMais != null)
                        {
                            if (dsSanPham[2].ChiTietKhuyenMais.Count > 0)
                            {
                                var giaTriKhuyenMai = dsSanPham[2].ChiTietKhuyenMais.Last().GiaTriKhuyenMai;
                                if (giaTriKhuyenMai != null)
                                {
                                    cardView3.SetKhuyenMai((int)giaTriKhuyenMai);
                                }
                            }
                            else
                            {
                                cardView3.SetKhuyenMai(0);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            edtSearch.Text = "";
        }

        //void btnDown_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //void btnUp_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        void btn_Click(object sender, EventArgs e)
        {
            Button btn =(Button) sender;
            MessageBox.Show(btn.Text);
        }
        private ButtonPageNum addButtonPageNum(int pageNum)
        {
            ButtonPageNum btn = new ButtonPageNum(pageNum,false);
            return btn;
            
        }

        private Button addButtonVector(bool huong)
        {
            Button btn = new Button();
            btn.BackColor = System.Drawing.Color.Blue;
            btn.Name = (huong==true)? "btnUp":"btnDown";
            btn.Size = new System.Drawing.Size(43, 38);
            btn.TabIndex = 0;
            btn.Text = (huong == true) ? "▲" : "▼";
            btn.UseVisualStyleBackColor = false;
            //panelPageNum.RowStyles.Clear();
            //panelPageNum.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            //panelPageNum.Controls.Add(btn, 0, panelPageNum.RowCount - 1);
            return btn;
        }

        private void ClearControl()
        {
            edtMaSP.Text = "";
            edtTenSP.Text = "";
            edtGia.Text = "";
            edtKhuyenMai.Text = "";
            edtGiamGiaCon.Text = "";
            edtSoLuong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (edtMaSP.Text != "")
            {
                //List<ChiTietHoaDon> dsSanPhamMua = (List<ChiTietHoaDon>)dgvHoaDon.DataSource;
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                SanPham sp = _SanPhamService.getOneByID(int.Parse(edtMaSP.Text.Trim()));
                chiTietHoaDon.MaSanPham = sp.MaSanPham;
                chiTietHoaDon.ID_PhieuBan = phieuBan.ID;
                chiTietHoaDon.Gia = double.Parse(edtGia.Text.Trim());
                chiTietHoaDon.GiaTriKhuyenMai = int.Parse(edtKhuyenMai.Text.Trim());
                chiTietHoaDon.TongCong = double.Parse(edtGiamGiaCon.Text.Trim());

                if (sp.SoLuongTon < int.Parse(edtSoLuong.Text.Trim()))
                {
                    MessageBox.Show("so luong tong kho khong du", "Luu y");
                    chiTietHoaDon.SoLuong = sp.SoLuongTon;
                }
                else
                {
                    chiTietHoaDon.SoLuong = int.Parse(edtSoLuong.Text.Trim());
                }

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = chiTietHoaDon.MaSanPham.ToString();
                listViewItem.SubItems.Add(edtTenSP.Text.Trim());
                listViewItem.SubItems.Add(chiTietHoaDon.Gia.ToString());
                listViewItem.SubItems.Add(chiTietHoaDon.GiaTriKhuyenMai.ToString());
                listViewItem.SubItems.Add(chiTietHoaDon.SoLuong.ToString());
                listViewItem.SubItems.Add(chiTietHoaDon.TongCong.ToString());
                //dsSanPhamMua.Add(chiTietHoaDon);
                //dgvHoaDon.DataSource = dsSanPhamMua;
                ListViewOrder.Items.Add(listViewItem);
                TongTien = (double)(TongTien + chiTietHoaDon.TongCong);
                double TienPhaiTra = TongTien - TongTien * int.Parse(edtGiamGia.Text) / 100;
                edtTongTien.Text = TongTien.ToString("N0");
                edtSoTienPhaiTra.Text = TienPhaiTra.ToString("N0");
            }
            else
            {
                MessageBox.Show("Chua chon san pham", "Luu y");
            }

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
            else
            {
                return;
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
        }

        private void edtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            float tongTien = (float.Parse(edtGia.Text.Trim())-float.Parse(edtGia.Text.Trim()) * int.Parse(edtKhuyenMai.Text.Trim()) 
                / 100)*int.Parse(edtSoLuong.Value.ToString());
            edtGiamGiaCon.Text=tongTien.ToString("N0");
        }

        private void edtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtGiamGiaCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtKhuyenMai_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardView1_Load(object sender, EventArgs e)
        {

        }

        private void edtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void ListViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewOrder.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = ListViewOrder.SelectedItems[0];
                string maSanPham = listViewItem.Text;
                string tenSanPham = listViewItem.SubItems[1].Text;
                string giaSanPham = listViewItem.SubItems[2].Text;
                string khuyenMai = listViewItem.SubItems[3].Text;
                string soLuong = listViewItem.SubItems[4].Text;
                string tongCong = listViewItem.SubItems[5].Text;

                //string tenSanPham = listViewItem.SubItems["TenSanPham"].Text;
                //string giaSanPham = listViewItem.SubItems["Gia"].Text;
                //string khuyenMai = listViewItem.SubItems["KhuyenMai"].Text;
                //string soLuong = listViewItem.SubItems["SoLuong"].Text;
                //string tongCong = listViewItem.SubItems["TongCong"].Text;

                edtMaSP.Text = maSanPham;
                edtTenSP.Text = tenSanPham;
                double giaSanPham_ = double.Parse(giaSanPham);
                    
                edtGia.Text =giaSanPham_.ToString("N0");
                edtKhuyenMai.Text = khuyenMai;
                
                double tongCong_= double.Parse(tongCong);
                edtGiamGiaCon.Text =tongCong_.ToString("N0");
                edtSoLuong.Text =soLuong;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ListViewOrder.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn và xóa nó
                ListViewItem selectedRow = ListViewOrder.SelectedItems[0];

                TongTien = TongTien - double.Parse(selectedRow.SubItems[5].Text); 

                selectedRow.SubItems[4].Text= edtSoLuong.Value.ToString();

                TongTien = TongTien + double.Parse(selectedRow.SubItems[5].Text);

                //ListViewOrder.Items.Remove(selectedRow);
                ListViewOrder.Refresh();
                edtTongTien.Text = TongTien.ToString("N0");

                double TienPhaiTra = TongTien - TongTien * int.Parse(edtGiamGia.Text) / 100;
                edtTongTien.Text = TongTien.ToString("N0");
                edtSoTienPhaiTra.Text = TienPhaiTra.ToString("N0");
                selectedRow.SubItems[5].Text = edtSoTienPhaiTra.Text.Trim();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ListViewOrder.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn và xóa nó
                ListViewItem selectedRow = ListViewOrder.SelectedItems[0];

                TongTien = TongTien - double.Parse(selectedRow.SubItems[5].Text);

                ListViewOrder.Items.Remove(selectedRow);
                edtTongTien.Text = TongTien.ToString("N0");

                double TienPhaiTra = TongTien - TongTien * int.Parse(edtGiamGia.Text) / 100;
                edtTongTien.Text = TongTien.ToString("N0");
                edtSoTienPhaiTra.Text = TienPhaiTra.ToString("N0");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            InitNewForm();
            InitListView();
            khachHang = _KhachHangService.getOneBySDT("0912345654");
            edtMaHD.Text = "0";
            edtMaKH.Text = khachHang.TenKhachHang;
            edtTongTien.Text = phieuBan.TongTien.ToString();
            edtGiamGia.Text = phieuBan.GiamGia.ToString();
            edtSoTienPhaiTra.Text = "0";
            edtSoTienNhan.Text = "0";
            edtSoTienThua.Text = "0";
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            PhieuBanHang phieuBanHangInit = new PhieuBanHang();
            phieuBanHangInit.MaKhachHang = khachHang.MaKhachHang;
            phieuBanHangInit.MaNhanVien = nhanVien.MaNhanVien;
            phieuBanHangInit.TongTien = 0;
            phieuBanHangInit.GiamGia = 0;
            phieuBanHangInit.TienPhaiTra = 0;
            phieuBanHangInit.TrangThai = false;
            phieuBan = _PhieuBanHangService.Insert(phieuBanHangInit);
            if (phieuBan != null)
            {
                edtMaHD.Text = phieuBan.ID.ToString();
                edtMaKH.Text = khachHang.TenKhachHang;
                edtMaNV.Text = nhanVien.TenNhanVien;
                edtTongTien.Text = phieuBan.TongTien.ToString();
                edtSoTienPhaiTra.Text = "0";
                edtGiamGia.Text = "0";
                edtSoTienNhan.Text = "0";
                edtSoTienThua.Text = "0";
            }
            else {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ListViewOrder.Items.Count <= 0)
            {
                MessageBox.Show("Hóa đơn trống\n Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (edtSoTienNhan.Text == "0") 
            { MessageBox.Show("Chưa nhập số tiền nhận ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else {
                phieuBan.TongTien = TongTien;
                phieuBan.GiamGia = double.Parse(edtGiamGia.Text);
                phieuBan.TienPhaiTra = double.Parse(edtSoTienPhaiTra.Text);
                phieuBan.TrangThai = true;

                double soTienNhan = double.Parse(edtSoTienNhan.Text);
                if (soTienNhan < phieuBan.TienPhaiTra)
                {
                    MessageBox.Show("Số tiền nhận không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    bool kq = _PhieuBanHangService.Update(phieuBan);
                    if (kq == true)
                    {
                        List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
                        foreach (ListViewItem item in ListViewOrder.Items)
                        {
                            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                            chiTietHoaDon.MaSanPham = int.Parse(item.Text);
                            string tenSanPham = item.SubItems[1].Text;
                            chiTietHoaDon.Gia = double.Parse(item.SubItems[2].Text);
                            chiTietHoaDon.GiaTriKhuyenMai = int.Parse(item.SubItems[3].Text);
                            chiTietHoaDon.SoLuong = int.Parse(item.SubItems[4].Text);
                            chiTietHoaDon.TongCong = double.Parse(item.SubItems[5].Text);
                            chiTietHoaDon.ID_PhieuBan = phieuBan.ID;

                            kq = _ChiTietHoaDonService.Insert(chiTietHoaDon);
                            if (kq == false)
                            {
                                MessageBox.Show("Lỗi\n"
                                    + tenSanPham, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            chiTietHoaDons.Add(chiTietHoaDon);
                        }
                        double TienThua = (double)(soTienNhan - phieuBan.TienPhaiTra);
                        edtSoTienThua.Text = TienThua.ToString("N0");
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhatSoLuongSanPham(chiTietHoaDons);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
           

        }

        private void CapNhatSoLuongSanPham(List<ChiTietHoaDon> ds)
        {
            if (ds != null)
            {
                bool kq = false;
                foreach (ChiTietHoaDon ct in ds)
                {
                    SanPham sp = _SanPhamService.getOneByID((int)ct.MaSanPham);
                    if (sp != null)
                    {
                        sp.SoLuongTon = sp.SoLuongTon - ct.SoLuong;
                        kq = _SanPhamService.update(sp);
                    }
                }
            }

        }

        private void BanHangFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (!form.Visible)
                {
                    form.Show();
                }
            }
        }

        private void btnTimKhach_Click(object sender, EventArgs e)
        {
            KhachHang khSearch = _KhachHangService.getOneBySDT(SoDienThoaiTimKiem_TextBox.Text.ToString().Trim());
            if (khSearch != null)
            {
                khachHang = khSearch;
                edtMaKH.Text = khachHang.TenKhachHang;
                HoTenSearchTextBox.Text = khachHang.TenKhachHang;
            }
            else {
                DialogResult result = MessageBox.Show("Không tìm thấy khách hàng. \n" +
                    "Bạn có muốn thêm tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    NewKhachHangFrm newKhachHangFrm=new NewKhachHangFrm();
                    newKhachHangFrm.ShowDialog();
                }
            }
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            NewKhachHangFrm newKhachHangFrm = new NewKhachHangFrm();
            newKhachHangFrm.ShowDialog();
        }


        //private void Click()
        //{ 
        //    dynamic sanpham=
        //}
    }
}
