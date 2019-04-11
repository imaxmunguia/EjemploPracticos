using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMusicStore.Web.Startup))]
namespace MvcMusicStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
