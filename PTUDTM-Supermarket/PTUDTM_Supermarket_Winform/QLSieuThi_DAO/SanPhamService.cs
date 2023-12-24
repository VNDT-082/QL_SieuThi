using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi_DAO
{
    public class SanPhamService
    {
        private readonly QLSieuThiDataContext _DBContext;
        public SanPhamService()
        {
            _DBContext = new QLSieuThiDataContext();
        }
        public List<SanPham> getAll()
        {
            return _DBContext.SanPhams.ToList<SanPham>();
        }
        public List<SanPham> getByCategory(int maLoai)
        {
            return _DBContext.SanPhams.Where(i => i.MaLoai == maLoai).ToList<SanPham>();
        }
        public SanPham getOneByID(int Id)
        {
            return _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == Id);
        }

        public List<SanPham> TimKiem(string Id)
        {
            int ID = 0;
            bool kq = int.TryParse(Id,out ID);
            List < SanPham > ds=new List < SanPham >();
            if (kq == true)
            {
                SanPham sp=getOneByID(ID);
                if (sp != null)
                {
                    ds.Add(sp);
                }
                
            }
            else { 
                ds=_DBContext.SanPhams.Where(i=>i.TenSanPham.Contains(Id)).ToList<SanPham>();
            }
            return ds;
        }
        public int Count(string value)
        {
            try
            {
                return _DBContext.SanPhams.Where(i => i.TenSanPham.Contains(value)).Count();
            }
            catch (Exception ex) { Console.WriteLine(ex); return 0; }
        }
        public List<SanPham> getTop3ConcatName(string value,int pageNum)
        { 
            int pageSize=_DBContext.SanPhams.Where(i=>i.TenSanPham.Contains(value)).Count();
            List<SanPham> ds;
            if (pageSize <= 3)
            {
                ds = _DBContext.SanPhams.Where(i => i.TenSanPham.Contains(value)).ToList<SanPham>();
                return ds;
            }
            else if(pageSize>3) {
                ds = _DBContext.SanPhams.Where(i => i.TenSanPham.Contains(value)).Skip((pageNum-1)*3).Take(3).ToList<SanPham>();
                return ds;
            }
            return null;
        }
        public bool update(SanPham sanPham)
        {
            try
            {
                var sp = _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == sanPham.MaSanPham);
                if (sp != null)
                {
                    sp.TenSanPham = sanPham.TenSanPham;
                    LoaiSanPham lsp = _DBContext.LoaiSanPhams.FirstOrDefault(i => i.MaLoai == sanPham.MaLoai);
                    if(lsp != null)
                    {
                        sp.LoaiSanPham = lsp;
                        sp.MaLoai = lsp.MaLoai;
                    }
                   
                    //sp.HinhAnh = sanPham.HinhAnh;
                    sp.Gia = sanPham.Gia;
                    sp.SoLuongTon = sanPham.SoLuongTon;
                    sp.DonViTinh = sanPham.DonViTinh;
                    sp.MoTa = sanPham.MoTa;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }

        public bool updateHinhAnh(SanPham sanPham)
        {
            try
            {
                var sp = _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == sanPham.MaSanPham);
                if (sp != null)
                {
                    sp.HinhAnh = sanPham.HinhAnh;
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
        public bool delete(int Id)
        {
            try
            {
                var sp = _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == Id);
                if (sp != null)
                {
                    List<ChiTietHoaDon> ds = _DBContext.ChiTietHoaDons.Where(i => i.MaSanPham == sp.MaSanPham).ToList();
                    if (ds != null)
                    {
                        if (ds.Count > 0)
                        {
                            sp.SoLuongTon = -1;
                            update(sp);
                            return true;
                        }
                    }
                    _DBContext.SanPhams.DeleteOnSubmit(sp);
                    _DBContext.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }
        }
        public SanPham insertOne(SanPham sanPham)
        {
            try
            {
                var sp = _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == sanPham.MaSanPham);
                if (sp == null)
                {
                    sanPham.MaSanPham = GenerateID();
                    _DBContext.SanPhams.InsertOnSubmit(sanPham);
                    _DBContext.SubmitChanges();
                    return _DBContext.SanPhams.FirstOrDefault(i => i.MaSanPham == sanPham.MaSanPham);
                }
                return null;
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
        }

        private int GenerateID()
        {
            SanPham sp = _DBContext.SanPhams.OrderByDescending(i => i.MaSanPham).FirstOrDefault();
            if (sp == null)
                return 1;
            return sp.MaSanPham + 1;
        }
    }
}
