using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class ChiTietKhuyenMaiService
    {
        private QLSieuThiDataContext _DBContext;
        public ChiTietKhuyenMaiService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public List<ChiTietKhuyenMai> GetAll()
        {
            List<ChiTietKhuyenMai> ds = new List<ChiTietKhuyenMai>();
            ds = _DBContext.ChiTietKhuyenMais.ToList();
            return ds;
        }

        public List<ChiTietKhuyenMai> GetListByIdKhuyenMai(int maKhuyenMai)
        {
            List<ChiTietKhuyenMai> ds = new List<ChiTietKhuyenMai>();
            ds = _DBContext.ChiTietKhuyenMais.Where(i=>i.MaKhuyenMai==maKhuyenMai).ToList();
            return ds;
        }
        public ChiTietKhuyenMai Insert(ChiTietKhuyenMai chiTietKhuyenMai)
        {
            try {
                ChiTietKhuyenMai test = _DBContext.ChiTietKhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == chiTietKhuyenMai.MaKhuyenMai
                && i.MaSanPham == chiTietKhuyenMai.MaSanPham);
                if (test != null)
                {
                    return null;
                }
                _DBContext.ChiTietKhuyenMais.InsertOnSubmit(chiTietKhuyenMai);
                _DBContext.SubmitChanges();
                return _DBContext.ChiTietKhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == chiTietKhuyenMai.MaKhuyenMai
                && i.MaSanPham == chiTietKhuyenMai.MaSanPham);
            }
            catch (Exception ex) { return null; }   
        }
        public bool Update(ChiTietKhuyenMai chiTietKhuyenMai)
        { 
            ChiTietKhuyenMai test= _DBContext.ChiTietKhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == chiTietKhuyenMai.MaKhuyenMai
                && i.MaSanPham == chiTietKhuyenMai.MaSanPham);
            if (test != null)
            {
                test.GiaTriKhuyenMai = chiTietKhuyenMai.GiaTriKhuyenMai;
                _DBContext.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool Delete(ChiTietKhuyenMai chiTietKhuyenMai)
        {
            ChiTietKhuyenMai test = _DBContext.ChiTietKhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == chiTietKhuyenMai.MaKhuyenMai
                && i.MaSanPham == chiTietKhuyenMai.MaSanPham);
            if (test != null)
            {
                _DBContext.ChiTietKhuyenMais.DeleteOnSubmit(test);
                _DBContext.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
