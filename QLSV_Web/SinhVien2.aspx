<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinhVien2.aspx.cs" Inherits="QLSV_Web.SinhVien2" %>

<!DOCTYPE html>

<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Hệ thống quản lý sinh viên</title>
    
    <!-- DataTables CSS -->    
    <link href="Content/vendor/datatables-plugins/dataTables.bootstrap.css" rel="stylesheet" />
    <!-- DataTables Responsive CSS -->
    <link href="Content/vendor/datatables-responsive/dataTables.responsive.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="Content/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <!-- Bootstrap Core CSS -->
    <link href="Content/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- MetisMenu CSS -->    
    <link href="Content/vendor/metisMenu/metisMenu.min.css" rel="stylesheet" />
    <!-- Custom CSS -->    
    <link href="Content/dist/css/sb-admin-2.css" rel="stylesheet" />
    <!-- Morris Charts CSS -->    
    <link href="Content/vendor/morrisjs/morris.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="Content/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">       

</head>

<body>
    <div id="wrapper">
         <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a id="tua" class="navbar-brand" href="Default.html">Hệ thống quản lý sinh viên - Danh sách sinh viên</a>
            </div>
            <!-- /.navbar-header -->
            <ul class="nav navbar-top-links navbar-right">
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i> <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li><a href="#"><i class="fa fa-user fa-fw"></i> Thông tin tài khoản</a>
                        </li>
                        <li><a href="#"><i class="fa fa-gear fa-fw"></i> Cài đặt</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="login.html"><i class="fa fa-sign-out fa-fw"></i> Đăng xuất</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->

             <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu"> 
                         <li class="sidebar-search">
                            <div class="input-group custom-search-form">
                                <input type="text" class="form-control" placeholder="Search...">
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <i class="fa fa-search"></i>
                                    </button>
                                </span>
                            </div>                            
                        </li>                           
                        <%=LoadTree()%>                        
                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

        <div id="page-wrapper">
            <div class="row">
                <form id ="SoTaiSanCoDinh" runat ="server">                                
                    <div class="col-lg-12">   
                        <div class="panel panel-default">
                            <div class="panel-heading">   
                                <b>Danh mục tài sản</b>                                
                                <asp:Button ID="Button1" CssClass ="btn btn-info" runat="server" Text="Thêm" OnClick="btnThem_Click" />                                               
                                <asp:Button ID="Button2"  CssClass ="btn btn-info"  runat="server" Text="Sửa" OnClick="btnSua_Click" />                                  
                                <button type="button" class="btn btn-info" data-toggle="modal" data-target="#DeleteModal">Xóa</button> 
                                <asp:HiddenField id="txtMa" runat="server" />   
                            </div>         
                            <div class="panel-body">                                        
                                <table style="width:100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                    <thead>
                                        <tr>                                                                           
                                            <th>STT</th>
                                            <%--<th>Mã sinh viên</th>--%>
                                            <th>Tên sinh viên</th>
                                            <th>Gioi tính</th>
                                            <th>Năm sinh</th>
                                            <th>Mã lớp</th>                                                                             
                                        </tr>
                                    </thead>
                                    <tbody style="white-space:nowrap">
                                            <%=LaySinhVienTheoLop()%>
                                    </tbody>
                                </table>   
                                             
                            </div> <!-- /.panel-body -->
                        </div> <!-- /.panel -->.
                    </div> <!-- /.col-lg-12 -->     
                    <div class="modal fade" id="DeleteModal" role="dialog">
                <div class="modal-dialog">    
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Thông báo</h4>
                        </div>
                        <div class="modal-body">
                            <p>Bạn có chắc chắn xóa mẩu tin này không?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="Button3" class="btn btn-info" runat="server" Text="Có" OnClick="btnXoa_Click"/>
                            <asp:Button ID="Button4" class="btn btn-info" runat="server" Text="Không"/>                  
                        </div>
                    </div>      
                </div>
            </div>
                </form>
            </div>
            <!-- /.row -->
        </div>
        <!-- /#page-wrapper -->
    </div>
    <!-- /#wrapper -->   
<!-- jQuery -->    
    <script src="Content/vendor/jquery/jquery.min.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="Content/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!-- Metis Menu Plugin JavaScript -->
    <script src="Content/vendor/metisMenu/metisMenu.min.js"></script>
    <!-- Morris Charts JavaScript -->
    <script src="Content/vendor/raphael/raphael.min.js"></script>
    <script src="Content/vendor/morrisjs/morris.min.js"></script>
    <script src="Content/data/morris-data.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="Content/dist/js/sb-admin-2.js"></script>       
    <!-- DataTables JavaScript -->    
    <script src="Content/vendor/datatables/js/jquery.dataTables.min.js"></script>    
    <script src="Content/vendor/datatables-plugins/dataTables.bootstrap.min.js"></script>    
    <script src="Content/vendor/datatables-responsive/dataTables.responsive.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="Content/dist/js/sb-admin-2.js"></script>    
     <script>
    $(document).ready(function() {
        $('#dataTables-example').DataTable({
            responsive: true
        });
    });
    </script>
    
</body>

</html>
