using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class PhieuNhapHangService
    {
        private readonly QLSieuThiDataContext _DBContext;

        public PhieuNhapHangService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public PhieuNhapHang getOneByID(int maPhieuNhap)
        {
            return _DBContext.PhieuNhapHangs.FirstOrDefault(i => i.MaPhieuNhap == maPhieuNhap);
        }
        public List<PhieuNhapHang> getAll()
        {
            return _DBContext.PhieuNhapHangs.OrderByDescending(i=>i.NgayNhap).ToList<PhieuNhapHang>();
        }

        public PhieuNhapHang Insert(PhieuNhapHang phieuNhapHang)
        {
            try {
                phieuNhapHang.MaPhieuNhap = GenerateID();
                _DBContext.PhieuNhapHangs.InsertOnSubmit(phieuNhapHang);
                _DBContext.SubmitChanges();
                return getOneByID(phieuNhapHang.MaPhieuNhap);
            }catch(Exception ex) { return null; }
        }
        public bool Update(PhieuNhapHang phieuNhapHang)
        {
            try
            {
                PhieuNhapHang test = getOneByID(phieuNhapHang.MaPhieuNhap);
                if(test != null)
                {
                    //test.NgayNhap  =phieuNhapHang.NgayNhap ;
                    //test.MaNhanVien  =phieuNhapHang.MaNhanVien ;
                    test.NhaCungCap = _DBContext.NhaCungCaps.FirstOrDefault(i => i.MaNhanCungCap == phieuNhapHang.MaNhaCungCap);
                    test.MaNhaCungCap  =phieuNhapHang.MaNhaCungCap ;
                    //test.TrangThai =phieuNhapHang.TrangThai;
                    //test.GiaTri =phieuNhapHang.GiaTri;
                    //test.MaPhieuNhap =phieuNhapHang.MaPhieuNhap;
                    //test.QL_PheDuyet =phieuNhapHang.QL_PheDuyet;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        public bool Update2(PhieuNhapHang phieuNhapHang)
        {
            try
            {
                PhieuNhapHang test = getOneByID(phieuNhapHang.MaPhieuNhap);
                if (test != null)
                {
                    test.NgayNhap = phieuNhapHang.NgayNhap;
                    test.MaNhanVien = phieuNhapHang.MaNhanVien;
                    test.MaNhaCungCap = phieuNhapHang.MaNhaCungCap;
                    test.TrangThai = phieuNhapHang.TrangThai;
                    test.GiaTri = phieuNhapHang.GiaTri;
                    test.MaPhieuNhap = phieuNhapHang.MaPhieuNhap;
                    test.QL_PheDuyet = phieuNhapHang.QL_PheDuyet;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public bool Delete(int  MaPhieuNhap)
        {
            try
            {
                PhieuNhapHang test = getOneByID(MaPhieuNhap);
                if (test != null)
                {
                    List<ChiTietPhieuNhap> ds = _DBContext.ChiTietPhieuNhaps.Where(i => i.MaPhieuNhap == test.MaPhieuNhap).ToList();
                    if (ds != null)
                    {
                        foreach (ChiTietPhieuNhap ct in ds)
                        {
                            _DBContext.ChiTietPhieuNhaps.DeleteOnSubmit(ct);
                        }
                        _DBContext.SubmitChanges();
                    }
                    _DBContext.PhieuNhapHangs.DeleteOnSubmit(test);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        public List<PhieuNhapHang> getListByIdNhanVien(int maNhanVien)
        {
            List<PhieuNhapHang> ds = null;
            ds= _DBContext.PhieuNhapHangs.Where(i=>i.MaNhanVien==maNhanVien).OrderByDescending(i => i.NgayNhap).ToList<PhieuNhapHang>();
            return ds;
        }
        private int GenerateID()
        {
            PhieuNhapHang pn = _DBContext.PhieuNhapHangs.OrderByDescending(i => i.MaPhieuNhap).FirstOrDefault();

            return (pn != null) ? pn.MaPhieuNhap + 1 : 1;
        }
    }
}
