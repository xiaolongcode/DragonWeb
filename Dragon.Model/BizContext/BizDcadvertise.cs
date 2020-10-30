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
    ///首页广告 
    /// <summary> 
    public class BizDcadvertise: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcadvertise  dca_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcadvertise>  dca_list { get; set; }

    } 
 } 
