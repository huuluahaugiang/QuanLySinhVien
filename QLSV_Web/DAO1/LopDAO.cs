using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSV_Web
{
    public class LopDAO
    {
        private QLSV2021Entities3 db = null;
        public LopDAO()
        {
            db = new QLSV2021Entities3();
        }
        public List<LOP> GetAllData()
        {
            return db.LOPs.ToList();
        }
        public List<LocLopCoSinhVien_Result> LocLopCoSV()
        {
            List<LocLopCoSinhVien_Result> listSV = null;
            listSV = db.Database.SqlQuery<LocLopCoSinhVien_Result>("exec LocLopCoSinhVien").ToList();
            return listSV;
        }

        public List<int> GetNamHoc()
        {
            List<int> L = new List<int> {2011, 2012, 2013, 2014, 2015, 2016, 2021};
            return L;
        }

    }
}