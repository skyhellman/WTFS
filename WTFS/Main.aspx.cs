using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using WTFS.Common.DataHelper;
using WTFS.Common.WebHelper;
using WTFS.DataBase.BaseHelper;
using WTFS.DataBase.SqlServer;

namespace WTFS
{
    public partial class Main : System.Web.UI.Page
    {

        public StringBuilder strHtml = new StringBuilder();
        public StringBuilder sbHomeShortcouHtml = new StringBuilder();
        public StringBuilder Login_InfoHtml = new StringBuilder();
        public string _UserName; 
        System_IDAO systemidao = new System_Dal();
        UserInfo_IDAO user_idao = new UserInfo_Dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               // string UserId = RequestSession.GetSessionUser().UserId.ToString();//用户ID
               // string UserName= RequestSession.GetSessionUser().UserName.ToString();//用户Name
                ViewState["userid"] = "48f3889c-af8d-401f-ada2-c383031af92d";// UserId;
                ViewState["username"] = "管理员";// UserName;

                InitInfo();
            }
            
        }
        public void InitInfo()
        { 
            DataTable dt = systemidao.GetMenuHtml(ViewState["userid"].ToString());
            if (DataTableHelper.IsExistRows(dt))
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "ParentId = '0'";
                int i = 0;
                foreach (DataRowView drv in dv)
                {
                    if(i==0)
                    {
                        strHtml.Append("<li class=\"treeview menu-open active \">");
                    }
                    else
                    {
                        strHtml.Append("<li class=\"treeview \">");
                    }
                    strHtml.Append(" &nbsp;&nbsp;<a href=\"#\"><span style=\"color:white;font-size:larger; \"><i class=\"fa fa-folder \">&nbsp;&nbsp;&nbsp;" + drv["Menu_Name"] + "</i></span>"
                        + "<span class=\"pull-right-container\" style=\"color:white;font-size:larger;\"><i class=\"fa fa-angle-left pull-right\"></i>&nbsp;&nbsp;&nbsp;</span></a>");
                    // strHtml.Append("<div>" + drv["Menu_Name"] + "</div>");
                    //创建子节点
                    strHtml.Append(GetTreeNode(drv["Menu_Id"].ToString(), dt));
                    strHtml.Append("</li>");
                }
            }
            //Response.Write(strHtml.ToString());
            }
        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="parentID">父节点主键</param>
        /// <param name="dtMenu"></param>
        /// <returns></returns>
        public string GetTreeNode(string parentID, DataTable dtNode)
        {
            StringBuilder sb_TreeNode = new StringBuilder();
            DataView dv = new DataView(dtNode);
            dv.RowFilter = "ParentId = '" + parentID + "'";
            if (dv.Count > 0)
            {
                sb_TreeNode.Append("<ul  class=\"treeview-menu\">");
                foreach (DataRowView drv in dv)
                {
                    

                    sb_TreeNode.Append("<li>");//<li style=\"display:inline;height:10px;\">
                    DataTable IsJudge = DataTableHelper.GetNewDataTable(dtNode, "ParentId = '" + drv["Menu_Id"].ToString() + "'");//判断是否有下级菜单
                    if (DataTableHelper.IsExistRows(IsJudge))
                    {
                        sb_TreeNode.Append("<div><img src=\"/App_Themes/Images/32/" + drv["Menu_Img"] + "\" width=\"16\" height=\"16\" /><span style=\"color:white; \">" + drv["Menu_Name"] + "</span></div>");
                    }
                    else
                    {
                        string tabname = "";
                        string urlstr = "";
                        urlstr = drv["NavigateUrl"].ToString();
                        if (urlstr.Length > 0)
                        {
                            tabname = urlstr.Substring(urlstr.LastIndexOf("/") + 1, urlstr.Length - urlstr.LastIndexOf("/") - 6);
                            sb_TreeNode.Append(" <a href=\"#\" data-addtab=\"" + tabname + "\" data-target=\"#MasterTabs\" data-title=" + drv["Menu_Title"]
                                + " data-url=" + drv["NavigateUrl"] + "><img src=\"/App_Themes/Images/32/" + drv["Menu_Img"] + "\" width=\"16\" height=\"16\" />"
                                + "&nbsp;&nbsp;" + drv["Menu_Name"] + "</a> ");
                        }                      //<i class=\"fa fa-circle-o\"></i></li> 
                        //sb_TreeNode.Append("<div title=\"" + drv["Menu_Title"] + "\" onclick=\"NavMenu('" + drv["NavigateUrl"] + "','" 
                        //+ drv["Menu_Name"] + "')\"><img src=\"/App_Themes/Images/32/" + drv["Menu_Img"] + "\" width=\"16\" height=\"16\" />" + drv["Menu_Name"] + "</div>");
                    }
                    //创建子节点
                    sb_TreeNode.Append(GetTreeNode(drv["Menu_Id"].ToString(), dtNode));
                    sb_TreeNode.Append("</li>");
                }
                sb_TreeNode.Append("</ul>");
            }
            return sb_TreeNode.ToString();
        }
        /// <summary>
        /// 加载快捷功能
        /// </summary>
        private void InitShortcouData()
        {
            DataTable dt = systemidao.GetHomeShortcut_List(RequestSession.GetSessionUser().UserId.ToString());
            if (DataTableHelper.IsExistRows(dt))
            {
                int rowSum = dt.Rows.Count;
                if (rowSum > 0)
                {
                    for (int i = 0; i < rowSum; i++)
                    {
                        sbHomeShortcouHtml.Append("<div onclick=\"ClickShortcut('" + dt.Rows[i]["NavigateUrl"] + "','" + dt.Rows[i]["Setup_IName"] + "','" + dt.Rows[i]["Target"] + "')\" class=\"shortcuticons\">");
                        sbHomeShortcouHtml.Append("<img src=\"/Themes/Images/32/" + dt.Rows[i]["Setup_Img"] + "\" alt=\"\" /><br />");
                        sbHomeShortcouHtml.Append(dt.Rows[i]["Setup_IName"] + "</div>");
                    }
                }
            }
        }
        public void BindLogin_Info()
        {
            int count = 0;
            DataTable dt = user_idao.GetLogin_Info(ref count);
            Login_InfoHtml.Append("本月登录总数：" + count + " 次 <br />");
            Login_InfoHtml.Append("本次登录IP：" + dt.Rows[0]["SYS_LOGINLOG_IP"].ToString() + "<br />");
            Login_InfoHtml.Append("本次登录时间：" + dt.Rows[0]["SYS_LOGINLOG_TIME"].ToString() + "<br />");
            if (dt.Rows.Count != 1)
            {
                Login_InfoHtml.Append("上次登录IP：" + dt.Rows[1]["SYS_LOGINLOG_IP"].ToString() + "<br />");
                Login_InfoHtml.Append("上次登录时间：" + dt.Rows[1]["SYS_LOGINLOG_TIME"].ToString() + "<br />");
            }
            else
            {
                Login_InfoHtml.Append("上次登录IP：127.0.0.1 <br />");
                Login_InfoHtml.Append("上次登录时间：1900-01-01 00:00:00<br />");
            }
        }

    }
}