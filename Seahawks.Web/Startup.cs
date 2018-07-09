using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seahawks.Web.Startup))]
namespace Seahawks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
