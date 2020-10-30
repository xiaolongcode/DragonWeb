//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///工作总结 
    /// <summary> 
    [Table("dc_summarize")]
    public class dc_summarize
    { 

        /// <summary>
        /// 总结内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 总结题目
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 附件url
        /// </summary>
        public string annexurl { get; set; }    } 
 } 
