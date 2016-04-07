using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubERP.Web.Startup))]
namespace ClubERP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
