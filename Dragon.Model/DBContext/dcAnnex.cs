//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///文章附件 
    /// <summary> 
    [Table("dcAnnex")]
    public class dcAnnex
    { 

        /// <summary>
        /// id
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 企业文章id
        /// </summary>
        public int movingid { get; set; }

        /// <summary>
        /// 附件标题
        /// </summary>
        public string annextitle { get; set; }

        /// <summary>
        /// 附件url
        /// </summary>
        public string annexurl { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public string adddate { get; set; }    } 
 } 
