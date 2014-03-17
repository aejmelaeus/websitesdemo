using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSitesDemo.Startup))]
namespace WebSitesDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
