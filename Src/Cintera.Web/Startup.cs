using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cintera.Web.Startup))]
namespace Cintera.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
