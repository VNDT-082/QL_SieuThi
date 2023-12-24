using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class PhieuBanHangService
    {
        private readonly QLSieuThiDataContext _DBContext;

        public PhieuBanHangService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public PhieuBanHang GetOneById(int maPhieuBan)
        {
            PhieuBanHang phieuBanHang = null;
            phieuBanHang = _DBContext.PhieuBanHangs.FirstOrDefault(i => i.ID == maPhieuBan);
            return phieuBanHang;
        }
        public List<PhieuBanHang> GetAll()
        {
            return _DBContext.PhieuBanHangs.ToList<PhieuBanHang>();
        }
        public List<PhieuBanHang> GetListByNhanVienId(int maNhanVien)
        {
            List<PhieuBanHang> dsPhieuBan = null;
            dsPhieuBan = _DBContext.PhieuBanHangs.Where(i => i.MaNhanVien == maNhanVien).ToList();
            return dsPhieuBan;
        }
        public List<PhieuBanHang> GetListByKhachHangId(int maKhachHang)
        {
            List<PhieuBanHang> dsPhieuBan = null;
            dsPhieuBan = _DBContext.PhieuBanHangs.Where(i => i.MaKhachHang == maKhachHang).ToList();
            return dsPhieuBan;
        }

        public PhieuBanHang Insert(PhieuBanHang phieuBanHang)
        {
            try {
                phieuBanHang.ID = GenerateId();
                phieuBanHang.NgayMua = DateTime.Now;
                _DBContext.PhieuBanHangs.InsertOnSubmit(phieuBanHang);
                _DBContext.SubmitChanges();
                PhieuBanHang phieuBan = GetOneById(phieuBanHang.ID);
                return phieuBan;
            }catch(Exception ex) { Console.WriteLine(ex.Message); return null; }

        }

        public bool Update(PhieuBanHang phieuBanHang)
        {
            try
            {
                PhieuBanHang phieuBanHang_ = GetOneById(phieuBanHang.ID);
                if (phieuBanHang_ != null)
                {
                    phieuBanHang_.TongTien = phieuBanHang.TongTien;
                    phieuBanHang_.TienPhaiTra = phieuBanHang.TienPhaiTra;
                    phieuBanHang_.GiamGia = phieuBanHang.GiamGia;
                    phieuBanHang_.TrangThai = phieuBanHang.TrangThai;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }

        }

        public bool Delete(int  maPhieuBanHang)
        {
            try
            {
                PhieuBanHang phieuBanHang_ = GetOneById(maPhieuBanHang);
                if (phieuBanHang_ != null)
                {
                    List<ChiTietHoaDon> dshd = _DBContext.ChiTietHoaDons.Where(i => i.ID_PhieuBan == phieuBanHang_.ID).ToList();
                    if (dshd != null)
                    {
                        foreach (ChiTietHoaDon ct in dshd)
                        {
                            _DBContext.ChiTietHoaDons.DeleteOnSubmit(ct);
                        }
                        _DBContext.SubmitChanges();
                    }

                    _DBContext.PhieuBanHangs.DeleteOnSubmit(phieuBanHang_);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }

        }
        private int GenerateId()
        {
            PhieuBanHang phieuBanHang = _DBContext.PhieuBanHangs.OrderByDescending(i => i.ID).FirstOrDefault();
            if (phieuBanHang == null)
                return 1;
            return phieuBanHang.ID + 1;
        }
    }
}
