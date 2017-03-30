using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunFlowers.Startup))]
namespace SunFlowers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
