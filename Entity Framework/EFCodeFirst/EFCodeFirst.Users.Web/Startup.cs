using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFCodeFirst.Users.Web.Startup))]
namespace EFCodeFirst.Users.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
