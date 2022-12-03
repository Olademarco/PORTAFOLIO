using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PORTAFOLIO.Startup))]
namespace PORTAFOLIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
