using QLSieuThi_DAO.DataSetPhanQuyenTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class DataSetQL_PhanQuyen
    {
        private readonly QL_PhanQuyenTableAdapter adapter;
        public DataSetQL_PhanQuyen()
        { 
            adapter=new QL_PhanQuyenTableAdapter(); 
        }
        public DataTable GetAll()
        {
            DataTable dt = adapter.GetData();
            return dt;
        }
        public DataTable GetListByIdManHinh(string maManHinh)
        {
            DataTable dt = adapter.GetData().Where(i=>i.MaManHinh==maManHinh).CopyToDataTable();
            return dt;
        }
        public DataRow GetOneById(string maManHinh, string maNhomNguoiDung)
        {
            DataRow row = adapter.GetData().Where(i => i.MaManHinh == maManHinh
                 && i.MaNhomNguoiDung == maNhomNguoiDung).FirstOrDefault();
            return row;
        }

        public List<QL_PhanQuyen> GetListByMaNhomNguoiDung(string maNhomNguoiDung)
        {
            List<QL_PhanQuyen> dsQuyen = new List<QL_PhanQuyen>();

            DataTable dtQuyen= adapter.GetData().Where(i => i.MaNhomNguoiDung.Equals(maNhomNguoiDung)).CopyToDataTable();
            foreach (DataRow row in dtQuyen.Rows)
            { 
                QL_PhanQuyen quyen = new QL_PhanQuyen();
                quyen.MaManHinh = row["MaManHinh"].ToString();
                quyen.MaNhomNguoiDung = row["MaNhomNguoiDung"].ToString();
                quyen.CoQuyen = (bool)row["CoQuyen"];
                dsQuyen.Add( quyen );
            }
            //if (maNhomNguoiDung.Equals(row["MaNhomNguoiDung"].ToString()))
            //{
            //    QL_PhanQuyen quyen = new QL_PhanQuyen();
            //    quyen.MaManHinh = row["MaManHinh"].ToString();
            //    quyen.MaNhomNguoiDung = row["MaNhomNguoiDung"].ToString();
            //    quyen.CoQuyen = (bool)row["CoQuyen"];
            //    dsQuyen.Add(quyen);
            //}
            return dsQuyen;
        }
        public bool Insert(QL_PhanQuyen QL_PhanQuyen)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaManHinh == QL_PhanQuyen.MaManHinh
                && i.MaNhomNguoiDung==QL_PhanQuyen.MaNhomNguoiDung).FirstOrDefault();
                if (row == null)
                {
                    int kq = adapter.Insert(QL_PhanQuyen.MaNhomNguoiDung, QL_PhanQuyen.MaManHinh, QL_PhanQuyen.CoQuyen);
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
        public bool Delete(QL_PhanQuyen QL_PhanQuyen)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaManHinh == QL_PhanQuyen.MaManHinh
                && i.MaNhomNguoiDung == QL_PhanQuyen.MaNhomNguoiDung).FirstOrDefault();
                if (row == null)
                    return false;
                int kq = adapter.Delete(QL_PhanQuyen.MaNhomNguoiDung, QL_PhanQuyen.MaManHinh, QL_PhanQuyen.CoQuyen);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(QL_PhanQuyen QL_PhanQuyen)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaManHinh == QL_PhanQuyen.MaManHinh
                && i.MaNhomNguoiDung == QL_PhanQuyen.MaNhomNguoiDung).FirstOrDefault();
                if (row == null)
                {
                    return false;
                }
                row["MaNhomNguoiDung"] = QL_PhanQuyen.MaNhomNguoiDung;
                row["MaManHinh"] = QL_PhanQuyen.MaManHinh;
                row["CoQuyen"] = QL_PhanQuyen.CoQuyen;
                int kq = adapter.Update(row);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(DataRow[] dataRows)
        {
            try
            {
                int kq = adapter.Update(dataRows);
                
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

