using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLSV_Web.DAO1;

namespace QLSV_Web
{
    public partial class SinhVien_Them : System.Web.UI.Page
    {
        static string ma = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadCboLop();                
                ma = Request.QueryString["MaSinhVien"].ToString();
                string Flag = Request.QueryString["Flag"].ToString();
                if (ma != "")
                {
                    SV_DAO db = new SV_DAO();
                    if (Flag == "3")
                    {
                        db.Xoa(ma);
                        Response.Redirect("SinhVien.aspx");
                    }
                    else
                    {                        
                        SINHVIEN item = new SINHVIEN();
                        item = db.HienThi(ma);
                        if (item != null)
                        {
                            txtMaSV.Text = item.MaSV;
                            txtMaSV.ReadOnly = true;
                            txtTenSV.Text = item.TenSV;
                            if (item.GioiTinh == "Nữ")
                            {
                                chkGioiTinh.Checked = true;
                            }
                            else
                            {
                                chkGioiTinh.Checked = false;
                            }
                            txtNamSinh.Text = item.NamSinh;
                            ddlMaLop.SelectedValue = item.MaLop;
                        }
                    }
                }
            }
        }
        private void LoadCboLop()
        {
            LopDAO dao = new LopDAO ();
            ddlMaLop.DataSource = dao.GetAllData();
            ddlMaLop.DataTextField = "TenLop";
            ddlMaLop.DataValueField = "MaLop";
            ddlMaLop.DataBind();
        }       
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("SinhVien.aspx");
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SINHVIEN item = new SINHVIEN();                
                item.MaSV = txtMaSV.Text;
                item.TenSV = txtTenSV.Text;
                if (chkGioiTinh.Checked)
                {
                    item.GioiTinh = "Nữ";
                }
                else
                {
                    item.GioiTinh = "Nam";
                }
                item.NamSinh = txtNamSinh.Text;
                item.MaLop = ddlMaLop.SelectedValue.ToString();                
                SV_DAO db = new SV_DAO();
                if (ma == "")
                {
                    db.Them(item);
                }
                else
                {
                    db.Sua(item);
                }
                Response.Redirect("SinhVien.aspx");
            }
        }
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("SinhVien.aspx");
        }
    }
}