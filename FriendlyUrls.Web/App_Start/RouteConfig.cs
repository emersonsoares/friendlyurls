using System.Web.Mvc;
using System.Web.Routing;

namespace FriendlyUrls.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Notices",
                            url: "{controller}/{slug}",
                            defaults: new { controller = "Notices", action = "Details" });

            routes.MapRoute(name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
