using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WykLab5.Startup))]
namespace WykLab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
