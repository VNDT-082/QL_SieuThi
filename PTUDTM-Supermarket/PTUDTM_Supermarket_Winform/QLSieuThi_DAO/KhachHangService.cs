using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class KhachHangService
    {
        private readonly QLSieuThiDataContext _DBContext;
        public KhachHangService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public KhachHang getOneBySDT(string sdt)
        {
            return _DBContext.KhachHangs.FirstOrDefault(i => i.SoDienThoai == sdt);
        }
        public KhachHang getOneByID(int Id)
        {
            return _DBContext.KhachHangs.FirstOrDefault(i => i.MaKhachHang == Id);
        }

        public List<KhachHang> GetAll()
        {
            return _DBContext.KhachHangs.ToList();
        }
        public bool Insert(KhachHang khachHang)
        {
            try {
                KhachHang newKH = new KhachHang();
                newKH.MaKhachHang = GenerateID();
                newKH.TenKhachHang = khachHang.TenKhachHang;
                newKH.DiaChi = khachHang.DiaChi;
                newKH.MatKhau = khachHang.SoDienThoai;
                newKH.SoDienThoai = khachHang.SoDienThoai;
                newKH.GioiTinh = khachHang.GioiTinh;
                _DBContext.KhachHangs.InsertOnSubmit(newKH);
                _DBContext.SubmitChanges();
                return true;
            }
           catch (Exception ex) { Console.WriteLine(ex.Message.ToString());
                return false;
            }

        }
        private int GenerateID()
        {
            KhachHang kh = _DBContext.KhachHangs.OrderByDescending(i => i.MaKhachHang).FirstOrDefault();
            return (kh != null) ? kh.MaKhachHang + 1 : 1;
        }
    }
}
