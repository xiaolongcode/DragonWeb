using System;
using System.ComponentModel;

namespace Dragon.Model.Base
{
    /// <summary>
    /// API返回统一结果
    /// </summary>
    [Description("API返回统一结果")]
    public class JavaModel
    {
        /// <summary>
        /// 生成实列
        /// </summary>
        /// <param name="info">实体model</param>
        /// <param name="result">0失败，1成功，2session过期</param>
        /// <param name="resultMessage">返回提示</param>
        /// <returns></returns>
        public static JavaModel GetResult(object info, int result, string resultMessage)
        {
            JavaModel view = new JavaModel
            {
                code = result,
                data = info,
                msg = resultMessage
            };
            return view;
        }
        /// <summary>
        /// 返回操作提示结果(success:1,fail:0,2:session过期)
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 返回的结果对象
        /// </summary>
        [Description("返回的结果对象")]
        public dynamic data { get; set; }
        /// <summary>
        /// 返回操作提示信息
        /// </summary>
        public string msg { get; set; }

        
    }
}
