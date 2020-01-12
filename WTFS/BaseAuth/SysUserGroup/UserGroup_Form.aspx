<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroup_Form.aspx.cs" Inherits="WTFS.BaseAuth.SysUserGroup.UserGroup_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>用户组信息表单</title>
    <link href="/App_Themes/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script src="/App_Themes/Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/Validator/JValidator.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/artDialog/artDialog.source.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/artDialog/iframeTools.source.js" type="text/javascript"></script>
    <script src="/App_Themes/Scripts/FunctionJS.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
       <table border="0" cellpadding="0" cellspacing="0" class="frm">
        <tr>
            <th>
                用户组名称：
            </th>
            <td>
                <input id="UserGroup_Name" runat="server" type="text" class="txt" datacol="yes" err="用户组名称"
                    checkexpession="NotNull" style="width: 85%" />
            </td>
        </tr>
        <tr>
            <th>
                用户组编号：
            </th>
            <td>
                <input id="UserGroup_Code" runat="server" type="text" class="txt" datacol="yes" err="用户组编号"
                    checkexpession="NotNull" style="width: 85%" />
            </td>
        </tr>
        <tr>
            <th>
                节点位置：
            </th>
            <td>
                <select id="ParentId" class="select" runat="server" style="width: 87%">
                </select>
            </td>
        </tr>
        <tr>
            <th>
                显示顺序：
            </th>
            <td>
                <input id="SortCode" runat="server" type="text" class="txt" datacol="yes" err="显示顺序"
                    checkexpession="Num" style="width: 85%" />
            </td>
        </tr>
        <tr>
            <th>
                描述信息：
            </th>
            <td>
                <textarea id="UserGroup_Remark" class="txtRemark" runat="server" style="width: 85.5%;
                    height: 80px;"></textarea>
            </td>
        </tr>
    </table>
    <div class="frmbottom">
        <asp:LinkButton ID="Save" runat="server" class="l-btn" OnClientClick="return CheckDataValid('#form1');"
            OnClick="Save_Click"><span class="l-btn-left">
            <img src="/App_Themes/Images/disk.png" alt="" />保 存</span></asp:LinkButton>
        <a id="Close" class="l-btn" href="javascript:void(0)" onclick="OpenClose();"><span
            class="l-btn-left">
            <img src="/App_Themes/Images/cancel.png" alt="" />关 闭</span></a>
    </div>
    </form>
</body>
</html>
