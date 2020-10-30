//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///工作计划字表 
    /// <summary> 
    [Table("dc_workplan_detail")]
    public class dc_workplan_detail
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 工作计划id 外键
        /// </summary>
        public int wid { get; set; }

        /// <summary>
        /// 上级id
        /// </summary>
        public int upperid { get; set; }

        /// <summary>
        /// 工作类型
        /// </summary>
        public string worktype { get; set; }

        /// <summary>
        /// 工作详细内容/内容
        /// </summary>
        public string worketails { get; set; }

        /// <summary>
        /// 上级编号
        /// </summary>
        public string uppercode { get; set; }    } 
 } 
