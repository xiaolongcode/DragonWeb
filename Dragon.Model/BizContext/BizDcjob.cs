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
    ///岗位表 
    /// <summary> 
    public class BizDcjob: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dcjob  dcj_info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dcjob>  dcj_list { get; set; }

    } 
 } 
