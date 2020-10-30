//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///考勤附件表 
    /// <summary> 
    [Table("dc_holiday_annex")]
    public class dc_holiday_annex
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 考勤表id
        /// </summary>
        public int holiday_id { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        public string imgtitle { get; set; }

        /// <summary>
        /// 图片ulr
        /// </summary>
        public string imgulr { get; set; }    } 
 } 
