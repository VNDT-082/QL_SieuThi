using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using CloudinaryDotNet;
using System.Net;
using System.IO;

namespace CustomControll
{

    public partial class CardView : UserControl
    {
        public string TenSanPham,Gia,HinhAnh;
        public int MaSanPham, GiaTriKhuyenMai;
        public double GiaSanPham;
        public CardView()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            WindowsDevice.setHeightOfCerrentPictureBox(this.Size.Height, pictureBox, (float)0.6);
            WindowsDevice.setHeightOfCerrentTableLayoutPanel(this.Size.Height, tableLayoutPanel1, (float)0.4);

            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            //add lable
            this.tableLayoutPanel1.Controls.Add(this.lblTenSP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaSP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKhuyenMai, 0, 3);

            this.lblTenSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, 
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, 
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuyenMai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, ((byte)(163)));

        }


        private void CardView_SizeChanged(object sender, EventArgs e)
        {
            Init();
        }
        public void SetTenSanPham(string tenSanPham)
        {
            this.TenSanPham=tenSanPham;
            lblTenSP.Text = tenSanPham;
        }
        public void SetMaSanPham(int maSanPham)
        {
            this.MaSanPham=maSanPham;
            lblMaSP.Text = maSanPham.ToString();
        }
        public void SetGia(double gia)
        {
            this.GiaSanPham=gia;
            lblGia.Text = gia.ToString("N0") + " vnd";
        }
        public void SetImg(string img)
        {
            string[] fileName_ = img.Split('/');
            pictureBox.Image = new Bitmap(Application.StartupPath + "\\sanpham\\" + fileName_[fileName_.Length - 1]);
            //CloudinaryService cloudinaryService = new CloudinaryService();
            //this.HinhAnh=img;
            //pictureBox.Image = cloudinaryService.getBitMapImage(img); 
        }
        public void SetKhuyenMai(int giaTriKhuyenMai)
        {
            if (giaTriKhuyenMai != 0)
            {
                this.GiaTriKhuyenMai = giaTriKhuyenMai;
                lblKhuyenMai.Text = giaTriKhuyenMai.ToString() + "%";
            }
            else {
                this.GiaTriKhuyenMai = 0;
                lblKhuyenMai.Text ="";
            }
        }

        public event EventHandler Click;

        private void HandleClick()
        {
            OnClick(EventArgs.Empty);
        }
        //public dynamic btnAdd_Click(object sender, EventArgs e)
        //{
        //    dynamic sanPham = new { maSanPham = this.MaSanPham, tenSanPham = this.TenSanPham, 
        //        giaSanPham = this.GiaSanPham, giaTriKhuyenMai = this.GiaTriKhuyenMai };
        //    return sanPham;
        //}

        public event EventHandler ButtonClick;
        //public void butt
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if(ButtonClick!=null)
            {
             ButtonClick(this,EventArgs.Empty);
            }
        }

    }
}
//public class CloudinaryService
//{
//    private Account account;
//    private Cloudinary cloudinary;
//    public CloudinaryService()
//    {
//        account = new Account(
//          "dozsz2dqi",
//          "453574262281117",
//          "L6S4ZLeF6wI35ILMHuGseA0r6E0");

//        cloudinary = new Cloudinary(account);

//    }
//    public Bitmap getBitMapImage(string originalUrl)
//    {
//        using (WebClient webClient = new WebClient())
//        {
//            byte[] imageData = webClient.DownloadData(originalUrl);

//            using (MemoryStream memoryStream = new MemoryStream(imageData))
//            {

//                Bitmap bitmap = new Bitmap(memoryStream);
//                return bitmap;
//            }
//        }
//    }
//}