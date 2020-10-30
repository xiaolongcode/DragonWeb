using Dragon.Model.Base;
using Dragon.Model.DBContext;
using Dragon.Service.Manager;
using Dragon.Service.Manager.Base;
using Dragon.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dragon.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //APIHelper.GetInfo();
            //APIHelper.PostInfo();
            DcUserlogRepository home = new DcUserlogRepository();

            //基类方法
            dc_userlog model = new dc_userlog();
            //model.number = "002";
            //model.name = "张三";
            //model.job = "程序员";
            //model.fashion = "手机端";
            //model.adddate = "1991-05-25";
            //model.id = home.Add(model);
            //model.job = "UI";
            //model.fashion = "PC";
            //model.adddate = "1991-05-25";
            //home.Edit(model);
            //home.Delete<dc_userlog>(3);

            //ResultView rv = home.List<dc_userlog>();
            //PageInfo pagem = home.ListPage<dc_userlog>(" job='程序员'", 1, 2, "id");
            //PageInfo pagem1 = home.ListCount<dc_userlog>("job='程序员'", 2);

            //PageInfo pagem2 = home.ListPage<dc_userlog>("", 1, 2, "id");
            //PageInfo pagem3 = home.ListCount<dc_userlog>("", 2);

            //int num = home.Scalar(" select * from dc_userlog where job='程序员' ");
            //int nums = home.Execute(" update dc_userlog set fashion='shoujiduan' where  job='程序员' ", 2);


            //自定义方法
            model = new dc_userlog();
            model.name = "张三";
            //home.DeleteList(model);
            model = home.SearchModel(model);

            return View();
        }
    }
}