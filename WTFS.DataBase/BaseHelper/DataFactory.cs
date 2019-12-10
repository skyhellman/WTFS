using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using WTFS.DataBase.SqlServer;
using WTFS.Common.CodeHelper;

namespace WTFS.DataBase.BaseHelper
{
    //class DataFactory
    //{
    //}
    /// <summary>
    /// 连接数据库服务工厂
    /// </summary>
    public class DataFactory
    {
        /// <summary>
        /// 链接 SqlServer 数据库
        /// </summary>
        /// <returns></returns>
        public static IDbHelper SqlDataBase()
        {
            return new SqlServerHelper(ConfigHelper.GetAppSettings("SqlServer_RM_DB"));
        }
    }
}
