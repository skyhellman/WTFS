﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Xml;
using System.IO;
using System.Configuration;

namespace WTFS.Common.CodeHelper
{
    //class ConfigHelper
    //{
    //}
    /// <summary>
    ///  Config 公共帮助类
    /// </summary>
    public class ConfigHelper
    {
        /// <summary>
        /// 获得配置文件appSettings子节点值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static string GetAppSettings(string key)
        {
            //return ConfigurationManager.AppSettings[key].ToString().Trim();
            return WebConfigurationManager.ConnectionStrings["RMconnectionStrings"].ToString(); 
        }
        /// <summary>
        /// 修改配置文件
        /// </summary>
        /// <param name="xmlDocument"></param>
        /// <param name="selectPath"></param>
        /// <param name="key"></param>
        /// <param name="keyValue"></param>
        public static void SetValue(XmlDocument xmlDocument, string selectPath, string key, string keyValue)
        {
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes(selectPath);
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                if (xmlNode.Attributes["key"].Value.ToUpper().Equals(key.ToUpper()))
                {
                    xmlNode.Attributes["value"].Value = keyValue;
                    break;
                }
            }
        }
    }
}
