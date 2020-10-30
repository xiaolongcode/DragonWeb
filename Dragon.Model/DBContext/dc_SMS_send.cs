//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///短信发送表 
    /// <summary> 
    [Table("dc_SMS_send")]
    public class dc_SMS_send
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 状态（0成功，1失败）
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 方向（接收 ，发送）
        /// </summary>
        public string SMS_type { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public string adddate { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string backinfo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string staffname { get; set; }    } 
 } 
