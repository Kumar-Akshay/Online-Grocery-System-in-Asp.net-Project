using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineGrocery.Web.Startup))]
namespace OnlineGrocery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
