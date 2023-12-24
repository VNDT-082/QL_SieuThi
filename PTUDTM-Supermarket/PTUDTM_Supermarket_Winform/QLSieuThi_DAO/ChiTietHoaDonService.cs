using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class ChiTietHoaDonService
    {
        private readonly QLSieuThiDataContext _DBContext;

        public ChiTietHoaDonService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public ChiTietHoaDon GetListOneById(ChiTietHoaDon ChiTietHoaDon)
        {
            ChiTietHoaDon chiTietHoaDon = null;
            chiTietHoaDon = _DBContext.ChiTietHoaDons.FirstOrDefault(i => i.ID==ChiTietHoaDon.ID);
            return chiTietHoaDon;
        }
        public List<ChiTietHoaDon> GetListByHoaDonId(int maHoaDon)
        { 
            List<ChiTietHoaDon> dsChiTietHoaDon = null;
            dsChiTietHoaDon = _DBContext.ChiTietHoaDons.Where(i => i.ID_PhieuBan == maHoaDon).ToList();
            return dsChiTietHoaDon;
        }
        public bool Insert(ChiTietHoaDon chiTietHoaDon)
        {
            try {
                chiTietHoaDon.ID = GenerateId(chiTietHoaDon.ID_PhieuBan);
                _DBContext.ChiTietHoaDons.InsertOnSubmit(chiTietHoaDon);
                _DBContext.SubmitChanges();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        private int GenerateId(int? idPhieuBan)
        {
            ChiTietHoaDon chiTietHoaDon = _DBContext.ChiTietHoaDons.Where(i => i.ID_PhieuBan == idPhieuBan).OrderByDescending(i => i.ID).FirstOrDefault();
            if (chiTietHoaDon == null)
                return 1;
            return chiTietHoaDon.ID + 1;
        }
    }
}
