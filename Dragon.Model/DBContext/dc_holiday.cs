//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///考勤管理 
    /// <summary> 
    [Table("dc_holiday")]
    public class dc_holiday
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        public int days { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 请假类型
        /// </summary>
        public string holidaytype { get; set; }

        /// <summary>
        /// 请假开始日期
        /// </summary>
        public string bendate { get; set; }

        /// <summary>
        /// 请假结束日期
        /// </summary>
        public string enddate { get; set; }

        /// <summary>
        /// 提交日期
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public string checkname { get; set; }

        /// <summary>
        /// 审批时间
        /// </summary>
        public string checkdate { get; set; }

        /// <summary>
        /// 请假理由
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string number { get; set; }    } 
 } 
