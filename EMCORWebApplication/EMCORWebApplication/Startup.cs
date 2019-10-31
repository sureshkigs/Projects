using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMCORWebApplication.Startup))]
namespace EMCORWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
