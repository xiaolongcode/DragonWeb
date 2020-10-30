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
    [Table("hr_workplan")]
    public class hr_workplan
    { 

        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public int empId { get; set; }

        /// <summary>
        /// 工作计划状态 0-未提交 1-已提交 2-已确认
        /// </summary>
        public int wp_state { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 提交日期/确认日期
        /// </summary>
        public string submit_Date { get; set; }    } 
 } 
