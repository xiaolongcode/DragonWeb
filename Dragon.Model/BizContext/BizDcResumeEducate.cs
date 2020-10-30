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
    ///应聘简历个人基本信息-教育经历 
    /// <summary> 
    public class BizDcResumeEducate: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_educate  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_educate>  dc__list { get; set; }

    } 
 } 
