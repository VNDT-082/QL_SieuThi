using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class KhuyenMaiService
    {
        private QLSieuThiDataContext _DBContext;
        public KhuyenMaiService()
        { 
            _DBContext = new QLSieuThiDataContext();
        }
        public List<KhuyenMai> GetAll()
        {
            List<KhuyenMai> ds=new List<KhuyenMai>();
            ds= _DBContext.KhuyenMais.ToList();
            return ds;
        }
        public KhuyenMai GetOneByID(int maKhuyenMai)
        {
            return _DBContext.KhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == maKhuyenMai);
        }
        public KhuyenMai Insert(KhuyenMai khuyenMai)
        {
            try {
                khuyenMai.MaKhuyenMai = GenarateID();
                _DBContext.KhuyenMais.InsertOnSubmit(khuyenMai);
                _DBContext.SubmitChanges();
                return _DBContext.KhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == khuyenMai.MaKhuyenMai);
            }
            catch (Exception ex) { return null; }
        }

        public bool Update(KhuyenMai khuyenMai)
        {
            try
            {
                KhuyenMai km = _DBContext.KhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == khuyenMai.MaKhuyenMai);
                if (km != null)
                {
                    km.NoiDung = khuyenMai.NoiDung;
                    km.NgayBatDau = khuyenMai.NgayBatDau;
                    km.NgayKetThuc = khuyenMai.NgayKetThuc;
                    km.GiaTriKhuyenMai = khuyenMai.GiaTriKhuyenMai;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        public bool Delete(int MaKhuyenMai)
        {
            try
            {
                KhuyenMai km = _DBContext.KhuyenMais.FirstOrDefault(i => i.MaKhuyenMai == MaKhuyenMai);
                if (km != null)
                {
                    List<ChiTietKhuyenMai> ds = new List<ChiTietKhuyenMai>();
                    ds = _DBContext.ChiTietKhuyenMais.Where(i => i.MaKhuyenMai == km.MaKhuyenMai).ToList();
                    if (ds != null) {
                        if (ds.Count > 0)
                        {
                            foreach (ChiTietKhuyenMai ct in ds)
                            {
                                _DBContext.ChiTietKhuyenMais.DeleteOnSubmit(ct);
                            }
                            _DBContext.SubmitChanges();
                        }
                    }
                    _DBContext.KhuyenMais.DeleteOnSubmit(km);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        private int GenarateID()
        {
            KhuyenMai km = _DBContext.KhuyenMais.OrderByDescending(i => i.MaKhuyenMai).FirstOrDefault();
            return (km != null) ? km.MaKhuyenMai + 1 : 1;
        }
    }
}
