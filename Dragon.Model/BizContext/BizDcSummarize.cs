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
    ///工作总结 
    /// <summary> 
    public class BizDcSummarize: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_summarize  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_summarize>  dc__list { get; set; }

    } 
 } 
