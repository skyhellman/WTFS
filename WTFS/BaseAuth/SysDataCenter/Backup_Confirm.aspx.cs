using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WTFS.Common.WebHelper;
using WTFS.Common.CodeHelper;
using WTFS.Common.EncryptHelper;
using WTFS.Common.UIHelper;
using WTFS.Common.DataHelper;
using WTFS.DataBase.BaseHelper;
using WTFS.App_Code;

namespace WTFS.BaseAuth.SysDataCenter
{
    public partial class Backup_Confirm : System.Web.UI.Page
    {
        public string _UserPwd;
        protected void Page_Load(object sender, EventArgs e)
        {
            _UserPwd = RequestSession.GetSessionUser().UserPwd.ToString();
        }
    }
}