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
    ///关于我们（行业资质、一路走来用、一分钟说大潮、不忘初心） 
    /// <summary> 
    public class BizDcAbout: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcAbout  dcA_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcAbout>  dcA_list { get; set; }

    } 
 } 
