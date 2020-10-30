//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///首页广告 
    /// <summary> 
    [Table("dcadvertise")]
    public class dcadvertise
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 显示隐藏 0 显示    1 隐藏
        /// </summary>
        public int ishide { get; set; }

        /// <summary>
        /// 广告图片链接
        /// </summary>
        public string imgurl { get; set; }

        /// <summary>
        /// 广告名称/标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 广告链接
        /// </summary>
        public string linkurl { get; set; }    } 
 } 
