using Dragon.Core;
using Dragon.Model.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Dragon.Web.Core
{
    public class StataHelper
    {
        /// <summary>
        /// 获取API调用路径
        /// </summary>
        /// <returns></returns>
        public static string GetAPIPath()
        {
            return ConfigurationManager.AppSettings["WebAPI"];
        }

        /// <summary>
        /// Post API请求接口加密
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static RequestView PostRequestEncrypt(RequestView model)
        {
            string token = "3B3C48F227981712390E4D016D340676513E407555AB45A82135FB6B89236CF3";
            #region 加密签名串
            string sign = Encrypt.MD5("zyl@" + model.Info + "&Dragon");// "{\"text\":\"" + model.Info + "\",\"sign\":\"yxw&dachao\"}";
            #endregion
            model.Token = token;
            model.Sign = sign;
            return model;
        }
        /// <summary>
        /// Get API请求接口加密
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static string GetRequestEncrypt(Dictionary<string, string> dic)
        {
            string requestjson = "";
            string token = "3B3C48F227981712390E4D016D340676513E407555AB45A82135FB6B89236CF3";
            #region 加密签名串
            string info = "";
            foreach (var v in dic)
            {
                info += v.Value;
                requestjson += "&" + v.Key + "=" + v.Value;
            }
            string sign = Encrypt.MD5("zyl@" + info + "&Dragon");

            requestjson = "token=" + token + "&sign=" + sign + requestjson;
            #endregion
            return requestjson;
        }
        
    }
}