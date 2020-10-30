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
    ///家庭成员表 
    /// <summary> 
    public class BizDcResumeGuideFamily: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_guide_family  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_guide_family>  dc__list { get; set; }

    } 
 } 
