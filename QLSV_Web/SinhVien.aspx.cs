using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLSV_Web.DAO1;

namespace QLSV_Web
{
    public partial class SinhVien : System.Web.UI.Page
    {
        protected string LoadTable()
        {
            SV_DAO db = new SV_DAO();            
            string htmlStr = "";
            List<SINHVIEN> reader = new List<SINHVIEN>();
            reader =  db.LayToanBoSinhVien();
            SINHVIEN item = new SINHVIEN();
            for (int i = 0; i < reader.Count(); i++)
            {
                item = reader[i];
                htmlStr += "<tr>";
                htmlStr += "<td>" + (i + 1).ToString() + "</td>";
                htmlStr += "<td>" + item.MaSV + "</td>";
                htmlStr += "<td>" + item.TenSV + "</td>";
                htmlStr += "<td>" + item.GioiTinh + "</td>";
                htmlStr += "<td>" + item.NamSinh + "</td>";
                htmlStr += "<td>" + item.MaLop + "</td>";
                htmlStr += "<td> <a href = 'SinhVien_Them.aspx?MaSinhVien=" + item.MaSV + "&Flag=2'>Sửa</a> </td > ";                
                htmlStr += "<td> <a href = 'SinhVien_Them.aspx?MaSinhVien=" + item.MaSV + "&Flag=3'>Xóa</a> </td > ";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
          
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            string ma = "";
            Response.Redirect("SinhVien_Them.aspx?MaSinhVien=" + ma + "&Flag=1");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Value.ToString();
            Response.Redirect("SinhVien_Them.aspx?MaSinhVien=" + ma + "&Flag=2");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}