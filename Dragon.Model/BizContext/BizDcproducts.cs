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
    ///首页产品表 
    /// <summary> 
    public class BizDcproducts: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcproducts  dcp_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcproducts>  dcp_list { get; set; }

    } 
 } 
