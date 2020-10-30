//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///简历补充表（期望薪资+应聘渠道) 
    /// <summary> 
    [Table("dc_resume_additional")]
    public class dc_resume_additional
    { 

        /// <summary>
        /// 述职报告
        /// </summary>
        public string essay { get; set; }

        /// <summary>
        /// 个人介绍
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 应聘我社原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 简历主键
        /// </summary>
        public int resumeid { get; set; }

        /// <summary>
        /// 婚育状况：0:未婚;1:已婚;
        /// </summary>
        public int marry { get; set; }

        /// <summary>
        /// 户籍家庭邮编
        /// </summary>
        public int booklet_code { get; set; }

        /// <summary>
        /// 应聘渠道
        /// </summary>
        public string applyFrom { get; set; }

        /// <summary>
        /// 招聘会
        /// </summary>
        public string jobFair { get; set; }

        /// <summary>
        /// 招聘其他信息
        /// </summary>
        public string othersInfo { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        public string wishSallary1 { get; set; }

        /// <summary>
        /// 月薪期望区域范围
        /// </summary>
        public string wishSallary2 { get; set; }

        /// <summary>
        /// 年收入
        /// </summary>
        public string income1 { get; set; }

        /// <summary>
        /// 应聘方式（新增）
        /// </summary>
        public string applytype { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public string degree { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string postal_code { get; set; }

        /// <summary>
        /// 户口所在地(省|市)
        /// </summary>
        public string booklet_city { get; set; }

        /// <summary>
        /// 户口性质(农业/城镇)
        /// </summary>
        public string booklet_type { get; set; }

        /// <summary>
        /// 户口所在派出所
        /// </summary>
        public string booklet_police { get; set; }

        /// <summary>
        /// 户籍家庭住址
        /// </summary>
        public string booklet_addr { get; set; }

        /// <summary>
        /// 年收入区域范围
        /// </summary>
        public string income2 { get; set; }

        /// <summary>
        /// 导游证号
        /// </summary>
        public string guideIDCard { get; set; }

        /// <summary>
        /// 导游语种
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// 导游证考试时间
        /// </summary>
        public string examTime { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string political { get; set; }

        /// <summary>
        /// 人事档案所在地
        /// </summary>
        public string archive { get; set; }    } 
 } 
