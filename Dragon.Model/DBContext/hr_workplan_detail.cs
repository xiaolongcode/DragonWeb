//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    /// 
    /// <summary> 
    [Table("hr_workplan_detail")]
    public class hr_workplan_detail
    { 

        /// <summary>
        /// 主键id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 工作计划id 外键
        /// </summary>
        public int wid { get; set; }

        /// <summary>
        /// 上级id
        /// </summary>
        public int upperId { get; set; }

        /// <summary>
        /// 工作类型
        /// </summary>
        public string worktype { get; set; }

        /// <summary>
        /// 工作详细内容/内容
        /// </summary>
        public string workdetails { get; set; }    } 
 } 
