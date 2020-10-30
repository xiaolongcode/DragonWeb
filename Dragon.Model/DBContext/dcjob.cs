//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///岗位表 
    /// <summary> 
    [Table("dcjob")]
    public class dcjob
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 岗位id（对应3.0）
        /// </summary>
        public int jobid { get; set; }

        /// <summary>
        /// 岗位类别 0 专职 1 兼职
        /// </summary>
        public int jobtype { get; set; }

        /// <summary>
        /// 岗位编号
        /// </summary>
        public string jobnum { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        public string jobname { get; set; }

        /// <summary>
        /// 岗位说明书url
        /// </summary>
        public string joburl { get; set; }

        /// <summary>
        /// 岗位视频url
        /// </summary>
        public string videourl { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
        public string addname { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public string adddate { get; set; }    } 
 } 
