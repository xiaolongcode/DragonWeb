//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///家庭成员表 
    /// <summary> 
    [Table("dc_resume_guide_family")]
    public class dc_resume_guide_family
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 简历主键id
        /// </summary>
        public int resumeid { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 关系
        /// </summary>
        public string relationship { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 工作单位
        /// </summary>
        public string company { get; set; }    } 
 } 
