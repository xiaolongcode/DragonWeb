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
    [Table("hr_duty")]
    public class hr_duty
    { 

        /// <summary>
        /// 职责id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 工作内容id
        /// </summary>
        public int workid { get; set; }

        /// <summary>
        /// 岗位id
        /// </summary>
        public int deptid { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string work { get; set; }

        /// <summary>
        /// 具体工作内容
        /// </summary>
        public string jobcontent { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string datetime { get; set; }

        /// <summary>
        /// pdf文件名
        /// </summary>
        public string pdf { get; set; }

        /// <summary>
        /// 视频名
        /// </summary>
        public string video { get; set; }    } 
 } 
