//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///学历证书表 
    /// <summary> 
    [Table("dc_resume_schooling_documents")]
    public class dc_resume_schooling_documents
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 简历主键
        /// </summary>
        public int resumeid { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public string level { get; set; }    } 
 } 
