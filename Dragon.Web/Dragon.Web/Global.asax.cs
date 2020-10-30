using Dragon.Service.Base.Instrument;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dragon.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleCRUD.SetConnectionString("", 0);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
