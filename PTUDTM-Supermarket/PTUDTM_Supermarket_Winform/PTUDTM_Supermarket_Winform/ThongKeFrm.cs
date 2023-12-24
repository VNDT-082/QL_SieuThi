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
    public partial class ThongKeFrm : Form
    {
        private PhieuBanHangService _PhieuBanHangService;
        private ChiTietHoaDonService _ChiTietHoaDonService;
        public ThongKeFrm()
        {
            InitializeComponent();
            _PhieuBanHangService = new PhieuBanHangService();
            _ChiTietHoaDonService=new ChiTietHoaDonService();
            List<PhieuBanHang> dsPhieuBan = _PhieuBanHangService.GetAll();
            //double[] dsthang = new double[12];

            double thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12 ;
            thang1 = thang2 = thang3 = thang4 = thang5 = thang6 = thang7 = thang8 = thang9 = thang10 = thang11 = thang12 = 0;

            double _thang1, _thang2, _thang3, _thang4, _thang5, _thang6, _thang7, _thang8, _thang9, _thang10, _thang11, _thang12;
            _thang1 = _thang2 = _thang3 = _thang4 = _thang5 = _thang6 = _thang7 = _thang8 = _thang9 = _thang10 = _thang11 = _thang12 = 0;

            double[] dsThang ={ thang1, thang2, thang3, thang4, thang5, thang6, thang7, thang8, thang9, thang10, thang11, thang12};
            double[] _dsThang = { _thang1, _thang2, _thang3, _thang4, _thang5, _thang6, _thang7, _thang8, _thang9, _thang10, _thang11, _thang12 };

            foreach (PhieuBanHang phieuBanHang in dsPhieuBan)
            {
                if (phieuBanHang.NgayMua != null)
                {
                    if (phieuBanHang.NgayMua.Value.Month == 1)
                    {
                        thang1 = (double)(thang1 + phieuBanHang.TongTien);
                        dsThang[0] = thang1;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang1 = (double)(_thang1 + phieuBanHang.TongTien);
                            _dsThang[0] = _thang1;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 2)
                    {
                        thang2 = (double)(thang2 + phieuBanHang.TongTien);
                        dsThang[1] = thang2;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang2 = (double)(_thang2 + phieuBanHang.TongTien);
                            _dsThang[1] = _thang2;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 3)
                    {
                        thang3 = (double)(thang3 + phieuBanHang.TongTien);
                        dsThang[2] = thang3;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang3 = (double)(_thang3 + phieuBanHang.TongTien);
                            _dsThang[2] = _thang3;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 4)
                    {
                        thang4 = (double)(thang4 + phieuBanHang.TongTien);
                        dsThang[3] = thang4;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang4 = (double)(_thang4 + phieuBanHang.TongTien);
                            _dsThang[3] = _thang4;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 5)
                    {
                        thang5 = (double)(thang5 + phieuBanHang.TongTien);
                        dsThang[4] = thang5;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang5 = (double)(_thang5 + phieuBanHang.TongTien);
                            _dsThang[4] = _thang5;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 6)
                    {
                        thang6 = (double)(thang6 + phieuBanHang.TongTien);
                        dsThang[5] = thang6;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang6 = (double)(_thang6 + phieuBanHang.TongTien);
                            _dsThang[5] = _thang6;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 7)
                    {
                        thang7 = (double)(thang7 + phieuBanHang.TongTien);
                        dsThang[6] = thang7;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang7 = (double)(_thang7 + phieuBanHang.TongTien);
                            _dsThang[6] = _thang7;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 8)
                    {
                        thang8 = (double)(thang8 + phieuBanHang.TongTien);
                        dsThang[7] = thang8;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang8 = (double)(_thang8 + phieuBanHang.TongTien);
                            _dsThang[7] = _thang8;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 9)
                    {
                        thang9 = (double)(thang9 + phieuBanHang.TongTien);
                        dsThang[8] = thang9;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang9 = (double)(_thang9 + phieuBanHang.TongTien);
                            _dsThang[8] = _thang9;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 10)
                    {
                        thang10 = (double)(thang1 + phieuBanHang.TongTien);
                        dsThang[9] = thang10;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang10 = (double)(_thang10 + phieuBanHang.TongTien);
                            _dsThang[9] = _thang10;
                        }
                    }
                    else if (phieuBanHang.NgayMua.Value.Month == 11)
                    {
                        thang11 = (double)(thang11 + phieuBanHang.TongTien);
                        dsThang[10] = thang11;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang11 = (double)(_thang11 + phieuBanHang.TongTien);
                            _dsThang[10] = _thang11;
                        }
                    }
                    else
                    {
                        thang12 = (double)(thang12 + phieuBanHang.TongTien);
                        dsThang[11] = thang12;
                        if (phieuBanHang.NgayMua.Value.Year == DateTime.Now.Year)
                        {
                            _thang12 = (double)(_thang12 + phieuBanHang.TongTien);
                            _dsThang[11] = _thang12;
                        }
                    }
                }
            }
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 1", thang1.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 2", thang2.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 3", thang3.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 4", thang4.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 5", thang5.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 6", thang6.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 7", thang7.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 8", thang8.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 9", thang9.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 10", thang10.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 11", thang11.ToString("N0"));
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 12", thang12.ToString("N0"));

            for (int i = 0; i < 12; i++)
            {
                chart1.Series["Doanh thu"].Points[i].Label = dsThang[i].ToString("N0");
            }

            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 1", _thang1.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 2", _thang2.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 3", _thang3.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 4", _thang4.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 5", _thang5.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 6", _thang6.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 7", _thang7.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 8", _thang8.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 9", _thang9.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 10", _thang10.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 11", _thang11.ToString("N0"));
            chart1.Series["Tong doanh thu"].Points.AddXY("Tháng 12", _thang12.ToString("N0"));

            for (int i = 0; i < 12; i++)
            {
                chart1.Series["Tong doanh thu"].Points[i].Label = _dsThang[i].ToString("N0");
            }
            //chart1.Series["Doanh thu"].Points[12].Label= thang12.ToString("N0");

            chart1.Titles.Add("Doanh thu");

            label3.Text=label3.Text+ dsPhieuBan.Count.ToString();
            double tongDoanhThu = thang1 + thang2 + thang3 + thang4 + thang5 + thang6 + thang7 + thang8 + thang9 + thang10 + thang11 + thang12;
            label4.Text =label4.Text+tongDoanhThu.ToString("N0");
            var pbieuBanMax = dsPhieuBan.OrderByDescending(i => i.TongTien).FirstOrDefault();
            label5.Text=label5.Text+ " " +pbieuBanMax.NgayMua.Value.ToShortDateString()+" ("+pbieuBanMax.TongTien.ToString()+")";

        }
    }
}
