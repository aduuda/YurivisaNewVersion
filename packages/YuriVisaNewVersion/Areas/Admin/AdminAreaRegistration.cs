using System.Web.Mvc;

namespace YuriVisaNewVersion.Areas.Admin
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
                "Admin_Login",
                "Admin/{controller}",
                new { controller = "Login",action="Login", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Post", id = UrlParameter.Optional }
            );
        }
    }
}