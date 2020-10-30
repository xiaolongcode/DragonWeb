//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///短信模板表 
    /// <summary> 
    [Table("dc_SMS_template")]
    public class dc_SMS_template
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 短信模板标题名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 短信模板内容
        /// </summary>
        public string content { get; set; }    } 
 } 
