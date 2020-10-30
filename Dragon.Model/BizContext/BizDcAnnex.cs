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
    ///文章附件 
    /// <summary> 
    public class BizDcAnnex: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcAnnex  dcA_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcAnnex>  dcA_list { get; set; }

    } 
 } 
