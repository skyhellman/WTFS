﻿using System;
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

namespace WTFS.BaseAuth.SysUserGroup
{
    public partial class UserGroup_Form : System.Web.UI.Page
    {
        UserInfo_IDAO user_idao = new UserInfo_Dal();
        string _key, _ParentId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _key = Request["key"];                  //主键
            _ParentId = Request["ParentId"];        //父节点
            if (!IsPostBack)
            {
                InitParentId();
                if (!string.IsNullOrEmpty(_ParentId))
                {
                    ParentId.Value = _ParentId;
                }
                if (!string.IsNullOrEmpty(_key))
                {
                    InitData();
                }
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitData()
        {
            Hashtable ht = DataFactory.SqlDataBase().GetHashtableById("Base_UserGroup", "UserGroup_ID", _key);
            if (ht.Count > 0 && ht != null)
            {
                ControlBindHelper.SetWebControls(this.Page, ht);
            }
        }
        /// <summary>
        /// 节点位置下拉框绑定
        /// </summary>
        /// <param name="projectid"></param>
        /// <returns></returns>
        private void InitParentId()
        {
            DataTable dt = user_idao.InitUserGroupParentId();
            if (!string.IsNullOrEmpty(_key))
            {
                if (DataTableHelper.IsExistRows(dt))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserGroup_ID"].ToString() == _key)
                            dt.Rows.RemoveAt(i);
                    }
                }
            }
            ControlBindHelper.BindHtmlSelect(dt, ParentId, "UserGroup_Name", "UserGroup_ID", "用户组信息 - 父节");
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Save_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht = ControlBindHelper.GetWebControls(this.Page);
            if (string.IsNullOrEmpty(ParentId.Value))
            {
                ht["ParentId"] = "0";
            }
            if (!string.IsNullOrEmpty(_key))
            {
                ht["ModifyDate"] = DateTime.Now;
                ht["ModifyUserId"] = RequestSession.GetSessionUser().UserId;
                ht["ModifyUserName"] = RequestSession.GetSessionUser().UserName;
            }
            else
            {
                ht["UserGroup_ID"] = CommonHelper.GetGuid;
                ht["CreateUserId"] = RequestSession.GetSessionUser().UserId;
                ht["CreateUserName"] = RequestSession.GetSessionUser().UserName;
            }
            bool IsOk = DataFactory.SqlDataBase().Submit_AddOrEdit("Base_UserGroup", "UserGroup_ID", _key, ht);
            if (IsOk)
            {
                ShowMsgHelper.AlertMsg("操作成功！");
            }
            else
            {
                ShowMsgHelper.Alert_Error("操作失败！");
            }
        }
    }
}