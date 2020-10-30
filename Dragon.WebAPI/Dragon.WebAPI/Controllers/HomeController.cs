using Dragon.Core;
using Dragon.Model.Base;
using Dragon.Model.DBContext;
using Dragon.Service.Manager;
using Dragon.WebAPI.Core;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Dragon.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public ResultView PostInfo(RequestView RequestModel)
        {
            try
            {
                #region 验证数据
                string Message = "";
                if (!VerifyData.PostRequestVerify(RequestModel, out Message))
                {
                    return new ResultView { Info = "", Result = 0, ResultMessage = Message };
                }
                #endregion
                #region 获取接口参数
                dc_resume_guide Request = JsonHelper.ConvertToObject<dc_resume_guide>(RequestModel.Info);
                #endregion
                #region 操作数据
                DcResumeGuideRepository dr = new DcResumeGuideRepository();
                List<dc_resume_guide> list = new List<dc_resume_guide>();
                list = dr.SearchAllList();
                #endregion
                string ResultJson = JsonHelper.ConvertToJosnString(list);
                return new ResultView { Info = ResultJson, Result = 1, ResultMessage = "执行成功" };

            }
            catch (Exception ex)
            {
                return new ResultView { Info = "", Result = 0, ResultMessage = "执行异常" };
            }
        }

        [HttpGet]
        public ResultView GetInfo(string token, string sign, string name)
        {
            try
            {
                #region 验证数据
                string Message = "";
                string content = name;
                if (!VerifyData.GetRequestVerify(token, sign, content, out Message))
                {
                    return new ResultView { Info = "", Result = 0, ResultMessage = Message };
                }
                #endregion

                #region 操作数据
                DcResumeGuideRepository dr = new DcResumeGuideRepository();
                List<dc_resume_guide> list = new List<dc_resume_guide>();
                list = dr.SearchAllList();
                #endregion
                string ResultJson = JsonHelper.ConvertToJosnString(list);
                return new ResultView { Info = ResultJson, Result = 1, ResultMessage = "执行成功" };

            }
            catch (Exception ex)
            {
                return new ResultView { Info = "", Result = 0, ResultMessage = "执行异常" };
            }
        }
    }
}
