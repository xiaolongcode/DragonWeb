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
    ///首页轮播 
    /// <summary> 
    public class BizDcbanner: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcbanner  dcb_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcbanner>  dcb_list { get; set; }

    } 
 } 
