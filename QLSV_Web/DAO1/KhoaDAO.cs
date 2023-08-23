using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLSV_Web
{
    public class KhoaDAO
    {
        private QLSV2021Entities2 db = null;
        public KhoaDAO()
        {
            db = new QLSV2021Entities2();
        }
        public List<KHOA> GetAllData()
        {
            return db.KHOAs.ToList();
        }
    }
}