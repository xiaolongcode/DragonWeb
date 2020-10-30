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
    [Table("hr_performancescore_file")]
    public class hr_performancescore_file
    { 

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 外键 人员id
        /// </summary>
        public int empid { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public string submit_date { get; set; }

        /// <summary>
        /// 绩效Excel表格
        /// </summary>
        public string jxfile { get; set; }    } 
 } 
