using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.SessionState;
using WTFS.DataBase.BaseHelper; 

namespace WTFS.BaseAuth.SysMenu
{
    /// <summary>
    /// Menu_List 的摘要说明
    /// </summary>
    public class Menu_List : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            context.Response.Buffer = true;
            context.Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
            context.Response.AddHeader("pragma", "no-cache");
            context.Response.AddHeader("cache-control", "");
            context.Response.CacheControl = "no-cache";
            string Action = context.Request["action"].Trim();               //提交动作
            string ParentId = context.Request["ParentId"];
            string key = context.Request["key"];//主键
            System_IDAO systemidao = new System_Dal();
            switch (Action)
            {
                case "addButton"://菜单添加按钮
                    context.Response.Write(systemidao.AllotButton(key, ParentId));
                    context.Response.End();
                    break;
                default:
                    break;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}