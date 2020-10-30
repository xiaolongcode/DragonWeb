using Dragon.Service.Base.Instrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Dragon.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleCRUD.SetConnectionString("", 0);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
