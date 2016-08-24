using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VladoBlog.Startup))]
namespace VladoBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
