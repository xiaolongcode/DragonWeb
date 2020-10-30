//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///应聘简历个人基本信息-教育经历 
    /// <summary> 
    [Table("dc_resume_educate")]
    public class dc_resume_educate
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 教育经历记录id
        /// </summary>
        public int educate_id { get; set; }

        /// <summary>
        /// 简历id
        /// </summary>
        public int resume_id { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string start_date { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string end_date { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        public string school_name { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string specialty { get; set; }

        /// <summary>
        /// 年限
        /// </summary>
        public string educate_degree { get; set; }

        /// <summary>
        /// 学历(新增)
        /// </summary>
        public string degree { get; set; }    } 
 } 
