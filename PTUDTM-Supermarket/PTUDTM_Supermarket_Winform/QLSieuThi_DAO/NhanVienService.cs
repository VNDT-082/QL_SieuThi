using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class NhanVienService
    {
        private readonly QLSieuThiDataContext _DBContext;

        public NhanVienService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public NhanVien getOneByID(int ID)
        {
            return _DBContext.NhanViens.FirstOrDefault(i => i.MaNhanVien == ID);
        }
        public NhanVien getOneByTenDangNhap(string tenDangNhap)
        {
            return _DBContext.NhanViens.FirstOrDefault(i => i.TenDangNhap == tenDangNhap);
        }
        public List<NhanVien> GetAll() {
            return _DBContext.NhanViens.ToList();
        }
        public NhanVien Insert(NhanVien nhanVien)
        {
            try {
                nhanVien.MaNhanVien = GenerateId();
                _DBContext.NhanViens.InsertOnSubmit(nhanVien);
                _DBContext.SubmitChanges();
                return getOneByID(nhanVien.MaNhanVien);
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); return null; }
        }

        public bool Update(NhanVien nhanVien)
        {
            try
            {
                NhanVien nhanVienEntity = getOneByID(nhanVien.MaNhanVien);
                if (nhanVienEntity != null)
                {
                    nhanVienEntity.TenDangNhap = nhanVien.TenDangNhap;
                    nhanVienEntity.LoaiNhanVien = nhanVien.LoaiNhanVien;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return false; }
        }

        public bool Delete(NhanVien nhanVien)
        {
            try
            {
                NhanVien nhanVienEntity = getOneByID(nhanVien.MaNhanVien);
                if (nhanVienEntity != null)
                {
                    _DBContext.NhanViens.DeleteOnSubmit(nhanVienEntity);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return false; }
        }
        private int GenerateId()
        {
            NhanVien nhanVien = _DBContext.NhanViens.OrderByDescending(i => i.MaNhanVien).FirstOrDefault();
            if (nhanVien == null)
                return 1;
            else
                return nhanVien.MaNhanVien + 1;
        }
    }
}
