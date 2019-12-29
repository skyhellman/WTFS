﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using WTFS.Common.WebHelper;
using WTFS.Common.CodeHelper;
using WTFS.Common.EncryptHelper;
using WTFS.Common.UIHelper;
using WTFS.Common.DataHelper;
using WTFS.DataBase.BaseHelper;

namespace WTFS.UserControl
{
    public partial class LoadButton : System.Web.UI.UserControl
    {
        public StringBuilder sb_Button = new StringBuilder();
        System_IDAO systemidao = new System_Dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            string UserId = RequestSession.GetSessionUser().UserId.ToString();//用户ID
            DataTable dt_Button = systemidao.GetButtonHtml(UserId);
            if (DataTableHelper.IsExistRows(dt_Button))
            {
                foreach (DataRow dr in dt_Button.Rows)
                {
                    sb_Button.Append("<a title=\"" + dr["Menu_Title"].ToString() + "\" onclick=\"" + dr["NavigateUrl"].ToString() + ";\" class=\"button green\">");
                    sb_Button.Append("<span class=\"icon-botton\" style=\"background: url('/App_Themes/images/16/" + dr["Menu_Img"].ToString() + "') no-repeat scroll 0px 4px;\"></span>");
                    sb_Button.Append(dr["Menu_Name"].ToString());
                    sb_Button.Append("</a>");
                }
            }
            else
            {
                sb_Button.Append("<a class=\"button green\">");
                sb_Button.Append("无操作按钮");
                sb_Button.Append("</a>");
            }
        }
    }
}