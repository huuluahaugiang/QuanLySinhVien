using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSV_Web.DAO1
{
    public class SinhVienDAO
    {
        private QLSV2021Entities3 db = null;
        public SinhVienDAO()
        {
            db = new QLSV2021Entities3();
        }
        public List<SINHVIEN> GetAllData()
        {
            return db.SINHVIENs.ToList();
        }

        
        public List<LayToanBoSV_Result> LayToanBoSinhVien()
        {
            List<LayToanBoSV_Result> listLTS = null;
            // listLTS = db.Database.SqlQuery<LayToanBoSV_Result>("exec LayToanBoSV", new System.Data.SqlClient.SqlParameter("@MaLoai", MaLoai)).ToList();
            return listLTS;
        }

        public List<LaySVTheoLop_Result> LaySinhVienTheoLop(string MaLop)
        {            
            List<LaySVTheoLop_Result> listSV = null;
            listSV = db.Database.SqlQuery<LaySVTheoLop_Result>("exec LaySVTheoLop @MaLop", new System.Data.SqlClient.SqlParameter("@MaLop", MaLop)).ToList();
            return listSV;
        }
        public void Insert(SINHVIEN sv)
        {
            db.SINHVIENs.Add(sv);
            db.SaveChanges();
        }
        public bool Update(SINHVIEN entity)
        {
            try
            {
                var sv = db.SINHVIENs.Find(entity.MaSV);
                sv.TenSV = entity.TenSV;
                sv.MaLop = entity.MaLop;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                var lst = db.SINHVIENs.Find(id);
                db.SINHVIENs.Remove(lst);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SINHVIEN ViewDetail(string id)
        {
            return db.SINHVIENs.Find(id);
        }
    }
   
}