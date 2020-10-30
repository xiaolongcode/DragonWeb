//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.Collections.Generic;
using Dragon.Model.Base;
using Dragon.Model.DBContext;

namespace Dragon.Model.BizContext
 { 
    /// <summary> 
    ///企业文章（ 企业动态  经营理念  党团建设  工会活动 员工天地） 
    /// <summary> 
    public class BizDcMoving: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcMoving  dcM_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcMoving>  dcM_list { get; set; }

    } 
 } 
