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
    public partial class DataCenter_Conten : PageBase
    {
        System_IDAO systemidao = new System_Dal();
        public string _Table_Name;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Table_Name = Server.UrlDecode(Request["Table_Name"]);//表名
            if (!IsPostBack)
            {
                if (_Table_Name == null)
                {
                    _Table_Name = "未选择";
                }
                GridBind();
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void GridBind()
        {
            DataTable dt = systemidao.GetSyscolumns(_Table_Name);
            ControlBindHelper.BindRepeaterList(dt, rp_Item);
        }
    }
}