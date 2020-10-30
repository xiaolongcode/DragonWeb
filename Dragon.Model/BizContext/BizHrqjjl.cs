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
    public class BizHrqjjl: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public hrqjjl  hrq_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<hrqjjl>  hrq_list { get; set; }

    } 
 } 
