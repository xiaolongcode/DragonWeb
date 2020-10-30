//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///招聘简历附件 
    /// <summary> 
    [Table("dc_resume_attach")]
    public class dc_resume_attach
    { 

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 类别（1-简历附件;2-导游证;3-带团照片;4-logo;5-简历头像;6-前台验证头像；7-近照；8-毕业证；9-学籍；10-资格证书（暂时停用） ;11- 学信网证明；12-学士学位证明；13-资格证书1；14-资格证书2；15-资格证书3；16-资格证书4）
        /// </summary>
        public int category { get; set; }

        /// <summary>
        /// 简历主键
        /// </summary>
        public int resumeid { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public string uploadtime { get; set; }    } 
 } 
