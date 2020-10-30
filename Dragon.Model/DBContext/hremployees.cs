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
    [Table("hremployees")]
    public class hremployees
    { 

        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpId { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public int DeptId { get; set; }

        /// <summary>
        /// 人员状态（ 0- 入职培训人员，1-  在职人员——试用期人员，2- 在职人员——正式人员，3- 实习人员，4- 其他从业人员，5- 离职人员（未办理离职清算），6- 离职人员（已办理离职清算），7- 返聘人员，8- 退休人员）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int htnx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Jxkpje { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int flag { get; set; }

        /// <summary>
        /// 集团类型
        /// </summary>
        public int jtlx { get; set; }

        /// <summary>
        /// 培训状态 1培训中 2未通过
        /// </summary>
        public int PXStatus { get; set; }

        /// <summary>
        /// 社保年限
        /// </summary>
        public int Sbnx { get; set; }

        /// <summary>
        /// 状态是否通过审核0未通过1已通过
        /// </summary>
        public int AuditStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Glnum { get; set; }

        /// <summary>
        /// 照片
        /// </summary>
        public Object Photo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string empname { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string Birth { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticalParty { get; set; }

        /// <summary>
        /// 文化程度
        /// </summary>
        public string CultureLevel { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string MaritalCondition { get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        public string BloodType { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string NationPlace { get; set; }

        /// <summary>
        /// 北京居住地
        /// </summary>
        public string BJResidence { get; set; }

        /// <summary>
        /// 北京邮编
        /// </summary>
        public string BJPostCode { get; set; }

        /// <summary>
        /// 家庭住址邮编
        /// </summary>
        public string JTPostCode { get; set; }

        /// <summary>
        /// 培训未通过说明
        /// </summary>
        public string PXMone { get; set; }

        /// <summary>
        /// 退休日期
        /// </summary>
        public string retireDate { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public string weixin { get; set; }

        /// <summary>
        /// 档案年份（档案管理）
        /// </summary>
        public string ArchivesDate { get; set; }

        /// <summary>
        /// 档案位置（档案管理）
        /// </summary>
        public string ArchivesLocation { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbyy3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbyy4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string khh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Hzh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Gatxz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Qyqk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbzrrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbzcrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Gjjzrrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Gjjzcrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbyy1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbyy2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Dazrrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Cdh { get; set; }

        /// <summary>
        /// 离职日期
        /// </summary>
        public string Lzrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sbkh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zfgjjkh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Jxkpjb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zjlxrdh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Hjlx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zyzc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Syqdqr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string bankno { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        public string Rzrq { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string htbh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Htdqr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zjdz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zjyb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Fddh { get; set; }

        /// <summary>
        /// 户口所在地派出所
        /// </summary>
        public string PolicePost { get; set; }

        /// <summary>
        /// 所口所在地街道办事处
        /// </summary>
        public string StreetOffice { get; set; }

        /// <summary>
        /// 本企业工龄起始日
        /// </summary>
        public string HireDate { get; set; }

        /// <summary>
        /// 工龄
        /// </summary>
        public string WorkingYears { get; set; }

        /// <summary>
        /// 签订劳动合同日期
        /// </summary>
        public string ContractSignDate { get; set; }

        /// <summary>
        /// 导游经历
        /// </summary>
        public string TouristExp { get; set; }

        /// <summary>
        /// 手机电话
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 档案存放地
        /// </summary>
        public string Files_Keep_Org { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 居住地址
        /// </summary>
        public string Residence { get; set; }

        /// <summary>
        /// 户口所在地
        /// </summary>
        public string Hukou { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 电脑号
        /// </summary>
        public string PcId { get; set; }

        /// <summary>
        /// 工作证号
        /// </summary>
        public string BadgeId { get; set; }

        /// <summary>
        /// 导游证号
        /// </summary>
        public string TouristID { get; set; }

        /// <summary>
        /// 办公电话
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// 家庭电话
        /// </summary>
        public string HomePhone { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }    } 
 } 
