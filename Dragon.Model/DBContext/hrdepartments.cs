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
    [Table("hrdepartments")]
    public class hrdepartments
    { 

        /// <summary>
        /// 部门编号
        /// </summary>
        public int DeptId { get; set; }

        /// <summary>
        /// 0-部门，1-岗位
        /// </summary>
        public int DeptType { get; set; }

        /// <summary>
        /// 上级部门
        /// </summary>
        public int UpperId { get; set; }

        /// <summary>
        /// 只有DeptType=2时有效，1表示领导岗位，0表示普通岗位
        /// </summary>
        public int IsLeader { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int SortId { get; set; }

        /// <summary>
        /// 公司 1。大潮 2.游学网 3.德育 4.集团
        /// </summary>
        public int companyid { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 部门编码
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 上级部门编号
        /// </summary>
        public string LeaderGwCode { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string Updatatime { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string UpName { get; set; }    } 
 } 
