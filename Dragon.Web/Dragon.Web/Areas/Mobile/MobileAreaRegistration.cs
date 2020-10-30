using System.Web.Mvc;

namespace Dragon.Web.Areas.Mobile
{
    public class MobileAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mobile";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mobile_default",
                "Mobile/{controller}/{action}/{id}",
       new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
           new string[] { "Dragon.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}