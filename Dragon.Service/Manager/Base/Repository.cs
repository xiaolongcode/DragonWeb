using Dragon.Model.Base;
using Dragon.Service.Base.Implement;
using Dragon.Service.Base.Interface;


namespace Dragon.Service.Manager.Base
{
    /// <summary>
    /// 公共的数据库访问操作
    /// </summary>
    public class Repository
    {
        public readonly ICommonRepository respository = null;
        /// <summary>
        /// 
        /// </summary>
        public Repository()
        {
            respository = new CommonRepository();
        }
        /// <summary>
        ///添加 
        /// </summary>
        /// <param name="Query">要添加的数据对象</param>
        public int Add<T>(T Query)
        {
            ResultView rv = respository.Insert(Query);
            if (rv.Result == 1)
            {
                //成功返回Id
                return rv.Info;
            }
            return 0;
        }

        /// <summary>
        ///删除 
        /// </summary>
        /// <param name="id">要删除的数据id</param>
        public bool Delete<T>(int id)
        {
            ResultView rv = respository.Delete<T>(id);
            if (rv.Result == 1)
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///修改 
        /// </summary>
        /// <param name="Query">要修改的数据对象</param>
        public bool Edit<T>(T Query)
        {
            ResultView rv = respository.Update(Query);
            if (rv.Result == 1)
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///查询所有数据 
        /// </summary>
        public ResultView List<T>()
        {
            return respository.GetList<T>();
        }
        /// <summary>
        ///分页查询列表 
        /// </summary>
        /// <param name="strwhere">查询条件(不需要 where 关键字)</param>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagecount">每页条数</param>
        /// <param name="orderby">排序</param>
        public PageInfo ListPage<T>(string strwhere, int pageindex = 1, int pagecount = 10,string orderby="id")
        {
            PageInfo model = new PageInfo();
            if (!string.IsNullOrEmpty(strwhere))
                strwhere = " where " + strwhere;
            strwhere= StaticBase.WhereFilter(strwhere);
            var rv = respository.GetListPage<T>(pageindex, pagecount, strwhere, orderby, null);
            model.Count = rv.RecordCount;
            model.Info = rv.ContentList;
            return model;
        }
        /// <summary>
        ///分页查询列表 
        /// </summary>
        /// <param name="strwhere">查询条件(不需要 where 关键字)</param>
        /// <param name="pagecount">每页条数</param>
        public PageInfo ListCount<T>(string strwhere, int pagecount = 10)
        {
            PageInfo model = new PageInfo();
            if (!string.IsNullOrEmpty(strwhere))
                strwhere = " where " + strwhere;
            strwhere = StaticBase.WhereFilter(strwhere);
            var rv = respository.GetCountPage<T>(pagecount, strwhere, null);
            model.Count = rv.RecordCount;
            return model;
        }

        /// <summary>
        ///返回首行列数据
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        public int Scalar(string strSql)
        {
            int count = 0;
            strSql = StaticBase.SqlFilter(strSql,0);
            var rv = respository.ExecuteScalar<int>(strSql);
            if (rv.Result == 1)
            {
                count = rv.Info;
            }
            return count;
        }

        /// <summary>
        ///执行一条sql语句
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="type">0 查询 1 添加 2 修改 3 删除</param>
        /// <param name="isone">默认为一条sql语句</param>
        public int Execute(string strSql, int type = 0, bool isone = true)
        {
            int count = 0;
            strSql = StaticBase.SqlFilter(strSql, type, isone);
            var rv = respository.Execute<int>(strSql);
            if (rv.Result == 1)
            {
                count = rv.Info;//返回受影响的行数
            }
            return count;
        }
    }
}
