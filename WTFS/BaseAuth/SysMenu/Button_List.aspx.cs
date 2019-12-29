using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Collections; 
using WTFS.Common.UIHelper;
using WTFS.DataBase.BaseHelper;
using WTFS.DataBase.SqlServer;
using WTFS.App_Code;

namespace WTFS.BaseAuth.SysMenu
{
    public partial class Button_List : PageBase
    {
        System_IDAO systemidao = new System_Dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitData()
        {
            DataTable dt = systemidao.GetButtonList();
            ControlBindHelper.BindRepeaterList(dt, rp_Item);
        }
    }
}