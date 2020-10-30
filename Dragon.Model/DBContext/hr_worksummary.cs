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
    [Table("hr_worksummary")]
    public class hr_worksummary
    { 

        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 员工id 外键
        /// </summary>
        public int empid { get; set; }

        /// <summary>
        /// 是否下载
        /// </summary>
        public int xzstate { get; set; }

        /// <summary>
        /// 换库状态 0未读，1已读
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 提交日期
        /// </summary>
        public string submit_Date { get; set; }

        /// <summary>
        /// 总结状态
        /// </summary>
        public string ws_state { get; set; }

        /// <summary>
        /// 路径(文件名)
        /// </summary>
        public string file_url { get; set; }    } 
 } 
