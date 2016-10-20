using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oasis.Web.Startup))]
namespace oasis.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
