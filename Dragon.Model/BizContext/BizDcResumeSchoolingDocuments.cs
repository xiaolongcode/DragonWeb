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
    ///学历证书表 
    /// <summary> 
    public class BizDcResumeSchoolingDocuments: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_resume_schooling_documents  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_resume_schooling_documents>  dc__list { get; set; }

    } 
 } 
