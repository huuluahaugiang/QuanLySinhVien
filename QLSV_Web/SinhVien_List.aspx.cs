using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLSV_Web.DAO1;

namespace QLSV_Web
{
    public partial class SinhVien_List : System.Web.UI.Page
    {
        public string MaLop = "*";
        static string ma = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["MaLop"] != null)
                MaLop = Request.QueryString["MaLop"].ToString();
            else
                MaLop = "LOAI4";
            if (Page.IsPostBack)
            {
                ma = "";
            }
        }
        public string LoadTree()
        {
            string htmlStr = "";
            LopDAO db = new LopDAO();
            List<LocLopCoSinhVien_Result> dr = new List<LocLopCoSinhVien_Result>();
            dr = db.LocLopCoSV();
            LocLopCoSinhVien_Result item = new LocLopCoSinhVien_Result();
            for (int i = 0; i < dr.Count(); i++)
            {
                item = dr[i];
                htmlStr += "<li>";
                htmlStr += "<a href='SinhVien_list.aspx?MaLop=" + item.MaLop + "'>" + item.TenLop + "<span class='fa arrow'></span></a>";
                htmlStr += "</li>";
            }
            return htmlStr;
        }

        public string LoadTree2()
        {
            string htmlStr = "";
            KhoaDAO db = new KhoaDAO();
            List<KHOA> drKhoa = new List<KHOA>();
            drKhoa = db.GetAllData();
            KHOA itemKhoa;
            for (int i = 0; i < drKhoa.Count(); i++)
            {
                itemKhoa = drKhoa[i];
                htmlStr += "<li>";
                htmlStr += "<a href='#'><i class='fa fa-home fa-fw'></i>" + itemKhoa.TenKhoa + "<span class='fa arrow'></span></a>";
                htmlStr += "<ul class='nav nav-second-level'>";                
                LopDAO db2 = new LopDAO();
                List<LocLopCoSinhVien_Result> dr = new List<LocLopCoSinhVien_Result>();
                dr = db2.LocLopCoSV();
                LocLopCoSinhVien_Result item = new LocLopCoSinhVien_Result();
                for (int j = 0; i < dr.Count(); j++)
                if (drKhoa[i].Nam== (dr[j].NamHoc))
                {
                    item = dr[j];
                    htmlStr += "<li>";
                    htmlStr += "<a href='SinhVien_list.aspx?MaLop=" + item.MaLop + "'>" + item.TenLop + "<span class='fa arrow'></span></a>";
                    htmlStr += "</li>";
                }
                htmlStr += "</ul>";
                htmlStr += "</li>";
            }
            return htmlStr;
        }

        public string LoadTree3()
        {
            string htmlStr = "";
            LopDAO db = new LopDAO();
            List<int> dr = new List<int>();
            dr = db.GetNamHoc();
            int item ;
            for (int i = 0; i < dr.Count(); i++)
            {
                item = dr[i];
                htmlStr += "<li>";
                htmlStr += "<a href='SinhVien_list.aspx?MaLop=" + item + "'>" + item + "<span class='fa arrow'></span></a>";
                htmlStr += "</li>";
            }
            return htmlStr;
        }
        public string LaySinhVienTheoLop()
        {            
            SinhVienDAO dao = new  SinhVienDAO();
            List<LaySVTheoLop_Result> reader = dao.LaySinhVienTheoLop(MaLop);
            LaySVTheoLop_Result item = new LaySVTheoLop_Result();

            string htmlStr = "";
            htmlStr += "<table style = 'width:100%' class='table table-striped table-bordered table-hover' id='dataTables-example'>";
            htmlStr +=  "<thead>";
            htmlStr +=      "<tr>";
            htmlStr +=          "<th> STT </th>";
            htmlStr +=          "<th> Mã sinh viên </th>";
            htmlStr +=          "<th> Tên sinh viên</th>";
            htmlStr +=          "<th> Gioi tính </th>";
            htmlStr +=          "<th> Năm sinh </th>";
            htmlStr +=          "<th> Mã lớp </th>";
            htmlStr +=      "</tr>";
            htmlStr +=  "</thead>";
            htmlStr += "<tbody style = 'white -space:nowrap'>";           
            for (int i = 0; i < reader.Count(); i++)
            {
                item = reader[i];
                htmlStr += "<tr>";
                htmlStr +=      "<td>" + (i + 1).ToString() + "</td>";
                htmlStr +=      "<td>" + item.MaSV + "</td>";
                htmlStr +=      "<td>" + item.TenSV + "</td>";
                htmlStr +=      "<td>" + item.GioiTinh + "</td>";
                htmlStr +=      "<td>" + item.NamSinh + "</td>";
                htmlStr +=      "<td>" + item.MaLop + "</td>";                
                htmlStr += "</tr>";
            }
            htmlStr += "</ tbody >";
            htmlStr += " </ table >";
            return htmlStr;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            string ma = "";
            Response.Redirect("SinhVien_New.aspx?MaSinhVien=" + ma + "&Flag=1");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Value.ToString();
            Response.Redirect("SinhVien_New.aspx?MaSinhVien=" + ma + "&Flag=2");
        }
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVienDAO db = new SinhVienDAO();
            string ma = txtMa.Value.ToString();
            db.Delete(ma);
        }
    }
}