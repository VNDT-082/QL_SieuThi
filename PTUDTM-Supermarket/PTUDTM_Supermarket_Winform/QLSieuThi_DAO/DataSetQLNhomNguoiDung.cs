using QLSieuThi_DAO.DataSetPhanQuyenTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class DataSetQLNhomNguoiDung
    {
        private readonly QL_NhomNguoiDungTableAdapter adapter;
        private string[] dsQuyenMacDinh = { "MN001", "MN002", "MN003", "MN004", "MN005", "MN006", };
        public DataSetQLNhomNguoiDung()
        {
            adapter = new QL_NhomNguoiDungTableAdapter();
        }
        public DataTable GetAll()
        {
            DataTable dt = adapter.GetData();
            return dt;
        }
        public DataRow GetOneById(string maNhom)
        {
            DataRow row = adapter.GetData().Where(i => i.MaNhom== maNhom).FirstOrDefault();
            return row;
        }
        public bool Insert(QL_NhomNguoiDung QL_NhomNguoiDung)
        {
            try
            {
                if (adapter.GetData().Rows.Count <= 0)
                {
                    QL_NhomNguoiDung.MaNhom = GenerateId();
                    int kq = adapter.Insert(QL_NhomNguoiDung.MaNhom, QL_NhomNguoiDung.TenNhom, QL_NhomNguoiDung.GhiChu);
                    return kq > 0 ? true : false;
                }
                DataRow row = adapter.GetData().Where(i => i.MaNhom == QL_NhomNguoiDung.MaNhom).FirstOrDefault();
                if (row == null)
                {
                    QL_NhomNguoiDung.MaNhom = GenerateId();
                    int kq = adapter.Insert(QL_NhomNguoiDung.MaNhom, QL_NhomNguoiDung.TenNhom, QL_NhomNguoiDung.GhiChu);
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
        public bool Delete(QL_NhomNguoiDung QL_NhomNguoiDung)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaNhom == QL_NhomNguoiDung.MaNhom).FirstOrDefault();
                if (row == null)
                    return false;
                string maNhom = row["MaNhom"].ToString();
                bool isExists=dsQuyenMacDinh.Contains(maNhom);
                if (isExists == true)
                { 
                    return false;
                }
                int kq = adapter.Delete(QL_NhomNguoiDung.MaNhom, QL_NhomNguoiDung.TenNhom, QL_NhomNguoiDung.GhiChu);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(QL_NhomNguoiDung QL_NhomNguoiDung)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaNhom == QL_NhomNguoiDung.MaNhom).FirstOrDefault();
                if (row == null)
                {
                    return false;
                }
                //row["MaNhom"] = QL_NhomNguoiDung.MaNhom;
                row["TenNhom"] = QL_NhomNguoiDung.TenNhom;
                row["GhiChu"] = QL_NhomNguoiDung.GhiChu;
                int kq = adapter.Update(row);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        private string GenerateId()
        {
            DataRow row = adapter.GetData().OrderByDescending(i => i.MaNhom).FirstOrDefault();
            if (row == null)
            {
                return "MN001";
            }
            int numId = int.Parse(row["MaNhom"].ToString().Substring(2, 3));
            if (numId + 1 > 9)
            {
                return "MN0" + ++numId;
            }
            return "MN00" + ++numId;
        }
    }
}
