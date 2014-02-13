using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendlyUrls.Web.Startup))]
namespace FriendlyUrls.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
