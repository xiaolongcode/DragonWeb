//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///企业文章（ 企业动态  经营理念  党团建设  工会活动 员工天地） 
    /// <summary> 
    [Table("dcMoving")]
    public class dcMoving
    { 

        /// <summary>
        /// 内容
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 0 企业动态  1 经营理念 2 党团建设  3 工会活动4 员工天地  5 共享制四座桥
        /// </summary>
        public int datatype { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int number { get; set; }

        /// <summary>
        /// 删除状态 0 未删除  1 已删除
        /// </summary>
        public int isdel { get; set; }

        /// <summary>
        /// 显示隐藏 0 显示    1 隐藏
        /// </summary>
        public int ishide { get; set; }

        /// <summary>
        /// 置顶 0 否  1 是
        /// </summary>
        public int sticky { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 内容来源
        /// </summary>
        public string datasource { get; set; }

        /// <summary>
        /// 图片url（经营理念用）
        /// </summary>
        public string imgurl { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        public string fabudate { get; set; }    } 
 } 
