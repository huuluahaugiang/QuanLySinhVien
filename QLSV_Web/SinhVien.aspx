<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinhVien.aspx.cs" Inherits="QLSV_Web.SinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</head>
    <body>
        <form id="form1" runat="server">
            <div>
                <div class="panel-heading">       
                    <b>Danh mục Sinh viên</b> 
                    <asp:Button ID="btnHome" class="btn btn-info" runat="server" Text="Trang chủ" OnClick="btnHome_Click"/>
                    <asp:Button ID="btnThem" class ="btn btn-info" runat="server" Text="Thêm" OnClick="btnThem_Click"/>                                    
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <table>
                        <thead>
                            <tr>                                        
                                <th>STT</th>
                                <th>Mã sinh viên</th>
                                <th>Tên sinh viên</th>
                                <th>Gioi tính</th>
                                <th>Năm sinh</th>
                                <th>Mã lớp</th>
                                <th>Sửa</th>
                                <th>Xóa</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%=LoadTable()%>
                        </tbody>
                    </table>  
                    <asp:HiddenField id="txtMa" runat="server" />
                </div>        
            </div>
        </form>
        <script>
        var table = document.getElementsByTagName("table")[0];
        var tbody = table.getElementsByTagName("tbody")[0];
        tbody.onclick = function (e) {
            e = e || window.event;
            var data = [];
            var target = e.srcElement || e.target;
            while (target && target.nodeName !== "TR") {
                target = target.parentNode;
            }
            if (target) {
                var cells = target.getElementsByTagName("td");
                for (var i = 0; i < cells.length; i++) {
                    data.push(cells[i].innerHTML);
                }
            }
            //alert(data[1]);            
            $('#<%= txtMa.ClientID %>').val(data[1]);
        };
        </script>
    </body>
</html>
