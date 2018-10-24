using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gigo.Backend.Startup))]
namespace Gigo.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
