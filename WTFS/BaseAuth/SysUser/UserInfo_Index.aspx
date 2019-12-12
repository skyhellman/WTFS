﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo_Index.aspx.cs" Inherits="WTFS.BaseAuth.SysUser.UserInfo_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>用户信息</title>
    <link href="/App_Themes/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script src="/App_Themes/Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/FunctionJS.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("html").css("overflow", "hidden");
            $("body").css("overflow", "hidden");
            iframeresize();
            Loading(true);
            $("#target_right").attr("src", "UserInfo_List.aspx");
            $("#target_left").attr("src", "UserInfo_Left.aspx");
        })
        /**自应高度**/
        function iframeresize() {
            resizeU();
            $(window).resize(resizeU);
            function resizeU() {
                var iframeMain = $(window).height();
                $("#iframeMainContent").height(iframeMain);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
      <div id="iframeMainContent">
        <div class="iframeleft">
            <iframe id="target_left" name="target_left" scrolling="auto" frameborder="0" scrolling="yes"
                width="100%" height="100%"></iframe>
        </div>
        <div class="iframeContent">
            <iframe id="target_right" name="target_right" scrolling="auto" frameborder="0" scrolling="yes"
                width="100%" height="100%"></iframe>
        </div>
    </div>
    </form>
</body>
</html>
