﻿using FancyFix.Core.Admin;
using FancyFix.OA;
using FancyFix.OA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FancyFix.ThirdPartyPlatform.Base
{
    public abstract class BaseWebViewPage<TMmodel> : System.Web.Mvc.WebViewPage<TMmodel>
    {
        public static string cssVersion = DateTime.Now.ToString("yyMMddhhss"); //样式版本
        public static string domain = Tools.Special.Common.GetDomain();
        public static string webUrl = Tools.Special.Common.GetWebUrl();


        #region Request方法
        /// <summary>
        /// Request一个数字
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RequestInt(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return 0;
            }
            else
            {
                return v.ToInt32();
            }
        }
        /// <summary>
        /// Request一个Byte
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public byte RequestByte(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return 0;
            }
            else
            {
                return v.ToByte();
            }
        }

        /// <summary>
        /// Request一个Decimal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public decimal RequestDecimal(string name)
        {
            string v = RequestString(name);
            decimal result = 0;
            if (decimal.TryParse(v, out result))
            {
                return result;
            }
            return 0;
        }
        /// <summary>
        /// Request一个布尔值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool RequestBool(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return false;
            }
            else
            {
                try
                {
                    return bool.Parse(v);
                }
                catch
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 请求一个字符串，返回null时返回空字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string RequestString(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                v = string.Empty;
            }
            return v.Trim();
        }

        /// <summary>
        /// Request一个Double
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public double RequestDouble(string name)
        {
            string v = RequestString(name);
            double result = 0;
            if (double.TryParse(v, out result))
            {
                return result;
            }
            return 0;
        }

        /// <summary>
        /// 请求字符串类型
        /// </summary>
        /// <param name="requestStr">请求的Request值</param>
        /// <returns>返回字符串，null则返回""</returns>
        public static string ConvertString(string requestStr)
        {
            return requestStr.ToString2();
        }

        /// <summary>
        ///   数字类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public static int ConvertInt(string requestStr)
        {
            return requestStr.ToInt32();
        }

        /// <summary>
        ///   浮点类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public static float ConvertFloat(string requestStr)
        {
            return requestStr.ToFloat();
        }

        /// <summary>
        ///   双精度类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public static decimal ConvertDecimal(string requestStr)
        {
            return requestStr.ToDecimal();
        }

        public static Int32 ConvertObjectToInt(object requestStr)
        {
            try
            {
                return Convert.ToInt32(requestStr);
            }
            catch
            {
                return 0;
            }
        }

        public static string ConvertObjectToStr(object requestStr)
        {
            try
            {
                return Convert.ToString(requestStr);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 转换成布尔型
        /// </summary>
        /// <param name="requestStr"></param>
        /// <returns></returns>
        public static bool ConvertBoolean(string requestStr)
        {
            try
            {
                if (string.IsNullOrEmpty(requestStr))
                {
                    return false;
                }

                requestStr = requestStr.ToLower();
                if (requestStr == "1" || requestStr == "true")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 页面方法转换

        /// <summary>
        /// 格式化成Url
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string GetFormatUrl(string title)
        {
            return Tools.Usual.Utils.ConverUrl(title).ToLower();
        }

        /// <summary>
        /// 去除Html标签
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveHtml(string str)
        {
            return Tools.Common.StringProcess.RemoveHtml(str);
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string CutString(string str, int length)
        {
            return Tools.Common.StringProcess.CutString(str, length);
        }
        /// <summary>
        /// 判断文件后缀是否是图片
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsImg(string fileName)
        {
            return Tools.Usual.Utils.IsImg(fileName);
        }

        /// <summary>
        /// 获取文件后缀
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetFileExt(string fileName)
        {
            return Tools.Usual.Utils.GetFileExt(fileName);
        }

        /// <summary>
        /// 格式化产品参数
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public static string FormatOrderAttrDetail(string detail)
        {
            return detail.Replace(";", "\r\n");
        }

        /// <summary>
        /// Email格式化
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string FormatEmail(string email)
        {
            string[] t = email.Split('@');
            string result = string.Empty;
            result = t[0].Substring(0, 2) + "****@***.com";
            return result;
        }

        /// <summary>
        /// 文本Texteara显示
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ShowTextarea(string str)
        {
            return Tools.Usual.Utils.ToTexteara(str);
        }

        /// <summary>
        /// 根据条件筛选列表
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected static DataTable GetSelect(DataTable dt, string where)
        {
            return Tools.Usual.Utils.GetSelect(dt, where);
        }

        /// <summary>
        /// 获取唯一数据的字段
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="PrimaryKeyColumns"></param>
        /// <returns></returns>
        protected static DataTable GetDistinctPrimaryKeyColumnTable(DataTable dt, string[] PrimaryKeyColumns)
        {
            return Tools.Usual.Utils.GetDistinctPrimaryKeyColumnTable(dt, PrimaryKeyColumns);
        }

        /// <summary>
        /// 去除html内容里的图片高宽样式
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public static string RemoveImageStyle(string detail)
        {
            Regex regWidth = new Regex("(<img[^>]*?)\\s+width\\s*=\\s*\\S+", RegexOptions.IgnoreCase);
            Regex regHeight = new Regex("(<img[^>]*?)\\s+height\\s*=\\s*\\S+", RegexOptions.IgnoreCase);
            Regex regStyle = new Regex("(<img[^>]*?)\\s+style\\s*=\\s*\\S+", RegexOptions.IgnoreCase);

            return regWidth.Replace(regHeight.Replace(regStyle.Replace(detail, "$1"), "$1"), "$1");
        }

        /// <summary>
        /// 获取html中所有图片的路径
        /// </summary>
        /// <param name="htmlText"></param>
        /// <returns></returns>
        public static string[] GetImageUrlListFromHtml(string htmlText)
        {
            return Tools.Usual.Utils.GetImageUrlListFromHtml(htmlText);
        }

        /// <summary>
        /// 获取html中所有a标签的链接地址
        /// </summary>
        /// <param name="htmlText"></param>
        /// <returns></returns>
        public static string[] GetLinkUrlListFromHtml(string htmlText)
        {
            return Tools.Usual.Utils.GetLinkUrlListFromHtml(htmlText);
        }
        #endregion
    }
}
