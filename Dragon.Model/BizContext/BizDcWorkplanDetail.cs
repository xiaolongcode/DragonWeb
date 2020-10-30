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
    ///工作计划字表 
    /// <summary> 
    public class BizDcWorkplanDetail: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_workplan_detail  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_workplan_detail>  dc__list { get; set; }

    } 
 } 
