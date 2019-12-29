﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Web; 
using System.Web.UI;
using System.Collections;
using WTFS.Common.CodeHelper;
using WTFS.Common.UIHelper;
using WTFS.Common.WebHelper;
using WTFS.DataBase.BaseHelper;
using WTFS.DataBase.SqlServer;

namespace WTFS.App_Code
{
    //public class PageBase
    //{
    //}
    /// <summary>
    /// 基类
    /// </summary>
    public class PageBase : System.Web.UI.Page
    {
        System_IDAO sys_idao = new System_Dal();
        protected override void OnLoad(EventArgs e)
        {
            #region 当Session过期自动跳出登录画面
            if (RequestSession.GetSessionUser() == null)
            {
                Session.Abandon();  //取消当前会话
                Session.Clear();
                Response.Redirect("/Login.aspx");
            }
            #endregion

            #region 防止刷新重复提交
            if (null == Session["Token"])
            {
                WebHelper.SetToken();
            }
            #endregion

            #region URL权限验证,拒绝，不合法的请求
            URLPermission();
            #endregion

            base.OnLoad(e);
        }
        #region URL权限验证,拒绝，不合法的请求
        /// <summary>
        /// URL权限验证,拒绝，不合法的请求
        /// </summary>
        public void URLPermission()
        {
            bool IsOK = false;
            //获取当前访问页面地址
            string requestPath = RequestHelper.GetScriptName+".aspx";
            string[] filterUrl = { "/Contact.aspx", "/BaseAuth/SysUser/UpdateUserPwd.aspx" };//过滤特别页面
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < filterUrl.Length; i++)
            {
                if (requestPath == filterUrl[i])
                {
                    IsOK = true;
                    break;
                }
            }
            if (!IsOK)
            {
                string UserId = RequestSession.GetSessionUser().UserId.ToString();//用户ID
                DataTable dt = sys_idao.GetPermission_URL(UserId);
                DataView dv = new DataView(dt);
                dv.RowFilter = "NavigateUrl = '" + requestPath + "'";
                if (dv.Count == 0)
                {
                    StringBuilder strHTML = new StringBuilder();
                    strHTML.Append("<div style='text-align: center; line-height: 300px;'>");
                    strHTML.Append("<font style=\"font-size: 13;font-weight: bold; color: red;\">权限不足</font></div>");
                    HttpContext.Current.Response.Write(strHTML.ToString());
                    HttpContext.Current.Response.End();
                }
            }

        }
        #endregion
    }
}