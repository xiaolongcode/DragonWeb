//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///关于我们（行业资质、一路走来用、一分钟说大潮、不忘初心） 
    /// <summary> 
    [Table("dcAbout")]
    public class dcAbout
    { 

        /// <summary>
        /// 文字介绍内容（一分钟说大潮、不忘初心 用）
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 0 行业资质  1 一分钟说大潮 2 一路走来  3 不忘初心 4 企业荣誉
        /// </summary>
        public int datatype { get; set; }

        /// <summary>
        /// 删除状态 0 未删除  1 已删除
        /// </summary>
        public int isdel { get; set; }

        /// <summary>
        /// 显示隐藏 0 显示    1 隐藏
        /// </summary>
        public int ishide { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int number { get; set; }

        /// <summary>
        /// 置顶 0 否  1 是
        /// </summary>
        public int sticky { get; set; }

        /// <summary>
        /// 图片标题（行业资质、一路走来用）
        /// </summary>
        public string imgtitle { get; set; }

        /// <summary>
        /// 图片url（行业资质、一路走来用）
        /// </summary>
        public string imgurl { get; set; }

        /// <summary>
        /// 视频介绍url（一分钟说大潮 用）
        /// </summary>
        public string videourl { get; set; }

        /// <summary>
        /// 添加日期
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 备用字段
        /// </summary>
        public string backup { get; set; }

        /// <summary>
        /// 年份  一路走来用
        /// </summary>
        public string ab_year { get; set; }

        /// <summary>
        /// 月份  一路走来用
        /// </summary>
        public string ab_month { get; set; }    } 
 } 
