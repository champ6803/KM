using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KM.Web.Startup))]
namespace KM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
