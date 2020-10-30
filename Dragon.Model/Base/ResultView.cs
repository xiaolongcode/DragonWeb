using System.ComponentModel;

namespace Dragon.Model.Base
{
    /// <summary>
    /// API返回统一结果
    /// </summary>
    [Description("API返回统一结果")]
    public class ResultView
    {
        /// <summary>
        /// 生成实列
        /// </summary>
        /// <param name="info">实体model</param>
        /// <param name="result">0失败，1成功，2session过期</param>
        /// <param name="resultMessage">返回提示</param>
        /// <returns></returns>
        public static ResultView GetResult(object info, int result, string resultMessage)
        {
            ResultView view = new ResultView
            {
                Result = result,
                Info = info,
                ResultMessage = resultMessage
            };
            return view;
        }
        /// <summary>
        /// 返回操作提示结果(success:1,fail:0,2:session过期)
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 返回的结果对象
        /// </summary>
        [Description("返回的结果对象")]
        public dynamic Info { get; set; }
        /// <summary>
        /// 返回操作提示信息
        /// </summary>
        public string ResultMessage { get; set; }
    }
}
