using BulidCodeDB;
using Dragon.Service.Base.Implement;
using Dragon.Service.Base.Instrument;
using Dragon.Service.Base.Interface;
using Dragon.Model.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BulidCode
{
    public partial class BulidCode : Form
    {
        private string nameSpace;//命名空间名称
        private string server;//服务器
        private string database;//数据库
        private string name;//登录名
        private string pwd;//密码
        /// <summary>
        /// 0 SqlServer  1 MySql 
        /// </summary>
        private int SqlType = -1;//
        public BulidCode()
        {
            InitializeComponent();


            string serverName = "192.168.0.205";//服务器信息
            string nameSpace = "Dragon"; //命名空间名称
            string databaseName = "DCOfficial";// 数据库
            string loginName = "ligong"; //登录名
            string loginPwd = "64811044Dachao"; //登录密码

            txtip.Text = serverName;
            txtnamespace.Text = nameSpace;
            txtdb.Text = databaseName;
            txtuser.Text = loginName;
            txtpwd.Text = loginPwd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverPath = Environment.CurrentDirectory;//获取或设置当前工作目录的完全限定路径。
            int index = serverPath.IndexOf("bin");
            serverPath = serverPath.Substring(0, index) + "BulidCode";
            server = txtip.Text;
            nameSpace = txtnamespace.Text;
            database = txtdb.Text;
            name = txtuser.Text;
            pwd = txtpwd.Text;

            if (rbmysql.Checked)
            {
                SqlType = 1;
            }
            if (rbSqlServer.Checked)
            {
                SqlType = 0;
            }
            if (SqlType == -1)
            {
                MessageBox.Show("请选择数据类型！");
                return;
            }
            try
            {
                CreateCodes(serverPath, server, nameSpace, database, name, pwd);
                MessageBox.Show("代码生成完毕");
            }
            catch (Exception ex)
            {
                MessageBox.Show("代码生成异常：" + ex.Message);
            }
        }


        #region 代码生成
        //public delegate void ProcessDelegate(int val);//声明委托
        #region 变量
        //public  event ProcessDelegate ProcessIn;//事件

        #endregion
        #region 生成代码
        /// <summary>
        /// 初始方法
        /// </summary>
        /// <param name="serverPath"></param>
        /// <param name="serverName"></param>
        /// <param name="nameSpace"></param>
        /// <param name="databaseName"></param>
        /// <param name="loginName"></param>
        /// <param name="loginPwd"></param>
        public void CreateCodes(string serverPath, string serverName, string nameSpace, string databaseName, string loginName, string loginPwd)
        {

            //获得链接信息
            server = serverName;
            database = databaseName;
            name = loginName;
            pwd = loginPwd;
            string appendstr = "Service端命名空间：Dragon.Service ；Model端命名空间：Dragon.Model \r\n";
            appendstr += "数据库服务器：" + server + " 数据库：" + database + " 账号：" + name + "密码：" + pwd + "\r\n";
            appendstr += "保存路径：" + serverPath + "\r\n";
            tblog.AppendText(appendstr);
            SimpleCRUD.SetConnectionString(GetConn(), SqlType);
            CreateModel(serverPath, nameSpace);//生成Model项目

        }
        #region 生成Model项目
        /// <summary>
        /// 生成Model项目
        /// </summary>
        ///<param name="savePath">存放路径</param>
        /// <param name="nameSpace">命名空间</param>
        private void CreateModel(string savePath, string nameSpace)
        {
            string appendstr = " 开始读取数据 \r\n";
            tblog.AppendText(appendstr);
            //实体类
            List<TableList> tblist = GetTableNames();
            appendstr = " 表数据读取成功：共" + tblist.Count + "个数据表 \r\n";
            tblog.AppendText(appendstr);
            int num = 0;
            int count = tblist.Count;
            foreach (TableList table in tblist)
            {
                num++;
                appendstr = " ===============执行第" + num + "个表数据写入，剩余" + (count - num) + "条数据=============== \r\n";
                tblog.AppendText(appendstr);
                List<ColumnContent> list = GetColumns(table.tablename.ToDelKh());
                appendstr = " 列数据读取成功：共" + list.Count + "个列数据 \r\n";
                tblog.AppendText(appendstr);
                #region 生成数据库model

                StringBuilder tabstr = new StringBuilder();
                tabstr.Append("//======================================================================\r\n");
                tabstr.Append("//      Copyright (c) " + DateTime.Now.ToString("yyyy-MM-dd") + " Dragon All rights reserved. \r\n");
                tabstr.Append("//======================================================================\r\n");
                tabstr.Append("using System;\r\n");
                tabstr.Append("using System.ComponentModel.DataAnnotations;\r\n");
                tabstr.Append("using System.ComponentModel.DataAnnotations.Schema;\r\n\r\n");

                tabstr.Append("namespace " + nameSpace + ".Model.DBContext\r\n");
                tabstr.Append(" { \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    ///" + table.tabletitle.Replace("\r", "").Replace("\n", "").Trim() + " \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    [Table(\"" + table.tablename.ToDelKh() + "\")]\r\n");
                tabstr.Append("    public class " + table.tablename.ToDelKh() + "\r\n");
                tabstr.Append("    { \r\n\r\n");
                for (int i = 0; i < list.Count; i++)
                {
                    ColumnContent ct = list[i];

                    //自动属性
                    tabstr.Append("        /// <summary>\r\n");
                    tabstr.Append("        /// " + ct.Comment.Replace("\r", "").Replace("\n", "").Trim() + "\r\n");
                    tabstr.Append("        /// </summary>\r\n");
                    if (SqlType == 1)
                    {
                        if (ct.Key == "PRI")//PRI主键约束　　UNI唯一约束　　MUL可以重复
                        {
                            tabstr.Append("        [Key]\r\n");
                        }
                    }
                    else
                    {
                        if (ct.Key == "1")
                        {
                            tabstr.Append("        [Key]\r\n");
                        }
                    }
                    tabstr.Append("        public " + ChangeTypeName(ct.TypeName) + " " + ct.ColName.ToDelKh() + " { get; set; }" + (i < list.Count - 1 ? "\r\n\r\n" : ""));
                }
                tabstr.Append("    } \r\n");
                tabstr.Append(" } \r\n");
                StreamWriter newtext = new StreamWriter(savePath + @"\Model\DBContext\" + table.tablename.ToDelKh() + ".cs", false, Encoding.UTF8);
                newtext.Write(tabstr.ToString());
                newtext.Close();
                #endregion

                tblog.AppendText("生成数据库Model成功 \r\n");
                #region 生成重定义model
                tabstr = new StringBuilder();
                tabstr.Append("//======================================================================\r\n");
                tabstr.Append("//      Copyright (c) " + DateTime.Now.ToString("yyyy-MM-dd") + " Dragon All rights reserved. \r\n");
                tabstr.Append("//======================================================================\r\n");

                tabstr.Append("using System;\r\n");
                tabstr.Append("using System.Collections.Generic;\r\n");
                tabstr.Append("using " + nameSpace + ".Model.Base;\r\n");
                tabstr.Append("using " + nameSpace + ".Model.DBContext;\r\n\r\n");


                tabstr.Append("namespace " + nameSpace + ".Model.BizContext\r\n");
                tabstr.Append(" { \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    ///" + table.tabletitle.Replace("\r", "").Replace("\n", "").Trim() + " \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    public class Biz" + table.tablename.ToCamel() + ": BizPage\r\n");
                tabstr.Append("    { \r\n\r\n");
                //自动属性
                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///表对象 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public " + table.tablename.ToDelKh() + "  " + table.tablename.ToDelKhBiz() + "_info { get; set; }\r\n\r\n");
                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///表list \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public List<" + table.tablename.ToDelKh() + ">  " + table.tablename.ToDelKhBiz() + "_list { get; set; }\r\n\r\n");

                tabstr.Append("    } \r\n");
                tabstr.Append(" } \r\n");
                newtext = new StreamWriter(savePath + @"\Model\BizContext\Biz" + table.tablename.ToCamel() + ".cs", false, Encoding.UTF8);
                newtext.Write(tabstr.ToString());
                newtext.Close();
                #endregion

                tblog.AppendText("生成重定义Model成功 \r\n");
                #region 生成Service
                tabstr = new StringBuilder();
                tabstr.Append("//======================================================================\r\n");
                tabstr.Append("//      Copyright (c) " + DateTime.Now.ToString("yyyy-MM-dd") + " Dragon All rights reserved. \r\n");
                tabstr.Append("//======================================================================\r\n");

                //tabstr.Append("using System;\r\n");
                tabstr.Append("using System.Collections.Generic;\r\n");
                tabstr.Append("using " + nameSpace + ".Service.Manager.Base;\r\n");
                //tabstr.Append("using " + nameSpace + ".Service.Base.Implement;\r\n");
                //tabstr.Append("using " + nameSpace + ".Service.Base.Interface;\r\n");
                tabstr.Append("using " + nameSpace + ".Model.Base;\r\n");
                tabstr.Append("using " + nameSpace + ".Model.BizContext;\r\n");
                tabstr.Append("using " + nameSpace + ".Model.DBContext;\r\n\r\n");


                tabstr.Append("namespace " + nameSpace + ".Service.Manager\r\n");
                tabstr.Append(" { \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    ///" + table.tabletitle.Replace("\r", "").Replace("\n", "").Trim() + " \r\n");
                tabstr.Append("    /// <summary> \r\n");
                tabstr.Append("    public class " + table.tablename.ToCamel() + "Repository: Repository\r\n");
                tabstr.Append("    { \r\n\r\n");

                //tabstr.Append("        private readonly ICommonRepository respository = null;\r\n");
                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///构造函数 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public " + table.tablename.ToCamel() + "Repository()\r\n");
                tabstr.Append("        {\r\n");
                //tabstr.Append("            respository = new CommonRepository();\r\n");
                tabstr.Append("        }\r\n");

                //tabstr.Append("        #region 添加\r\n");
                //tabstr.Append("        /// <summary>\r\n");
                //tabstr.Append("        ///添加 \r\n");
                //tabstr.Append("        /// </summary>\r\n");
                //tabstr.Append("        public int Add(" + table.tablename.ToDelKh() + " Query)\r\n");
                //tabstr.Append("        {\r\n");
                //tabstr.Append("            #region 关键字过滤 ;\r\n");
                //tabstr.Append("            //string 类型需要过滤 ;\r\n");
                //tabstr.Append("            //Query.h_title = StaticBase.KeyFilter(Query.h_title); \r\n");
                //tabstr.Append("            #endregion ;\r\n");
                //tabstr.Append("            ResultView rv = respository.Insert(Query); \r\n");//<" + table.tablename.ToDelKh() + ">
                //tabstr.Append("            if (rv.Result == 1) \r\n");
                //tabstr.Append("            { \r\n");
                //tabstr.Append("                 return rv.Info;  \r\n");
                //tabstr.Append("             } \r\n");
                //tabstr.Append("             return 0; \r\n");
                //tabstr.Append("        }\r\n");
                //tabstr.Append("        #endregion \r\n");

                tabstr.Append("        #region 删除\r\n");
                //tabstr.Append("        /// <summary>\r\n");
                //tabstr.Append("        ///根据id删除 \r\n");
                //tabstr.Append("        /// </summary>\r\n");
                //tabstr.Append("        public bool Delete(int id)\r\n");
                //tabstr.Append("        {\r\n");
                //tabstr.Append("            ResultView rv = respository.Delete<" + table.tablename.ToDelKh() + ">(id); \r\n");
                //tabstr.Append("            if (rv.Result == 1) \r\n");
                //tabstr.Append("            { \r\n");
                //tabstr.Append("               return true; \r\n");
                //tabstr.Append("             } \r\n");
                //tabstr.Append("             return false; \r\n");
                //tabstr.Append("        }\r\n");


                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///根据条件删除 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public bool DeleteList(" + table.tablename.ToDelKh() + " Query)\r\n");
                tabstr.Append("        {\r\n");
                tabstr.Append("            #region 关键字过滤 ;\r\n");
                tabstr.Append("            //string 类型需要过滤 ;\r\n");
                tabstr.Append("            //Query.name = \"%\" + StaticBase.KeyFilter(Query.name) + \"%\";\r\n");
                tabstr.Append("            #endregion ;\r\n");
                tabstr.Append("            ResultView rv = respository.DeleteList<" + table.tablename.ToDelKh() + ">(\" where name like @name  \", Query);\r\n");
                tabstr.Append("            if (rv.Result == 1) \r\n");
                tabstr.Append("            { \r\n");
                tabstr.Append("               return true; \r\n");
                tabstr.Append("             } \r\n");
                tabstr.Append("             return false; \r\n");
                tabstr.Append("        }\r\n");
                tabstr.Append("        #endregion \r\n");

                //tabstr.Append("        #region 修改\r\n");
                //tabstr.Append("        /// <summary>\r\n");
                //tabstr.Append("        ///修改 \r\n");
                //tabstr.Append("        /// </summary>\r\n");
                //tabstr.Append("        public bool Edit(" + table.tablename.ToDelKh() + " Query)\r\n");
                //tabstr.Append("        {\r\n");
                //tabstr.Append("            #region 关键字过滤 ;\r\n");
                //tabstr.Append("            //string 类型需要过滤 ;\r\n");
                //tabstr.Append("            //Query.name = StaticBase.KeyFilter(Query.name); \r\n");
                //tabstr.Append("            #endregion ;\r\n");
                //tabstr.Append("            ResultView rv = respository.Update(Query); \r\n");//<" + table.tablename.ToDelKh() + ">
                //tabstr.Append("            if (rv.Result == 1) \r\n");
                //tabstr.Append("            { \r\n");
                //tabstr.Append("                return true; \r\n");
                //tabstr.Append("             } \r\n");
                //tabstr.Append("             return false; \r\n");
                //tabstr.Append("        }\r\n");
                //tabstr.Append("        #endregion \r\n");

                tabstr.Append("        #region 查询\r\n");
                //tabstr.Append("        /// <summary>\r\n");
                //tabstr.Append("        ///查询所有数据 \r\n");
                //tabstr.Append("        /// </summary>\r\n");
                //tabstr.Append("        public List<" + table.tablename.ToDelKh() + "> SearchAllList()\r\n");
                //tabstr.Append("        {\r\n");
                //tabstr.Append("            List<" + table.tablename.ToDelKh() + "> list = new List<" + table.tablename.ToDelKh() + ">(); \r\n");
                //tabstr.Append("            ResultView rv = respository.GetList<" + table.tablename.ToDelKh() + ">();\r\n");
                //tabstr.Append("            if (rv.Result == 1) \r\n");
                //tabstr.Append("            { \r\n");
                //tabstr.Append("               list = rv.Info;\r\n");
                //tabstr.Append("             } \r\n");
                //tabstr.Append("             return list; \r\n");
                //tabstr.Append("        }\r\n");


                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///根据条件查询列表 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public List<" + table.tablename.ToDelKh() + "> SearchList(" + table.tablename.ToDelKh() + " Query)\r\n");
                tabstr.Append("        {\r\n");
                tabstr.Append("            List<" + table.tablename.ToDelKh() + "> list = new List<" + table.tablename.ToDelKh() + ">(); \r\n");
                tabstr.Append("            #region 关键字过滤 ;\r\n");
                tabstr.Append("            //string 类型需要过滤 ;\r\n");
                tabstr.Append("            //Query.name = \"%\" + StaticBase.KeyFilter(Query.name) + \"%\";\r\n");
                tabstr.Append("            #endregion ;\r\n");
                tabstr.Append("             ResultView rv = respository.GetList<" + table.tablename.ToDelKh() + ">(\" where id = @id  and name like @name \", Query);\r\n");
                tabstr.Append("            if (rv.Result == 1) \r\n");
                tabstr.Append("            { \r\n");
                tabstr.Append("               list = rv.Info;\r\n");
                tabstr.Append("             } \r\n");
                tabstr.Append("             return list; \r\n");
                tabstr.Append("        }\r\n");

                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///根据条件查询对象 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        public " + table.tablename.ToDelKh() + " SearchModel(" + table.tablename.ToDelKh() + " Query)\r\n");
                tabstr.Append("        {\r\n");
                tabstr.Append("             " + table.tablename.ToDelKh() + " model = new " + table.tablename.ToDelKh() + "(); \r\n");
                tabstr.Append("            #region 关键字过滤 ;\r\n");
                tabstr.Append("            //string 类型需要过滤 ;\r\n");
                tabstr.Append("            //Query.name = \"%\" + StaticBase.KeyFilter(Query.name) + \"%\";\r\n");
                tabstr.Append("            #endregion ;\r\n");
                tabstr.Append("             ResultView rv = respository.GetModel<" + table.tablename.ToDelKh() + ">(\" select * from " + table.tablename.ToDelKh() + " where id = @id  and name like @name \", Query);\r\n");
                tabstr.Append("            if (rv.Result == 1) \r\n");
                tabstr.Append("            { \r\n");
                tabstr.Append("               model = rv.Info;\r\n");
                tabstr.Append("             } \r\n");
                tabstr.Append("             return model; \r\n");
                tabstr.Append("        }\r\n");


                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///分页查询列表 \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        /// <param name=\"Query\">查询条件</param>\r\n");
                tabstr.Append("        /// <param name=\"pageindex\">第几页</param>\r\n");
                tabstr.Append("        /// <param name=\"pagecount\">每页条数</param>\r\n");
                tabstr.Append("        public Biz" + table.tablename.ToCamel() + " SearchListPage(" + table.tablename.ToDelKh() + " Query, int pageindex = 1, int pagecount = 10)\r\n");
                tabstr.Append("        {\r\n");
                tabstr.Append("            Biz" + table.tablename.ToCamel() + " model = new Biz" + table.tablename.ToCamel() + "(); \r\n");
                tabstr.Append("           #region 关键字过滤 ;\r\n");
                tabstr.Append("           //string 类型需要过滤 ;\r\n");
                tabstr.Append("           //Query.name = \"%\" + StaticBase.KeyFilter(Query.name) + \"%\";\r\n");
                tabstr.Append("           #endregion ;\r\n");
                tabstr.Append("           var rv = respository.GetListPage<" + table.tablename.ToDelKh() + ">(pageindex, pagecount, \"where id = @id  and name like @name \", \"id\", Query);\r\n");
                tabstr.Append("            model.pagecount = rv.RecordCount; \r\n");
                tabstr.Append("            model." + table.tablename.ToDelKhBiz() + "_list=rv.ContentList ;\r\n");
                tabstr.Append("            if (model." + table.tablename.ToDelKhBiz() + "_list == null)\r\n");
                tabstr.Append("                model." + table.tablename.ToDelKhBiz() + "_list = new List<" + table.tablename.ToDelKh() + ">();\r\n");
                tabstr.Append("            return model; \r\n");
                tabstr.Append("        }\r\n");

                tabstr.Append("        /// <summary>\r\n");
                tabstr.Append("        ///查询数据总条数（分页使用) \r\n");
                tabstr.Append("        /// </summary>\r\n");
                tabstr.Append("        /// <param name=\"Query\">查询条件</param>\r\n");
                tabstr.Append("        public int SearchListPageCount(" + table.tablename.ToDelKh() + " Query)\r\n");
                tabstr.Append("        {\r\n");
                tabstr.Append("            PageInfo model = new PageInfo(); \r\n");
                tabstr.Append("           #region 关键字过滤 ;\r\n");
                tabstr.Append("           //string 类型需要过滤 ;\r\n");
                tabstr.Append("           //Query.name = \"%\" + StaticBase.KeyFilter(Query.name) + \"%\";\r\n");
                tabstr.Append("           #endregion ;\r\n");
                tabstr.Append("           var rv = respository.ExecuteScalar<PageInfo>(\"select count(id) as Count from " + table.tablename.ToDelKh() + " where id = @id  and name like @name \", Query);\r\n");
                tabstr.Append("            if (rv.Result == 1)\r\n");
                tabstr.Append("            {\r\n");
                tabstr.Append("                model.Count = rv.Info;\r\n");
                tabstr.Append("            }\r\n");
                tabstr.Append("            if (model == null)\r\n");
                tabstr.Append("                return 0;\r\n");
                tabstr.Append("               return model.Count;\r\n");
                tabstr.Append("        }\r\n");


                tabstr.Append("        #endregion \r\n");
                tabstr.Append("    } \r\n");
                tabstr.Append(" } \r\n");
                newtext = new StreamWriter(savePath + @"\Service\Manager\" + table.tablename.ToCamel() + "Repository.cs", false, Encoding.UTF8);
                newtext.Write(tabstr.ToString());
                newtext.Close();
                #endregion

                tblog.AppendText("生成Service成功 \r\n");

                tblog.AppendText("===============当前表写入结束=============== \r\n");
            }
        }
        #endregion
        #endregion
        #region 数据库有关的公用方法

        #region 返回连接语句
        /// <summary>
        /// 连接语句
        /// </summary>
        /// <returns>连接数据库字符串</returns>
        private string GetConn()
        {
            if (SqlType == 1)
            {
                //链接模式 true为Sql模式,False为Win模式
                return string.Format("Database={0};Data Source={1};User Id={2};Password={3};port=3306", database, server, name, pwd);
            }
            else
            {
                return string.Format("server={0};database={1};uid={2};pwd={3}", server, database, name, pwd);
            }
        }

        private readonly ICommonRepository respository = new CommonRepository();

        #endregion
        #region 获取所有当前数据库中的表
        /// <summary>
        /// 获取所有当前数据库中的表
        /// </summary>
        /// <returns>当前数据库中的表名数组</returns>
        private List<TableList> GetTableNames()
        {
            SimpleCRUD.SetConnectionString(GetConn(), SqlType);
            List<TableList> tblist = new List<TableList>();
            if (SqlType == 1)
            {
                string sql = "SELECT TABLE_NAME as 'tablename',TABLE_COMMENT as 'tabletitle' FROM information_schema.TABLES WHERE table_schema='" + database + "';";

                ResultView rvm = respository.GetModelList<TableList>(sql, null);

                if (rvm.Result == 1)
                {
                    tblist = rvm.Info;
                }
            }
            else
            {
                string sql = "SELECT d.name tablename,isnull(f.value,'') tabletitle FROM     sysobjects d LEFT JOIN  sys.extended_properties f on  d.id=f.major_id and f.minor_id=0 WHERE    d.xtype = 'U' ";
                ResultView rvm = respository.GetModelList<TableList>(sql, null);

                if (rvm.Result == 1)
                {
                    tblist = rvm.Info;
                }
            }


            return tblist;
        }
        #endregion
        #region 将数据库字段类型转换成C#中使用类型
        /// <summary>
        /// 将数据库字段类型转换成C#中使用类型
        /// </summary>
        /// <param name="typeName">数据库类型</param>
        /// <returns>C#类型</returns>
        private string ChangeTypeName(string typeName)
        {
            string type = null;
            switch (typeName.ToLower())
            {
                case "int":
                    type = "int";
                    break;
                case "bigint":
                    type = "Int64";
                    break;
                case "text":
                case "ntext":
                case "longtext":
                case "char":
                case "varchar":
                case "nchar":
                case "nvarchar":
                    type = "string";
                    break;
                case "numeric":
                case "decimal":
                case "money":
                case "smallmoney":
                    type = "decimal";
                    break;
                case "real":
                    type = "Single";
                    break;
                case "image":
                case "timestamp":
                case "binary":
                case "uniqueidentifier":
                case "varbinary":
                case "xml":
                    type = "Object";
                    break;
                case "tinyint":
                    type = "byte";
                    break;
                case "float":
                    type = "double";
                    break;
                case "date":
                case "datetime":
                case "smalldatetime":
                    type = "DateTime";
                    break;
                case "bit":
                    type = "bool";
                    break;
                default:
                    type = "string";
                    break;
            }
            return type;
        }
        #endregion
        #region 获取表的列信息
        /// <summary>
        /// 获取表的列信息
        /// </summary>
        /// <param name="tebleName">要查询的表</param>
        /// <returns>返回列信息集合</returns>
        private List<ColumnContent> GetColumns(string tebleName)
        {
            List<ColumnContent> list = new List<ColumnContent>();
            if (SqlType == 1)
            {
                string sql = string.Format(@"SELECT COLUMN_KEY as 'key',COLUMN_NAME as 'colname',column_comment as 'comment',
DATA_TYPE as 'typename',COLUMN_DEFAULT,EXTRA FROM INFORMATION_SCHEMA.Columns WHERE table_name='" + tebleName + "' AND table_schema='" + database + "'");


                ResultView rvm = respository.GetModelList<ColumnContent>(sql, null);

                if (rvm.Result == 1)
                {
                    list = rvm.Info;
                }
            }
            else
            {
                string sql = string.Format(@"SELECT  CASE WHEN EXISTS
                                                   (SELECT     1    FROM   sysobjects
                                                    WHERE   xtype = 'PK' AND parent_obj = a.id AND name IN
                                                    (SELECT  name   FROM    sysindexes    WHERE      indid IN
                                                    (SELECT  indid   FROM   sysindexkeys                                
                                                    WHERE  id = a.id AND colid = a.colid))) THEN '1' ELSE '0' END AS 'key',
                                                    CASE WHEN COLUMNPROPERTY(a.id, a.name, 'IsIdentity') = 1 
                                                    THEN '1' ELSE '0' END AS 'identity', a.name AS ColName, c.name AS TypeName, a.length AS 'byte', 
                                                    COLUMNPROPERTY(a.id, a.name, 
                                              'PRECISION') AS 'length', a.xscale, a.isnullable, ISNULL(e.text, '') AS 'default', ISNULL(p.value, '') AS 'comment'
                        FROM         sys.syscolumns AS a INNER JOIN 
                                              sys.sysobjects AS b ON a.id = b.id INNER JOIN
                                              sys.systypes AS c ON a.xtype = c.xtype LEFT OUTER JOIN
                                              sys.syscomments AS e ON a.cdefault = e.id LEFT OUTER JOIN
                                              sys.extended_properties AS p ON a.id = p.major_id AND a.colid = p.minor_id
                        WHERE     (b.name = '" + tebleName + "') AND (c.status <> '1')");

                ResultView rvm = respository.GetModelList<ColumnContent>(sql, null);

                if (rvm.Result == 1)
                {
                    list = rvm.Info;
                }
            }

            return list;
        }
        #endregion
        #endregion

        #endregion
    }
}
