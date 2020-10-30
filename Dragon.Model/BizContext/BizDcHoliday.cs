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
    ///考勤管理 
    /// <summary> 
    public class BizDcHoliday: BizPage
    { 

        /// <summary>
        ///表对象 
        /// </summary>
        public dc_holiday  dc__info { get; set; }

        /// <summary>
        ///表list 
        /// </summary>
        public List<dc_holiday>  dc__list { get; set; }

    } 
 } 
