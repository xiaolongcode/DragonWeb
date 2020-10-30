//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///首页轮播 
    /// <summary> 
    [Table("dcbanner")]
    public class dcbanner
    { 

        /// <summary>
        /// id
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int number { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 图片Url
        /// </summary>
        public string imgurl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        public string linkurl { get; set; }    } 
 } 
