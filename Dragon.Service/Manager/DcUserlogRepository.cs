//======================================================================
//      Copyright (c) 2020-09-29 Dragon All rights reserved. 
//======================================================================
using System.Collections.Generic;
using Dragon.Service.Manager.Base;
using Dragon.Model.Base;
using Dragon.Model.BizContext;
using Dragon.Model.DBContext;

namespace Dragon.Service.Manager
 { 
    /// <summary> 
    ///员工日志 
    /// <summary> 
    public class DcUserlogRepository: Repository
    { 

        /// <summary>
        ///构造函数 
        /// </summary>
        public DcUserlogRepository()
        {
        }
        #region 删除
        /// <summary>
        ///根据条件删除 
        /// </summary>
        public bool DeleteList(dc_userlog Query)
        {
            #region 关键字过滤 ;
            //string 类型需要过滤 ;
            //Query.name = "%" + StaticBase.KeyFilter(Query.name) + "%";
            #endregion ;
            ResultView rv = respository.DeleteList<dc_userlog>(" where name like @name  ", Query);
            if (rv.Result == 1) 
            { 
               return true; 
             } 
             return false; 
        }
        #endregion 
        #region 查询
        /// <summary>
        ///根据条件查询列表 
        /// </summary>
        public List<dc_userlog> SearchList(dc_userlog Query)
        {
            List<dc_userlog> list = new List<dc_userlog>(); 
            #region 关键字过滤 ;
            //string 类型需要过滤 ;
            //Query.name = "%" + StaticBase.KeyFilter(Query.name) + "%";
            #endregion ;
             ResultView rv = respository.GetList<dc_userlog>(" where id = @id  and name like @name ", Query);
            if (rv.Result == 1) 
            { 
               list = rv.Info;
             } 
             return list; 
        }
        /// <summary>
        ///根据条件查询对象 
        /// </summary>
        public dc_userlog SearchModel(dc_userlog Query)
        {
             dc_userlog model = new dc_userlog();
            #region 关键字过滤 ;
            //string 类型需要过滤 ;
            Query.name = StaticBase.KeyFilter(Query.name);
            Query.id = 2;
            #endregion ;
            ResultView rv = respository.GetModel<dc_userlog>(" select * from dc_userlog where  id = @id ", Query);
            if (rv.Result == 1) 
            { 
               model = rv.Info;
             } 
             return model; 
        }
        /// <summary>
        ///分页查询列表 
        /// </summary>
        /// <param name="Query">查询条件</param>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagecount">每页条数</param>
        public BizDcUserlog SearchListPage(dc_userlog Query, int pageindex = 1, int pagecount = 10)
        {
            BizDcUserlog model = new BizDcUserlog(); 
           #region 关键字过滤 ;
           //string 类型需要过滤 ;
           //Query.name = "%" + StaticBase.KeyFilter(Query.name) + "%";
           #endregion ;
           var rv = respository.GetListPage<dc_userlog>(pageindex, pagecount, "where id = @id  and name like @name ", "id", Query);
            model.pagecount = rv.RecordCount; 
            model.dc__list=rv.ContentList ;
            if (model.dc__list == null)
                model.dc__list = new List<dc_userlog>();
            return model; 
        }
        /// <summary>
        ///查询数据总条数（分页使用) 
        /// </summary>
        /// <param name="Query">查询条件</param>
        public int SearchListPageCount(dc_userlog Query)
        {
            PageInfo model = new PageInfo(); 
           #region 关键字过滤 ;
           //string 类型需要过滤 ;
           //Query.name = "%" + StaticBase.KeyFilter(Query.name) + "%";
           #endregion ;
           var rv = respository.ExecuteScalar<PageInfo>("select count(id) as Count from dc_userlog where id = @id  and name like @name ", Query);
            if (rv.Result == 1)
            {
                model.Count = rv.Info;
            }
            if (model == null)
                return 0;
               return model.Count;
        }
        #endregion 
    } 
 } 
