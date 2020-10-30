//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    ///基本信息表 
    /// <summary> 
    [Table("dc_resume_guide")]
    public class dc_resume_guide
    { 

        /// <summary>
        /// 应聘我社原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 个人介绍
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 简历状态#0:未选择;1:通过;2:未通过
        /// </summary>
        public int gstatus { get; set; }

        /// <summary>
        /// 最后修改状态的管理员
        /// </summary>
        public int last_user_id { get; set; }

        /// <summary>
        /// 职位表ID
        /// </summary>
        public int post_id { get; set; }

        /// <summary>
        /// 婚育状况：0:未婚;1:已婚; (新增)
        /// </summary>
        public int marry { get; set; }

        /// <summary>
        /// 面试状态 0 未预约初试  1 待初试   2 初试未通过  3 未预约复试  4 待复试   5 复试未通过  6 已通过面试
        /// </summary>
        public int interviewstate { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public string weixin { get; set; }

        /// <summary>
        /// 述职报告
        /// </summary>
        public string essay { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public string hiredate { get; set; }

        /// <summary>
        /// 月薪期望区域范围
        /// </summary>
        public string wishSallary2 { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        public string wishSallary1 { get; set; }

        /// <summary>
        /// 年收入
        /// </summary>
        public string income1 { get; set; }

        /// <summary>
        /// 年收入区域范围
        /// </summary>
        public string income2 { get; set; }

        /// <summary>
        /// 应聘方式（新增）
        /// </summary>
        public string applytype { get; set; }

        /// <summary>
        /// 生育状况
        /// </summary>
        public string plant { get; set; }

        /// <summary>
        /// 复试时间
        /// </summary>
        public string retestdate { get; set; }

        /// <summary>
        /// 复试面试人
        /// </summary>
        public string retestname { get; set; }

        /// <summary>
        /// 初试结果（备注或原因）
        /// </summary>
        public string initialtestremarks { get; set; }

        /// <summary>
        /// 复试结果（备注或原因）
        /// </summary>
        public string retestremarks { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        public string post_name { get; set; }

        /// <summary>
        /// 应聘渠道
        /// </summary>
        public string applyFrom { get; set; }

        /// <summary>
        /// 人事档案所在地 (新增)
        /// </summary>
        public string archive { get; set; }

        /// <summary>
        /// 户口性质(农业/城镇)
        /// </summary>
        public string booklet_type { get; set; }

        /// <summary>
        /// 户口所在派出所
        /// </summary>
        public string booklet_police { get; set; }

        /// <summary>
        /// 籍贯家庭住址
        /// </summary>
        public string booklet_addr { get; set; }

        /// <summary>
        /// 初试时间
        /// </summary>
        public string initialtestdate { get; set; }

        /// <summary>
        /// 初试面试人
        /// </summary>
        public string initialtestname { get; set; }

        /// <summary>
        /// 在京居住地
        /// </summary>
        public string HomeinBeijing { get; set; }

        /// <summary>
        /// 临近地铁站
        /// </summary>
        public string subway_station { get; set; }

        /// <summary>
        /// 填写时间
        /// </summary>
        public string fillinTime { get; set; }

        /// <summary>
        /// 最后修改状态时间
        /// </summary>
        public string last_time { get; set; }

        /// <summary>
        /// 政治面貌（新增）
        /// </summary>
        public string political { get; set; }

        /// <summary>
        /// 户口所在地 (新增)
        /// </summary>
        public string booklet_city { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public string qq { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string idcard { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string nation { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string census_register { get; set; }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string ICE { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string contact_phone { get; set; }    } 
 } 
