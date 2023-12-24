using QLSieuThi_DAO.DataSetPhanQuyenTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class DataSetDM_ManHinh
    {
        private readonly DM_ManHinhTableAdapter adapter;
        public DataSetDM_ManHinh()
        {
            adapter = new DM_ManHinhTableAdapter();
        }
        public DataTable GetAll()
        {
            DataTable dt = adapter.GetData();
            return dt;
        }
        public DataRow GetOneById(string maManHinh)
        {
            DataRow row = adapter.GetData().Where(i=>i.MaManHinh==maManHinh).FirstOrDefault();
            return row;
        }
        public DM_ManHinh GetOneById_m(string maManHinh)
        {
            DataRow row = adapter.GetData().Where(i => i.MaManHinh == maManHinh).FirstOrDefault();
            DM_ManHinh dM = null;
            if (row != null)
            {
                dM = new DM_ManHinh();
                dM.MaManHinh = row["MaManHinh"].ToString();
                dM.TenManHinh = row["TenManHinh"].ToString();
            }
            return dM;
        }
        public bool Insert(DM_ManHinh dM_ManHinh)
        {
            try {
                dM_ManHinh.MaManHinh = GenerateId();
                int kq = adapter.Insert(dM_ManHinh.MaManHinh,dM_ManHinh.TenManHinh);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Delete(DM_ManHinh dM_ManHinh)
        {
            try
            {
                int kq = adapter.Delete(dM_ManHinh.MaManHinh, dM_ManHinh.TenManHinh);
                return kq > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Update(DM_ManHinh dM_ManHinh)
        {
            try
            {
                DataRow row = adapter.GetData().Where(i => i.MaManHinh == dM_ManHinh.MaManHinh).FirstOrDefault();
                if(row==null)
                    return false;
                row["TenManHinh"] = dM_ManHinh.TenManHinh;
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
            DataRow row = adapter.GetData().OrderByDescending(i => i.MaManHinh).FirstOrDefault();
            if (row == null)
            {
                return "MH001";
            }
            int numId = int.Parse(row["MaManHinh"].ToString().Substring(2, 3));
            if (numId + 1 > 9)
            {
                return "MH0" + ++numId;
            }
            return "MH00" + ++numId;
        }
    }
}
