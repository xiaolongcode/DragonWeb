//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///首页产品表 
    /// <summary> 
    [Table("dcproducts")]
    public class dcproducts
    { 

        /// <summary>
        /// id
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int number { get; set; }

        /// <summary>
        /// 0 社会大课堂 1 国内研学 2 国际游学 3 酷玩亲子游 4 同业精选  5 北京地接
        /// </summary>
        public int datetype { get; set; }

        /// <summary>
        /// 删除状态 0 未删除  1 已删除
        /// </summary>
        public int isdel { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal P_price { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string p_num { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string P_name { get; set; }

        /// <summary>
        /// 最近发团日期
        /// </summary>
        public string P_date { get; set; }

        /// <summary>
        /// 封面链接
        /// </summary>
        public string P_imghref { get; set; }

        /// <summary>
        /// 产品链接
        /// </summary>
        public string p_href { get; set; }    } 
 } 
