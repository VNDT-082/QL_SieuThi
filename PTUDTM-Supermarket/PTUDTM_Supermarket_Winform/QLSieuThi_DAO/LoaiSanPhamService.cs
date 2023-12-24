using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class LoaiSanPhamService
    {
        private QLSieuThiDataContext _DBContext;
        public LoaiSanPhamService()
        { 
            _DBContext = new QLSieuThiDataContext();
        }
        public List<LoaiSanPham> GetAll()
        {
            return _DBContext.LoaiSanPhams.ToList();
        }

        public LoaiSanPham GetOneById(int maLoai)
        {
            return _DBContext.LoaiSanPhams.FirstOrDefault(i => i.MaLoai == maLoai);
        }
        public LoaiSanPham Insert( LoaiSanPham lsp)
        {
            try {
                lsp.MaLoai = GenarateID();
                _DBContext.LoaiSanPhams.InsertOnSubmit(lsp);
                _DBContext.SubmitChanges();
                return GetOneById(lsp.MaLoai);
            }catch(Exception ex) { return  null; }
        }
        public bool Update(LoaiSanPham lsp)
        {
            try
            {
                LoaiSanPham test = GetOneById(lsp.MaLoai);
                if (test != null)
                {
                    test.TenLoai = lsp.TenLoai;
                    test.MoTa = lsp.MoTa;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public bool Delete(int maLoai)
        {
            try
            {
                LoaiSanPham test = GetOneById(maLoai);
                if (test != null)
                {
                    List<SanPham> ds = _DBContext.SanPhams.Where(i => i.MaLoai == maLoai).ToList();
                    if (ds != null)
                    {
                        _DBContext.LoaiSanPhams.DeleteOnSubmit(test);
                        _DBContext.SubmitChanges();
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }
        private int GenarateID()
        {
            LoaiSanPham ncc = _DBContext.LoaiSanPhams.OrderByDescending(i => i.MaLoai).FirstOrDefault();
            return (ncc != null) ? ncc.MaLoai + 1 : 1;
        }
    }
}
