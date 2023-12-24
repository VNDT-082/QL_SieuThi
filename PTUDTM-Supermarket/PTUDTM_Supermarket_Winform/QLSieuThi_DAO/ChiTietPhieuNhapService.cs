using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class ChiTietPhieuNhapService
    {
        private readonly QLSieuThiDataContext _DBContext;
        public ChiTietPhieuNhapService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public List<ChiTietPhieuNhap> getListByIdPhieuNhap(int maPhieuNhap)
        {
            return  _DBContext.ChiTietPhieuNhaps.Where(i => i.MaPhieuNhap == maPhieuNhap).ToList();
        }

        public ChiTietPhieuNhap getOneById(int maPhieuNhap, int maSanPham)
        {
            return _DBContext.ChiTietPhieuNhaps.FirstOrDefault(i => i.MaPhieuNhap == maPhieuNhap&& i.MaSanPham==maSanPham);
        }
        public ChiTietPhieuNhap Insert(ChiTietPhieuNhap ct)
        {
            try
            {
                _DBContext.ChiTietPhieuNhaps.InsertOnSubmit(ct);
                _DBContext.SubmitChanges();
                return getOneById(ct.MaPhieuNhap, ct.MaSanPham);
            }
            catch (Exception ex) { return null; }
        }
        public bool Update(ChiTietPhieuNhap ct)
        {
            try
            {
                ChiTietPhieuNhap test = getOneById(ct.MaPhieuNhap, ct.MaSanPham);
                if (test!=null)
                {
                    test.SoLuong = ct.SoLuong;
                    test.Gia = ct.Gia;
                    test.TongCong = ct.TongCong;
                    test.TrangThai = ct.TrangThai;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public bool Delete(int maPhieuNhap, int maSanPham)
        {
            try
            {
                ChiTietPhieuNhap test = getOneById(maPhieuNhap, maSanPham);
                if (test != null)
                {
                    _DBContext.ChiTietPhieuNhaps.DeleteOnSubmit(test);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
    }
}
