﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WTFS.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <title>首页</title>
    <link href="/App_Themes/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script src="/App_Themes/Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/Validator/JValidator.js" type="text/javascript"></script>
    <link href="/App_Themes/Scripts/ShowMsg/msgbox.css" rel="stylesheet" type="text/css"/>
    <script src="/App_Themes/Scripts/ShowMsg/msgbox.js" type="text/javascript"></script>
    <link href="/App_Themes/Scripts/artDialog/skins/blue.css" rel="stylesheet" type="text/css"/>
     <script src="/App_Themes/Scripts/artDialog/artDialog.source.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/artDialog/iframeTools.source.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/TreeTable/jquery.treeTable.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/FunctionJS.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/MainFrame.js" type="text/javascript"></script>
    <link href="/App_Themes/Styles/Menu.css" rel="stylesheet" type="text/css" />
    <link href="/App_Themes/Styles/myui.min.css" rel="stylesheet" type="text/css" />
</head>
<body class="hold-transition skin-blue sidebar-mini">
    <%--<form id="form1" runat="server">--%>
        <div class="wrapper">
            <!-- Main Header -->
            <header class="main-header">
                <!-- Logo -->
                <a href="#" class="logo">
                    <!-- mini logo for sidebar mini 50x50 pixels -->
                    <span class="logo-mini"><b></b></span>
                    <!-- logo for regular state and mobile devices -->
                    <span class="logo-lg"><b>WTFS</b></span>
                </a>
                <!-- Header Navbar -->
                <nav class="navbar navbar-static-top" role="navigation">
                    <!-- Sidebar toggle button-->
                    <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
                        <span class="sr-only">Toggle navigation</span>
                    </a>
                    <!-- Navbar Right Menu -->
                    <div class="navbar-custom-menu">
                        <ul class="nav navbar-nav">
                            <li class="dropdown notifications-menu">
                                <!-- Menu toggle button -->
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-bell-o"></i>
                                    提醒
                                            <span class="label label-warning">1</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li class="header">警示信息 </li>
                                    <li>
                                        <!-- Inner Menu: contains the notifications -->
                                        <ul class="menu">
                                            <li>
                                                <!-- start notification -->
                                                <a href="#">
                                                    <i class="fa fa-users text-aqua"></i>信息内容
                                                </a>
                                            </li>
                                            <!-- end notification -->
                                        </ul>
                                    </li>
                                    <li class="footer"><a href="#">查看</a></li>
                                </ul>
                            </li>
                            <!-- User Account Menu -->
                            <li class="user user-menu">
                                <!-- Menu Toggle Button -->
                                <a href="#">
                                    <!-- The user image in the navbar-->
                                    <img src="App_Themes/Images/sl.jpg" class="user-image" alt="User Image" />
                                    <!-- hidden-xs hides the username on small devices so only the image appears. -->
                                    <span class="hidden-xs"  ><%=ViewState["username"].ToString() %></span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </header>
            <!-- Left side column. contains the logo and sidebar -->
            <aside class="main-sidebar">
                <!-- sidebar: style can be found in sidebar.less -->
                <section class="sidebar">
                    <!-- Sidebar Menu -->
                    <ul class="sidebar-menu" data-widget="tree">
                          <%=strHtml %>
                        </ul>

                    <%--<ul class="sidebar-menu" data-widget="tree">
                        <li class="treeview menu-open active">
                            <a href="#">
                                <i class="fa fa-folder"></i><span>基础权限</span>
                                <span class="pull-right-container">
                                    <i class="fa fa-angle-left pull-right"></i>
                                </span>
                            </a>
                            <ul class="treeview-menu">
                                <li><a href="#" data-addtab="Default" data-target="#MasterTabs" data-title="个人简介" data-url="Default.aspx"><i class="fa fa-circle-o"></i>页面一 </a></li>
                                <li><a href="#" data-addtab="About" data-target="#MasterTabs" data-title="cesnk" data-url="About.aspx"><i class="fa fa-circle-o"></i>页面二 </a></li>
                            </ul>
                        </li>
                        <li class="treeview">
                            <a href="#">
                                <i class="fa fa-folder"></i><span>测算</span>
                                <span class="pull-right-container">
                                    <i class="fa fa-angle-left pull-right"></i>
                                </span>
                            </a>
                            <ul class="treeview-menu">
                                <li><a href="#" data-addtab="ContentTest" data-target="#MasterTabs" data-title="大的" data-url="ContentTest.aspx"><i class="fa fa-circle-o"></i>dd </a></li>
                                <li><a href="#" data-addtab="About" data-target="#MasterTabs" data-title="cesnk" data-url="About.aspx"><i class="fa fa-circle-o"></i>erf dsw </a></li>
                            </ul>
                        </li>
                    </ul>--%>
                    <!-- /.sidebar-menu -->

                    <div class="sidebar-footer hidden-small fadeInLeft animated" id="sidebar-footer-bar">
                        <a data-toggle="tooltip" data-placement="top" data-original-title="refresh" data-widget="tooltip-refresh">
                            <span class="fa fa-refresh" aria-hidden="true"></span>
                        </a>
                        <a id="fullscreen" data-toggle="tooltip" data-placement="top" title="" data-original-title="FullScreen" data-widget="tooltip-fullscreen">
                            <span class="fa fa-arrows-alt" aria-hidden="true"></span>
                        </a>
                        <a id="lockpage" data-toggle="tooltip" data-placement="top" title="" data-original-title="Lock" data-widget="tooltip-lock">
                            <span class="fa fa-eye-slash" aria-hidden="true"></span>
                        </a>
                        <a data-toggle="tooltip" data-placement="top" title="" href="Login.aspx" data-original-title="Logout">
                            <span class="fa fa-power-off" aria-hidden="true" ></span>
                        </a>
                    </div>
                </section>
                <!-- /.sidebar -->
            </aside>
            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                <!-- Main content -->
                <section class="content container-fluid" style="padding: 0px">
                    <ul class="nav nav-tabs menu-tabs" id="MasterTabs" role="tablist">
                        <li class="nav-tabs-header active" role="presentation" >
                            <a aria-controls="home" data-toggle="tab" href="#home" role="tab">
                                <i class="fa fa-home"></i>Home
                            </a>
                        </li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content fixheight">
                        <div class="tab-pane active" id="home" role="tabpanel">
                             <iframe id="main" name="main" style="width:100%;height:100%; border:0; "  src="Contact.aspx"></iframe>

                        </div>
                    </div>
                </section>
                <!-- /.content -->
            </div>
            <!-- /.content-wrapper -->
            <!-- Main Footer -->
            <footer class="main-footer">
                <!-- To the right -->
                <div class="pull-right hidden-xs">
                    <b>Version</b> 1.0.0.1
                </div>
                <!-- Default to the left -->
                <strong>Copyright © 2019 .</strong> All rights reserved.
            </footer>
            <!--Small Chat-->
            <div class="box small-chat-box direct-chat direct-chat-primary  fadeInRight animated" data-widget="chat-small-box">
                <div class="box-header with-border">
                    <h3 class="box-title" id="chatTitle">DIS</h3>
                    <div class="box-tools pull-right">
                        <button type="button" id="btn_showContacts" class="btn btn-box-tool" data-toggle="tooltip" title="" data-widget="chat-pane-toggle" data-original-title="Contacts">
                            <i class="fa fa-comments"></i>
                        </button>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class="box-body" id="chatBody">
                    <!-- Conversations are loaded here -->
                    <div class="direct-chat-messages" id="listmsg">
                        <div class="direct-chat-msg">
                            <div class="direct-chat-info clearfix">
                                <span class="direct-chat-name pull-left">索隆</span>
                                <span class="direct-chat-timestamp pull-right">18/02/05 6:00am</span>
                            </div>
                            <!-- /.direct-chat-info -->
                            <img class="direct-chat-img" src="App_Themes/Images/sl.jpg" alt="Message User Image" /><!-- /.direct-chat-img -->
                            <div class="direct-chat-text">
                                早上好
                            </div>
                            <!-- /.direct-chat-text -->
                        </div>
                        <!-- /.direct-chat-msg -->
                        <!-- Message to the right -->
                        <div class="direct-chat-msg right">
                            <div class="direct-chat-info clearfix">
                                <span class="direct-chat-name pull-right">娜美</span>
                                <span class="direct-chat-timestamp pull-left">18/02/05 7:00am</span>
                            </div>
                            <!-- /.direct-chat-info -->
                            <img class="direct-chat-img" src="App_Themes/Images/nm.jpg" alt="Message User Image" /><!-- /.direct-chat-img -->
                            <div class="direct-chat-text">
                                早上好!
                            </div>
                            <!-- /.direct-chat-text -->
                        </div>
                    </div>
                    <!--/.direct-chat-messages-->
                    <!-- Contacts are loaded here -->
                    <div class="direct-chat-contacts">
                        <ul class="contacts-list">
                            <li>
                                <a href="javascript:;" data-widget="chat-pane-toggle">
                                    <img src="App_Themes/Images/nm.jpg" class="contacts-list-img" />
                                    <div class="contacts-list-info">
                                        <span class="contacts-list-name">Polo
                                                    <small class="contacts-list-date pull-right"><i class="fa fa-circle text-danger"></i>离线</small>
                                        </span>
                                        <span class="contacts-list-msg">娜美@gmail.com</span>
                                    </div>
                                    <!-- /.contacts-list-info -->
                                </a>
                            </li>
                        </ul>
                        <!-- /.contatcts-list -->
                    </div>
                    <!-- /.direct-chat-pane -->
                </div>
                <!-- /.box-body -->
                <div class="box-footer">
                    <form action="#" method="post">
                        <div class="input-group">
                            <input type="text" id="message" name="message" placeholder="输入信息 ..." class="form-control" />
                            <span class="input-group-btn">
                                <button type="button" id="sendmessage" class="btn btn-primary btn-flat">发送</button>
                            </span>
                        </div>
                    </form>
                </div>
                <!-- /.box-footer-->
            </div>
            <div class="chat-area">
                <span class="badge badge-warning pull-right msgCount">2</span>
                <a class="open-small-chat" data-widget="chat-small-open">
                    <i class="fa fa-comments"></i>
                </a>
            </div>
            <!-- /. Chat-Area-->
        </div> 
        <!-- ./wrapper -->
        <div id="modal" class="hold-transition lockscreen" style="display: none">
            <div class="lockscreen-wrapper">
                <div class="lockscreen-logo">
                    <a href="#"><b>WDIS</b></a>
                </div>
                <div class="lockscreen-name">索隆</div>
                <div class="lockscreen-item">
                    <div class="lockscreen-image">
                        <img src="App_Themes/Images/sl.jpg" />
                    </div>
                    <form class="lockscreen-credentials">
                        <div class="input-group">
                            <input id="tbx_lock_password" type="password" class="form-control" placeholder="password" value=""/>

                            <div class="input-group-btn">
                                <button type="button" class="btn" data-widget="tooltip-unlock" data-placement="top" title=""><i class="fa fa-arrow-right text-muted"></i></button>
                            </div>
                        </div>
                    </form>
                </div>
                <div class="help-block text-center">
                    输入密码解除锁定
                </div>
                <div class="lockscreen-footer text-center">
                    Copyright © 2019
                            All rights reserved
                </div>
            </div>
        </div>
        <!-- ./ 锁定屏幕 -->
        <script src="App_Themes/Scripts/jquery-3.4.1.min.js"></script>
        <script src="App_Themes/Scripts/myui.min.js"></script> 
    <%--</form>--%>
</body>
</html>
