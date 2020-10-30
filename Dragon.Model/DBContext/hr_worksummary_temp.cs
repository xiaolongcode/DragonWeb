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
    [Table("hr_worksummary_temp")]
    public class hr_worksummary_temp
    { 

        /// <summary>
        /// 模板id
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public string submit_Date { get; set; }    } 
 } 
