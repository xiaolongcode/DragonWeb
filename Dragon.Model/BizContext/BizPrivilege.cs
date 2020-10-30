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
    /// 
    /// <summary> 
    public class BizPrivilege: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public privilege  pri_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<privilege>  pri_list { get; set; }

    } 
 } 
