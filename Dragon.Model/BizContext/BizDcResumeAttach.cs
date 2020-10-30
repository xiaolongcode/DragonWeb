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
    ///招聘简历附件 
    /// <summary> 
    public class BizDcResumeAttach: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_attach  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_attach>  dc__list { get; set; }

    } 
 } 
