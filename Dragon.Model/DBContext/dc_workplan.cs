//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///工作计划主表 
    /// <summary> 
    [Table("dc_workplan")]
    public class dc_workplan
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public int empid { get; set; }

        /// <summary>
        /// 工作计划状态 0-未提交 1-已提交 2-已确认
        /// </summary>
        public int wp_stae { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 提交日期/确认日期
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        public string empcode { get; set; }    } 
 } 
