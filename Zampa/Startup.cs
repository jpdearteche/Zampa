using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zampa.Startup))]
namespace Zampa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
