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
    [Table("prvusers")]
    public class prvusers
    { 

        /// <summary>
        /// 员工ID
        /// </summary>
        public int EmpId { get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool isValid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Key]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd { get; set; }    } 
 } 
