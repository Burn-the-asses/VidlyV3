using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyV3.Startup))]
namespace VidlyV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
