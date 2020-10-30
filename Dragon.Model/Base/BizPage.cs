using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Model.Base
{
    /// <summary>
    /// 页面返回基类
    /// </summary>
    public class BizPage
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int pagecount { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Msginfo { get; set; }
        /// <summary>
        /// 当前第几页
        /// </summary>
        public int pagenum { get; set; }
        public int pageindex { get; set; }
    }
}
