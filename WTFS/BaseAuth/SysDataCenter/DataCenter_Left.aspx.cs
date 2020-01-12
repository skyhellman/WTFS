using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.Data;
using WTFS.Common.WebHelper;
using WTFS.Common.CodeHelper;
using WTFS.Common.EncryptHelper;
using WTFS.Common.UIHelper;
using WTFS.Common.DataHelper;
using WTFS.DataBase.BaseHelper;
using WTFS.App_Code;

namespace WTFS.BaseAuth.SysDataCenter
{
    public partial class DataCenter_Left : PageBase
    {
        public StringBuilder treeItem_Table = new StringBuilder();
        System_IDAO systemidao = new System_Dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetTreeTable();
            }
        }
        // <summary>
        /// 所以数据库列表
        /// </summary>
        public void GetTreeTable()
        {
            DataTable dt = systemidao.GetSysobjects();
            foreach (DataRow drv in dt.Rows)
            {
                treeItem_Table.Append("<li>");
                treeItem_Table.Append("<div onclick=\"GetTable('" + drv["TABLE_NAME"] + "')\"><img src=\"/App_Themes/Images/20130502112716785_easyicon_net_16.png\" width=\"16\" height=\"16\" />" + drv["TABLE_NAME"] + "</div>");
                treeItem_Table.Append("</li>");
            }
        }
    }
}