using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PLEXEDC.WEB.UI.Startup))]
namespace PLEXEDC.WEB.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
