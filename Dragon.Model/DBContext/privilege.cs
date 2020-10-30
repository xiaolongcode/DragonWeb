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
    [Table("privilege")]
    public class privilege
    { 

        /// <summary>
        /// 用户组ID
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 插件编码
        /// </summary>
        public string PrvCode { get; set; }    } 
 } 
