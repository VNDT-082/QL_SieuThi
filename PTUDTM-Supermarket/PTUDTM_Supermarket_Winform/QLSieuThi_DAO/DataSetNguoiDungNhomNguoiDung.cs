using QLSieuThi_DAO.DataSetPhanQuyenTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class DataSetNguoiDungNhomNguoiDung
    {
        private readonly QL_NguoiDungNhomNguoiDungTableAdapter adapter;
        public DataSetNguoiDungNhomNguoiDung()
        { 
            adapter=new QL_NguoiDungNhomNguoiDungTableAdapter();
        }
        public DataTable GetAll()
        {
            DataTable dt = adapter.GetData();
            return dt;
        }
        public DataRow GetOneById(string maNhomNguoiDung, string tenDangNhap)
        {
            DataRow row = adapter.GetData().Where(i => i.MaNhomNguoiDung == maNhomNguoiDung && i.TenDangNhap == tenDangNhap).FirstOrDefault();
            return row;
        }
        public List<QL_NguoiDungNhomNguoiDung> GetListByTenDangNhap(string tenDangNhap)
        {
            DataTable dt = adapter.GetData().Where(i=>i.TenDangNhap == tenDangNhap).CopyToDataTable();
            List<QL_NguoiDungNhomNguoiDung> ds = new List<QL_NguoiDungNhomNguoiDung>();
            foreach (DataRow row in dt.Rows)
            {
                QL_NguoiDungNhomNguoiDung qL_NguoiDungNhomNguoiDung = new QL_NguoiDungNhomNguoiDung();
                qL_NguoiDungNhomNguoiDung.TenDangNhap = row["TenDangNhap"].ToString();
                qL_NguoiDungNhomNguoiDung.MaNhomNguoiDung = row["MaNhomNguoiDung"].ToString();
                qL_NguoiDungNhomNguoiDung.GhiChu = row["GhiChu"].ToString();
                ds.Add(qL_NguoiDungNhomNguoiDung);
            }
           
            return ds;
        }
        public bool Insert(QL_NguoiDungNhomNguoiDung QL_NguoiDungNhomNguoiDung)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.TenDangNhap == QL_NguoiDungNhomNguoiDung.TenDangNhap
                && i.MaNhomNguoiDung == QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung).FirstOrDefault();
                if (row == null)
                {
                    int kq = adapter.Insert(QL_NguoiDungNhomNguoiDung.TenDangNhap, QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung, QL_NguoiDungNhomNguoiDung.GhiChu);
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
        public bool Delete(QL_NguoiDungNhomNguoiDung QL_NguoiDungNhomNguoiDung)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.TenDangNhap == QL_NguoiDungNhomNguoiDung.TenDangNhap
                && i.MaNhomNguoiDung == QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung).FirstOrDefault();
                if (row == null)
                    return false;
                int kq = adapter.Delete(QL_NguoiDungNhomNguoiDung.TenDangNhap,QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung,QL_NguoiDungNhomNguoiDung.GhiChu);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(QL_NguoiDungNhomNguoiDung QL_NguoiDungNhomNguoiDung)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.TenDangNhap == QL_NguoiDungNhomNguoiDung.TenDangNhap).FirstOrDefault();
                if (row == null)
                {
                    return false;
                }
                row["TenDangNhap"] = QL_NguoiDungNhomNguoiDung.TenDangNhap;
                row["MaNhomNguoiDung"] = QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung;
                row["GhiChu"] = QL_NguoiDungNhomNguoiDung.GhiChu;
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
