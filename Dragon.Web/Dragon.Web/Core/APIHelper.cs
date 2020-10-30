using Dragon.core;
using Dragon.Core;
using Dragon.Model.Base;
using Dragon.Model.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dragon.Web.Core
{
    public class APIHelper
    {

        /// <summary>
        /// post请求示例
        /// </summary>
        /// <returns></returns>
        public static List<dc_resume_guide> PostInfo()
        {
            try
            {

                #region 请求数据
                RequestView rv = new RequestView();
                rv.Info = "{\"name\":\"zhangsan\"}";// 传对象的时候转为json字符串
                rv.PageIndex = 1;
                rv.PageCount = 15;
                rv = StataHelper.PostRequestEncrypt(rv);
                string requestjson = JsonHelper.ConvertToJosnString(rv);
                string resultStr = HttpHelper.HttpPost(StataHelper.GetAPIPath() + "/webapi/Home/PostInfo", requestjson);
                #endregion

                #region  解析数据
                List<dc_resume_guide> list = new List<dc_resume_guide>();
                ResultView resultModel = JsonHelper.FromJsonTo<ResultView>(resultStr);
                if (resultModel.Result == 1)
                {
                    list = JsonHelper.FromJsonTo<List<dc_resume_guide>>(resultModel.Info);
                }
                #endregion
                return list;
            }
            catch
            {
                return null;
            }
        }



        /// <summary>
        /// get请求示例
        /// </summary>
        /// <returns></returns>
        public static ResultView GetInfo()
        {
            try
            {

                #region 请求数据
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("name", "zhangsan");
                string requestjson = StataHelper.GetRequestEncrypt(dic);
                string resultStr = HttpHelper.HttpGet(StataHelper.GetAPIPath() + "/webapi/Home/GetInfo", requestjson);
                #endregion
                #region  解析数据
                ResultView resultModel = JsonHelper.FromJsonTo<ResultView>(resultStr);
                #endregion
                return resultModel;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}