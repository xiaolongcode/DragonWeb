using Dragon.Core;
using Dragon.Model.Base;
using System.Collections.Generic;

namespace Dragon.WebAPI.Core
{
    /// <summary>
    /// 校验
    /// </summary>
    public class VerifyData
    {
        /// <summary>
        /// 校验API请求是否合法
        /// </summary>
        /// <param name="model">请求对象</param>
        /// <param name="Message">不合法返回原因</param>
        /// <returns></returns>
        public static bool PostRequestVerify(RequestView model, out string Message)
        {
            string token = "3B3C48F227981712390E4D016D340676513E407555AB45A82135FB6B89236CF3";
            Message = "";
            if (token != model.Token)
            {
                Message = "token不正确！";
                return false;
            }
            #region 加密签名串
            string servicesign = Encrypt.MD5("zyl@" + model.Info + "&Dragon");
            #endregion

            if (servicesign != model.Sign)
            {
                Message = "签名不正确！";
                return false;
            }
            return true;
        }


        /// <summary>
        /// 校验API请求是否合法
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="sign">加密签名</param>
        /// <param name="content">参数拼接字符串</param>
        /// <param name="Message">不合法返回原因</param>
        /// <returns></returns>
        public static bool GetRequestVerify(string token, string sign, string content, out string Message)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string servicetoken = "3B3C48F227981712390E4D016D340676513E407555AB45A82135FB6B89236CF3";
            Message = "";
            if (servicetoken != token)
            {
                Message = "token不正确！";
                return false;
            }
            #region 加密签名串
            string servicesign = Encrypt.MD5("zyl@" + content + "&Dragon");
            #endregion

            if (servicesign != sign)
            {
                Message = "签名不正确！";
                return false;
            }
            return true;
        }
    }
}