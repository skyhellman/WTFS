using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WTFS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // string UserId = RequestSession.GetSessionUser().UserId.ToString();//用户ID
                // string UserName= RequestSession.GetSessionUser().UserName.ToString();//用户Name
                ViewState["userid"] = "48f3889c-af8d-401f-ada2-c383031af92d";// UserId;
                ViewState["username"] = "管理员";// UserName;
 
            }
        }
    }
}