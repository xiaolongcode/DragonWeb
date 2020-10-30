using System.Web.Mvc;

namespace Dragon.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
         new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
           new string[] { "Dragon.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}