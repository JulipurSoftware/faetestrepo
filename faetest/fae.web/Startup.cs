using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fae.web.Startup))]
namespace fae.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
