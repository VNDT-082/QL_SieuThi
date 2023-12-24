using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class NhaCungCapService
    {
        private readonly QLSieuThiDataContext _DBContext;

        public NhaCungCapService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public NhaCungCap getOneByID(int ID)
        {
            return _DBContext.NhaCungCaps.FirstOrDefault(i => i.MaNhanCungCap == ID);
        }
        public List<NhaCungCap> getAll()
        {
            return _DBContext.NhaCungCaps.ToList<NhaCungCap>();
        }
        public bool Insert(NhaCungCap nhaCungCap)
        {
            try {
                nhaCungCap.MaNhanCungCap = GenarateID();
                _DBContext.NhaCungCaps.InsertOnSubmit(nhaCungCap);
                _DBContext.SubmitChanges();
                return true;
            }catch (Exception ex) { return false; }
        }
        public bool Update(NhaCungCap nhaCungCap)
        {
            try
            {
                NhaCungCap ncc = getOneByID(nhaCungCap.MaNhanCungCap);
                if(ncc != null)
                {
                    ncc.TenNhaCungCap = nhaCungCap.TenNhaCungCap;
                    ncc.DiaChi = nhaCungCap.DiaChi;
                    ncc.SoDienThoai = nhaCungCap.SoDienThoai;
                    ncc.Email = nhaCungCap.Email;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        public bool Delete( int maNhaCungCap)
        {
            try
            {
                NhaCungCap ncc = getOneByID(maNhaCungCap);
                if (ncc != null)
                {
                    _DBContext.NhaCungCaps.DeleteOnSubmit(ncc);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        private int GenarateID()
        { 
            NhaCungCap ncc=_DBContext.NhaCungCaps.OrderByDescending(i=>i.MaNhanCungCap).FirstOrDefault();
            return (ncc != null) ? ncc.MaNhanCungCap + 1 : 1;
        }
    }
}
