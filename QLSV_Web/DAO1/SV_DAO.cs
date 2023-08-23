using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSV_Web.DAO1
{
    public class SV_DAO
    {
        private QLSV2021Entities3 db = null;
        public SV_DAO()
        {
            db = new QLSV2021Entities3();
        }
        public List<SINHVIEN> LayToanBoSinhVien()
        {
            return db.SINHVIENs.ToList();
        }
        public void Them(SINHVIEN sv)
        {
            db.SINHVIENs.Add(sv);
            db.SaveChanges();
        }
        
        public bool Sua(SINHVIEN SV)
        {
            try
            {
                var sv_Sua = db.SINHVIENs.Find(SV.MaSV);
                sv_Sua.TenSV = SV.TenSV;
                sv_Sua.NamSinh = SV.NamSinh;
                sv_Sua.GioiTinh = SV.GioiTinh;
                sv_Sua.NamSinh = SV.NamSinh;
                sv_Sua.MaLop = SV.MaLop;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string MaSV)
        {
            try
            {
                var SV_Xoa = db.SINHVIENs.Find(MaSV);
                db.SINHVIENs.Remove(SV_Xoa);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SINHVIEN HienThi(string MaSV)
        {
            return db.SINHVIENs.Find(MaSV);
        }
    }
}