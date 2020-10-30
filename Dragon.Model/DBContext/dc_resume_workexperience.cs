//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///工作经历表 
    /// <summary> 
    [Table("dc_resume_workexperience")]
    public class dc_resume_workexperience
    { 

        /// <summary>
        /// 业绩职责
        /// </summary>
        public string outstanding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 简历主键
        /// </summary>
        public int resumeid { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        public string startdate { get; set; }

        /// <summary>
        /// 终止日期
        /// </summary>
        public string enddate { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 离职原因
        /// </summary>
        public string leaving { get; set; }    } 
 } 
