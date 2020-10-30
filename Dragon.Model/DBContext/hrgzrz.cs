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
    [Table("hrgzrz")]
    public class hrgzrz
    { 

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tjfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tjsj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tjdate { get; set; }    } 
 } 
