//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    /// 
    /// <summary> 
    [Table("hrqjjl")]
    public class hrqjjl
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 请假状态  0 未批准 1已批准 2 拒绝申请 3 撤销申请
        /// </summary>
        public int datastate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmpCode { get; set; }

        /// <summary>
        /// 请假日期-开始日期
        /// </summary>
        public string Qjrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string qjlx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string pzr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Pzsj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string zjlshsj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tjrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string apr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Lygjk { get; set; }

        /// <summary>
        /// 请假日期-截止日期
        /// </summary>
        public string Qjrq_deadline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string sfwc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string jlsh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string jlshsj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string zjsh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string zjshsj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string zjlsh { get; set; }    } 
 } 
