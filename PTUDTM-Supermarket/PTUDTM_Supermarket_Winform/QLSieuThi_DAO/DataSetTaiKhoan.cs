using QLSieuThi_DAO.DataSetPhanQuyenTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class DataSetTaiKhoan
    {
        private TaiKhoanTableAdapter adapter;
        public DataSetTaiKhoan()
        {
            adapter = new TaiKhoanTableAdapter();
        }
        public DataTable GetAll()
        {
            DataTable dt = adapter.GetData();
            return dt;
        }

        public TaiKhoan GetOneByTenDangNhap(string tenDangNhap)
        {
            TaiKhoan taiKhoan = null;
            DataRow row = adapter.GetData().Where(i => i.TenDangNhap == tenDangNhap).FirstOrDefault();
            if (row != null)
            {
                taiKhoan = new TaiKhoan();
                taiKhoan.TenDangNhap = row["TenDangNhap"].ToString();
                taiKhoan.MatKhau = row["MatKhau"].ToString();
                taiKhoan.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();
                taiKhoan.TrangThai = (bool)row["TrangThai"];
            }
            return taiKhoan;
        }
        public bool Insert(TaiKhoan taiKhoan)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.TenDangNhap == taiKhoan.TenDangNhap).FirstOrDefault();
                if (row == null)
                {
                    int kq = adapter.Insert(taiKhoan.TenDangNhap, taiKhoan.MatKhau, taiKhoan.LoaiTaiKhoan, taiKhoan.TrangThai);
                    return kq > 0 ? true : false;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Delete(TaiKhoan taiKhoan)
        {
            try
            {
                int kq = adapter.Delete(taiKhoan.TenDangNhap,taiKhoan.MatKhau, taiKhoan.LoaiTaiKhoan,taiKhoan.TrangThai);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(TaiKhoan taiKhoan)
        {
            try
            {
                DataRow row =  adapter.GetData().Where(i => i.TenDangNhap == taiKhoan.TenDangNhap).FirstOrDefault();
                if (row == null)
                {
                    return false;
                }
                row["MatKhau"] = taiKhoan.MatKhau;
                row["LoaiTaiKhoan"] = taiKhoan.LoaiTaiKhoan;
                row["TrangThai"] = taiKhoan.TrangThai;
                int kq = adapter.Update(row);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
