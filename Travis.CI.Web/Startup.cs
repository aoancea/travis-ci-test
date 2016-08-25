using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Travis.CI.Web.Startup))]
namespace Travis.CI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
