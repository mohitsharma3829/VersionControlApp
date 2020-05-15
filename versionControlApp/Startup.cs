using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(versionControlApp.Startup))]
namespace versionControlApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
