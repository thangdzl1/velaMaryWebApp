using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(velaMaryWebApp.Startup))]
namespace velaMaryWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
