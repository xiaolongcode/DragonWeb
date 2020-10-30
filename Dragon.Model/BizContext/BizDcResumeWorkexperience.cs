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
    ///工作经历表 
    /// <summary> 
    public class BizDcResumeWorkexperience: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_workexperience  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_workexperience>  dc__list { get; set; }

    } 
 } 
