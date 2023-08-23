<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinhVien_Them.aspx.cs" Inherits="QLSV_Web.SinhVien_Them" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>                                                          
            <asp:Button ID="btnLưu" CssClass ="btn btn-info" runat="server" Text="Lưu" OnClick="btnLuu_Click"/>
            <asp:Button ID="btnHuy" CssClass ="btn btn-info" runat="server" Text="Hủy" OnClick="btnHuy_Click" CausesValidation="false"/>
            <br />
            <b>Nhập thông tin sinh viên</b>
            <div class="form-group">
                Mã sinh viên (*)
            </div>                                        
            <div class="form-group">
                <asp:TextBox ID="txtMaSV" runat="server"></asp:TextBox>
            </div>                                                              
            <div class="form-group">
                Tên sinh viên (*)
            </div>                                        
            <div class="form-group">                
                <asp:TextBox ID="txtTenSV" runat="server"></asp:TextBox>
            </div>                                                                       
            <div class="form-group">
                Giới tính
            </div>                                        
            <div class="form-group">
                <asp:CheckBox ID="chkGioiTinh" runat="server" />                
            </div>  
            <div class="form-group">
                Năm sinh
            </div>                                        
            <div class="form-group">
                <asp:TextBox ID="txtNamSinh" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                Mã lớp
            </div>                                                    
            <div class="form-group">                                                    
                <asp:DropDownList ID="ddlMaLop"  runat="server"  class="form-control"></asp:DropDownList>
            </div>
            <asp:HiddenField id="txtMa" runat="server" />
        </div>    
    </form>
</body>
</html>
