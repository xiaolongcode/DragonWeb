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
    ///简历补充表（期望薪资+应聘渠道) 
    /// <summary> 
    public class BizDcResumeAdditional: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_additional  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_additional>  dc__list { get; set; }

    } 
 } 
