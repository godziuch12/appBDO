using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationBDO.Startup))]
namespace ApplicationBDO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
