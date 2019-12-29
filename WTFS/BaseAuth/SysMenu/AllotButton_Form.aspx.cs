using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WTFS.DataBase.BaseHelper;
using WTFS.DataBase.SqlServer;
using WTFS.Common.WebHelper;
using WTFS.Common.UIHelper;
using WTFS.App_Code;

namespace WTFS.BaseAuth.SysMenu
{
    public partial class AllotButton_Form : PageBase
    {
        System_IDAO systemidao = new System_Dal();
        public StringBuilder ButtonList = new StringBuilder();
        public StringBuilder selectedButtonList = new StringBuilder();
        public string _ParentId;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}