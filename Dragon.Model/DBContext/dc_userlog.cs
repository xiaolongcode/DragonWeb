//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///员工日志 
    /// <summary> 
    [Table("dc_userlog")]
    public class dc_userlog
    { 

        /// <summary>
        /// 提交内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 岗位
        /// </summary>
        public string job { get; set; }

        /// <summary>
        /// 提交方式
        /// </summary>
        public string fashion { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public string adddate { get; set; }    } 
 } 
