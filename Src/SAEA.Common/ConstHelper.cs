﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.MVC.Mvc
*文件名： AreaCollection
*版本号： V3.6.2.2
*唯一标识：eb956356-8ea4-4657-aec1-458a3654c078
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/8/2 18:10:16
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/8/2 18:10:16
*修改人： yswenli
*版本号： V3.6.2.2
*描述：
*
*****************************************************************************/

using System;
using System.Linq;

namespace SAEA.Common
{
    public class ConstHelper
    {
        public const string CONTROLLERNAME = "controller";

        public const string CONTROLLERSPACE = "Controllers";

        public const string HTTPGET = "HttpGet";

        public const string HTTPPOST = "HttpPost";

        public const string GET = "GET";

        public const string POST = "POST";

        public const string OPTIONS = "OPTIONS";

        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        public const string FORMENCTYPE1 = "application/x-www-form-urlencoded";

        /// <summary>
        /// multipart/form-data
        /// </summary>
        public const string FORMENCTYPE2 = "multipart/form-data";

        /// <summary>
        /// application/json
        /// </summary>
        public const string FORMENCTYPE3 = "application/json";

        public const string ONACTIONEXECUTING = "OnActionExecuting";

        public const string ONACTIONEXECUTED = "OnActionExecuted";

        public const string SERVERMVCSERVER = "83,101,114,118,101,114,58,32,83,65,69,65,46,72,116,116,112,46,83,101,114,118,101,114,32,51,46,48";

        public const string CT = "Content-Type";

        public const string BOUNDARY = " boundary=";

        public const string ID = "id";

        /// <summary>
        /// ActionFilterAttribute
        /// </summary>
        public const string ACTIONFILTERATTRIBUTE = "ActionFilterAttribute";

        public const string ENTER = "\r\n";

        public const string DENTER = "\r\n\r\n";

        public const string SPACE = " ";

        public const string JSONCONTENTTYPE = "application/json; charset=utf-8";

        public const string ASTERRISK = "*";

        public const string MINUSSIGN = "-";

        public const string DOLLAR = "$";

        public const string COLON = ":";

        public const string COMMA = ",";

        public const string SLASH = "/";

        public const string LESS_THAN = "<";

        public const string GREATER_THAN = ">";

        public const string AMPERSAND = "&";

        public const string EQUO = "=";

        public const string SEMICOLON = ";";

        public const string QUESTIONMARK = "?";


        static string _serverName = string.Empty;

        public static string ServerName
        {
            get
            {
                if (string.IsNullOrEmpty(_serverName))
                {
                    _serverName = System.Text.Encoding.UTF8.GetString(SERVERMVCSERVER.Split(",").Select(b => Convert.ToByte(b)).ToArray());
                }
                return _serverName;
            }
        }

        public const string SESSIONID = "SAEA.Http.Server.SessionID";


        public const string OUTPUTCACHEATTRIBUTE = "SAEA.MVC.OutputCacheAttribute";

    }
}
