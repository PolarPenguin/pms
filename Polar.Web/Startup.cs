using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Polar.Web.Startup))]
namespace Polar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
